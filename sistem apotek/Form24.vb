Imports MySql.Data.MySqlClient
Public Class formubahstok
    Dim con As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Public masuk As String
    Public keluar As String
    Public hasil As String
    Dim dtdgv As New DataTable
    Public nama As String

    Private Sub dgvubahterima_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvubahstok.CellContentClick

    End Sub
    Private Sub btutupterima_Click(sender As Object, e As EventArgs) Handles bttutupubahstok.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btubahpenerimaan_Click(sender As Object, e As EventArgs) Handles btubahstok.Click
        If tbidbrgubahstok.Text <> "" And tbidubahstok.Text <> "" Then
            If rblebih.Checked = True Then
                keluar = ""
                Dim com3 As New MySqlCommand("select sum(stok_keluar+'" + tbkeluarubah.Text + "') from stok_barang where id_stok='" + tbidubahstok.Text + "'", con)
                Dim adapt3 As New MySqlDataAdapter(com3)
                Dim dt3 As New DataTable
                adapt3.Fill(dt3)
                keluar = dt3.Rows(0).Item(0).ToString

                Try
                    con.Open()
                    Dim com1 As New MySqlCommand("update stok_barang set stok_keluar = '" + keluar + "' where id_stok= '" + tbidubahstok.Text + "';", con)
                    com1.ExecuteNonQuery()
                    MsgBox("data sudah masuk")
                    con.Close()
                    'formubahstok_Load(sender, e)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    con.Close()
                End Try
                Dim a As String = ""
                Dim com7 As New MySqlCommand("select sum(stok_masuk-stok_keluar) from stok_barang where id_stok='" + tbidubahstok.Text + "';", con)
                Dim adapt7 As New MySqlDataAdapter(com7)
                Dim dt7 As New DataTable
                adapt7.Fill(dt7)
                a = dt7.Rows(0).Item(0).ToString
                tbakhirubah.Text = a

                Try
                    con.Open()
                    Dim com1 As New MySqlCommand("update stok_barang set stok_akhir= '" + a + "' where id_stok= '" + tbidubahstok.Text + "';", con)
                    com1.ExecuteNonQuery()
                    MsgBox("data sudah masuk")
                    con.Close()
                    'formubahstok_Load(sender, e)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    con.Close()
                End Try

                Dim count As Integer = 0
                Dim saveidhistory As String
                Dim comm As New MySqlCommand("SELECT * FROM history;", con)
                Dim adapt As New MySqlDataAdapter(comm)
                Dim dt As New DataTable
                adapt.Fill(dt)
                count = dt.Rows.Count() + 1
                saveidhistory = "H" + count.ToString

                Try
                    con.Open()
                    Dim com4 As New MySqlCommand("insert into history values('" + saveidhistory + "','" + tbidbrgubahstok.Text + "','" + nama + "','" + keluar + "','0','" + dtpubahstok.Value.ToString("yyyyMMdd") + "','gudang','kelebihan')", con)
                    com4.ExecuteNonQuery()
                    con.Close()
                    formubahstok_Load(sender, e)
                    MsgBox("masuk history")
                Catch ex As Exception
                    MsgBox(ex.Message)
                    con.Close()
                End Try

            ElseIf rbkurang.Checked = True Then
                keluar = ""
                Dim com3 As New MySqlCommand("select sum(stok_masuk+'" + tbmasukubah.Text + "') from stok_barang where id_stok='" + tbidubahstok.Text + "'", con)
                Dim adapt3 As New MySqlDataAdapter(com3)
                Dim dt3 As New DataTable
                adapt3.Fill(dt3)
                keluar = dt3.Rows(0).Item(0).ToString

                Try
                    con.Open()
                    Dim com1 As New MySqlCommand("update stok_barang set stok_masuk = '" + keluar + "' where id_stok= '" + tbidubahstok.Text + "';", con)
                    com1.ExecuteNonQuery()
                    MsgBox("data sudah masuk")
                    con.Close()
                    'formubahstok_Load(sender, e)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    con.Close()
                End Try
                Dim b As String
                Dim com7 As New MySqlCommand("select sum(stok_masuk-stok_keluar) from stok_barang where id_stok='" + tbidubahstok.Text + "';", con)
                Dim adapt7 As New MySqlDataAdapter(com7)
                Dim dt7 As New DataTable
                adapt7.Fill(dt7)
                b = dt7.Rows(0).Item(0).ToString
                tbakhirubah.Text = b

                Try
                    con.Open()
                    Dim com1 As New MySqlCommand("update stok_barang set stok_akhir= '" + b + "' where id_stok= '" + tbidubahstok.Text + "';", con)
                    com1.ExecuteNonQuery()
                    MsgBox("data sudah masuk")
                    con.Close()
                    'formubahstok_Load(sender, e)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    con.Close()
                End Try

                Dim count As Integer = 0
                Dim saveidhistory As String
                Dim comm As New MySqlCommand("SELECT * FROM history;", con)
                Dim adapt As New MySqlDataAdapter(comm)
                Dim dt As New DataTable
                adapt.Fill(dt)
                count = dt.Rows.Count() + 1
                saveidhistory = "H" + count.ToString


                Try
                    con.Open()
                    Dim com4 As New MySqlCommand("insert into history values('" + saveidhistory + "','" + tbidbrgubahstok.Text + "','" + nama + "','" + keluar + "','0','" + dtpubahstok.Value.ToString("yyyyMMdd") + "','gudang','kekurangan')", con)
                    com4.ExecuteNonQuery()
                    con.Close()
                    formubahstok_Load(sender, e)
                    MsgBox("masuk history")
                Catch ex As Exception
                    MsgBox(ex.Message)
                    con.Close()
                End Try
            End If
        Else
            MsgBox("isi dahulu data")
        End If

    End Sub
    Private Sub formubahstok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btubahstok.Enabled = False
            Button1.Enabled = False
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btubahstok.Enabled = False
            Button1.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btubahstok.Enabled = False
            Button1.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btubahstok.Enabled = True
            Button1.Enabled = True
        End If
        Dim command As New MySqlCommand("select id_barang, nama_barang, stok_masuk, stok_keluar, stok_akhir from stok_barang where `delete`='0'", con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim dt2 As New DataTable
        adapter.Fill(dt2)
        GridControl1.DataSource = dt2
        GridView1.PopulateColumns()


        Dim com2 As New MySqlCommand("select id_barang,nama_barang from m_barang where`delete`='0';", con)
        Dim adap2 As New MySqlDataAdapter(com2)
        Dim dtbrg As New DataTable
        adap2.Fill(dtbrg)
        cbnamabrgubahstok.DataSource = dtbrg
        cbnamabrgubahstok.DisplayMember = "nama_barang"
        cbnamabrgubahstok.ValueMember = "id_barang"

    End Sub
    Private Sub cbnamabrgubah_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnamabrgubahstok.SelectedIndexChanged
        nama = ""
        Try
            Dim com As New MySqlCommand("select id_barang, nama_barang, id_stok from stok_barang where id_barang= '" + cbnamabrgubahstok.SelectedValue.ToString + "'", con)
            Dim adapt As New MySqlDataAdapter(com)
            Dim dtbrg As New DataTable
            adapt.Fill(dtbrg)
            'cbnamabrgubah.DataSource = dtbrg
            'cbnamabrgubah.ValueMember = "id_barang"
            'cbnamabrgubah.DisplayMember = "nama_barang"
            tbidubahstok.Text = dtbrg.Rows(0).Item(2).ToString
            tbidbrgubahstok.Text = dtbrg.Rows(0).Item(0).ToString
            nama = dtbrg.Rows(0).Item(1).ToString
        Catch ex As Exception

        End Try
    End Sub
    Private Sub rblebih_CheckedChanged(sender As Object, e As EventArgs) Handles rblebih.CheckedChanged
        lbkluar.Visible = True
        tbkeluarubah.Visible = True
        lbmsk.Visible = False
        tbmasukubah.Visible = False
    End Sub

    Private Sub rbkurang_CheckedChanged(sender As Object, e As EventArgs) Handles rbkurang.CheckedChanged
        lbmsk.Visible = True
        tbmasukubah.Visible = True
        lbkluar.Visible = False
        tbkeluarubah.Visible = False
    End Sub



    Private Sub tbmasukubah_TextChanged(sender As Object, e As EventArgs) Handles tbmasukubah.TextChanged
        keluar = ""
        Dim com3 As New MySqlCommand("select sum(stok_masuk+'" + tbmasukubah.Text + "') from stok_barang where id_stok='" + tbidubahstok.Text + "'", con)
        Dim adapt3 As New MySqlDataAdapter(com3)
        Dim dt3 As New DataTable
        adapt3.Fill(dt3)
        keluar = dt3.Rows(0).Item(0).ToString


        Dim b As String
        Dim com7 As New MySqlCommand("select sum('" + keluar + "'-stok_keluar) from stok_barang where id_stok='" + tbidubahstok.Text + "';", con)
        Dim adapt7 As New MySqlDataAdapter(com7)
        Dim dt7 As New DataTable
        adapt7.Fill(dt7)
        b = dt7.Rows(0).Item(0).ToString

        tbakhirubah.Text = b.ToString

    End Sub

    Private Sub tbkeluarubah_TextChanged(sender As Object, e As EventArgs) Handles tbkeluarubah.TextChanged
        keluar = ""
        Dim com3 As New MySqlCommand("select sum(stok_keluar+'" + tbkeluarubah.Text + "') from stok_barang where id_stok='" + tbidubahstok.Text + "'", con)
        Dim adapt3 As New MySqlDataAdapter(com3)
        Dim dt3 As New DataTable
        adapt3.Fill(dt3)
        keluar = dt3.Rows(0).Item(0).ToString


        Dim b As String
        b = ""
        Dim com7 As New MySqlCommand("select sum(stok_masuk-'" + keluar + "') from stok_barang where id_stok='" + tbidubahstok.Text + "';", con)
        Dim adapt7 As New MySqlDataAdapter(com7)
        Dim dt7 As New DataTable
        adapt7.Fill(dt7)
        b = dt7.Rows(0).Item(0).ToString

        tbakhirubah.Text = b.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.Open()
            Dim com4 As New MySqlCommand("update stok_barang set `delete`='1' where id_barang='" + tbidbrgubahstok.Text + "'", con)
            com4.ExecuteNonQuery()
            con.Close()
            formubahstok_Load(sender, e)
            MsgBox("data dihapus")
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

        Try
            con.Open()
            Dim com42 As New MySqlCommand("update m_barang set `delete`='1' where id_barang='" + tbidbrgubahstok.Text + "'", con)
            com42.ExecuteNonQuery()
            con.Close()
            formubahstok_Load(sender, e)
            MsgBox("data dihapus di master")
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub tbmasukubah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbmasukubah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbkeluarubah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbkeluarubah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbakhirubah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbakhirubah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
