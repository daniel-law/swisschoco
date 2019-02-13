<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factories
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClearResultsButton = New System.Windows.Forms.Button()
        Me.ModifyFactoryButton = New System.Windows.Forms.Button()
        Me.AddFactoryButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RefreshContactsButton = New System.Windows.Forms.Button()
        Me.DeleteFactoryButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FactoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevelopmentDataSet = New SwissChoco.DevelopmentDataSet()
        Me.FactoriesTableAdapter = New SwissChoco.DevelopmentDataSetTableAdapters.FactoriesTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1056, 151)
        Me.Panel2.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 27)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "View, modify and delete factories here."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 52)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Factories"
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
        Me.ClearResultsButton.Location = New System.Drawing.Point(952, 448)
        Me.ClearResultsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ClearResultsButton.Name = "ClearResultsButton"
        Me.ClearResultsButton.Size = New System.Drawing.Size(198, 40)
        Me.ClearResultsButton.TabIndex = 47
        Me.ClearResultsButton.Text = "Clear Results"
        Me.ClearResultsButton.UseVisualStyleBackColor = False
        '
        'ModifyFactoryButton
        '
        Me.ModifyFactoryButton.BackColor = System.Drawing.Color.White
        Me.ModifyFactoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ModifyFactoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ModifyFactoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModifyFactoryButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifyFactoryButton.ForeColor = System.Drawing.Color.Black
        Me.ModifyFactoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModifyFactoryButton.Location = New System.Drawing.Point(952, 789)
        Me.ModifyFactoryButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ModifyFactoryButton.Name = "ModifyFactoryButton"
        Me.ModifyFactoryButton.Size = New System.Drawing.Size(198, 50)
        Me.ModifyFactoryButton.TabIndex = 46
        Me.ModifyFactoryButton.Text = "Modify Factory"
        Me.ModifyFactoryButton.UseVisualStyleBackColor = False
        '
        'AddFactoryButton
        '
        Me.AddFactoryButton.BackColor = System.Drawing.Color.White
        Me.AddFactoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddFactoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.AddFactoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddFactoryButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddFactoryButton.ForeColor = System.Drawing.Color.Black
        Me.AddFactoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddFactoryButton.Location = New System.Drawing.Point(952, 729)
        Me.AddFactoryButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddFactoryButton.Name = "AddFactoryButton"
        Me.AddFactoryButton.Size = New System.Drawing.Size(198, 50)
        Me.AddFactoryButton.TabIndex = 45
        Me.AddFactoryButton.Text = "Add Factory"
        Me.AddFactoryButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(947, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 27)
        Me.Label3.TabIndex = 44
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
        Me.RefreshContactsButton.Location = New System.Drawing.Point(969, 245)
        Me.RefreshContactsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RefreshContactsButton.Name = "RefreshContactsButton"
        Me.RefreshContactsButton.Size = New System.Drawing.Size(201, 50)
        Me.RefreshContactsButton.TabIndex = 43
        Me.RefreshContactsButton.Text = "Refresh Factories"
        Me.RefreshContactsButton.UseVisualStyleBackColor = False
        '
        'DeleteFactoryButton
        '
        Me.DeleteFactoryButton.BackColor = System.Drawing.Color.White
        Me.DeleteFactoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteFactoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DeleteFactoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteFactoryButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteFactoryButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteFactoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteFactoryButton.Location = New System.Drawing.Point(952, 849)
        Me.DeleteFactoryButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteFactoryButton.Name = "DeleteFactoryButton"
        Me.DeleteFactoryButton.Size = New System.Drawing.Size(198, 50)
        Me.DeleteFactoryButton.TabIndex = 42
        Me.DeleteFactoryButton.Text = "Delete Factory"
        Me.DeleteFactoryButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(1089, 352)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(61, 26)
        Me.SearchTextBox.TabIndex = 41
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
        Me.SearchButton.Location = New System.Drawing.Point(952, 398)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(198, 40)
        Me.SearchButton.TabIndex = 40
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.LocaleDataGridViewTextBoxColumn, Me.Column1, Me.Column2})
        Me.DataGridView1.DataSource = Me.FactoriesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(42, 339)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(847, 561)
        Me.DataGridView1.TabIndex = 48
        '
        'FactoriesBindingSource
        '
        Me.FactoriesBindingSource.DataMember = "Factories"
        Me.FactoriesBindingSource.DataSource = Me.DevelopmentDataSet
        '
        'DevelopmentDataSet
        '
        Me.DevelopmentDataSet.DataSetName = "DevelopmentDataSet"
        Me.DevelopmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FactoriesTableAdapter
        '
        Me.FactoriesTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.Frozen = True
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.Frozen = True
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 200
        '
        'LocaleDataGridViewTextBoxColumn
        '
        Me.LocaleDataGridViewTextBoxColumn.DataPropertyName = "Locale"
        Me.LocaleDataGridViewTextBoxColumn.Frozen = True
        Me.LocaleDataGridViewTextBoxColumn.HeaderText = "Locale"
        Me.LocaleDataGridViewTextBoxColumn.Name = "LocaleDataGridViewTextBoxColumn"
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwissChoco.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(1053, 41)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Factories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 925)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ClearResultsButton)
        Me.Controls.Add(Me.ModifyFactoryButton)
        Me.Controls.Add(Me.AddFactoryButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RefreshContactsButton)
        Me.Controls.Add(Me.DeleteFactoryButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Factories"
        Me.Text = "SwissChoco - Factories"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ModifyFactoryButton As Button
    Friend WithEvents AddFactoryButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents RefreshContactsButton As Button
    Friend WithEvents DeleteFactoryButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DevelopmentDataSet As DevelopmentDataSet
    Friend WithEvents FactoriesBindingSource As BindingSource
    Friend WithEvents FactoriesTableAdapter As DevelopmentDataSetTableAdapters.FactoriesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocaleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
