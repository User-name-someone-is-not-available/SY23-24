﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productcontroll
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.idlabel = New System.Windows.Forms.Label()
        Me.pricelabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idlabel
        '
        Me.idlabel.AutoSize = True
        Me.idlabel.Location = New System.Drawing.Point(3, 81)
        Me.idlabel.Name = "idlabel"
        Me.idlabel.Size = New System.Drawing.Size(50, 20)
        Me.idlabel.TabIndex = 0
        Me.idlabel.Text = "label1"
        '
        'pricelabel
        '
        Me.pricelabel.AutoSize = True
        Me.pricelabel.Location = New System.Drawing.Point(56, 81)
        Me.pricelabel.Name = "pricelabel"
        Me.pricelabel.Size = New System.Drawing.Size(53, 20)
        Me.pricelabel.TabIndex = 1
        Me.pricelabel.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'productcontroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pricelabel)
        Me.Controls.Add(Me.idlabel)
        Me.Name = "productcontroll"
        Me.Size = New System.Drawing.Size(125, 105)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idlabel As Label
    Friend WithEvents pricelabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
