<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLog
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConductedByTextBox = New System.Windows.Forms.TextBox()
        Me.FactoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.DetailsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddLogButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 151)
        Me.Panel2.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwissChoco.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(537, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 27)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Enter the details below to add a new log."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 52)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Add Manufacturing Log"
        '
        'ConductedByTextBox
        '
        Me.ConductedByTextBox.Location = New System.Drawing.Point(187, 363)
        Me.ConductedByTextBox.MaxLength = 64
        Me.ConductedByTextBox.Name = "ConductedByTextBox"
        Me.ConductedByTextBox.Size = New System.Drawing.Size(220, 26)
        Me.ConductedByTextBox.TabIndex = 58
        '
        'FactoryIDTextBox
        '
        Me.FactoryIDTextBox.Location = New System.Drawing.Point(187, 312)
        Me.FactoryIDTextBox.MaxLength = 64
        Me.FactoryIDTextBox.Name = "FactoryIDTextBox"
        Me.FactoryIDTextBox.Size = New System.Drawing.Size(220, 26)
        Me.FactoryIDTextBox.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(57, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 31)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Conducted By:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameLabel
        '
        Me.NameLabel.Location = New System.Drawing.Point(90, 313)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(91, 25)
        Me.NameLabel.TabIndex = 55
        Me.NameLabel.Text = "Factory ID:"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DetailsRichTextBox
        '
        Me.DetailsRichTextBox.Location = New System.Drawing.Point(187, 408)
        Me.DetailsRichTextBox.Name = "DetailsRichTextBox"
        Me.DetailsRichTextBox.Size = New System.Drawing.Size(463, 173)
        Me.DetailsRichTextBox.TabIndex = 60
        Me.DetailsRichTextBox.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(44, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 25)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Details:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddLogButton
        '
        Me.AddLogButton.BackColor = System.Drawing.Color.White
        Me.AddLogButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddLogButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.AddLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddLogButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddLogButton.ForeColor = System.Drawing.Color.Black
        Me.AddLogButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddLogButton.Location = New System.Drawing.Point(264, 618)
        Me.AddLogButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddLogButton.Name = "AddLogButton"
        Me.AddLogButton.Size = New System.Drawing.Size(168, 50)
        Me.AddLogButton.TabIndex = 61
        Me.AddLogButton.Text = "Add Log"
        Me.AddLogButton.UseVisualStyleBackColor = False
        '
        'AddLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 725)
        Me.Controls.Add(Me.AddLogButton)
        Me.Controls.Add(Me.DetailsRichTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ConductedByTextBox)
        Me.Controls.Add(Me.FactoryIDTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "AddLog"
        Me.Text = "SwissChoco - Add Manufacturing Log"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ConductedByTextBox As TextBox
    Friend WithEvents FactoryIDTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents DetailsRichTextBox As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AddLogButton As Button
End Class
