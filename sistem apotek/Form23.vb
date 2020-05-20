Imports MySql.Data.MySqlClient
Public Class Formhistorypenerimaan
    Dim con As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Private Sub Formhistorypenerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com As New MySqlCommand("select * from detail_penerimaan;", con)
        Dim adaptno As New MySqlDataAdapter(com)
        Dim dtfaktur As New DataTable
        adaptno.Fill(dtfaktur)
        gchistory.DataSource = dtfaktur
    End Sub

    Private Sub btbatalpeg_Click(sender As Object, e As EventArgs) Handles btbatalpeg.Click
        Dim tutup As String
        tutup = MessageBox.Show("APAKAH ANDA YAKIN KELUAR?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If tutup = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class