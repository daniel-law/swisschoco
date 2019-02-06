Public Class Debug
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if the user was authenticated.
        If My.User.IsAuthenticated Then
            MsgBox("The current authenticated user is: " & My.User.Name & ".")
        Else
            MsgBox("No user is currently authenticated :(")
        End If

        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            MsgBox("User is an admin.")
        Else
            MsgBox("User is not an admin.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ProductsForm As New Products
        ProductsForm.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim MainMenuForm As New MainMenu
        MainMenu.Show()
    End Sub
End Class