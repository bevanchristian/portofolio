Imports MySql.Data.MySqlClient
Public Class Formubahreturpenjualan
    Dim connect As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public simpan2 As String
    Public c As Integer
    Private Sub Formubahreturpenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btsimpan.Enabled = False
            bttambahrb.Enabled = False
            bthapusrb.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btsimpan.Enabled = False
            bttambahrb.Enabled = False
            bthapusrb.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btsimpan.Enabled = False
            bttambahrb.Enabled = False
            bthapusrb.Enabled = False
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btsimpan.Enabled = True
            bttambahrb.Enabled = True
            bthapusrb.Enabled = True
        End If
        tbidpembelian.Enabled = False
        tbfaktur.Enabled = False
        tbkodebarang.Enabled = False
        Dim command2 As New MySqlCommand("SELECT * FROM retur_penjualan where `delete`='0' ;", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim dt As New DataTable
        dt.Clear()
        adapter2.Fill(dt)
        ComboBox1.DataSource = dt
        ComboBox1.ValueMember = "id_retur_penjualan"
        ComboBox1.DisplayMember = "id_retur_penjualan"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim command As New MySqlCommand("SELECT * FROM retur_dpenjualan where id_retur_penjualan='" + ComboBox1.SelectedValue.ToString + "'", connect)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        datatble1.Clear()
        adapter.Fill(datatble1)
        dgvbarang.DataSource = datatble1
    End Sub

    Private Sub dgvbarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellClick

        Dim hitung As Integer
        hitung = 0

        Dim command3 As New MySqlCommand("SELECT id_retur_penjualan FROM retur_penjualan r", connect)
        Dim adapter3 As New MySqlDataAdapter(command3)
        Dim datatble13 As New DataTable
        adapter3.Fill(datatble13)
        hitung = datatble13.Rows.Count() + 1
        simpan2 = "RJU" + hitung.ToString
        'tbreturpembelian.Text = simpan

        Dim command As New MySqlCommand("SELECT * FROM retur_dpeNJUALAN where id_dpeNJUALAN='" + dgvbarang.Item(0, dgvbarang.CurrentRow.Index).Value.ToString + "'", connect)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        datatble1.Clear()
        adapter.Fill(datatble1)
        tbidpembelian.Text = datatble1.Rows(0).Item(0).ToString
        tbkodebarang.Text = datatble1.Rows(0).Item(3).ToString
        tbnamabarang.Text = datatble1.Rows(0).Item(4).ToString
        tbidsuplier.Text = datatble1.Rows(0).Item(2).ToString
        tbjumlah.Text = datatble1.Rows(0).Item(5).ToString

        Dim command2 As New MySqlCommand("select no_pajak from retur_penjualan a,retur_dpenjualan b where a.id_retur_penjualan=b.id_retur_penjualan AND id_dpenjualan='" + dgvbarang.Item(0, dgvbarang.CurrentRow.Index).Value.ToString + "'", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim datatble12 As New DataTable
        datatble12.Clear()
        adapter2.Fill(datatble12)
        tbfaktur.Text = datatble12.Rows(0).Item(0).ToString
    End Sub

    Private Sub bttambahrb_Click(sender As Object, e As EventArgs) Handles bttambahrb.Click
        If tbkodebarang.Text <> "" And tbnamabarang.Text <> "" And tbfaktur.Text <> "" And tbjumlah.Text <> "" And tbidpembelian.Text <> "" And tbidsuplier.Text <> "" Then
            C = c + 1
            If RadioButton1.Checked = True Then
                Dim hitung As String
                Dim SIMPAN3 As String = 0
                Dim command81 As New MySqlCommand("SELECT * FROM retur_dpenjualan r", connect)
                Dim adapter81 As New MySqlDataAdapter(command81)
                Dim datatble81 As New DataTable
                adapter81.Fill(datatble81)
                hitung = datatble81.Rows.Count() + 1
                If hitung < 10 Then
                    SIMPAN3 = "PBUR00" + hitung.ToString

                ElseIf hitung >= 10 And hitung <= 99 Then
                    SIMPAN3 = "PBUR0" + hitung.ToString

                End If
                Dim hitung2 As String
                Dim SIMPAN22 As String
                Dim command34 As New MySqlCommand("SELECT id_retur_peNJUALAN FROM retur_peNJUALAN r", connect)
                Dim adapter34 As New MySqlDataAdapter(command34)
                Dim datatble134 As New DataTable
                adapter34.Fill(datatble134)
                hitung2 = datatble134.Rows.Count() + 1
                SIMPAN22 = "RJU" + hitung2.ToString
                Try
                    connect.Open()
                    Dim command2 As New MySqlCommand("insert into retur_dpenjualan values ('" + tbidpembelian.Text + "','" + SIMPAN22 + "','" + tbidsuplier.Text + "','" + tbkodebarang.Text + "','" + tbnamabarang.Text + "','" + tbjumlah.Text + "')", connect)
                    command2.ExecuteNonQuery()
                    MsgBox("sudah di masukan retur ubahan")
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try

                'Dim pengurangan As String = "0"
                'Dim command3 As New MySqlCommand("select sum(stok_masuk+'" + tbjumlah.Text + "') from stok_barang where id_barang='" + tbkodebarang.Text + "'", connect)
                'Dim adapter3 As New MySqlDataAdapter(command3)
                'Dim dt3 As New DataTable
                'dt3.Clear()
                'adapter3.Fill(dt3)
                'pengurangan = dt3.Rows(0).Item(0).ToString

                'Try
                '    connect.Open()
                '    Dim command2 As New MySqlCommand("update stok_barang set stok_masuk='" + pengurangan.ToString + "' where id_barang='" + tbkodebarang.Text + "'", connect)
                '    command2.ExecuteNonQuery()
                '    MsgBox("sudah di kurangi stok keluarnya ubah")
                '    connect.Close()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                '    connect.Close()
                'End Try
                'Dim tampung As String
                'Dim command5 As New MySqlCommand("select sum(stok_masuk-stok_keluar)from stok_barang where id_barang='" + tbkodebarang.Text + "'", connect)
                'Dim adapter5 As New MySqlDataAdapter(command5)
                'Dim dt5 As New DataTable
                'dt5.Clear()
                'adapter5.Fill(dt5)
                'tampung = dt5.Rows(0).Item(0).ToString
                'Try
                '    connect.Open()
                '    Dim command8 As New MySqlCommand("update stok_barang set stok_akhir='" + tampung.ToString + "' where id_barang='" + tbkodebarang.Text + "'", connect)
                '    command8.ExecuteNonQuery()
                '    MsgBox("sudah ahkir dikalkulasi ubah")
                '    connect.Close()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                '    connect.Close()
                'End Try


                Dim hitung77 As String
                Dim historyid As String
                Dim command52 As New MySqlCommand("SELECT * FROM HISTORY ", connect)
                Dim adapter52 As New MySqlDataAdapter(command52)
                Dim datatble152 As New DataTable
                adapter52.Fill(datatble152)
                hitung77 = datatble152.Rows.Count() + 1

                historyid = "H" + hitung77.ToString
                'TextBox2.Text = hitung


                Try
                    connect.Open()
                    Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbkodebarang.Text + "','" + tbnamabarang.Text + "','" + tbjumlah.Text + "','0','" + tbretur.Value.ToString("yyyyMMdd") + "','UBAHRETURPENJUALAN','CUSTOMER KEKURANGAN SAAT RETUR')", connect)
                    command2.ExecuteNonQuery()
                    MsgBox("sudah di masukan 2")
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try
            ElseIf RadioButton2.Checked = True Then


                'BELI/STOK MASUK
                'Dim hitung2 As String
                'Dim SIMPAN22 As String
                'Dim command34 As New MySqlCommand("SELECT id_retur_peMBELIAN FROM retur_PEMBELIAN r", connect)
                'Dim adapter34 As New MySqlDataAdapter(command34)
                'Dim datatble134 As New DataTable
                'adapter34.Fill(datatble134)
                'hitung2 = datatble134.Rows.Count() + 1
                'SIMPAN22 = "RPU" + hitung2.ToString

                'Try
                '    connect.Open()
                '    Dim command2 As New MySqlCommand("insert into retur_dpembelian values ('" + tbidpembelian.Text + "','" + SIMPAN22 + "','" + tbidsuplier.Text + "','" + tbkodebarang.Text + "','" + tbnamabarang.Text + "','" + tbjumlah.Text + "')", connect)
                '    command2.ExecuteNonQuery()
                '    MsgBox("sudah di masukan retur pembelian ubahan")
                '    connect.Close()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                '    connect.Close()
                'End Try



                Dim pengurangan As String = "0"
                Dim command3 As New MySqlCommand("select sum(stok_keluar+'" + tbjumlah.Text + "') from stok_barang where id_barang='" + tbkodebarang.Text + "'", connect)
                Dim adapter3 As New MySqlDataAdapter(command3)
                Dim dt3 As New DataTable
                dt3.Clear()
                adapter3.Fill(dt3)
                pengurangan = dt3.Rows(0).Item(0).ToString

                Try
                    connect.Open()
                    Dim command2 As New MySqlCommand("update stok_barang set stok_keluar='" + pengurangan.ToString + "' where id_barang='" + tbkodebarang.Text + "'", connect)
                    command2.ExecuteNonQuery()
                    MsgBox("sudah di kurangi stok keluarnya ubah")
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try
                Dim tampung As String
                Dim command5 As New MySqlCommand("select sum(stok_masuk-stok_keluar)from stok_barang where id_barang='" + tbkodebarang.Text + "'", connect)
                Dim adapter5 As New MySqlDataAdapter(command5)
                Dim dt5 As New DataTable
                dt5.Clear()
                adapter5.Fill(dt5)
                tampung = dt5.Rows(0).Item(0).ToString
                Try
                    connect.Open()
                    Dim command8 As New MySqlCommand("update stok_barang set stok_akhir='" + tampung.ToString + "' where id_barang='" + tbkodebarang.Text + "'", connect)
                    command8.ExecuteNonQuery()
                    MsgBox("sudah ahkir dikalkulasi ubah")
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try


                Dim hitung77 As String
                Dim historyid As String
                Dim command52 As New MySqlCommand("SELECT * FROM HISTORY ", connect)
                Dim adapter52 As New MySqlDataAdapter(command52)
                Dim datatble152 As New DataTable
                adapter52.Fill(datatble152)
                hitung77 = datatble152.Rows.Count() + 1

                historyid = "H" + hitung77.ToString

                Try
                    connect.Open()
                    Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbkodebarang.Text + "','" + tbnamabarang.Text + "','0','" + tbjumlah.Text + "','" + tbretur.Value.ToString("yyyyMMdd") + "','UBAHRETURPENJUALAN','CUSTOMER KELEBIHAN KETIKA RETUR')", connect)
                    command2.ExecuteNonQuery()
                    MsgBox("sudah di masukan 2")
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try
            End If
        Else
            MsgBox("isi data dahulu")
        End If

    End Sub
    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If c = 0 Then
            MsgBox("isi data dulu")
        Else
            c = 0

            If RadioButton2.Checked = True Then
                'Dim hitung2 As String
                'Dim SIMPAN22 As String
                'Dim command34 As New MySqlCommand("SELECT id_retur_peMBELIAN FROM retur_PEMBELIAN r", connect)
                'Dim adapter34 As New MySqlDataAdapter(command34)
                'Dim datatble134 As New DataTable
                'adapter34.Fill(datatble134)
                'hitung2 = datatble134.Rows.Count() + 1
                'SIMPAN22 = "RPU" + hitung2.ToString


                'Try
                '    connect.Open()
                '    Dim command2 As New MySqlCommand("insert into retur_pembelian values ('" + SIMPAN22 + "','" + tbfaktur.Text + "','" + tbretur.Value.ToString("yyyyMMdd") + "','0')", connect)
                '    command2.ExecuteNonQuery()
                '    MsgBox("sudah di masukan retur 2 ubah")
                '    connect.Close()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                '    connect.Close()
                'End Try

                Dim command As New MySqlCommand("SELECT * FROM history", connect)
                Dim adapter As New MySqlDataAdapter(command)
                Dim datatble1 As New DataTable
                datatble1.Clear()
                adapter.Fill(datatble1)
                dgvbarang.DataSource = datatble1

                'Dim hitung As Integer
                'hitung = 0
                'Dim simpan As String
                'Dim command3 As New MySqlCommand("SELECT id_retur_pembelian FROM retur_pembelian r", connect)

                'Dim adapter3 As New MySqlDataAdapter(command3)
                'Dim datatble3 As New DataTable
                'adapter3.Fill(datatble3)
                'hitung = datatble3.Rows.Count() + 1
                'simpan = "RP" + hitung.ToString

                'tbfaktur.Text = simpan
            ElseIf RadioButton1.Checked = True Then
                Dim hitung2 As String
                Dim SIMPAN22 As String
                Dim command34 As New MySqlCommand("SELECT id_retur_peNJUALAN FROM retur_peNJUALAN r", connect)
                Dim adapter34 As New MySqlDataAdapter(command34)
                Dim datatble134 As New DataTable
                adapter34.Fill(datatble134)
                hitung2 = datatble134.Rows.Count() + 1
                SIMPAN22 = "RJU" + hitung2.ToString
                Try
                    connect.Open()
                    Dim command2 As New MySqlCommand("insert into retur_penjualan values ('" + SIMPAN22 + "','" + tbfaktur.Text + "','" + tbretur.Value.ToString("yyyyMMdd") + "','0','0')", connect)
                    command2.ExecuteNonQuery()
                    MsgBox("sudah di masukan retur 2 ubah")
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try

                Dim command As New MySqlCommand("SELECT * FROM retur_dpeNJUALAN r where id_retur_penjualan='" + SIMPAN22 + "';", connect)
                Dim adapter As New MySqlDataAdapter(command)
                Dim datatble1 As New DataTable
                datatble1.Clear()
                adapter.Fill(datatble1)
                dgvbarang.DataSource = datatble1

                Dim hitung As Integer
                hitung = 0
                Dim simpan As String
                Dim command3 As New MySqlCommand("SELECT id_retur_penjualan FROM retur_penjualan r", connect)

                Dim adapter3 As New MySqlDataAdapter(command3)
                Dim datatble3 As New DataTable
                adapter3.Fill(datatble3)
                hitung = datatble3.Rows.Count() + 1
                simpan = "RJU" + hitung.ToString

                tbfaktur.Text = simpan
            End If
        End If
    End Sub
    Private Sub dgvbarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellContentClick

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'Lb_idpembelian.Text = "ID penjualan"
        'lb_returpemb.Text = "ID Retur penjualan"
        'lb_idsupplier.Text = "ID Customer"
        'lb_nofaktur.Text = "No Pajak"
    End Sub

    Private Sub bthapusrb_Click(sender As Object, e As EventArgs) Handles bthapusrb.Click
        Try
            connect.Open()
            Dim command22 As New MySqlCommand("update retur_penjualan set `delete`='1' where no_pajak='" + tbfaktur.Text + "' and id_retur_penjualan='" + ComboBox1.SelectedValue + "'", connect)
            command22.ExecuteNonQuery()
            MsgBox("sudah di hapus logical satu faktur")
            connect.Close()
            Dim command2 As New MySqlCommand("SELECT * FROM retur_penjualan where `delete`='0' ;", connect)
            Dim adapter2 As New MySqlDataAdapter(command2)
            Dim dt As New DataTable
            dt.Clear()
            adapter2.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.ValueMember = "id_retur_penjualan"
            ComboBox1.DisplayMember = "id_retur_penjualan"
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub tbjumlah_TextChanged(sender As Object, e As EventArgs) Handles tbjumlah.TextChanged

    End Sub

    Private Sub bttutuprb_Click(sender As Object, e As EventArgs) Handles bttutuprb.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'Lb_idpembelian.Text = "ID pembelian"
        'lb_returpemb.Text = "ID Retur pembelian"
        'lb_idsupplier.Text = "ID supplier"
        'lb_nofaktur.Text = "No faktur"
    End Sub

    Private Sub tbjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbjumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class


