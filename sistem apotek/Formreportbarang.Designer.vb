<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formreportbarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomSqlQuery6 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formreportbarang))
        Dim CustomSqlQuery7 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim CustomSqlQuery8 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Me.DocumentViewer1 = New DevExpress.XtraPrinting.Preview.DocumentViewer()
        Me.XtraReport61 = New WindowsApplication1.XtraReport6()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.XtraReport41 = New WindowsApplication1.XtraReport4()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.XtraReport42 = New WindowsApplication1.XtraReport4()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        CType(Me.XtraReport61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraReport41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraReport42, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentViewer1
        '
        Me.DocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentViewer1.DocumentSource = GetType(WindowsApplication1.XtraReport4)
        Me.DocumentViewer1.IsMetric = True
        Me.DocumentViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentViewer1.Name = "DocumentViewer1"
        Me.DocumentViewer1.Size = New System.Drawing.Size(577, 441)
        Me.DocumentViewer1.TabIndex = 0
        '
        'XtraReport61
        '
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ptnagsalaya"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery6.Name = "Query"
        CustomSqlQuery6.Sql = "SELECT * FROM m_pegawai"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery6})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        Me.XtraReport61.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.XtraReport61.DataMember = "Query"
        Me.XtraReport61.DataSource = Me.SqlDataSource1
        Me.XtraReport61.Name = "XtraReport61"
        Me.XtraReport61.PageHeight = 1100
        Me.XtraReport61.PageWidth = 850
        Me.XtraReport61.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.XtraReport61.Version = "17.1"
        '
        'XtraReport41
        '
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ptnagsalaya"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery7.Name = "Query"
        CustomSqlQuery7.Sql = "SELECT * FROM m_barang"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery7})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable1")
        Me.XtraReport41.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.XtraReport41.DataMember = "Query"
        Me.XtraReport41.DataSource = Me.SqlDataSource1
        Me.XtraReport41.Name = "XtraReport41"
        Me.XtraReport41.PageHeight = 1100
        Me.XtraReport41.PageWidth = 850
        Me.XtraReport41.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.XtraReport41.Version = "17.1"
        '
        'XtraReport42
        '
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ptnagsalaya"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery8.Name = "Query"
        CustomSqlQuery8.Sql = "SELECT * FROM m_barang"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery8})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable2")
        Me.XtraReport42.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.XtraReport42.DataMember = "Query"
        Me.XtraReport42.DataSource = Me.SqlDataSource1
        Me.XtraReport42.Name = "XtraReport42"
        Me.XtraReport42.PageHeight = 1100
        Me.XtraReport42.PageWidth = 850
        Me.XtraReport42.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.XtraReport42.Version = "17.1"
        '
        'Formreportbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 441)
        Me.Controls.Add(Me.DocumentViewer1)
        Me.Name = "Formreportbarang"
        Me.Text = "Formreportbarang"
        CType(Me.XtraReport61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraReport41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraReport42, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DocumentViewer1 As DevExpress.XtraPrinting.Preview.DocumentViewer
    Friend WithEvents XtraReport61 As WindowsApplication1.XtraReport6
    Private WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XtraReport41 As WindowsApplication1.XtraReport4
    Friend WithEvents XtraReport42 As WindowsApplication1.XtraReport4
End Class
