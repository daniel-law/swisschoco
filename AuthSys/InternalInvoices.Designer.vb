<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InternalInvoices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InvoiceIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FactoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.NewInvoiceButton = New System.Windows.Forms.Button()
        Me.DeleteInvoiceButton = New System.Windows.Forms.Button()
        Me.SaveChangesButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwissChoco.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(636, 43)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(638, 151)
        Me.Panel2.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 43)
        Me.Panel1.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 27)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "View, modify and delete internal invoices here."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 52)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Internal Invoices"
        '
        'InvoiceIDTextBox
        '
        Me.InvoiceIDTextBox.Location = New System.Drawing.Point(241, 356)
        Me.InvoiceIDTextBox.MaxLength = 64
        Me.InvoiceIDTextBox.Name = "InvoiceIDTextBox"
        Me.InvoiceIDTextBox.Size = New System.Drawing.Size(220, 26)
        Me.InvoiceIDTextBox.TabIndex = 55
        '
        'NameLabel
        '
        Me.NameLabel.Location = New System.Drawing.Point(144, 357)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(91, 25)
        Me.NameLabel.TabIndex = 54
        Me.NameLabel.Text = "Invoice ID:"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(111, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 31)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Factory ID:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FactoryIDTextBox
        '
        Me.FactoryIDTextBox.Location = New System.Drawing.Point(241, 403)
        Me.FactoryIDTextBox.MaxLength = 64
        Me.FactoryIDTextBox.Name = "FactoryIDTextBox"
        Me.FactoryIDTextBox.Size = New System.Drawing.Size(220, 26)
        Me.FactoryIDTextBox.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(111, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 31)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Product IDs:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.Location = New System.Drawing.Point(241, 451)
        Me.ProductIDTextBox.MaxLength = 64
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(220, 26)
        Me.ProductIDTextBox.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(111, 498)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 31)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Contact:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactTextBox
        '
        Me.ContactTextBox.Location = New System.Drawing.Point(241, 503)
        Me.ContactTextBox.MaxLength = 64
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(220, 26)
        Me.ContactTextBox.TabIndex = 61
        '
        'TotalCostNumericUpDown
        '
        Me.TotalCostNumericUpDown.Location = New System.Drawing.Point(241, 550)
        Me.TotalCostNumericUpDown.Name = "TotalCostNumericUpDown"
        Me.TotalCostNumericUpDown.Size = New System.Drawing.Size(120, 26)
        Me.TotalCostNumericUpDown.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(111, 547)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 31)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Total Cost:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.White
        Me.NextButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.ForeColor = System.Drawing.Color.Black
        Me.NextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NextButton.Location = New System.Drawing.Point(300, 634)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(198, 40)
        Me.NextButton.TabIndex = 65
        Me.NextButton.Text = "--->"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'PreviousButton
        '
        Me.PreviousButton.BackColor = System.Drawing.Color.White
        Me.PreviousButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PreviousButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PreviousButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviousButton.ForeColor = System.Drawing.Color.Black
        Me.PreviousButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PreviousButton.Location = New System.Drawing.Point(74, 634)
        Me.PreviousButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(198, 40)
        Me.PreviousButton.TabIndex = 64
        Me.PreviousButton.Text = "<---"
        Me.PreviousButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.White
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.Color.Black
        Me.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelButton.Location = New System.Drawing.Point(549, 260)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(198, 45)
        Me.CancelButton.TabIndex = 72
        Me.CancelButton.Text = "(X) Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        Me.CancelButton.Visible = False
        '
        'NewInvoiceButton
        '
        Me.NewInvoiceButton.BackColor = System.Drawing.Color.White
        Me.NewInvoiceButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewInvoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.NewInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewInvoiceButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewInvoiceButton.ForeColor = System.Drawing.Color.Black
        Me.NewInvoiceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewInvoiceButton.Location = New System.Drawing.Point(549, 634)
        Me.NewInvoiceButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NewInvoiceButton.Name = "NewInvoiceButton"
        Me.NewInvoiceButton.Size = New System.Drawing.Size(198, 45)
        Me.NewInvoiceButton.TabIndex = 71
        Me.NewInvoiceButton.Text = "New Invoice"
        Me.NewInvoiceButton.UseVisualStyleBackColor = False
        '
        'DeleteInvoiceButton
        '
        Me.DeleteInvoiceButton.BackColor = System.Drawing.Color.White
        Me.DeleteInvoiceButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteInvoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DeleteInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteInvoiceButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteInvoiceButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteInvoiceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteInvoiceButton.Location = New System.Drawing.Point(549, 689)
        Me.DeleteInvoiceButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteInvoiceButton.Name = "DeleteInvoiceButton"
        Me.DeleteInvoiceButton.Size = New System.Drawing.Size(198, 45)
        Me.DeleteInvoiceButton.TabIndex = 70
        Me.DeleteInvoiceButton.Text = "Delete Invoice"
        Me.DeleteInvoiceButton.UseVisualStyleBackColor = False
        '
        'SaveChangesButton
        '
        Me.SaveChangesButton.BackColor = System.Drawing.Color.White
        Me.SaveChangesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveChangesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveChangesButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveChangesButton.ForeColor = System.Drawing.Color.Black
        Me.SaveChangesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveChangesButton.Location = New System.Drawing.Point(549, 579)
        Me.SaveChangesButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveChangesButton.Name = "SaveChangesButton"
        Me.SaveChangesButton.Size = New System.Drawing.Size(198, 45)
        Me.SaveChangesButton.TabIndex = 69
        Me.SaveChangesButton.Text = "Save Changes"
        Me.SaveChangesButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(544, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 27)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Search by ID:"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(686, 391)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(61, 26)
        Me.SearchTextBox.TabIndex = 67
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.White
        Me.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.Color.Black
        Me.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchButton.Location = New System.Drawing.Point(549, 437)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(198, 40)
        Me.SearchButton.TabIndex = 66
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'InternalInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 770)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.NewInvoiceButton)
        Me.Controls.Add(Me.DeleteInvoiceButton)
        Me.Controls.Add(Me.SaveChangesButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TotalCostNumericUpDown)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FactoryIDTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.InvoiceIDTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InternalInvoices"
        Me.Text = "SwissChoco - Internal Invoices"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCostNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents InvoiceIDTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FactoryIDTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents TotalCostNumericUpDown As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NextButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents NewInvoiceButton As Button
    Friend WithEvents DeleteInvoiceButton As Button
    Friend WithEvents SaveChangesButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
End Class
