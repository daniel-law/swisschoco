<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevelopmentDataSet = New SwissChoco.DevelopmentDataSet()
        Me.ProductsTableAdapter = New SwissChoco.DevelopmentDataSetTableAdapters.ProductsTableAdapter()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.DeleteProductButton = New System.Windows.Forms.Button()
        Me.RefreshProductsButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddProductButton = New System.Windows.Forms.Button()
        Me.ModifyProductButton = New System.Windows.Forms.Button()
        Me.ClearResultsButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevelopmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1834, 151)
        Me.Panel2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 52)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Products"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(31, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 27)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "View, modify and delete products here."
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.PictureDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.IngredientsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(36, 336)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1607, 556)
        Me.DataGridView1.TabIndex = 17
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.Frozen = True
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdDataGridViewTextBoxColumn.Width = 62
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 150
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price /GBP"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 50
        '
        'PictureDataGridViewTextBoxColumn
        '
        Me.PictureDataGridViewTextBoxColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewTextBoxColumn.HeaderText = "Picture"
        Me.PictureDataGridViewTextBoxColumn.Name = "PictureDataGridViewTextBoxColumn"
        Me.PictureDataGridViewTextBoxColumn.ReadOnly = True
        Me.PictureDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PictureDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PictureDataGridViewTextBoxColumn.Width = 200
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight /g"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.ReadOnly = True
        Me.WeightDataGridViewTextBoxColumn.Width = 50
        '
        'IngredientsDataGridViewTextBoxColumn
        '
        Me.IngredientsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IngredientsDataGridViewTextBoxColumn.DataPropertyName = "Ingredients"
        Me.IngredientsDataGridViewTextBoxColumn.HeaderText = "Ingredients"
        Me.IngredientsDataGridViewTextBoxColumn.Name = "IngredientsDataGridViewTextBoxColumn"
        Me.IngredientsDataGridViewTextBoxColumn.ReadOnly = True
        Me.IngredientsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IngredientsDataGridViewTextBoxColumn.Width = 300
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.DevelopmentDataSet
        '
        'DevelopmentDataSet
        '
        Me.DevelopmentDataSet.DataSetName = "DevelopmentDataSet"
        Me.DevelopmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
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
        Me.SearchButton.Location = New System.Drawing.Point(1739, 384)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(198, 40)
        Me.SearchButton.TabIndex = 18
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(1876, 338)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(61, 26)
        Me.SearchTextBox.TabIndex = 19
        '
        'DeleteProductButton
        '
        Me.DeleteProductButton.BackColor = System.Drawing.Color.White
        Me.DeleteProductButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteProductButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteProductButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteProductButton.Location = New System.Drawing.Point(1739, 835)
        Me.DeleteProductButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteProductButton.Name = "DeleteProductButton"
        Me.DeleteProductButton.Size = New System.Drawing.Size(198, 50)
        Me.DeleteProductButton.TabIndex = 20
        Me.DeleteProductButton.Text = "Delete Product"
        Me.DeleteProductButton.UseVisualStyleBackColor = False
        '
        'RefreshProductsButton
        '
        Me.RefreshProductsButton.BackColor = System.Drawing.Color.White
        Me.RefreshProductsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RefreshProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshProductsButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshProductsButton.ForeColor = System.Drawing.Color.Black
        Me.RefreshProductsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RefreshProductsButton.Location = New System.Drawing.Point(1756, 231)
        Me.RefreshProductsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RefreshProductsButton.Name = "RefreshProductsButton"
        Me.RefreshProductsButton.Size = New System.Drawing.Size(201, 50)
        Me.RefreshProductsButton.TabIndex = 21
        Me.RefreshProductsButton.Text = "Refresh Products"
        Me.RefreshProductsButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(1734, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 27)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Search by ID:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1987, 48)
        Me.Panel1.TabIndex = 25
        '
        'AddProductButton
        '
        Me.AddProductButton.BackColor = System.Drawing.Color.White
        Me.AddProductButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddProductButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProductButton.ForeColor = System.Drawing.Color.Black
        Me.AddProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddProductButton.Location = New System.Drawing.Point(1739, 715)
        Me.AddProductButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddProductButton.Name = "AddProductButton"
        Me.AddProductButton.Size = New System.Drawing.Size(198, 50)
        Me.AddProductButton.TabIndex = 26
        Me.AddProductButton.Text = "Add Product"
        Me.AddProductButton.UseVisualStyleBackColor = False
        '
        'ModifyProductButton
        '
        Me.ModifyProductButton.BackColor = System.Drawing.Color.White
        Me.ModifyProductButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ModifyProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ModifyProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModifyProductButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifyProductButton.ForeColor = System.Drawing.Color.Black
        Me.ModifyProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModifyProductButton.Location = New System.Drawing.Point(1739, 775)
        Me.ModifyProductButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ModifyProductButton.Name = "ModifyProductButton"
        Me.ModifyProductButton.Size = New System.Drawing.Size(198, 50)
        Me.ModifyProductButton.TabIndex = 27
        Me.ModifyProductButton.Text = "Modify Product"
        Me.ModifyProductButton.UseVisualStyleBackColor = False
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
        Me.ClearResultsButton.Location = New System.Drawing.Point(1739, 434)
        Me.ClearResultsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ClearResultsButton.Name = "ClearResultsButton"
        Me.ClearResultsButton.Size = New System.Drawing.Size(198, 40)
        Me.ClearResultsButton.TabIndex = 28
        Me.ClearResultsButton.Text = "Clear Results"
        Me.ClearResultsButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwissChoco.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(1834, 40)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1986, 925)
        Me.Controls.Add(Me.ClearResultsButton)
        Me.Controls.Add(Me.ModifyProductButton)
        Me.Controls.Add(Me.AddProductButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RefreshProductsButton)
        Me.Controls.Add(Me.DeleteProductButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Products"
        Me.Text = "SwissChoco - Products"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevelopmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DevelopmentDataSet As DevelopmentDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As DevelopmentDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents DeleteProductButton As Button
    Friend WithEvents RefreshProductsButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AddProductButton As Button
    Friend WithEvents ModifyProductButton As Button
    Friend WithEvents ClearResultsButton As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewTextBoxColumn As DataGridViewImageColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IngredientsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
