Imports MySql.Data.MySqlClient
Public Class formpembelian
    Dim connect As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public hitung2 As String
    Public counter As Integer
    Dim counter2 As Integer
    Dim counter3 As Integer
    Public b As Integer
    Public c As Integer
    Public simpanbelom As Integer

    Private Sub bttutupbrg_Click(sender As Object, e As EventArgs) Handles btutupbeli.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btviewbarang.Click
        formbarang.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btviewsup.Click
        formsupplier.Show()
    End Sub

    Private Sub btretur_Click(sender As Object, e As EventArgs) Handles btretur.Click
        formreturbeli.Show()
    End Sub

    Private Sub dgvpembelian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpembelian.CellContentClick

    End Sub

    Private Sub formpembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            bttambahorder.Enabled = False
            bttambahbeli.Enabled = False
            bthapusbeli.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            bttambahorder.Enabled = True
            bttambahbeli.Enabled = True
            bthapusbeli.Enabled = True
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            bttambahorder.Enabled = False
            bttambahbeli.Enabled = False
            bthapusbeli.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            bttambahorder.Enabled = False
            bttambahbeli.Enabled = False
            bthapusbeli.Enabled = False
        End If
        b = 1
        GridControl1.Show()
        GridControl2.Hide()
        'Dim command As New MySqlCommand("select t.no_faktur,tgl_pembelian,id_supplier,total_pembelian,id_dpembelian,id_barang,nama_barang,harga_beli,diskon,no_batch,expire_date,total_beli from t_pembelian t left join tdetail_pembelian s on t.no_faktur=s.no_faktur where t.no_faktur='" + tbfakturbeli.Text + "';", connect)
        'Dim adapter As New MySqlDataAdapter(command)
        'Dim datatble1 As New DataTable
        'datatble1.Clear()
        'adapter.Fill(datatble1)
        'GridControl1.DataSource = datatble1

        'Dim command2 As New MySqlCommand("select id_barang,nama_barang from m_barang", connect)
        'Dim adapter2 As New MySqlDataAdapter(command2)
        'Dim dt As New DataTable
        'dt.Clear()
        'adapter2.Fill(dt)
        'ComboBox1.DataSource = dt
        'ComboBox1.ValueMember = "id_barang"
        'ComboBox1.DisplayMember = "nama_barang"
    End Sub

    Private Sub dgvpembelian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpembelian.CellClick
        'Dim command2 As New MySqlCommand("select t.no_faktur,tgl_pembelian,id_supplier,total_pembelian,id_dpembelian,id_barang,nama_barang,harga_beli,diskon,no_batch,expire_date from t_pembelian t left join tdetail_pembelian s on t.no_faktur=s.no_faktur where t.no_faktur='" + dgvpembelian.Item(0, dgvpembelian.CurrentRow.Index).Value.ToString + "'", connect)

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
    End Sub

    Private Sub bttambahbeli_Click(sender As Object, e As EventArgs) Handles bttambahbeli.Click
        If c = 0 Then
            MsgBox("isi data dulu")
        Else
            c = 0
            hitung2 = 0

            Try
                connect.Open()
                Dim command2 As New MySqlCommand("insert into t_pembelian values ('" + tbfakturbeli.Text + "','" + textbox1.Value.ToString("yyyyMMdd") + "','" + tbkodesup.Text + "','" + counter2.ToString + "','0','0')", connect)
                command2.ExecuteNonQuery()
                MsgBox("sudah di masukan")
                connect.Close()
                'formpembelian_Load(sender, e)

            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
            counter2 = 0

            Dim command As New MySqlCommand("select no_faktur,tgl_pembelian,id_supplier,total_pembelian,`delete` from t_pembelian where no_faktur='" + tbfakturbeli.Text + "'", connect)
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
            Dim command4 As New MySqlCommand("SELECT no_faktur FROM t_pembelian t", connect)

            Dim adapter4 As New MySqlDataAdapter(command4)
            Dim datatble4 As New DataTable
            adapter4.Fill(datatble4)
            hitung = datatble4.Rows.Count() + 1
            simpan2 = "F" + hitung.ToString
            tbfakturbeli.Text = simpan2








            'Try
            '    connect.Open()
            '    Dim command2 As New MySqlCommand("insert into t_pembelian values ('" + tbfakturbeli.Text + "','" + TextBox1.Text + "','" + tbkodesup.Text + "','" + tbtotbeli.Text + "')", connect)
            '    command2.ExecuteNonQuery()
            '    MsgBox("sudah di masukan")
            '    connect.Close()
            '    formpembelian_Load(sender, e)

            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    connect.Close()
            'End Try
            'Try
            '    connect.Open()
            '    Dim command2 As New MySqlCommand("insert into tdetail_pembelian values ('" + tbidbeli.Text + "','" + tbfakturbeli.Text + "','" + tbkodejual.Text + "','" + tbnamabrg.Text + "','" + tbhrgbeli.Text + "','" + TextBox3.Text + "','" + tbbathbeli.Text + "','" + TextBox2.Text + "')", connect)
            '    command2.ExecuteNonQuery()
            '    MsgBox("sudah di masukan 2")
            '    connect.Close()
            '    formpembelian_Load(sender, e)
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    connect.Close()
            'End Try
            simpanbelom = 1
        End If


    End Sub
    Private Sub tbidbeli_Click(sender As Object, e As EventArgs) Handles tbidbeli.Click
        Dim hitung As Integer
        hitung = 0
        Dim simpan2 As String
        Dim command As New MySqlCommand("SELECT * FROM tdetail_pembelian", connect)

        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        adapter.Fill(datatble1)
        hitung = datatble1.Rows.Count() + 1
        If hitung < 10 Then
            simpan2 = "PB00" + hitung.ToString
            tbidbeli.Text = simpan2
        ElseIf hitung >= 10 And hitung <= 99 Then
            simpan2 = "PB0" + hitung.ToString
            tbidbeli.Text = simpan2
        End If
    End Sub

    Private Sub bthapusbeli_Click(sender As Object, e As EventArgs) Handles bthapusbeli.Click
        'Try
        '    connect.Open()
        '    Dim command3 As New MySqlCommand("delete from  t_pembelian where no_faktur='" + tbfakturbeli.Text + "'", connect)
        '    command3.ExecuteNonQuery()

        '    MsgBox("data sudah dihapus")
        '    connect.Close()
        '    formpembelian_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    connect.Close()
        'End Try
        'Try
        '    connect.Open()
        '    Dim command3 As New MySqlCommand("delete from  tdetail_pembelian where id_dpembelian='" + tbidbeli.Text + "'", connect)
        '    command3.ExecuteNonQuery()

        '    MsgBox("data sudah dihapus2")
        '    connect.Close()
        '    formpembelian_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    connect.Close()
        'End Try
    End Sub

    Private Sub btubahbeli_Click(sender As Object, e As EventArgs) Handles btubahbeli.Click
        b = 0
        Form15.ShowDialog()
        'Try
        '    connect.Open()
        '    Dim command4 As New MySqlCommand("update  tdetail_pembelian set id_dpembelian='" + tbidbeli.Text + "',no_faktur='" + tbfakturbeli.Text + "',id_barang='" + tbkodejual.Text + "',nama_barang='" + tbnamabrg.Text + "',harga_beli='" + tbhrgbeli.Text + "',diskon='" + TextBox3.Text + "',no_batch='" + tbbathbeli.Text + "',expire_date='" + TextBox2.Text + "',total_beli='" + tbtotbeli.Text + "' where id_dpembelian='" + tbidbeli.Text + "'", connect)
        '    command4.ExecuteNonQuery()
        '    MsgBox("data sudah diupdate 2")
        '    connect.Close()
        '    formpembelian_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    connect.Close()
        'End Try

        'Dim command6 As New MySqlCommand("SELECT sum(harga_beli) FROM tdetail_pembelian t where no_faktur='" + tbfakturbeli.Text + "'", connect)
        'Dim adapter6 As New MySqlDataAdapter(command6)
        'Dim datatble6 As New DataTable
        'datatble6.Clear()
        'adapter6.Fill(datatble6)
        'dgvpembelian.DataSource = datatble6
        'tb1.Text = datatble6.Rows(0).Item(0)




        'Try
        '    connect.Open()
        '    Dim command4 As New MySqlCommand("update  t_pembelian set no_faktur='" + tbfakturbeli.Text + "',tgl_pembelian='" + TextBox1.Text + "',id_supplier='" + tbkodesup.Text + "',total_pembelian='" + tb1.Text + "' where no_faktur='" + tbfakturbeli.Text + "'", connect)
        '    command4.ExecuteNonQuery()
        '    MsgBox("data sudah diupdate")
        '    connect.Close()
        '    formpembelian_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    connect.Close()
        'End Try
    End Sub

    Private Sub stokmasuk_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbidbeli_TextChanged(sender As Object, e As EventArgs) Handles tbidbeli.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

        'Try


        '    Dim command As New MySqlCommand("select id_barang,nama_barang from m_barang where id_barang='" + ComboBox1.SelectedValue.ToString + "'", connect)
        '    Dim adapter As New MySqlDataAdapter(command)
        '    Dim dt As New DataTable
        '    adapter.Fill(dt)
        '    ComboBox1.DataSource = dt
        '    ComboBox1.ValueMember = "id_barang"
        '    ComboBox1.DisplayMember = "nama_barang"
        '    TextBox4.Text = dt.Rows(0).Item(0).ToString

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs)
        'Try


        '    Dim command As New MySqlCommand("select id_barang,nama_barang from m_barang where id_barang='" + ComboBox1.SelectedValue.ToString + "'", connect)
        '    Dim adapter As New MySqlDataAdapter(command)
        '    Dim dt As New DataTable
        '    adapter.Fill(dt)
        '    ComboBox1.DataSource = dt
        '    ComboBox1.ValueMember = "id_barang"
        '    ComboBox1.DisplayMember = "nama_barang"
        '    TextBox4.Text = dt.Rows(0).Item(0).ToString

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs)

        'Dim command2 As New MySqlCommand("select id_barang,nama_barang from m_barang", connect)
        'Dim adapter2 As New MySqlDataAdapter(command2)
        'Dim dt As New DataTable
        'dt.Clear()
        'adapter2.Fill(dt)
        'ComboBox1.DataSource = dt
        'ComboBox1.ValueMember = "id_barang"
        'ComboBox1.DisplayMember = "nama_barang"
    End Sub

    Private Sub tbfakturbeli_Click(sender As Object, e As EventArgs) Handles tbfakturbeli.Click
        GridControl2.Hide()
        GridControl1.Show()
        Dim hitung As Integer
        hitung = 0
        Dim simpan2 As String
        Dim command As New MySqlCommand("SELECT no_faktur FROM t_pembelian t", connect)

        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        adapter.Fill(datatble1)
        hitung = datatble1.Rows.Count() + 1
        simpan2 = "F" + hitung.ToString
        tbfakturbeli.Text = simpan2
    End Sub

    Private Sub btupdatesql_Click(sender As Object, e As EventArgs) Handles bttambahorder.Click

        If tbbathbeli.Text <> "" And tbfakturbeli.Text <> "" And tbhrgbeli.Text <> "" And tbkodejual.Text <> "" And tbtotbeli.Text <> "" And totalbelitb.Text <> "" Then
            simpanbelom = 0
            c = c + 1
            counter2 = counter2 + tbtotbeli.Text

            Dim hitung As Integer
            hitung = 0
            Dim simpan2 As String
            Dim command As New MySqlCommand("SELECT * FROM tdetail_pembelian ", connect)

            Dim adapter As New MySqlDataAdapter(command)
            Dim datatble1 As New DataTable
            adapter.Fill(datatble1)
            hitung = datatble1.Rows.Count() + 1
            If hitung < 10 Then
                simpan2 = "PB00" + hitung.ToString
                tbidbeli.Text = simpan2
            ElseIf hitung >= 10 And hitung <= 99 Then
                simpan2 = "PB0" + hitung.ToString
                tbidbeli.Text = simpan2
            End If
            Try
                connect.Open()
                Dim command2 As New MySqlCommand("insert into tdetail_pembelian values ('" + tbidbeli.Text + "','" + tbfakturbeli.Text + "','" + tbkodejual.Text + "','" + tbnamabrg.Text + "','" + tbhrgbeli.Text + "','" + Textbox3.Text + "','" + tbbathbeli.Text + "','" + Textbox2.Text + "','" + totalbelitb.Text + "')", connect)
                command2.ExecuteNonQuery()
                MsgBox("sudah di masukan tdetailpembelian")
                connect.Close()
                formpembelian_Load(sender, e)
                Dim command4 As New MySqlCommand("select id_dpembelian,id_barang,nama_barang,harga_beli,diskon,no_batch,expire_date,total_beli from  tdetail_pembelian T where t.no_faktur='" + tbfakturbeli.Text + "'", connect)
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
            Dim hitunghistory As Integer
            Dim historyid As String
            Dim command5 As New MySqlCommand("SELECT * FROM HISTORY ", connect)
            Dim adapter5 As New MySqlDataAdapter(command5)
            Dim datatble15 As New DataTable
            adapter5.Fill(datatble15)
            hitunghistory = datatble15.Rows.Count() + 1
            historyid = "H" + hitunghistory.ToString
            'TextBox2.Text = hitung

            Try
                connect.Open()
                Dim command2 As New MySqlCommand("insert into history (ID_HISTORY,ID_BARANG,NAMA_BARANG,STOK_MASUK,STOK_KELUAR,TGL_HISTORY,owner,keterangan) values('" + historyid + "','" + tbkodejual.Text + "','" + tbnamabrg.Text + "','" + totalbelitb.Text + "','0','" + textbox1.Value.ToString("yyyyMMdd") + "','pembelian','pembelian')", connect)
                command2.ExecuteNonQuery()
                MsgBox("sudah di masukan history")
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try

        Else
            MsgBox("isi data dulu")

        End If

    End Sub

    Private Sub tbfakturbeli_TextChanged(sender As Object, e As EventArgs) Handles tbfakturbeli.TextChanged

    End Sub

    Private Sub tbtotalbeli_TextChanged(sender As Object, e As EventArgs) Handles totalbelitb.TextChanged
        Try
            Dim asa As String
            tbtotbeli.Text = 0
            hitung2 = 0

            hitung2 = totalbelitb.Text * tbhrgbeli.Text
            tbtotbeli.Text = hitung2.ToString
            counter3 = hitung2
            If Textbox3.Text <> "0" Then
                asa = (totalbelitb.Text * tbhrgbeli.Text) * Textbox3.Text / 100
                hitung2 = (totalbelitb.Text * tbhrgbeli.Text) - asa.ToString
                tbtotbeli.Text = hitung2.ToString
            End If
        Catch ex As Exception

        End Try

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
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btbatalbeli_Click(sender As Object, e As EventArgs) Handles btlaporan.Click
        Formreportpembelian.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub tbhrgbeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbhrgbeli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub totalbelitb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles totalbelitb.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class

