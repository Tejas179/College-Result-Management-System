Imports MySql.Data.MySqlClient
Imports WindowsApplication7.Form19

Public Class Form18
    Dim conn As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim myadaptor As New MySqlDataAdapter

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MsgBox(Form7.test1)

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;port=3306;Uid=admin;pwd=admin;Database=student"

        Try
            conn.Open()

        Catch ex As MySqlException
            MsgBox("Failed")
        End Try

        Dim Query As String = "SELECT * FROM details WHERE rno=" & Form19.test1


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

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit ? ", "Exit application ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then

            Application.ExitThread()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If

    End Sub
End Class


