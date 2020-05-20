Imports MySql.Data.MySqlClient

Public Class formubahpenjualan
    Dim connect As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public hitung2 As String
    Public counter3 As Integer
    Public simpan3 As String = 0
    Public SIU As String
    Public SIMPAN299 As String
    Public beli As String
    Public ju As Integer
    Public counter As Integer
    Public c As Integer
    Dim simpanbelom As Integer
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btsimpan.Enabled = False
            bthapusjual.Enabled = False
            btubahjual.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btsimpan.Enabled = False
            bthapusjual.Enabled = False
            btubahjual.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btsimpan.Enabled = False
            bthapusjual.Enabled = False
            btubahjual.Enabled = False
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btsimpan.Enabled = True
            bthapusjual.Enabled = True
            btubahjual.Enabled = True
        End If
        ju = 1
        Dim command2 As New MySqlCommand("select no_pajak from t_penjualan where `delete`=0", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim datatble2 As New DataTable
        datatble2.Clear()
        adapter2.Fill(datatble2)
        ComboBox1.DataSource = datatble2
        ComboBox1.DisplayMember = "no_pajak"
        ComboBox1.ValueMember = "no_pajak"

        'Dim command As New MySqlCommand("select t.no_faktur,tgl_pembelian,id_supplier,total_pembelian,id_dpembelian,id_barang,nama_barang,harga_beli,diskon,no_batch,expire_date,total_beli from t_pembelian t left join tdetail_pembelian s on t.no_faktur=s.no_faktur where t.no_faktur='" + ComboBox1.SelectedValue + "';", connect)
        'Dim adapter As New MySqlDataAdapter(command)
        'Dim datatble1 As New DataTable
        'datatble1.Clear()
        'adapter.Fill(datatble1)
        'dgvbarang.DataSource = datatble1

        'Dim command As New MySqlCommand("select t.no_pajak,tgl_penjualan,total_penjual,id_dpenjualan,id_barang,nama_barang,harga_jual,diskon,no_batch,expire_date,id_customer from t_penjualan t left join tdetail_penjualan s on t.no_pajak=s.no_pajak where t.no_pajak='" + ComboBox1.SelectedValue + "';", connect)
        'Dim adapter As New MySqlDataAdapter(command)
        'Dim datatble1 As New DataTable
        'datatble1.Clear()
        'adapter.Fill(datatble1)
        'dgvbarang.DataSource = datatble1

        Dim hitung As Integer = 0
        Dim command6 As New MySqlCommand("SELECT * FROM t_penjualan t", connect)

        Dim adapter6 As New MySqlDataAdapter(command6)
        Dim datatble6 As New DataTable
        adapter6.Fill(datatble6)

        hitung = datatble6.Rows.Count() + 1
        simpan3 = "NPU" + hitung.ToString
        tbpajakjual.Text = simpan3
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim command As New MySqlCommand("select t.no_pajak,tgl_penjualan,total_penjual,id_dpenjualan,id_barang,nama_barang,harga_jual,diskon,no_batch,expire_date,id_customer from t_penjualan t left join tdetail_penjualan s on t.no_pajak=s.no_pajak where s.no_pajak='" + ComboBox1.SelectedValue.ToString + "'and `delete`=0", connect)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        datatble1.Clear()
        adapter.Fill(datatble1)
        GridControl1.DataSource = datatble1
        GridView1.PopulateColumns()
    End Sub

    Private Sub dgvbarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellContentClick
        'Dim command2 As New MySqlCommand("select t.no_pajak,tgl_penjualan,total_penjual,id_dpenjualan,id_barang,nama_barang,harga_jual,diskon,no_batch,expire_date,id_customer,total_jual from t_penjualan t left join tdetail_penjualan s on t.no_pajak=s.no_pajak where s.id_dpenjualan='" + dgvbarang.Item(3, dgvbarang.CurrentRow.Index).Value.ToString + "'", connect)
        'Dim adapter2 As New MySqlDataAdapter(command2)
        'Dim datatble1 As New DataTable
        'adapter2.Fill(datatble1)

        'tbpajakjual.Text = datatble1.Rows(0).Item(0)
        'tbtotjual.Text = datatble1.Rows(0).Item(2)
        'tbidjual.Text = datatble1.Rows(0).Item(3)
        'tb_penjualan.Text = datatble1.Rows(0).Item(1)
        'tbidcust.Text = datatble1.Rows(0).Item(10)
        'tbjual.Text = datatble1.Rows(0).Item(4)
        'tbnamabrg.Text = datatble1.Rows(0).Item(5)
        'TextBox1.Text = datatble1.Rows(0).Item(8)
        'texbox3.Text = datatble1.Rows(0).Item(9)
        'tbbeli.Text = datatble1.Rows(0).Item(6)
        'tbdisc.Text = datatble1.Rows(0).Item(7)
        'tbtotaljual.Text = datatble1.Rows(0).Item(11)
    End Sub

    Private Sub btlihatbrg_Click(sender As Object, e As EventArgs) Handles btlihatbrg.Click
        formbarang.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Formcustomer.ShowDialog()
    End Sub

    Private Sub btubahjual_Click(sender As Object, e As EventArgs) Handles btubahjual.Click
        ju = 0
        If tbtotaljual.Text <> "" And tbidcust.Text <> "" And tbtotjual.Text <> "" And tbjual.Text <> "" And tbidjual.Text <> "" And tb_penjualan.Text <> "" And tbdisc.Text <> "" And tbnamabrg.Text <> "" And tbidcust.Text <> "" Then
            c = c + 1
            simpanbelom = 0
            'Dim hitung As Integer
            'hitung = 0
            'Dim SIMPAN2 As String = 0
            'Dim command8 As New MySqlCommand("SELECT * FROM tdetail_penjualan ", connect)
            'Dim adapter8 As New MySqlDataAdapter(command8)
            'Dim datatble8 As New DataTable
            'adapter8.Fill(datatble8)
            'hitung = datatble8.Rows.Count() + 1
            'If hitung < 10 Then
            '    SIMPAN2 = "PJU00" + hitung.ToString

            'ElseIf hitung >= 10 And hitung <= 99 Then
            '    SIMPAN2 = "PJU0" + hitung.ToString
            'End If
            'Try
            '    connect.Open()
            '    Dim command24 As New MySqlCommand("insert into tdetail_penjualan values ('" + SIMPAN2 + "','" + simpan3 + "','" + tbjual.Text + "','" + tbnamabrg.Text + "','" + tbbeli.Text + "','" + tbdisc.Text + "','" + TextBox1.Text + "','" + texbox3.Text + "','" + tbtotaljual.Text + "')", connect)
            '    command24.ExecuteNonQuery()
            '    MsgBox("sudah di masukan ubahan ke tdetail")
            '    connect.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    connect.Close()
            'End Try


            'Dim command44 As New MySqlCommand("select sum(stok_keluar+'" + tbtotaljual.Text + "') from stok_barang where id_barang='" + tbjual.Text + "'", connect)
            'Dim adapter44 As New MySqlDataAdapter(command44)
            'Dim datatble44 As New DataTable
            'datatble44.Clear()
            'adapter44.Fill(datatble44)
            'SIU = datatble44.Rows(0).Item(0).ToString

            'Try
            '    connect.Open()
            '    Dim command2 As New MySqlCommand("update stok_barang set stok_keluar='" + SIU + "' where id_barang='" + tbjual.Text + "'", connect)
            '    command2.ExecuteNonQuery()
            '    MsgBox("sudah di masukan 2")
            '    connect.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    connect.Close()
            'End Try

            'If RadioButton1.Checked = True Then
            counter = counter + tbtotjual.Text
            Dim hitung As Integer
            Dim historyid As String
            Dim command5 As New MySqlCommand("SELECT * FROM HISTORY ", connect)
            Dim adapter5 As New MySqlDataAdapter(command5)
            Dim datatble15 As New DataTable
            adapter5.Fill(datatble15)
            hitung = datatble15.Rows.Count() + 1
            historyid = "H" + hitung.ToString

            Dim hitung2 As Integer
            hitung2 = 0
            Dim SIMPAN2 As String = 0
            Dim command8 As New MySqlCommand("SELECT * FROM tdetail_penjualan ", connect)
            Dim adapter8 As New MySqlDataAdapter(command8)
            Dim datatble8 As New DataTable
            adapter8.Fill(datatble8)
            hitung2 = datatble8.Rows.Count() + 1
            If hitung2 < 10 Then
                SIMPAN2 = "PJU00" + hitung2.ToString

            ElseIf hitung2 >= 10 And hitung2 <= 99 Then
                SIMPAN2 = "PJU0" + hitung2.ToString
            End If
            Try
                connect.Open()
                Dim command24 As New MySqlCommand("insert into tdetail_penjualan values ('" + SIMPAN2 + "','" + simpan3 + "','" + tbjual.Text + "','" + tbnamabrg.Text + "','" + tbbeli.Text + "','" + tbdisc.Text + "','" + TextBox1.Text + "','" + texbox3.Text + "','" + tbtotaljual.Text + "')", connect)
                command24.ExecuteNonQuery()
                MsgBox("sudah di masukan ubahan ke tdetail")
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
            Dim command44 As New MySqlCommand("select sum(stok_keluar+'" + tbtotaljual.Text + "') from stok_barang where id_barang='" + tbjual.Text + "'", connect)
            Dim adapter44 As New MySqlDataAdapter(command44)
            Dim datatble44 As New DataTable
            datatble44.Clear()
            adapter44.Fill(datatble44)
            SIU = datatble44.Rows(0).Item(0).ToString
            Try
                connect.Open()
                Dim command2 As New MySqlCommand("update stok_barang set stok_keluar='" + SIU + "' where id_barang='" + tbjual.Text + "'", connect)
                command2.ExecuteNonQuery()
                MsgBox("sudah di masukan 2")
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
            Dim ahkhir As String
            Dim command6 As New MySqlCommand("select sum(stok_masuk-stok_keluar) from stok_barang where id_barang='" + tbjual.Text + "'", connect)
            Dim adapter6 As New MySqlDataAdapter(command6)
            Dim datatble6 As New DataTable
            datatble6.Clear()
            adapter6.Fill(datatble6)
            ahkhir = ""
            ahkhir = datatble6.Rows(0).Item(0).ToString
            connect.Open()
            Dim command25 As New MySqlCommand("update stok_barang set stok_akhir='" + ahkhir + "' where id_barang='" + tbjual.Text + "'", connect)
            command25.ExecuteNonQuery()
            MsgBox("sudah di update stok akhirnya")
            connect.Close()

            Try
                connect.Open()
                Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbjual.Text + "','" + tbnamabrg.Text + "','0','" + tbtotaljual.Text + "','" + tb_penjualan.Value.ToString("yyyyMMdd") + "','penjualan','kelebihan barang')", connect)
                command2.ExecuteNonQuery()
                MsgBox("sudah di masukan 2")
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try




            'ElseIf RadioButton2.Checked = True Then
            '    counter = counter + tbtotjual.Text
            '    Dim hitung As Integer
            '    Dim historyid As String
            '    Dim command5 As New MySqlCommand("SELECT * FROM HISTORY ", connect)
            '    Dim adapter5 As New MySqlDataAdapter(command5)
            '    Dim datatble15 As New DataTable
            '    adapter5.Fill(datatble15)
            '    hitung = datatble15.Rows.Count() + 1
            '    historyid = "H" + hitung.ToString


            '    counter = counter + tbtotjual.Text
            '    Dim hitung2 As Integer
            '    hitung2 = 0

            '    Dim command8 As New MySqlCommand("SELECT * FROM tdetail_pembelian ", connect)
            '    Dim adapter8 As New MySqlDataAdapter(command8)
            '    Dim datatble8 As New DataTable
            '    adapter8.Fill(datatble8)
            '    hitung2 = datatble8.Rows.Count() + 1
            '    SIMPAN299 = ""
            '    If hitung2 < 10 Then
            '        SIMPAN299 = "PBU00" + hitung2.ToString

            '    ElseIf hitung2 >= 10 And hitung2 <= 99 Then
            '        SIMPAN299 = "PBU0" + hitung2.ToString
            '    End If
            '    Try

            '        Dim hitung4 As Integer = 0
            '        Dim command6 As New MySqlCommand("SELECT * FROM t_pembelian t", connect)
            '        Dim adapter6 As New MySqlDataAdapter(command6)
            '        Dim datatble6 As New DataTable
            '        beli = ""
            '        adapter6.Fill(datatble6)
            '        hitung4 = datatble6.Rows.Count() + 1
            '        beli = "FU" + hitung4.ToString

            '        connect.Open()
            '        Dim command24 As New MySqlCommand("insert into tdetail_PEMBELIAN values ('" + SIMPAN299 + "','" + beli + "','" + tbjual.Text + "','" + tbnamabrg.Text + "','" + tbbeli.Text + "','" + tbdisc.Text + "','" + TextBox1.Text + "','" + texbox3.Text + "','" + tbtotaljual.Text + "')", connect)
            '        command24.ExecuteNonQuery()
            '        MsgBox("sudah di masukan ubahan ke tdetailpembelian")
            '        connect.Close()
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        connect.Close()
            '    End Try

            '    Try
            '        connect.Open()
            '        Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbjual.Text + "','" + tbnamabrg.Text + "','" + tbtotaljual.Text + "','0','" + tb_penjualan.Value.ToString("yyyyMMdd") + "','penjualan','kekurangan barang')", connect)
            '        command2.ExecuteNonQuery()
            '        MsgBox("sudah di masukan 2")
            '        connect.Close()
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        connect.Close()
            '    End Try


            'End If

            'Dim command44 As New MySqlCommand("select sum(stok_masuk+'" + tbtotaljual.Text + "') from stok_barang where id_barang='" + tbjual.Text + "'", connect)
            'Dim adapter44 As New MySqlDataAdapter(command44)
            'Dim datatble44 As New DataTable
            'datatble44.Clear()
            'adapter44.Fill(datatble44)
            'SIU = datatble44.Rows(0).Item(0).ToString
            'Try
            '    connect.Open()
            '    Dim command2 As New MySqlCommand("update stok_barang set stok_masuk='" + SIU + "' where id_barang='" + tbjual.Text + "'", connect)
            '    command2.ExecuteNonQuery()
            '    MsgBox("sudah di masukan 2")
            '    connect.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    connect.Close()
            'End Try

            'Try
            '    connect.Open()
            '    Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbjual.Text + "','" + tbnamabrg.Text + "','" + tbtotaljual.Text + "','0','" + tb_penjualan.Value.ToString("yyyyMMdd") + "','penjualan','kekurangan')", connect)
            '    command2.ExecuteNonQuery()
            '    MsgBox("sudah di masukan 2")
            '    connect.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    connect.Close()
            'End Try

            'Try
            '    connect.Open()
            '    Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbjual.Text + "','" + tbnamabrg.Text + "','0','" + tbtotaljual.Text + "','" + tb_penjualan.Value.ToString("yyyyMMdd") + "','penjualan','penjualan')", connect)
            '    command2.ExecuteNonQuery()
            '    MsgBox("sudah di masukan 2")
            '    connect.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    connect.Close()
            'End Try


            'Dim command2 As New MySqlCommand("select_", connect)
            'Dim adapter2 As New MySqlDataAdapter(command2)
            'Dim datatble2 As New DataTable
            'datatble2.Clear()
            'adapter2.Fill(datatble2)
        Else
            MsgBox("isi data dahulu")
        End If
    End Sub

    Private Sub bthapusjual_Click(sender As Object, e As EventArgs) Handles bthapusjual.Click
        Try
            connect.Open()
            Dim command3 As New MySqlCommand("update t_penjualan set `delete`=1 where no_pajak='" + ComboBox1.SelectedValue + "'", connect)
            command3.ExecuteNonQuery()
            MsgBox("sudah di hapus logical satu faktur")
            connect.Close()
            Dim command2 As New MySqlCommand("select no_pajak from t_penjualan where `delete`=0", connect)
            Dim adapter2 As New MySqlDataAdapter(command2)
            Dim datatble2 As New DataTable
            datatble2.Clear()
            adapter2.Fill(datatble2)
            ComboBox1.DataSource = datatble2
            ComboBox1.DisplayMember = "no_pajak"
            ComboBox1.ValueMember = "no_pajak"
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If c = 0 Then
            MsgBox("isi data dulu")
        Else
            c = 0
            simpanbelom = 1
            'If RadioButton1.Checked = True Then
            Dim total As String
            Dim command10 As New MySqlCommand("select sum(harga_jual * total_jual) from tdetail_penjualan where no_pajak='" + simpan3 + "'", connect)
            Dim adapter10 As New MySqlDataAdapter(command10)
            Dim datatble10 As New DataTable
            adapter10.Fill(datatble10)
            total = datatble10.Rows(0).Item(0)

            Try
                connect.Open()
                Dim command6 As New MySqlCommand("insert into t_penjualan values ('" + simpan3 + "','" + tb_penjualan.Value.ToString("yyyyMMdd") + "','" + tbidcust.Text + "','" + counter.ToString + "' ,'0')", connect)
                command6.ExecuteNonQuery()
                MsgBox("sudah di masukan ubahan")
                connect.Close()
                Dim command As New MySqlCommand("select t.no_pajak,tgl_penjualan,total_penjual,id_dpenjualan,id_barang,nama_barang,harga_jual,diskon,no_batch,expire_date,id_customer from t_penjualan t left join tdetail_penjualan s on t.no_pajak=s.no_pajak where t.no_pajak='" + simpan3 + "';", connect)
                Dim adapter As New MySqlDataAdapter(command)
                Dim datatble1 As New DataTable
                datatble1.Clear()
                adapter.Fill(datatble1)
                dgvbarang.DataSource = datatble1
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
            Dim command75 As New MySqlCommand("SELECT * FROM t_penjualan t where no_pajak='" + simpan3 + "'", connect)
            Dim adapter75 As New MySqlDataAdapter(command75)
            Dim datatble75 As New DataTable
            adapter75.Fill(datatble75)
            GridControl1.DataSource = datatble75
            GridView1.PopulateColumns()


            Dim hitung As Integer = 0
            Dim command7 As New MySqlCommand("SELECT * FROM t_penjualan t", connect)

            Dim adapter7 As New MySqlDataAdapter(command7)
            Dim datatble7 As New DataTable
            adapter7.Fill(datatble7)
            hitung = datatble7.Rows.Count() + 1
            simpan3 = "NPU" + hitung.ToString
            tbpajakjual.Text = simpan3
            counter = 0


            '    ElseIf RadioButton2.Checked = True Then
            '    Dim total As String
            '    Dim command10 As New MySqlCommand("select sum(harga_beli * total_beli) from tdetail_pembelian where no_faktur='" + beli + "'", connect)
            '    Dim adapter10 As New MySqlDataAdapter(command10)
            '    Dim datatble10 As New DataTable
            '    adapter10.Fill(datatble10)
            '    total = datatble10.Rows(0).Item(0)
            '    Try
            '        connect.Open()
            '        Dim command2 As New MySqlCommand("insert into t_pembelian values ('" + beli + "','" + tb_penjualan.Value.ToString("yyyyMMdd") + "','" + tbidcust.Text + "','" + counter.ToString + "','0')", connect)
            '        command2.ExecuteNonQuery()
            '        MsgBox("sudah di masukan ke tdetailpembelian")
            '        connect.Close()
            '        'formpembelian_Load(sender, e)
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        connect.Close()
            '    End Try
            '    Dim command75 As New MySqlCommand("SELECT * FROM t_pembelian t where no_faktur='" + beli + "'", connect)
            '    Dim adapter75 As New MySqlDataAdapter(command75)
            '    Dim datatble75 As New DataTable
            '    adapter75.Fill(datatble75)
            '    GridControl1.DataSource = datatble75
            '    GridView1.PopulateColumns()


            '    Dim hitung4 As Integer = 0
            '    Dim command6 As New MySqlCommand("SELECT * FROM t_pembelian t", connect)
            '    Dim adapter6 As New MySqlDataAdapter(command6)
            '    Dim datatble6 As New DataTable
            '    beli = ""
            '    adapter6.Fill(datatble6)
            '    hitung4 = datatble6.Rows.Count() + 1
            '    beli = "FU" + hitung4.ToString
            '    counter = 0
            'End If
        End If
    End Sub

    Private Sub tbtotaljual_TextChanged(sender As Object, e As EventArgs) Handles tbtotaljual.TextChanged
        Try
            Dim asa As String
            tbtotjual.Text = 0
            hitung2 = 0

            hitung2 = tbtotaljual.Text * tbbeli.Text
            tbtotjual.Text = hitung2.ToString
            counter3 = hitung2
            If tbdisc.Text <> "0" Then
                asa = tbtotaljual.Text * tbbeli.Text / tbdisc.Text
                hitung2 = (tbtotaljual.Text * tbbeli.Text) - asa.ToString
                tbtotjual.Text = hitung2.ToString
                'diskon ngitunge yak apa
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        lbidcust.Text = "SUPPLIER"
        lbnopajak.Text = "NO FAKTUR"
        lbtgljual.Text = "TGL PEMBELIAN"

    End Sub

    Private Sub lbidcust_Click(sender As Object, e As EventArgs) Handles lbidcust.Click

    End Sub

    Private Sub tbidjual_TextChanged(sender As Object, e As EventArgs) Handles tbidjual.TextChanged

    End Sub

    Private Sub tbpajakjual_TextChanged(sender As Object, e As EventArgs) Handles tbpajakjual.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        lbidcust.Text = "ID CUSTOMMER"
        lbnopajak.Text = "NO PAJAK"
        lbtgljual.Text = "TGL PENJUALAN"
    End Sub

    Private Sub btubahjual_Click_1(sender As Object, e As EventArgs) Handles btubahjual.Click

    End Sub

    Private Sub tbbeli_TextChanged(sender As Object, e As EventArgs) Handles tbbeli.TextChanged
        Try
            Dim asa As String
            tbtotjual.Text = 0
            hitung2 = 0

            hitung2 = tbtotaljual.Text * tbbeli.Text
            tbtotjual.Text = hitung2.ToString
            counter3 = hitung2
            If tbdisc.Text <> "0" Then
                asa = tbtotaljual.Text * tbbeli.Text / tbdisc.Text
                hitung2 = (tbtotaljual.Text * tbbeli.Text) - asa.ToString
                tbtotjual.Text = hitung2.ToString
                'diskon ngitunge yak apa
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btutupbeli_Click(sender As Object, e As EventArgs) Handles btutupbeli.Click
        If simpanbelom = 0 And c > 0 Then
            MsgBox("tekan simpan dulu")
        Else
            ju = 0
            Dim tutup As String
            tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If tutup = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Dim command2 As New MySqlCommand("select t.no_pajak,tgl_penjualan,total_penjual,id_dpenjualan,id_barang,nama_barang,harga_jual,diskon,no_batch,expire_date,id_customer,total_jual from t_penjualan t left join tdetail_penjualan s on t.no_pajak=s.no_pajak where s.id_dpenjualan='" + GridView1.GetFocusedDataRow(3).ToString + "'", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim datatble1 As New DataTable
        adapter2.Fill(datatble1)

        tbpajakjual.Text = datatble1.Rows(0).Item(0)
        tbtotjual.Text = datatble1.Rows(0).Item(2)
        tbidjual.Text = datatble1.Rows(0).Item(3)
        tb_penjualan.Text = datatble1.Rows(0).Item(1)
        tbidcust.Text = datatble1.Rows(0).Item(10)
        tbjual.Text = datatble1.Rows(0).Item(4)
        tbnamabrg.Text = datatble1.Rows(0).Item(5)
        TextBox1.Text = datatble1.Rows(0).Item(8)
        texbox3.Text = datatble1.Rows(0).Item(9)
        tbbeli.Text = datatble1.Rows(0).Item(6)
        tbdisc.Text = datatble1.Rows(0).Item(7)
        tbtotaljual.Text = datatble1.Rows(0).Item(11)
    End Sub

    Private Sub tbpajakjual_Click(sender As Object, e As EventArgs) Handles tbpajakjual.Click

    End Sub

    Private Sub btretur_Click(sender As Object, e As EventArgs) Handles btretur.Click
        Formubahreturpenjualan.ShowDialog()
    End Sub

    Private Sub tbbeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbbeli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbtotaljual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbtotaljual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
