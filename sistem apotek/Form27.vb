Imports MySql.Data.MySqlClient
Public Class Form27
    Dim con As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public tbalepenjulan As New DataTable
    Private Sub Form27_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            tbalepenjulan.Clear()
            Dim command As New MySqlCommand("SELECT tgl_penjualan as `tanggal`,a.no_pajak as 'No Pajak', id_barang as 'ID Barang', nama_barang as 'Nama Barang',expire_date as 'Expire Date', harga_jual as 'Harga Jual',diskon as 'Diskon', total_jual as 'Total Jual', total_penjual as 'Total Penjual', id_customer as 'ID Customer' FROM t_penjualan a left join tdetail_penjualan b on a.no_pajak = b.no_pajak where `delete`=0 and tgl_penjualan>='" + DateTimePicker1.Value.ToString("yyyyMMdd") + "'and tgl_penjualan<='" + DateTimePicker2.Value.ToString("yyyyMMdd") + "'", con)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(tbalepenjulan)
            Formreportpenjualan.ShowDialog()
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

