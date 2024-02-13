Public Class CLICKER
    Public Property count As Integer
    Public Property increnent As Integer = 1
    Public Sub click()
        count = count + 1

    End Sub
    Public Sub reset()
        count = 0
    End Sub
End Class
