Public Class Form1
    Dim money As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Realcontroll1.spin()
        Realcontroll2.spin()
        Realcontroll3.spin()
        money = money - 1
        Label4.Text = money
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        money = money + 1
        Label4.Text = money
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Realcontroll1.itemvalue
        Label2.Text = Realcontroll2.itemvalue
        Label3.Text = Realcontroll3.itemvalue
        If Realcontroll1.itemvalue = Realcontroll2.itemvalue And Realcontroll2.itemvalue = Realcontroll3.itemvalue Then
            money = money + 10
        End If
        Timer1.Enabled = False
        Label4.Text = money
    End Sub
End Class
