Imports MySql.Data.MySqlClient
Public Class Formhistory
    Dim con As New MySqlConnection("server=localhost; user id =root; database=ptnagsalaya;convert zero datetime=true")
    Private Sub bttutuphistory_Click(sender As Object, e As EventArgs) Handles bttutuphistory.Click

        Me.Close()
    End Sub

    Private Sub formhistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com1 As New MySqlCommand("select * from history;", con)
        Dim adapt1 As New MySqlDataAdapter(com1)
        Dim dt1 As New DataTable
        adapt1.Fill(dt1)
        gchistory.DataSource = dt1
    End Sub
End Class