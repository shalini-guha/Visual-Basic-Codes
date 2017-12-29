Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim year, leapyear As Integer
        leapyear = False
        year = TextBox1.Text
        If (year Mod 100 = 0) Then
            If (year Mod 400 = 0) Then
                leapyear = True
            End If
        ElseIf (year Mod 4 = 0) Then
            leapyear = True
        End If
        If leapyear = True Then
            Label2.Text = "Leap year"
        Else
            Label2.Text = "Not a leap year"
        End If
    End Sub
End Class
