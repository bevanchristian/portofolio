Imports MySql.Data.MySqlClient
Public Class formpenjualan
    Dim connect As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public hitung2 As String
    Public counter As Integer
    Dim counter2 As Integer
    Dim counter3 As Integer
    Public SIU As String
    Public j As Integer
    Public c As Integer
    Public simpanbelom As Integer
    Private Sub bttutupbrg_Click(sender As Object, e As EventArgs) Handles bttutupjual.Click
        If simpanbelom = 0 And c > 0 Then
            MsgBox("tekan simpan dulu")
        Else

            j = 0
            Dim tutup As String
            tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If tutup = DialogResult.Yes Then
                Me.Close()
            End If
        End If

    End Sub
    Private Sub btretur_Click(sender As Object, e As EventArgs) Handles btretur.Click
        formreturjual.Show()
    End Sub
    Private Sub formpenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btsimpan.Enabled = False
            bttambahjual.Enabled = False
            bthapusjual.Enabled = False
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btsimpan.Enabled = True
            bttambahjual.Enabled = True
            bthapusjual.Enabled = True
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btsimpan.Enabled = False
            bttambahjual.Enabled = False
            bthapusjual.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btsimpan.Enabled = False
            bttambahjual.Enabled = False
            bthapusjual.Enabled = False
        End If
        j = 1
        GridControl1.Show()
        GridControl2.Hide()
        'Dim command As New MySqlCommand("select t.no_pajak,tgl_penjualan,total_penjual,id_dpenjualan,id_barang,nama_barang,harga_jual,diskon,no_batch,expire_date,id_customer from t_penjualan t left join tdetail_penjualan s on t.no_pajak=s.no_pajak;", connect)
        'Dim adapter As New MySqlDataAdapter(command)
        'Dim datatble1 As New DataTable
        'datatble1.Clear()
        'adapter.Fill(datatble1)
        'dgvbarang.DataSource = datatble

    End Sub

    Private Sub dgvbarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellClick
        'Dim command2 As New MySqlCommand("select t.no_pajak,tgl_penjualan,total_penjual,id_dpenjualan,id_barang,nama_barang,harga_jual,diskon,no_batch,expire_date,id_customer from t_penjualan t left join tdetail_penjualan s on t.no_pajak=s.no_pajak where t.no_pajak='" + dgvbarang.Item(0, dgvbarang.CurrentRow.Index).Value.ToString + "'", connect)
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
    End Sub

    Private Sub bttambahbeli_Click(sender As Object, e As EventArgs) Handles bttambahjual.Click

        If tbtotaljual.Text <> "" And tbdisc.Text <> "" And tbbeli.Text <> "" And tbjual.Text <> "" And tbidcust.Text <> "" Then
            simpanbelom = 0
            c = c + 1
            counter2 = counter2 + tbtotjual.Text

            Dim hitung As Integer
            hitung = 0
            Dim simpan2 As String
            Dim command As New MySqlCommand("SELECT * FROM tdetail_penjualan ", connect)

            Dim adapter As New MySqlDataAdapter(command)
            Dim datatble1 As New DataTable
            adapter.Fill(datatble1)
            hitung = datatble1.Rows.Count() + 1
            If hitung < 10 Then
                simpan2 = "PJ00" + hitung.ToString
                tbidjual.Text = simpan2
            ElseIf hitung >= 10 And hitung <= 99 Then
                simpan2 = "PJ0" + hitung.ToString
                tbidjual.Text = simpan2
            End If
            Try
                connect.Open()
                Dim command2 As New MySqlCommand("insert into tdetail_penjualan values ('" + tbidjual.Text + "','" + tbpajakjual.Text + "','" + tbjual.Text + "','" + tbnamabrg.Text + "','" + tbbeli.Text + "','" + tbdisc.Text + "','" + TextBox1.Text + "','" + texbox3.Text + "','" + tbtotaljual.Text + "')", connect)
                command2.ExecuteNonQuery()
                MsgBox("sudah di masukan tdetailpenjualan")
                connect.Close()



                Dim command44 As New MySqlCommand("select sum(stok_keluar+'" + tbtotaljual.Text + "') from stok_barang where id_barang='" + tbjual.Text + "'", connect)
                Dim adapter44 As New MySqlDataAdapter(command44)
                Dim datatble44 As New DataTable
                datatble44.Clear()
                adapter44.Fill(datatble44)
                SIU = datatble44.Rows(0).Item(0).ToString


                Dim command4 As New MySqlCommand("select id_dpenjualan,id_barang,nama_barang,harga_jual,diskon,no_batch,expire_date,total_jual from  tdetail_penjualan T where t.no_pajak='" + tbpajakjual.Text + "'", connect)
                Dim adapter4 As New MySqlDataAdapter(command4)
                Dim datatble4 As New DataTable
                datatble4.Clear()
                adapter4.Fill(datatble4)
                GridControl1.Show()
                GridControl2.Hide()
                GridControl1.DataSource = datatble4
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try


            Try
                connect.Open()
                Dim command2 As New MySqlCommand("update stok_barang set stok_keluar='" + SIU + "' where id_barang='" + tbjual.Text + "'", connect)
                command2.ExecuteNonQuery()
                'MsgBox("sudah di masukan 2")
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try

            Dim ss As String
            Dim command442 As New MySqlCommand("select sum(stok_masuk-stok_keluar) from stok_barang where id_barang='" + tbjual.Text + "'", connect)
            Dim adapter442 As New MySqlDataAdapter(command442)
            Dim datatble442 As New DataTable
            datatble442.Clear()
            adapter442.Fill(datatble442)
            ss = datatble442.Rows(0).Item(0).ToString

            Try
                connect.Open()
                Dim command22 As New MySqlCommand("update stok_barang set stok_akhir='" + ss + "' where id_barang='" + tbjual.Text + "'", connect)
                command22.ExecuteNonQuery()
                MsgBox("sudah di update data stok akhir")
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try

            Dim historyid As String
            Dim command5 As New MySqlCommand("SELECT * FROM HISTORY ", connect)
            Dim adapter5 As New MySqlDataAdapter(command5)
            Dim datatble15 As New DataTable
            adapter5.Fill(datatble15)
            hitung = datatble15.Rows.Count() + 1

            historyid = "H" + hitung.ToString
            'TextBox2.Text = hitung




            Try
                connect.Open()
                Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbjual.Text + "','" + tbnamabrg.Text + "','0','" + tbtotaljual.Text + "','" + tb_penjualan.Value.ToString("yyyyMMdd") + "','penjualan','penjualan')", connect)
                command2.ExecuteNonQuery()
                MsgBox("sudah di masukan 2")
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try




            'Try
            '    connect.Open()
            '    Dim command2 As New MySqlCommand("insert into t_penjualan values ('" + tbpajakjual.Text + "','" + tb_penjualan.Text + "','" + tbidcust.Text + "','" + tbtotjual.Text + "')", connect)
            '    command2.ExecuteNonQuery()
            '    MsgBox("sudah di masukan")
            '    connect.Close()
            '    formpenjualan_Load(sender, e)

            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    connect.Close()
            'End Try
            'Try
            '    connect.Open()
            '    Dim command2 As New MySqlCommand("insert into tdetail_penjualan values ('" + tbidjual.Text + "','" + tbpajakjual.Text + "','" + tbjual.Text + "','" + tbnamabrg.Text + "','" + tbbeli.Text + "','" + tbdisc.Text + "','" + TextBox1.Text + "','" + texbox3.Text + "')", connect)
            '    command2.ExecuteNonQuery()
            '    MsgBox("sudah di masukan 2")
            '    connect.Close()
            '    formpenjualan_Load(sender, e)
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    connect.Close()
            'End Try

        Else
            MsgBox("isi data dahulu")

        End If



    End Sub
    Private Sub tbidjual_Click(sender As Object, e As EventArgs) Handles tbidjual.Click

        Dim hitung As Integer
        hitung = 0
        Dim simpan2 As String
        Dim command As New MySqlCommand("SELECT * FROM tdetail_penjualan ", connect)

        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        adapter.Fill(datatble1)
        hitung = datatble1.Rows.Count() + 1
        If hitung < 10 Then
            simpan2 = "PJ00" + hitung.ToString
            tbidjual.Text = simpan2
        ElseIf hitung >= 10 And hitung <= 99 Then
            simpan2 = "PJ0" + hitung.ToString
            tbidjual.Text = simpan2
        End If
        'Dim hitung As Integer
        'hitung = 0
        'Dim simpan As String
        'Dim simpan2 As String
        'Dim command As New MySqlCommand("SELECT * FROM tdetail_penjualan t", connect)

        'Dim adapter As New MySqlDataAdapter(command)
        'Dim datatble1 As New DataTable
        'adapter.Fill(datatble1)
        'hitung = datatble1.Rows.Count() + 1
        'simpan = "Pj" + hitung.ToString
        'simpan2 = "F" + hitung.ToString
        'tbidjual.Text = simpan
        'tbpajakjual.Text = simpan2
    End Sub

    Private Sub bthapusjual_Click(sender As Object, e As EventArgs)
        'Try
        '    connect.Open()
        '    Dim command3 As New MySqlCommand("delete from  t_penjualan where no_pajak='" + tbpajakjual.Text + "'", connect)
        '    command3.ExecuteNonQuery()

        '    MsgBox("data sudah dihapus")
        '    connect.Close()
        '    formpenjualan_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    connect.Close()
        'End Try
        'Try
        '    connect.Open()
        '    Dim command3 As New MySqlCommand("delete from  tdetail_penjualan where id_dpembelian='" + tbidjual.Text + "'", connect)
        '    command3.ExecuteNonQuery()

        '    MsgBox("data sudah dihapus2")
        '    connect.Close()
        '    formpenjualan_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    connect.Close()
        'End Try
    End Sub

    Private Sub btubahjual_Click(sender As Object, e As EventArgs) Handles btubahjual.Click
        j = 0
        formubahpenjualan.ShowDialog()
        'Try
        '    connect.Open()
        '    Dim command4 As New MySqlCommand("update  t_penjualan set no_pajak='" + tbpajakjual.Text + "',tgl_penjualan='" + tb_penjualan.Text + "',id_customer='" + tbidcust.Text + "',total_penjual='" + tbtotjual.Text + "' where no_pajak='" + tbpajakjual.Text + "'", connect)
        '    command4.ExecuteNonQuery()
        '    MsgBox("data sudah diupdate")
        '    connect.Close()
        '    formpenjualan_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    connect.Close()
        'End Try
        'Try
        '    connect.Open()
        '    Dim command4 As New MySqlCommand("update  tdetail_penjualan set id_dpenjualan='" + tbidjual.Text + "',no_pajak='" + tbpajakjual.Text + "',id_barang='" + tbjual.Text + "',nama_barang='" + tbnamabrg.Text + "',harga_jual='" + tbbeli.Text + "',diskon='" + tbdisc.Text + "',no_batch='" + TextBox1.Text + "',expire_date='" + texbox3.Text + "' where id_dpenjualan='" + tbidjual.Text + "'", connect)
        '    command4.ExecuteNonQuery()
        '    MsgBox("data sudah diupdate 2")
        '    connect.Close()
        '    formpenjualan_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    connect.Close()
        'End Try
    End Sub
    Private Sub btlihatbrg_Click(sender As Object, e As EventArgs) Handles btlihatbrg.Click
        formbarang.Show()
    End Sub

    Private Sub lbtgljual_Click(sender As Object, e As EventArgs) Handles lbtgljual.Click

    End Sub

    Private Sub tbpajakjual_TextChanged(sender As Object, e As EventArgs) Handles tbpajakjual.TextChanged

    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If c = 0 Then
            MsgBox("isi data dulu")
        Else
            c = 0
            hitung2 = 0

            Try
                connect.Open()
                Dim command2 As New MySqlCommand("insert into t_penjualan values ('" + tbpajakjual.Text + "','" + tb_penjualan.Value.ToString("yyyyMMdd") + "','" + tbidcust.Text + "','" + counter2.ToString + "','0')", connect)
                command2.ExecuteNonQuery()
                MsgBox("sudah di masukan")
                connect.Close()
                'formpembelian_Load(sender, e)

            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
            counter2 = 0

            Dim command As New MySqlCommand("select no_pajak,tgl_penjualan,id_customer,total_penjual,`delete` from t_penjualan where no_pajak='" + tbpajakjual.Text + "'", connect)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatble1 As New DataTable
            datatble1.Clear()
            adapter.Fill(datatble1)
            GridControl1.Hide()

            GridControl2.DataSource = datatble1

            GridControl2.Show()


            Dim hitung As Integer
            hitung = 0
            Dim simpan2 As String
            Dim command4 As New MySqlCommand("SELECT no_pajak FROM t_penjualan t", connect)

            Dim adapter4 As New MySqlDataAdapter(command4)
            Dim datatble4 As New DataTable
            adapter4.Fill(datatble4)
            hitung = datatble4.Rows.Count() + 1
            simpan2 = "NP" + hitung.ToString
            tbpajakjual.Text = simpan2
            simpanbelom = 1
        End If
    End Sub

    Private Sub tbidjual_TextChanged(sender As Object, e As EventArgs) Handles tbidjual.TextChanged

    End Sub

    Private Sub tbpajakjual_Click(sender As Object, e As EventArgs) Handles tbpajakjual.Click
        Dim hitung As Integer
        hitung = 0
        Dim simpan2 As String
        Dim command4 As New MySqlCommand("SELECT no_pajak FROM t_penjualan t", connect)

        Dim adapter4 As New MySqlDataAdapter(command4)
        Dim datatble4 As New DataTable
        adapter4.Fill(datatble4)
        hitung = datatble4.Rows.Count() + 1
        simpan2 = "NP" + hitung.ToString
        tbpajakjual.Text = simpan2
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

    Private Sub dgvbarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellContentClick

    End Sub

    Private Sub btcust_Click(sender As Object, e As EventArgs) Handles btcust.Click
        Formcustomer.ShowDialog()
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

    Private Sub btlaporan_Click(sender As Object, e As EventArgs) Handles btlaporan.Click
        Formreportpenjualan.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub tbbeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbbeli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbtotaljual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbtotaljual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class


