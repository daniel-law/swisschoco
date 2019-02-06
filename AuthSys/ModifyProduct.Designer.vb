<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyProduct
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModifyProductButton = New System.Windows.Forms.Button()
        Me.IngredientsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WeightNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.DescriptionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwissChoco.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(537, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 151)
        Me.Panel2.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(431, 27)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Change the details below to modify a product."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 52)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Modify Product"
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
        Me.ModifyProductButton.Location = New System.Drawing.Point(267, 848)
        Me.ModifyProductButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ModifyProductButton.Name = "ModifyProductButton"
        Me.ModifyProductButton.Size = New System.Drawing.Size(168, 62)
        Me.ModifyProductButton.TabIndex = 44
        Me.ModifyProductButton.Text = "Modify Product"
        Me.ModifyProductButton.UseVisualStyleBackColor = False
        '
        'IngredientsRichTextBox
        '
        Me.IngredientsRichTextBox.Location = New System.Drawing.Point(187, 673)
        Me.IngredientsRichTextBox.Name = "IngredientsRichTextBox"
        Me.IngredientsRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.IngredientsRichTextBox.Size = New System.Drawing.Size(351, 161)
        Me.IngredientsRichTextBox.TabIndex = 43
        Me.IngredientsRichTextBox.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(90, 674)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 37)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Ingredients"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(90, 628)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 37)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Weight:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WeightNumericUpDown
        '
        Me.WeightNumericUpDown.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.WeightNumericUpDown.Location = New System.Drawing.Point(187, 634)
        Me.WeightNumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.WeightNumericUpDown.Name = "WeightNumericUpDown"
        Me.WeightNumericUpDown.Size = New System.Drawing.Size(120, 26)
        Me.WeightNumericUpDown.TabIndex = 40
        '
        'DescriptionRichTextBox
        '
        Me.DescriptionRichTextBox.Location = New System.Drawing.Point(187, 458)
        Me.DescriptionRichTextBox.Name = "DescriptionRichTextBox"
        Me.DescriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.DescriptionRichTextBox.Size = New System.Drawing.Size(351, 161)
        Me.DescriptionRichTextBox.TabIndex = 39
        Me.DescriptionRichTextBox.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(90, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 37)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Description:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(90, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 37)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Picture:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureTextBox
        '
        Me.PictureTextBox.Location = New System.Drawing.Point(187, 419)
        Me.PictureTextBox.Name = "PictureTextBox"
        Me.PictureTextBox.Size = New System.Drawing.Size(220, 26)
        Me.PictureTextBox.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(90, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 37)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Price:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PriceNumericUpDown
        '
        Me.PriceNumericUpDown.DecimalPlaces = 2
        Me.PriceNumericUpDown.Location = New System.Drawing.Point(187, 374)
        Me.PriceNumericUpDown.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.PriceNumericUpDown.Name = "PriceNumericUpDown"
        Me.PriceNumericUpDown.Size = New System.Drawing.Size(120, 26)
        Me.PriceNumericUpDown.TabIndex = 34
        '
        'NameLabel
        '
        Me.NameLabel.Location = New System.Drawing.Point(90, 315)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(91, 37)
        Me.NameLabel.TabIndex = 33
        Me.NameLabel.Text = "Name:"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(187, 327)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(220, 26)
        Me.NameTextBox.TabIndex = 32
        '
        'ModifyProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 933)
        Me.Controls.Add(Me.ModifyProductButton)
        Me.Controls.Add(Me.IngredientsRichTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.WeightNumericUpDown)
        Me.Controls.Add(Me.DescriptionRichTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PriceNumericUpDown)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ModifyProduct"
        Me.Text = "SwissChoco - Modify Product"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ModifyProductButton As Button
    Friend WithEvents IngredientsRichTextBox As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents WeightNumericUpDown As NumericUpDown
    Friend WithEvents DescriptionRichTextBox As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PriceNumericUpDown As NumericUpDown
    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
End Class
