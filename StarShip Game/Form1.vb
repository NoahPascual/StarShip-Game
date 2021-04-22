Public Class Form1
    Dim speed As Integer
    Dim star(8) As PictureBox
    Dim score As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 3
        star(0) = PictureBox1
        star(1) = PictureBox2
        star(2) = PictureBox3
        star(3) = PictureBox9
        star(4) = PictureBox10
        star(5) = PictureBox11
        star(6) = PictureBox12
        star(7) = PictureBox13
        star(8) = PictureBox14
    End Sub

    Private Sub StarMover_Tick(sender As Object, e As EventArgs) Handles StarMover.Tick
        For x As Integer = 0 To 8
            star(x).Top += 2
            If star(x).Top >= Me.Height Then
                star(x).Top = -star(x).Height
            End If
        Next
        If (Rocket.Bounds.IntersectsWith(Enemy1.Bounds)) Then
            gameover()
        End If

        If (Rocket.Bounds.IntersectsWith(Enemy2.Bounds)) Then
            gameover()
        End If

        If (Rocket.Bounds.IntersectsWith(Enemy3.Bounds)) Then
            gameover()
        End If

        If (Rocket.Bounds.IntersectsWith(Enemy4.Bounds)) Then
            gameover()
        End If

        If (Rocket.Bounds.IntersectsWith(Enemy5.Bounds)) Then
            gameover()
        End If
    End Sub
    Private Sub gameover()
        EndText.Visible = True
        ReplayButton.Visible = True
        StarMover.Stop()
        Enemy1Mover.Stop()
        Enemy2Mover.Stop()
        Enemy3Mover.Stop()
        Enemy4Mover.Stop()
        Enemy5Mover.Stop()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            RightMover.Start()
        End If
        If e.KeyCode = Keys.Left Then
            LeftMover.Start()
        End If
    End Sub

    Private Sub RightMover_Tick(sender As Object, e As EventArgs) Handles RightMover.Tick
        If (Rocket.Location.X < 186) Then
            Rocket.Left += 5
        End If
    End Sub

    Private Sub LeftMover_Tick(sender As Object, e As EventArgs) Handles LeftMover.Tick
        If (Rocket.Location.X > 0) Then
            Rocket.Left -= 5
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightMover.Stop()
        LeftMover.Stop()
    End Sub

    Private Sub Enemy1Mover_Tick(sender As Object, e As EventArgs) Handles Enemy1Mover.Tick

        Enemy1.Top += 3.25
        If Enemy1.Top >= Me.Height Then
            score += 1
            ScoreText.Text = "Score " & score
            Enemy1.Top = -Enemy1.Height
        End If
    End Sub

    Private Sub Enemy2Mover_Tick(sender As Object, e As EventArgs) Handles Enemy2Mover.Tick

        Enemy2.Top += 3
        If Enemy2.Top >= Me.Height Then
            score += 1
            ScoreText.Text = "Score " & score
            Enemy2.Top = -Enemy1.Height
        End If
    End Sub

    Private Sub Enemy3Mover_Tick(sender As Object, e As EventArgs) Handles Enemy3Mover.Tick

        Enemy3.Top += 1
        If Enemy3.Top >= Me.Height Then
            score += 1
            ScoreText.Text = "Score " & score
            Enemy3.Top = -Enemy1.Height
        End If
    End Sub

    Private Sub Enemy4Mover_Tick(sender As Object, e As EventArgs) Handles Enemy4Mover.Tick

        Enemy4.Top += 3.5
        If Enemy4.Top >= Me.Height Then
            score += 1
            ScoreText.Text = "Score " & score
            Enemy4.Top = -Enemy1.Height
        End If
    End Sub

    Private Sub Enemy5Mover_Tick(sender As Object, e As EventArgs) Handles Enemy5Mover.Tick

        Enemy5.Top += 3
        If Enemy5.Top >= Me.Height Then
            score += 1
            ScoreText.Text = "Score " & score
            Enemy5.Top = -Enemy1.Height
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ReplayButton.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub
End Class
