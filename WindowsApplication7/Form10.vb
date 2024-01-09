Imports MySql.Data.MySqlClient

Public Class Form10

    Dim sCommand As MySqlCommand
    Dim sAdapter As MySqlDataAdapter
    Dim sBuilder As MySqlCommandBuilder
    Dim sDs As DataSet
    Dim sTable As DataTable
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

            
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim connectionString As String = "server=localhost;port=3307;Uid=admin ;pwd=admin;Database=student"
        Dim sql As String = "SELECT * FROM table 2"
        Dim connection As New MySqlConnection(connectionString)

        connection.Open()
        sCommand = New MySqlCommand(sql, connection)
        sAdapter = New MySqlDataAdapter(sCommand)
        sBuilder = New MySqlCommandBuilder(sAdapter)
        sDs = New DataSet()
        sAdapter.Fill(sDs, "table 2")
        sTable = sDs.Tables("table 2")
        connection.Close()
        DataGridView1.DataSource = sDs.Tables("table 2")
        DataGridView1.ReadOnly = True
        save_btn.Enabled = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub
End Class