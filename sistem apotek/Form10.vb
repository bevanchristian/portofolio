Imports MySql.Data.MySqlClient
Public Class formstokopname
    Dim con As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya")
    Public awal As String
    Public akhir As String
    Public hasil As Double
    Dim sqlQuery As String

    Public Sub formstokopname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btsimpanopname.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btsimpanopname.Enabled = True
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btsimpanopname.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btsimpanopname.Enabled = False
        End If
        Dim com3 As New MySqlCommand("select id_barang, nama_barang from m_barang where id_barang='" + Formstok.gaestok + "'", con)
        Dim adapt3 As New MySqlDataAdapter(com3)
        Dim dtbrg As New DataTable
        dtbrg.Clear()
        adapt3.Fill(dtbrg)
        cbnamabarangopname.DataSource = dtbrg
        cbnamabarangopname.ValueMember = "id_barang"
        cbnamabarangopname.DisplayMember = "nama_barang"
        tbidbrgopname.Text = Formstok.gaestok

        Try
            sqlQuery = "select stok_akhir from stok_barang where id_barang='" + Formstok.tbidbarangstok.Text + "';"
            Dim com43 As New MySqlCommand(sqlQuery, con)
            Dim adapt43 As New MySqlDataAdapter(com43)
            Dim dt43 As New DataTable
            adapt43.Fill(dt43)
            tbawalopname.Text = dt43.Rows(0).Item(0).ToString
        Catch ex As Exception
        End Try

        If tbketerangan.Text = "" Then
            tbketerangan.Text = "0"
        End If

    End Sub

    Private Sub bttutupopname_Click(sender As Object, e As EventArgs) Handles bttutupopname.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btlaporan_Click(sender As Object, e As EventArgs) Handles btlaporan.Click
        Formreportstokopname.ShowDialog()
    End Sub

    Private Sub cbnamabarangopname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnamabarangopname.SelectedIndexChanged


        Dim count As Integer = 0
        Dim saveidstok As String
        Dim comm As New MySqlCommand("SELECT * FROM stok_opname;", con)
        Dim adapt As New MySqlDataAdapter(comm)
        Dim dt As New DataTable
        adapt.Fill(dt)
        count = dt.Rows.Count() + 1
        saveidstok = "O" + count.ToString
        tbidopname.Text = saveidstok
    End Sub
    Private Sub cbnamabarangopname_Click(sender As Object, e As EventArgs) Handles cbnamabarangopname.Click
        Try
            Dim com3 As New MySqlCommand("select id_barang, nama_barang from m_barang where `delete`='0'", con)
            Dim adapt3 As New MySqlDataAdapter(com3)
            Dim dtbrg As New DataTable
            dtbrg.Clear()
            adapt3.Fill(dtbrg)
            cbnamabarangopname.DataSource = dtbrg
            cbnamabarangopname.ValueMember = "id_barang"
            cbnamabarangopname.DisplayMember = "nama_barang"
        Catch ex As Exception

        End Try
       
    End Sub
    Private Sub tbawalopname_Click(sender As Object, e As EventArgs) Handles tbawalopname.Click
        Dim com43 As New MySqlCommand("select stok_akhir from stok_barang where id_barang='" + tbidbrgopname.Text + "';", con)
        Dim adapt43 As New MySqlDataAdapter(com43)
        Dim dt43 As New DataTable
        adapt43.Fill(dt43)
        tbawalopname.Text = dt43.Rows(0).Item(0).ToString
    End Sub
    Private Sub btsimpanopname_Click(sender As Object, e As EventArgs) Handles btsimpanopname.Click
        If tbakhiropname.Text <> "" And tbawalopname.Text <> "" And tbidbrgopname.Text <> "" And tbidopname.Text <> "" Then
            Try
                con.Open()
                Dim comsim As New MySqlCommand("insert into stok_opname values('" + tbidopname.Text + "','" + dtpopname.Value.ToString("yyyyMMdd") + "','" + tbidbrgopname.Text + "','" + cbnamabarangopname.SelectedValue.ToString + "','" + tbawalopname.Text + "','" + tbakhiropname.Text + "','" + tbketerangan.Text + "','0')", con)
                comsim.ExecuteNonQuery()
                con.Close()
                MsgBox("data sudah masuk")
                formstokopname_Load(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        Else
            MsgBox("isi dahulu data")
        End If

    End Sub
    Private Sub tbakhiropname_TextChanged(sender As Object, e As EventArgs) Handles tbakhiropname.TextChanged

        Try
            If tbakhiropname.Text <> "" Then
                hasil = 0
                hasil = tbakhiropname.Text - tbawalopname.Text
                tampung.Text = hasil.ToString
                If tampung.Text > 0 Then
                    tbketerangan.Text = "kelebihan" + tampung.Text
                ElseIf tampung.Text < 0 Then
                    tbketerangan.Text = "kekurangan" + tampung.Text
                Else
                    tbketerangan.Text = "sesuai"
                End If
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btubahstokopname.Click
        formubahstokopname.ShowDialog()
    End Sub

    Private Sub cbnamabarangopname_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbnamabarangopname.SelectedValueChanged
        Try


            Dim com3 As New MySqlCommand("select id_barang, nama_barang from m_barang where id_barang='" + cbnamabarangopname.SelectedValue.ToString + "'", con)
            Dim adapt3 As New MySqlDataAdapter(com3)
            Dim dtbrg As New DataTable
            dtbrg.Clear()
            adapt3.Fill(dtbrg)
            cbnamabarangopname.DataSource = dtbrg
            cbnamabarangopname.ValueMember = "id_barang"
            cbnamabarangopname.DisplayMember = "nama_barang"
            tbidbrgopname.Text = dtbrg.Rows(0).Item(0).ToString

            sqlQuery = "select stok_akhir from stok_barang where id_barang='" + cbnamabarangopname.SelectedValue.ToString + "';"
            Dim com43 As New MySqlCommand(sqlQuery, con)
            Dim adapt43 As New MySqlDataAdapter(com43)
            Dim dt43 As New DataTable
            adapt43.Fill(dt43)
            tbawalopname.Text = dt43.Rows(0).Item(0).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbawalopname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbawalopname.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbakhiropname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbakhiropname.KeyPress
        'If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
