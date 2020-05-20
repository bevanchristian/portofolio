Imports MySql.Data.MySqlClient

Public Class formpegawai
    Dim connect As New MySqlConnection("server=localhost;uid=root;database=ptnagsalaya;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim query As String
    Public id As String
    Public simpan5 As String

    Private Sub formpegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btbatalpeg.Enabled = True
            bthapuspeg.Enabled = True
            bttambahpeg.Enabled = True
            btubahpeg.Enabled = True
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btbatalpeg.Enabled = False
            bthapuspeg.Enabled = False
            bttambahpeg.Enabled = False
            btubahpeg.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btbatalpeg.Enabled = False
            bthapuspeg.Enabled = False
            bttambahpeg.Enabled = False
            btubahpeg.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btbatalpeg.Enabled = False
            bthapuspeg.Enabled = False
            bttambahpeg.Enabled = False
            btubahpeg.Enabled = False
        End If
        Try
            query = "SELECT * FROM m_pegawai p where `delete`='0'"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            Dim dt As New DataTable
            dt.Clear()
            adapter.Fill(dt)
            GridControl1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bttambahpeg_Click(sender As Object, e As EventArgs)
      

    End Sub

    Private Sub bttutuppeg_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub dgvpegawai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpegawai.CellClick
        'Dim command2 As New MySqlCommand("select * from m_pegawai p where id_pegawai='" + dgvpegawai.Item(0, dgvpegawai.CurrentRow.Index).Value.ToString + "'", connect)
        'Dim adapter2 As New MySqlDataAdapter(command2)
        'Dim dttable2 As New DataTable
        'adapter2.Fill(dttable2)
        'tbidpeg.Text = dttable2.Rows(0).Item(0).ToString
        'tbnamapeg.Text = dttable2.Rows(0).Item(1).ToString
        'tbjabatanpeg.Text = dttable2.Rows(0).Item(2).ToString
        'tbalamatpeg.Text = dttable2.Rows(0).Item(3).ToString
        'tbkotapeg.Text = dttable2.Rows(0).Item(4).ToString
        'tbtelppeg.Text = dttable2.Rows(0).Item(5).ToString
        'id = dgvpegawai.Item(0, dgvpegawai.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub btubahpeg_Click(sender As Object, e As EventArgs) Handles btubahpeg.Click
        Try
            connect.Open()
            Dim command4 As New MySqlCommand("update  m_pegawai set id_pegawai='" + tbidpeg.Text + "',nama_pegawai='" + tbnamapeg.Text + "',jabatan_pegawai='" + tbjabatanpeg.Text + "',alamat_pegawai='" + tbalamatpeg.Text + "',kota_pegawai='" + tbkotapeg.Text + "',notelp_pegawai='" + tbtelppeg.Text + "' where id_pegawai='" + id + "'", connect)
            command4.ExecuteNonQuery()

            MsgBox("data sudah diubah")
            connect.Close()
            formpegawai_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub btbatalpeg_Click(sender As Object, e As EventArgs) Handles btbatalpeg.Click

    End Sub

    Private Sub bthapuspeg_Click(sender As Object, e As EventArgs)
        Try
            connect.Open()
            Dim command3 As New MySqlCommand("update m_pegawai set `delete`='1' where id_pegawai='" + id + "'", connect)
            command3.ExecuteNonQuery()

            MsgBox("data sudah dihapus")
            connect.Close()
            formpegawai_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub bttutuppeg_Click_1(sender As Object, e As EventArgs) Handles bttutuppeg.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Formpegawaireport.ShowDialog()
    End Sub

    Private Sub tbidpeg_Click(sender As Object, e As EventArgs) Handles tbidpeg.Click
        Dim hitung As Integer = 0
        Dim command7 As New MySqlCommand("SELECT * FROM m_pegawai", connect)

        Dim adapter7 As New MySqlDataAdapter(command7)
        Dim datatble7 As New DataTable
        adapter7.Fill(datatble7)
        simpan5 = ""
        hitung = datatble7.Rows.Count() + 1
        If hitung < 10 Then
            simpan5 = "PG00" + hitung.ToString
            tbidpeg.Text = simpan5.ToString
        ElseIf hitung > 10 Then
            simpan5 = "PG0" + hitung.ToString
            tbidpeg.Text = simpan5.ToString
        End If
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Dim command2 As New MySqlCommand("select * from m_pegawai p where id_pegawai='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim dttable2 As New DataTable
        adapter2.Fill(dttable2)
        tbidpeg.Text = dttable2.Rows(0).Item(0).ToString
        tbnamapeg.Text = dttable2.Rows(0).Item(1).ToString
        tbjabatanpeg.Text = dttable2.Rows(0).Item(2).ToString
        tbalamatpeg.Text = dttable2.Rows(0).Item(3).ToString
        tbkotapeg.Text = dttable2.Rows(0).Item(4).ToString
        tbtelppeg.Text = dttable2.Rows(0).Item(5).ToString
        id = GridView1.GetFocusedDataRow(0).ToString
    End Sub

    Private Sub bttambahpeg_Click_1(sender As Object, e As EventArgs) Handles bttambahpeg.Click
        If tbnamapeg.Text <> "" And tbkotapeg.Text <> "" And tbalamatpeg.Text <> "" And tbjabatanpeg.Text <> "" And tbtelppeg.Text <> "" Then
            Try
                connect.Open()
                Dim command3 As New MySqlCommand("insert into m_pegawai values ('" + tbidpeg.Text + "','" + tbnamapeg.Text + "','" + tbjabatanpeg.Text + "','" + tbalamatpeg.Text + "','" + tbkotapeg.Text + "','" + tbtelppeg.Text + "','0');", connect)
                command3.ExecuteNonQuery()
                MsgBox("data sudah masuk")
                connect.Close()
                formpegawai_Load(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
        Else
            MsgBox("isi dahulu data")
        End If

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub bthapuspeg_Click_1(sender As Object, e As EventArgs) Handles bthapuspeg.Click
        Try
            connect.Open()
            Dim command5 As New MySqlCommand("update m_pegawai set `delete`='1' where id_pegawai='" + id + "'", connect)
            command5.ExecuteNonQuery()
            MsgBox("Data Telah Dihapus")
            connect.Close()
            formpegawai_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub
End Class