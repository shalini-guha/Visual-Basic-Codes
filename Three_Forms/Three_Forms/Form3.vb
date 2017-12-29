Public Class Form3
    Public Property x As Integer
    Public Property z As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim y, t As Integer
        y = Val(TextBox1.Text)
        t = x + y + z
        Label2.Text = t
    End Sub
End Class