Imports System.Net
Imports System.Security.Policy

Public Class woodtype

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim f1 As New Form1
        f1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim f3 As New checkout
        f3.ShowDialog()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = WC
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Pine" Then
            WC = 12.99
        End If
        If ComboBox1.Text = "White Oak" Then
            WC = 9.99
        End If
        If ComboBox1.Text = "Butternut" Then
            WC = 10.99
        End If
        If ComboBox1.Text = "Ash" Then
            WC = 11.99
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Cherry" Then
            WC = 16.99
        End If
        If ComboBox2.Text = "Mahogany" Then
            WC = 17.99
        End If
        If ComboBox2.Text = "Walnut" Or "Hard Maple" Then
            WC = 15.99
        End If
        If ComboBox2.Text = "Teak" Then
            WC = 14.99
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "Rosewood" Then
            WC = 19.99
        End If
        If ComboBox3.Text = "Brazilian Rosewood" Then
            WC = 26.99
        End If
        If ComboBox3.Text = "Hollywood" Then
            WC = 21.99
        End If
        If ComboBox3.Text = "Agarwood" Then
            WC = 22.99
        End If

    End Sub
End Class