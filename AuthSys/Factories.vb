Imports System.Data.SqlClient
Imports System.Configuration

Public Class Factories
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
            FactoriesDataGridView.AutoResizeColumn(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As Exception
            MsgBox("There was an error getting the data from the database: " & ex.Message, MessageBoxIcon.Warning)
        End Try
    End Function

    Private Sub Factories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bind the DataGridView to the BindingSource.
        FactoriesDataGridView.DataSource = bindingSource1
        ' Query data from the database.
        GetData("SELECT * FROM Factories")

        ' Visual.
        FactoriesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Validation.
        FactoriesDataGridView.Select()
    End Sub

    Private Sub refreshFactories()
        table.Rows.Clear()
        FactoriesDataGridView.Refresh()
        ' Bind the DataGridView to the BindingSource
        FactoriesDataGridView.DataSource = bindingSource1
        ' Query data from the database.
        GetData("SELECT * FROM Factories")
        FactoriesDataGridView.Select()
    End Sub

    Private Sub RefreshContactsButton_Click(sender As Object, e As EventArgs) Handles RefreshContactsButton.Click
        refreshFactories()
    End Sub

    ' Validate whether there is a row selected and confirm the user choice.
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteFactoryButton.Click
        If FactoriesDataGridView.SelectedRows.Count > 0 And FactoriesDataGridView.SelectedRows(0).Index <> FactoriesDataGridView.NewRowIndex Then
            Dim rowIndex As Integer = FactoriesDataGridView.CurrentCell.RowIndex
            ' Ask user for deletion confirmation.
            Dim result As Integer = MessageBox.Show("Are you sure you wish to delete this factory? This action is irreversible.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
                Dim cmd As New SqlCommand

                Try
                    cmd.Connection = connectionString
                    connectionString.Open()
                    cmd.CommandText = "DELETE FROM Factories WHERE Id = @Id;"
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = FactoriesDataGridView.SelectedCells(0).Value.ToString
                    cmd.ExecuteNonQuery()

                    MsgBox("The factory was removed from the database.", MessageBoxIcon.Information)
                    refreshFactories()

                Catch ex As Exception
                    MsgBox("Unable to delete the selected factory.", MessageBoxIcon.Warning)
                    ' DB issues, exit.
                    Exit Sub
                End Try
            End If
        Else
            MsgBox("Please first select a contact to be deleted.", MessageBoxIcon.Information)
        End If
    End Sub

    ' This code searches for a specific factory.
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ' Verify data is numeric.
        If IsNumeric(SearchTextBox.Text) = True Then
            table.Rows.Clear()
            FactoriesDataGridView.Refresh()
            ' Bind the DataGridView to the BindingSource
            FactoriesDataGridView.DataSource = bindingSource1

            Try
                ' Query data from the database.
                GetData("SELECT * FROM Factories WHERE Id = " & SearchTextBox.Text)
                FactoriesDataGridView.Select()
            Catch ex As Exception
                MsgBox("There was an error looking up that ID.")
            End Try
        Else
            MsgBox("The ID must be numeric to be looked up.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearResultsButton_Click(sender As Object, e As EventArgs) Handles ClearResultsButton.Click
        refreshFactories()
        SearchTextBox.Clear()
    End Sub

    ' This code opens a new add factory form.
    Private Sub AddFactoryButton_Click(sender As Object, e As EventArgs) Handles AddFactoryButton.Click
        Dim AddFactoryForm As New AddFactory
        AddFactoryForm.Show()
    End Sub

    ' This code passes in the factory details to a new modify form, then opens that modify form.
    Private Sub ModifyFactoryButton_Click(sender As Object, e As EventArgs) Handles ModifyFactoryButton.Click
        If FactoriesDataGridView.SelectedRows.Count > 0 And FactoriesDataGridView.SelectedRows(0).Index <> FactoriesDataGridView.NewRowIndex Then
            Dim ModifyFactoryForm As New ModifyFactory
            ModifyFactory.Id = FactoriesDataGridView.SelectedCells(0).Value.ToString
            ModifyFactory.FactoryName = FactoriesDataGridView.SelectedCells(1).Value.ToString
            ModifyFactory.Country = FactoriesDataGridView.SelectedCells(2).Value.ToString
            ModifyFactory.Show()
        Else
            MsgBox("Please first select a factory to be modified.", MessageBoxIcon.Information)
        End If
    End Sub
End Class