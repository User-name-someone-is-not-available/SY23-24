Public Class Form1
    Dim records(50) As String
    Dim count As Integer
    Dim current As Integer
    Private Sub FireToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Form3.Close()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles f2.TextChanged

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        f1.Text = ""
        f2.Text = ""
        f3.Text = ""
        f4.Text = ""
        f5.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outFile As New IO.StreamWriter("data.txt")
        outFile.Write(f1.Text)
        outFile.Write("|")
        outFile.Write(f5.Text)
        outFile.Write("|")
        outFile.Write(f4.Text)
        outFile.Write("|")
        outFile.Write(f3.Text)
        outFile.Write("|")
        outFile.Write(f2.Text)
        outFile.Write("|")
        outFile.WriteLine(PictureBox1.Location)
        outFile.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New IO.StreamReader("data.txt")
            While Not inFile.EndOfStream
                records(count) = inFile.ReadLine
                count = count + 1
            End While
            inFile.Close()
            showrecord(0)
        End If
    End Sub
    Public Sub showrecord(index As Integer)
        Dim fields() As String
        If records(index) <> Nothing Then
            fields = records(index).Split("|")
        f1.Text = fields(0)
        f2.Text = fields(1)
        f3.Text = fields(2)
        f4.Text = fields(3)
        f5.Text = fields(4)
            If IO.File.Exists(fields(5)) Then
                PictureBox1.Load(fields(5))
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles b4.Click
        current = count - 1
        showrecord(current)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles b3.Click
        If current < count - 1 Then current = current + 1


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b1.Click
        current = 0
        showrecord(current)

    End Sub
End Class
