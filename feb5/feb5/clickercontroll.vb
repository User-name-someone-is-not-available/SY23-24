Public Class clickercontroll
    Dim c As New CLICKER
    Public Property increnent As Integer = 1



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.increnent = increnent
        c.reset()
        TextBox2.Text = c.count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.click()
        TextBox2.Text = c.count
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub clickercontroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
