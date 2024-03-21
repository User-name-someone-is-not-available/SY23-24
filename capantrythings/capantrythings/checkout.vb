Public Class checkout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim WC As New woodtype
        WC.ShowDialog()

    End Sub
End Class