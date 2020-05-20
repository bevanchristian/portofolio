Imports MySql.Data.MySqlClient
Public Class formbarang
    Dim connect As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya")
    Public id As String
    Public simpan5 As String

    Private Sub formbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btbatalbrg.Enabled = False
            bttambahbrg.Enabled = False
            bthapusbrg.Enabled = False
            btubahbrg.Enabled = False
            bttambahbrg.Enabled = False
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btbatalbrg.Enabled = False
            bttambahbrg.Enabled = False
            bthapusbrg.Enabled = False
            btubahbrg.Enabled = False
            bttambahbrg.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btbatalbrg.Enabled = False
            bttambahbrg.Enabled = False
            bthapusbrg.Enabled = False
            btubahbrg.Enabled = False
            bttambahbrg.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btbatalbrg.Enabled = True
            bttambahbrg.Enabled = True
            bthapusbrg.Enabled = True
            btubahbrg.Enabled = True
            bttambahbrg.Enabled = True
        End If

        Dim command As New MySqlCommand("SELECT * FROM m_barang m where `delete`='0'", connect)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        datatble1.Clear()

        adapter.Fill(datatble1)
        GridControl1.DataSource = datatble1

    End Sub

    Private Sub bttutupbrg_Click(sender As Object, e As EventArgs) Handles bttutupbrg.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Public Sub dgvbarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellClick
        'Dim command2 As New MySqlCommand("select *from m_barang where  id_barang='" + dgvbarang.Item(0, dgvbarang.CurrentRow.Index).Value.ToString + "'", connect)
        'Dim adapter2 As New MySqlDataAdapter(command2)
        'Dim dttable2 As New DataTable
        'adapter2.Fill(dttable2)
        'tbkodebrg.Text = dttable2.Rows(0).Item(0).ToString
        'tbnamabrg.Text = dttable2.Rows(0).Item(1).ToString
        'tbbelibrg.Text = dttable2.Rows(0).Item(2).ToString
        'tbdiscbrg.Text = dttable2.Rows(0).Item(3).ToString
        'tbbatchbrg.Text = dttable2.Rows(0).Item(4).ToString
        'tbexpbrg.Text = dttable2.Rows(0).Item(5).ToString
        'tbjualbrg.Text = dttable2.Rows(0).Item(7).ToString
        'id = dgvbarang.Item(0, dgvbarang.CurrentRow.Index).Value.ToString



    End Sub

    Private Sub bttambahbrg_Click(sender As Object, e As EventArgs) Handles bttambahbrg.Click
        If tbbatchbrg.Text <> "" And tbbelibrg.Text <> "" And tbdiscbrg.Text <> "" And tbexpbrg.Text <> "" And tbjualbrg.Text <> "" And tbnamabrg.Text <> "" Then
            Dim simpan3 As String
            Dim hitung As Integer = 0
            Dim command7 As New MySqlCommand("SELECT * FROM stok_barang", connect)

            Dim adapter7 As New MySqlDataAdapter(command7)
            Dim datatble7 As New DataTable
            adapter7.Fill(datatble7)
            simpan3 = ""
            hitung = datatble7.Rows.Count() + 1
            If hitung < 10 Then
                simpan3 = "S0" + hitung.ToString
            ElseIf hitung > 10 Then
                simpan3 = "S" + hitung.ToString
            End If


            Try
                connect.Open()
                Dim command3 As New MySqlCommand("insert into m_barang values('" + tbkodebrg.Text + "','" + tbnamabrg.Text + "','" + tbbelibrg.Text + "','" + tbdiscbrg.Text + "','" + tbbatchbrg.Text + "','" + tbexpbrg.Text + "','0','" + tbjualbrg.Text + "')", connect)
                command3.ExecuteNonQuery()
                MsgBox("data sudah masuk")
                connect.Close()
                formbarang_Load(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
            Try
                connect.Open()
                Dim command3 As New MySqlCommand("insert into stok_barang values('" + simpan3 + "','" + tbkodebrg.Text + "','" + tbnamabrg.Text + "','0','0','0','0')", connect)
                command3.ExecuteNonQuery()
                MsgBox("data sudah masuk ke stok barang")
                connect.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
        Else
            MsgBox("isi data dahulu")
        End If


    End Sub

    Public Sub bthapusbrg_Click(sender As Object, e As EventArgs) Handles bthapusbrg.Click
        Try
            connect.Open()
            Dim command3 As New MySqlCommand("update  m_barang set `delete`='1' where id_barang='" + id + "'", connect)
            command3.ExecuteNonQuery()

            MsgBox("data sudah dihapus")
            connect.Close()
            formbarang_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            connect.Open()
            Dim command3 As New MySqlCommand("update  stok_barang set `delete`='1' where id_barang='" + id + "'", connect)
            command3.ExecuteNonQuery()

            MsgBox("data sudah dihapus")
            connect.Close()
            formbarang_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub dgvbarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellContentClick

    End Sub

    Public Sub btubahbrg_Click(sender As Object, e As EventArgs) Handles btubahbrg.Click
        Try
            connect.Open()
            Dim command4 As New MySqlCommand("update  m_barang set id_barang='" + tbkodebrg.Text + "',nama_barang='" + tbnamabrg.Text + "',harga_beli='" + tbbelibrg.Text + "',diskon='" + tbdiscbrg.Text + "',no_batch='" + tbbatchbrg.Text + "',expire_date='" + tbexpbrg.Text + "',harga_jual='" + tbjualbrg.Text + "' where id_barang='" + id + "'", connect)
            command4.ExecuteNonQuery()

            MsgBox("data sudah diubah di master")
            connect.Close()
            formbarang_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try


        Try
            connect.Open()
            Dim command4 As New MySqlCommand("update  stok_barang set id_barang='" + tbkodebrg.Text + "',nama_barang='" + tbnamabrg.Text + "' where id_barang='" + id + "'", connect)
            command4.ExecuteNonQuery()

            MsgBox("data sudah ubah di stok")
            connect.Close()
            formbarang_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub btbatalbrg_Click(sender As Object, e As EventArgs) Handles btbatalbrg.Click

    End Sub

    Private Sub tbcaribrg_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Form20.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub tbkodebrg_Click(sender As Object, e As EventArgs) Handles tbkodebrg.Click

        Dim hitung As Integer = 0
        Dim command7 As New MySqlCommand("SELECT * FROM m_barang", connect)

        Dim adapter7 As New MySqlDataAdapter(command7)
        Dim datatble7 As New DataTable
        adapter7.Fill(datatble7)
        simpan5 = ""
        hitung = datatble7.Rows.Count() + 1
        If hitung < 10 Then
            simpan5 = "A000" + hitung.ToString
            tbkodebrg.Text = simpan5.ToString
        ElseIf hitung > 10 Then
            simpan5 = "A00" + hitung.ToString
            tbkodebrg.Text = simpan5.ToString
        End If
    End Sub

    Private Sub tbkodebrg_TextChanged(sender As Object, e As EventArgs) Handles tbkodebrg.TextChanged

    End Sub

    Private Sub dgvbarang_DoubleClick(sender As Object, e As EventArgs) Handles dgvbarang.DoubleClick
        If formpembelian.b = 1 Then
            Dim command2 As New MySqlCommand("select *from m_barang where  id_barang='" + dgvbarang.Item(0, dgvbarang.CurrentRow.Index).Value.ToString + "'", connect)
            Dim adapter2 As New MySqlDataAdapter(command2)
            Dim dttable2 As New DataTable
            adapter2.Fill(dttable2)
            formpembelian.tbkodejual.Text = dttable2.Rows(0).Item(0).ToString
            formpembelian.tbnamabrg.Text = dttable2.Rows(0).Item(1).ToString
            formpembelian.tbhrgbeli.Text = dttable2.Rows(0).Item(2).ToString
            formpembelian.Textbox3.Text = dttable2.Rows(0).Item(3).ToString
            formpembelian.tbbathbeli.Text = dttable2.Rows(0).Item(4).ToString
            formpembelian.Textbox2.Text = dttable2.Rows(0).Item(5).ToString
            Me.Close()
        End If
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Dim command2 As New MySqlCommand("select *from m_barang where  id_barang='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim dttable2 As New DataTable
        adapter2.Fill(dttable2)
        tbkodebrg.Text = dttable2.Rows(0).Item(0).ToString
        tbnamabrg.Text = dttable2.Rows(0).Item(1).ToString
        tbbelibrg.Text = dttable2.Rows(0).Item(2).ToString
        tbdiscbrg.Text = dttable2.Rows(0).Item(3).ToString
        tbbatchbrg.Text = dttable2.Rows(0).Item(4).ToString
        tbexpbrg.Text = dttable2.Rows(0).Item(5).ToString
        tbjualbrg.Text = dttable2.Rows(0).Item(7).ToString
        id = GridView1.GetFocusedDataRow(0).ToString

        If formpembelian.b = 1 Then


            Dim command21 As New MySqlCommand("select *from m_barang where  id_barang='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
            Dim adapter21 As New MySqlDataAdapter(command21)
            Dim dttable23 As New DataTable
            adapter21.Fill(dttable23)
            formpembelian.tbkodejual.Text = dttable23.Rows(0).Item(0).ToString
            formpembelian.tbnamabrg.Text = dttable23.Rows(0).Item(1).ToString
            formpembelian.tbhrgbeli.Text = dttable23.Rows(0).Item(2).ToString
            formpembelian.Textbox3.Text = dttable23.Rows(0).Item(3).ToString
            formpembelian.tbbathbeli.Text = dttable23.Rows(0).Item(4).ToString
            formpembelian.Textbox2.Text = dttable23.Rows(0).Item(5).ToString
            Me.Close()
        End If
        If formpenjualan.j = 1 Then

            Dim command21 As New MySqlCommand("select *from m_barang where  id_barang='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
            Dim adapter21 As New MySqlDataAdapter(command21)
            Dim dttable21 As New DataTable
            adapter21.Fill(dttable21)
            formpenjualan.tbjual.Text = dttable21.Rows(0).Item(0).ToString
            formpenjualan.tbnamabrg.Text = dttable21.Rows(0).Item(1).ToString
            formpenjualan.tbbeli.Text = dttable21.Rows(0).Item(7).ToString
            formpenjualan.tbdisc.Text = dttable21.Rows(0).Item(3).ToString
            formpenjualan.TextBox1.Text = dttable21.Rows(0).Item(4).ToString
            formpenjualan.texbox3.Text = dttable21.Rows(0).Item(5).ToString
            Me.Close()
        End If
        If Form15.b = 1 Then
            Dim command21 As New MySqlCommand("select *from m_barang where  id_barang='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
            Dim adapter21 As New MySqlDataAdapter(command21)
            Dim dttable214 As New DataTable
            adapter21.Fill(dttable214)
            Form15.tbkodejual.Text = dttable214.Rows(0).Item(0).ToString
            Form15.tbnamabrg.Text = dttable214.Rows(0).Item(1).ToString
            Form15.tbhrgbeli.Text = dttable214.Rows(0).Item(2).ToString
            Form15.Textbox3.Text = dttable214.Rows(0).Item(3).ToString
            Form15.tbbathbeli.Text = dttable214.Rows(0).Item(4).ToString
            Form15.Textbox2.Text = dttable214.Rows(0).Item(5).ToString
            Me.Close()
        End If
        If formubahpenjualan.ju = 1 Then
            Dim command21 As New MySqlCommand("select *from m_barang where  id_barang='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
            Dim adapter21 As New MySqlDataAdapter(command21)
            Dim dttable210 As New DataTable
            adapter21.Fill(dttable210)
            formubahpenjualan.tbjual.Text = dttable210.Rows(0).Item(0).ToString
            formubahpenjualan.tbnamabrg.Text = dttable210.Rows(0).Item(1).ToString
            formubahpenjualan.tbbeli.Text = dttable210.Rows(0).Item(7).ToString
            formubahpenjualan.tbdisc.Text = dttable210.Rows(0).Item(3).ToString
            formubahpenjualan.TextBox1.Text = dttable210.Rows(0).Item(4).ToString
            formubahpenjualan.texbox3.Text = dttable210.Rows(0).Item(5).ToString
            Me.Close()
        End If
        If formreturbeli.r = 1 Then
            Dim command21 As New MySqlCommand("select *from m_barang where  id_barang='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
            Dim adapter21 As New MySqlDataAdapter(command21)
            Dim dttable210 As New DataTable
            adapter21.Fill(dttable210)
            formreturbeli.tbkodebarang.Text = dttable210.Rows(0).Item(0).ToString
            formreturbeli.tbnamabarang.Text = dttable210.Rows(0).Item(1).ToString
            Me.Close()
        End If
        If formreturjual.s = 1 Then
            Dim command21 As New MySqlCommand("select *from m_barang where  id_barang='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
            Dim adapter21 As New MySqlDataAdapter(command21)
            Dim dttable210 As New DataTable
            adapter21.Fill(dttable210)
            formreturjual.tbkodebarang.Text = dttable210.Rows(0).Item(0).ToString
            formreturjual.tbnamabarang.Text = dttable210.Rows(0).Item(1).ToString
            Me.Close()
        End If
    End Sub

    Private Sub tbjualbrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbjualbrg.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbbelibrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbbelibrg.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class



