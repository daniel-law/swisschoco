Public Class ViewFactory
    Public Property Name As String
    Public Property Locale As String

    Private Sub ViewFactory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Text = Name
        LocaleTextBox.Text = Locale
    End Sub
End Class