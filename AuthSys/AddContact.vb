Imports System.Data.SqlClient
Imports System.Configuration

Public Class AddContact
    Private Sub AddContactButton_Click(sender As Object, e As EventArgs) Handles AddContactButton.Click
        If NameTextBox.Text <> "" And EmailTextBox.Text <> "" And PhoneNumberTextBox.Text <> "" Then
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "INSERT INTO Contacts (Name, Telephone, Email) VALUES (@name, @telephone, @email);"
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameTextBox.Text
                cmd.Parameters.Add("@telephone", SqlDbType.NVarChar).Value = PhoneNumberTextBox.Text
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = EmailTextBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully added new contact into the database.", MessageBoxIcon.Information)

                ' Clear entered details.
                NameTextBox.Clear()
                PhoneNumberTextBox.Clear()
                EmailTextBox.Clear()
                NameTextBox.Select()

            Catch ex As Exception
                MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            End Try
        Else
            MsgBox("Please ensure all the details are filled out.", MessageBoxIcon.Information)
        End If
    End Sub
End Class