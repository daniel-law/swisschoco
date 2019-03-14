Imports System.Data.SqlClient
Imports System.Configuration

Public Class ModifyProduct
    Public Property Id As String
    Public Property Title As String
    Public Property Price As String
    Public Property Picture As String
    Public Property Description As String
    Public Property Weight As String
    Public Property Ingredients As String

    Dim imgByte As Byte()

    ' This will load the product parameters into the form.
    Private Sub ModifyProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Text = Title
        PriceNumericUpDown.Value = Price
        DescriptionRichTextBox.Text = Description
        WeightNumericUpDown.Value = Weight
        IngredientsRichTextBox.Text = Ingredients
    End Sub

    ' This will modify a product if the validation is met.
    Private Sub ModifyProductButton_Click(sender As Object, e As EventArgs) Handles ModifyProductButton.Click
        If NameTextBox.Text <> "" And PriceNumericUpDown.Value <> 0.00 And PictureTextBox.Text <> "" And DescriptionRichTextBox.Text <> "" And WeightNumericUpDown.Value <> 0 And IngredientsRichTextBox.Text <> "" Then
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "UPDATE Products SET Name = @name, Price = @price, Picture = @image, Description = @description, Weight = @weight, Ingredients = @ingredients WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameTextBox.Text
                cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = PriceNumericUpDown.Value
                cmd.Parameters.Add("@image", SqlDbType.Image).Value = imgByte
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = DescriptionRichTextBox.Text
                cmd.Parameters.Add("@weight", SqlDbType.SmallInt).Value = WeightNumericUpDown.Value
                cmd.Parameters.Add("@ingredients", SqlDbType.NVarChar).Value = IngredientsRichTextBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully modified the product details.", MessageBoxIcon.Information)

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

    Private Sub SelectImageButton_Click(sender As Object, e As EventArgs) Handles SelectImageButton.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
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
        End If
    End Sub
End Class