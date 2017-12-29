Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x, r As Integer
        x = Val(TextBox1.Text)
        r = x Mod 2
        If r = 0 Then
            Label1.Text = "Even" + x.ToString()
        Else
            Label1.Text = "Odd" + x.ToString()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
