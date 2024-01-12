Public Class Form1
    Dim records(50) As String
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
            records(0) = inFile.ReadLine
            records(1) = inFile.ReadLine
            inFile.Close()
        End If
    End Sub
End Class
