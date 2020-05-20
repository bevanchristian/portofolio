Imports MySql.Data.MySqlClient
Public Class Form28
    Dim con As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public tbalehistory As New DataTable
    Private Sub Form28_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            tbalehistory.Clear()
            Dim command As New MySqlCommand("SELECT * FROM history h where tgl_history>='" + DateTimePicker1.Value.ToString("yyyyMMdd") + "'and tgl_history<='" + DateTimePicker2.Value.ToString("yyyyMMdd") + "'", con)
            Dim adapter As New MySqlDataAdapter(command)
            Dim command2 As New MySqlCommand("select sum(stok_masuk-stok_keluar)from history where tgl_history>='" + DateTimePicker1.Value.ToString("yyyyMMdd") + "'and tgl_history<='" + DateTimePicker2.Value.ToString("yyyyMMdd") + "'", con)
            Dim adapter2 As New MySqlDataAdapter(command2)
            adapter.Fill(tbalehistory)
            adapter2.Fill(tbalehistory)
            Form29.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
