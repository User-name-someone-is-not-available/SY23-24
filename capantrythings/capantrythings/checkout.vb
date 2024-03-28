Public Class checkout
    Dim itemc As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim WC As New woodtype
        WC.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim wt As New woodtype

        TextBox3.Text = wt.ComboBox1.Text
        TextBox4.Text = WC
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
        If WO = 1 Then
            TextBox3.Text = "pine"
        End If
        If WO = 2 Then
            TextBox3.Text = "Maple"
        End If
        If WO = 3 Then
            TextBox3.Text = "Red Oak"
        End If
        If WO = 4 Then
            TextBox3.Text = "White Oak"
        End If
        If WO = 5 Then
            TextBox3.Text = "Butternut"
        End If
        If WO = 6 Then
            TextBox3.Text = "Ash"
        End If
        If WO = 7 Then
            TextBox3.Text = "Cherry"
        End If
        If WO = 8 Then
            TextBox3.Text = "Mahogany"
        End If
        If WO = 9 Then
            TextBox3.Text = "Hard Maple"
        End If
        If WO = 10 Then
            TextBox3.Text = "Walnut"
        End If
        If WO = 11 Then
            TextBox3.Text = "Teak"
        End If
        If WO = 12 Then
            TextBox3.Text = "Rosewood"
        End If
        If WO = 13 Then
            TextBox3.Text = "Brazilian Rosewood"
        End If
        If WO = 14 Then
            TextBox3.Text = "Hollywood"
        End If
        If WO = 15 Then
            TextBox3.Text = "Agarwood"
        End If

    End Sub


End Class