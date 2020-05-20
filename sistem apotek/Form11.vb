Imports MySql.Data.MySqlClient

Public Class formgolongan
    Dim connect As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya")
    Public id As String
    Public simpan5 As String

    Private Sub bttutupgolongan_Click(sender As Object, e As EventArgs) Handles bttutupgol.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub formgolongan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand("select id_golongan as 'id golongan',nama_golongan as 'nama golongan',`delete` from m_golongan m where `delete`='0'", connect)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatble1 As New DataTable
        datatble1.Clear()
        adapter.Fill(datatble1)
        GridControl1.DataSource = datatble1

        If formlogin.tbuser.Text = "direktur" Then
            btbatalgol.Enabled = False
            bthapusgol.Enabled = False
            bttambahgol.Enabled = False
            btubahgol.Enabled = False
        End If

        If formlogin.tbuser.Text = "penjualan" Then
            btbatalgol.Enabled = False
            bthapusgol.Enabled = False
            bttambahgol.Enabled = False
            btubahgol.Enabled = False
        End If

        If formlogin.tbuser.Text = "gudang" Then
            btbatalgol.Enabled = False
            bthapusgol.Enabled = False
            bttambahgol.Enabled = False
            btubahgol.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btbatalgol.Enabled = False
            bthapusgol.Enabled = False
            bttambahgol.Enabled = False
            btubahgol.Enabled = False
        End If
    End Sub

    Private Sub bttambahgol_Click(sender As Object, e As EventArgs) Handles bttambahgol.Click
        If tbnamagol.Text <> "" Then

            Try
                connect.Open()
                Dim command3 As New MySqlCommand("insert into m_golongan(id_golongan,nama_golongan) values('" + tbidgol.Text + "','" + tbnamagol.Text + "')", connect)
                command3.ExecuteNonQuery()
                MsgBox("data sudah masuk")
                connect.Close()
                formgolongan_Load(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
        Else
            MsgBox("isi dahulu data")
        End If


    End Sub

    Private Sub dgvbarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellClick
        'Dim command2 As New MySqlCommand("select *from m_golongan where  id_golongan='" + dgvbarang.Item(0, dgvbarang.CurrentRow.Index).Value.ToString + "'", connect)
        ' Dim adapter2 As New MySqlDataAdapter(command2)
        'Dim dttable2 As New DataTable
        'adapter2.Fill(dttable2)
        'tbidgol.Text = dttable2.Rows(0).Item(0).ToString
        'tbnamagol.Text = dttable2.Rows(0).Item(1).ToString
        'id = dgvbarang.Item(0, dgvbarang.CurrentRow.Index).Value.ToString

    End Sub

    Private Sub bthapusgol_Click(sender As Object, e As EventArgs) Handles bthapusgol.Click
        Try
            connect.Open()
            Dim command3 As New MySqlCommand("update  m_golongan set `delete`='1' where id_golongan='" + id + "'", connect)
            command3.ExecuteNonQuery()

            MsgBox("data sudah dihapus")
            connect.Close()
            formgolongan_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

    End Sub

    Private Sub btubahgol_Click(sender As Object, e As EventArgs) Handles btubahgol.Click
        Try
            connect.Open()
            Dim command4 As New MySqlCommand("update  m_golongan set id_golongan='" + tbidgol.Text + "',nama_golongan='" + tbnamagol.Text + "' where id_golongan='" + id + "'", connect)
            command4.ExecuteNonQuery()

            MsgBox("data sudah diubah")
            connect.Close()
            formgolongan_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Formgolonganreport.ShowDialog()
    End Sub

    Private Sub tbidgol_Click(sender As Object, e As EventArgs) Handles tbidgol.Click
        Dim hitung As Integer = 0
        Dim command7 As New MySqlCommand("SELECT * FROM m_golongan", connect)

        Dim adapter7 As New MySqlDataAdapter(command7)
        Dim datatble7 As New DataTable
        adapter7.Fill(datatble7)
        simpan5 = ""
        hitung = datatble7.Rows.Count() + 1
        If hitung < 10 Then
            simpan5 = "G0" + hitung.ToString
            tbidgol.Text = simpan5.ToString
        ElseIf hitung > 10 Then
            simpan5 = "G" + hitung.ToString
            tbidgol.Text = simpan5.ToString
        End If
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Dim command2 As New MySqlCommand("select *from m_golongan where  id_golongan='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim dttable2 As New DataTable
        adapter2.Fill(dttable2)
        tbidgol.Text = dttable2.Rows(0).Item(0).ToString
        tbnamagol.Text = dttable2.Rows(0).Item(1).ToString
        id = GridView1.GetFocusedDataRow(0).ToString
    End Sub
End Class
