<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formcustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formcustomer))
        Me.btbatalcust = New System.Windows.Forms.Button()
        Me.btubahcust = New System.Windows.Forms.Button()
        Me.bthapuscust = New System.Windows.Forms.Button()
        Me.bttambahcust = New System.Windows.Forms.Button()
        Me.tbtelpcust = New System.Windows.Forms.TextBox()
        Me.lbtelpcust = New System.Windows.Forms.Label()
        Me.tbkotacust = New System.Windows.Forms.TextBox()
        Me.lbkotacust = New System.Windows.Forms.Label()
        Me.tbalamatcust = New System.Windows.Forms.TextBox()
        Me.lbalamatcust = New System.Windows.Forms.Label()
        Me.tbnamacust = New System.Windows.Forms.TextBox()
        Me.lbnamacust = New System.Windows.Forms.Label()
        Me.tbkodecust = New System.Windows.Forms.TextBox()
        Me.lbkodecust = New System.Windows.Forms.Label()
        Me.dgvcustomer = New System.Windows.Forms.DataGridView()
        Me.btutupcust = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.dgvcustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btbatalcust
        '
        Me.btbatalcust.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btbatalcust.Location = New System.Drawing.Point(848, 569)
        Me.btbatalcust.Name = "btbatalcust"
        Me.btbatalcust.Size = New System.Drawing.Size(126, 41)
        Me.btbatalcust.TabIndex = 74
        Me.btbatalcust.Text = "Batal"
        Me.btbatalcust.UseVisualStyleBackColor = True
        '
        'btubahcust
        '
        Me.btubahcust.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahcust.Location = New System.Drawing.Point(714, 569)
        Me.btubahcust.Name = "btubahcust"
        Me.btubahcust.Size = New System.Drawing.Size(118, 41)
        Me.btubahcust.TabIndex = 73
        Me.btubahcust.Text = "Ubah"
        Me.btubahcust.UseVisualStyleBackColor = True
        '
        'bthapuscust
        '
        Me.bthapuscust.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bthapuscust.Location = New System.Drawing.Point(567, 569)
        Me.bthapuscust.Name = "bthapuscust"
        Me.bthapuscust.Size = New System.Drawing.Size(126, 41)
        Me.bthapuscust.TabIndex = 72
        Me.bthapuscust.Text = "Hapus"
        Me.bthapuscust.UseVisualStyleBackColor = True
        '
        'bttambahcust
        '
        Me.bttambahcust.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttambahcust.Location = New System.Drawing.Point(417, 569)
        Me.bttambahcust.Name = "bttambahcust"
        Me.bttambahcust.Size = New System.Drawing.Size(129, 41)
        Me.bttambahcust.TabIndex = 71
        Me.bttambahcust.Text = "Tambah"
        Me.bttambahcust.UseVisualStyleBackColor = True
        '
        'tbtelpcust
        '
        Me.tbtelpcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbtelpcust.Location = New System.Drawing.Point(262, 514)
        Me.tbtelpcust.Multiline = True
        Me.tbtelpcust.Name = "tbtelpcust"
        Me.tbtelpcust.Size = New System.Drawing.Size(415, 31)
        Me.tbtelpcust.TabIndex = 68
        '
        'lbtelpcust
        '
        Me.lbtelpcust.AutoSize = True
        Me.lbtelpcust.BackColor = System.Drawing.Color.Transparent
        Me.lbtelpcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbtelpcust.ForeColor = System.Drawing.SystemColors.Control
        Me.lbtelpcust.Location = New System.Drawing.Point(21, 514)
        Me.lbtelpcust.Name = "lbtelpcust"
        Me.lbtelpcust.Size = New System.Drawing.Size(150, 31)
        Me.lbtelpcust.TabIndex = 67
        Me.lbtelpcust.Text = "Telepon/HP:"
        '
        'tbkotacust
        '
        Me.tbkotacust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbkotacust.Location = New System.Drawing.Point(262, 477)
        Me.tbkotacust.Multiline = True
        Me.tbkotacust.Name = "tbkotacust"
        Me.tbkotacust.Size = New System.Drawing.Size(415, 31)
        Me.tbkotacust.TabIndex = 66
        '
        'lbkotacust
        '
        Me.lbkotacust.AutoSize = True
        Me.lbkotacust.BackColor = System.Drawing.Color.Transparent
        Me.lbkotacust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkotacust.ForeColor = System.Drawing.SystemColors.Control
        Me.lbkotacust.Location = New System.Drawing.Point(21, 477)
        Me.lbkotacust.Name = "lbkotacust"
        Me.lbkotacust.Size = New System.Drawing.Size(73, 31)
        Me.lbkotacust.TabIndex = 65
        Me.lbkotacust.Text = "Kota:"
        '
        'tbalamatcust
        '
        Me.tbalamatcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbalamatcust.Location = New System.Drawing.Point(262, 440)
        Me.tbalamatcust.Multiline = True
        Me.tbalamatcust.Name = "tbalamatcust"
        Me.tbalamatcust.Size = New System.Drawing.Size(415, 31)
        Me.tbalamatcust.TabIndex = 64
        '
        'lbalamatcust
        '
        Me.lbalamatcust.AutoSize = True
        Me.lbalamatcust.BackColor = System.Drawing.Color.Transparent
        Me.lbalamatcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbalamatcust.ForeColor = System.Drawing.SystemColors.Control
        Me.lbalamatcust.Location = New System.Drawing.Point(19, 437)
        Me.lbalamatcust.Name = "lbalamatcust"
        Me.lbalamatcust.Size = New System.Drawing.Size(211, 31)
        Me.lbalamatcust.TabIndex = 63
        Me.lbalamatcust.Text = "Alamat Customer:"
        '
        'tbnamacust
        '
        Me.tbnamacust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnamacust.Location = New System.Drawing.Point(262, 400)
        Me.tbnamacust.Multiline = True
        Me.tbnamacust.Name = "tbnamacust"
        Me.tbnamacust.Size = New System.Drawing.Size(415, 31)
        Me.tbnamacust.TabIndex = 62
        '
        'lbnamacust
        '
        Me.lbnamacust.AutoSize = True
        Me.lbnamacust.BackColor = System.Drawing.Color.Transparent
        Me.lbnamacust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnamacust.ForeColor = System.Drawing.SystemColors.Control
        Me.lbnamacust.Location = New System.Drawing.Point(21, 400)
        Me.lbnamacust.Name = "lbnamacust"
        Me.lbnamacust.Size = New System.Drawing.Size(195, 31)
        Me.lbnamacust.TabIndex = 61
        Me.lbnamacust.Text = "Nama Customer:"
        '
        'tbkodecust
        '
        Me.tbkodecust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbkodecust.Location = New System.Drawing.Point(262, 358)
        Me.tbkodecust.Multiline = True
        Me.tbkodecust.Name = "tbkodecust"
        Me.tbkodecust.Size = New System.Drawing.Size(415, 31)
        Me.tbkodecust.TabIndex = 60
        '
        'lbkodecust
        '
        Me.lbkodecust.AutoSize = True
        Me.lbkodecust.BackColor = System.Drawing.Color.Transparent
        Me.lbkodecust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkodecust.ForeColor = System.Drawing.SystemColors.Control
        Me.lbkodecust.Location = New System.Drawing.Point(22, 358)
        Me.lbkodecust.Name = "lbkodecust"
        Me.lbkodecust.Size = New System.Drawing.Size(191, 31)
        Me.lbkodecust.TabIndex = 59
        Me.lbkodecust.Text = "Kode Customer:"
        '
        'dgvcustomer
        '
        Me.dgvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcustomer.Location = New System.Drawing.Point(987, 438)
        Me.dgvcustomer.Name = "dgvcustomer"
        Me.dgvcustomer.RowTemplate.Height = 24
        Me.dgvcustomer.Size = New System.Drawing.Size(10, 13)
        Me.dgvcustomer.TabIndex = 56
        '
        'btutupcust
        '
        Me.btutupcust.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btutupcust.Appearance.Options.UseFont = True
        Me.btutupcust.ImageOptions.Image = CType(resources.GetObject("btutupcust.ImageOptions.Image"), System.Drawing.Image)
        Me.btutupcust.Location = New System.Drawing.Point(12, 569)
        Me.btutupcust.Name = "btutupcust"
        Me.btutupcust.Size = New System.Drawing.Size(137, 41)
        Me.btutupcust.TabIndex = 100
        Me.btutupcust.Text = "Tutup"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 33)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(985, 319)
        Me.GridControl1.TabIndex = 102
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'Formcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.lines_stripes_black_background_119743_3840x2400
        Me.ClientSize = New System.Drawing.Size(1009, 649)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.dgvcustomer)
        Me.Controls.Add(Me.btutupcust)
        Me.Controls.Add(Me.btbatalcust)
        Me.Controls.Add(Me.btubahcust)
        Me.Controls.Add(Me.bthapuscust)
        Me.Controls.Add(Me.bttambahcust)
        Me.Controls.Add(Me.tbtelpcust)
        Me.Controls.Add(Me.lbtelpcust)
        Me.Controls.Add(Me.tbkotacust)
        Me.Controls.Add(Me.lbkotacust)
        Me.Controls.Add(Me.tbalamatcust)
        Me.Controls.Add(Me.lbalamatcust)
        Me.Controls.Add(Me.tbnamacust)
        Me.Controls.Add(Me.lbnamacust)
        Me.Controls.Add(Me.tbkodecust)
        Me.Controls.Add(Me.lbkodecust)
        Me.Name = "Formcustomer"
        Me.Text = "Data Customer"
        CType(Me.dgvcustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btbatalcust As System.Windows.Forms.Button
    Friend WithEvents btubahcust As System.Windows.Forms.Button
    Friend WithEvents bthapuscust As System.Windows.Forms.Button
    Friend WithEvents bttambahcust As System.Windows.Forms.Button
    Friend WithEvents tbtelpcust As System.Windows.Forms.TextBox
    Friend WithEvents lbtelpcust As System.Windows.Forms.Label
    Friend WithEvents tbkotacust As System.Windows.Forms.TextBox
    Friend WithEvents lbkotacust As System.Windows.Forms.Label
    Friend WithEvents tbalamatcust As System.Windows.Forms.TextBox
    Friend WithEvents lbalamatcust As System.Windows.Forms.Label
    Friend WithEvents tbnamacust As System.Windows.Forms.TextBox
    Friend WithEvents lbnamacust As System.Windows.Forms.Label
    Friend WithEvents tbkodecust As System.Windows.Forms.TextBox
    Friend WithEvents lbkodecust As System.Windows.Forms.Label
    Friend WithEvents dgvcustomer As System.Windows.Forms.DataGridView
    Friend WithEvents btutupcust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
