Imports MySql.Data.MySqlClient
Public Class formreturjual
    Dim connect As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public tes As String
    Public GAERETUR As String
    Public s As Integer
    Public counter As Integer
    Public batas As Integer
    Dim c As Integer = 0
    Public simpanbelom As Integer
    Private Sub bttutupbrg_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub formreturjual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GridControl1.BackColor = Color.Black
        If formlogin.tbuser.Text = "direktur" Then
            bthapusrj.Enabled = False
            btlihatbrg.Enabled = False
            btsimpan.Enabled = False
            bttambahrj.Enabled = False
            btubahrj.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            bthapusrj.Enabled = False
            btlihatbrg.Enabled = False
            btsimpan.Enabled = False
            bttambahrj.Enabled = False
            btubahrj.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            bthapusrj.Enabled = False
            btlihatbrg.Enabled = False
            btsimpan.Enabled = False
            bttambahrj.Enabled = False
            btubahrj.Enabled = False
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            bthapusrj.Enabled = True
            btlihatbrg.Enabled = True
            btsimpan.Enabled = True
            bttambahrj.Enabled = True
            btubahrj.Enabled = True
        End If
        s = 1
        Dim command2 As New MySqlCommand("select no_pajak,id_customer from t_penjualan where `delete`='0'", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim dt As New DataTable
        dt.Clear()
        adapter2.Fill(dt)
        ComboBox1.DataSource = dt
        ComboBox1.ValueMember = "no_pajak"
        ComboBox1.DisplayMember = "no_pajak"

    End Sub

    Private Sub bttambahrj_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim command As New MySqlCommand("SELECT * FROM tdetail_penjualan t where no_pajak='" + ComboBox1.SelectedValue.ToString + "'", connect)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        datatble1.Clear()
        adapter.Fill(datatble1)
        GridControl1.DataSource = datatble1
        'GridControl1.BackColor = Color.Black
        GridView1.PopulateColumns()
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        Dim command6 As New MySqlCommand("select no_pajak,id_customer from t_penjualan where `delete`=0", connect)
        Dim adapter6 As New MySqlDataAdapter(command6)
        Dim dt6 As New DataTable
        dt6.Clear()
        adapter6.Fill(dt6)
        ComboBox1.DataSource = dt6
        ComboBox1.ValueMember = "no_pajak"
        ComboBox1.DisplayMember = "no_pajak"
    End Sub



    Private Sub bttambahrb_Click(sender As Object, e As EventArgs) Handles bttambahrj.Click

        c = c + 1
        If tbjumlah.Text <> "" And tbkodebarang.Text <> "" And tbidpenjualan.Text <> "" And tbidsuplier.Text <> "" And tbnamabarang.Text <> "" Then
            simpanbelom = 0
            Try
                connect.Open()
                Dim command2 As New MySqlCommand("insert into retur_dpenjualan values ('" + tbidpenjualan.Text + "','" + tbreturpenjualan.Text + "','" + tbidsuplier.Text + "','" + tbkodebarang.Text + "','" + tbnamabarang.Text + "','" + tbjumlah.Text + "')", connect)
                command2.ExecuteNonQuery()
                MsgBox("sudah di masukan retur penjualan")
                connect.Close()


            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
            'Try
            '    GAERETUR = "0"
            '    Dim command33 As New MySqlCommand("select stok_masuk from stok_barang where id_barang='" + tbkodebarang.Text + "'", connect)
            '    Dim adapter33 As New MySqlDataAdapter(command33)
            '    Dim dt33 As New DataTable
            '    dt33.Clear()
            '    adapter33.Fill(dt33)
            '    GAERETUR = dt33.Rows(0).Item(0).ToString
            'Catch ex As Exception

            'End Try

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
            '    MsgBox("sudah di kurangi stok keluarnya")
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
            '    MsgBox("sudah ahkir dikalkulasi")
            '    connect.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    connect.Close()
            'End Try

            Dim hitung As String
            Dim historyid As String
            Dim command52 As New MySqlCommand("SELECT * FROM HISTORY ", connect)
            Dim adapter52 As New MySqlDataAdapter(command52)
            Dim datatble152 As New DataTable
            adapter52.Fill(datatble152)
            hitung = datatble152.Rows.Count() + 1

            historyid = "H" + hitung.ToString
            'TextBox2.Text = hitung


            Try
                connect.Open()
                Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbkodebarang.Text + "','" + tbnamabarang.Text + "','" + tbjumlah.Text + "','0','" + tbretur.Value.ToString("yyyyMMdd") + "','retur jual','barang di kembalikan')", connect)
                command2.ExecuteNonQuery()
                MsgBox("sudah di masukan 2")
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
        Else
            MsgBox("isi data dahulu")
        End If

    End Sub

    Private Sub dgvbarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellContentClick

    End Sub

    Private Sub dgvbarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellClick
        'Dim command3 As New MySqlCommand("select id_dpenjualan,id_barang,nama_barang from tdetail_penjualan where id_dpenjualan='" + dgvbarang.Item(0, dgvbarang.CurrentRow.Index).Value.ToString + "'", connect)
        'Dim adapter3 As New MySqlDataAdapter(command3)
        'Dim dt3 As New DataTable
        'dt3.Clear()
        'adapter3.Fill(dt3)
        'tbidpenjualan.Text = dt3.Rows(0).Item(0).ToString
        'tbkodebarang.Text = dt3.Rows(0).Item(1).ToString
        'tbnamabarang.Text = dt3.Rows(0).Item(2).ToString

        'tes = "0"
        'Dim command9 As New MySqlCommand("SELECT * FROM tdetail_penjualan t where no_pajak='" + dgvbarang.Item(1, dgvbarang.CurrentRow.Index).Value.ToString + "'", connect)
        'Dim adapter9 As New MySqlDataAdapter(command9)
        'Dim datatble19 As New DataTable
        'datatble19.Clear()
        'adapter9.Fill(datatble19)
        'tes = datatble19.Rows(0).Item(8).ToString


        'Dim command2 As New MySqlCommand("select id_customer,no_pajak from t_penjualan where no_pajak='" + dgvbarang.Item(1, dgvbarang.CurrentRow.Index).Value.ToString + "'", connect)
        'Dim adapter2 As New MySqlDataAdapter(command2)
        'Dim dt As New DataTable
        'dt.Clear()
        'adapter2.Fill(dt)
        'tbidsuplier.Text = dt.Rows(0).Item(0).ToString


        'Dim hitung As Integer
        'hitung = 0
        'Dim simpan As String
        'Dim command As New MySqlCommand("SELECT id_retur_penjualan FROM retur_penjualan r", connect)

        'Dim adapter As New MySqlDataAdapter(command)
        'Dim datatble1 As New DataTable
        'adapter.Fill(datatble1)
        'hitung = datatble1.Rows.Count() + 1
        'simpan = "RJ" + hitung.ToString

        'tbreturpenjualan.Text = simpan
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If c = 0 Then
            MsgBox("isi data dulu")
        Else
            c = 0
            Try
                connect.Open()
                Dim command2 As New MySqlCommand("insert into retur_penjualan values ('" + tbreturpenjualan.Text + "','" + ComboBox1.SelectedValue + "','" + tbretur.Value.ToString("yyyyMMdd") + "','0','0')", connect)
                command2.ExecuteNonQuery()
                MsgBox("sudah di masukan retur 2")
                connect.Close()
                'formreturbeli_Load(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try

            Dim command As New MySqlCommand("SELECT * FROM retur_dpenjualan r where id_retur_penjualan ='" + tbreturpenjualan.Text + "';", connect)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatble1 As New DataTable
            datatble1.Clear()
            adapter.Fill(datatble1)
            GridControl1.DataSource = datatble1
            GridView1.PopulateColumns()
            Dim hitung As Integer
            hitung = 0
            Dim simpan As String
            Dim command3 As New MySqlCommand("SELECT id_retur_penjualan FROM retur_penjualan r", connect)

            Dim adapter3 As New MySqlDataAdapter(command3)
            Dim datatble3 As New DataTable
            adapter3.Fill(datatble3)
            hitung = datatble3.Rows.Count() + 1
            simpan = "RJ" + hitung.ToString

            tbreturpenjualan.Text = simpan
            simpanbelom = 1
        End If
    End Sub

    Private Sub btlihatbrg_Click(sender As Object, e As EventArgs) Handles btlihatbrg.Click
        formbarang.ShowDialog()
    End Sub

    Private Sub btubahrj_Click(sender As Object, e As EventArgs) Handles btubahrj.Click
        s = 0
        Formubahreturpenjualan.ShowDialog()
    End Sub

    Private Sub bthapusrj_Click(sender As Object, e As EventArgs) Handles bthapusrj.Click

    End Sub

    Private Sub bttutuprjual_Click(sender As Object, e As EventArgs) Handles bttutuprjual.Click

        If simpanbelom = 0 And c > 0 Then
            MsgBox("tekan simpan dulu")
        Else
            s = 0
            Dim tutup As String
            tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If tutup = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Dim command3 As New MySqlCommand("select id_dpenjualan,id_barang,nama_barang from tdetail_penjualan where id_dpenjualan='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
        Dim adapter3 As New MySqlDataAdapter(command3)
        Dim dt3 As New DataTable
        dt3.Clear()
        adapter3.Fill(dt3)
        tbidpenjualan.Text = dt3.Rows(0).Item(0).ToString
        tbkodebarang.Text = dt3.Rows(0).Item(1).ToString
        tbnamabarang.Text = dt3.Rows(0).Item(2).ToString

        'batas = 0
        'Dim command9 As New MySqlCommand("SELECT * FROM tdetail_pembelian t where no_faktur='" + GridView1.GetFocusedDataRow(1).ToString + "'and id_dpembelian='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
        'Dim adapter9 As New MySqlDataAdapter(command9)
        'Dim datatble19 As New DataTable
        'datatble19.Clear()
        'adapter9.Fill(datatble19)
        'batas = datatble19.Rows(0).Item(8).ToString


        batas = "0"
        Dim command9 As New MySqlCommand("SELECT * FROM tdetail_penjualan t where no_pajak='" + GridView1.GetFocusedDataRow(1).ToString + "'and id_dpenjualan='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
        Dim adapter9 As New MySqlDataAdapter(command9)
        Dim datatble19 As New DataTable
        datatble19.Clear()
        adapter9.Fill(datatble19)
        batas = datatble19.Rows(0).Item(8).ToString


        Dim command2 As New MySqlCommand("select id_customer,no_pajak from t_penjualan where no_pajak='" + GridView1.GetFocusedDataRow(1).ToString + "'", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim dt As New DataTable
        dt.Clear()
        adapter2.Fill(dt)
        tbidsuplier.Text = dt.Rows(0).Item(0).ToString


        Dim hitung As Integer
        hitung = 0
        Dim simpan As String
        Dim command As New MySqlCommand("SELECT id_retur_penjualan FROM retur_penjualan r", connect)

        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        adapter.Fill(datatble1)
        hitung = datatble1.Rows.Count() + 1
        simpan = "RJ" + hitung.ToString

        tbreturpenjualan.Text = simpan
    End Sub

    Private Sub tbjumlah_TextChanged(sender As Object, e As EventArgs) Handles tbjumlah.TextChanged
        Dim simpan As Integer
        If tbjumlah.Text <> "" Then
            simpan = 0
            simpan = tbjumlah.Text
            If simpan > batas Then
                MsgBox("maaf jumlah melebihi batas")
            End If
        End If
    End Sub

    Private Sub tbjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbjumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class

