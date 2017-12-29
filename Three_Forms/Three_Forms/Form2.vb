Public Class Form2
    Public Property x As Integer
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim g As New Form3
        g.z = Val(TextBox1.Text)
        g.x = x
        Me.Hide()
        g.Show()
    End Sub
End Class