﻿Public Class ViewFactory
    Public Property FactoryName As String
    Public Property Locale As String

    Private Sub ViewFactory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Text = FactoryName
        LocaleTextBox.Text = Locale
    End Sub
End Class