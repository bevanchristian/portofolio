Imports MySql.Data.MySqlClient
Public Class formpenerimaan
    Dim con As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya")
    Public id As String
    Public saveidpenerimaan As String
    Public c As Integer
    Public simpanbelom As Integer
    Private Sub formpenerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If formlogin.tbuser.Text = "direktur" Then
            btsimpanterima.Enabled = False
            bttambahterima.Enabled = False
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btsimpanterima.Enabled = False
            bttambahterima.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btsimpanterima.Enabled = True
            bttambahterima.Enabled = True
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btsimpanterima.Enabled = False
            bttambahterima.Enabled = False
        End If
        Dim com1 As New MySqlCommand("select no_faktur from t_pembelian where `delete`='0' and selesai='0' UNION SELECT ID_RETUR_PENJUALAN FROM RETUR_PENJUALAN where `delete`='0' and selesai='0';", con)
        Dim adapt1 As New MySqlDataAdapter(com1)
        Dim dtfaktur As New DataTable
        adapt1.Fill(dtfaktur)
        cbnofakturterima.DataSource = dtfaktur
        cbnofakturterima.ValueMember = "no_faktur"
        cbnofakturterima.DisplayMember = "no_faktur"
        Dim hitung As Integer = 0
        Dim saveiddpenerimaan As String
        Dim commdp As New MySqlCommand("SELECT * FROM detail_penerimaan;", con)
        Dim adaptdp As New MySqlDataAdapter(commdp)
        Dim dtdp As New DataTable
        adaptdp.Fill(dtdp)
        hitung = dtdp.Rows.Count() + 1
        saveiddpenerimaan = "DP" + hitung.ToString
        tbiddterima.Text = saveiddpenerimaan
    End Sub
    Private Sub cbnofakturterima_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnofakturterima.SelectedIndexChanged
        Try
            Dim com As New MySqlCommand("select no_faktur, id_barang, nama_barang, harga_beli, diskon, no_batch,expire_date,total_beli from tdetail_pembelian where no_faktur='" + cbnofakturterima.SelectedValue.ToString + "'UNION SELECT ID_RETUR_PENJUALAN,ID_BARANG,NAMA_BARANG,ID_CUSTOMER,'',ID_DPENJUALAN,'',JUMLAH FROM RETUR_DPENJUALAN where id_retur_penjualan='" + cbnofakturterima.SelectedValue.ToString + "';", con)
            Dim adaptno As New MySqlDataAdapter(com)
            Dim dtfaktur As New DataTable
            adaptno.Fill(dtfaktur)
            'cbnofaktur.DataSource = dtfaktur
            'cbnofaktur.ValueMember = "no_faktur"
            'cbnofaktur.DisplayMember = "no_faktur"
            GridControl1.DataSource = dtfaktur
            GridView1.PopulateColumns()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim count As Integer = 0
        Dim saveidpenerimaan As String
        Dim comm As New MySqlCommand("SELECT * FROM penerimaan p;", con)
        Dim adapt As New MySqlDataAdapter(comm)
        Dim dt As New DataTable
        adapt.Fill(dt)
        count = dt.Rows.Count() + 1
        saveidpenerimaan = "P" + count.ToString
        tbidterima.Text = saveidpenerimaan
    End Sub
    Private Sub btutupterima_Click(sender As Object, e As EventArgs) Handles bttutupterima.Click
        If simpanbelom = 0 And c > 0 Then
            MsgBox("tekan simpan dulu")
        Else
            Dim tutup As String
            tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If tutup = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub dgvterima_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvterima.CellClick
        Dim hitung As Integer = 0
        Dim saveiddpenerimaan As String
        Dim commdp As New MySqlCommand("SELECT * FROM detail_penerimaan;", con)
        Dim adaptdp As New MySqlDataAdapter(commdp)
        Dim dtdp As New DataTable
        adaptdp.Fill(dtdp)
        hitung = dtdp.Rows.Count() + 1
        saveiddpenerimaan = "DP" + hitung.ToString
        tbiddterima.Text = saveiddpenerimaan
        Dim command As New MySqlCommand("select no_faktur, id_barang, nama_barang, harga_beli, no_batch,total_beli from tdetail_pembelian where nama_barang='" + dgvterima.Item(2, dgvterima.CurrentRow.Index).Value.ToString + "'UNION SELECT ID_RETUR_PENJUALAN,ID_BARANG,NAMA_BARANG,ID_CUSTOMER,ID_DPENJUALAN,JUMLAH FROM RETUR_DPENJUALAN where nama_barang='" + dgvterima.Item(2, dgvterima.CurrentRow.Index).Value.ToString + "';", con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim dt2 As New DataTable
        dt2.Clear()
        adapter.Fill(dt2)
        tbidbrgterima.Text = dt2.Rows(0).Item(1).ToString
        tbnamabrgterima.Text = dt2.Rows(0).Item(2).ToString

        'Dim com1 As New MySqlCommand("select id_penerimaan,tgl_penerimaan, no_faktur from penerimaan where id_penerimaan='" + dgvterima.Item(0, dgvterima.CurrentRow.Index).Value.ToString + "'and no_faktur='" + dgvterima.Item(2, dgvterima.CurrentRow.Index).Value.ToString + "';", con)
        'Dim adapt1 As New MySqlDataAdapter(com1)
        'Dim dt1 As New DataTable
        'adapt1.Fill(dt1)
        ''dtpubahterima.Text = dt1.Rows(0).Item(1).ToString
        'tbiddterima.Text = dt1.Rows(0).Item(2).ToString
        'tbiddterima.Text = dt1.Rows(0).Item(2).ToString
    End Sub
    Private Sub btsimpanterima_Click(sender As Object, e As EventArgs) Handles btsimpanterima.Click
        If c = 0 Then
            MsgBox("isi data dulu")
        Else
            c = 0

            Dim count As Integer = 0
            Dim comm As New MySqlCommand("SELECT * FROM penerimaan p;", con)
            Dim adapt As New MySqlDataAdapter(comm)
            Dim dt As New DataTable
            adapt.Fill(dt)
            count = dt.Rows.Count() + 1
            saveidpenerimaan = "P" + count.ToString
            tbidterima.Text = saveidpenerimaan
            Try
                con.Open()
                Dim command3 As New MySqlCommand("insert into penerimaan values('" + tbidterima.Text + "','" + dtpterima.Value.ToString("yyyyMMdd") + "','" + cbnofakturterima.SelectedValue.ToString + "','0')", con)
                command3.ExecuteNonQuery()
                con.Close()
                'MsgBox("data sudah masuk")
                'formpenerimaan_Load(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
            Try
                con.Open()
                Dim command3 As New MySqlCommand("update t_pembelian set selesai='1' where no_faktur='" + cbnofakturterima.Text + "'", con)
                command3.ExecuteNonQuery()
                con.Close()
                MsgBox("data sudah diupdate selesai")
                formpenerimaan_Load(sender, e)
            Catch ex As Exception

            End Try
            Try
                con.Open()
                Dim command3 As New MySqlCommand("update retur_penjualan set selesai='1' where id_retur_penjualan='" + cbnofakturterima.Text + "'", con)
                command3.ExecuteNonQuery()
                con.Close()
                MsgBox("data sudah diupdate selesai")
                formpenerimaan_Load(sender, e)
            Catch ex As Exception

            End Try
            Dim com1 As New MySqlCommand("select * from penerimaan;", con)
            Dim adapt1 As New MySqlDataAdapter(com1)
            Dim dtfaktur As New DataTable
            adapt1.Fill(dtfaktur)
            GridControl1.DataSource = dtfaktur
            GridView1.PopulateColumns()
            simpanbelom = 1
        End If
    End Sub

    Private Sub cbnofakturterima_Click(sender As Object, e As EventArgs) Handles cbnofakturterima.Click
        Dim com1 As New MySqlCommand("select no_faktur from t_pembelian where `delete`='0' and selesai='0' UNION SELECT ID_RETUR_PENJUALAN FROM RETUR_PENJUALAN where `delete`='0' and selesai='0';", con)
        Dim adapt1 As New MySqlDataAdapter(com1)
        Dim dtfaktur As New DataTable
        adapt1.Fill(dtfaktur)
        cbnofakturterima.DataSource = dtfaktur
        cbnofakturterima.ValueMember = "no_faktur"
        cbnofakturterima.DisplayMember = "no_faktur"
    End Sub
    Private Sub btstokterima_Click(sender As Object, e As EventArgs) Handles btstokterima.Click
        Formstok.Show()
    End Sub

    Private Sub btubahterima_Click(sender As Object, e As EventArgs) Handles btubahterima.Click
        formubahpenerimaan.Show()
    End Sub
    Private Sub bttambahterima_Click(sender As Object, e As EventArgs) Handles bttambahterima.Click
        If tbidbrgterima.Text <> "" And tbiddterima.Text <> "" And tbidterima.Text <> "" And tbjumlahterima.Text <> "" And tbnamabrgterima.Text <> "" Then
            simpanbelom = 0
            c = c + 1
            Dim hitung As Integer = 0
            Dim saveiddpenerimaan As String
            Dim commdp As New MySqlCommand("SELECT * FROM detail_penerimaan;", con)
            Dim adaptdp As New MySqlDataAdapter(commdp)
            Dim dtdp As New DataTable
            adaptdp.Fill(dtdp)
            hitung = dtdp.Rows.Count() + 1
            saveiddpenerimaan = "DP" + hitung.ToString
            tbiddterima.Text = saveiddpenerimaan
            Try
                con.Open()
                Dim command2 As New MySqlCommand("insert into detail_penerimaan(id_dpenerimaan,id_penerimaan,id_barang,nama_barang,jumlah) values('" + tbiddterima.Text + "','" + tbidterima.Text + "','" + tbidbrgterima.Text + "','" + tbnamabrgterima.Text + "','" + tbjumlahterima.Text + "')", con)
                command2.ExecuteNonQuery()
                MsgBox("data sudah masuk")
                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        Else
            MsgBox("isi dahulu data")
        End If

    End Sub
    Private Sub bthistorypenerimaan_Click(sender As Object, e As EventArgs) Handles bthistorypenerimaan.Click
        formhistorypenerimaan.Show()
    End Sub


    Private Sub btlaporan_Click(sender As Object, e As EventArgs) Handles btlaporan.Click
        Formreportpenerimaanvb.ShowDialog()
    End Sub

    Private Sub dgvterima_CellBorderStyleChanged(sender As Object, e As EventArgs) Handles dgvterima.CellBorderStyleChanged

    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Dim hitung As Integer = 0
        Dim saveiddpenerimaan As String
        Dim commdp As New MySqlCommand("SELECT * FROM detail_penerimaan;", con)
        Dim adaptdp As New MySqlDataAdapter(commdp)
        Dim dtdp As New DataTable
        adaptdp.Fill(dtdp)
        hitung = dtdp.Rows.Count() + 1
        saveiddpenerimaan = "DP" + hitung.ToString
        tbiddterima.Text = saveiddpenerimaan
        Try
            Dim command As New MySqlCommand("select no_faktur, id_barang, nama_barang, harga_beli, no_batch,total_beli from tdetail_pembelian where nama_barang='" + GridView1.GetFocusedDataRow(2).ToString + "'UNION SELECT ID_RETUR_PENJUALAN,ID_BARANG,NAMA_BARANG,ID_CUSTOMER,ID_DPENJUALAN,JUMLAH FROM RETUR_DPENJUALAN where nama_barang='" + GridView1.GetFocusedDataRow(2).ToString + "';", con)
            Dim adapter As New MySqlDataAdapter(command)
            Dim dt2 As New DataTable
            dt2.Clear()
            adapter.Fill(dt2)
            tbidbrgterima.Text = dt2.Rows(0).Item(1).ToString
            tbnamabrgterima.Text = dt2.Rows(0).Item(2).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub tbjumlahterima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbjumlahterima.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class

