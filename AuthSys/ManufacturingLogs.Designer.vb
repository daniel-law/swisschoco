<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManufacturingLogs
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.FactoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.ConductedByTextBox = New System.Windows.Forms.TextBox()
        Me.DetailsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.SaveChangesButton = New System.Windows.Forms.Button()
        Me.DeleteLogButton = New System.Windows.Forms.Button()
        Me.NewLogButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1112, 43)
        Me.Panel1.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwissChoco.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(960, 42)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(1, 42)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(961, 151)
        Me.Panel2.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(463, 27)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "View, modify and delete manufacturing logs here."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 52)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Manufacturing Logs"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(98, 462)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 25)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Details:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(102, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 31)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Conducted By:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameLabel
        '
        Me.NameLabel.Location = New System.Drawing.Point(144, 368)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(91, 25)
        Me.NameLabel.TabIndex = 50
        Me.NameLabel.Text = "Factory ID:"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FactoryIDTextBox
        '
        Me.FactoryIDTextBox.Location = New System.Drawing.Point(241, 367)
        Me.FactoryIDTextBox.MaxLength = 64
        Me.FactoryIDTextBox.Name = "FactoryIDTextBox"
        Me.FactoryIDTextBox.Size = New System.Drawing.Size(220, 26)
        Me.FactoryIDTextBox.TabIndex = 53
        '
        'ConductedByTextBox
        '
        Me.ConductedByTextBox.Location = New System.Drawing.Point(241, 418)
        Me.ConductedByTextBox.MaxLength = 64
        Me.ConductedByTextBox.Name = "ConductedByTextBox"
        Me.ConductedByTextBox.Size = New System.Drawing.Size(220, 26)
        Me.ConductedByTextBox.TabIndex = 54
        '
        'DetailsRichTextBox
        '
        Me.DetailsRichTextBox.Location = New System.Drawing.Point(241, 462)
        Me.DetailsRichTextBox.Name = "DetailsRichTextBox"
        Me.DetailsRichTextBox.Size = New System.Drawing.Size(463, 129)
        Me.DetailsRichTextBox.TabIndex = 55
        Me.DetailsRichTextBox.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(836, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 27)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Search by ID:"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(978, 358)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(61, 26)
        Me.SearchTextBox.TabIndex = 57
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
        Me.SearchButton.Location = New System.Drawing.Point(841, 404)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(198, 40)
        Me.SearchButton.TabIndex = 56
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
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
        Me.PreviousButton.Location = New System.Drawing.Point(102, 668)
        Me.PreviousButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(198, 40)
        Me.PreviousButton.TabIndex = 59
        Me.PreviousButton.Text = "<---"
        Me.PreviousButton.UseVisualStyleBackColor = False
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
        Me.NextButton.Location = New System.Drawing.Point(506, 668)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(198, 40)
        Me.NextButton.TabIndex = 60
        Me.NextButton.Text = "--->"
        Me.NextButton.UseVisualStyleBackColor = False
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
        Me.SaveChangesButton.Location = New System.Drawing.Point(841, 546)
        Me.SaveChangesButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveChangesButton.Name = "SaveChangesButton"
        Me.SaveChangesButton.Size = New System.Drawing.Size(198, 45)
        Me.SaveChangesButton.TabIndex = 61
        Me.SaveChangesButton.Text = "Save Changes"
        Me.SaveChangesButton.UseVisualStyleBackColor = False
        '
        'DeleteLogButton
        '
        Me.DeleteLogButton.BackColor = System.Drawing.Color.White
        Me.DeleteLogButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteLogButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DeleteLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteLogButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteLogButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteLogButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteLogButton.Location = New System.Drawing.Point(841, 656)
        Me.DeleteLogButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteLogButton.Name = "DeleteLogButton"
        Me.DeleteLogButton.Size = New System.Drawing.Size(198, 45)
        Me.DeleteLogButton.TabIndex = 63
        Me.DeleteLogButton.Text = "Delete Log"
        Me.DeleteLogButton.UseVisualStyleBackColor = False
        '
        'NewLogButton
        '
        Me.NewLogButton.BackColor = System.Drawing.Color.White
        Me.NewLogButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewLogButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.NewLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewLogButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLogButton.ForeColor = System.Drawing.Color.Black
        Me.NewLogButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewLogButton.Location = New System.Drawing.Point(841, 601)
        Me.NewLogButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NewLogButton.Name = "NewLogButton"
        Me.NewLogButton.Size = New System.Drawing.Size(198, 45)
        Me.NewLogButton.TabIndex = 64
        Me.NewLogButton.Text = "New Log"
        Me.NewLogButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.White
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.Color.Black
        Me.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelButton.Location = New System.Drawing.Point(841, 227)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(198, 45)
        Me.CancelButton.TabIndex = 65
        Me.CancelButton.Text = "(X) Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        Me.CancelButton.Visible = False
        '
        'ManufacturingLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 770)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.NewLogButton)
        Me.Controls.Add(Me.DeleteLogButton)
        Me.Controls.Add(Me.SaveChangesButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.DetailsRichTextBox)
        Me.Controls.Add(Me.ConductedByTextBox)
        Me.Controls.Add(Me.FactoryIDTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ManufacturingLogs"
        Me.Text = "SwissChoco - Manufacturing Logs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents FactoryIDTextBox As TextBox
    Friend WithEvents ConductedByTextBox As TextBox
    Friend WithEvents DetailsRichTextBox As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents SaveChangesButton As Button
    Friend WithEvents DeleteLogButton As Button
    Friend WithEvents NewLogButton As Button
    Friend WithEvents CancelButton As Button
End Class
