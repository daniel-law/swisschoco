Imports System.Data.SqlClient

Public Class Products

    Dim WithEvents Timer As New System.Windows.Forms.Timer
    Private bindingSource1 As BindingSource = New BindingSource()
    Private dataAdapter As SqlDataAdapter = New SqlDataAdapter()
    Private table As DataTable = New DataTable()

    Private Function GetData(ByVal query As String)
        Try
            Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            dataAdapter = New SqlDataAdapter(query, connectionString)
            ' Create a command builder to appropriately query the database.
            Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(dataAdapter)
            ' Populate a table and bind it.
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            dataAdapter.Fill(table)
            bindingSource1.DataSource = table
            ' Resize everything so it looks clean.
            DataGridView1.AutoResizeColumn(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As Exception
            MsgBox("There was an error getting the data from the database.", MessageBoxIcon.Warning)
        End Try
    End Function

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bind the DataGridView to the BindingSource.
        DataGridView1.DataSource = bindingSource1
        ' Query data from the database.
        GetData("SELECT * FROM Products")

        ' Visual.
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' Auto-refresh data.
        Timer.Interval = 10000
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
        refreshProducts()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' // Timer must be stopped otherwise form will still request data while hidden from the user.
        Timer.Stop()
    End Sub

    Private Sub refreshProducts()
        table.Rows.Clear()
        DataGridView1.Refresh()
        ' Bind the DataGridView to the BindingSource
        DataGridView1.DataSource = bindingSource1
        ' Query data from the database.
        GetData("SELECT * FROM Products")
    End Sub

    Private Sub RefreshProductsButton_Click(sender As Object, e As EventArgs) Handles RefreshProductsButton.Click
        refreshProducts()
    End Sub

    ' Validate whether there is a row selected and confirm the user choice.
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.SelectedRows.Count > 0 And DataGridView1.SelectedRows(0).Index <> DataGridView1.NewRowIndex Then
            Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
            ' Ask user for deletion confirmation.
            Dim result As Integer = MessageBox.Show("Are you sure you wish to delete this product? This action is irreversible.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                Dim cmd As New SqlCommand

                Try
                    cmd.Connection = connectionString
                    connectionString.Open()
                    cmd.CommandText = "DELETE FROM Products WHERE Id = @Id;"
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = DataGridView1.SelectedCells(0).Value.ToString
                    cmd.ExecuteNonQuery()

                    MsgBox("The product was removed from the database.", MessageBoxIcon.Information)

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

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ' Verify data is numeric.
        If IsNumeric(SearchTextBox.Text) = True Then
            table.Rows.Clear()
            DataGridView1.Refresh()
            ' Bind the DataGridView to the BindingSource
            DataGridView1.DataSource = bindingSource1

            Try
                ' Query data from the database.
                GetData("SELECT * FROM Products WHERE Id = " & SearchTextBox.Text)
            Catch ex As Exception
                MsgBox("There was an error looking up that ID.")
            End Try
        Else
            MsgBox("The ID must be numeric to be looked up.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Dim AddProductForm As New AddProduct
        AddProductForm.Show()
    End Sub

    Private Sub ModifyProductButton_Click(sender As Object, e As EventArgs) Handles ModifyProductButton.Click
        If DataGridView1.SelectedRows.Count > 0 And DataGridView1.SelectedRows(0).Index <> DataGridView1.NewRowIndex Then
            Dim ModifyProductForm As New ModifyProduct
            ModifyProductForm.Id = DataGridView1.SelectedCells(0).Value.ToString
            ModifyProductForm.Name = DataGridView1.SelectedCells(1).Value.ToString
            ModifyProductForm.Price = DataGridView1.SelectedCells(2).Value.ToString
            ModifyProductForm.Picture = DataGridView1.SelectedCells(3).Value.ToString
            ModifyProductForm.Description = DataGridView1.SelectedCells(4).Value.ToString
            ModifyProductForm.Weight = DataGridView1.SelectedCells(5).Value.ToString
            ModifyProductForm.Ingredients = DataGridView1.SelectedCells(6).Value.ToString
            ModifyProductForm.Show()
        Else
            MsgBox("Please first select a product to be modified.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearResultsButton_Click(sender As Object, e As EventArgs) Handles ClearResultsButton.Click
        refreshProducts()
    End Sub
End Class