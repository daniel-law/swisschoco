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
                           My.Computer.FileSystem.SpecialDirectories.MyDocuments, "AuthSys.txt")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Register = New Register
        Register.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        ' Show the debug menu.
        Dim DebugForm As New Debug
        Debug.Show()
    End Sub
End Class
