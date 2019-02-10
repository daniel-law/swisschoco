<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.SearchFormButton = New System.Windows.Forms.Button()
        Me.FactoriesFormButton = New System.Windows.Forms.Button()
        Me.ContactsFormButton = New System.Windows.Forms.Button()
        Me.ManufacturingLogsFormButton = New System.Windows.Forms.Button()
        Me.InternalInvoicesFormButton = New System.Windows.Forms.Button()
        Me.ProductsFormButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.currentTime = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuickJumpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(961, 151)
        Me.Panel2.TabIndex = 10
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.Location = New System.Drawing.Point(27, 222)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(647, 52)
        Me.WelcomeLabel.TabIndex = 12
        Me.WelcomeLabel.Text = "Good afternoon, {Users.FullName}."
        '
        'SearchFormButton
        '
        Me.SearchFormButton.BackColor = System.Drawing.Color.White
        Me.SearchFormButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchFormButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SearchFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchFormButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchFormButton.ForeColor = System.Drawing.Color.Black
        Me.SearchFormButton.Image = CType(resources.GetObject("SearchFormButton.Image"), System.Drawing.Image)
        Me.SearchFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchFormButton.Location = New System.Drawing.Point(731, 586)
        Me.SearchFormButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchFormButton.Name = "SearchFormButton"
        Me.SearchFormButton.Size = New System.Drawing.Size(305, 152)
        Me.SearchFormButton.TabIndex = 21
        Me.SearchFormButton.Text = "Search"
        Me.SearchFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SearchFormButton.UseVisualStyleBackColor = False
        '
        'FactoriesFormButton
        '
        Me.FactoriesFormButton.BackColor = System.Drawing.Color.White
        Me.FactoriesFormButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FactoriesFormButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.FactoriesFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FactoriesFormButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FactoriesFormButton.ForeColor = System.Drawing.Color.Black
        Me.FactoriesFormButton.Image = CType(resources.GetObject("FactoriesFormButton.Image"), System.Drawing.Image)
        Me.FactoriesFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FactoriesFormButton.Location = New System.Drawing.Point(406, 586)
        Me.FactoriesFormButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FactoriesFormButton.Name = "FactoriesFormButton"
        Me.FactoriesFormButton.Size = New System.Drawing.Size(305, 152)
        Me.FactoriesFormButton.TabIndex = 20
        Me.FactoriesFormButton.Text = "Factories"
        Me.FactoriesFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FactoriesFormButton.UseVisualStyleBackColor = False
        '
        'ContactsFormButton
        '
        Me.ContactsFormButton.BackColor = System.Drawing.Color.White
        Me.ContactsFormButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ContactsFormButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ContactsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContactsFormButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactsFormButton.ForeColor = System.Drawing.Color.Black
        Me.ContactsFormButton.Image = CType(resources.GetObject("ContactsFormButton.Image"), System.Drawing.Image)
        Me.ContactsFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ContactsFormButton.Location = New System.Drawing.Point(83, 586)
        Me.ContactsFormButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ContactsFormButton.Name = "ContactsFormButton"
        Me.ContactsFormButton.Size = New System.Drawing.Size(305, 152)
        Me.ContactsFormButton.TabIndex = 19
        Me.ContactsFormButton.Text = "Contacts"
        Me.ContactsFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ContactsFormButton.UseVisualStyleBackColor = False
        '
        'ManufacturingLogsFormButton
        '
        Me.ManufacturingLogsFormButton.BackColor = System.Drawing.Color.White
        Me.ManufacturingLogsFormButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ManufacturingLogsFormButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ManufacturingLogsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManufacturingLogsFormButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturingLogsFormButton.ForeColor = System.Drawing.Color.Black
        Me.ManufacturingLogsFormButton.Image = CType(resources.GetObject("ManufacturingLogsFormButton.Image"), System.Drawing.Image)
        Me.ManufacturingLogsFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManufacturingLogsFormButton.Location = New System.Drawing.Point(731, 377)
        Me.ManufacturingLogsFormButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ManufacturingLogsFormButton.Name = "ManufacturingLogsFormButton"
        Me.ManufacturingLogsFormButton.Size = New System.Drawing.Size(305, 152)
        Me.ManufacturingLogsFormButton.TabIndex = 15
        Me.ManufacturingLogsFormButton.Text = "Manufacturing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Logs"
        Me.ManufacturingLogsFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ManufacturingLogsFormButton.UseVisualStyleBackColor = False
        '
        'InternalInvoicesFormButton
        '
        Me.InternalInvoicesFormButton.BackColor = System.Drawing.Color.White
        Me.InternalInvoicesFormButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InternalInvoicesFormButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.InternalInvoicesFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InternalInvoicesFormButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InternalInvoicesFormButton.ForeColor = System.Drawing.Color.Black
        Me.InternalInvoicesFormButton.Image = CType(resources.GetObject("InternalInvoicesFormButton.Image"), System.Drawing.Image)
        Me.InternalInvoicesFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InternalInvoicesFormButton.Location = New System.Drawing.Point(406, 377)
        Me.InternalInvoicesFormButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InternalInvoicesFormButton.Name = "InternalInvoicesFormButton"
        Me.InternalInvoicesFormButton.Size = New System.Drawing.Size(305, 153)
        Me.InternalInvoicesFormButton.TabIndex = 14
        Me.InternalInvoicesFormButton.Text = "Internal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Invoices"
        Me.InternalInvoicesFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.InternalInvoicesFormButton.UseVisualStyleBackColor = False
        '
        'ProductsFormButton
        '
        Me.ProductsFormButton.BackColor = System.Drawing.Color.White
        Me.ProductsFormButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductsFormButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ProductsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductsFormButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsFormButton.ForeColor = System.Drawing.Color.Black
        Me.ProductsFormButton.Image = CType(resources.GetObject("ProductsFormButton.Image"), System.Drawing.Image)
        Me.ProductsFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductsFormButton.Location = New System.Drawing.Point(83, 378)
        Me.ProductsFormButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProductsFormButton.Name = "ProductsFormButton"
        Me.ProductsFormButton.Size = New System.Drawing.Size(305, 152)
        Me.ProductsFormButton.TabIndex = 13
        Me.ProductsFormButton.Text = "Products"
        Me.ProductsFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProductsFormButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwissChoco.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(959, 40)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LogoutButton)
        Me.Panel1.Controls.Add(Me.currentTime)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1112, 43)
        Me.Panel1.TabIndex = 26
        '
        'LogoutButton
        '
        Me.LogoutButton.BackColor = System.Drawing.Color.White
        Me.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 7.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.ForeColor = System.Drawing.Color.Black
        Me.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutButton.Location = New System.Drawing.Point(1025, 0)
        Me.LogoutButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(87, 43)
        Me.LogoutButton.TabIndex = 28
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = False
        '
        'currentTime
        '
        Me.currentTime.AutoSize = True
        Me.currentTime.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentTime.Location = New System.Drawing.Point(12, 10)
        Me.currentTime.Name = "currentTime"
        Me.currentTime.Size = New System.Drawing.Size(88, 24)
        Me.currentTime.TabIndex = 27
        Me.currentTime.Text = "Loading..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuickJumpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(147, 4)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(305, 32)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuickJumpToolStripMenuItem
        '
        Me.QuickJumpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsToolStripMenuItem, Me.ContactsToolStripMenuItem})
        Me.QuickJumpToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 9.0!)
        Me.QuickJumpToolStripMenuItem.Name = "QuickJumpToolStripMenuItem"
        Me.QuickJumpToolStripMenuItem.Size = New System.Drawing.Size(117, 28)
        Me.QuickJumpToolStripMenuItem.Text = "Quick Jump"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProductToolStripMenuItem, Me.ViewProductToolStripMenuItem, Me.ModifyProductToolStripMenuItem, Me.DeleteProductToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(164, 30)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'AddProductToolStripMenuItem
        '
        Me.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        Me.AddProductToolStripMenuItem.Size = New System.Drawing.Size(217, 30)
        Me.AddProductToolStripMenuItem.Text = "Add Product"
        '
        'ViewProductToolStripMenuItem
        '
        Me.ViewProductToolStripMenuItem.Name = "ViewProductToolStripMenuItem"
        Me.ViewProductToolStripMenuItem.Size = New System.Drawing.Size(217, 30)
        Me.ViewProductToolStripMenuItem.Text = "View Product"
        '
        'ModifyProductToolStripMenuItem
        '
        Me.ModifyProductToolStripMenuItem.Name = "ModifyProductToolStripMenuItem"
        Me.ModifyProductToolStripMenuItem.Size = New System.Drawing.Size(217, 30)
        Me.ModifyProductToolStripMenuItem.Text = "Modify Product"
        '
        'DeleteProductToolStripMenuItem
        '
        Me.DeleteProductToolStripMenuItem.Name = "DeleteProductToolStripMenuItem"
        Me.DeleteProductToolStripMenuItem.Size = New System.Drawing.Size(217, 30)
        Me.DeleteProductToolStripMenuItem.Text = "Delete Product"
        '
        'ContactsToolStripMenuItem
        '
        Me.ContactsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddContactToolStripMenuItem, Me.ViewContactToolStripMenuItem, Me.ModifyContactToolStripMenuItem, Me.DeleteContactToolStripMenuItem})
        Me.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
        Me.ContactsToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ContactsToolStripMenuItem.Text = "Contacts"
        '
        'AddContactToolStripMenuItem
        '
        Me.AddContactToolStripMenuItem.Name = "AddContactToolStripMenuItem"
        Me.AddContactToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.AddContactToolStripMenuItem.Text = "Add Contact"
        '
        'ViewContactToolStripMenuItem
        '
        Me.ViewContactToolStripMenuItem.Name = "ViewContactToolStripMenuItem"
        Me.ViewContactToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ViewContactToolStripMenuItem.Text = "View Contact"
        '
        'ModifyContactToolStripMenuItem
        '
        Me.ModifyContactToolStripMenuItem.Name = "ModifyContactToolStripMenuItem"
        Me.ModifyContactToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ModifyContactToolStripMenuItem.Text = "Modify Contact"
        '
        'DeleteContactToolStripMenuItem
        '
        Me.DeleteContactToolStripMenuItem.Name = "DeleteContactToolStripMenuItem"
        Me.DeleteContactToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.DeleteContactToolStripMenuItem.Text = "Delete Contact"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1114, 871)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SearchFormButton)
        Me.Controls.Add(Me.FactoriesFormButton)
        Me.Controls.Add(Me.ContactsFormButton)
        Me.Controls.Add(Me.ManufacturingLogsFormButton)
        Me.Controls.Add(Me.InternalInvoicesFormButton)
        Me.Controls.Add(Me.ProductsFormButton)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "MainMenu"
        Me.Text = "SwissChoco - Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WelcomeLabel As Label
    Friend WithEvents ProductsFormButton As Button
    Friend WithEvents InternalInvoicesFormButton As Button
    Friend WithEvents ManufacturingLogsFormButton As Button
    Friend WithEvents ContactsFormButton As Button
    Friend WithEvents FactoriesFormButton As Button
    Friend WithEvents SearchFormButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents currentTime As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuickJumpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteContactToolStripMenuItem As ToolStripMenuItem
End Class
