Imports System.Data.SqlClient

Public Class InternalInvoices

    Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Dim cmd As New SqlCommand

    Dim currentId As Integer
    Dim Values As New List(Of Dictionary(Of String, String))()
    Dim errorNotify As Boolean = True

    Private Sub InternalInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' // Get the first record in InternalInvoices.
        Dim queryAssociatedDetails As Boolean

        Dim queryContactId As Integer
        Dim queryFactoryId As Integer

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT TOP 1 * FROM InternalInvoices;"
            Dim reader As SqlDataReader = cmd.ExecuteReader

            Dim InvoiceId As String
            Dim ContactId As String
            Dim TotalCost As String
            Dim FactoryId As String

            While reader.Read
                InvoiceId = reader("Id").ToString()
                ContactId = reader("ContactId").ToString()
                FactoryId = reader("FactoryId").ToString()
                TotalCost = reader("TotalCost").ToString()
            End While

            If ContactId <> "" Then
                InvoiceIDTextBox.Text = InvoiceId
                ContactsNumericUpDown.Value = ContactId
                TotalCostNumericUpDown.Value = TotalCost
                queryAssociatedDetails = True
                currentId = InvoiceId

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
            Dim retrievedProduct_Id As String
            Dim retrievedProduct_Name As String
            Dim retrievedProduct_Price As String

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
                        {"id", reader("ProductId")}, {"quantity", reader("Quantity")}})
                    retrievedProduct_Id = reader("ProductId")
                    ' TODO: Query the specific details to show to the user.
                    ' Add the item to the listbox.
                    'ItemsListBox.Items.Add("Id: " & reader("ProductId") & ", " & retrievedProduct_Name & ", " & retrievedProduct_Price & ", x" & reader("Quantity"))
                    ItemsListBox.Items.Add("Id: " & reader("ProductId") & reader("Quantity"))
                    netTotal = netTotal + reader("TotalCost")
                End While

            Catch ex As Exception
                MsgBox("Unable to find the products associated with this invoice." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try
        End If
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

        Dim userInputQuality As String
        userInputQuality = InputBox("Please enter the quantity you wish to add.")

        If IsNumeric(userInputQuality) And isValidToAdd = True Then
            Values.Add(New Dictionary(Of String, String) From {
                {"id", Id}, {"quantity", userInputQuality}})

            ' DEBUG
            For Each value As Dictionary(Of String, String) In Values
                MsgBox(value("id"))
                MsgBox(value("quantity"))
            Next

            ItemsListBox.Items.Add("Id: " & Id & ", " & Name & ", " & Price & ", x" & userInputQuality)
        End If
    End Sub

    Private Sub SaveChangesButton_Click(sender As Object, e As EventArgs) Handles SaveChangesButton.Click
        ' Re-write the invoice details to InternalInvoices and then to InvoiceItem.
        ' Check whether the contact exists.
        Dim contactExists As Boolean

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
        If TotalCostNumericUpDown.Value <> 0 And ItemsListBox.Items.Count >= 1 And FactoryIDTextBox.Text <> "" And contactExists = True Then
            ' Update the InternalInvoices table.
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "UPDATE InternalInvoices SET ContactId = @contactId, TotalCost = @TotalCost, FactoryId = @FactoryId WHERE Id = @Id;"
                cmd.Parameters.Add("Id", SqlDbType.Int).Value = currentId
                cmd.Parameters.Add("ContactId", SqlDbType.Int).Value = ContactsNumericUpDown.Value
                cmd.Parameters.Add("TotalCost", SqlDbType.Int).Value = TotalCostNumericUpDown.Value
                cmd.Parameters.Add("FactoryId", SqlDbType.Int).Value = FactoryIDTextBox.Text
                cmd.ExecuteNonQuery()

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
    End Sub
End Class