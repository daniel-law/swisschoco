<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Contacts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClearResultsButton = New System.Windows.Forms.Button()
        Me.ModifyContactButton = New System.Windows.Forms.Button()
        Me.AddContactButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RefreshContactsButton = New System.Windows.Forms.Button()
        Me.DeleteContactButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ContactsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevelopmentDataSet = New SwissChoco.DevelopmentDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContactsTableAdapter = New SwissChoco.DevelopmentDataSetTableAdapters.ContactsTableAdapter()
        CType(Me.ContactsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevelopmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1206, 52)
        Me.Panel1.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1056, 151)
        Me.Panel2.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(30, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 27)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "View, modify and delete contacts here."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 52)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Contacts"
        '
        'ClearResultsButton
        '
        Me.ClearResultsButton.BackColor = System.Drawing.Color.White
        Me.ClearResultsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearResultsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ClearResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearResultsButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearResultsButton.ForeColor = System.Drawing.Color.Black
        Me.ClearResultsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearResultsButton.Location = New System.Drawing.Point(965, 436)
        Me.ClearResultsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ClearResultsButton.Name = "ClearResultsButton"
        Me.ClearResultsButton.Size = New System.Drawing.Size(198, 40)
        Me.ClearResultsButton.TabIndex = 39
        Me.ClearResultsButton.Text = "Clear Results"
        Me.ClearResultsButton.UseVisualStyleBackColor = False
        '
        'ModifyContactButton
        '
        Me.ModifyContactButton.BackColor = System.Drawing.Color.White
        Me.ModifyContactButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ModifyContactButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ModifyContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModifyContactButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifyContactButton.ForeColor = System.Drawing.Color.Black
        Me.ModifyContactButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModifyContactButton.Location = New System.Drawing.Point(965, 777)
        Me.ModifyContactButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ModifyContactButton.Name = "ModifyContactButton"
        Me.ModifyContactButton.Size = New System.Drawing.Size(198, 50)
        Me.ModifyContactButton.TabIndex = 38
        Me.ModifyContactButton.Text = "Modify Contact"
        Me.ModifyContactButton.UseVisualStyleBackColor = False
        '
        'AddContactButton
        '
        Me.AddContactButton.BackColor = System.Drawing.Color.White
        Me.AddContactButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddContactButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddContactButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddContactButton.ForeColor = System.Drawing.Color.Black
        Me.AddContactButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddContactButton.Location = New System.Drawing.Point(965, 717)
        Me.AddContactButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddContactButton.Name = "AddContactButton"
        Me.AddContactButton.Size = New System.Drawing.Size(198, 50)
        Me.AddContactButton.TabIndex = 37
        Me.AddContactButton.Text = "Add Contact"
        Me.AddContactButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(960, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 27)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Search by ID:"
        '
        'RefreshContactsButton
        '
        Me.RefreshContactsButton.BackColor = System.Drawing.Color.White
        Me.RefreshContactsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshContactsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RefreshContactsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshContactsButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshContactsButton.ForeColor = System.Drawing.Color.Black
        Me.RefreshContactsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RefreshContactsButton.Location = New System.Drawing.Point(982, 233)
        Me.RefreshContactsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RefreshContactsButton.Name = "RefreshContactsButton"
        Me.RefreshContactsButton.Size = New System.Drawing.Size(201, 50)
        Me.RefreshContactsButton.TabIndex = 35
        Me.RefreshContactsButton.Text = "Refresh Contacts"
        Me.RefreshContactsButton.UseVisualStyleBackColor = False
        '
        'DeleteContactButton
        '
        Me.DeleteContactButton.BackColor = System.Drawing.Color.White
        Me.DeleteContactButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteContactButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DeleteContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteContactButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteContactButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteContactButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteContactButton.Location = New System.Drawing.Point(965, 837)
        Me.DeleteContactButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteContactButton.Name = "DeleteContactButton"
        Me.DeleteContactButton.Size = New System.Drawing.Size(198, 50)
        Me.DeleteContactButton.TabIndex = 34
        Me.DeleteContactButton.Text = "Delete Contact"
        Me.DeleteContactButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(1102, 340)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(61, 26)
        Me.SearchTextBox.TabIndex = 33
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
        Me.SearchButton.Location = New System.Drawing.Point(965, 386)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(198, 40)
        Me.SearchButton.TabIndex = 32
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'ContactsDataGridView
        '
        Me.ContactsDataGridView.AutoGenerateColumns = False
        Me.ContactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column1})
        Me.ContactsDataGridView.DataSource = Me.ContactsBindingSource
        Me.ContactsDataGridView.Location = New System.Drawing.Point(35, 333)
        Me.ContactsDataGridView.MultiSelect = False
        Me.ContactsDataGridView.Name = "ContactsDataGridView"
        Me.ContactsDataGridView.ReadOnly = True
        Me.ContactsDataGridView.RowTemplate.Height = 28
        Me.ContactsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ContactsDataGridView.Size = New System.Drawing.Size(851, 561)
        Me.ContactsDataGridView.TabIndex = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telephone"
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Telephone"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'ContactsBindingSource
        '
        Me.ContactsBindingSource.DataMember = "Contacts"
        Me.ContactsBindingSource.DataSource = Me.DevelopmentDataSet
        '
        'DevelopmentDataSet
        '
        Me.DevelopmentDataSet.DataSetName = "DevelopmentDataSet"
        Me.DevelopmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwissChoco.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(1053, 41)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'ContactsTableAdapter
        '
        Me.ContactsTableAdapter.ClearBeforeFill = True
        '
        'Contacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 925)
        Me.Controls.Add(Me.ContactsDataGridView)
        Me.Controls.Add(Me.ClearResultsButton)
        Me.Controls.Add(Me.ModifyContactButton)
        Me.Controls.Add(Me.AddContactButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RefreshContactsButton)
        Me.Controls.Add(Me.DeleteContactButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Contacts"
        Me.Text = "SwissChoco - Contacts"
        CType(Me.ContactsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevelopmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ClearResultsButton As Button
    Friend WithEvents ModifyContactButton As Button
    Friend WithEvents AddContactButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents RefreshContactsButton As Button
    Friend WithEvents DeleteContactButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents ContactsDataGridView As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DevelopmentDataSet As DevelopmentDataSet
    Friend WithEvents ContactsBindingSource As BindingSource
    Friend WithEvents ContactsTableAdapter As DevelopmentDataSetTableAdapters.ContactsTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
