<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddContact
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AddContactButton = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwissChoco.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(537, 0)
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
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 151)
        Me.Panel2.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(420, 27)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Enter the details below to add a new contact."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 52)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Add Contact"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(103, 421)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Phone Number:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(140, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Email:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameLabel
        '
        Me.NameLabel.Location = New System.Drawing.Point(149, 323)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(91, 25)
        Me.NameLabel.TabIndex = 26
        Me.NameLabel.Text = "Name:"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.AddContactButton.Location = New System.Drawing.Point(246, 512)
        Me.AddContactButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddContactButton.Name = "AddContactButton"
        Me.AddContactButton.Size = New System.Drawing.Size(168, 50)
        Me.AddContactButton.TabIndex = 32
        Me.AddContactButton.Text = "Add Contact"
        Me.AddContactButton.UseVisualStyleBackColor = False
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(246, 323)
        Me.NameTextBox.MaxLength = 64
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(220, 26)
        Me.NameTextBox.TabIndex = 33
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(246, 370)
        Me.EmailTextBox.MaxLength = 64
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(220, 26)
        Me.EmailTextBox.TabIndex = 34
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(246, 420)
        Me.PhoneNumberTextBox.MaxLength = 64
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(220, 26)
        Me.PhoneNumberTextBox.TabIndex = 35
        '
        'AddContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(691, 630)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.AddContactButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "AddContact"
        Me.Text = "SwissChoco - Add Contact"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddContactButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
End Class
