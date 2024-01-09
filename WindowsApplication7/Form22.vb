Imports MySql.Data.MySqlClient

Public Class Form22
    Dim sCommand As MySqlCommand
    Dim sAdapter As MySqlDataAdapter
    Dim sBuilder As MySqlCommandBuilder
    Dim sDs As DataSet
    Dim sTable As DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "server=localhost;port=3306;Uid=admin ;pwd=admin;Database=student"
        Dim sql As String = "SELECT * FROM `table2`"
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
        Button1.Enabled = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
End Class