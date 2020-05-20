Imports MySql.Data.MySqlClient
Public Class formsupplier
    Dim connect As New MySqlConnection("server=localhost;uid=root;database=ptnagsalaya;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim id As String
    Public simpan5 As String

    Private Sub formsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            bttambahsup.Enabled = False
            btbatalsup.Enabled = False
            bthapussup.Enabled = False
            btubahsup.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            bttambahsup.Enabled = True
            btbatalsup.Enabled = True
            bthapussup.Enabled = True
            btubahsup.Enabled = True
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            bttambahsup.Enabled = False
            btbatalsup.Enabled = False
            bthapussup.Enabled = False
            btubahsup.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            bttambahsup.Enabled = False
            btbatalsup.Enabled = False
            bthapussup.Enabled = False
            btubahsup.Enabled = False
        End If
        dt.Clear()

        Try
            id = "SELECT * FROM m_supplier where `delete`='0'"
            command = New MySqlCommand(id, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            GridControl1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvsupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsupplier.CellClick
        'Dim command2 As New MySqlCommand("select * from m_supplier where id_supplier='" + dgvsupplier.Item(0, dgvsupplier.CurrentRow.Index).Value.ToString + "'", connect)
        'Dim adapter2 As New MySqlDataAdapter(command2)
        'Dim dt2 As New DataTable
        'adapter2.Fill(dt2)
        'tbkodesup.Text = dt2.Rows(0).Item(0).ToString
        'tbnamasup.Text = dt2.Rows(0).Item(1).ToString
        'tbalamatsup.Text = dt2.Rows(0).Item(2).ToString
        'tbkotasup.Text = dt2.Rows(0).Item(3).ToString
        'tbtelpsup.Text = dt2.Rows(0).Item(4).ToString
        'id = dgvsupplier.Item(0, dgvsupplier.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub bttambahsup_Click(sender As Object, e As EventArgs) Handles bttambahsup.Click
        If tbnamasup.Text <> "" And tbnamasup.Text <> "" And tbkotasup.Text <> "" Then
            Try
                connect.Open()
                Dim command3 As New MySqlCommand("insert into m_supplier values('" + tbkodesup.Text + "','" + tbnamasup.Text + "','" + tbalamatsup.Text + "','" + tbkotasup.Text + "','" + tbtelpsup.Text + "','0')", connect)
                command3.ExecuteNonQuery()
                MsgBox("Data Telah Masuk")
                connect.Close()
                formsupplier_Load(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
        Else
            MsgBox("isi data dahulu")
        End If

    End Sub

    Private Sub btubahsup_Click(sender As Object, e As EventArgs) Handles btubahsup.Click
        Try
            connect.Open()
            Dim command4 As New MySqlCommand("update m_supplier set id_supplier='" + tbkodesup.Text + "',nama_supplier='" + tbnamasup.Text + "',alamat_supplier='" + tbalamatsup.Text + "',kota_supplier='" + tbkotasup.Text + "' where id_supplier='" + id + "'", connect)
            command4.ExecuteNonQuery()
            MsgBox("Data Sudah Diubah")
            connect.Close()
            formsupplier_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub bthapussup_Click(sender As Object, e As EventArgs) Handles bthapussup.Click
        Try
            connect.Open()
            Dim command5 As New MySqlCommand("update m_supplier set `delete`='1' where id_supplier='" + id + "'", connect)
            command5.ExecuteNonQuery()
            MsgBox("Data Telah Dihapus")
            connect.Close()
            formsupplier_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub bttutupsup_Click(sender As Object, e As EventArgs) Handles bttutupsup.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Formreportsupplier.ShowDialog()
    End Sub

    Private Sub tbkodesup_Click(sender As Object, e As EventArgs) Handles tbkodesup.Click
        Dim hitung As Integer = 0
        Dim command7 As New MySqlCommand("SELECT * FROM m_supplier", connect)

        Dim adapter7 As New MySqlDataAdapter(command7)
        Dim datatble7 As New DataTable
        adapter7.Fill(datatble7)
        simpan5 = ""
        hitung = datatble7.Rows.Count() + 1
        If hitung < 10 Then
            simpan5 = "SP" + hitung.ToString
            tbkodesup.Text = simpan5.ToString
        ElseIf hitung > 10 Then
            simpan5 = "SP" + hitung.ToString
            tbkodesup.Text = simpan5.ToString
        End If
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Dim command2 As New MySqlCommand("select * from m_supplier where id_supplier='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim dt2 As New DataTable
        adapter2.Fill(dt2)
        tbkodesup.Text = dt2.Rows(0).Item(0).ToString
        tbnamasup.Text = dt2.Rows(0).Item(1).ToString
        tbalamatsup.Text = dt2.Rows(0).Item(2).ToString
        tbkotasup.Text = dt2.Rows(0).Item(3).ToString
        tbtelpsup.Text = dt2.Rows(0).Item(4).ToString
        id = GridView1.GetFocusedDataRow(0).ToString
        If formpembelian.b = 1 Then
            Dim command22 As New MySqlCommand("select * from m_supplier where id_supplier='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
            Dim adapter22 As New MySqlDataAdapter(command22)
            Dim dt22 As New DataTable
            adapter2.Fill(dt22)
            formpembelian.tbkodesup.Text = dt22.Rows(0).Item(0).ToString
            Me.Close()
        End If
        If Form15.b = 1 Then
            Dim command22 As New MySqlCommand("select * from m_supplier where id_supplier='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
            Dim adapter22 As New MySqlDataAdapter(command22)
            Dim dt22 As New DataTable
            adapter2.Fill(dt22)
            Form15.tbkodesup.Text = dt22.Rows(0).Item(0).ToString
            Me.Close()
        End If
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub tbkodesup_TextChanged(sender As Object, e As EventArgs) Handles tbkodesup.TextChanged

    End Sub
End Class
