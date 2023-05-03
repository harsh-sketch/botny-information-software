
Imports System.Data.OleDb
Public Class mainmenu
    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
    Public Sub findinformation(x As String)
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lenovo\Downloads\priyanka\priyankaDatabase2.accdb;")
        Dim command As New OleDbCommand("Select * FROM botnyTable1 WHERE treename = '" & x & "'", connection)
        connection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()
        If reader.Read() Then
            Dim treename As String = reader.GetString(1)
            Dim fruitflower As String = reader.GetString(2)
            Dim specie As String = reader.GetString(3)
            Dim wheather As String = reader.GetString(4)
            Dim found As String = reader.GetString(5)
            Dim usedfor As String = reader.GetString(6)
            Dim about As String = reader.GetString(7)
            Show_information.treename.Text = treename
            Show_information.fruitflower.Text = fruitflower
            Show_information.species.Text = specie
            Show_information.needwheather.Text = wheather
            Show_information.foundon.Text = found
            Show_information.usedfor.Text = usedfor
            Show_information.about.Text = about
            Show_information.Show()
            reader.Close()
        End If
        reader.Close()
        connection.Close()

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        findinformation("Jasmin")

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        findinformation("mango")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        findinformation("marigold")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        findinformation("sunflower")

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        findinformation("Rose")

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        findinformation("Mashrooms")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        findinformation(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updatex.Show()
        Me.Hide()
    End Sub
End Class