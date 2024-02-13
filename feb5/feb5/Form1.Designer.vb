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
        Me.Clickercontroll1 = New feb5.clickercontroll()
        Me.Clickercontroll2 = New feb5.clickercontroll()
        Me.Clickercontroll3 = New feb5.clickercontroll()
        Me.SuspendLayout()
        '
        'Clickercontroll1
        '
        Me.Clickercontroll1.BackColor = System.Drawing.SystemColors.MenuText
        Me.Clickercontroll1.Location = New System.Drawing.Point(1, -3)
        Me.Clickercontroll1.Name = "Clickercontroll1"
        Me.Clickercontroll1.Size = New System.Drawing.Size(185, 136)
        Me.Clickercontroll1.TabIndex = 6
        '
        'Clickercontroll2
        '
        Me.Clickercontroll2.BackColor = System.Drawing.Color.IndianRed
        Me.Clickercontroll2.Location = New System.Drawing.Point(343, -3)
        Me.Clickercontroll2.Name = "Clickercontroll2"
        Me.Clickercontroll2.Size = New System.Drawing.Size(185, 136)
        Me.Clickercontroll2.TabIndex = 7
        '
        'Clickercontroll3
        '
        Me.Clickercontroll3.BackColor = System.Drawing.Color.Black
        Me.Clickercontroll3.Location = New System.Drawing.Point(152, -3)
        Me.Clickercontroll3.Name = "Clickercontroll3"
        Me.Clickercontroll3.Size = New System.Drawing.Size(185, 136)
        Me.Clickercontroll3.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Clickercontroll3)
        Me.Controls.Add(Me.Clickercontroll2)
        Me.Controls.Add(Me.Clickercontroll1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Clickercontroll1 As clickercontroll
    Friend WithEvents Clickercontroll2 As clickercontroll
    Friend WithEvents Clickercontroll3 As clickercontroll
End Class
