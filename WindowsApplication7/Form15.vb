Imports MySql.Data.MySqlClient
Imports WindowsApplication7.Form16

Public Class Form15
    Dim conn As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim myadaptor As New MySqlDataAdapter

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        'MsgBox(Form7.test1)

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;port=3306;Uid=admin;pwd=admin;Database=student"

        Try
            conn.Open()

        Catch ex As MySqlException
            MsgBox("Failed")
        End Try

        Dim Query As String = "SELECT * FROM details WHERE rno=" & Form16.test1


        Dim result As String

        cmd.Connection = conn
        cmd.CommandText = Query

        myadaptor.SelectCommand = cmd

        Dim mydata As MySqlDataReader

        mydata = cmd.ExecuteReader()
        Dim loopcount As Integer = 1


        If mydata.HasRows Then

            While mydata.Read()
                If loopcount > 1 Then
                    Exit While
                End If

                TextBox1.Text = mydata(0)
                TextBox2.Text = mydata(1)
                TextBox3.Text = mydata(2)
                TextBox4.Text = mydata(3)
                TextBox5.Text = mydata(4)
                TextBox6.Text = mydata(5)
                TextBox7.Text = mydata(6)
                TextBox8.Text = mydata(7)
                TextBox9.Text = mydata(8)
                TextBox10.Text = mydata(9)
                TextBox11.Text = mydata(10)
                TextBox12.Text = mydata(11)
                TextBox13.Text = mydata(12)
                TextBox14.Text = mydata(13)
                TextBox15.Text = mydata(14)
                TextBox16.Text = mydata(15)
                TextBox17.Text = mydata(16)
                TextBox18.Text = mydata(17)
                TextBox19.Text = mydata(18)
                TextBox20.Text = mydata(19)
                TextBox21.Text = mydata(20)
                TextBox22.Text = mydata(21)
                TextBox23.Text = mydata(22)
                TextBox24.Text = mydata(23)
                TextBox25.Text = mydata(24)
                TextBox26.Text = mydata(25)
                TextBox27.Text = mydata(26)
                TextBox28.Text = mydata(27)
                TextBox29.Text = mydata(28)
                TextBox30.Text = mydata(29)
                TextBox31.Text = mydata(30)
                TextBox32.Text = mydata(31)
                TextBox33.Text = mydata(32)
                TextBox34.Text = mydata(33)
                TextBox35.Text = mydata(34)
                TextBox36.Text = mydata(35)
                TextBox37.Text = mydata(36)


                For i As Integer = 0 To 36
                    result = mydata(i).ToString

                    'MsgBox(result)


                    ' Label30.Text = Label30.Text + result & vbNewLine



                Next
                loopcount = loopcount + 1

            End While
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;port=3306;Uid=admin;pwd=admin;Database=student"

        Dim Reader As MySqlDataReader

        Try
            conn.Open()

            Dim query As String
            query = "insert into details values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & TextBox19.Text & "','" & TextBox20.Text & "','" & TextBox21.Text & "','" & TextBox22.Text & "','" & TextBox23.Text & "','" & TextBox24.Text & "','" & TextBox25.Text & "','" & TextBox26.Text & "','" & TextBox27.Text & "','" & TextBox28.Text & "','" & TextBox29.Text & "','" & TextBox30.Text & "','" & TextBox31.Text & "','" & TextBox32.Text & "','" & TextBox33.Text & "','" & TextBox34.Text & "','" & TextBox35.Text & "','" & TextBox36.Text & "','" & TextBox37.Text & "') "

            cmd = New MySqlCommand(query, conn)
            Reader = cmd.ExecuteReader

            MsgBox("Your details Is Successfully Saved !")
            conn.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox18.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox21.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox24_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox24.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox27_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox27.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox30_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox30.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs) Handles TextBox30.TextChanged

    End Sub

   

   
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit ? ", "Exit application ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then

            Application.ExitThread()
        End If
    End Sub
End Class