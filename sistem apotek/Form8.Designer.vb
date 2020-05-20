<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formpenerimaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formpenerimaan))
        Me.tbidbrgterima = New System.Windows.Forms.TextBox()
        Me.lbalamatcust2 = New System.Windows.Forms.Label()
        Me.tbjumlahterima = New System.Windows.Forms.TextBox()
        Me.lbtelpcust = New System.Windows.Forms.Label()
        Me.tbnamabrgterima = New System.Windows.Forms.TextBox()
        Me.lbkotacust = New System.Windows.Forms.Label()
        Me.lbalamatcust1 = New System.Windows.Forms.Label()
        Me.lbnamacust = New System.Windows.Forms.Label()
        Me.tbidterima = New System.Windows.Forms.TextBox()
        Me.lbkodecust = New System.Windows.Forms.Label()
        Me.btstokterima = New System.Windows.Forms.Button()
        Me.dgvterima = New System.Windows.Forms.DataGridView()
        Me.tbiddterima = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btubahterima = New System.Windows.Forms.Button()
        Me.bttambahterima = New System.Windows.Forms.Button()
        Me.cbnofakturterima = New System.Windows.Forms.ComboBox()
        Me.dtpterima = New System.Windows.Forms.DateTimePicker()
        Me.bthistorypenerimaan = New System.Windows.Forms.Button()
        Me.btlaporan = New System.Windows.Forms.Button()
        Me.bttutupterima = New DevExpress.XtraEditors.SimpleButton()
        Me.btsimpanterima = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.dgvterima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbidbrgterima
        '
        Me.tbidbrgterima.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidbrgterima.Location = New System.Drawing.Point(339, 392)
        Me.tbidbrgterima.Multiline = True
        Me.tbidbrgterima.Name = "tbidbrgterima"
        Me.tbidbrgterima.Size = New System.Drawing.Size(393, 31)
        Me.tbidbrgterima.TabIndex = 96
        '
        'lbalamatcust2
        '
        Me.lbalamatcust2.AutoSize = True
        Me.lbalamatcust2.BackColor = System.Drawing.Color.Transparent
        Me.lbalamatcust2.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbalamatcust2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbalamatcust2.Location = New System.Drawing.Point(12, 389)
        Me.lbalamatcust2.Name = "lbalamatcust2"
        Me.lbalamatcust2.Size = New System.Drawing.Size(131, 31)
        Me.lbalamatcust2.TabIndex = 95
        Me.lbalamatcust2.Text = "ID Barang:"
        '
        'tbjumlahterima
        '
        Me.tbjumlahterima.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbjumlahterima.Location = New System.Drawing.Point(339, 466)
        Me.tbjumlahterima.Multiline = True
        Me.tbjumlahterima.Name = "tbjumlahterima"
        Me.tbjumlahterima.Size = New System.Drawing.Size(395, 31)
        Me.tbjumlahterima.TabIndex = 87
        '
        'lbtelpcust
        '
        Me.lbtelpcust.AutoSize = True
        Me.lbtelpcust.BackColor = System.Drawing.Color.Transparent
        Me.lbtelpcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbtelpcust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbtelpcust.Location = New System.Drawing.Point(14, 466)
        Me.lbtelpcust.Name = "lbtelpcust"
        Me.lbtelpcust.Size = New System.Drawing.Size(98, 31)
        Me.lbtelpcust.TabIndex = 86
        Me.lbtelpcust.Text = "Jumlah:"
        '
        'tbnamabrgterima
        '
        Me.tbnamabrgterima.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnamabrgterima.Location = New System.Drawing.Point(339, 429)
        Me.tbnamabrgterima.Multiline = True
        Me.tbnamabrgterima.Name = "tbnamabrgterima"
        Me.tbnamabrgterima.Size = New System.Drawing.Size(395, 31)
        Me.tbnamabrgterima.TabIndex = 85
        '
        'lbkotacust
        '
        Me.lbkotacust.AutoSize = True
        Me.lbkotacust.BackColor = System.Drawing.Color.Transparent
        Me.lbkotacust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkotacust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbkotacust.Location = New System.Drawing.Point(14, 429)
        Me.lbkotacust.Name = "lbkotacust"
        Me.lbkotacust.Size = New System.Drawing.Size(167, 31)
        Me.lbkotacust.TabIndex = 84
        Me.lbkotacust.Text = "Nama Barang:"
        '
        'lbalamatcust1
        '
        Me.lbalamatcust1.AutoSize = True
        Me.lbalamatcust1.BackColor = System.Drawing.Color.Transparent
        Me.lbalamatcust1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbalamatcust1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbalamatcust1.Location = New System.Drawing.Point(12, 345)
        Me.lbalamatcust1.Name = "lbalamatcust1"
        Me.lbalamatcust1.Size = New System.Drawing.Size(222, 31)
        Me.lbalamatcust1.TabIndex = 82
        Me.lbalamatcust1.Text = "Tahun Penerimaan:"
        '
        'lbnamacust
        '
        Me.lbnamacust.AutoSize = True
        Me.lbnamacust.BackColor = System.Drawing.Color.Transparent
        Me.lbnamacust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnamacust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbnamacust.Location = New System.Drawing.Point(14, 301)
        Me.lbnamacust.Name = "lbnamacust"
        Me.lbnamacust.Size = New System.Drawing.Size(131, 31)
        Me.lbnamacust.TabIndex = 80
        Me.lbnamacust.Text = "No Faktur:"
        '
        'tbidterima
        '
        Me.tbidterima.Enabled = False
        Me.tbidterima.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidterima.Location = New System.Drawing.Point(339, 225)
        Me.tbidterima.Multiline = True
        Me.tbidterima.Name = "tbidterima"
        Me.tbidterima.Size = New System.Drawing.Size(395, 31)
        Me.tbidterima.TabIndex = 79
        '
        'lbkodecust
        '
        Me.lbkodecust.AutoSize = True
        Me.lbkodecust.BackColor = System.Drawing.Color.Transparent
        Me.lbkodecust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkodecust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbkodecust.Location = New System.Drawing.Point(15, 225)
        Me.lbkodecust.Name = "lbkodecust"
        Me.lbkodecust.Size = New System.Drawing.Size(181, 31)
        Me.lbkodecust.TabIndex = 78
        Me.lbkodecust.Text = "ID Penerimaan:"
        '
        'btstokterima
        '
        Me.btstokterima.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btstokterima.Location = New System.Drawing.Point(720, 572)
        Me.btstokterima.Name = "btstokterima"
        Me.btstokterima.Size = New System.Drawing.Size(103, 41)
        Me.btstokterima.TabIndex = 93
        Me.btstokterima.Text = "Stok"
        Me.btstokterima.UseVisualStyleBackColor = True
        '
        'dgvterima
        '
        Me.dgvterima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvterima.Location = New System.Drawing.Point(828, 225)
        Me.dgvterima.Name = "dgvterima"
        Me.dgvterima.RowTemplate.Height = 24
        Me.dgvterima.Size = New System.Drawing.Size(10, 10)
        Me.dgvterima.TabIndex = 101
        '
        'tbiddterima
        '
        Me.tbiddterima.Enabled = False
        Me.tbiddterima.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbiddterima.Location = New System.Drawing.Point(339, 264)
        Me.tbiddterima.Multiline = True
        Me.tbiddterima.Name = "tbiddterima"
        Me.tbiddterima.Size = New System.Drawing.Size(395, 31)
        Me.tbiddterima.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(15, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 31)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "ID Detail Penerimaan:"
        '
        'btubahterima
        '
        Me.btubahterima.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahterima.Location = New System.Drawing.Point(452, 572)
        Me.btubahterima.Name = "btubahterima"
        Me.btubahterima.Size = New System.Drawing.Size(103, 41)
        Me.btubahterima.TabIndex = 105
        Me.btubahterima.Text = "Ubah"
        Me.btubahterima.UseVisualStyleBackColor = True
        '
        'bttambahterima
        '
        Me.bttambahterima.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttambahterima.Location = New System.Drawing.Point(343, 572)
        Me.bttambahterima.Name = "bttambahterima"
        Me.bttambahterima.Size = New System.Drawing.Size(103, 41)
        Me.bttambahterima.TabIndex = 106
        Me.bttambahterima.Text = "Tambah"
        Me.bttambahterima.UseVisualStyleBackColor = True
        '
        'cbnofakturterima
        '
        Me.cbnofakturterima.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbnofakturterima.FormattingEnabled = True
        Me.cbnofakturterima.Location = New System.Drawing.Point(339, 306)
        Me.cbnofakturterima.Name = "cbnofakturterima"
        Me.cbnofakturterima.Size = New System.Drawing.Size(395, 33)
        Me.cbnofakturterima.TabIndex = 107
        '
        'dtpterima
        '
        Me.dtpterima.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpterima.Location = New System.Drawing.Point(339, 354)
        Me.dtpterima.Name = "dtpterima"
        Me.dtpterima.Size = New System.Drawing.Size(395, 28)
        Me.dtpterima.TabIndex = 108
        '
        'bthistorypenerimaan
        '
        Me.bthistorypenerimaan.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthistorypenerimaan.Location = New System.Drawing.Point(234, 572)
        Me.bthistorypenerimaan.Name = "bthistorypenerimaan"
        Me.bthistorypenerimaan.Size = New System.Drawing.Size(103, 41)
        Me.bthistorypenerimaan.TabIndex = 109
        Me.bthistorypenerimaan.Text = "History"
        Me.bthistorypenerimaan.UseVisualStyleBackColor = True
        '
        'btlaporan
        '
        Me.btlaporan.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btlaporan.Location = New System.Drawing.Point(828, 264)
        Me.btlaporan.Name = "btlaporan"
        Me.btlaporan.Size = New System.Drawing.Size(10, 10)
        Me.btlaporan.TabIndex = 110
        Me.btlaporan.Text = "Laporan"
        Me.btlaporan.UseVisualStyleBackColor = True
        '
        'bttutupterima
        '
        Me.bttutupterima.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttutupterima.Appearance.Options.UseFont = True
        Me.bttutupterima.ImageOptions.Image = CType(resources.GetObject("bttutupterima.ImageOptions.Image"), System.Drawing.Image)
        Me.bttutupterima.Location = New System.Drawing.Point(12, 572)
        Me.bttutupterima.Name = "bttutupterima"
        Me.bttutupterima.Size = New System.Drawing.Size(137, 41)
        Me.bttutupterima.TabIndex = 99
        Me.bttutupterima.Text = "Tutup"
        '
        'btsimpanterima
        '
        Me.btsimpanterima.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btsimpanterima.Appearance.Options.UseFont = True
        Me.btsimpanterima.ImageOptions.Image = CType(resources.GetObject("btsimpanterima.ImageOptions.Image"), System.Drawing.Image)
        Me.btsimpanterima.Location = New System.Drawing.Point(561, 573)
        Me.btsimpanterima.Name = "btsimpanterima"
        Me.btsimpanterima.Size = New System.Drawing.Size(153, 39)
        Me.btsimpanterima.TabIndex = 98
        Me.btsimpanterima.Text = "Simpan"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(21, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(728, 200)
        Me.GridControl1.TabIndex = 111
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'formpenerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(850, 625)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btlaporan)
        Me.Controls.Add(Me.bthistorypenerimaan)
        Me.Controls.Add(Me.dtpterima)
        Me.Controls.Add(Me.cbnofakturterima)
        Me.Controls.Add(Me.bttambahterima)
        Me.Controls.Add(Me.btubahterima)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbiddterima)
        Me.Controls.Add(Me.dgvterima)
        Me.Controls.Add(Me.bttutupterima)
        Me.Controls.Add(Me.btsimpanterima)
        Me.Controls.Add(Me.tbidbrgterima)
        Me.Controls.Add(Me.lbalamatcust2)
        Me.Controls.Add(Me.btstokterima)
        Me.Controls.Add(Me.tbjumlahterima)
        Me.Controls.Add(Me.lbtelpcust)
        Me.Controls.Add(Me.tbnamabrgterima)
        Me.Controls.Add(Me.lbkotacust)
        Me.Controls.Add(Me.lbalamatcust1)
        Me.Controls.Add(Me.lbnamacust)
        Me.Controls.Add(Me.tbidterima)
        Me.Controls.Add(Me.lbkodecust)
        Me.Name = "formpenerimaan"
        Me.Text = "Penerimaan"
        CType(Me.dgvterima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbidbrgterima As System.Windows.Forms.TextBox
    Friend WithEvents lbalamatcust2 As System.Windows.Forms.Label
    Friend WithEvents tbjumlahterima As System.Windows.Forms.TextBox
    Friend WithEvents lbtelpcust As System.Windows.Forms.Label
    Friend WithEvents tbnamabrgterima As System.Windows.Forms.TextBox
    Friend WithEvents lbkotacust As System.Windows.Forms.Label
    Friend WithEvents lbalamatcust1 As System.Windows.Forms.Label
    Friend WithEvents lbnamacust As System.Windows.Forms.Label
    Friend WithEvents tbidterima As System.Windows.Forms.TextBox
    Friend WithEvents lbkodecust As System.Windows.Forms.Label
    Friend WithEvents btstokterima As System.Windows.Forms.Button
    Friend WithEvents btsimpanterima As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttutupterima As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvterima As System.Windows.Forms.DataGridView
    Friend WithEvents tbiddterima As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btubahterima As System.Windows.Forms.Button
    Friend WithEvents bttambahterima As System.Windows.Forms.Button
    Friend WithEvents cbnofakturterima As System.Windows.Forms.ComboBox
    Friend WithEvents dtpterima As System.Windows.Forms.DateTimePicker
    Friend WithEvents bthistorypenerimaan As System.Windows.Forms.Button
    Friend WithEvents btlaporan As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
