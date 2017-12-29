Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str, str1 As String
        Dim i, j As Integer
        str = TextBox1.Text
        str1 = StrReverse(str)
        If StrComp(str, str1) = 0 Then
            Label1.Text = "Palindrome"
        Else
            Label1.Text = "Not a Palindrome"
        End If
    End Sub
End Class
