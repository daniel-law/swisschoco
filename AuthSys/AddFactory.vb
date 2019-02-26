Imports System.Data.SqlClient
Imports System.Configuration

Public Class AddFactory
    Private Sub AddFactory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reader As New System.Xml.XmlTextReader("https://raw.githubusercontent.com/lukes/ISO-3166-Countries-with-Regional-Codes/master/all/all.xml")
        While reader.Read
            If reader.NodeType = System.Xml.XmlNodeType.Element And reader.GetAttribute("name") <> Nothing Then
                CountryComboBox.Items.Add(reader.GetAttribute("name"))
            End If
        End While
    End Sub

    Private Sub AddFactoryButton_Click(sender As Object, e As EventArgs) Handles AddFactoryButton.Click
        If CountryComboBox.SelectedIndex <> -1 And NameTextBox.Text <> "" Then
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "INSERT INTO Factories (Name, Locale) VALUES (@name, @locale);"
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameTextBox.Text
                cmd.Parameters.Add("@locale", SqlDbType.NVarChar).Value = CountryComboBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully added new factory into the database.", MessageBoxIcon.Information)

                ' Clear entered details.
                NameTextBox.Clear()
                CountryComboBox.Text = ""
                CountryComboBox.SelectedIndex = -1
                NameTextBox.Select()

            Catch ex As Exception
                MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            End Try
        Else
            MsgBox("Please ensure all the details are correctly filled out.", MessageBoxIcon.Information)
        End If
    End Sub
End Class