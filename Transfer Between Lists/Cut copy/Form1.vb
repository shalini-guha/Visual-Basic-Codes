Public Class Form1


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a As String
        a = TextBox1.Text
        ListBox1.Items.Add(a)
        TextBox1.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim b As String
        b = TextBox2.Text
        ListBox2.Items.Add(b)
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As String
        c = ListBox1.SelectedItem
        ListBox2.Items.Add(c)
        ListBox1.Items.Remove(c)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim c As String
        c = ListBox2.SelectedItem
        ListBox1.Items.Add(c)
        ListBox2.Items.Remove(c)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c As String
        c = ListBox1.SelectedItem
        ListBox2.Items.Add(c)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim c As String
        c = ListBox2.SelectedItem
        ListBox1.Items.Add(c)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ListBox2.Items.AddRange(ListBox1.Items)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ListBox1.Items.AddRange(ListBox2.Items)
    End Sub
End Class
