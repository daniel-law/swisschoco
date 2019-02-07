Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Register

    Dim Username As String
    Dim Role As String
    Dim FullName As String

    Private Function CreateNewUser(ByVal Username As String, Salt As String, HashedPassword As String)
        ' Include their name in data entry.
        FullName = FullNameTextBox.Text

        ' Determine which role the new user will be.
        If RoleComboBox.SelectedIndex = 0 Then Role = "User"
        If RoleComboBox.SelectedIndex = 1 Then Role = "Administrator"

        ' Code that will create a new user.
        Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim cmd As New SqlCommand

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "INSERT INTO Users (Username, Hash, Salt, FullName, Role) VALUES (@username, @hash, @salt, @fullname, @role);"
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = Username
            cmd.Parameters.Add("@hash", SqlDbType.NVarChar).Value = HashedPassword
            cmd.Parameters.Add("@salt", SqlDbType.NVarChar).Value = Salt
            cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = FullName
            cmd.Parameters.Add("@role", SqlDbType.NVarChar).Value = Role
            cmd.ExecuteNonQuery()
            connectionString.Close()

            MsgBox("User sucessfully created!", MessageBoxIcon.Information)

            ' Clear textboxes and focus cursor.
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            ConfirmPasswordTextBox.Clear()
            FullNameTextBox.Clear()
            RoleComboBox.SelectedIndex = -1
            UsernameTextBox.Select()
        Catch ex As Exception
            MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
        End Try

        ' Log event.
        Try
            Dim filePath As String
            filePath = System.IO.Path.Combine(
                       My.Computer.FileSystem.SpecialDirectories.MyDocuments, "AuthSys.txt")
            My.Computer.FileSystem.WriteAllText(filePath, Environment.NewLine & "[LOGON_CREATE] " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & " Account created with a username of " & UsernameTextBox.Text & ".", True)
        Catch fileException As Exception
            MsgBox("Program encountered an error writing files. You should urgently contact your systems admin.", MessageBoxIcon.Warning)
        End Try
    End Function

    Private Sub CheckUsernameUniqueness()
        ' Code that will check whether a user exists or not.
        Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim cmd As New SqlCommand

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM Users WHERE Username = '" & Username & "';"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
            ' DB issues, exit proc.
            Exit Sub
        End Try

        If cmd.ExecuteScalar <> 0 Then
            MsgBox("User already exists, choose a unique username!", MessageBoxIcon.Information)
        Else
            ' Generate a new unique salt for a password.
            Dim saltBytes() As Byte
            Dim saltValue As String
            ' Byte array will hold the salt.
            saltBytes = New Byte(16) {}

            ' New random number generator.
            Dim rng As RNGCryptoServiceProvider
            rng = New RNGCryptoServiceProvider()

            ' Fill salt.
            rng.GetNonZeroBytes(saltBytes)

            saltValue = Convert.ToBase64String(saltBytes)

            ' Create the salted hash.
            Dim rawSalted As String = saltValue & Trim(PasswordTextBox.Text)
            Dim saltedPwBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(rawSalted)
            Dim sha1 As New System.Security.Cryptography.
            SHA1CryptoServiceProvider
            Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)
            Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)

            CreateNewUser(Username, saltValue, hashedPw)
        End If
        connectionString.Close()
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        If PasswordTextBox.Text = ConfirmPasswordTextBox.Text And PasswordTextBox.Text.Length > 8 And FullNameTextBox.Text <> "" And RoleComboBox.SelectedIndex <> -1 Then
            Username = UsernameTextBox.Text
            CheckUsernameUniqueness()
        Else
            MsgBox("Details invalid, please check and try again.", MessageBoxIcon.Information)

            ' Log event.
            Try
                Dim filePath As String
                filePath = System.IO.Path.Combine(
                           My.Computer.FileSystem.SpecialDirectories.MyDocuments, "AuthSys.txt")
                My.Computer.FileSystem.WriteAllText(filePath, Environment.NewLine & "[LOGON_CREATE] " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & " Failed account creation with username " & UsernameTextBox.Text & ".", True)
            Catch fileException As Exception
                MsgBox("Program encountered an error writing files. You should urgently contact your systems admin.", MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
End Class