Public Class productcontroll
    Public Property productid As String
    Public Property productprice As Decimal
    Public Property productpicture As Image
    Public Property count As Integer

    Private Sub productcontroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idlabel.Text = productid
        pricelabel.Text = productprice.ToString("c2")
        PictureBox1.Image = productpicture
    End Sub
    Sub buy()
        If count < 0 Then
            count = count - 1
        End If
        If count = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class

