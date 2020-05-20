Imports MySql.Data.MySqlClient
Public Class Form30
    Dim con As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public tbalpenerimaan As New DataTable
    Private Sub Form30_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            tbalpenerimaan.Clear()
            Dim command As New MySqlCommand("select id_dpenerimaan, d.id_penerimaan, tgl_penerimaan, no_faktur, id_barang, nama_barang, jumlah from detail_penerimaan d left join penerimaan p on d.id_penerimaan=p.id_penerimaan where `delete`=0 and tgl_penerimaan>='" + DateTimePicker1.Value.ToString("yyyyMMdd") + "'and tgl_penerimaan<='" + DateTimePicker2.Value.ToString("yyyyMMdd") + "'", con)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(tbalpenerimaan)
            Formreportpenerimaanvb.ShowDialog()
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
