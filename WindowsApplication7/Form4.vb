﻿Imports MySql.Data.MySqlClient
Public Class Form4
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
    End Sub

    

    Public Shared test1 As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        test1 = Convert.ToInt64(TextBox1.Text)
        Form14.Show()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit ? ", "Exit application ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then

            Application.ExitThread()
        End If
    End Sub
End Class