<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim CustomSqlQuery3 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form17))
        Me.DocumentViewer1 = New DevExpress.XtraPrinting.Preview.DocumentViewer()
        ' Me.XtraReport21 = New WindowsApplication1.XtraReport2()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        ' Me.XtraReport22 = New WindowsApplication1.XtraReport2()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        'Me.XtraReport23 = New WindowsApplication1.XtraReport2()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        CType(Me.XtraReport21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraReport22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraReport23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentViewer1
        '
        Me.DocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentViewer1.DocumentSource = Me.XtraReport23
        Me.DocumentViewer1.IsMetric = True
        Me.DocumentViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentViewer1.Name = "DocumentViewer1"
        Me.DocumentViewer1.Size = New System.Drawing.Size(656, 529)
        Me.DocumentViewer1.TabIndex = 0
        '
        'XtraReport21
        '
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ptnagsalaya"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery2.Name = "Query"
        CustomSqlQuery2.Sql = "SELECT * FROM stok_barang"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable1")
        Me.XtraReport21.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.XtraReport21.DataMember = "Query"
        Me.XtraReport21.DataSource = Me.SqlDataSource1
        Me.XtraReport21.Name = "XtraReport21"
        Me.XtraReport21.PageHeight = 1100
        Me.XtraReport21.PageWidth = 850
        Me.XtraReport21.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.XtraReport21.Version = "17.1"
        '
        'XtraReport22
        '
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ptnagsalaya"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery3.Name = "Query"
        CustomSqlQuery3.Sql = "SELECT * FROM stok_barang"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery3})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable2")
        Me.XtraReport22.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.XtraReport22.DataMember = "Query"
        Me.XtraReport22.DataSource = Me.SqlDataSource1
        Me.XtraReport22.Name = "XtraReport22"
        Me.XtraReport22.PageHeight = 1100
        Me.XtraReport22.PageWidth = 850
        Me.XtraReport22.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.XtraReport22.Version = "17.1"
        '
        'XtraReport23
        '
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ptnagsalaya"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Query"
        CustomSqlQuery1.Sql = "SELECT * FROM stok_barang"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        Me.XtraReport23.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.XtraReport23.DataMember = "Query"
        Me.XtraReport23.DataSource = Me.SqlDataSource1
        Me.XtraReport23.Name = "XtraReport23"
        Me.XtraReport23.PageHeight = 1100
        Me.XtraReport23.PageWidth = 850
        Me.XtraReport23.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.XtraReport23.Version = "17.1"
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 529)
        Me.Controls.Add(Me.DocumentViewer1)
        Me.Name = "Form17"
        Me.Text = "Form17"
        CType(Me.XtraReport21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraReport22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraReport23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DocumentViewer1 As DevExpress.XtraPrinting.Preview.DocumentViewer
    Friend WithEvents XtraReport23 As WindowsApplication1.XtraReport2
    Private WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XtraReport21 As WindowsApplication1.XtraReport2
    Private WithEvents SqlDataSource3 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XtraReport22 As WindowsApplication1.XtraReport2
    Private WithEvents SqlDataSource4 As DevExpress.DataAccess.Sql.SqlDataSource
End Class
