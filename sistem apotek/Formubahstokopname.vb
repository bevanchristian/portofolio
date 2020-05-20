Imports MySql.Data.MySqlClient
Public Class formubahstokopname
    Dim connect As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Private Sub formubahstokopname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            btsimpanopname.Enabled = False
            Simplebutton1.Enabled = False
        End If
        If formlogin.tbuser.Text = "gudang" Then
            btsimpanopname.Enabled = True
            Simplebutton1.Enabled = True
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            btsimpanopname.Enabled = False
            Simplebutton1.Enabled = False
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            btsimpanopname.Enabled = False
            Simplebutton1.Enabled = False
        End If



        Dim com3 As New MySqlCommand("select id_stok_opname from stok_opname where `delete`='0' ", connect)
        Dim adapt3 As New MySqlDataAdapter(com3)
        Dim dtbrg As New DataTable
        dtbrg.Clear()
        adapt3.Fill(dtbrg)
        cbidopname.DataSource = dtbrg
        cbidopname.ValueMember = "id_stok_opname"
        cbidopname.DisplayMember = "id_stok_opname"
    End Sub

    Private Sub cbidopname_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbidopname.SelectedValueChanged
        Try


            Dim com32 As New MySqlCommand("select * from stok_opname where id_stok_opname='" + cbidopname.SelectedValue.ToString + "' ", connect)
            Dim adapt32 As New MySqlDataAdapter(com32)
            Dim dtbrg2 As New DataTable

            adapt32.Fill(dtbrg2)
            dtpopname.Text = dtbrg2.Rows(0).Item(1).ToString
            tbnamaopname.Text = dtbrg2.Rows(0).Item(3).ToString
            tbidbrgopname.Text = dtbrg2.Rows(0).Item(2).ToString
            tbawalopname.Text = dtbrg2.Rows(0).Item(4).ToString
            tbakhiropname.Text = dtbrg2.Rows(0).Item(5).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btsimpanopname_Click(sender As Object, e As EventArgs) Handles btsimpanopname.Click
        Try
            connect.Open()
            Dim command2 As New MySqlCommand("update stok_opname set id_barang='" + tbidbrgopname.Text + "',nama_barang='" + tbnamaopname.Text + "',stoke_awal='" + tbawalopname.Text + "',stok_akhir='" + tbakhiropname.Text + "',keterangan='" + tbketerangan.Text + "' where id_stok_opname='" + cbidopname.SelectedValue.ToString + "'", connect)
            command2.ExecuteNonQuery()
            MsgBox("sudah di ubah stok opname")
            connect.Close()
            formubahstokopname_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            connect.Open()
            Dim com4 As New MySqlCommand("update stok_opname set `delete`='1' where id_stok_opname='" + cbidopname.SelectedValue.ToString + "'", connect)
            com4.ExecuteNonQuery()
            connect.Close()
            formubahstokopname_Load(sender, e)
            MsgBox("data dihapus")
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub tbakhiropname_TextChanged(sender As Object, e As EventArgs) Handles tbakhiropname.TextChanged
        Dim hasil As Double
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bttutupopname_Click(sender As Object, e As EventArgs) Handles bttutupopname.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub tbawalopname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbawalopname.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbakhiropname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbakhiropname.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
