Public Class Formreportpenerimaanvb

    Private Sub Formreportpenerimaanvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim report As reportpenerimaan = New reportpenerimaan
            report.DataSource = Form30.tbalpenerimaan
            report.DataMember = report.DataMember
            report.CreateDocument(True)
            DocumentViewer1.DocumentSource = report
        Catch ex As Exception

        End Try

    End Sub
End Class