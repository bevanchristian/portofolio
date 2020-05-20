Public Class FormLAPORAN

    Private Sub FormLAPORAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formlogin.tbuser.Text = "gudang" Then
            'btsupplier2.Enabled = False
            'SimpleButton2.Enabled = False
            'SimpleButton3.Enabled = False
            'SimpleButton4.Enabled = False
            btlaporanbeli.Enabled = False
            btlaporanjual.Enabled = False
            btlaporanreturbeli.Enabled = False
            SimpleButton7.Enabled = False
            btlaporankas.Enabled = False
            btlaporanmasterbrg.Enabled = True
            btsupplier2.Enabled = True
            SimpleButton2.Enabled = True
            SimpleButton3.Enabled = True
            SimpleButton4.Enabled = True
            btreportterima.Enabled = True
            btreportstokbrg.Enabled = True
            btreportstokopname.Enabled = True
        End If
        If formlogin.tbuser.Text = "pembelian" Then
            'btsupplier2.Enabled = False
            'SimpleButton2.Enabled = False
            'SimpleButton3.Enabled = False
            'SimpleButton4.Enabled = False
            'btlaporanbeli.Enabled = False
            btlaporanjual.Enabled = False
            'btlaporanreturbeli.Enabled = False
            SimpleButton7.Enabled = False
            btlaporankas.Enabled = False
            btreportstokbrg.Enabled = False
            btreportterima.Enabled = False
            btreportstokopname.Enabled = False
            btlaporanmasterbrg.Enabled = True
            btsupplier2.Enabled = True
            SimpleButton2.Enabled = True
            SimpleButton3.Enabled = True
            SimpleButton4.Enabled = True
            btlaporanbeli.Enabled = True
            btlaporanreturbeli.Enabled = True
        End If
        If formlogin.tbuser.Text = "penjualan" Then
            'btsupplier2.Enabled = False
            'SimpleButton2.Enabled = False
            'SimpleButton3.Enabled = False
            'SimpleButton4.Enabled = False
            btlaporanbeli.Enabled = False
            'btlaporanjual.Enabled = False
            btlaporanreturbeli.Enabled = False
            'SimpleButton7.Enabled = False
            btlaporankas.Enabled = False
            btreportstokbrg.Enabled = False
            btreportterima.Enabled = False
            btreportstokopname.Enabled = False
            btlaporanmasterbrg.Enabled = True
            btsupplier2.Enabled = True
            SimpleButton2.Enabled = True
            SimpleButton3.Enabled = True
            SimpleButton4.Enabled = True
            btlaporanjual.Enabled = True
            SimpleButton7.Enabled = True
        End If
    End Sub

    Private Sub btlaporanmasterbrg_Click(sender As Object, e As EventArgs) Handles btlaporanmasterbrg.Click
        formreportmasterbarang.ShowDialog()
    End Sub

    Private Sub btsupplier2_Click(sender As Object, e As EventArgs) Handles btsupplier2.Click
        Formreportsupplier.ShowDialog()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        formreportcustomer.ShowDialog()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Formgolonganreport.ShowDialog()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Formpegawaireport.ShowDialog()
    End Sub

    Private Sub btlaporanbeli_Click(sender As Object, e As EventArgs) Handles btlaporanbeli.Click
        Form26.ShowDialog()
    End Sub

    Private Sub btlaporanjual_Click(sender As Object, e As EventArgs) Handles btlaporanjual.Click
        Form27.ShowDialog()
    End Sub

    Private Sub btlaporanreturbeli_Click(sender As Object, e As EventArgs) Handles btlaporanreturbeli.Click
        Formreportreturbeli.ShowDialog()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Formreportreturpenjualan.ShowDialog()
    End Sub

    Private Sub btreportterima_Click(sender As Object, e As EventArgs) Handles btreportterima.Click
        Form30.ShowDialog()
    End Sub

    
    Private Sub btreportstokbrg_Click(sender As Object, e As EventArgs) Handles btreportstokbrg.Click
        Formreportstok.ShowDialog()
    End Sub

    Private Sub btreportstokopname_Click(sender As Object, e As EventArgs) Handles btreportstokopname.Click
        Formreportstokopname.ShowDialog()
    End Sub

    Private Sub btlaporankas_Click(sender As Object, e As EventArgs) Handles btlaporankas.Click
        Formkas.ShowDialog()
    End Sub

    Private Sub bthistory_Click(sender As Object, e As EventArgs) Handles bthistory.Click
        Form28.ShowDialog()
    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class