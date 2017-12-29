Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim f As New Form2
        f.x = Val(TextBox1.Text)
        Me.Hide()
        f.Show()

    End Sub
End Class
