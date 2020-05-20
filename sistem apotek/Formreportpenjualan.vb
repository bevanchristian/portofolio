Public Class Formreportpenjualan

    Private Sub Formreportpenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim report As reportpenjualan = New reportpenjualan
            report.DataSource = Form27.tbalepenjulan
            report.DataMember = report.DataMember
            report.CreateDocument(True)
            DocumentViewer1.DocumentSource = report
        Catch ex As Exception

        End Try

    End Sub
End Class