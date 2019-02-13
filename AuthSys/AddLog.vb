Imports System.Data.SqlClient

Public Class AddLog
    Private Sub AddLogButton_Click(sender As Object, e As EventArgs) Handles AddLogButton.Click
        If FactoryIDTextBox.Text <> "" And ConductedByTextBox.Text <> "" And DetailsRichTextBox.Text <> "" Then
            Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "INSERT INTO ManufacturingLogs (FactoryId, UserId, Detail) VALUES (@factoryId, @userId, @detail);"
                cmd.Parameters.Add("@factoryId", SqlDbType.Int).Value = FactoryIDTextBox.Text
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = ConductedByTextBox.Text
                cmd.Parameters.Add("@detail", SqlDbType.NVarChar).Value = DetailsRichTextBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully added new manufacturing log into the database.", MessageBoxIcon.Information)

                ' Clear entered details.
                FactoryIDTextBox.Clear()
                ConductedByTextBox.Clear()
                DetailsRichTextBox.Clear()
                FactoryIDTextBox.Select()

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