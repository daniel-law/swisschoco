Imports System.Data.SqlClient
Imports System.Configuration

Public Class AddLog
    Private Sub AddLogButton_Click(sender As Object, e As EventArgs) Handles AddLogButton.Click
        If DetailsRichTextBox.Text <> "" Then
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "INSERT INTO ManufacturingLogs (FactoryId, UserId, Detail) VALUES (@factoryId, @userId, @detail);"
                cmd.Parameters.Add("@factoryId", SqlDbType.Int).Value = FactoryIDNumericUpDown.Value
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = ConductedByNumericUpDown.Value
                cmd.Parameters.Add("@detail", SqlDbType.NVarChar).Value = DetailsRichTextBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully added new manufacturing log into the database.", MessageBoxIcon.Information)

                ' Clear entered details.
                FactoryIDNumericUpDown.Value = 1
                ConductedByNumericUpDown.Value = 1
                DetailsRichTextBox.Clear()
                FactoryIDNumericUpDown.Select()

            Catch ex As Exception
                MsgBox("Program encountered an error connecting to the database, ensure that the contact and factory exist before contacting your systems admin.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            End Try
        Else
            MsgBox("Please ensure all the details are filled out.", MessageBoxIcon.Information)
        End If
    End Sub
End Class