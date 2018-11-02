Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if the user was authenticated.
        If My.User.IsAuthenticated Then
            MsgBox("Welcome back to the system, " & My.User.Name & ".")
            Me.Label1.Text = "Authenticated " & My.User.Name
        Else
            Me.Label1.Text = "User not authenticated"
        End If

        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            Me.Label2.Text = "User is an Administrator"
        Else
            Me.Label2.Text = "User is not an Administrator"
        End If
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        My.Forms.LoginForm1.ShowDialog()
    End Sub
End Class