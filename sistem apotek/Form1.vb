Imports MySql.Data.MySqlClient
Public Class formlogin


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        If tbuser.Text = "direktur" And tbpass.Text = "direktur" Then
            formmenu.ShowDialog()
        ElseIf tbuser.Text = "penjualan" And tbpass.Text = "jual" Then
            formmenu.ShowDialog()
        ElseIf tbuser.Text = "pembelian" And tbpass.Text = "beli" Then
            formmenu.ShowDialog()
        ElseIf tbuser.Text = "gudang" And tbpass.Text = "gudang" Then
            formmenu.ShowDialog()
        Else
            MessageBox.Show("username atau password yang anda input salah", "Informasi", MessageBoxButtons.OK)
         
            formlogin_Load(sender, e)

        End If
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles bttutup.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub lbuser_Click(sender As Object, e As EventArgs) Handles lbuser.Click

    End Sub

    Private Sub formlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbpass.Text = ""
        tbuser.Text = ""
    End Sub
End Class
