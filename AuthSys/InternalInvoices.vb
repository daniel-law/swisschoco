Imports System.Data.SqlClient

Public Class InternalInvoices

    Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Dim cmd As New SqlCommand

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
            ItemsListBox.Items.Add("Id: " & Id & ", " & Name & ", " & Price & ", x" & userInputQuality)
        End If
    End Sub

    Private Sub InternalInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' // Get the first record in InternalInvoices.
        Dim queryContactDetails As Boolean
        Dim queryContactId As Boolean

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT TOP 1 * FROM InternalInvoices;"
            Dim reader As SqlDataReader = cmd.ExecuteReader

            Dim InvoiceId As String
            Dim ContactId As String
            Dim TotalCost As String

            While reader.Read
                InvoiceId = reader("Id").ToString()
                ContactId = reader("ContactId").ToString()
                TotalCost = reader("TotalCost").ToString()
            End While

            If ContactId <> "" Then
                InvoiceIDTextBox.Text = InvoiceId
                ContactIDTextBox.Text = ContactId
                TotalCostNumericUpDown.Value = TotalCost
                queryContactDetails = True
                queryContactId = ContactId
            End If

            connectionString.Close()

        Catch ex As Exception
            MsgBox("Unable to view the selected invoice." & ex.Message, MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            connectionString.Close()
        End Try

        If queryContactDetails = True Then
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Contacts WHERE Id = @Id;"
                cmd.Parameters.Add("Id", SqlDbType.Int).Value = queryContactId
                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read
                    ContactNameTextBox.Text = reader("Name").ToString()
                End While

                connectionString.Close()

            Catch ex As Exception
                MsgBox("Unable to find the selected contact." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                connectionString.Close()
            End Try
        End If
    End Sub
End Class