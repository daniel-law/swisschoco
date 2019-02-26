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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalCostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.CancelCreationButton = New System.Windows.Forms.Button()
        Me.NewInvoiceButton = New System.Windows.Forms.Button()
        Me.DeleteInvoiceButton = New System.Windows.Forms.Button()
        Me.SaveChangesButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ItemsListBox = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContactNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SelectFactoryButton = New System.Windows.Forms.Button()
        Me.SelectItemsButton = New System.Windows.Forms.Button()
        Me.ContactsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CreateInvoiceButton = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwissChoco.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(1137, 43)
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
        Me.Panel2.Size = New System.Drawing.Size(1139, 151)
        Me.Panel2.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1290, 43)
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
        Me.InvoiceIDTextBox.Location = New System.Drawing.Point(241, 331)
        Me.InvoiceIDTextBox.MaxLength = 64
        Me.InvoiceIDTextBox.Name = "InvoiceIDTextBox"
        Me.InvoiceIDTextBox.ReadOnly = True
        Me.InvoiceIDTextBox.Size = New System.Drawing.Size(220, 26)
        Me.InvoiceIDTextBox.TabIndex = 55
        '
        'NameLabel
        '
        Me.NameLabel.Location = New System.Drawing.Point(144, 332)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(91, 25)
        Me.NameLabel.TabIndex = 54
        Me.NameLabel.Text = "Invoice ID:"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(582, 553)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 31)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Factory ID:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FactoryIDTextBox
        '
        Me.FactoryIDTextBox.Location = New System.Drawing.Point(712, 555)
        Me.FactoryIDTextBox.MaxLength = 64
        Me.FactoryIDTextBox.Name = "FactoryIDTextBox"
        Me.FactoryIDTextBox.ReadOnly = True
        Me.FactoryIDTextBox.Size = New System.Drawing.Size(220, 26)
        Me.FactoryIDTextBox.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(111, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 31)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Contact ID:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalCostNumericUpDown
        '
        Me.TotalCostNumericUpDown.DecimalPlaces = 2
        Me.TotalCostNumericUpDown.Enabled = False
        Me.TotalCostNumericUpDown.Location = New System.Drawing.Point(241, 454)
        Me.TotalCostNumericUpDown.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.TotalCostNumericUpDown.Name = "TotalCostNumericUpDown"
        Me.TotalCostNumericUpDown.ReadOnly = True
        Me.TotalCostNumericUpDown.Size = New System.Drawing.Size(120, 26)
        Me.TotalCostNumericUpDown.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(111, 451)
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
        'CancelCreationButton
        '
        Me.CancelCreationButton.BackColor = System.Drawing.Color.White
        Me.CancelCreationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelCreationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CancelCreationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelCreationButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelCreationButton.ForeColor = System.Drawing.Color.Black
        Me.CancelCreationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelCreationButton.Location = New System.Drawing.Point(1050, 416)
        Me.CancelCreationButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelCreationButton.Name = "CancelCreationButton"
        Me.CancelCreationButton.Size = New System.Drawing.Size(198, 45)
        Me.CancelCreationButton.TabIndex = 72
        Me.CancelCreationButton.Text = "(X) Cancel"
        Me.CancelCreationButton.UseVisualStyleBackColor = False
        Me.CancelCreationButton.Visible = False
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
        Me.NewInvoiceButton.Location = New System.Drawing.Point(1050, 575)
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
        Me.DeleteInvoiceButton.Location = New System.Drawing.Point(1050, 630)
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
        Me.SaveChangesButton.Location = New System.Drawing.Point(1050, 520)
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
        Me.Label7.Location = New System.Drawing.Point(1045, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 27)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Search by ID:"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(1187, 271)
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
        Me.SearchButton.Location = New System.Drawing.Point(1050, 317)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(198, 40)
        Me.SearchButton.TabIndex = 66
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'ItemsListBox
        '
        Me.ItemsListBox.FormattingEnabled = True
        Me.ItemsListBox.ItemHeight = 20
        Me.ItemsListBox.Location = New System.Drawing.Point(571, 269)
        Me.ItemsListBox.Name = "ItemsListBox"
        Me.ItemsListBox.Size = New System.Drawing.Size(384, 204)
        Me.ItemsListBox.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(582, 599)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 31)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Name:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(712, 601)
        Me.NameTextBox.MaxLength = 64
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(220, 26)
        Me.NameTextBox.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(582, 646)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 31)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Country:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Location = New System.Drawing.Point(712, 648)
        Me.CountryTextBox.MaxLength = 64
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.ReadOnly = True
        Me.CountryTextBox.Size = New System.Drawing.Size(220, 26)
        Me.CountryTextBox.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(111, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 31)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Contact Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactNameTextBox
        '
        Me.ContactNameTextBox.Location = New System.Drawing.Point(241, 410)
        Me.ContactNameTextBox.MaxLength = 64
        Me.ContactNameTextBox.Name = "ContactNameTextBox"
        Me.ContactNameTextBox.ReadOnly = True
        Me.ContactNameTextBox.Size = New System.Drawing.Size(220, 26)
        Me.ContactNameTextBox.TabIndex = 79
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(566, 497)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(429, 27)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Below are the details of the associated factory."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(566, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(405, 27)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Below are the details of the item(s) ordered."
        '
        'SelectFactoryButton
        '
        Me.SelectFactoryButton.BackColor = System.Drawing.Color.White
        Me.SelectFactoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelectFactoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SelectFactoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectFactoryButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectFactoryButton.ForeColor = System.Drawing.Color.Black
        Me.SelectFactoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SelectFactoryButton.Location = New System.Drawing.Point(74, 566)
        Me.SelectFactoryButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SelectFactoryButton.Name = "SelectFactoryButton"
        Me.SelectFactoryButton.Size = New System.Drawing.Size(198, 45)
        Me.SelectFactoryButton.TabIndex = 82
        Me.SelectFactoryButton.Text = "Select Factory"
        Me.SelectFactoryButton.UseVisualStyleBackColor = False
        '
        'SelectItemsButton
        '
        Me.SelectItemsButton.BackColor = System.Drawing.Color.White
        Me.SelectItemsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelectItemsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SelectItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectItemsButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectItemsButton.ForeColor = System.Drawing.Color.Black
        Me.SelectItemsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SelectItemsButton.Location = New System.Drawing.Point(300, 566)
        Me.SelectItemsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SelectItemsButton.Name = "SelectItemsButton"
        Me.SelectItemsButton.Size = New System.Drawing.Size(198, 45)
        Me.SelectItemsButton.TabIndex = 83
        Me.SelectItemsButton.Text = "Select Item(s)"
        Me.SelectItemsButton.UseVisualStyleBackColor = False
        '
        'ContactsNumericUpDown
        '
        Me.ContactsNumericUpDown.Location = New System.Drawing.Point(242, 370)
        Me.ContactsNumericUpDown.Maximum = New Decimal(New Integer() {-1304428545, 434162106, 542, 0})
        Me.ContactsNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ContactsNumericUpDown.Name = "ContactsNumericUpDown"
        Me.ContactsNumericUpDown.Size = New System.Drawing.Size(120, 26)
        Me.ContactsNumericUpDown.TabIndex = 84
        Me.ContactsNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CreateInvoiceButton
        '
        Me.CreateInvoiceButton.BackColor = System.Drawing.Color.White
        Me.CreateInvoiceButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateInvoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CreateInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateInvoiceButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateInvoiceButton.ForeColor = System.Drawing.Color.Black
        Me.CreateInvoiceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreateInvoiceButton.Location = New System.Drawing.Point(1050, 471)
        Me.CreateInvoiceButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CreateInvoiceButton.Name = "CreateInvoiceButton"
        Me.CreateInvoiceButton.Size = New System.Drawing.Size(198, 45)
        Me.CreateInvoiceButton.TabIndex = 85
        Me.CreateInvoiceButton.Text = "Create Invoice"
        Me.CreateInvoiceButton.UseVisualStyleBackColor = False
        Me.CreateInvoiceButton.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(111, 493)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 31)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Status:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"In Progress", "Fulfilled", "Cancelled"})
        Me.StatusComboBox.Location = New System.Drawing.Point(241, 493)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(121, 28)
        Me.StatusComboBox.TabIndex = 87
        '
        'InternalInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 718)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CreateInvoiceButton)
        Me.Controls.Add(Me.ContactsNumericUpDown)
        Me.Controls.Add(Me.SelectItemsButton)
        Me.Controls.Add(Me.SelectFactoryButton)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ContactNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ItemsListBox)
        Me.Controls.Add(Me.CancelCreationButton)
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
        Me.Controls.Add(Me.Label5)
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
        CType(Me.ContactsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalCostNumericUpDown As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NextButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents CancelCreationButton As Button
    Friend WithEvents NewInvoiceButton As Button
    Friend WithEvents DeleteInvoiceButton As Button
    Friend WithEvents SaveChangesButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents ItemsListBox As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ContactNameTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents SelectFactoryButton As Button
    Friend WithEvents SelectItemsButton As Button
    Friend WithEvents ContactsNumericUpDown As NumericUpDown
    Friend WithEvents CreateInvoiceButton As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents StatusComboBox As ComboBox
End Class
