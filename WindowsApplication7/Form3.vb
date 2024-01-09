Imports MySql.Data.MySqlClient

Public Class Form3
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged, TextBox1.TextChanged



    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_LostFocus(sender As Object, e As EventArgs) Handles TextBox9.LostFocus
        'TextBox9.Text = Number.ToString()
        'Dim Number = Integer.Parse(TextBox9.Text)
        If TextBox9.Text = "" Then
            'TextBox9.BackColor = Color.White
            MsgBox("CAN NOT BLANK", MsgBoxStyle.Critical)
            TextBox9.BackColor = Color.Red




        ElseIf Integer.Parse(TextBox9.Text) > 100 Or Integer.Parse(TextBox9.Text) < 0 Then
            MsgBox("INVALID MARKS", MsgBoxStyle.Critical)
            TextBox9.BackColor = Color.Red
            TextBox9.Focus()
        Else
            TextBox9.BackColor = Color.White

        End If


        'TextBox9.Text = Integer.Parse(TextBox9.Text).ToString()


    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
     
        If Not IsNumeric(TextBox9.Text) Then
            TextBox10.Text = ""
            Exit Sub
        End If
        TextBox10.Text = GetText3(TextBox9.Text)
    End Sub
    Public Function GetTextForNumber(ByVal NMBR As Decimal) As String

        If NMBR <= 10 Then
            If NMBR = 0 Then Return ""
            If NMBR = 1 Then Return "One"
            If NMBR = 2 Then Return "Two"
            If NMBR = 3 Then Return "Three"
            If NMBR = 4 Then Return "Four"
            If NMBR = 5 Then Return "Five"
            If NMBR = 6 Then Return "Six"
            If NMBR = 7 Then Return "Seven"
            If NMBR = 8 Then Return "Eight"
            If NMBR = 9 Then Return "Nine"
            If NMBR = 10 Then Return "Ten"
        End If

        If NMBR >= 11 And NMBR <= 19 Then
            If NMBR = 11 Then Return "Eleven"
            If NMBR = 12 Then Return "Twelve"
            If NMBR = 13 Then Return "Thirteen"
            If NMBR = 14 Then Return "Fourteen"
            If NMBR = 15 Then Return "Fifteen"
            If NMBR = 16 Then Return "Sixteen"
            If NMBR = 17 Then Return "Seventeen"
            If NMBR = 18 Then Return "Eighteen"
            If NMBR = 19 Then Return "Nineteen"
        End If
        If NMBR >= 20 And NMBR <= 99 Then
            Dim SecondDigit As Integer = NMBR \ 10
            Dim FirstDigit As Integer = NMBR Mod 10

            If SecondDigit = 2 Then Return "Twenty " & GetText3(FirstDigit)
            If SecondDigit = 3 Then Return "Thirty " & GetText3(FirstDigit)
            If SecondDigit = 4 Then Return "Fourty " & GetText3(FirstDigit)
            If SecondDigit = 5 Then Return "Fifty " & GetText3(FirstDigit)
            If SecondDigit = 6 Then Return "Sixty " & GetText3(FirstDigit)
            If SecondDigit = 7 Then Return "Seventy " & GetText3(FirstDigit)
            If SecondDigit = 8 Then Return "Eighty " & GetText3(FirstDigit)
            If SecondDigit = 9 Then Return "Ninety " & GetText3(FirstDigit)
        End If
        If NMBR >= 100 And NMBR <= 999 Then
            Dim HundradDigit As Integer = NMBR \ 100
            Dim Remaining As Integer = NMBR Mod 100

            Dim TXT As String = GetText3(HundradDigit)
            TXT = TXT & "Hundrad"

            If Remaining <> 0 Then
                TXT = TXT & "and " & GetText3(Remaining)

            End If
            Return TXT
        End If
    End Function

    Private Sub TextBox12_LostFocus(sender As Object, e As EventArgs) Handles TextBox12.LostFocus

        If TextBox12.Text = "" Then
            'TextBox9.BackColor = Color.White
            MsgBox("CAN NOT BLANK", MsgBoxStyle.Critical)
            TextBox12.BackColor = Color.Red




        ElseIf Integer.Parse(TextBox12.Text) > 100 Or Integer.Parse(TextBox12.Text) < 0 Then
            MsgBox("INVALID MARKS", MsgBoxStyle.Critical)
            TextBox12.BackColor = Color.Red
            TextBox12.Focus()
        Else
            TextBox12.BackColor = Color.White

        End If


    End Sub


    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        If Not IsNumeric(TextBox12.Text) Then
            TextBox13.Text = ""
            Exit Sub
        End If
        TextBox13.Text = GetText2(TextBox12.Text)
    End Sub
    Public Function GetText2(ByVal NMBR As Decimal) As String

        If NMBR <= 10 Then
            If NMBR = 0 Then Return ""
            If NMBR = 1 Then Return "One"
            If NMBR = 2 Then Return "Two"
            If NMBR = 3 Then Return "Three"
            If NMBR = 4 Then Return "Four"
            If NMBR = 5 Then Return "Five"
            If NMBR = 6 Then Return "Six"
            If NMBR = 7 Then Return "Seven"
            If NMBR = 8 Then Return "Eight"
            If NMBR = 9 Then Return "Nine"
            If NMBR = 10 Then Return "Ten"
        End If

        If NMBR >= 11 And NMBR <= 19 Then
            If NMBR = 11 Then Return "Eleven"
            If NMBR = 12 Then Return "Twelve"
            If NMBR = 13 Then Return "Thirteen"
            If NMBR = 14 Then Return "Fourteen"
            If NMBR = 15 Then Return "Fifteen"
            If NMBR = 16 Then Return "Sixteen"
            If NMBR = 17 Then Return "Seventeen"
            If NMBR = 18 Then Return "Eighteen"
            If NMBR = 19 Then Return "Nineteen"
        End If
        If NMBR >= 20 And NMBR <= 99 Then
            Dim SecondDigit As Integer = NMBR \ 10
            Dim FirstDigit As Integer = NMBR Mod 10

            If SecondDigit = 2 Then Return "Twenty " & GetText2(FirstDigit)
            If SecondDigit = 3 Then Return "Thirty " & GetText2(FirstDigit)
            If SecondDigit = 4 Then Return "Fourty " & GetText2(FirstDigit)
            If SecondDigit = 5 Then Return "Fifty " & GetText2(FirstDigit)
            If SecondDigit = 6 Then Return "Sixty " & GetText2(FirstDigit)
            If SecondDigit = 7 Then Return "Seventy " & GetText2(FirstDigit)
            If SecondDigit = 8 Then Return "Eighty " & GetText2(FirstDigit)
            If SecondDigit = 9 Then Return "Ninety " & GetText2(FirstDigit)
        End If
        If NMBR >= 100 And NMBR <= 999 Then
            Dim HundradDigit As Integer = NMBR \ 100
            Dim Remaining As Integer = NMBR Mod 100

            Dim TXT As String = GetText2(HundradDigit)
            TXT = TXT & "Hundrad"

            If Remaining <> 0 Then
                TXT = TXT & "and " & GetText2(Remaining)

            End If
            Return TXT
        End If
    End Function

    Private Sub TextBox15_LostFocus(sender As Object, e As EventArgs) Handles TextBox15.LostFocus
        If TextBox15.Text = "" Then
            'TextBox9.BackColor = Color.White
            MsgBox("CAN NOT BLANK", MsgBoxStyle.Critical)
            TextBox15.BackColor = Color.Red




        ElseIf Integer.Parse(TextBox15.Text) > 100 Or Integer.Parse(TextBox15.Text) < 0 Then
            MsgBox("INVALID MARKS", MsgBoxStyle.Critical)
            TextBox15.BackColor = Color.Red
            TextBox15.Focus()
        Else
            TextBox15.BackColor = Color.White

        End If
    End Sub


    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        If Not IsNumeric(TextBox15.Text) Then
            TextBox16.Text = ""
            Exit Sub
        End If
        TextBox16.Text = GetText3(TextBox15.Text)
    End Sub
    Public Function GetText3(ByVal NMBR As Decimal) As String

        If NMBR <= 10 Then
            If NMBR = 0 Then Return ""
            If NMBR = 1 Then Return "One"
            If NMBR = 2 Then Return "Two"
            If NMBR = 3 Then Return "Three"
            If NMBR = 4 Then Return "Four"
            If NMBR = 5 Then Return "Five"
            If NMBR = 6 Then Return "Six"
            If NMBR = 7 Then Return "Seven"
            If NMBR = 8 Then Return "Eight"
            If NMBR = 9 Then Return "Nine"
            If NMBR = 10 Then Return "Ten"
        End If

        If NMBR >= 11 And NMBR <= 19 Then
            If NMBR = 11 Then Return "Eleven"
            If NMBR = 12 Then Return "Twelve"
            If NMBR = 13 Then Return "Thirteen"
            If NMBR = 14 Then Return "Fourteen"
            If NMBR = 15 Then Return "Fifteen"
            If NMBR = 16 Then Return "Sixteen"
            If NMBR = 17 Then Return "Seventeen"
            If NMBR = 18 Then Return "Eighteen"
            If NMBR = 19 Then Return "Nineteen"
        End If
        If NMBR >= 20 And NMBR <= 99 Then
            Dim SecondDigit As Integer = NMBR \ 10
            Dim FirstDigit As Integer = NMBR Mod 10

            If SecondDigit = 2 Then Return "Twenty " & GetText3(FirstDigit)
            If SecondDigit = 3 Then Return "Thirty " & GetText3(FirstDigit)
            If SecondDigit = 4 Then Return "Fourty " & GetText3(FirstDigit)
            If SecondDigit = 5 Then Return "Fifty " & GetText3(FirstDigit)
            If SecondDigit = 6 Then Return "Sixty " & GetText3(FirstDigit)
            If SecondDigit = 7 Then Return "Seventy " & GetText3(FirstDigit)
            If SecondDigit = 8 Then Return "Eighty " & GetText3(FirstDigit)
            If SecondDigit = 9 Then Return "Ninety " & GetText3(FirstDigit)
        End If
        If NMBR >= 100 And NMBR <= 999 Then
            Dim HundradDigit As Integer = NMBR \ 100
            Dim Remaining As Integer = NMBR Mod 100

            Dim TXT As String = GetText3(HundradDigit)
            TXT = TXT & "Hundrad"

            If Remaining <> 0 Then
                TXT = TXT & "and " & GetText3(Remaining)

            End If
            Return TXT
        End If
    End Function

    Private Sub TextBox18_LostFocus(sender As Object, e As EventArgs) Handles TextBox18.LostFocus

        If TextBox18.Text = "" Then
            'TextBox9.BackColor = Color.White
            MsgBox("CAN NOT BLANK", MsgBoxStyle.Critical)
            TextBox18.BackColor = Color.Red




        ElseIf Integer.Parse(TextBox18.Text) > 100 Or Integer.Parse(TextBox18.Text) < 0 Then
            MsgBox("INVALID MARKS", MsgBoxStyle.Critical)
            TextBox18.BackColor = Color.Red
            TextBox18.Focus()
        Else
            TextBox18.BackColor = Color.White

        End If
    End Sub


    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        If Not IsNumeric(TextBox18.Text) Then
            TextBox19.Text = ""
            Exit Sub
        End If
        TextBox19.Text = GetText4(TextBox18.Text)
    End Sub
    Public Function GetText4(ByVal NMBR As Decimal) As String

        If NMBR <= 10 Then
            If NMBR = 0 Then Return ""
            If NMBR = 1 Then Return "One"
            If NMBR = 2 Then Return "Two"
            If NMBR = 3 Then Return "Three"
            If NMBR = 4 Then Return "Four"
            If NMBR = 5 Then Return "Five"
            If NMBR = 6 Then Return "Six"
            If NMBR = 7 Then Return "Seven"
            If NMBR = 8 Then Return "Eight"
            If NMBR = 9 Then Return "Nine"
            If NMBR = 10 Then Return "Ten"
        End If

        If NMBR >= 11 And NMBR <= 19 Then
            If NMBR = 11 Then Return "Eleven"
            If NMBR = 12 Then Return "Twelve"
            If NMBR = 13 Then Return "Thirteen"
            If NMBR = 14 Then Return "Fourteen"
            If NMBR = 15 Then Return "Fifteen"
            If NMBR = 16 Then Return "Sixteen"
            If NMBR = 17 Then Return "Seventeen"
            If NMBR = 18 Then Return "Eighteen"
            If NMBR = 19 Then Return "Nineteen"
        End If
        If NMBR >= 20 And NMBR <= 99 Then
            Dim SecondDigit As Integer = NMBR \ 10
            Dim FirstDigit As Integer = NMBR Mod 10

            If SecondDigit = 2 Then Return "Twenty " & GetText4(FirstDigit)
            If SecondDigit = 3 Then Return "Thirty " & GetText4(FirstDigit)
            If SecondDigit = 4 Then Return "Fourty " & GetText4(FirstDigit)
            If SecondDigit = 5 Then Return "Fifty " & GetText4(FirstDigit)
            If SecondDigit = 6 Then Return "Sixty " & GetText4(FirstDigit)
            If SecondDigit = 7 Then Return "Seventy " & GetText4(FirstDigit)
            If SecondDigit = 8 Then Return "Eighty " & GetText4(FirstDigit)
            If SecondDigit = 9 Then Return "Ninety " & GetText4(FirstDigit)
        End If
        If NMBR >= 100 And NMBR <= 999 Then
            Dim HundradDigit As Integer = NMBR \ 100
            Dim Remaining As Integer = NMBR Mod 100

            Dim TXT As String = GetText4(HundradDigit)
            TXT = TXT & "Hundrad"

            If Remaining <> 0 Then
                TXT = TXT & "and " & GetText4(Remaining)

            End If
            Return TXT
        End If
    End Function

    Private Sub TextBox21_LostFocus(sender As Object, e As EventArgs) Handles TextBox21.LostFocus

        If TextBox21.Text = "" Then
            'TextBox9.BackColor = Color.White
            MsgBox("CAN NOT BLANK", MsgBoxStyle.Critical)
            TextBox21.BackColor = Color.Red




        ElseIf Integer.Parse(TextBox21.Text) > 100 Or Integer.Parse(TextBox21.Text) < 0 Then
            MsgBox("INVALID MARKS", MsgBoxStyle.Critical)
            TextBox21.BackColor = Color.Red
            TextBox21.Focus()
        Else
            TextBox21.BackColor = Color.White

        End If
    End Sub


    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged
        If Not IsNumeric(TextBox21.Text) Then
            TextBox22.Text = ""
            Exit Sub
        End If
        TextBox22.Text = GetText5(TextBox21.Text)
    End Sub
    Public Function GetText5(ByVal NMBR As Decimal) As String

        If NMBR <= 10 Then
            If NMBR = 0 Then Return ""
            If NMBR = 1 Then Return "One"
            If NMBR = 2 Then Return "Two"
            If NMBR = 3 Then Return "Three"
            If NMBR = 4 Then Return "Four"
            If NMBR = 5 Then Return "Five"
            If NMBR = 6 Then Return "Six"
            If NMBR = 7 Then Return "Seven"
            If NMBR = 8 Then Return "Eight"
            If NMBR = 9 Then Return "Nine"
            If NMBR = 10 Then Return "Ten"
        End If

        If NMBR >= 11 And NMBR <= 19 Then
            If NMBR = 11 Then Return "Eleven"
            If NMBR = 12 Then Return "Twelve"
            If NMBR = 13 Then Return "Thirteen"
            If NMBR = 14 Then Return "Fourteen"
            If NMBR = 15 Then Return "Fifteen"
            If NMBR = 16 Then Return "Sixteen"
            If NMBR = 17 Then Return "Seventeen"
            If NMBR = 18 Then Return "Eighteen"
            If NMBR = 19 Then Return "Nineteen"
        End If
        If NMBR >= 20 And NMBR <= 99 Then
            Dim SecondDigit As Integer = NMBR \ 10
            Dim FirstDigit As Integer = NMBR Mod 10

            If SecondDigit = 2 Then Return "Twenty " & GetText5(FirstDigit)
            If SecondDigit = 3 Then Return "Thirty " & GetText5(FirstDigit)
            If SecondDigit = 4 Then Return "Fourty " & GetText5(FirstDigit)
            If SecondDigit = 5 Then Return "Fifty " & GetText5(FirstDigit)
            If SecondDigit = 6 Then Return "Sixty " & GetText5(FirstDigit)
            If SecondDigit = 7 Then Return "Seventy " & GetText5(FirstDigit)
            If SecondDigit = 8 Then Return "Eighty " & GetText5(FirstDigit)
            If SecondDigit = 9 Then Return "Ninety " & GetText5(FirstDigit)
        End If
        If NMBR >= 100 And NMBR <= 999 Then
            Dim HundradDigit As Integer = NMBR \ 100
            Dim Remaining As Integer = NMBR Mod 100

            Dim TXT As String = GetText5(HundradDigit)
            TXT = TXT & "Hundrad"

            If Remaining <> 0 Then
                TXT = TXT & "and " & GetText5(Remaining)

            End If
            Return TXT
        End If
    End Function

    Private Sub TextBox24_LostFocus(sender As Object, e As EventArgs) Handles TextBox24.LostFocus

        If TextBox24.Text = "" Then
            'TextBox9.BackColor = Color.White
            MsgBox("CAN NOT BLANK", MsgBoxStyle.Critical)
            TextBox24.BackColor = Color.Red




        ElseIf Integer.Parse(TextBox24.Text) > 100 Or Integer.Parse(TextBox24.Text) < 0 Then
            MsgBox("INVALID MARKS", MsgBoxStyle.Critical)
            TextBox24.BackColor = Color.Red
            TextBox24.Focus()
        Else
            TextBox24.BackColor = Color.White

        End If
    End Sub


    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles TextBox24.TextChanged
        If Not IsNumeric(TextBox24.Text) Then
            TextBox25.Text = ""
            Exit Sub
        End If
        TextBox25.Text = GetText6(TextBox24.Text)
    End Sub
    Public Function GetText6(ByVal NMBR As Decimal) As String

        If NMBR <= 10 Then
            If NMBR = 0 Then Return ""
            If NMBR = 1 Then Return "One"
            If NMBR = 2 Then Return "Two"
            If NMBR = 3 Then Return "Three"
            If NMBR = 4 Then Return "Four"
            If NMBR = 5 Then Return "Five"
            If NMBR = 6 Then Return "Six"
            If NMBR = 7 Then Return "Seven"
            If NMBR = 8 Then Return "Eight"
            If NMBR = 9 Then Return "Nine"
            If NMBR = 10 Then Return "Ten"
        End If

        If NMBR >= 11 And NMBR <= 19 Then
            If NMBR = 11 Then Return "Eleven"
            If NMBR = 12 Then Return "Twelve"
            If NMBR = 13 Then Return "Thirteen"
            If NMBR = 14 Then Return "Fourteen"
            If NMBR = 15 Then Return "Fifteen"
            If NMBR = 16 Then Return "Sixteen"
            If NMBR = 17 Then Return "Seventeen"
            If NMBR = 18 Then Return "Eighteen"
            If NMBR = 19 Then Return "Nineteen"
        End If
        If NMBR >= 20 And NMBR <= 99 Then
            Dim SecondDigit As Integer = NMBR \ 10
            Dim FirstDigit As Integer = NMBR Mod 10

            If SecondDigit = 2 Then Return "Twenty " & GetText6(FirstDigit)
            If SecondDigit = 3 Then Return "Thirty " & GetText6(FirstDigit)
            If SecondDigit = 4 Then Return "Fourty " & GetText6(FirstDigit)
            If SecondDigit = 5 Then Return "Fifty " & GetText6(FirstDigit)
            If SecondDigit = 6 Then Return "Sixty " & GetText6(FirstDigit)
            If SecondDigit = 7 Then Return "Seventy " & GetText6(FirstDigit)
            If SecondDigit = 8 Then Return "Eighty " & GetText6(FirstDigit)
            If SecondDigit = 9 Then Return "Ninety " & GetText6(FirstDigit)
        End If
        If NMBR >= 100 And NMBR <= 999 Then
            Dim HundradDigit As Integer = NMBR \ 100
            Dim Remaining As Integer = NMBR Mod 100

            Dim TXT As String = GetText6(HundradDigit)
            TXT = TXT & "Hundrad"

            If Remaining <> 0 Then
                TXT = TXT & "and " & GetText6(Remaining)

            End If
            Return TXT
        End If
    End Function

    Private Sub TextBox27_LostFocus(sender As Object, e As EventArgs) Handles TextBox27.LostFocus

        If TextBox27.Text = "" Then
            'TextBox9.BackColor = Color.White
            MsgBox("CAN NOT BLANK", MsgBoxStyle.Critical)
            TextBox27.BackColor = Color.Red




        ElseIf Integer.Parse(TextBox27.Text) > 100 Or Integer.Parse(TextBox27.Text) < 0 Then
            MsgBox("INVALID MARKS", MsgBoxStyle.Critical)
            TextBox27.BackColor = Color.Red
            TextBox27.Focus()
        Else
            TextBox27.BackColor = Color.White

        End If
    End Sub


    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles TextBox27.TextChanged
        If Not IsNumeric(TextBox27.Text) Then
            TextBox28.Text = ""
            Exit Sub
        End If
        TextBox28.Text = GetText7(TextBox27.Text)
    End Sub
    Public Function GetText7(ByVal NMBR As Decimal) As String

        If NMBR <= 10 Then
            If NMBR = 0 Then Return ""
            If NMBR = 1 Then Return "One"
            If NMBR = 2 Then Return "Two"
            If NMBR = 3 Then Return "Three"
            If NMBR = 4 Then Return "Four"
            If NMBR = 5 Then Return "Five"
            If NMBR = 6 Then Return "Six"
            If NMBR = 7 Then Return "Seven"
            If NMBR = 8 Then Return "Eight"
            If NMBR = 9 Then Return "Nine"
            If NMBR = 10 Then Return "Ten"
        End If

        If NMBR >= 11 And NMBR <= 19 Then
            If NMBR = 11 Then Return "Eleven"
            If NMBR = 12 Then Return "Twelve"
            If NMBR = 13 Then Return "Thirteen"
            If NMBR = 14 Then Return "Fourteen"
            If NMBR = 15 Then Return "Fifteen"
            If NMBR = 16 Then Return "Sixteen"
            If NMBR = 17 Then Return "Seventeen"
            If NMBR = 18 Then Return "Eighteen"
            If NMBR = 19 Then Return "Nineteen"
        End If
        If NMBR >= 20 And NMBR <= 99 Then
            Dim SecondDigit As Integer = NMBR \ 10
            Dim FirstDigit As Integer = NMBR Mod 10

            If SecondDigit = 2 Then Return "Twenty " & GetText7(FirstDigit)
            If SecondDigit = 3 Then Return "Thirty " & GetText7(FirstDigit)
            If SecondDigit = 4 Then Return "Fourty " & GetText7(FirstDigit)
            If SecondDigit = 5 Then Return "Fifty " & GetText7(FirstDigit)
            If SecondDigit = 6 Then Return "Sixty " & GetText7(FirstDigit)
            If SecondDigit = 7 Then Return "Seventy " & GetText7(FirstDigit)
            If SecondDigit = 8 Then Return "Eighty " & GetText7(FirstDigit)
            If SecondDigit = 9 Then Return "Ninety " & GetText7(FirstDigit)
        End If
        If NMBR >= 100 And NMBR <= 999 Then
            Dim HundradDigit As Integer = NMBR \ 100
            Dim Remaining As Integer = NMBR Mod 100

            Dim TXT As String = GetText7(HundradDigit)
            TXT = TXT & "Hundrad"

            If Remaining <> 0 Then
                TXT = TXT & "and " & GetText7(Remaining)

            End If
            Return TXT
        End If
    End Function

    Private Sub TextBox30_GotFocus(sender As Object, e As EventArgs) Handles TextBox30.GotFocus

       
    End Sub

    Private Sub TextBox30_LostFocus(sender As Object, e As EventArgs) Handles TextBox30.LostFocus

        If TextBox30.Text = "" Then
            'TextBox9.BackColor = Color.White
            MsgBox("CAN NOT BLANK", MsgBoxStyle.Critical)
            TextBox30.BackColor = Color.Red




        ElseIf Integer.Parse(TextBox30.Text) > 50 Or Integer.Parse(TextBox30.Text) < 0 Then
            MsgBox("INVALID MARKS", MsgBoxStyle.Critical)
            TextBox30.BackColor = Color.Red
            TextBox30.Focus()
        Else
            TextBox30.BackColor = Color.White

        End If

        Dim sum As Integer
        Dim Percentage As Double
        Dim pass_class As String
        Dim result As String

        sum = Convert.ToInt32(TextBox9.Text) + Convert.ToInt32(TextBox12.Text) + Convert.ToInt32(TextBox15.Text) + Convert.ToInt32(TextBox18.Text) + Convert.ToInt32(TextBox21.Text) + Convert.ToInt32(TextBox24.Text) + Convert.ToInt32(TextBox27.Text) + Convert.ToInt32(TextBox30.Text)
        TextBox33.Text = sum
        Percentage = (sum / 750) * 100
        TextBox35.Text = Percentage
     
    
        If Percentage >= 75 And Percentage <= 100 Then
            pass_class = "FIRST CLASS WITH DISTINCTION"
        ElseIf Percentage >= 60 And Percentage <= 74 Then
            pass_class = "FIRST CLASS "
        ElseIf Percentage >= 40 And Percentage <= 59 Then
            pass_class = "SECOND CLASS "
        Else
            pass_class = "FAILED "
        End If

        TextBox36.Text = pass_class

        If Convert.ToInt16(TextBox9.Text) < 35 Or Convert.ToInt16(TextBox12.Text) < 35 Or Convert.ToInt16(TextBox15.Text) < 35 Or Convert.ToInt16(TextBox18.Text) < 35 Or Convert.ToInt16(TextBox21.Text) < 35 Or Convert.ToInt16(TextBox24.Text) < 35 Or Convert.ToInt16(TextBox27.Text) < 35 Or Convert.ToInt16(TextBox30.Text) < 35 Then
            result = "FAILED"



        ElseIf Percentage > 40 Then
            result = "PASSED"
        Else
            result = "FAILED"
        End If

        TextBox37.Text = result
    End Sub



    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs) Handles TextBox30.TextChanged
        If Not IsNumeric(TextBox30.Text) Then
            TextBox31.Text = ""
            Exit Sub
        End If
        TextBox31.Text = GetText8(TextBox30.Text)
    End Sub
    Public Function GetText8(ByVal NMBR As Decimal) As String

        If NMBR <= 10 Then
            If NMBR = 0 Then Return ""
            If NMBR = 1 Then Return "One"
            If NMBR = 2 Then Return "Two"
            If NMBR = 3 Then Return "Three"
            If NMBR = 4 Then Return "Four"
            If NMBR = 5 Then Return "Five"
            If NMBR = 6 Then Return "Six"
            If NMBR = 7 Then Return "Seven"
            If NMBR = 8 Then Return "Eight"
            If NMBR = 9 Then Return "Nine"
            If NMBR = 10 Then Return "Ten"
        End If

        If NMBR >= 11 And NMBR <= 19 Then
            If NMBR = 11 Then Return "Eleven"
            If NMBR = 12 Then Return "Twelve"
            If NMBR = 13 Then Return "Thirteen"
            If NMBR = 14 Then Return "Fourteen"
            If NMBR = 15 Then Return "Fifteen"
            If NMBR = 16 Then Return "Sixteen"
            If NMBR = 17 Then Return "Seventeen"
            If NMBR = 18 Then Return "Eighteen"
            If NMBR = 19 Then Return "Nineteen"
        End If
        If NMBR >= 20 And NMBR <= 99 Then
            Dim SecondDigit As Integer = NMBR \ 10
            Dim FirstDigit As Integer = NMBR Mod 10

            If SecondDigit = 2 Then Return "Twenty " & GetText8(FirstDigit)
            If SecondDigit = 3 Then Return "Thirty " & GetText8(FirstDigit)
            If SecondDigit = 4 Then Return "Fourty " & GetText8(FirstDigit)
            If SecondDigit = 5 Then Return "Fifty " & GetText8(FirstDigit)
            If SecondDigit = 6 Then Return "Sixty " & GetText8(FirstDigit)
            If SecondDigit = 7 Then Return "Seventy " & GetText8(FirstDigit)
            If SecondDigit = 8 Then Return "Eighty " & GetText8(FirstDigit)
            If SecondDigit = 9 Then Return "Ninety " & GetText8(FirstDigit)
        End If
        If NMBR >= 100 And NMBR <= 999 Then
            Dim HundradDigit As Integer = NMBR \ 100
            Dim Remaining As Integer = NMBR Mod 100

            Dim TXT As String = GetText8(HundradDigit)
            TXT = TXT & "Hundrad"

            If Remaining <> 0 Then
                TXT = TXT & "and " & GetText8(Remaining)

            End If
            Return TXT
        End If
    End Function

    Private Sub TextBox33_LostFocus(sender As Object, e As EventArgs) Handles TextBox33.LostFocus

        If TextBox33.Text = "" Then
            'TextBox9.BackColor = Color.White
            MsgBox("CAN NOT BLANK", MsgBoxStyle.Critical)
            TextBox33.BackColor = Color.Red




        ElseIf Integer.Parse(TextBox33.Text) > 750 Or Integer.Parse(TextBox33.Text) < 0 Then
            MsgBox("INVALID MARKS", MsgBoxStyle.Critical)
            TextBox33.BackColor = Color.Red
            TextBox33.Focus()
        Else
            TextBox33.BackColor = Color.White

        End If
    End Sub

    Private Sub TextBox33_TextChanged(sender As Object, e As EventArgs) Handles TextBox33.TextChanged

        If Not IsNumeric(TextBox33.Text) Then
            TextBox34.Text = ""
            Exit Sub
        End If
        TextBox34.Text = GetText9(TextBox33.Text)
    End Sub
    Public Function GetText9(ByVal NMBR As Decimal) As String

        If NMBR <= 10 Then
            If NMBR = 0 Then Return ""
            If NMBR = 1 Then Return "One"
            If NMBR = 2 Then Return "Two"
            If NMBR = 3 Then Return "Three"
            If NMBR = 4 Then Return "Four"
            If NMBR = 5 Then Return "Five"
            If NMBR = 6 Then Return "Six"
            If NMBR = 7 Then Return "Seven"
            If NMBR = 8 Then Return "Eight"
            If NMBR = 9 Then Return "Nine"
            If NMBR = 10 Then Return "Ten"
        End If

        If NMBR >= 11 And NMBR <= 19 Then
            If NMBR = 11 Then Return "Eleven"
            If NMBR = 12 Then Return "Twelve"
            If NMBR = 13 Then Return "Thirteen"
            If NMBR = 14 Then Return "Fourteen"
            If NMBR = 15 Then Return "Fifteen"
            If NMBR = 16 Then Return "Sixteen"
            If NMBR = 17 Then Return "Seventeen"
            If NMBR = 18 Then Return "Eighteen"
            If NMBR = 19 Then Return "Nineteen"
        End If
        If NMBR >= 20 And NMBR <= 99 Then
            Dim SecondDigit As Integer = NMBR \ 10
            Dim FirstDigit As Integer = NMBR Mod 10

            If SecondDigit = 2 Then Return "Twenty " & GetText9(FirstDigit)
            If SecondDigit = 3 Then Return "Thirty " & GetText9(FirstDigit)
            If SecondDigit = 4 Then Return "Fourty " & GetText9(FirstDigit)
            If SecondDigit = 5 Then Return "Fifty " & GetText9(FirstDigit)
            If SecondDigit = 6 Then Return "Sixty " & GetText9(FirstDigit)
            If SecondDigit = 7 Then Return "Seventy " & GetText9(FirstDigit)
            If SecondDigit = 8 Then Return "Eighty " & GetText9(FirstDigit)
            If SecondDigit = 9 Then Return "Ninety " & GetText9(FirstDigit)
        End If
        If NMBR >= 100 And NMBR <= 999 Then
            Dim HundradDigit As Integer = NMBR \ 100
            Dim Remaining As Integer = NMBR Mod 100

            Dim TXT As String = GetText9(HundradDigit)
            TXT = TXT & "Hundrad"

            If Remaining <> 0 Then
                TXT = TXT & "and " & GetText9(Remaining)

            End If
            Return TXT
        End If
    End Function

    Private Sub TextBox36_TextChanged(sender As Object, e As EventArgs) Handles TextBox36.TextChanged

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

    Private Sub TextBox33_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox33.KeyPress
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

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
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
End Class