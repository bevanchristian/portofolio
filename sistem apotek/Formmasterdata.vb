Public Class Formmasterdata

    Private Sub btbarang2_Click(sender As Object, e As EventArgs) Handles btbarang2.Click
        formbarang.ShowDialog()
    End Sub

    Private Sub btgolongan2_Click(sender As Object, e As EventArgs) Handles btgolongan2.Click
        formgolongan.ShowDialog()
    End Sub

    Private Sub btpegawai2_Click(sender As Object, e As EventArgs) Handles btpegawai2.Click
        formpegawai.ShowDialog()
    End Sub

    Private Sub btsupplier2_Click(sender As Object, e As EventArgs) Handles btsupplier2.Click
        formsupplier.ShowDialog()
    End Sub

    Private Sub btcustomer2_Click(sender As Object, e As EventArgs) Handles btcustomer2.Click
        Formcustomer.ShowDialog()
    End Sub

    Private Sub Formmasterdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            lbjabatan.Text = "Direktur"

        ElseIf formlogin.tbuser.Text = "pembelian" Then
            lbjabatan.Text = "Pembelian"
            

        ElseIf formlogin.tbuser.Text = "penjualan" Then
            lbjabatan.Text = "Penjualan"



        ElseIf formlogin.tbuser.Text = "gudang" Then
            lbjabatan.Text = "Gudang"

        End If
    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        MsgBox("Yakin Anda Ingin Keluar?", MsgBoxStyle.Exclamation, "Yakin?")
        Me.Close()
    End Sub
End Class