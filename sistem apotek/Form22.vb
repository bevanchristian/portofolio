Imports MySql.Data.MySqlClient
Public Class formubahpenerimaan
    Dim con As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public saveidpenerimaan As String

    Private Sub formubahpenerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btubahpenerimaan.Enabled = False
            SimpleButton2.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btubahpenerimaan.Enabled = False
            SimpleButton2.Enabled = False
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btubahpenerimaan.Enabled = False
            SimpleButton2.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btubahpenerimaan.Enabled = True
            SimpleButton2.Enabled = True
        End If
        Dim com1 As New MySqlCommand("select id_penerimaan from penerimaan where `delete`='0';", con)
        Dim adapt1 As New MySqlDataAdapter(com1)
        Dim dtubah As New DataTable
        adapt1.Fill(dtubah)
        cbidubahterima.DataSource = dtubah
        cbidubahterima.ValueMember = "id_penerimaan"
        cbidubahterima.DisplayMember = "id_penerimaan"
        Dim count As Integer = 0

        'Dim comm As New MySqlCommand("SELECT * FROM penerimaan p;", con)
        'Dim adapt As New MySqlDataAdapter(comm)
        'Dim dt As New DataTable
        'adapt.Fill(dt)
        'count = dt.Rows.Count() + 1
        'saveidpenerimaan = "PU" + count.ToString


    End Sub

    Private Sub btutupterima_Click(sender As Object, e As EventArgs) Handles bttutuppenerimaan.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub cbidubahpenerimaan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbidubahterima.SelectedIndexChanged
        Try
            Dim com1 As New MySqlCommand("select id_penerimaan, id_barang, nama_barang, jumlah from detail_penerimaan where id_penerimaan = '" + cbidubahterima.SelectedValue.ToString + "';", con)
            Dim adapt1 As New MySqlDataAdapter(com1)
            Dim dtubah As New DataTable
            adapt1.Fill(dtubah)
            cbidubahterima.DataSource = dtubah
            cbidubahterima.ValueMember = "id_penerimaan"
            cbidubahterima.DisplayMember = "id_penerimaan"
            GridControl1.DataSource = dtubah
            GridView1.PopulateColumns()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvubahterima_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvubahterima.CellClick
        'Dim hitung As Integer = 0
        'Dim saveiddpenerimaan As String
        'Dim commdp As New MySqlCommand("SELECT * FROM detail_penerimaan;", con)
        'Dim adaptdp As New MySqlDataAdapter(commdp)
        'Dim dtdp As New DataTable
        'adaptdp.Fill(dtdp)
        'hitung = dtdp.Rows.Count() + 1
        'saveiddpenerimaan = "DPU" + hitung.ToString
        'TextBox1.Text = saveiddpenerimaan
        'Dim command As New MySqlCommand("select id_penerimaan, id_barang, nama_barang, jumlah ,id_dpenerimaan from detail_penerimaan where id_penerimaan='" + dgvubahterima.Item(0, dgvubahterima.CurrentRow.Index).Value.ToString + "' and nama_barang='" + dgvubahterima.Item(2, dgvubahterima.CurrentRow.Index).Value.ToString + "';", con)
        'Dim adapter As New MySqlDataAdapter(command)
        'Dim dt2 As New DataTable
        'adapter.Fill(dt2)
        'tbidbrgubahterima.Text = dt2.Rows(0).Item(1).ToString
        'tbnamabrgubahterima.Text = dt2.Rows(0).Item(2).ToString
        'tbjumlahubahterima.Text = dt2.Rows(0).Item(3).ToString
        'TextBox1.Text = dt2.Rows(0).Item(4).ToString

        'Dim com1 As New MySqlCommand("select id_penerimaan,tgl_penerimaan, no_faktur from penerimaan where id_penerimaan='" + dgvubahterima.Item(0, dgvubahterima.CurrentRow.Index).Value.ToString + "';", con)
        'Dim adapt1 As New MySqlDataAdapter(com1)
        'Dim dt1 As New DataTable
        'adapt1.Fill(dt1)
        ''dtpubahterima.Text = dt1.Rows(0).Item(1).ToString
        'tbnofakturubahterima.Text = dt1.Rows(0).Item(2).ToString

    End Sub

    Private Sub cbidubahpenerimaan_Click(sender As Object, e As EventArgs) Handles cbidubahterima.Click
        Dim com3 As New MySqlCommand("select id_penerimaan from penerimaan where `delete`='0'", con)
        Dim adapt3 As New MySqlDataAdapter(com3)
        Dim dt3 As New DataTable
        adapt3.Fill(dt3)
        cbidubahterima.DataSource = dt3
        cbidubahterima.ValueMember = "id_penerimaan"
        cbidubahterima.DisplayMember = "id_penerimaan"
    End Sub

    Private Sub btubahpenerimaan_Click(sender As Object, e As EventArgs) Handles btubahpenerimaan.Click



        'Try
        '    con.Open()
        '    Dim command3 As New MySqlCommand("insert into penerimaan values('" + saveidpenerimaan + "','" + dtpubahterima.Value.ToString("yyyyMMdd") + "','" + tbnofakturubahterima.Text + "')", con)
        '    command3.ExecuteNonQuery()
        '    con.Close()
        '    MsgBox("data sudah masuk")


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    con.Close()
        'End Try
        'Dim count As Integer = 0
        'Dim comm As New MySqlCommand("SELECT * FROM penerimaan p;", con)
        'Dim adapt As New MySqlDataAdapter(comm)
        'Dim dt As New DataTable
        'adapt.Fill(dt)
        'count = dt.Rows.Count() + 1
        'saveidpenerimaan = "PU" + count.ToString
        'Try
        '    con.Open()
        '    Dim command4 As New MySqlCommand("update penerimaan set tgl_penerimaan='" + dtpubahterima.Text + "'where id_penerimaan='" + cbidubahterima.SelectedValue + "';", con)
        '    command4.ExecuteNonQuery()

        '    MsgBox("data sudah diubah")
        '    con.Close()
        '    formubahpenerimaan_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    con.Close()
        'End Try

        Try
            con.Open()
            Dim command5 As New MySqlCommand("update detail_penerimaan set id_barang='" + tbidbrgubahterima.Text + "',nama_barang= '" + tbnamabrgubahterima.Text + "',jumlah= '" + tbjumlahubahterima.Text + "' where id_dpenerimaan='" + TextBox1.Text + "' and id_penerimaan='" + cbidubahterima.SelectedValue.ToString + "';", con)
            command5.ExecuteNonQuery()
            MsgBox("data sudah diubah")
            con.Close()
            formubahpenerimaan_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

        'Dim hitung As Integer = 0
        'Dim saveiddpenerimaan As String
        'Dim commdp As New MySqlCommand("SELECT * FROM detail_penerimaan;", con)
        'Dim adaptdp As New MySqlDataAdapter(commdp)
        'Dim dtdp As New DataTable
        'adaptdp.Fill(dtdp)
        'hitung = dtdp.Rows.Count() + 1
        'saveiddpenerimaan = "DPU" + hitung.ToString
        'TextBox1.Text = saveiddpenerimaan
        'Try
        '    con.Open()
        '    Dim command2 As New MySqlCommand("insert into detail_penerimaan(id_dpenerimaan,id_penerimaan,id_barang,nama_barang,jumlah) values('" + TextBox1.Text + "','" + saveidpenerimaan + "','" + tbidbrgubahterima.Text + "','" + tbnamabrgubahterima.Text + "','" + tbjumlahubahterima.Text + "')", con)
        '    command2.ExecuteNonQuery()
        '    MsgBox("data sudah masuk")
        '    con.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    con.Close()
        'End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            con.Open()
            Dim command2 As New MySqlCommand("update penerimaan set `delete`='1' where id_penerimaan='" + cbidubahterima.SelectedValue.ToString + "'", con)
            command2.ExecuteNonQuery()
            MsgBox("data sudah dihapus")
            con.Close()
            formubahpenerimaan_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Dim command As New MySqlCommand("select id_penerimaan, id_barang, nama_barang, jumlah ,id_dpenerimaan from detail_penerimaan where id_penerimaan='" + GridView1.GetFocusedDataRow(0).ToString + "' and nama_barang='" + GridView1.GetFocusedDataRow(2).ToString + "';", con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim dt2 As New DataTable
        adapter.Fill(dt2)
        tbidbrgubahterima.Text = dt2.Rows(0).Item(1).ToString
        tbnamabrgubahterima.Text = dt2.Rows(0).Item(2).ToString
        tbjumlahubahterima.Text = dt2.Rows(0).Item(3).ToString
        TextBox1.Text = dt2.Rows(0).Item(4).ToString

        Dim com1 As New MySqlCommand("select id_penerimaan,tgl_penerimaan, no_faktur from penerimaan where id_penerimaan='" + GridView1.GetFocusedDataRow(0).ToString + "';", con)
        Dim adapt1 As New MySqlDataAdapter(com1)
        Dim dt1 As New DataTable
        adapt1.Fill(dt1)
        'dtpubahterima.Text = dt1.Rows(0).Item(1).ToString
        tbnofakturubahterima.Text = dt1.Rows(0).Item(2).ToString
    End Sub

    Private Sub tbjumlahubahterima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbjumlahubahterima.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
