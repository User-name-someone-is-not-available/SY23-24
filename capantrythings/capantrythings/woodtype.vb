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
End Class