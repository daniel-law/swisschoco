Imports System.Data.SqlClient
Imports System.Configuration

Public Class Products
    Private bindingSource1 As BindingSource = New BindingSource()
    Private dataAdapter As SqlDataAdapter = New SqlDataAdapter()
    Private table As DataTable = New DataTable()

    Private Function GetData(ByVal query As String)
        Try
            Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
            dataAdapter = New SqlDataAdapter(query, connectionString)
            ' Create a command builder to appropriately query the database.
            Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(dataAdapter)
            ' Populate a table and bind it.
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            dataAdapter.Fill(table)
            bindingSource1.DataSource = table
            ' Resize everything so it looks clean.
            ProductsDataGridView.AutoResizeColumn(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As Exception
            MsgBox("There was an error getting the data from the database.", MessageBoxIcon.Warning)
        End Try
    End Function

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bind the DataGridView to the BindingSource.
        ProductsDataGridView.DataSource = bindingSource1
        ' Query data from the database.
        GetData("SELECT * FROM Products")

        ' Visual.
        ProductsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub refreshProducts()
        table.Rows.Clear()
        ProductsDataGridView.Refresh()
        ' Bind the DataGridView to the BindingSource
        ProductsDataGridView.DataSource = bindingSource1
        ' Query data from the database.
        GetData("SELECT * FROM Products")
        ProductsDataGridView.Select()
    End Sub

    Private Sub RefreshProductsButton_Click(sender As Object, e As EventArgs) Handles RefreshProductsButton.Click
        refreshProducts()
    End Sub

    ' Validate whether there is a row selected and confirm the user choice.
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteProductButton.Click
        If ProductsDataGridView.SelectedRows.Count > 0 And ProductsDataGridView.SelectedRows(0).Index <> ProductsDataGridView.NewRowIndex Then
            Dim rowIndex As Integer = ProductsDataGridView.CurrentCell.RowIndex
            ' Ask user for deletion confirmation.
            Dim result As Integer = MessageBox.Show("Are you sure you wish to delete this product? This action is irreversible.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
                Dim cmd As New SqlCommand

                Try
                    cmd.Connection = connectionString
                    connectionString.Open()
                    cmd.CommandText = "DELETE FROM Products WHERE Id = @Id;"
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = ProductsDataGridView.SelectedCells(0).Value.ToString
                    cmd.ExecuteNonQuery()

                    MsgBox("The product was removed from the database.", MessageBoxIcon.Information)
                    refreshProducts()

                Catch ex As Exception
                    MsgBox("Unable to delete the selected product.", MessageBoxIcon.Warning)
                    ' DB issues, exit.
                    Exit Sub
                End Try
            End If
        Else
            MsgBox("Please first select a product to be deleted.", MessageBoxIcon.Information)
        End If
    End Sub

    ' This will search for a specific product if it exists in the database.
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ' Verify data is numeric.
        If IsNumeric(SearchTextBox.Text) = True Then
            table.Rows.Clear()
            ProductsDataGridView.Refresh()
            ' Bind the DataGridView to the BindingSource
            ProductsDataGridView.DataSource = bindingSource1

            Try
                ' Query data from the database.
                GetData("SELECT * FROM Products WHERE Id = " & SearchTextBox.Text)
                ProductsDataGridView.Select()
            Catch ex As Exception
                MsgBox("There was an error looking up that ID.")
            End Try
        Else
            MsgBox("The ID must be numeric to be looked up.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearResultsButton_Click(sender As Object, e As EventArgs) Handles ClearResultsButton.Click
        refreshProducts()
        SearchTextBox.Clear()
    End Sub

    ' This will show a new add product form.
    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Dim AddProductForm As New AddProduct
        AddProductForm.Show()
    End Sub

    ' This will show a new modify product form, with the parameters passed in.
    Private Sub ModifyProductButton_Click(sender As Object, e As EventArgs) Handles ModifyProductButton.Click
        If ProductsDataGridView.SelectedRows.Count > 0 And ProductsDataGridView.SelectedRows(0).Index <> ProductsDataGridView.NewRowIndex Then
            Dim ModifyProductForm As New ModifyProduct
            ModifyProductForm.Id = ProductsDataGridView.SelectedCells(0).Value.ToString
            ModifyProductForm.Title = ProductsDataGridView.SelectedCells(1).Value.ToString
            ModifyProductForm.Price = ProductsDataGridView.SelectedCells(2).Value.ToString
            ModifyProductForm.Picture = ProductsDataGridView.SelectedCells(3).Value.ToString
            ModifyProductForm.Description = ProductsDataGridView.SelectedCells(4).Value.ToString
            ModifyProductForm.Weight = ProductsDataGridView.SelectedCells(5).Value.ToString
            ModifyProductForm.Ingredients = ProductsDataGridView.SelectedCells(6).Value.ToString
            ModifyProductForm.Show()
        Else
            MsgBox("Please first select a product to be modified.", MessageBoxIcon.Information)
        End If
    End Sub
End Class