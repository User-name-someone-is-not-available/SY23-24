Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickel()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdime()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertdollar()
        Label1.Text = cs.total.ToString("c2")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
        If q > 0 Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If
        If di > 0 Then
            PictureBox3.Visible = True
        Else
            PictureBox3.Visible = False
        End If
        If n > 0 Then
            PictureBox4.Visible = True
        Else
            PictureBox4.Visible = False
        End If
    End Sub

    Private Sub buybtn_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case idtextbox.Text

            Case Productcontrol1.productid
                Productcontrol1.buy()
            Case Productcontrol2.productid
                Productcontrol2.buy()
            Case Productcontrol3.productid
                Productcontrol3.buy()
            Case Productcontrol4.productid
                Productcontrol4.buy()
            Case Productcontrol5.productid
                Productcontrol5.buy()
            Case Productcontrol6.productid
                Productcontrol6.buy()
            Case Productcontrol7.productid
                Productcontrol7.buy()
            Case Productcontrol8.productid
                Productcontrol8.buy()
            Case Productcontrol9.productid
                Productcontrol9.buy()
            Case Productcontrol10.productid
                Productcontrol11.buy()
            Case Productcontrol12.productid
                Productcontrol12.buy()
            Case Productcontrol13.productid
                Productcontrol13.buy()
            Case Productcontrol14.productid
                Productcontrol14.buy()
            Case Productcontrol15.productid
                Productcontrol15.buy()
            Case Productcontrol16.productid
                Productcontrol16.buy()




        End Select
        Productcontrol1.buy()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
