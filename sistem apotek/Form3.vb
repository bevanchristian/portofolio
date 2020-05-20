Imports MySql.Data.MySqlClient
Public Class formmenus

    Private Sub formmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "direktur" Then
            lbjabatan.Text = "Direktur"

        ElseIf formlogin.tbuser.Text = "pembelian" Then
            lbjabatan.Text = "Pembelian"
            btpegawai.Enabled = False
            btcustomer.Enabled = False
            btpenjualan.Enabled = False
            btlaporanjual.Enabled = False

        ElseIf formlogin.tbuser.Text = "penjualan" Then
            lbjabatan.Text = "Penjualan"
            btpegawai.Enabled = False
            btsupplier.Enabled = False
            btpembelian.Enabled = False
            btlaporanbeli.Enabled = False

        ElseIf formlogin.tbuser.Text = "gudang" Then
            lbjabatan.Text = "Gudang"
            btpembelian.Enabled = False
            btpenjualan.Enabled = False
            btlaporanbeli.Enabled = False
            btlaporanjual.Enabled = False

        End If
    End Sub

    

    Private Sub btkeluar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

   

   

    Private Sub btpembelian_Click(sender As Object, e As EventArgs) Handles btpembelian.Click
        formpembelian.Show()
    End Sub

    Private Sub btpenjualan_Click(sender As Object, e As EventArgs) Handles btpenjualan.Click
        formpenjualan.show()
    End Sub

    Private Sub btgudang_Click(sender As Object, e As EventArgs) Handles btgudang.Click
        formpenerimaan.Show()
    End Sub

   

    

    Private Sub btlaporanbeli_Click(sender As Object, e As EventArgs) Handles btlaporanbeli.Click

    End Sub

    Private Sub btlaporanjual_Click(sender As Object, e As EventArgs) Handles btlaporanjual.Click

    End Sub

    Private Sub btstok_Click(sender As Object, e As EventArgs) Handles btstok.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lbjabatan_Click(sender As Object, e As EventArgs) Handles lbjabatan.Click

    End Sub

    Private Sub btubahjual_Click(sender As Object, e As EventArgs) Handles btubahjual.Click
        formubahpenjualan.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Formkas.ShowDialog()
    End Sub
End Class