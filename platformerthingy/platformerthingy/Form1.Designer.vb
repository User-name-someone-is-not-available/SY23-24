<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm2Dplatformer
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
        Me.components = New System.ComponentModel.Container()
        Me.picplayer = New System.Windows.Forms.PictureBox()
        Me.air = New System.Windows.Forms.PictureBox()
        Me.picground = New System.Windows.Forms.PictureBox()
        Me.tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.TMRleft = New System.Windows.Forms.Timer(Me.components)
        Me.TMRup = New System.Windows.Forms.Timer(Me.components)
        Me.gamelogic = New System.Windows.Forms.Timer(Me.components)
        Me.grvity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Mover1 = New platformerthingy.moveR()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.picplayer2 = New System.Windows.Forms.PictureBox()
        Me.Mover2 = New platformerthingy.moveR()
        Me.Mover3 = New platformerthingy.moveR()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Mover4 = New platformerthingy.moveR()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.air, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picplayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picplayer
        '
        Me.picplayer.BackColor = System.Drawing.Color.Red
        Me.picplayer.Location = New System.Drawing.Point(402, 702)
        Me.picplayer.Name = "picplayer"
        Me.picplayer.Size = New System.Drawing.Size(39, 41)
        Me.picplayer.TabIndex = 0
        Me.picplayer.TabStop = False
        '
        'air
        '
        Me.air.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.air.Location = New System.Drawing.Point(-3, 0)
        Me.air.Name = "air"
        Me.air.Size = New System.Drawing.Size(800, 370)
        Me.air.TabIndex = 1
        Me.air.TabStop = False
        '
        'picground
        '
        Me.picground.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.picground.Location = New System.Drawing.Point(1, 376)
        Me.picground.Name = "picground"
        Me.picground.Size = New System.Drawing.Size(796, 62)
        Me.picground.TabIndex = 2
        Me.picground.TabStop = False
        '
        'tmrright
        '
        '
        'TMRleft
        '
        '
        'TMRup
        '
        '
        'gamelogic
        '
        '
        'grvity
        '
        Me.grvity.Interval = 150
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(404, 302)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 14)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(534, 226)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(108, 14)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(134, 214)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(108, 14)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(553, 376)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(244, 62)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "restart"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox5.Location = New System.Drawing.Point(122, 108)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(12, 11)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "COIN"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox6.Location = New System.Drawing.Point(653, 195)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(12, 11)
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "COIN"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox7.Location = New System.Drawing.Point(413, 78)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(12, 11)
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "COIN"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox8.Location = New System.Drawing.Point(754, 391)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(12, 11)
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "COIN"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox9.Location = New System.Drawing.Point(429, 322)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(12, 11)
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "COIN"
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Mover1.intervle = 100
        Me.Mover1.Location = New System.Drawing.Point(239, 82)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(372, 80)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox7
        Me.Mover1.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(847, 264)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 13
        '
        'picplayer2
        '
        Me.picplayer2.BackColor = System.Drawing.Color.Red
        Me.picplayer2.Location = New System.Drawing.Point(1, 347)
        Me.picplayer2.Name = "picplayer2"
        Me.picplayer2.Size = New System.Drawing.Size(36, 35)
        Me.picplayer2.TabIndex = 14
        Me.picplayer2.TabStop = False
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.LightGray
        Me.Mover2.intervle = 500
        Me.Mover2.Location = New System.Drawing.Point(178, 289)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(349, 10)
        Me.Mover2.speed = 10
        Me.Mover2.sprite = Me.PictureBox1
        Me.Mover2.TabIndex = 15
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.LightGray
        Me.Mover3.intervle = 500
        Me.Mover3.Location = New System.Drawing.Point(743, 121)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(10, 317)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.PictureBox8
        Me.Mover3.TabIndex = 16
        '
        'PictureBox10
        '
        Me.PictureBox10.Location = New System.Drawing.Point(830, 130)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox10.TabIndex = 17
        Me.PictureBox10.TabStop = False
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.LightGray
        Me.Mover4.intervle = 500
        Me.Mover4.Location = New System.Drawing.Point(135, -26)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(10, 432)
        Me.Mover4.speed = 10
        Me.Mover4.sprite = Me.PictureBox3
        Me.Mover4.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "coins"
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Location = New System.Drawing.Point(50, 0)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(53, 20)
        Me.scoreLabel.TabIndex = 20
        Me.scoreLabel.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(728, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Label2"
        '
        'frm2Dplatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1924, 588)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.picplayer2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.picground)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picplayer)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.air)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.Mover2)
        Me.Name = "frm2Dplatformer"
        Me.Text = "Form1"
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.air, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picplayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picplayer As PictureBox
    Friend WithEvents air As PictureBox
    Friend WithEvents picground As PictureBox
    Friend WithEvents tmrright As Timer
    Friend WithEvents TMRleft As Timer
    Friend WithEvents TMRup As Timer
    Friend WithEvents gamelogic As Timer
    Friend WithEvents grvity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Mover1 As moveR
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents picplayer2 As PictureBox
    Friend WithEvents Mover2 As moveR
    Friend WithEvents Mover3 As moveR
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Mover4 As moveR
    Friend WithEvents Label1 As Label
    Friend WithEvents scoreLabel As Label
    Friend WithEvents Label2 As Label
End Class
