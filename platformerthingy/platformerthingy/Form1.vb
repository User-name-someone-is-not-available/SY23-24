Public Class frm2Dplatformer
    Dim movespeed As Integer = 15
    Dim jumping As Boolean
    Dim coins As Integer


    Private Sub frm2Dplatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                TMRup.Start()
            Case Keys.Right
                tmrright.Start()
            Case Keys.Left
                TMRleft.Start()
                jumping = True
        End Select
    End Sub

    Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles tmrright.Tick
        picplayer2.Left += 15
    End Sub

    Private Sub frm2Dplatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrright.Stop()
            Case Keys.Up
                TMRup.Stop()
                jumping = False
            Case Keys.Left
                TMRleft.Stop()

        End Select
    End Sub

    Private Sub TMRleft_Tick(sender As Object, e As EventArgs) Handles TMRleft.Tick
        picplayer2.Left -= movespeed
    End Sub

    Private Sub TMRup_Tick(sender As Object, e As EventArgs) Handles TMRup.Tick
        picplayer2.Top -= movespeed
    End Sub

    Private Sub frm2Dplatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gamelogic.Start()
    End Sub

    Private Sub tmrgamelogic_Tick(sender As Object, e As EventArgs) Handles gamelogic.Tick
        If picplayer2.Bounds.IntersectsWith(picground.Bounds) Then
            grvity.Stop()
        Else
            If jumping = False Then
                grvity.Start()
            End If
        End If


        For Each B As Control In Me.Controls
            If TypeOf B Is PictureBox Then
                If B.Tag = "bound" Then
                    If picplayer2.Bounds.IntersectsWith(B.Bounds) Then
                        grvity.Stop()
                    End If

                End If
            End If
            If TypeOf B Is PictureBox Then
                If B.Tag = "restart" Then
                    If picplayer2.Bounds.IntersectsWith(B.Bounds) Then
                        picplayer2.Location = New Point(42, 353)
                        PictureBox5.Visible = True
                        PictureBox9.Visible = True
                        PictureBox8.Visible = True
                        PictureBox7.Visible = True
                        PictureBox6.Visible = True
                        scoreLabel.Text = 0
                    End If

                End If
            End If
            If TypeOf B Is PictureBox Then
                If B.Tag = "COIN" Then
                    If picplayer2.Bounds.IntersectsWith(B.Bounds) And B.Visible = True Then
                        coins = coins + 1
                        scoreLabel.Text = coins
                        B.Visible = False

                    End If
                End If
            End If
            If PictureBox5.Visible = False And PictureBox6.Visible = False And PictureBox7.Visible = False And PictureBox8.Visible = False And PictureBox9.Visible = False Then
                scoreLabel.Text = "you win"
            End If
        Next
    End Sub

    Private Sub grvity_Tick(sender As Object, e As EventArgs) Handles grvity.Tick
        picplayer2.Top += movespeed
    End Sub

    Private Sub picground_Click(sender As Object, e As EventArgs) Handles picground.Click

    End Sub

    Private Sub air_Click(sender As Object, e As EventArgs) Handles air.Click

    End Sub

    Private Sub picplayer2_Click(sender As Object, e As EventArgs) Handles picplayer2.Click

    End Sub

    Private Sub Mover1_Load(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Mover1_Load_1(sender As Object, e As EventArgs) Handles Mover1.Load

    End Sub
End Class
