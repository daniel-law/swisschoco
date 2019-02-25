Imports System.Data.SqlClient
Imports System.Configuration

Public Class ModifyFactory

    Public Property Id As String
    Public Property Name As String
    Public Property Country As String

    Private Sub ModifyFactory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reader As New System.Xml.XmlTextReader("https://raw.githubusercontent.com/lukes/ISO-3166-Countries-with-Regional-Codes/master/all/all.xml")
        While reader.Read
            If reader.NodeType = System.Xml.XmlNodeType.Element And reader.GetAttribute("name") <> Nothing Then
                CountryComboBox.Items.Add(reader.GetAttribute("name"))
            End If
        End While

        NameTextBox.Text = Name
        CountryComboBox.Text = Country
    End Sub

    Private Sub AddFactoryButton_Click(sender As Object, e As EventArgs) Handles AddFactoryButton.Click
        If CountryComboBox.SelectedIndex <> -1 And NameTextBox.Text <> "" Then
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("DevelopmentConnectionString").ConnectionString)
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "UPDATE Factories SET Name = @name, Locale = @locale WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameTextBox.Text
                cmd.Parameters.Add("@locale", SqlDbType.NVarChar).Value = CountryComboBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully modified the factory details.", MessageBoxIcon.Information)

                Me.Close()

            Catch ex As Exception
                MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            End Try
        Else
            MsgBox("Please ensure all the details are filled out.", MessageBoxIcon.Information)
        End If
    End Sub
End Class