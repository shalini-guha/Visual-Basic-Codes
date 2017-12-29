Imports System.Data.OleDb
Public Class Form1
    Dim con As New OleDbConnection
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "provider=microsoft.ace.oledb.12.0;data source=C:\Users\UEM\Desktop\CSE2A-03\Database7.accdb"
        con.Open()
        shalini()
    End Sub
    Private Sub shalini()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("select * from Table1", con)
        da.fill(dt)
        DataGridView1.DataSource = dt.DefaultView
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim command As OleDbCommand
        command = New OleDbCommand("select * from Table1 where Roll=@roll", con)
        command.Parameters.Add("@roll", OleDbType.Integer).Value = TextBox1.Text
        da = New OleDbDataAdapter(command)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            TextBox1.Text = dt.Rows(0)(0).ToString
            TextBox2.Text = dt.Rows(0)(1).ToString
            TextBox3.Text = dt.Rows(0)(2).ToString

        Else
            MsgBox("Roll Not Found")
        End If

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim command As OleDbCommand
        command = New OleDbCommand("delete from Table1 where Roll=@roll", con)
        command.Parameters.Add("@roll", OleDbType.Integer).Value = TextBox1.Text
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        da = New OleDbDataAdapter(command)
        da.Fill(dt)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
