Imports MySql.Data.MySqlClient
Public Class Form26
    Dim con As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public tbalepembelian As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            tbalepembelian.Clear()
            Dim command As New MySqlCommand("SELECT tgl_pembelian as 'tanggal' ,a.no_faktur as 'No Faktur', id_barang as 'ID Barang', nama_barang as 'Nama Barang',expire_date as 'Expire Date', harga_beli as 'Harga Beli',diskon as 'Diskon', total_beli as 'Total Beli', total_pembelian as 'Total Pembelian', id_supplier as 'ID Supplier' FROM t_pembelian a left join tdetail_pembelian b on a.no_faktur = b.no_faktur where `delete`=0 and tgl_pembelian>='" + DateTimePicker1.Value.ToString("yyyyMMdd") + "'and tgl_pembelian<='" + DateTimePicker2.Value.ToString("yyyyMMdd") + "'", con)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(tbalepembelian)
            Formreportpembelian.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Form26_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class