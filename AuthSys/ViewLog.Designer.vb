<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewLog
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
        Me.DetailsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ConductedByTextBox = New System.Windows.Forms.TextBox()
        Me.FactoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 151)
        Me.Panel2.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 27)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Below are the details of the log."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 52)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "View Manufacturing Log"
        '
        'DetailsRichTextBox
        '
        Me.DetailsRichTextBox.Location = New System.Drawing.Point(185, 391)
        Me.DetailsRichTextBox.Name = "DetailsRichTextBox"
        Me.DetailsRichTextBox.ReadOnly = True
        Me.DetailsRichTextBox.Size = New System.Drawing.Size(463, 173)
        Me.DetailsRichTextBox.TabIndex = 66
        Me.DetailsRichTextBox.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(42, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 25)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Details:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ConductedByTextBox
        '
        Me.ConductedByTextBox.Location = New System.Drawing.Point(185, 346)
        Me.ConductedByTextBox.MaxLength = 64
        Me.ConductedByTextBox.Name = "ConductedByTextBox"
        Me.ConductedByTextBox.ReadOnly = True
        Me.ConductedByTextBox.Size = New System.Drawing.Size(220, 26)
        Me.ConductedByTextBox.TabIndex = 64
        '
        'FactoryIDTextBox
        '
        Me.FactoryIDTextBox.Location = New System.Drawing.Point(185, 295)
        Me.FactoryIDTextBox.MaxLength = 64
        Me.FactoryIDTextBox.Name = "FactoryIDTextBox"
        Me.FactoryIDTextBox.ReadOnly = True
        Me.FactoryIDTextBox.Size = New System.Drawing.Size(220, 26)
        Me.FactoryIDTextBox.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(55, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 31)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Conducted By:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameLabel
        '
        Me.NameLabel.Location = New System.Drawing.Point(88, 296)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(91, 25)
        Me.NameLabel.TabIndex = 61
        Me.NameLabel.Text = "Factory ID:"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ViewLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 613)
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
        Me.Name = "ViewLog"
        Me.Text = "SwissChoco - View Manufacturing Log"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DetailsRichTextBox As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ConductedByTextBox As TextBox
    Friend WithEvents FactoryIDTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NameLabel As Label
End Class
