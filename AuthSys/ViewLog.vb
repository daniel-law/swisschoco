Public Class ViewLog
    Public Property Id As String
    Public Property FactoryId As String
    Public Property UserId As String
    Public Property Detail As String

    ' This will load the parameters to view the manufacturing log.
    Private Sub ViewLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FactoryIDTextBox.Text = FactoryId
        ConductedByTextBox.Text = UserId
        DetailsRichTextBox.Text = Detail
    End Sub
End Class