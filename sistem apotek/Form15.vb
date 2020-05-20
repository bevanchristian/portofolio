Imports MySql.Data.MySqlClient
Public Class Form15
    Dim connect As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public hitung2 As String
    Public counter3 As Integer
    Public simpan3 As String = 0
    Public b As Integer
    Public SIMPAN2 As String = 0
    Public SIMPANPAJAK As String = 0
    Public counter As Integer
    Public c As Integer
    Dim simpanretur As String
    Dim simpanbelom As Integer

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btsimpan.Enabled = False
            bthapusbeli.Enabled = False
            btbatalbeli.Enabled = False
            bthapusbeli.Enabled = False
            btsimpan.Enabled = False
            btubahbeli.Enabled = False
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btsimpan.Enabled = False
            bthapusbeli.Enabled = False
            btbatalbeli.Enabled = False
            bthapusbeli.Enabled = False
            btsimpan.Enabled = False
            btubahbeli.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btsimpan.Enabled = False
            bthapusbeli.Enabled = False
            btbatalbeli.Enabled = False
            bthapusbeli.Enabled = False
            btsimpan.Enabled = False
            btubahbeli.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btsimpan.Enabled = True
            bthapusbeli.Enabled = True
            btbatalbeli.Enabled = True
            bthapusbeli.Enabled = True
            btsimpan.Enabled = True
            btubahbeli.Enabled = True

        End If
        b = 1
        Dim command2 As New MySqlCommand("select no_faktur from t_pembelian where `delete`=0", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim datatble2 As New DataTable
        datatble2.Clear()
        adapter2.Fill(datatble2)
        ComboBox1.DataSource = datatble2
        ComboBox1.DisplayMember = "no_faktur"
        ComboBox1.ValueMember = "no_faktur"

        Dim command As New MySqlCommand("select t.no_faktur,tgl_pembelian,id_supplier,total_pembelian,id_dpembelian,id_barang,nama_barang,harga_beli,diskon,no_batch,expire_date,total_beli from t_pembelian t left join tdetail_pembelian s on t.no_faktur=s.no_faktur where t.no_faktur='" + ComboBox1.SelectedValue + "';", connect)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        datatble1.Clear()
        adapter.Fill(datatble1)
        GridControl1.DataSource = datatble1

        Dim hitung As Integer = 0
        Dim command6 As New MySqlCommand("SELECT * FROM t_pembelian t", connect)
        Dim adapter6 As New MySqlDataAdapter(command6)
        Dim datatble6 As New DataTable
        adapter6.Fill(datatble6)
        hitung = datatble6.Rows.Count() + 1
        simpan3 = "FU" + hitung.ToString
        tbfakturbeli.Text = simpan3

        Dim hitung2 As Integer
        hitung2 = 0

        Dim command23 As New MySqlCommand("SELECT id_retur_pembelian FROM retur_pembelian r", connect)
        Dim adapter23 As New MySqlDataAdapter(command23)
        Dim datatble13 As New DataTable
        adapter23.Fill(datatble13)
        hitung2 = datatble13.Rows.Count() + 1
        simpanretur = "RP" + hitung2.ToString


    End Sub

    Private Sub dgvpembelian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpembelian.CellContentClick
        'Dim command2 As New MySqlCommand("select t.no_faktur,tgl_pembelian,id_supplier,total_pembelian,id_dpembelian,id_barang,nama_barang,harga_beli,diskon,no_batch,expire_date,total_beli from t_pembelian t left join tdetail_pembelian s on t.no_faktur=s.no_faktur where id_dpembelian='" + dgvpembelian.Item(4, dgvpembelian.CurrentRow.Index).Value.ToString + "'", connect)

        'Dim adapter2 As New MySqlDataAdapter(command2)
        'Dim datatble1 As New DataTable
        'adapter2.Fill(datatble1)


        'tbfakturbeli.Text = datatble1.Rows(0).Item(0)
        'tbkodesup.Text = datatble1.Rows(0).Item(2)
        'TextBox1.Text = datatble1.Rows(0).Item(1)
        'tbkodejual.Text = datatble1.Rows(0).Item(5)
        'tbbathbeli.Text = datatble1.Rows(0).Item(9)
        'tbhrgbeli.Text = datatble1.Rows(0).Item(7)
        'tbtotbeli.Text = datatble1.Rows(0).Item(3)
        'tbidbeli.Text = datatble1.Rows(0).Item(4)
        'tbnamabrg.Text = datatble1.Rows(0).Item(6)
        'TextBox2.Text = datatble1.Rows(0).Item(10)
        'TextBox3.Text = datatble1.Rows(0).Item(8)
        'totalbelitb.Text = datatble1.Rows(0).Item(11)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim command As New MySqlCommand("select t.no_faktur,tgl_pembelian,id_supplier,total_pembelian,id_dpembelian,id_barang,nama_barang,harga_beli,diskon,no_batch,expire_date,total_beli from t_pembelian t left join tdetail_pembelian s on t.no_faktur=s.no_faktur where t.no_faktur='" + ComboBox1.SelectedValue.ToString + "' ;", connect)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        datatble1.Clear()
        adapter.Fill(datatble1)
        GridControl1.DataSource = datatble1
        GridView1.PopulateColumns()
        Dim hitung As Integer = 0
        Dim command6 As New MySqlCommand("SELECT * FROM t_pembelian t", connect)

        Dim adapter6 As New MySqlDataAdapter(command6)
        Dim datatble6 As New DataTable
        adapter6.Fill(datatble6)

        hitung = datatble6.Rows.Count() + 1
        simpan3 = "FU" + hitung.ToString
        tbfakturbeli.Text = simpan3

    End Sub

    Private Sub tbfakturbeli_TextChanged(sender As Object, e As EventArgs) Handles tbfakturbeli.TextChanged

    End Sub

    Private Sub btubahbeli_Click(sender As Object, e As EventArgs) Handles btubahbeli.Click
        b = 0


        If tbtotbeli.Text <> "" And tbbathbeli.Text <> "" And tbkodesup.Text <> "" And tbfakturbeli.Text <> "" And tbhrgbeli.Text <> "" And tbidbeli.Text <> "" And tbkodejual.Text <> "" And tbnamabrg.Text <> "" Then
            c = c + 1
            simpanbelom = 0
            If rdkekurangan.Checked = True Then
                counter = counter + tbtotbeli.Text
                Dim hitung As Integer
                hitung = 0
                Dim SIMPAN2 As String = 0
                Dim command8 As New MySqlCommand("SELECT * FROM tdetail_pembelian ", connect)
                Dim adapter8 As New MySqlDataAdapter(command8)
                Dim datatble8 As New DataTable
                adapter8.Fill(datatble8)
                hitung = datatble8.Rows.Count() + 1
                If hitung < 10 Then
                    SIMPAN2 = "PBU00" + hitung.ToString

                ElseIf hitung >= 10 And hitung <= 99 Then
                    SIMPAN2 = "PBU0" + hitung.ToString

                End If

                Try
                    connect.Open()
                    Dim command2 As New MySqlCommand("insert into tdetail_pembelian values ('" + SIMPAN2 + "','" + simpan3 + "','" + tbkodejual.Text + "','" + tbnamabrg.Text + "','" + tbhrgbeli.Text + "','" + Textbox3.Text + "','" + tbbathbeli.Text + "','" + Textbox2.Text + "','" + totalbelitb.Text + "')", connect)
                    command2.ExecuteNonQuery()
                    MsgBox("sudah di masukan 2")
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try

                Dim hitung3 As Integer
                Dim historyid As String
                Dim command5 As New MySqlCommand("SELECT * FROM HISTORY ", connect)
                Dim adapter5 As New MySqlDataAdapter(command5)
                Dim datatble15 As New DataTable
                adapter5.Fill(datatble15)
                hitung3 = datatble15.Rows.Count() + 1
                historyid = "H" + hitung.ToString

                Try
                    connect.Open()
                    Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbkodejual.Text + "','" + tbnamabrg.Text + "','" + totalbelitb.Text + "','0','" + textbox1.Value.ToString("yyyyMMdd") + "','pembelian','kekurangan barang')", connect)
                    command2.ExecuteNonQuery()
                    MsgBox("sudah di masukan 2")
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try

            ElseIf rdkelebihan.Checked = True Then
                'counter = counter + tbtotbeli.Text
                'SIMPANPAJAK = ""
                'Dim hitung As Integer = 0
                'Dim command7 As New MySqlCommand("SELECT * FROM t_penjualan t", connect)

                'Dim adapter7 As New MySqlDataAdapter(command7)
                'Dim datatble7 As New DataTable
                'adapter7.Fill(datatble7)
                'hitung = datatble7.Rows.Count() + 1
                'SIMPANPAJAK = "NPU" + hitung.ToString
                'tbfakturbeli.Text = SIMPANPAJAK
                'Dim siu As String

                'Dim historyid As String
                'Dim command5 As New MySqlCommand("SELECT * FROM HISTORY ", connect)
                'Dim adapter5 As New MySqlDataAdapter(command5)
                'Dim datatble15 As New DataTable
                'adapter5.Fill(datatble15)
                'hitung = datatble15.Rows.Count() + 1
                'historyid = "H" + hitung.ToString
                'Dim hitung2 As Integer
                'hitung2 = 0

                'Dim command8 As New MySqlCommand("SELECT * FROM tdetail_penjualan ", connect)
                'Dim adapter8 As New MySqlDataAdapter(command8)
                'Dim datatble8 As New DataTable
                'adapter8.Fill(datatble8)
                'hitung2 = datatble8.Rows.Count() + 1
                'If hitung2 < 10 Then
                '    SIMPAN2 = "PJU00" + hitung2.ToString

                'ElseIf hitung2 >= 10 And hitung2 <= 99 Then
                '    SIMPAN2 = "PJU0" + hitung2.ToString
                'End If
                'Try
                '    connect.Open()
                '    Dim command24 As New MySqlCommand("insert into tdetail_penjualan values ('" + SIMPAN2 + "','" + SIMPANPAJAK + "','" + tbkodejual.Text + "','" + tbnamabrg.Text + "','" + tbhrgbeli.Text + "','" + Textbox3.Text + "','" + tbbathbeli.Text + "','" + textbox1.Text + "','" + totalbelitb.Text + "')", connect)
                '    command24.ExecuteNonQuery()
                '    MsgBox("sudah di masukan ubahan ke tdetail")
                '    connect.Close()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                '    connect.Close()
                'End Try
                'Dim command44 As New MySqlCommand("select sum(stok_keluar+'" + totalbelitb.Text + "') from stok_barang where id_barang='" + tbkodejual.Text + "'", connect)
                'Dim adapter44 As New MySqlDataAdapter(command44)
                'Dim datatble44 As New DataTable
                'datatble44.Clear()
                'adapter44.Fill(datatble44)
                'siu = datatble44.Rows(0).Item(0).ToString
                'Try
                '    connect.Open()
                '    Dim command2 As New MySqlCommand("update stok_barang set stok_keluar='" + siu + "' where id_barang='" + tbkodejual.Text + "'", connect)
                '    command2.ExecuteNonQuery()
                '    MsgBox("sudah di masukan 2")
                '    connect.Close()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                '    connect.Close()
                'End Try
                'Dim ahkhir As String
                'Dim command6 As New MySqlCommand("select sum(stok_masuk-stok_keluar) from stok_barang where id_barang='" + tbkodejual.Text + "'", connect)
                'Dim adapter6 As New MySqlDataAdapter(command6)
                'Dim datatble6 As New DataTable
                'datatble6.Clear()
                'adapter6.Fill(datatble6)
                'ahkhir = ""
                'ahkhir = datatble6.Rows(0).Item(0).ToString
                'connect.Open()
                'Dim command25 As New MySqlCommand("update stok_barang set stok_akhir='" + ahkhir + "' where id_barang='" + tbkodejual.Text + "'", connect)
                'command25.ExecuteNonQuery()
                'MsgBox("sudah di update stok akhirnya")
                'connect.Close()

                'Try
                '    connect.Open()
                '    Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbkodejual.Text + "','" + tbnamabrg.Text + "','0','" + totalbelitb.Text + "','" + textbox1.Value.ToString("yyyyMMdd") + "','pembelian','kelebihan barang')", connect)
                '    command2.ExecuteNonQuery()
                '    MsgBox("sudah di masukan 2")
                '    connect.Close()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                '    connect.Close()
                'End Try


                Try
                    connect.Open()
                    Dim command2 As New MySqlCommand("insert into retur_dpembelian values ('" + tbidbeli.Text + "','" + simpanretur + "','" + tbkodesup.Text + "','" + tbkodejual.Text + "','" + tbnamabrg.Text + "','" + totalbelitb.Text + "')", connect)
                    command2.ExecuteNonQuery()
                    MsgBox("sudah di masukan retur pembelian")
                    connect.Close()


                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try
                Try
                    Dim gaeretur As String
                    gaeretur = "0"
                    Dim command33 As New MySqlCommand("select stok_keluar from stok_barang where id_barang='" + tbkodejual.Text + "'", connect)
                    Dim adapter33 As New MySqlDataAdapter(command33)
                    Dim dt33 As New DataTable
                    dt33.Clear()
                    adapter33.Fill(dt33)
                    gaeretur = dt33.Rows(0).Item(0).ToString
                Catch ex As Exception

                End Try

                Dim pengurangan As String = "0"
                Dim command3 As New MySqlCommand("select sum(stok_keluar+'" + totalbelitb.Text + "') from stok_barang where id_barang='" + tbkodejual.Text + "'", connect)
                Dim adapter3 As New MySqlDataAdapter(command3)
                Dim dt3 As New DataTable
                dt3.Clear()
                adapter3.Fill(dt3)
                pengurangan = dt3.Rows(0).Item(0).ToString

                Try
                    connect.Open()
                    Dim command2 As New MySqlCommand("update stok_barang set stok_keluar='" + pengurangan.ToString + "' where id_barang='" + tbkodejual.Text + "'", connect)
                    command2.ExecuteNonQuery()
                    MsgBox("sudah di kurangi stok keluarnya")
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try
                Dim tampung As String
                Dim command5 As New MySqlCommand("select sum(stok_masuk-stok_keluar)from stok_barang where id_barang='" + tbkodejual.Text + "'", connect)
                Dim adapter5 As New MySqlDataAdapter(command5)
                Dim dt5 As New DataTable
                dt5.Clear()
                adapter5.Fill(dt5)
                tampung = dt5.Rows(0).Item(0).ToString
                Try
                    connect.Open()
                    Dim command8 As New MySqlCommand("update stok_barang set stok_akhir='" + tampung.ToString + "' where id_barang='" + tbkodejual.Text + "'", connect)
                    command8.ExecuteNonQuery()
                    MsgBox("sudah ahkir dikalkulasi")
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try

                Dim hitung11 As String = ""
                Dim historyid As String = ""
                Dim command52 As New MySqlCommand("SELECT * FROM HISTORY ", connect)
                Dim adapter52 As New MySqlDataAdapter(command52)
                Dim datatble152 As New DataTable
                adapter52.Fill(datatble152)
                hitung11 = datatble152.Rows.Count() + 1

                historyid = "H" + hitung11.ToString
                'TextBox2.Text = hitung


                Try
                    connect.Open()
                    Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbkodejual.Text + "','" + tbnamabrg.Text + "','0','" + totalbelitb.Text + "','" + textbox1.Value.ToString("yyyyMMdd") + "','pembelian','barang di kembalikan karena kelebihan beli')", connect)
                    command2.ExecuteNonQuery()
                    MsgBox("sudah di masukan 2")
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try

            End If
            'Dim total As String
            'Dim command10 As New MySqlCommand("  SELECT SUM(HARGA_BELI) FROM TDETAIL_PEMBELIAN WHERE NO_FAKTUR='" + simpan3 + "'", connect)
            'Dim adapter10 As New MySqlDataAdapter(command10)
            'Dim datatble10 As New DataTable
            'adapter10.Fill(datatble10)
            'total = datatble10.Rows(0).Item(0)


            'Try
            '    connect.Open()
            '    Dim command6 As New MySqlCommand("insert into t_pembelian values ('" + simpan3 + "','" + TextBox1.Text + "','" + tbkodesup.Text + "','" + total + "')", connect)
            '    command6.ExecuteNonQuery()
            '    MsgBox("sudah di masukan")
            '    connect.Close()
            '    Form15_Load(sender, e)

            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    connect.Close()
            'End Try
        Else
            MsgBox("isi data dahulu")
        End If

    End Sub

    Private Sub totalbelitb_TextChanged(sender As Object, e As EventArgs) Handles ghhg.TextChanged


    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If c = 0 Then
            MsgBox("isi data dulu")
        Else
            c = 0
            simpanbelom = 0
            If rdkekurangan.Checked = True Then


                Dim total As String
                Dim command10 As New MySqlCommand("select sum(harga_beli * total_beli) from tdetail_pembelian where no_faktur='" + simpan3 + "'", connect)
                Dim adapter10 As New MySqlDataAdapter(command10)
                Dim datatble10 As New DataTable
                adapter10.Fill(datatble10)
                total = datatble10.Rows(0).Item(0).ToString

                Try
                    connect.Open()
                    Dim command6 As New MySqlCommand("insert into t_pembelian values ('" + simpan3 + "','" + textbox1.Value.ToString("yyyyMMdd") + "','" + tbkodesup.Text + "','" + counter.ToString + "' ,'0','0')", connect)
                    command6.ExecuteNonQuery()
                    MsgBox("sudah di masukan")
                    connect.Close()
                    Dim command As New MySqlCommand("select t.no_faktur,tgl_pembelian,id_supplier,total_pembelian,id_dpembelian,id_barang,nama_barang,harga_beli,diskon,no_batch,expire_date,total_beli from t_pembelian t left join tdetail_pembelian s on t.no_faktur=s.no_faktur where t.no_faktur='" + simpan3 + "';", connect)
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim datatble1 As New DataTable
                    datatble1.Clear()
                    adapter.Fill(datatble1)
                    GridControl1.DataSource = datatble1
                    GridView1.PopulateColumns()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try

                Dim hitung As Integer = 0
                Dim command7 As New MySqlCommand("SELECT * FROM t_pembelian t", connect)

                Dim adapter7 As New MySqlDataAdapter(command7)
                Dim datatble7 As New DataTable
                adapter7.Fill(datatble7)

                hitung = datatble7.Rows.Count() + 1
                simpan3 = "FU" + hitung.ToString
                tbfakturbeli.Text = simpan3
                counter = 0

            ElseIf rdkelebihan.Checked = True Then

                'Dim total As String
                'Dim command10 As New MySqlCommand("select sum(harga_jual * total_jual) from tdetail_penjualan where no_pajak='" + SIMPANPAJAK + "'", connect)
                'Dim adapter10 As New MySqlDataAdapter(command10)
                'Dim datatble10 As New DataTable
                'adapter10.Fill(datatble10)
                'total = datatble10.Rows(0).Item(0).ToString

                'Try
                '    connect.Open()
                '    Dim command6 As New MySqlCommand("insert into t_penjualan values ('" + SIMPANPAJAK + "','" + textbox1.Value.ToString("yyyyMMdd") + "','" + tbkodesup.Text + "','" + counter.ToString + "' ,'0')", connect)
                '    command6.ExecuteNonQuery()
                '    MsgBox("sudah di masukan ubahan")
                '    connect.Close()
                '    Dim command As New MySqlCommand("select t.no_pajak,tgl_penjualan,total_penjual,id_dpenjualan,id_barang,nama_barang,harga_jual,diskon,no_batch,expire_date,id_customer from t_penjualan t left join tdetail_penjualan s on t.no_pajak=s.no_pajak where t.no_pajak='" + SIMPAN2 + "';", connect)
                '    Dim adapter As New MySqlDataAdapter(command)
                '    Dim datatble1 As New DataTable
                '    datatble1.Clear()
                '    adapter.Fill(datatble1)
                '    GridControl1.DataSource = datatble1
                '    GridView1.PopulateColumns()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                '    connect.Close()
                'End Try
                'Dim command75 As New MySqlCommand("SELECT * FROM t_penjualan t where no_pajak='" + SIMPANPAJAK + "'", connect)
                'Dim adapter75 As New MySqlDataAdapter(command75)
                'Dim datatble75 As New DataTable
                'adapter75.Fill(datatble75)
                'GridControl1.DataSource = datatble75
                'GridView1.PopulateColumns()

                'SIMPANPAJAK = ""
                'Dim hitung As Integer = 0
                'Dim command7 As New MySqlCommand("SELECT * FROM t_penjualan t", connect)

                'Dim adapter7 As New MySqlDataAdapter(command7)
                'Dim datatble7 As New DataTable
                'adapter7.Fill(datatble7)
                'hitung = datatble7.Rows.Count() + 1
                'SIMPANPAJAK = "NPU" + hitung.ToString
                'tbfakturbeli.Text = SIMPANPAJAK
                'counter = 0

                Try
                    connect.Open()
                    Dim command2 As New MySqlCommand("insert into retur_pembelian values ('" + simpanretur.ToString + "','" + ComboBox1.SelectedValue + "','" + textbox1.Value.ToString("yyyyMMdd") + "','0')", connect)
                    command2.ExecuteNonQuery()
                    MsgBox("sudah di masukan retur 2")
                    connect.Close()
                    'formreturbeli_Load(sender, e)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connect.Close()
                End Try

                Dim command As New MySqlCommand("SELECT * FROM retur_dpembelian r where id_retur_pembelian='" + simpanretur.ToString + "';", connect)
                Dim adapter As New MySqlDataAdapter(command)
                Dim datatble1 As New DataTable
                datatble1.Clear()
                adapter.Fill(datatble1)
                GridControl1.DataSource = datatble1
                GridView1.PopulateColumns()
                Dim hitung As Integer
                hitung = 0

                Dim command3 As New MySqlCommand("SELECT id_retur_pembelian FROM retur_pembelian r", connect)

                Dim adapter3 As New MySqlDataAdapter(command3)
                Dim datatble3 As New DataTable
                adapter3.Fill(datatble3)
                hitung = datatble3.Rows.Count() + 1
                simpanretur = "RP" + hitung.ToString

            End If
        End If
    End Sub

    Private Sub bthapusbeli_Click(sender As Object, e As EventArgs) Handles bthapusbeli.Click
        Try
            connect.Open()
            Dim command3 As New MySqlCommand("update t_pembelian set `delete`=1 where no_faktur='" + ComboBox1.SelectedValue + "'", connect)
            command3.ExecuteNonQuery()
            MsgBox("sudah di hapus logical satu faktur")
            connect.Close()
            Dim command2 As New MySqlCommand("select no_faktur from t_pembelian where `delete`=0", connect)
            Dim adapter2 As New MySqlDataAdapter(command2)
            Dim datatble2 As New DataTable
            datatble2.Clear()
            adapter2.Fill(datatble2)
            ComboBox1.DataSource = datatble2
            ComboBox1.DisplayMember = "no_faktur"
            ComboBox1.ValueMember = "no_faktur"
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub totalbelitb_TextChanged_1(sender As Object, e As EventArgs) Handles totalbelitb.TextChanged
        Try
            Dim asa As String
            tbtotbeli.Text = 0
            hitung2 = 0

            hitung2 = totalbelitb.Text * tbhrgbeli.Text
            tbtotbeli.Text = hitung2.ToString
            counter3 = hitung2
            If Textbox3.Text <> "0" Then
                asa = totalbelitb.Text * tbhrgbeli.Text / Textbox3.Text
                hitung2 = (totalbelitb.Text * tbhrgbeli.Text) - asa.ToString
                tbtotbeli.Text = hitung2.ToString
                'diskon ngitunge yak apa
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ghhg_Click(sender As Object, e As EventArgs) Handles ghhg.Click

    End Sub

    Private Sub tbhrgbeli_TextChanged(sender As Object, e As EventArgs) Handles tbhrgbeli.TextChanged
        Try
            Dim asa As String
            tbtotbeli.Text = 0
            hitung2 = 0

            hitung2 = totalbelitb.Text * tbhrgbeli.Text
            tbtotbeli.Text = hitung2.ToString
            counter3 = hitung2
            If Textbox3.Text <> "0" Then
                asa = totalbelitb.Text * tbhrgbeli.Text / Textbox3.Text
                hitung2 = (totalbelitb.Text * tbhrgbeli.Text) - asa.ToString
                tbtotbeli.Text = hitung2.ToString
                'diskon ngitunge yak apa
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btutupbeli_Click(sender As Object, e As EventArgs) Handles btutupbeli.Click
        If simpanbelom = 0 And c > 0 Then
            MsgBox("tekan simpan dulu")
        Else
            b = 0
            Dim tutup As String
            tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If tutup = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btviewsup_Click(sender As Object, e As EventArgs) Handles btviewsup.Click
        formsupplier.ShowDialog()
    End Sub

    Private Sub btviewbarang_Click(sender As Object, e As EventArgs) Handles btviewbarang.Click
        formbarang.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Dim command2 As New MySqlCommand("select t.no_faktur,tgl_pembelian,id_supplier,total_pembelian,id_dpembelian,id_barang,nama_barang,harga_beli,diskon,no_batch,expire_date,total_beli from t_pembelian t left join tdetail_pembelian s on t.no_faktur=s.no_faktur where id_dpembelian='" + GridView1.GetFocusedDataRow(4).ToString + "'", connect)

        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim datatble1 As New DataTable
        adapter2.Fill(datatble1)


        tbfakturbeli.Text = datatble1.Rows(0).Item(0)
        tbkodesup.Text = datatble1.Rows(0).Item(2)
        textbox1.Text = datatble1.Rows(0).Item(1)
        tbkodejual.Text = datatble1.Rows(0).Item(5)
        tbbathbeli.Text = datatble1.Rows(0).Item(9)
        tbhrgbeli.Text = datatble1.Rows(0).Item(7)
        tbtotbeli.Text = datatble1.Rows(0).Item(3)
        tbidbeli.Text = datatble1.Rows(0).Item(4)
        tbnamabrg.Text = datatble1.Rows(0).Item(6)
        Textbox2.Text = datatble1.Rows(0).Item(10)
        Textbox3.Text = datatble1.Rows(0).Item(8)
        totalbelitb.Text = datatble1.Rows(0).Item(11)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdkekurangan.CheckedChanged

    End Sub

    Private Sub btretur_Click(sender As Object, e As EventArgs) Handles btretur.Click
        Form16.ShowDialog()
    End Sub
End Class

