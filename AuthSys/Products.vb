Imports System.Data.SqlClient

Public Class Products

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
        GetData("Select * FROM Products")
    End Sub

    Private Sub UndoChangesButton_Click(sender As Object, e As EventArgs) Handles UndoChangesButton.Click
        table.Rows.Clear()
        DataGridView1.Refresh()
        ' Bind the DataGridView to the BindingSource
        DataGridView1.DataSource = bindingSource1
        ' Query data from the database.
        GetData("Select * FROM Products")
    End Sub

    Private Sub SaveChangesButton_Click(sender As Object, e As EventArgs) Handles SaveChangesButton.Click
        ' Will update the DB with the necessary INSERT and DROP commands.
        Try
            dataAdapter.Update(bindingSource1.DataSource)
        Catch ex As Exception
            MsgBox("There was an issue with saving your changes. Sorry.")
        End Try
    End Sub

    ' Validate whether there is a row selected and confirm the user choice.
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("There must be a row selected to delete it!", MessageBoxIcon.Information)
        Else
            Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
            ' Ask user for deletion confirmation.
            Dim result As Integer = MessageBox.Show("Are you sure you wish to delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(rowIndex)
            End If
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

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        MsgBox("There was an error with your input.", MessageBoxIcon.Information)
    End Sub
End Class