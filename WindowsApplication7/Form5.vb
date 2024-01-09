Imports MySql.Data.MySqlClient
Public Class Form5

    Dim sCommand As MySqlCommand
    Dim sAdapter As MySqlDataAdapter
    Dim sBuilder As MySqlCommandBuilder
    Dim sDs As DataSet
    Dim sTable As DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "server=localhost;port=3306;Uid=admin ;pwd=admin;Database=student"
        Dim sql As String = "SELECT * FROM `table2` WHERE `COL 1`='" & TextBox1.Text & "' "
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        sCommand = New MySqlCommand(sql, connection)
        sAdapter = New MySqlDataAdapter(sCommand)
        sBuilder = New MySqlCommandBuilder(sAdapter)
        sDs = New DataSet()
        sAdapter.Fill(sDs, "table2")
        sTable = sDs.Tables("table2")
        connection.Close()
        DataGridView1.DataSource = sDs.Tables("table2")
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Dim connectionString1 As New MySqlConnection("datasource=localhost;port=3306;Uid=admin ;pwd=admin;Database=student")
    Function excecmd(ByVal cmd As MySqlCommand) As Boolean
        If connectionString1.State = ConnectionState.Closed Then
            connectionString1.Open()

        End If
        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True
            Else
                Return False

            End If


        Catch ex As Exception
            MsgBox("error")
            Return False
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Dim connectionString As String = "server=localhost;port=3306;Uid=admin ;pwd=admin;Database=student"


        '  Dim sql As String = "DELETE FROM `table2` WHERE `COL 1`=" & DataGridView1.SelectedRows(0).Index & " "
        Dim sql1 As String = "DELETE FROM table2 WHERE COL 1=" & TextBox1.Text & " "

        If MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'Dim connectionString As New MySqlConnection("datasource=localhost;port=3306;Uid=admin ;pwd=admin;Database=student")
            Dim delete_command As New MySqlCommand("DELETE FROM `table2` WHERE `COL 1`=@id", connectionString1)

            delete_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TextBox1.Text
            If excecmd(delete_command) Then
                MsgBox("Data Deleted")
            Else
                MsgBox("Not Deleted")
            End If


         
        End If
        DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '  Dim sql As String = "DELETE FROM `table2` WHERE `COL 2`=" & DataGridView1.SelectedRows(0).Index & " "
        Dim sql1 As String = "DELETE FROM table2 WHERE COL 2=" & TextBox4.Text & " "

        If MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim delete_command As New MySqlCommand("DELETE FROM `table2` WHERE `COL 2`=@id", connectionString1)

            delete_command.Parameters.Add("@id", MySqlDbType.VarChar).Value = TextBox4.Text
            If excecmd(delete_command) Then
                MsgBox("Data Deleted")
            Else
                MsgBox("Not Deleted")
            End If
        End If
        DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connectionString As String = "server=localhost;port=3306;Uid=admin ;pwd=admin;Database=student"
        Dim sql As String = "SELECT * FROM `table2` WHERE `COL 2`='" & TextBox4.Text & "' "
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        sCommand = New MySqlCommand(sql, connection)
        sAdapter = New MySqlDataAdapter(sCommand)
        sBuilder = New MySqlCommandBuilder(sAdapter)
        sDs = New DataSet()
        sAdapter.Fill(sDs, "table2")
        sTable = sDs.Tables("table2")
        connection.Close()
        DataGridView1.DataSource = sDs.Tables("table2")
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then


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