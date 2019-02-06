Imports System.Data.SqlClient

Public Class ModifyProduct
    Public Property Id As String
    Public Property Name As String
    Public Property Price As String
    Public Property Picture As String
    Public Property Description As String
    Public Property Weight As String
    Public Property Ingredients As String

    Private Sub ModifyProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Text = Name
        PriceNumericUpDown.Value = Price
        PictureTextBox.Text = Picture
        DescriptionRichTextBox.Text = Description
        WeightNumericUpDown.Value = Weight
        IngredientsRichTextBox.Text = Ingredients
    End Sub

    Private Sub ModifyProductButton_Click(sender As Object, e As EventArgs) Handles ModifyProductButton.Click
        ' TODO: validate user input.
        Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim cmd As New SqlCommand

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "UPDATE Products SET Name = '" & NameTextBox.Text & "', Price = '" & PriceNumericUpDown.Value & "', Picture = '" & PictureTextBox.Text & "', Description = '" & DescriptionRichTextBox.Text & "', Weight = '" & WeightNumericUpDown.Value & "', Ingredients = '" & IngredientsRichTextBox.Text & "' WHERE Id = " & Id & ";"
            cmd.ExecuteNonQuery()

            MsgBox("Sucessfully modified the product details.", MessageBoxIcon.Information)

            Me.Close()

        Catch ex As Exception
            MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        End Try
    End Sub
End Class