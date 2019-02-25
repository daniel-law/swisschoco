Imports System.Data.SqlClient
Imports System.Configuration

Public Class InternalInvoices

    Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
    Dim cmd As New SqlCommand

    Dim currentId As Integer
    Dim Values As New List(Of Dictionary(Of String, String))()
    Dim errorNotify As Boolean = True
    Dim factorySelected As Boolean
    Dim itemAdded As Boolean
    Dim refreshInvoice As Boolean

    Private Sub loadInvoice(ByVal SQLQuery As String)
        ' // Cleanup.
        Values.Clear()
        ItemsListBox.Items.Clear()

        ' // Get the record from InternalInvoices.
        Dim queryAssociatedDetails As Boolean
        Dim queryContactId As Integer
        Dim queryFactoryId As Integer

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = SQLQuery
            Dim reader As SqlDataReader = cmd.ExecuteReader

            Dim InvoiceId As String
            Dim ContactId As String
            Dim FactoryId As String
            Dim Status As Integer

            While reader.Read
                InvoiceId = reader("Id").ToString()
                ContactId = reader("ContactId").ToString()
                FactoryId = reader("FactoryId").ToString()
                Status = reader("Status")
            End While

            If ContactId <> "" Then
                InvoiceIDTextBox.Text = InvoiceId
                ContactsNumericUpDown.Value = ContactId
                queryAssociatedDetails = True
                currentId = InvoiceId

                If Status = 0 Then
                    StatusComboBox.SelectedIndex = 0
                ElseIf Status = 1 Then
                    StatusComboBox.SelectedIndex = 1
                Else
                    StatusComboBox.SelectedIndex = 2
                End If

                queryContactId = ContactId
                queryFactoryId = FactoryId
            End If

        Catch ex As Exception
            MsgBox("Unable to view the selected invoice." & ex.Message, MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try

        If queryAssociatedDetails = True Then
            ' Get the contact details associated with the invoice.
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Contacts WHERE Id = @Id;"
                cmd.Parameters.Add("Id", SqlDbType.Int).Value = queryContactId
                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read
                    ContactNameTextBox.Text = reader("Name").ToString()
                End While

            Catch ex As Exception
                MsgBox("Unable to find the contact for the internal invoice." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try

            ' Get the factory details associated with the invoice.
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Factories WHERE Id = @Id;"
                cmd.Parameters.Add("Id", SqlDbType.Int).Value = queryFactoryId
                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read
                    FactoryIDTextBox.Text = reader("Id").ToString()
                    NameTextBox.Text = reader("Name")
                    CountryTextBox.Text = reader("Locale")
                End While

            Catch ex As Exception
                MsgBox("Unable to find the factory for the internal invoice." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try

            ' Get order items associated with the invoice.
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM InvoiceItem WHERE InvoiceId = @Id;"
                cmd.Parameters.Add("Id", SqlDbType.Int).Value = InvoiceIDTextBox.Text
                Dim reader As SqlDataReader = cmd.ExecuteReader
                Dim netTotal As Decimal

                While reader.Read
                    ' Load the items into the List.
                    Values.Add(New Dictionary(Of String, String) From {
                        {"id", reader("ProductId")}, {"quantity", reader("Quantity")}, {"cost", reader("TotalCost")}})
                    netTotal = netTotal + reader("TotalCost")
                End While

                TotalCostNumericUpDown.Value = netTotal

            Catch ex As Exception
                MsgBox("Unable to find the products associated with this invoice." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try

            ' Retrieve the details of the products.
            For Each Value As Dictionary(Of String, String) In Values
                Try
                    cmd.Connection = connectionString
                    connectionString.Open()
                    cmd.CommandText = "SELECT * FROM Products WHERE Id = @Id;"
                    cmd.Parameters.Add("Id", SqlDbType.Int).Value = Value("id")
                    Dim reader As SqlDataReader = cmd.ExecuteReader

                    While reader.Read
                        ItemsListBox.Items.Add("Id: " & Value("id") & ", " & reader("Name") & ", " & reader("Price").ToString() & ", x" & Value("quantity"))
                    End While

                Catch ex As Exception
                    ' DB issues, exit.
                    Exit Sub
                Finally
                    cmd.Parameters.Clear()
                    connectionString.Close()
                End Try
            Next
        Else
            MsgBox("There is not another internal invoice.", MessageBoxIcon.Warning)
            loadInvoice("SELECT TOP 1 * FROM InternalInvoices;")
        End If
    End Sub

    Private Sub InternalInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInvoice("SELECT TOP 1 * FROM InternalInvoices;")
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        loadInvoice("SELECT TOP 1 * FROM InternalInvoices WHERE Id > " & currentId & " ORDER BY Id;")
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        loadInvoice("SELECT TOP 1 * FROM InternalInvoices WHERE Id < " & currentId & " ORDER BY Id DESC;")
    End Sub

    Private Sub cleanup()
        PreviousButton.Enabled = True
        NextButton.Enabled = True
        SearchButton.Enabled = True
        NewInvoiceButton.Enabled = True
        DeleteInvoiceButton.Enabled = True
        SaveChangesButton.Visible = True
        CancelButton.Visible = False
        CreateInvoiceButton.Visible = False

        loadInvoice("SELECT TOP 1 * FROM InternalInvoices;")
    End Sub

    Private Sub SelectFactoryButton_Click(sender As Object, e As EventArgs) Handles SelectFactoryButton.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Factory ID you wish to set.")

        If IsNumeric(userInput) Then

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Factories WHERE Id = @FactoryId;"
                cmd.Parameters.Add("@FactoryId", SqlDbType.Int).Value = userInput
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim Id As String
                Dim Name As String
                Dim Locale As String

                While reader.Read
                    Id = reader("Id").ToString()
                    Name = reader("Name").ToString()
                    Locale = reader("Locale").ToString()
                End While

                If Name <> "" Then
                    FactoryIDTextBox.Text = Id
                    NameTextBox.Text = Name
                    CountryTextBox.Text = Locale
                    factorySelected = True
                Else
                    MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MsgBox("Unable to find the selected factory." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try
        ElseIf userInput = "" Then
            ' // The user either pressed the close or cancel button.
            Exit Sub
        Else
            MsgBox("Please double check the ID you have entered, it must be numeric.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SelectItemsButton_Click(sender As Object, e As EventArgs) Handles SelectItemsButton.Click
        Dim userInputProduct As String
        userInputProduct = InputBox("Please enter the Product ID you wish to add.")

        Dim Id As String
        Dim Name As String
        Dim Price As String
        Dim isValidToAdd As Boolean

        ' Check whether the item is currently in the order or not.
        For Each Item In Values
            If Item("id") = userInputProduct Then
                MsgBox("Cannot add the same item to the order again.", MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        ' The item can be added to the invoice if it isn't already present.
        If IsNumeric(userInputProduct) Then

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Products WHERE Id = @ProductId;"
                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = userInputProduct
                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read
                    Id = reader("Id").ToString()
                    Name = reader("Name").ToString()
                    Price = reader("Price").ToString()
                End While

                If Name <> "" Then
                    isValidToAdd = True
                    itemAdded = True
                Else
                    MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                    Exit Sub
                End If

                connectionString.Close()

            Catch ex As Exception
                MsgBox("Unable to find the selected product." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try
        ElseIf userInputProduct = "" Then
            ' // The user either pressed the close or cancel button.
            Exit Sub
        Else
            MsgBox("Please double check the ID you have entered, it must be numeric.", MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim userInputQuantity As String
        userInputQuantity = InputBox("Please enter the quantity you wish to add.")

        If IsNumeric(userInputQuantity) And isValidToAdd = True Then
            Values.Add(New Dictionary(Of String, String) From {
                {"id", Id}, {"quantity", userInputQuantity}, {"cost", (Price * userInputQuantity)}})

            ItemsListBox.Items.Add("Id: " & Id & ", " & Name & ", " & Price & ", x" & userInputQuantity)
            TotalCostNumericUpDown.Value = TotalCostNumericUpDown.Value + (Price * userInputQuantity)
        End If
    End Sub

    Private Sub SaveChangesButton_Click(sender As Object, e As EventArgs) Handles SaveChangesButton.Click
        ' Re-write the invoice details to InternalInvoices and then to InvoiceItem.

        ' Check whether the contact exists.
        Dim contactExists As Boolean
        Dim updateAssociatedItems As Boolean

        If ContactsNumericUpDown.Value <> 0 Then
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Contacts WHERE Id = @Id;"
                cmd.Parameters.Add("Id", SqlDbType.Int).Value = ContactsNumericUpDown.Value
                Dim reader As SqlDataReader = cmd.ExecuteReader
                Dim testData As String

                While reader.Read
                    testData = reader("Name").ToString()
                End While

                If testData <> "" Then
                    contactExists = True
                    errorNotify = True
                Else
                    MsgBox("The selected contact does not exist.", MessageBoxIcon.Warning)
                    contactExists = False
                    errorNotify = False
                End If

            Catch ex As Exception
                MsgBox("Unable to find the selected contact." & ex.Message, MessageBoxIcon.Warning)
                contactExists = False
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try
        End If

        ' Check the validation is met and then carry out the update.
        If ItemsListBox.Items.Count >= 1 And FactoryIDTextBox.Text <> "" And contactExists = True Then
            ' Update the InternalInvoices table.
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "UPDATE InternalInvoices SET ContactId = @contactId, TotalCost = @totalCost, FactoryId = @factoryId, Status = @status WHERE Id = @Id;"
                cmd.Parameters.Add("Id", SqlDbType.Int).Value = currentId
                cmd.Parameters.Add("contactId", SqlDbType.Int).Value = ContactsNumericUpDown.Value
                cmd.Parameters.Add("totalCost", SqlDbType.Int).Value = TotalCostNumericUpDown.Value
                cmd.Parameters.Add("factoryId", SqlDbType.Int).Value = FactoryIDTextBox.Text
                cmd.Parameters.Add("status", SqlDbType.Int).Value = StatusComboBox.SelectedIndex
                cmd.ExecuteNonQuery()

                updateAssociatedItems = True
                refreshInvoice = True
                MsgBox("Sucessfully modified the Internal Invoice details.", MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox("Unable to find the selected internal invoice." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try

        ElseIf errorNotify = True Then
            MsgBox("Please ensure all the details are correctly filled out.", MessageBoxIcon.Information)
        End If

        If updateAssociatedItems = True Then
            For Each Item In Values
                Try
                    cmd.Connection = connectionString
                    connectionString.Open()
                    cmd.CommandText = "UPDATE InvoiceItem SET ProductId = @productId, Quantity = @quantity, TotalCost = @totalCost WHERE InvoiceId = @invoiceId AND ProductId = @productId IF @@ROWCOUNT=0 INSERT INTO InvoiceItem (ProductId, InvoiceId, Quantity, TotalCost) VALUES (@productId, @invoiceId, @quantity, @totalCost);"
                    cmd.Parameters.Add("@productId", SqlDbType.Int).Value = Convert.ToInt32(Item("id"))
                    cmd.Parameters.Add("@invoiceId", SqlDbType.Int).Value = Convert.ToInt32(InvoiceIDTextBox.Text)
                    cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = Convert.ToInt32(Item("quantity"))
                    cmd.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = Convert.ToDecimal(Item("cost"))
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox("Unable to query the associated invoice items." & ex.Message, MessageBoxIcon.Warning)
                    ' DB issues, exit.
                    Exit Sub
                Finally
                    cmd.Parameters.Clear()
                    connectionString.Close()
                End Try
            Next
        End If

        ' Refresh the invoice.
        If refreshInvoice = True Then
            loadInvoice("SELECT * FROM InternalInvoices WHERE Id = " & currentId)
            refreshInvoice = False
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If SearchTextBox.Text <> "" And IsNumeric(SearchTextBox.Text) Then
            loadInvoice("SELECT * FROM InternalInvoices WHERE Id = " & SearchTextBox.Text & ";")
        Else
            MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DeleteInvoiceButton_Click(sender As Object, e As EventArgs) Handles DeleteInvoiceButton.Click
        Dim result As Integer = MessageBox.Show("Are you sure you wish to delete this internal invoice? This action is irreversible.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim clearInvoice As Boolean

        If result = DialogResult.Yes Then
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "DELETE FROM InternalInvoices WHERE Id = @Id; DELETE FROM InvoiceItem WHERE InvoiceId = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = currentId
                Dim rowsReturned As Integer = cmd.ExecuteNonQuery()

                MsgBox("The internal invoice was removed from the database.", MessageBoxIcon.Information)
                clearInvoice = True

            Catch ex As Exception
                MsgBox("Unable to delete the selected internal invoice.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try

            If clearInvoice = True Then
                ' Must move to another record otherwise deleted record will still be shown in the form.
                loadInvoice("SELECT TOP 1 * FROM InternalInvoices;")
            End If
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        cleanup()
    End Sub

    Private Sub NewInvoiceButton_Click(sender As Object, e As EventArgs) Handles NewInvoiceButton.Click
        InvoiceIDTextBox.Text = "New"
        ContactNameTextBox.Clear()
        TotalCostNumericUpDown.Value = 0.00
        FactoryIDTextBox.Clear()
        NameTextBox.Clear()
        CountryTextBox.Clear()
        Values.Clear()
        ItemsListBox.Items.Clear()

        PreviousButton.Enabled = False
        NextButton.Enabled = False
        SearchButton.Enabled = False
        NewInvoiceButton.Enabled = False
        DeleteInvoiceButton.Enabled = False
        SaveChangesButton.Visible = False
        CancelButton.Visible = True
        CreateInvoiceButton.Visible = True
    End Sub

    Private Sub CreateInvoiceButton_Click(sender As Object, e As EventArgs) Handles CreateInvoiceButton.Click
        If factorySelected = True And itemAdded = True Then
            Dim addAssociatedItems As Boolean

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "INSERT INTO InternalInvoices (FactoryId, ContactId, TotalCost, Status) VALUES (@factoryId, @contactId, @totalCost, @status);"
                cmd.Parameters.Add("@factoryId", SqlDbType.Int).Value = FactoryIDTextBox.Text
                cmd.Parameters.Add("@contactId", SqlDbType.Int).Value = ContactsNumericUpDown.Value
                cmd.Parameters.Add("@totalCost", SqlDbType.NVarChar).Value = TotalCostNumericUpDown.Value
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = StatusComboBox.SelectedIndex
                Dim result = cmd.ExecuteNonQuery()

                MsgBox("Sucessfully added new internal invoice into the database.", MessageBoxIcon.Information)
                addAssociatedItems = True

            Catch ex As Exception
                MsgBox("Unable to create the internal invoice.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try

            If addAssociatedItems = True Then
                Try
                    ' Get the InvoiceId in question.
                    cmd.Connection = connectionString
                    connectionString.Open()
                    cmd.CommandText = "SELECT TOP 1 Id FROM InternalInvoices ORDER BY ID DESC"
                    Dim reader As SqlDataReader = cmd.ExecuteReader

                    While reader.Read
                        InvoiceIDTextBox.Text = reader("Id").ToString()
                    End While

                Catch ex As Exception
                    MsgBox("Unable to find the last added internal invoice, so unable to add the associated products to it.", MessageBoxIcon.Warning)
                    ' DB issues, exit.
                    Exit Sub
                Finally
                    cmd.Parameters.Clear()
                    connectionString.Close()
                End Try

                For Each Item In Values
                    Try
                        cmd.Connection = connectionString
                        connectionString.Open()
                        cmd.CommandText = "INSERT INTO InvoiceItem (ProductId, InvoiceId, Quantity, TotalCost) VALUES (@productId, @invoiceId, @quantity, @totalCost)"
                        cmd.Parameters.Add("@productId", SqlDbType.Int).Value = Convert.ToInt32(Item("id"))
                        cmd.Parameters.Add("@invoiceId", SqlDbType.Int).Value = Convert.ToInt32(InvoiceIDTextBox.Text)
                        cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = Convert.ToInt32(Item("quantity"))
                        cmd.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = Convert.ToDecimal(Item("cost"))
                        cmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MsgBox("Unable to add the associated invoice items." & ex.Message, MessageBoxIcon.Warning)
                        ' DB issues, exit.
                        Exit Sub
                    Finally
                        cmd.Parameters.Clear()
                        connectionString.Close()
                    End Try
                Next
            End If

            cleanup()
        Else
            MsgBox("Please ensure the details are filled out properly.", MessageBoxIcon.Warning)
        End If
    End Sub
End Class