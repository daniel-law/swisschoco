Public Class ViewContact
    Public Property Id As String
    Public Property Name As String
    Public Property Telephone As String
    Public Property Email As String

    Private Sub ViewContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Text = Name
        PhoneNumberTextBox.Text = Telephone
        EmailTextBox.Text = Email
    End Sub
End Class