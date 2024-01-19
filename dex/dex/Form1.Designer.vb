<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.f3 = New System.Windows.Forms.TextBox()
        Me.f5 = New System.Windows.Forms.TextBox()
        Me.f4 = New System.Windows.Forms.TextBox()
        Me.f1 = New System.Windows.Forms.TextBox()
        Me.f2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.b1 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Health "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Defense "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Attack"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(264, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(148, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "name"
        '
        'f3
        '
        Me.f3.Location = New System.Drawing.Point(313, 326)
        Me.f3.Name = "f3"
        Me.f3.Size = New System.Drawing.Size(125, 27)
        Me.f3.TabIndex = 9
        '
        'f5
        '
        Me.f5.Location = New System.Drawing.Point(108, 106)
        Me.f5.Name = "f5"
        Me.f5.Size = New System.Drawing.Size(125, 27)
        Me.f5.TabIndex = 10
        '
        'f4
        '
        Me.f4.Location = New System.Drawing.Point(108, 164)
        Me.f4.Name = "f4"
        Me.f4.Size = New System.Drawing.Size(125, 27)
        Me.f4.TabIndex = 11
        '
        'f1
        '
        Me.f1.Location = New System.Drawing.Point(313, 260)
        Me.f1.Name = "f1"
        Me.f1.Size = New System.Drawing.Size(125, 27)
        Me.f1.TabIndex = 12
        '
        'f2
        '
        Me.f2.Location = New System.Drawing.Point(313, 293)
        Me.f2.Name = "f2"
        Me.f2.Size = New System.Drawing.Size(125, 27)
        Me.f2.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.NewToolStripMenuItem.Text = "new"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.SaveToolStripMenuItem.Text = "save"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(543, 141)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(146, 35)
        Me.b1.TabIndex = 15
        Me.b1.Text = "first"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(543, 182)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(146, 35)
        Me.b2.TabIndex = 16
        Me.b2.Text = "next"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(543, 223)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(146, 35)
        Me.b3.TabIndex = 17
        Me.b3.Text = "previous"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.Location = New System.Drawing.Point(543, 264)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(146, 35)
        Me.b4.TabIndex = 18
        Me.b4.Text = "last"
        Me.b4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Average"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(243, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Stat"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.f2)
        Me.Controls.Add(Me.f1)
        Me.Controls.Add(Me.f4)
        Me.Controls.Add(Me.f5)
        Me.Controls.Add(Me.f3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents f3 As TextBox
    Friend WithEvents f5 As TextBox
    Friend WithEvents f4 As TextBox
    Friend WithEvents f1 As TextBox
    Friend WithEvents f2 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents b1 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents b4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
End Class
