Imports System.Data.SqlClient
Imports System.Configuration

Public Class ModifyContact
    Public Property Id As String
    Public Property Name As String
    Public Property Telephone As String
    Public Property Email As String

    Private Sub ModifyContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Text = Name
        PhoneNumberTextBox.Text = Telephone
        EmailTextBox.Text = Email
    End Sub

    Private Sub ModifyContactButton_Click(sender As Object, e As EventArgs) Handles ModifyContactButton.Click
        If NameTextBox.Text <> "" And PhoneNumberTextBox.Text <> "" And EmailTextBox.Text <> "" Then
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "UPDATE Contacts SET Name = @name, Email = @email, Telephone = @telephone WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameTextBox.Text
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = EmailTextBox.Text
                cmd.Parameters.Add("@telephone", SqlDbType.NVarChar).Value = PhoneNumberTextBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully modified the contact details.", MessageBoxIcon.Information)

                Me.Close()

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