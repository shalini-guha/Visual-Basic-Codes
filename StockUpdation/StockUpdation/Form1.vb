Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.StockDataSet1.Table1)
        'TODO: This line of code loads data into the 'StockDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.StockDataSet.Table1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim st, sl As Integer
        st = Val(TextBox3.Text)
        sl = Val(TextBox4.Text)
        If (sl > st) Then
            MsgBox("Stock not available")
        Else
            TextBox5.Text = Val(st - sl)
            TextBox3.Text = TextBox5.Text
            Table1BindingSource.EndEdit()
            Table1TableAdapter.Update(StockDataSet.Table1)
        End If
    End Sub
End Class
