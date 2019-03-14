Imports System.Data.SqlClient
Imports System.Configuration

Public Class ModifyLog

    Public Property Id As String
    Public Property FactoryId As String
    Public Property UserId As String
    Public Property Detail As String

    ' This will load the manufacturing log parameters into the form.
    Private Sub ModifyLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FactoryIDTextBox.Text = FactoryId
        ConductedByTextBox.Text = UserId
        DetailsRichTextBox.Text = Detail
    End Sub

    ' This will modify a manufacturing log if the validation is met.
    Private Sub ModifyLogButton_Click(sender As Object, e As EventArgs) Handles ModifyLogButton.Click
        If FactoryIDTextBox.Text <> "" And ConductedByTextBox.Text <> "" And DetailsRichTextBox.Text <> "" Then
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "UPDATE ManufacturingLogs SET UserId = @userId, Detail = @detail, FactoryId = @factoryId WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = ConductedByTextBox.Text
                cmd.Parameters.Add("@detail", SqlDbType.NVarChar).Value = DetailsRichTextBox.Text
                cmd.Parameters.Add("@factoryId", SqlDbType.Int).Value = FactoryIDTextBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully modified the manufacturing log details.", MessageBoxIcon.Information)

                Me.Close()

            Catch ex As Exception
                MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            End Try
        End If
    End Sub
End Class