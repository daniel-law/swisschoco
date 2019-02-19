Imports System.Data.SqlClient

Public Class Search
    Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Dim cmd As New SqlCommand

    Private Sub FindProductbyIDButton_Click(sender As Object, e As EventArgs) Handles FindProductbyIDButton.Click
        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM Products WHERE Id = @productId;"
            cmd.Parameters.Add("productId", SqlDbType.Int).Value = FindProductbyIDNumericUpDown.Value
            Dim reader As SqlDataReader = cmd.ExecuteReader
            Dim ImageColumn As New DataGridViewImageColumn
            ImageColumn.HeaderText = "Picture"

            ' Setup DataGridView.
            ResultsDataGridView.Columns.Clear()
            ResultsDataGridView.ColumnCount = 6
            ResultsDataGridView.Columns(0).Name = "ID"
            ResultsDataGridView.Columns(1).Name = "Name"
            ResultsDataGridView.Columns(2).Name = "Price /GBP"
            ResultsDataGridView.Columns.Insert(3, ImageColumn)
            ResultsDataGridView.Columns(4).Name = "Description"
            ResultsDataGridView.Columns(5).Name = "Weight /g"
            ResultsDataGridView.Columns(6).Name = "Ingredients"

            While reader.Read
                ResultsDataGridView.Rows.Add(reader("Id").ToString(), reader("Name").ToString(), reader("Price").ToString(), reader("Picture"), reader("Description").ToString(), reader("Weight").ToString(), reader("Ingredients").ToString())
            End While

        Catch ex As Exception
            MsgBox("Unable to find the Product.", MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try
    End Sub
End Class