Imports System.Data.SqlClient
Imports System.Configuration

Public Class Contacts
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
            ContactsDataGridView.AutoResizeColumn(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As Exception
            MsgBox("There was an error getting the data from the database: " & ex.Message, MessageBoxIcon.Warning)
        End Try
    End Function

    Private Sub Contacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bind the DataGridView to the BindingSource.
        ContactsDataGridView.DataSource = bindingSource1
        ' Query data from the database.
        GetData("SELECT * FROM Contacts")

        ' Visual.
        ContactsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ContactsDataGridView.Select()
    End Sub

    Private Sub refreshContacts()
        table.Rows.Clear()
        ContactsDataGridView.Refresh()
        ' Bind the DataGridView to the BindingSource
        ContactsDataGridView.DataSource = bindingSource1
        ' Query data from the database.
        GetData("SELECT * FROM Contacts")
        ContactsDataGridView.Select()
    End Sub

    Private Sub RefreshContactsButton_Click(sender As Object, e As EventArgs) Handles RefreshContactsButton.Click
        refreshContacts()
    End Sub

    ' Validate whether there is a row selected and confirm the user choice.
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteContactButton.Click
        If ContactsDataGridView.SelectedRows.Count > 0 And ContactsDataGridView.SelectedRows(0).Index <> ContactsDataGridView.NewRowIndex Then
            Dim rowIndex As Integer = ContactsDataGridView.CurrentCell.RowIndex
            ' Ask user for deletion confirmation.
            Dim result As Integer = MessageBox.Show("Are you sure you wish to delete this contact? This action is irreversible.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
                Dim cmd As New SqlCommand

                Try
                    cmd.Connection = connectionString
                    connectionString.Open()
                    cmd.CommandText = "DELETE FROM Contacts WHERE Id = @Id;"
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = ContactsDataGridView.SelectedCells(0).Value.ToString
                    cmd.ExecuteNonQuery()

                    MsgBox("The contact was removed from the database.", MessageBoxIcon.Information)
                    refreshContacts()

                Catch ex As Exception
                    MsgBox("Unable to delete the selected contact.", MessageBoxIcon.Warning)
                    ' DB issues, exit.
                    Exit Sub
                End Try
            End If
        Else
            MsgBox("Please first select a contact to be deleted.", MessageBoxIcon.Information)
        End If
    End Sub

    ' This searches for a specific contact in the database.
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ' Verify data is numeric.
        If IsNumeric(SearchTextBox.Text) = True Then
            table.Rows.Clear()
            ContactsDataGridView.Refresh()
            ' Bind the DataGridView to the BindingSource
            ContactsDataGridView.DataSource = bindingSource1

            Try
                ' Query data from the database.
                GetData("SELECT * FROM Contacts WHERE Id = " & SearchTextBox.Text)
                ContactsDataGridView.Select()
            Catch ex As Exception
                MsgBox("There was an error looking up that ID.")
            End Try
        Else
            MsgBox("The ID must be numeric to be looked up.", MessageBoxIcon.Information)
        End If
    End Sub

    ' This clears any results and reloads the contacts.
    Private Sub ClearResultsButton_Click(sender As Object, e As EventArgs) Handles ClearResultsButton.Click
        refreshContacts()
        SearchTextBox.Clear()
    End Sub

    ' This shows a new add contact form.
    Private Sub AddContactButton_Click(sender As Object, e As EventArgs) Handles AddContactButton.Click
        Dim AddContactForm As New AddContact
        AddContactForm.Show()
    End Sub

    ' This event will pass in the parameters to the modify contact form, then open that form.
    Private Sub ModifyContactButton_Click(sender As Object, e As EventArgs) Handles ModifyContactButton.Click
        If ContactsDataGridView.SelectedRows.Count > 0 And ContactsDataGridView.SelectedRows(0).Index <> ContactsDataGridView.NewRowIndex Then
            Dim ModifyContactForm As New ModifyContact
            ModifyContactForm.Id = ContactsDataGridView.SelectedCells(0).Value.ToString
            ModifyContactForm.ContactName = ContactsDataGridView.SelectedCells(1).Value.ToString
            ModifyContactForm.Telephone = ContactsDataGridView.SelectedCells(2).Value.ToString
            ModifyContactForm.Email = ContactsDataGridView.SelectedCells(3).Value.ToString()
            ModifyContactForm.Show()
        Else
            MsgBox("Please first select a contact to be modified.", MessageBoxIcon.Information)
        End If
    End Sub
End Class