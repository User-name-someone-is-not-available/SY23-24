Public Class checkout
    Dim C As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim WC As New woodtype
        WC.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim wt As New woodtype
        If TextBox2.Text = "2" Then
            C = 2
        End If
        If TextBox2.Text = "3" Then
            C = 3
        End If
        If TextBox2.Text = "4" Then
            C = 4
        End If
        If TextBox2.Text = "5" Then
            C = 5
        End If
        If TextBox2.Text = "6" Then
            C = 6
        End If
        If TextBox2.Text = "7" Then
            C = 7
        End If
        If TextBox2.Text = "8" Then
            C = 8
        End If
        If TextBox2.Text = "9" Then
            C = 9
        End If
        TextBox3.Text = wt.ComboBox1.Text
        TextBox4.Text = WC
        TextBox5.Text = C * (WC + IC)
        If IC = 1 Then
            TextBox1.Text = "Bowl"
        End If
        If IC = 2 Then
            TextBox1.Text = "Bed"
        End If
        If IC = 3 Then
            TextBox1.Text = "Table"
        End If
        If IC = 4 Then
            TextBox1.Text = "Chair"
        End If
        If IC = 5 Then
            TextBox1.Text = "Cup"

        End If
    End Sub


End Class