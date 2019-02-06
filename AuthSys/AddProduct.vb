Imports System.Data.SqlClient
Imports System.IO

Public Class AddProduct

    Dim imgByte As Byte()

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        ' TODO: validate user input.
        Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim cmd As New SqlCommand

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "INSERT INTO Products (Name, Price, Picture, Description, Weight, Ingredients) VALUES ('" & NameTextBox.Text & "', '" & PriceNumericUpDown.Value & "', @image" & ", '" & DescriptionRichTextBox.Text & "', '" & WeightNumericUpDown.Value & "', '" & IngredientsRichTextBox.Text & "');"
            cmd.Parameters.Add("@image", SqlDbType.Image).Value = imgByte
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            ' Show image preview.
            PictureTextBox.Text = OpenFileDialog1.FileName
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)

            ' Re-size image.
            Dim newSize As New Size(60, 80)
            Dim resizedImage As Image
            resizedImage = New Bitmap(PictureBox2.Image, newSize)

            ' Convert image to bytes.
            'Dim img As Image = Image.FromFile(OpenFileDialog1.FileName)
            Dim img As Image = resizedImage
            Dim imgStream As System.IO.MemoryStream = New System.IO.MemoryStream
            img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            imgByte = imgStream.GetBuffer()
        End If
    End Sub
End Class