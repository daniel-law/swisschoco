Public Class ViewProduct
    Public Property Id As String
    Public Property Title As String
    Public Property Price As String
    Public Property Picture As String
    Public Property Description As String
    Public Property Weight As String
    Public Property Ingredients As String

    ' This will load the parameters to view the product.
    Private Sub ViewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Text = Title
        PriceNumericUpDown.Value = Price
        DescriptionRichTextBox.Text = Description
        WeightNumericUpDown.Value = Weight
        IngredientsRichTextBox.Text = Ingredients
    End Sub
End Class