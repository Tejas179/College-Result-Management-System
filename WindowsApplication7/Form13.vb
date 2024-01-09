Public Class Form13
    
    Dim pl1 As Integer = 60



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pl1 > 250 Then
            Timer1.Stop()
        Else
            Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
            pl1 += 10
        End If
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Timer1.Start()

    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Timer1.Stop()
        pl1 = 60
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form16.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit ? ", "Exit application ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then

            Application.ExitThread()
        End If
    End Sub
End Class