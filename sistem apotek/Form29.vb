Public Class Form29

    Private Sub Form29_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim report As formreporthistory2 = New formreporthistory2
            report.DataSource = Form28.tbalehistory
            report.DataMember = report.DataMember
            report.CreateDocument(True)
            DocumentViewer1.DocumentSource = report
        Catch ex As Exception

        End Try

    End Sub
End Class