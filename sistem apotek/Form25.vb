Public Class formmenu

    Private Sub btmaster_Click(sender As Object, e As EventArgs) Handles btmaster.Click
        Formmasterdata.ShowDialog()
    End Sub

    Private Sub btransaksi_Click(sender As Object, e As EventArgs) Handles btransaksi.Click
        Formmenutransaksi.ShowDialog()
    End Sub

    Private Sub btreport_Click(sender As Object, e As EventArgs) Handles btreport.Click
        FormLAPORAN.ShowDialog()
    End Sub

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        MsgBox("Yakin Anda Ingin Keluar?", MsgBoxStyle.Exclamation, "Yakin?")
        Close()

    End Sub

    Private Sub formmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class