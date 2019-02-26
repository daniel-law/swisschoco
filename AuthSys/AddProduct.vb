Imports System.Data.SqlClient
Imports System.IO

Public Class AddProduct
    Dim imgByte As Byte()

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        If NameTextBox.Text <> "" And PriceNumericUpDown.Value <> 0.00 And PictureTextBox.Text <> "" And DescriptionRichTextBox.Text <> "" And WeightNumericUpDown.Value <> 0 And IngredientsRichTextBox.Text <> "" Then
            Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "INSERT INTO Products (Name, Price, Picture, Description, Weight, Ingredients) VALUES (@name, @price, @image, @description, @weight, @ingredients);"
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameTextBox.Text
                cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = PriceNumericUpDown.Value
                cmd.Parameters.Add("@image", SqlDbType.Image).Value = imgByte
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = DescriptionRichTextBox.Text
                cmd.Parameters.Add("@weight", SqlDbType.SmallInt).Value = WeightNumericUpDown.Value
                cmd.Parameters.Add("@ingredients", SqlDbType.NVarChar).Value = IngredientsRichTextBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully added new product into the database.", MessageBoxIcon.Information)

                ' Clear entered details.
                NameTextBox.Clear()
                PriceNumericUpDown.Value = 0.00
                PictureTextBox.Clear()
                PictureBox2.Image = Nothing
                DescriptionRichTextBox.Clear()
                WeightNumericUpDown.Value = 0
                IngredientsRichTextBox.Clear()
                NameTextBox.Select()

            Catch ex As Exception
                MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            End Try
        Else
            MsgBox("Please ensure all the details are filled out.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SelectImageButton_Click(sender As Object, e As EventArgs) Handles SelectImageButton.Click

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Try
                ' Show image preview.
                PictureTextBox.Text = OpenFileDialog1.FileName
                PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)

                ' Re-size image.
                Dim newSize As New Size(60, 80)
                Dim resizedImage As Image
                resizedImage = New Bitmap(PictureBox2.Image, newSize)

                ' Convert image to bytes.
                Dim img As Image = resizedImage
                Dim imgStream As System.IO.MemoryStream = New System.IO.MemoryStream
                img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                imgByte = imgStream.GetBuffer()
            Catch ex As OutOfMemoryException
                MsgBox("Please select an image to proceed!", MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
End Class