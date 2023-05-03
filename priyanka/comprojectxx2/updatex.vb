Imports System.Data.OleDb

Public Class updatex
    Private Sub BotnyTable1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BotnyTable1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PriyankaDatabase2DataSet)

    End Sub

    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'TODO: This line of code loads data into the 'PriyankaDatabase2DataSet.botnyTable1' table. You can move, or remove it, as needed.
        Me.BotnyTable1TableAdapter.Fill(Me.PriyankaDatabase2DataSet.botnyTable1)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BotnyTable1BindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error GoTo saveerr

        BotnyTable1BindingSource.RemoveCurrent()
saveerr:
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo saveerror
        BotnyTable1BindingSource.EndEdit()
        BotnyTable1TableAdapter.Update(PriyankaDatabase2DataSet.botnyTable1)

        MsgBox("Data has been saved")

saveerror:
        Exit Sub
    End Sub



    Dim pro As String
    Dim connectstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lenovo\Downloads\priyanka\priyankaDatabase2.accdb"
        connectstring = pro
        myconnection.ConnectionString = connectstring
        myconnection.Open()
        command = "update botnyTable1 set [treename]='" & TextBox2.Text & "', [foundon]='" & TextBox3.Text & "', [usedfor]='" & TextBox4.Text & "', [about]='" & TextBox8.Text & "', [species]='" & TextBox6.Text & "', [needwheather]='" & TextBox7.Text & "', [fruitflowergive]='" & TextBox5.Text & "' where [ID]=" & TextBox1.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        MsgBox("Information updated suuccefully")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            myconnection.Close()
        End Try
        Me.Refresh()
    End Sub
End Class