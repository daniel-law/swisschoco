Imports System.Data.SqlClient

Public Class AddProduct

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        ' TODO: validate user input.
        Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim cmd As New SqlCommand

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "INSERT INTO Products (Name, Price, Picture, Description, Weight, Ingredients) VALUES ('" & NameTextBox.Text & "', '" & PriceNumericUpDown.Value & "', '" & PictureTextBox.Text & "', '" & DescriptionRichTextBox.Text & "', '" & WeightNumericUpDown.Value & "', '" & IngredientsRichTextBox.Text & "');"
            cmd.ExecuteNonQuery()

            MsgBox("Sucessfully added new product into the database.", MessageBoxIcon.Information)

            ' Clear entered details.
            NameTextBox.Clear()
            PriceNumericUpDown.Value = 0.00
            PictureTextBox.Clear()
            DescriptionRichTextBox.Clear()
            WeightNumericUpDown.Value = 0
            IngredientsRichTextBox.Clear()
            NameTextBox.Select()

        Catch ex As Exception
            MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        End Try
    End Sub
End Class