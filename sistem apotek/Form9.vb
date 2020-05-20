Imports MySql.Data.MySqlClient
Public Class Formstok
    Dim con As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya")
    Public id As String
    Public simpan1 As String
    Public simpan2 As String
    Public hasil As String
    Public stokmasuk As String
    Public stokkeluar As String
    Public final As String
    Public gaestok As String



    Private Sub bttutupsup_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btbatalsup_Click(sender As Object, e As EventArgs) Handles btopname.Click
        gaestok = tbidbarangstok.Text
        formstokopname.Show()
    End Sub

    Private Sub Formstok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btsimpanstok.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btsimpanstok.Enabled = False
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btsimpanstok.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btsimpanstok.Enabled = True
        End If
        Dim command As New MySqlCommand("select id_barang, nama_barang, stok_masuk, stok_keluar, stok_akhir from stok_barang where `delete` = '0'", con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim dt2 As New DataTable
        adapter.Fill(dt2)
        GridControl1.DataSource = dt2
        GridView1.PopulateColumns()

        Dim com2 As New MySqlCommand("select id_barang,nama_barang from m_barang where `delete` = '0';", con)
        Dim adap2 As New MySqlDataAdapter(com2)
        Dim dtbrg As New DataTable
        dtbrg.Clear()
        adap2.Fill(dtbrg)
        cbnamabarangstok.DataSource = dtbrg
        cbnamabarangstok.DisplayMember = "nama_barang"
        cbnamabarangstok.ValueMember = "id_barang"
    End Sub

    Private Sub btutupterima_Click(sender As Object, e As EventArgs) Handles btutupterima.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub cbnamabarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnamabarangstok.SelectedIndexChanged
        gaestok = ""
        Try
            Dim com As New MySqlCommand("select id_barang, nama_barang, id_stok from stok_barang where id_barang= '" + cbnamabarangstok.SelectedValue.ToString + "'", con)
            Dim adapt As New MySqlDataAdapter(com)
            Dim dtbrg As New DataTable
            adapt.Fill(dtbrg)
            cbnamabarangstok.DataSource = dtbrg
            cbnamabarangstok.ValueMember = "id_barang"
            cbnamabarangstok.DisplayMember = "nama_barang"
            tbidbarangstok.Text = dtbrg.Rows(0).Item(0).ToString
            tbidstok.Text = dtbrg.Rows(0).Item(2).ToString

        Catch ex As Exception

        End Try


    End Sub

    Private Sub cbnamabarang_Click(sender As Object, e As EventArgs) Handles cbnamabarangstok.Click
        Dim com3 As New MySqlCommand("select id_barang, nama_barang from m_barang where `delete` = '0'", con)
        Dim adapt3 As New MySqlDataAdapter(com3)
        Dim dtbrg As New DataTable
        dtbrg.Clear()
        adapt3.Fill(dtbrg)
        cbnamabarangstok.DataSource = dtbrg
        cbnamabarangstok.ValueMember = "id_barang"
        cbnamabarangstok.DisplayMember = "nama_barang"
    End Sub

    Private Sub tbstokakhir_TextChanged(sender As Object, e As EventArgs) Handles tbstokakhir.TextChanged

    End Sub

    Private Sub btsimpanstok_Click(sender As Object, e As EventArgs) Handles btsimpanstok.Click
        If tbidbarangstok.Text <> "" And tbidstok.Text <> "" And tbstokakhir.Text <> "" And tbstokmasuk.Text <> "" Then
            Try
                con.Open()
                Dim comsim As New MySqlCommand("update stok_barang set stok_masuk= '" + stokmasuk + "', stok_akhir= '" + final + "' where id_stok= '" + tbidstok.Text + "';", con)
                comsim.ExecuteNonQuery()
                MsgBox("data sudah masuk")
                con.Close()
                Formstok_Load(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        Else
            MsgBox("isi dahulu data")
        End If


    End Sub

    Private Sub tbstokmasuk_TextChanged(sender As Object, e As EventArgs) Handles tbstokmasuk.TextChanged
        stokmasuk = ""
        Dim com3 As New MySqlCommand("select sum(stok_masuk+'" + tbstokmasuk.Text + "') from stok_barang where id_stok='" + tbidstok.Text + "'", con)
        Dim adapt3 As New MySqlDataAdapter(com3)
        Dim dtbrg As New DataTable
        adapt3.Fill(dtbrg)
        stokmasuk = dtbrg.Rows(0).Item(0).ToString

        Dim com7 As New MySqlCommand("select sum('" + stokmasuk + "'-stok_keluar) from stok_barang where id_stok='" + tbidstok.Text + "';", con)
        Dim adapt7 As New MySqlDataAdapter(com7)
        Dim dt7 As New DataTable
        adapt7.Fill(dt7)
        final = dt7.Rows(0).Item(0).ToString
        tbstokakhir.Text = final
    End Sub
    Private Sub rbkeluar_CheckedChanged(sender As Object, e As EventArgs)
        lbmasuk.Visible = False
        tbstokmasuk.Visible = False
    End Sub

    Private Sub rbmasuk_CheckedChanged(sender As Object, e As EventArgs)
        lbmasuk.Visible = True
        tbstokmasuk.Visible = True
    End Sub
    Private Sub btubahstok_Click(sender As Object, e As EventArgs) Handles btubahstok.Click
        formubahstok.Show()
    End Sub

    Private Sub bthistory_Click(sender As Object, e As EventArgs) Handles bthistorystok.Click
        formhistory.Show()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btpenerimaanstok.Click
        formhistorypenerimaan.Show()
    End Sub

    Private Sub btlaporan_Click(sender As Object, e As EventArgs) Handles btlaporan.Click
        Formreportstok.ShowDialog()
    End Sub

    Private Sub dgvstok_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstok.CellContentClick

    End Sub

    Private Sub tbstokmasuk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbstokmasuk.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbstokakhir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbstokakhir.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class