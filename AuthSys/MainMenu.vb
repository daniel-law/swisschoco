Public Class MainMenu

    Dim WithEvents Timer As New System.Windows.Forms.Timer

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start timer.
        Timer.Start()

        ' Work out what time of day they are loading the form.
        Dim timeOfDay As String
        If DateTime.Now.Hour < 12 Then
            timeOfDay = "Good morning, "
        ElseIf DateTime.Now.Hour < 17 Then
            timeOfDay = "Good afternoon, "
        Else
            timeOfDay = "Good evening, "
        End If

        ' Create personalised greeting.
        WelcomeLabel.Text = timeOfDay & My.User.Name & "."
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Show the Products form.
        Dim Products As New Products
        Products.Show()
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
        currentTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim Login As New LoginForm
        Login.Show()
        Me.Close()
    End Sub
End Class