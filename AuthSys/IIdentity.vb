Imports System.Security.Principal
Imports System.Security.Cryptography
Imports System.Configuration
Imports System.Data.SqlClient

Public Class IIdentity
    Implements System.Security.Principal.IIdentity

    Private nameValue As String
    Private authenticatedValue As Boolean
    Private roleValue As ApplicationServices.BuiltInRole
    Private errorNotify As Boolean = False ' Store whether the user has been informed of an error.

    ' Must return a string that indicates the current authentication mechanism.
    Public ReadOnly Property AuthenticationType As String Implements Security.Principal.IIdentity.AuthenticationType
        Get
            Return "SqlDatabase"
        End Get
    End Property

    ' Must return a value that indicates whether the user has been authenticated or not.
    Public ReadOnly Property IsAuthenticated As Boolean Implements Security.Principal.IIdentity.IsAuthenticated
        Get
            Return authenticatedValue
        End Get
    End Property

    ' Must return the name of the user associated with this identity.
    Public ReadOnly Property Name As String Implements Security.Principal.IIdentity.Name
        Get
            Return nameValue
        End Get
    End Property

    ' Returns the user's role.
    Public ReadOnly Property Role() As ApplicationServices.BuiltInRole
        Get
            Return roleValue
        End Get
    End Property

    ' Sets the user's nameValue and roleValue.
    Public Sub New(ByVal name As String, ByVal password As String)
        ' The name is not case sensitive, but the password is.
        If IsValidNameAndPassword(name, password) Then
            nameValue = callDB(name, "FullName")
            authenticatedValue = True

            ' Log event.
            Try
                Dim filePath As String
                filePath = System.IO.Path.Combine(
                           My.Computer.FileSystem.SpecialDirectories.MyDocuments, "SwissChoco Log.txt")
                My.Computer.FileSystem.WriteAllText(filePath, Environment.NewLine & "[LOGON_AUTH] " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & " Login attempt PASS with username " & name & ".", True)
            Catch fileException As Exception
                MsgBox("Program encountered an error writing files. You should urgently contact your systems admin.", MessageBoxIcon.Warning)
            End Try

            ' Query their role.
            Dim role = callDB(name, "Role")
            If role = "Administrator" Then roleValue = ApplicationServices.BuiltInRole.Administrator
            If role = "User" Then roleValue = ApplicationServices.BuiltInRole.User

        Else
            nameValue = ""
            authenticatedValue = False
            roleValue = ApplicationServices.BuiltInRole.Guest
        End If
    End Sub

    ' Checks whether the user/pass combination is valid or invalid.
    Private Function IsValidNameAndPassword(
        ByVal username As String,
        ByVal password As String) As Boolean

        ' Look up the stored hashed password and salt for the username.
        Dim storedHashedPW As String = GetHashedPassword(username)
        Dim salt As String = GetSalt(username)

        ' Create the salted hash.
        Dim rawSalted As String = salt & Trim(password)
        Dim saltedPwBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(rawSalted)
        Dim sha1 As New System.Security.Cryptography.
            SHA1CryptoServiceProvider
        Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)
        Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)

        ' Compare the hashed password with the stored password.
        Return hashedPw = storedHashedPW
    End Function

    Private Function callDB(ByVal username As String, ByVal column As String) As String
        ' Code that calls the DB to retrieve a specified value.
        Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim result As String

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT " & column & " FROM Users WHERE Username = @username;"
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username
            dr = cmd.ExecuteReader()

            While dr.Read
                result = dr(column)
            End While

            dr.Close()
            connectionString.Close()
        Catch ex As Exception
            errorNotify = True
            MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
        End Try

        Return result
    End Function

    Private Function GetHashedPassword(ByVal username As String) As String
        ' Code that gets the user's hashed password.
        Dim hash As String
        If errorNotify = False Then
            hash = callDB(username, "Hash")
        End If

        Return hash
    End Function

    Private Function GetSalt(ByVal username As String) As String
        ' Code that gets the user's salt.
        Dim salt As String
        If errorNotify = False Then
            salt = callDB(username, "Salt")
        End If

        Return salt
    End Function
End Class
