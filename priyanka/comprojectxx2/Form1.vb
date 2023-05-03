Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
    End Sub
End Class
