Imports System.Data.SqlClient
Imports System.Configuration

Public Class ManufacturingLogs

    Dim currentId As String
    Dim creatingRecord As Boolean
    Dim DBEmpty As Boolean

    Dim connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("ProductionConnectionString").ConnectionString)
    Dim cmd As New SqlCommand

    ' This will select the first record in the manufacturing logs table.
    Private Sub getFirstRecord()
        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT TOP 1 * FROM ManufacturingLogs;"
            Dim reader As SqlDataReader = cmd.ExecuteReader

            Dim FactoryID As String
            Dim UserId As String
            Dim Detail As String

            While reader.Read
                currentId = reader("Id").ToString()
                FactoryID = reader("FactoryID").ToString()
                UserId = reader("UserId").ToString()
                Detail = reader("Detail").ToString()
            End While

            LogIdTextBox.Text = currentId
            FactoryIDNumericUpDown.Value = FactoryID
            ConductedByNumericUpDown.Value = UserId
            DetailsRichTextBox.Text = Detail

            If FactoryID = Nothing Then
                DBEmpty = True
                FactoryIDNumericUpDown.Value = 1
                ConductedByNumericUpDown.Value = 1
                SaveChangesButton.Enabled = False
                DeleteLogButton.Enabled = False
            Else
                DBEmpty = False
            End If

        Catch ex As Exception
            MsgBox("Unable to view the selected manufacturing log.", MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try
    End Sub

    ' This will get the last record from the database.
    Private Sub getLastRecordID()
        Try
            cmd.Connection = connectionString
            connectionString.Open()
            cmd.CommandText = "SELECT TOP 1 Id FROM ManufacturingLogs ORDER BY ID DESC;"
            Dim reader As SqlDataReader = cmd.ExecuteReader

            While reader.Read
                currentId = reader("Id").ToString()
                LogIdTextBox.Text = currentId
            End While

        Catch ex As Exception
            MsgBox("Unable to view the selected manufacturing log." & ex.Message, MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try
    End Sub

    ' Setup the form.
    Private Sub ManufacturingLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBEmpty = True
        getFirstRecord()
    End Sub

    ' This event will save any changes to a manufacturing log.
    Private Sub SaveChangesButton_Click(sender As Object, e As EventArgs) Handles SaveChangesButton.Click
        If DetailsRichTextBox.Text <> "" And creatingRecord = False Then
            ' Updating current record.
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "UPDATE ManufacturingLogs SET UserId = @userId, Detail = @detail, FactoryId = @factoryId WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = currentId
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = ConductedByNumericUpDown.Value
                cmd.Parameters.Add("@detail", SqlDbType.NVarChar).Value = DetailsRichTextBox.Text
                cmd.Parameters.Add("@factoryId", SqlDbType.Int).Value = FactoryIDNumericUpDown.Value
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully modified the manufacturing log details.", MessageBoxIcon.Information)
                Exit Sub

            Catch ex As Exception
                MsgBox("Program encountered an error connecting to the database, ensure that the contact and factory exist before contacting your systems admin.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try
        End If

        If DetailsRichTextBox.Text <> "" And creatingRecord = True Then
            ' Adding new record.
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "INSERT INTO ManufacturingLogs (FactoryId, UserId, Detail) VALUES (@factoryId, @userId, @detail);"
                cmd.Parameters.Add("@factoryId", SqlDbType.Int).Value = FactoryIDNumericUpDown.Value
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = ConductedByNumericUpDown.Value
                cmd.Parameters.Add("@detail", SqlDbType.NVarChar).Value = DetailsRichTextBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully added new manufacturing log into the database.", MessageBoxIcon.Information)
                DBEmpty = False

            Catch ex As Exception
                MsgBox("Program encountered an error connecting to the database, ensure that the contact and factory exist before contacting your systems admin.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try

            ' Enable features.
            PreviousButton.Enabled = True
            NextButton.Enabled = True
            DeleteLogButton.Enabled = True
            NewLogButton.Enabled = True
            SearchButton.Enabled = True

            ' Hide cancel button.
            CancelCreationButton.Visible = False

            ' Set the ID to the record just created.
            getLastRecordID()
            creatingRecord = False
        ElseIf creatingRecord = True Then
            MsgBox("Please ensure all the details are filled out.", MessageBoxIcon.Warning)
        End If
    End Sub

    ' This will search for a manufacturing log and show the log if it exists.
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ' Verify data is numeric.
        If IsNumeric(SearchTextBox.Text) = True Then
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT * FROM ManufacturingLogs WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = SearchTextBox.Text
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim FactoryID As String
                Dim UserId As String
                Dim Detail As String

                While reader.Read
                    currentId = reader("Id").ToString()
                    FactoryID = reader("FactoryID").ToString()
                    UserId = reader("UserId").ToString()
                    Detail = reader("Detail").ToString()
                End While

                If Detail <> "" Then
                    LogIdTextBox.Text = currentId
                    FactoryIDNumericUpDown.Value = FactoryID
                    ConductedByNumericUpDown.Value = UserId
                    DetailsRichTextBox.Text = Detail
                Else
                    MsgBox("The ID you have specified was incorrect.", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MsgBox("Unable to view the selected manufacturing log." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try
        Else
            MsgBox("Please double check the ID you have entered, it must be numeric.", MessageBoxIcon.Information)
        End If
    End Sub

    ' This will delete a manufacturing log if it exists in the database.
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteLogButton.Click
        Dim result As Integer = MessageBox.Show("Are you sure you wish to delete this manufacturing log? This action is irreversible.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "DELETE FROM ManufacturingLogs WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = currentId
                Dim rowsReturned As Integer = cmd.ExecuteNonQuery()

                MsgBox("The manufacturing log was removed from the database.", MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox("Unable to delete the selected manufacturing log.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try

            ' Must move to another record otherwise deleted record will still be shown in the form.
            getFirstRecord()
        End If
    End Sub

    ' Setup the form for the creation of a new manufacturing log.
    Private Sub NewLogButton_Click(sender As Object, e As EventArgs) Handles NewLogButton.Click
        creatingRecord = True

        ' Clear fields.
        ConductedByNumericUpDown.Value = 1
        FactoryIDNumericUpDown.Value = 1
        DetailsRichTextBox.Clear()

        ' Disable features.
        PreviousButton.Enabled = False
        NextButton.Enabled = False
        DeleteLogButton.Enabled = False
        NewLogButton.Enabled = False
        SearchButton.Enabled = False
        SaveChangesButton.Enabled = True
        LogIdTextBox.Text = "New"

        ' Show cancel button.
        CancelCreationButton.Visible = True

        FactoryIDNumericUpDown.Select()
    End Sub

    ' This will re-enable functionality of the manufacturing logs form when the user cancels creation of a new manufacturing log.
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelCreationButton.Click
        ' Enable features.
        PreviousButton.Enabled = True
        NextButton.Enabled = True
        DeleteLogButton.Enabled = True
        NewLogButton.Enabled = True
        SearchButton.Enabled = True

        If DBEmpty = True Then
            SaveChangesButton.Enabled = False
        End If

        ' Hide cancel button.
        CancelCreationButton.Visible = False

        getFirstRecord()
        FactoryIDNumericUpDown.Select()
    End Sub

    ' This will navigate to the previous manufacturing log if it exists in the database.
    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If currentId <> Nothing Then
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT TOP 1 * FROM ManufacturingLogs WHERE Id < @currentId ORDER BY Id DESC;"
                cmd.Parameters.Add("@currentId", SqlDbType.Int).Value = currentId
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim FactoryID As String
                Dim UserId As String
                Dim Detail As String

                While reader.Read
                    currentId = reader("Id").ToString()
                    FactoryID = reader("FactoryID").ToString()
                    UserId = reader("UserId").ToString()
                    Detail = reader("Detail").ToString()
                End While

                If Detail <> "" Then
                    LogIdTextBox.Text = currentId
                    FactoryIDNumericUpDown.Value = FactoryID
                    ConductedByNumericUpDown.Value = UserId
                    DetailsRichTextBox.Text = Detail
                Else
                    MsgBox("There is not another manufacturing log.", MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MsgBox("Unable to view the manufacturing log." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try
        Else
            MsgBox("Unable to view the manufacturing log.", MessageBoxIcon.Warning)
        End If
    End Sub

    ' This will navigate to the next manufacturing log if it exists in the database.
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If currentId <> Nothing Then
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "SELECT TOP 1 * FROM ManufacturingLogs WHERE Id > @currentId ORDER BY Id;"
                cmd.Parameters.Add("@currentId", SqlDbType.Int).Value = currentId
                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim FactoryID As String
                Dim UserId As String
                Dim Detail As String

                While reader.Read
                    currentId = reader("Id").ToString()
                    FactoryID = reader("FactoryID").ToString()
                    UserId = reader("UserId").ToString()
                    Detail = reader("Detail").ToString()
                End While

                If Detail <> "" Then
                    LogIdTextBox.Text = currentId
                    FactoryIDNumericUpDown.Value = FactoryID
                    ConductedByNumericUpDown.Value = UserId
                    DetailsRichTextBox.Text = Detail
                Else
                    MsgBox("There is not another manufacturing log.", MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MsgBox("Unable to view the manufacturing log." & ex.Message, MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try
        Else
            MsgBox("Unable to view the manufacturing log.", MessageBoxIcon.Warning)
        End If
    End Sub
End Class