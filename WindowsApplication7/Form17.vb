Imports MySql.Data.MySqlClient

Public Class Form17
    Dim sCommand As MySqlCommand
    Dim sAdapter As MySqlDataAdapter
    Dim sBuilder As MySqlCommandBuilder
    Dim sDs As DataSet
    Dim sTable As DataTable

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form7.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form19.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

       
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form20.show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit ? ", "Exit application ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then

            Application.ExitThread()
        End If
    End Sub
End Class