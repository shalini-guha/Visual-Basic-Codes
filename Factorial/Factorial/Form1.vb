Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim j, valu, fact As Double
        valu = TextBox1.Text
        j = 1
        fact = 1
        While (j <= valu)
            fact = fact * j
            j = j + 1
        End While
        Label1.Text = fact
    End Sub
End Class


