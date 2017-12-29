Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim j, sum As Integer
        j = 1
        While (j <= 10)
            sum += j
            j = j + 1
        End While
        Label1.Text = sum

    End Sub
End Class
