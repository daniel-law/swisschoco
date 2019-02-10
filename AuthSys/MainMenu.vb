﻿Imports System.Data.SqlClient

Public Class MainMenu

    Dim WithEvents Timer As New System.Windows.Forms.Timer
    Dim lastCursorPos As Point
    Dim keyPressed As Boolean

    Private Sub getInactivity(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Static inactivityTimer As Integer
        Dim currentCursorPos As Point

        inactivityTimer += 1   ' // One second has elapsed.
        currentCursorPos = Cursor.Position

        ' // Check whether cursor has moved.
        If (currentCursorPos.X <> lastCursorPos.X) Or (currentCursorPos.Y <> lastCursorPos.Y) Then
            lastCursorPos = currentCursorPos
            inactivityTimer = 0
        Else
            ' // The cursor position is the same, check for key presses.
            If keyPressed = True Then
                inactivityTimer = 0
                keyPressed = False
            End If
        End If

        ' // The user will be logged off if they are inactive for 5 minutes.
        If inactivityTimer = 300 Then
            logout()
        End If
    End Sub

    Private Sub MainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        keyPressed = True
    End Sub

    Private Sub logout()
        ' De-authenticate the current user by providing a set of blank credentials.
        Dim samplePrincipal As New IPrincipal("", "")
        My.User.CurrentPrincipal = samplePrincipal

        ' Hide all open forms, to prevent any un-authenticated changes by guests.
        For Each Form In My.Application.OpenForms
            Form.Hide()
        Next

        ' Open a login form for future re-authentication.
        LoginForm.Show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start timer.
        Timer.Interval = 1000
        Timer.Start()
        ' Setup last cursor position.
        lastCursorPos = Cursor.Position

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

    Private Sub ProductsFormButton_Click(sender As Object, e As EventArgs) Handles ProductsFormButton.Click
        ' Show the Products form.
        Dim ProductsForm As New Products
        ProductsForm.Show()
    End Sub

    Private Sub ContactsFormButton_Click(sender As Object, e As EventArgs) Handles ContactsFormButton.Click
        ' Show the Contacts form.
        Dim ContactsForm As New Contacts
        ContactsForm.Show()
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
        currentTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        logout()
    End Sub

    Private Sub DeleteProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteProductToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Product ID you wish to delete.")

        If IsNumeric(userInput) Then
            Dim result As Integer = MessageBox.Show("Are you sure you wish to delete this product? This action is irreversible.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                Dim cmd As New SqlCommand

                Try
                    cmd.Connection = connectionString
                    connectionString.Open()
                    cmd.CommandText = "DELETE FROM Products WHERE Id = @Id;"
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                    Dim rowsReturned As Integer = cmd.ExecuteNonQuery()

                    If rowsReturned = 0 Then
                        MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                    Else
                        MsgBox("The product was removed from the database.", MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MsgBox("Unable to delete the selected product.", MessageBoxIcon.Warning)
                    ' DB issues, exit.
                    Exit Sub
                End Try
            End If
        ElseIf userInput = "" Then
            ' // The user either pressed the close or cancel button.
            Exit Sub
        Else
            MsgBox("Please double check the ID you have entered, it must be numeric.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ViewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Product ID you wish to view.")

        If IsNumeric(userInput) Then
            Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Products WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim Id As String
                Dim Name As String
                Dim Price As String
                Dim Description As String
                Dim Weight As String
                Dim Ingredients As String

                While reader.Read
                    Id = reader("Id").ToString()
                    Name = reader("Name").ToString()
                    Price = reader("Price").ToString()
                    Description = reader("Description").ToString()
                    Weight = reader("Weight").ToString()
                    Ingredients = reader("Ingredients").ToString()
                End While

                If Name <> "" Then
                    Dim ViewProductForm As New ViewProduct
                    ViewProductForm.Id = Id
                    ViewProductForm.Name = Name
                    ViewProductForm.Price = Price
                    ViewProductForm.Description = Description
                    ViewProductForm.Weight = Weight
                    ViewProductForm.Ingredients = Ingredients
                    ViewProductForm.Show()
                Else
                    MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MsgBox("Unable to view the selected product.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            End Try
        ElseIf userInput = "" Then
            ' // The user either pressed the close or cancel button.
            Exit Sub
        Else
            MsgBox("Please double check the ID you have entered, it must be numeric.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ModifyProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyProductToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Product ID you wish to modify.")

        If IsNumeric(userInput) Then
            Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Products WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim Id As String
                Dim Name As String
                Dim Price As String
                Dim Description As String
                Dim Weight As String
                Dim Ingredients As String

                While reader.Read
                    Id = reader("Id").ToString()
                    Name = reader("Name").ToString()
                    Price = reader("Price").ToString()
                    Description = reader("Description").ToString()
                    Weight = reader("Weight").ToString()
                    Ingredients = reader("Ingredients").ToString()
                End While

                If Name <> "" Then
                    Dim ViewProductForm As New ModifyProduct
                    ModifyProduct.Id = Id
                    ModifyProduct.Name = Name
                    ModifyProduct.Price = Price
                    ModifyProduct.Description = Description
                    ModifyProduct.Weight = Weight
                    ModifyProduct.Ingredients = Ingredients
                    ModifyProduct.Show()
                Else
                    MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MsgBox("Unable to modify the selected product.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            End Try
        ElseIf userInput = "" Then
            ' // The user either pressed the close or cancel button.
            Exit Sub
        Else
            MsgBox("Please double check the ID you have entered, it must be numeric.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AddProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductToolStripMenuItem.Click
        Dim AddProductForm As AddProduct
        AddProduct.Show()
    End Sub
End Class