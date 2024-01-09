Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MsgBox("Authenticated User", MsgBoxStyle.Information, "Authorized User")
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Incorrect User", MsgBoxStyle.Critical, "Invalid user")
            


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit ? ", "Exit application ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then

            Application.ExitThread()
        End If

    End Sub
End Class
