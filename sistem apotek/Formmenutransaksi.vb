Public Class Formmenutransaksi

    Private Sub btpembelian_Click(sender As Object, e As EventArgs) Handles btpembelian.Click
        formpembelian.ShowDialog()
    End Sub

    Private Sub btpenjualan_Click(sender As Object, e As EventArgs) Handles btpenjualan.Click
        formpenjualan.ShowDialog()
    End Sub

    Private Sub btgudang_Click(sender As Object, e As EventArgs) Handles btgudang.Click
        formpenerimaan.ShowDialog()
    End Sub

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        MsgBox("Yakin Anda Ingin Keluar?", MsgBoxStyle.Exclamation, "Yakin?")
        Close()
    End Sub

    Private Sub Formmenutransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "pembelian" Then
            btpenjualan.Enabled = False
            btgudang.Enabled = False
            btpembelian.Enabled = True
        ElseIf formlogin.tbuser.Text = "penjualan" Then
            btpembelian.Enabled = False
            btgudang.Enabled = False
            btpenjualan.Enabled = True
        ElseIf formlogin.tbuser.Text = "gudang" Then
            btpembelian.Enabled = False
            btpenjualan.Enabled = False
            btgudang.Enabled = True
        ElseIf formlogin.tbuser.Text = "direktur" Then
            btpembelian.Enabled = True
            btpenjualan.Enabled = True
            btgudang.Enabled = True
        End If

    End Sub
End Class