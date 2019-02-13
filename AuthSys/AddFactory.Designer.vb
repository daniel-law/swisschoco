<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFactory
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.CountryComboBox = New System.Windows.Forms.ComboBox()
        Me.AddFactoryButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwissChoco.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(535, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 151)
        Me.Panel2.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(415, 27)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Enter the details below to add a new factory."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 52)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Add Factory"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(211, 325)
        Me.NameTextBox.MaxLength = 64
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(327, 26)
        Me.NameTextBox.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(81, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 31)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Country:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameLabel
        '
        Me.NameLabel.Location = New System.Drawing.Point(114, 326)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(91, 25)
        Me.NameLabel.TabIndex = 59
        Me.NameLabel.Text = "Name:"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CountryComboBox
        '
        Me.CountryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CountryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CountryComboBox.FormattingEnabled = True
        Me.CountryComboBox.Location = New System.Drawing.Point(211, 374)
        Me.CountryComboBox.Name = "CountryComboBox"
        Me.CountryComboBox.Size = New System.Drawing.Size(327, 28)
        Me.CountryComboBox.TabIndex = 62
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
        Me.AddFactoryButton.Location = New System.Drawing.Point(263, 446)
        Me.AddFactoryButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddFactoryButton.Name = "AddFactoryButton"
        Me.AddFactoryButton.Size = New System.Drawing.Size(168, 50)
        Me.AddFactoryButton.TabIndex = 63
        Me.AddFactoryButton.Text = "Add Factory"
        Me.AddFactoryButton.UseVisualStyleBackColor = False
        '
        'AddFactory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 528)
        Me.Controls.Add(Me.AddFactoryButton)
        Me.Controls.Add(Me.CountryComboBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "AddFactory"
        Me.Text = "SwissChoco - Add Factory"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents CountryComboBox As ComboBox
    Friend WithEvents AddFactoryButton As Button
End Class
