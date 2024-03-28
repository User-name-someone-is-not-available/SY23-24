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

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Pine" Then
            WC = 12.99
            WO = 1
        End If
        If ComboBox1.Text = "Maple" Then
            WC = 12.99
            WO = 2
        End If
        If ComboBox1.Text = "Red Oak" Then
            WC = 9.99
            WO = 3

        End If
        If ComboBox1.Text = "White Oak" Then
            WC = 9.99
            WO = 4
        End If
        If ComboBox1.Text = "Butternut" Then
            WC = 10.99
            WO = 5
        End If
        If ComboBox1.Text = "Ash" Then
            WC = 11.99
            WO = 6
        End If
        TextBox2.Text = WC
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Cherry" Then
            WC = 16.99
            WO = 7
        End If
        If ComboBox2.Text = "Mahogany" Then
            WC = 17.99
            WO = 8
        End If
        If ComboBox2.Text = "Hard Maple" Then
            WC = 15.99
            WO = 9
        End If
        If ComboBox2.Text = "Walnut" Then
            WC = 15.99
            WO = 10
        End If
        If ComboBox2.Text = "Teak" Then
            WC = 14.99
            WO = 11
        End If
        TextBox2.Text = WC
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "Rosewood" Then
            WC = 19.99
            WO = 12
        End If
        If ComboBox3.Text = "Brazilian Rosewood" Then
            WC = 26.99
            WO = 13
        End If
        If ComboBox3.Text = "Hollywood" Then
            WC = 21.99
            WO = 14
        End If
        If ComboBox3.Text = "Agarwood" Then
            WC = 22.99
            WO = 15
        End If
        TextBox2.Text = WC
    End Sub

    Private Sub woodtype_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class