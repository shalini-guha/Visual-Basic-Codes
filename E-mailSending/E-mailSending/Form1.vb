Imports System.Net.Mail
Public Class Form1
    Dim smtp As New SmtpClient
    Dim message As New MailMessage
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        message.From = New MailAddress(TextBox1.Text)

        message.To.Add(TextBox3.Text)
        message.Subject = TextBox4.Text
        message.Body = TextBox5.Text

        smtp.Port = "587"
        smtp.Host = "smtp.live.com"
        smtp.EnableSsl = True
        smtp.Credentials = New Net.NetworkCredential(TextBox1.Text, TextBox2.Text)
        smtp.Send(message)
        MsgBox("mail sent")
    End Sub
End Class
