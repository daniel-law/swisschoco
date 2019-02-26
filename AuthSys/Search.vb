Imports System.Data.SqlClient
Imports System.Configuration

Public Class Search
    Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
    Dim cmd As New SqlCommand

    Private Sub setupProductsDGV()
        Dim ImageColumn As New DataGridViewImageColumn
        ImageColumn.HeaderText = "Picture"
        ResultsDataGridView.Columns.Clear()
        ResultsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ResultsDataGridView.ColumnCount = 6
        ResultsDataGridView.Columns(0).Name = "ID"
        ResultsDataGridView.Columns(1).Name = "Name"
        ResultsDataGridView.Columns(2).Name = "Price /GBP"
        ResultsDataGridView.Columns.Insert(3, ImageColumn)
        ResultsDataGridView.Columns(4).Name = "Description"
        ResultsDataGridView.Columns(5).Name = "Weight /g"
        ResultsDataGridView.Columns(6).Name = "Ingredients"
    End Sub

    Private Sub setupContactsDGV()
        ResultsDataGridView.Columns.Clear()
        ResultsDataGridView.ColumnCount = 4
        ResultsDataGridView.Columns(0).Name = "ID"
        ResultsDataGridView.Columns(1).Name = "Name"
        ResultsDataGridView.Columns(2).Name = "Telephone"
        ResultsDataGridView.Columns(3).Name = "Email"
    End Sub

    Private Sub setupInternalInvoicesDGV()
        ResultsDataGridView.Columns.Clear()
        ResultsDataGridView.ColumnCount = 5
        ResultsDataGridView.Columns(0).Name = "ID"
        ResultsDataGridView.Columns(1).Name = "Factory ID"
        ResultsDataGridView.Columns(2).Name = "Contact ID"
        ResultsDataGridView.Columns(3).Name = "Total Cost"
        ResultsDataGridView.Columns(4).Name = "Status"
    End Sub

    Private Sub setupLogsDGV()
        ResultsDataGridView.Columns.Clear()
        ResultsDataGridView.ColumnCount = 4
        ResultsDataGridView.Columns(0).Name = "ID"
        ResultsDataGridView.Columns(1).Name = "User ID"
        ResultsDataGridView.Columns(2).Name = "Factory ID"
        ResultsDataGridView.Columns(3).Name = "Detail"
    End Sub

    Private Sub FindProductbyIDButton_Click(sender As Object, e As EventArgs) Handles FindProductbyIDButton.Click
        setupProductsDGV()

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM Products WHERE Id = @productId;"
            cmd.Parameters.Add("productId", SqlDbType.Int).Value = FindProductbyIDNumericUpDown.Value
            Dim reader As SqlDataReader = cmd.ExecuteReader

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

    Private Sub FindProductbyNameButton_Click(sender As Object, e As EventArgs) Handles FindProductbyNameButton.Click
        setupProductsDGV()

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM Products WHERE Name LIKE '%' + @searchName + '%';"
            cmd.Parameters.Add("searchName", SqlDbType.NVarChar).Value = FindProductbyNameTextBox.Text
            Dim reader As SqlDataReader = cmd.ExecuteReader

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

    Private Sub FilterbyCostButton_Click(sender As Object, e As EventArgs) Handles FilterbyCostButton.Click
        setupProductsDGV()

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM Products WHERE Price BETWEEN @minimum AND @maximum;"
            cmd.Parameters.Add("minimum", SqlDbType.NVarChar).Value = CostMinNumericUpDown.Value
            cmd.Parameters.Add("maximum", SqlDbType.NVarChar).Value = CostMaxNumericUpDown.Value
            Dim reader As SqlDataReader = cmd.ExecuteReader

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

    Private Sub FindwithoutAllergenButton_Click(sender As Object, e As EventArgs) Handles FindwithoutAllergenButton.Click
        setupProductsDGV()

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM Products WHERE Ingredients NOT LIKE '%' + @allergen + '%';"
            cmd.Parameters.Add("allergen", SqlDbType.NVarChar).Value = FindwithoutAllergenTextBox.Text
            Dim reader As SqlDataReader = cmd.ExecuteReader

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

    Private Sub FindContactbyEmailButton_Click(sender As Object, e As EventArgs) Handles FindContactbyEmailButton.Click
        setupContactsDGV()

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM Contacts WHERE Email = @email;"
            cmd.Parameters.Add("email", SqlDbType.NVarChar).Value = FindContactbyEmailTextBox.Text
            Dim reader As SqlDataReader = cmd.ExecuteReader

            While reader.Read
                ResultsDataGridView.Rows.Add(reader("Id").ToString(), reader("Name").ToString(), reader("Telephone").ToString(), reader("Email").ToString())
            End While

        Catch ex As Exception
            MsgBox("Unable to find the Contact.", MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try
    End Sub

    Private Sub FindContactbyFactoryIDButton_Click(sender As Object, e As EventArgs) Handles FindContactbyFactoryIDButton.Click
        setupContactsDGV()
        Dim iList As New List(Of Integer)()


        ' Find the Contacts associated with the Factories.
        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT FactoryId, ContactId FROM InternalInvoices WHERE FactoryId = @factoryId;"
            cmd.Parameters.Add("factoryId", SqlDbType.NVarChar).Value = FindContactbyFactoryIDNumericUpDown.Value
            Dim reader As SqlDataReader = cmd.ExecuteReader

            While reader.Read
                iList.Add(reader("ContactId"))
            End While

        Catch ex As Exception
            MsgBox("Unable to find the Contacts associated with that Factory." & ex.Message, MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try

        ' Query the Contact details.
        For Each Contact In iList
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM Contacts WHERE Id = @contactId;"
                cmd.Parameters.Add("contactId", SqlDbType.NVarChar).Value = Contact
                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read
                    ResultsDataGridView.Rows.Add(reader("Id").ToString(), reader("Name").ToString(), reader("Telephone").ToString(), reader("Email").ToString())
                End While

            Catch ex As Exception
                MsgBox("Unable to query the Contacts details associated with that Factory." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try
        Next
    End Sub

    Private Sub FindInvoicesbyFactoryIDButton_Click(sender As Object, e As EventArgs) Handles FindInvoicesbyFactoryIDButton.Click
        setupInternalInvoicesDGV()

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM InternalInvoices WHERE FactoryId = @factoryId;"
            cmd.Parameters.Add("factoryId", SqlDbType.NVarChar).Value = FindInvoicesbyFactoryIDNumericUpDown.Value
            Dim reader As SqlDataReader = cmd.ExecuteReader
            Dim Status As String

            While reader.Read
                If reader("Status") = 0 Then
                    Status = "In Progress"
                ElseIf reader("Status") = 1 Then
                    Status = "Fulfilled"
                Else
                    Status = "Cancelled"
                End If

                ResultsDataGridView.Rows.Add(reader("Id").ToString(), reader("FactoryId").ToString(), reader("ContactId").ToString(), reader("TotalCost").ToString(), Status)
            End While

        Catch ex As Exception
            MsgBox("Unable to find the Invoices associated with that Factory." & ex.Message, MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try
    End Sub

    Private Sub FindLogbyIDButton_Click(sender As Object, e As EventArgs) Handles FindLogbyIDButton.Click
        setupLogsDGV()

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM ManufacturingLogs WHERE Id = @logId;"
            cmd.Parameters.Add("logId", SqlDbType.NVarChar).Value = FindLogbyIDNumericUpDown.Value
            Dim reader As SqlDataReader = cmd.ExecuteReader

            While reader.Read
                ResultsDataGridView.Rows.Add(reader("Id").ToString(), reader("UserId").ToString(), reader("FactoryId").ToString(), reader("Detail").ToString())
            End While

        Catch ex As Exception
            MsgBox("Unable to find the manufacturing log." & ex.Message, MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try
    End Sub

    Private Sub FindLogbyUserIDButton_Click(sender As Object, e As EventArgs) Handles FindLogbyUserIDButton.Click
        setupLogsDGV()

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM ManufacturingLogs WHERE UserId = @userId;"
            cmd.Parameters.Add("userId", SqlDbType.NVarChar).Value = FindLogbyUserIDNumericUpDown.Value
            Dim reader As SqlDataReader = cmd.ExecuteReader

            While reader.Read
                ResultsDataGridView.Rows.Add(reader("Id").ToString(), reader("UserId").ToString(), reader("FactoryId").ToString(), reader("Detail").ToString())
            End While

        Catch ex As Exception
            MsgBox("Unable to find the manufacturing log." & ex.Message, MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try
    End Sub

    Private Sub FindLogbyFactoryIDButton_Click(sender As Object, e As EventArgs) Handles FindLogbyFactoryIDButton.Click
        setupLogsDGV()

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM ManufacturingLogs WHERE FactoryId = @factoryId;"
            cmd.Parameters.Add("factoryId", SqlDbType.NVarChar).Value = FindLogbyFactoryIDNumericUpDown.Value
            Dim reader As SqlDataReader = cmd.ExecuteReader

            While reader.Read
                ResultsDataGridView.Rows.Add(reader("Id").ToString(), reader("UserId").ToString(), reader("FactoryId").ToString(), reader("Detail").ToString())
            End While

        Catch ex As Exception
            MsgBox("Unable to find the manufacturing log." & ex.Message, MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try
    End Sub

    Private Sub CheckInvoiceStatusButton_Click(sender As Object, e As EventArgs) Handles CheckInvoiceStatusButton.Click
        setupInternalInvoicesDGV()

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT * FROM InternalInvoices WHERE Id = @invoiceId;"
            cmd.Parameters.Add("invoiceId", SqlDbType.NVarChar).Value = CheckInvoiceStatusNumericUpDown.Value
            Dim reader As SqlDataReader = cmd.ExecuteReader
            Dim Status As String

            While reader.Read
                If reader("Status") = 0 Then
                    Status = "In Progress"
                ElseIf reader("Status") = 1 Then
                    Status = "Fulfilled"
                Else
                    Status = "Cancelled"
                End If

                ResultsDataGridView.Rows.Add(reader("Id").ToString(), reader("FactoryId").ToString(), reader("ContactId").ToString(), reader("TotalCost").ToString(), Status)
            End While

        Catch ex As Exception
            MsgBox("Unable to find the invoice." & ex.Message, MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try
    End Sub

    Private Sub FindStockLevelbyIDButton_Click(sender As Object, e As EventArgs) Handles FindStockLevelbyIDButton.Click
        ' Setup DataGridView for specific view.
        ResultsDataGridView.Columns.Clear()
        ResultsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ResultsDataGridView.ColumnCount = 3
        ResultsDataGridView.Columns(0).Name = "ID"
        ResultsDataGridView.Columns(1).Name = "Name"
        ResultsDataGridView.Columns(2).Name = "Stock Level"

        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT Id, Name, StockLevel FROM Products WHERE Id = @productId;"
            cmd.Parameters.Add("productId", SqlDbType.Int).Value = FindStockLevelbyIDNumericUpDown.Value
            Dim reader As SqlDataReader = cmd.ExecuteReader

            While reader.Read
                ResultsDataGridView.Rows.Add(reader("Id").ToString(), reader("Name").ToString(), reader("StockLevel").ToString())
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

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintDocument2.Print()
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim DataGridViewImage As New Bitmap(ResultsDataGridView.Width, ResultsDataGridView.Height)
        ResultsDataGridView.DrawToBitmap(DataGridViewImage, New Rectangle(0, 0, ResultsDataGridView.Width, ResultsDataGridView.Height))
        e.Graphics.DrawImage(DataGridViewImage, 0, 0)
    End Sub
End Class