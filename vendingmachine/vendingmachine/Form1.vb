Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        cs.insertnickles()
        Label1.Text = cs.total.ToString("c2")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        cs.insertdimes()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        cs.insertquarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        cs.insertdollar()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        cs.returncoins()
        Label1.Text = cs.total.ToString("c2")

    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            dollarvb.Visible = True
        Else
            dollarvb.Visible = False

        End If
        If q > 0 Then
            quartervb.Visible = True
        Else
            quartervb.Visible = False

        End If
        If di > 0 Then
            dimevb.Visible = True
        Else
            dimevb.Visible = False

        End If
        If n > 0 Then
            nickelvb.Visible = True
        Else
            nickelvb.Visible = False

        End If

    End Sub

    Private Sub Productcontroll1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Productcontroll6_Load(sender As Object, e As EventArgs)
    End Sub

    Private Sub Productcontroll4_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Productcontroll16_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Productcontroll1.buy()
    End Sub
End Class
