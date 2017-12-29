Imports System.Data.OleDb
Imports System.IO

Public Class Form1
    Dim con As New OleDbConnection
    Dim ms As New System.IO.MemoryStream
    Dim bytes() As Byte
    Dim shalini() As Byte

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\UEM\Desktop\CSE2A-03\Database10.accdb"
        con.Open()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim opf As New OpenFileDialog
        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim command As New OleDbCommand
        command = New OleDbCommand("insert into table1(Roll,Name,Picture)values(@Roll,@Name,@Picture)", con)

        command.Parameters.Add("@Roll", OleDbType.Integer).Value = TextBox1.Text
        command.Parameters.Add("@Name", OleDbType.VarChar).Value = TextBox2.Text
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        shalini = ms.GetBuffer
        command.Parameters.Add("@Picture", OleDbType.Binary).Value = shalini

        If command.ExecuteNonQuery = 1 Then
            MsgBox("message inserted")
        Else
            MsgBox("record is not inserted")
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        Dim command As New OleDbCommand
        command = New OleDbCommand("select * from table1 where roll=@roll", con)
        command.Parameters.Add("@roll", OleDbType.Integer).Value = TextBox1.Text
        da = New OleDbDataAdapter(command)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            TextBox1.Text = dt.Rows(0)(0)
            TextBox2.Text = dt.Rows(0)(1)
            bytes = dt.Rows(0)(2)
            PictureBox1.Image = Image.FromStream(New System.IO.MemoryStream(bytes))
        Else
            MsgBox("record not found")

        End If

    End Sub
End Class

