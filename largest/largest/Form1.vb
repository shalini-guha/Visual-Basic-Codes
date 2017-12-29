Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, lar As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        lar = a
        If b > a Then
            If b > c Then
                lar = b
            Else
                lar = c

            End If
        End If
        Label2.Text = lar
    End Sub
End Class
