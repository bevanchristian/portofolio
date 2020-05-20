Public Class Formreportpembelian

    Private Sub Formreportpembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim report As reportpembelian = New reportpembelian
            report.DataSource = Form26.tbalepembelian
            report.DataMember = report.DataMember
            report.CreateDocument(True)
            DocumentViewer1.DocumentSource = report
        Catch ex As Exception

        End Try

    End Sub
End Class