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
    End Sub


End Class