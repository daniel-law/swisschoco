Imports System.Data.SqlClient

Public Class ManufacturingLogs

    Dim currentId As String
    Dim creatingRecord As Boolean

    Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Dim cmd As New SqlCommand

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
            FactoryIDTextBox.Text = FactoryID
            ConductedByTextBox.Text = UserId
            DetailsRichTextBox.Text = Detail

        Catch ex As Exception
            MsgBox("Unable to view the selected manufacturing log.", MessageBoxIcon.Warning)
            ' DB issues, exit.
            Exit Sub
        Finally
            cmd.Parameters.Clear()
            connectionString.Close()
        End Try
    End Sub

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

    Private Sub ManufacturingLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getFirstRecord()
    End Sub

    Private Sub SaveChangesButton_Click(sender As Object, e As EventArgs) Handles SaveChangesButton.Click
        If FactoryIDTextBox.Text <> "" And ConductedByTextBox.Text <> "" And DetailsRichTextBox.Text <> "" And creatingRecord = False Then
            ' Updating current record.
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "UPDATE ManufacturingLogs SET UserId = @userId, Detail = @detail, FactoryId = @factoryId WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = currentId
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = ConductedByTextBox.Text
                cmd.Parameters.Add("@detail", SqlDbType.NVarChar).Value = DetailsRichTextBox.Text
                cmd.Parameters.Add("@factoryId", SqlDbType.Int).Value = FactoryIDTextBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully modified the manufacturing log details.", MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            Finally
                cmd.Parameters.Clear()
                connectionString.Close()
            End Try
        End If

        If FactoryIDTextBox.Text <> "" And ConductedByTextBox.Text <> "" And DetailsRichTextBox.Text <> "" And creatingRecord = True Then
            ' Adding new record.
            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "INSERT INTO ManufacturingLogs (FactoryId, UserId, Detail) VALUES (@factoryId, @userId, @detail);"
                cmd.Parameters.Add("@factoryId", SqlDbType.Int).Value = FactoryIDTextBox.Text
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = ConductedByTextBox.Text
                cmd.Parameters.Add("@detail", SqlDbType.NVarChar).Value = DetailsRichTextBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully added new manufacturing log into the database.", MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
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
            CancelButton.Visible = False

            ' Set the ID to the record just created.
            getLastRecordID()
            creatingRecord = False
        End If
    End Sub

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
                    FactoryIDTextBox.Text = FactoryID
                    ConductedByTextBox.Text = UserId
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

    Private Sub NewLogButton_Click(sender As Object, e As EventArgs) Handles NewLogButton.Click
        creatingRecord = True

        ' Clear fields.
        ConductedByTextBox.Clear()
        FactoryIDTextBox.Clear()
        DetailsRichTextBox.Clear()

        ' Disable features.
        PreviousButton.Enabled = False
        NextButton.Enabled = False
        DeleteLogButton.Enabled = False
        NewLogButton.Enabled = False
        SearchButton.Enabled = False
        LogIdTextBox.Text = "New"

        ' Show cancel button.
        CancelButton.Visible = True

        FactoryIDTextBox.Select()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ' Enable features.
        PreviousButton.Enabled = True
        NextButton.Enabled = True
        DeleteLogButton.Enabled = True
        NewLogButton.Enabled = True
        SearchButton.Enabled = True

        ' Hide cancel button.
        CancelButton.Visible = False

        getFirstRecord()
    End Sub

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
                    FactoryIDTextBox.Text = FactoryID
                    ConductedByTextBox.Text = UserId
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
                    FactoryIDTextBox.Text = FactoryID
                    ConductedByTextBox.Text = UserId
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