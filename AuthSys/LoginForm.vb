Public Class LoginForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim samplePrincipal As New IPrincipal(
    Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)
        Me.PasswordTextBox.Text = ""
        If (Not samplePrincipal.Identity.IsAuthenticated) Then
            ' The user is still not validated.
            MsgBox("The username and password is incorrect.")
            ' Log event.
            Try
                Dim filePath As String
                filePath = System.IO.Path.Combine(
                           My.Computer.FileSystem.SpecialDirectories.MyDocuments, "SwissChoco Log.txt")
                My.Computer.FileSystem.WriteAllText(filePath, Environment.NewLine & "[LOGON_AUTH] " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & " Login attempt FAIL with username " & UsernameTextBox.Text & ".", True)
            Catch fileException As Exception
                MsgBox("Program encountered an error writing files. You should urgently contact your systems admin.")
            End Try

        Else
            ' Update the current principal.
            My.User.CurrentPrincipal = samplePrincipal
            Dim MainMenu = New MainMenu
            MainMenu.Show()
            Me.Hide()
        End If
    End Sub

    ' Shows a new register form.
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim Register = New Register
        Register.Show()
    End Sub
End Class
