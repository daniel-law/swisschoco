Imports System.Data.SqlClient
Imports System.Configuration

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

    Private Sub ManufacturingLogsFormButton_Click(sender As Object, e As EventArgs) Handles ManufacturingLogsFormButton.Click
        ' Show the Manufacturing Logs form.
        Dim ManufacturingLogsForm As New ManufacturingLogs
        ManufacturingLogsForm.Show()
    End Sub

    Private Sub FactoriesFormButton_Click(sender As Object, e As EventArgs) Handles FactoriesFormButton.Click
        ' Show the Factories form.
        Dim FactoriesForm As New Factories
        FactoriesForm.Show()
    End Sub

    Private Sub SearchFormButton_Click(sender As Object, e As EventArgs) Handles SearchFormButton.Click
        ' Show the Search form.
        Dim SearchForm As New Search
        SearchForm.Show()
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
                Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
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
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
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
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
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

    Private Sub AddContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddContactToolStripMenuItem.Click
        Dim AddContactForm As AddContact
        AddContact.Show()
    End Sub

    Private Sub InternalInvoicesFormButton_Click(sender As Object, e As EventArgs) Handles InternalInvoicesFormButton.Click
        Dim InternalInvoiesForm As New InternalInvoices
        InternalInvoiesForm.Show()
    End Sub

    Private Sub ViewContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewContactToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Contact ID you wish to view.")

        If IsNumeric(userInput) Then
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Contacts WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim Id As String
                Dim Name As String
                Dim Telephone As String
                Dim Email As String

                While reader.Read
                    Id = reader("Id").ToString()
                    Name = reader("Name").ToString()
                    Telephone = reader("Telephone").ToString()
                    Email = reader("Email").ToString()
                End While

                If Name <> "" Then
                    Dim ViewContactForm As New ViewContact
                    ViewContactForm.Id = Id
                    ViewContactForm.Name = Name
                    ViewContactForm.Telephone = Telephone
                    ViewContactForm.Email = Email
                    ViewContactForm.Show()
                Else
                    MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MsgBox("Unable to view the selected contact.", MessageBoxIcon.Warning)
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

    Private Sub ModifyContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyContactToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Contact ID you wish to modify.")

        If IsNumeric(userInput) Then
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Contacts WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim Id As String
                Dim Name As String
                Dim Telephone As String
                Dim Email As String

                While reader.Read
                    Id = reader("Id").ToString()
                    Name = reader("Name").ToString()
                    Telephone = reader("Telephone").ToString()
                    Email = reader("Email").ToString()
                End While

                If Name <> "" Then
                    Dim ModifyContactForm As New ModifyContact
                    ModifyContact.Id = Id
                    ModifyContact.Name = Name
                    ModifyContact.Email = Email
                    ModifyContact.Telephone = Telephone
                    ModifyContact.Show()
                Else
                    MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MsgBox("Unable to modify the selected contact.", MessageBoxIcon.Warning)
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

    Private Sub DeleteContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteContactToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Product ID you wish to delete.")

        If IsNumeric(userInput) Then
            Dim result As Integer = MessageBox.Show("Are you sure you wish to delete this contact? This action is irreversible.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
                Dim cmd As New SqlCommand

                Try
                    cmd.Connection = connectionString
                    connectionString.Open()
                    cmd.CommandText = "DELETE FROM Contacts WHERE Id = @Id;"
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                    Dim rowsReturned As Integer = cmd.ExecuteNonQuery()

                    If rowsReturned = 0 Then
                        MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                    Else
                        MsgBox("The contact was removed from the database.", MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MsgBox("Unable to delete the selected contact.", MessageBoxIcon.Warning)
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

    Private Sub AddLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddLogToolStripMenuItem.Click
        Dim AddLogForm As New AddLog
        AddLogForm.Show()
    End Sub

    Private Sub ViewLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLogToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Log ID you wish to view.")

        If IsNumeric(userInput) Then
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM ManufacturingLogs WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim Id As String
                Dim FactoryID As String
                Dim UserId As String
                Dim Detail As String

                While reader.Read
                    Id = reader("Id").ToString()
                    FactoryID = reader("FactoryID").ToString()
                    UserId = reader("UserId").ToString()
                    Detail = reader("Detail").ToString()
                End While

                If Detail <> "" Then
                    Dim ViewLogForm As New ViewLog
                    ViewLogForm.Id = Id
                    ViewLogForm.FactoryId = FactoryID
                    ViewLogForm.UserId = UserId
                    ViewLogForm.Detail = Detail
                    ViewLogForm.Show()
                Else
                    MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
            End Try
        ElseIf userInput = "" Then
            ' // The user either pressed the close or cancel button.
            Exit Sub
        Else
            MsgBox("Please double check the ID you have entered, it must be numeric.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ModifyLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyLogToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Log ID you wish to modify.")

        If IsNumeric(userInput) Then
            Try
                Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
                Dim cmd As New SqlCommand

                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM ManufacturingLogs WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim Id As String
                Dim FactoryID As String
                Dim UserId As String
                Dim Detail As String

                While reader.Read
                    Id = reader("Id").ToString()
                    FactoryID = reader("FactoryID").ToString()
                    UserId = reader("UserId").ToString()
                    Detail = reader("Detail").ToString()
                End While

                If Detail <> "" Then
                    Dim ModifyLogForm As New ModifyLog
                    ModifyLogForm.Id = Id
                    ModifyLogForm.FactoryId = FactoryID
                    ModifyLogForm.UserId = UserId
                    ModifyLogForm.Detail = Detail
                    ModifyLogForm.Show()
                Else
                    MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MsgBox("Unable to modify the selected manufacturing log." & ex.Message, MessageBoxIcon.Warning)
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

    Private Sub DeleteLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteLogToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Log ID you wish to delete.")

        If IsNumeric(userInput) Then
            Dim result As Integer = MessageBox.Show("Are you sure you wish to delete this log? This action is irreversible.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
                Dim cmd As New SqlCommand

                Try
                    cmd.Connection = connectionString
                    connectionString.Open()
                    cmd.CommandText = "DELETE FROM ManufacturingLogs WHERE Id = @Id;"
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                    Dim rowsReturned As Integer = cmd.ExecuteNonQuery()

                    If rowsReturned = 0 Then
                        MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                    Else
                        MsgBox("The log was removed from the database.", MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MsgBox("Unable to delete the selected log.", MessageBoxIcon.Warning)
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

    Private Sub AddFactoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFactoryToolStripMenuItem.Click
        Dim AddFactoryForm As New AddFactory
        AddFactoryForm.Show()
    End Sub

    Private Sub ViewFactoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFactoryToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Factory ID you wish to view.")

        If IsNumeric(userInput) Then
            Try
                Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
                Dim cmd As New SqlCommand

                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Factories WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim Name As String
                Dim Locale As String

                While reader.Read
                    Name = reader("Name").ToString()
                    Locale = reader("Locale").ToString()
                End While

                If Name <> "" Then
                    Dim ViewFactoryForm As New ViewFactory
                    ViewFactoryForm.Name = Name
                    ViewFactoryForm.Locale = Locale
                    ViewFactoryForm.Show()
                Else
                    MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MsgBox("Unable to modify the selected factory." & ex.Message, MessageBoxIcon.Warning)
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

    Private Sub ModifyFactoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyFactoryToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Factory ID you wish to modify.")

        If IsNumeric(userInput) Then
            Try
                Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
                Dim cmd As New SqlCommand

                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Factories WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim Id As String
                Dim Name As String
                Dim Locale As String

                While reader.Read
                    Id = reader("Id").ToString()
                    Name = reader("Name").ToString()
                    Locale = reader("Locale").ToString()
                End While

                If Name <> "" Then
                    Dim ModifyFactoryForm As New ModifyFactory
                    ModifyFactoryForm.Id = Id
                    ModifyFactoryForm.Name = Name
                    ModifyFactoryForm.Country = Locale
                    ModifyFactoryForm.Show()
                Else
                    MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MsgBox("Unable to modify the selected factory." & ex.Message, MessageBoxIcon.Warning)
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

    Private Sub DeleteFactoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteFactoryToolStripMenuItem.Click
        Dim userInput As String
        userInput = InputBox("Please enter the Factory ID you wish to delete.")

        If IsNumeric(userInput) Then
            Dim result As Integer = MessageBox.Show("Are you sure you wish to delete this factory? This action is irreversible.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
                Dim cmd As New SqlCommand

                Try
                    cmd.Connection = connectionString
                    connectionString.Open()
                    cmd.CommandText = "DELETE FROM Factories WHERE Id = @Id;"
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userInput
                    Dim rowsReturned As Integer = cmd.ExecuteNonQuery()

                    If rowsReturned = 0 Then
                        MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                    Else
                        MsgBox("The factory was removed from the database.", MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MsgBox("Unable to delete the selected factory.", MessageBoxIcon.Warning)
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
End Class