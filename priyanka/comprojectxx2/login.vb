Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "priyanka" And TextBox2.Text = "pass123" Then
            MsgBox("Login Successful")
            mainmenu.Show()
            Me.Close()
            Form1.Hide()
        Else
            MsgBox("Invalid Credentials")
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub
End Class