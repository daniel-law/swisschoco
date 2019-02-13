Imports System.Data.SqlClient

Public Class Factories
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
            MsgBox("There was an error getting the data from the database: " & ex.Message, MessageBoxIcon.Warning)
        End Try
    End Function

    Private Sub Factories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bind the DataGridView to the BindingSource.
        DataGridView1.DataSource = bindingSource1
        ' Query data from the database.
        GetData("SELECT * FROM Factories")

        ' Visual.
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub refreshFactories()
        table.Rows.Clear()
        DataGridView1.Refresh()
        ' Bind the DataGridView to the BindingSource
        DataGridView1.DataSource = bindingSource1
        ' Query data from the database.
        GetData("SELECT * FROM Factories")
    End Sub

    Private Sub RefreshContactsButton_Click(sender As Object, e As EventArgs) Handles RefreshContactsButton.Click
        refreshFactories()
    End Sub

    ' TODO: deletion button.

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ' Verify data is numeric.
        If IsNumeric(SearchTextBox.Text) = True Then
            table.Rows.Clear()
            DataGridView1.Refresh()
            ' Bind the DataGridView to the BindingSource
            DataGridView1.DataSource = bindingSource1

            Try
                ' Query data from the database.
                GetData("SELECT * FROM Factories WHERE Id = " & SearchTextBox.Text)
            Catch ex As Exception
                MsgBox("There was an error looking up that ID.")
            End Try
        Else
            MsgBox("The ID must be numeric to be looked up.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearResultsButton_Click(sender As Object, e As EventArgs) Handles ClearResultsButton.Click
        refreshFactories()
    End Sub

    Private Sub AddFactoryButton_Click(sender As Object, e As EventArgs) Handles AddFactoryButton.Click
        Dim AddFactoryForm As New AddFactory
        AddFactoryForm.Show()
    End Sub
End Class