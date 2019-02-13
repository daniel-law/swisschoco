﻿Imports System.Data.SqlClient

Public Class ModifyLog

    Public Property Id As String
    Public Property FactoryId As String
    Public Property UserId As String
    Public Property Detail As String

    Private Sub ModifyLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FactoryIDTextBox.Text = FactoryId
        ConductedByTextBox.Text = UserId
        DetailsRichTextBox.Text = Detail
    End Sub

    Private Sub ModifyLogButton_Click(sender As Object, e As EventArgs) Handles ModifyLogButton.Click
        If FactoryIDTextBox.Text <> "" And ConductedByTextBox.Text <> "" And DetailsRichTextBox.Text <> "" Then
            Dim connectionString As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Development;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            Dim cmd As New SqlCommand

            Try
                cmd.Connection = connectionString
                connectionString.Open()
                cmd.CommandText = "UPDATE ManufacturingLogs SET UserId = @userId, Detail = @detail, FactoryId = @factoryId WHERE Id = @Id;"
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = ConductedByTextBox.Text
                cmd.Parameters.Add("@detail", SqlDbType.NVarChar).Value = DetailsRichTextBox.Text
                cmd.Parameters.Add("@factoryId", SqlDbType.Int).Value = FactoryIDTextBox.Text
                cmd.ExecuteNonQuery()

                MsgBox("Sucessfully modified the manufacturing log details.", MessageBoxIcon.Information)

                Me.Close()

            Catch ex As Exception
                MsgBox("Program encountered an error connecting to the database. Urgently contact your systems admin.", MessageBoxIcon.Warning)
                ' DB issues, exit.
                Exit Sub
            End Try
        End If
    End Sub
End Class