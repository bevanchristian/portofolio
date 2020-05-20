Imports MySql.Data.MySqlClient
Public Class Formcustomer
    Dim connect As New MySqlConnection("server=localhost;uid=root;database=ptnagsalaya;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim query As String
    Public id As String
    Public simpan5 As String

    Private Sub Formcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btbatalcust.Enabled = False
            bttambahcust.Enabled = False
            bthapuscust.Enabled = False
            btubahcust.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btbatalcust.Enabled = False
            bttambahcust.Enabled = False
            bthapuscust.Enabled = False
            btubahcust.Enabled = False
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btbatalcust.Enabled = True
            bttambahcust.Enabled = True
            bthapuscust.Enabled = True
            btubahcust.Enabled = True
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btbatalcust.Enabled = False
            bttambahcust.Enabled = False
            bthapuscust.Enabled = False
            btubahcust.Enabled = False
        End If
        Try
            query = "SELECT * FROM m_customer c where `delete`='0'"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            Dim dt As New DataTable
            dt.Clear()
            adapter.Fill(dt)
            GridControl1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tbcaricust_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvcustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcustomer.CellClick
        'Dim command2 As New MySqlCommand("select * from m_customer c where id_customer='" + dgvcustomer.Item(0, dgvcustomer.CurrentRow.Index).Value.ToString + "'", connect)
        'Dim adapter2 As New MySqlDataAdapter(command2)
        'Dim dttable2 As New DataTable
        'adapter2.Fill(dttable2)
        'tbkodecust.Text = dttable2.Rows(0).Item(0).ToString
        'tbnamacust.Text = dttable2.Rows(0).Item(1).ToString
        'tbalamatcust.Text = dttable2.Rows(0).Item(2).ToString
        'tbkotacust.Text = dttable2.Rows(0).Item(3).ToString
        ' tbtelpcust.Text = dttable2.Rows(0).Item(4).ToString
        'id = dgvcustomer.Item(0, dgvcustomer.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub bttambahcust_Click(sender As Object, e As EventArgs) Handles bttambahcust.Click
        If tbnamacust.Text <> "" And tbkotacust.Text <> "" And tbalamatcust.Text <> "" Then
            Try
                connect.Open()
                Dim command3 As New MySqlCommand("insert into m_customer values('" + tbkodecust.Text + "','" + tbnamacust.Text + "','" + tbalamatcust.Text + "','" + tbkotacust.Text + "','" + tbtelpcust.Text + "'," + "'0');", connect)
                command3.ExecuteNonQuery()
                MsgBox("data sudah masuk")
                connect.Close()
                Formcustomer_Load(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
        Else
            MsgBox("isi data dahulu")
        End If

    End Sub

    Private Sub bthapuscust_Click(sender As Object, e As EventArgs) Handles bthapuscust.Click
        Try
            connect.Open()
            Dim command3 As New MySqlCommand("update m_customer set `delete`='1' where id_customer='" + id + "'", connect)
            command3.ExecuteNonQuery()

            MsgBox("data sudah dihapus")
            connect.Close()
            Formcustomer_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub btubahcust_Click(sender As Object, e As EventArgs) Handles btubahcust.Click
        Try
            connect.Open()
            Dim command4 As New MySqlCommand("update  m_customer set id_customer='" + tbkodecust.Text + "',nama_customer='" + tbnamacust.Text + "',alamat_customer='" + tbalamatcust.Text + "',kota_customer='" + tbkotacust.Text + "',notelp_customer='" + tbtelpcust.Text + "' where id_customer='" + id + "'", connect)
            command4.ExecuteNonQuery()

            MsgBox("data sudah diubah")
            connect.Close()
            Formcustomer_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub btbatalcust_Click(sender As Object, e As EventArgs) Handles btbatalcust.Click

    End Sub

    Private Sub btutupcust_Click(sender As Object, e As EventArgs) Handles btutupcust.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btcetak_Click(sender As Object, e As EventArgs)
        formreportcustomer.ShowDialog()
    End Sub

    Private Sub tbkodecust_Click(sender As Object, e As EventArgs) Handles tbkodecust.Click
        Dim hitung As Integer = 0
        Dim command7 As New MySqlCommand("SELECT * FROM m_customer", connect)

        Dim adapter7 As New MySqlDataAdapter(command7)
        Dim datatble7 As New DataTable
        adapter7.Fill(datatble7)
        simpan5 = ""
        hitung = datatble7.Rows.Count() + 1
        If hitung < 10 Then
            simpan5 = "C" + hitung.ToString
            tbkodecust.Text = simpan5.ToString
        ElseIf hitung > 10 Then
            simpan5 = "C" + hitung.ToString
            tbkodecust.Text = simpan5.ToString
        End If
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Dim command2 As New MySqlCommand("select * from m_customer c where id_customer='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim dttable2 As New DataTable
        adapter2.Fill(dttable2)
        tbkodecust.Text = dttable2.Rows(0).Item(0).ToString
        tbnamacust.Text = dttable2.Rows(0).Item(1).ToString
        tbalamatcust.Text = dttable2.Rows(0).Item(2).ToString
        tbkotacust.Text = dttable2.Rows(0).Item(3).ToString
        tbtelpcust.Text = dttable2.Rows(0).Item(4).ToString
        id = GridView1.GetFocusedDataRow(0).ToString
        If formpenjualan.j = 1 Then
            Dim command25 As New MySqlCommand("select * from m_customer c where id_customer='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
            Dim adapter25 As New MySqlDataAdapter(command25)
            Dim dttable25 As New DataTable
            adapter25.Fill(dttable25)
            formpenjualan.tbidcust.Text = dttable25.Rows(0).Item(0).ToString
            Me.Close()
        End If
        If formubahpenjualan.ju = 1 Then
            Dim command255 As New MySqlCommand("select * from m_customer c where id_customer='" + GridView1.GetFocusedDataRow(0).ToString + "'", connect)
            Dim adapter255 As New MySqlDataAdapter(command255)
            Dim dttable255 As New DataTable
            adapter255.Fill(dttable255)
            formubahpenjualan.tbidcust.Text = dttable255.Rows(0).Item(0).ToString
            Me.Close()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class