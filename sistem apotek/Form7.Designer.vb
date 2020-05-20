<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formpenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formpenjualan))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btlihatbrg = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btubahjual = New System.Windows.Forms.Button()
        Me.bthapusjual = New System.Windows.Forms.Button()
        Me.btlaporan = New System.Windows.Forms.Button()
        Me.bttambahjual = New System.Windows.Forms.Button()
        Me.tbidjual = New System.Windows.Forms.TextBox()
        Me.lbstakhir = New System.Windows.Forms.Label()
        Me.tbdisc = New System.Windows.Forms.TextBox()
        Me.lbdisc = New System.Windows.Forms.Label()
        Me.tbbeli = New System.Windows.Forms.TextBox()
        Me.lbbeli = New System.Windows.Forms.Label()
        Me.tbjual = New System.Windows.Forms.TextBox()
        Me.lbjual = New System.Windows.Forms.Label()
        Me.lbtgljual = New System.Windows.Forms.Label()
        Me.tbnamabrg = New System.Windows.Forms.TextBox()
        Me.lbnama = New System.Windows.Forms.Label()
        Me.tbpajakjual = New System.Windows.Forms.TextBox()
        Me.lbnopajak = New System.Windows.Forms.Label()
        Me.tbtotjual = New System.Windows.Forms.TextBox()
        Me.lbtotjual = New System.Windows.Forms.Label()
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        Me.tbidcust = New System.Windows.Forms.TextBox()
        Me.lbidcust = New System.Windows.Forms.Label()
        Me.btretur = New System.Windows.Forms.Button()
        Me.texbox3 = New System.Windows.Forms.TextBox()
        Me.tb_penjualan = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbtotaljual = New System.Windows.Forms.TextBox()
        Me.btcust = New System.Windows.Forms.Button()
        Me.bttutupjual = New DevExpress.XtraEditors.SimpleButton()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(436, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 31)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Expire Date:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.TextBox1.Location = New System.Drawing.Point(229, 359)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 31)
        Me.TextBox1.TabIndex = 98
        '
        'btlihatbrg
        '
        Me.btlihatbrg.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btlihatbrg.Location = New System.Drawing.Point(752, 132)
        Me.btlihatbrg.Name = "btlihatbrg"
        Me.btlihatbrg.Size = New System.Drawing.Size(192, 41)
        Me.btlihatbrg.TabIndex = 97
        Me.btlihatbrg.Text = "Data Barang"
        Me.btlihatbrg.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(45, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 31)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "ID Penjualan:"
        '
        'btubahjual
        '
        Me.btubahjual.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahjual.Location = New System.Drawing.Point(819, 446)
        Me.btubahjual.Name = "btubahjual"
        Me.btubahjual.Size = New System.Drawing.Size(126, 41)
        Me.btubahjual.TabIndex = 94
        Me.btubahjual.Text = "Ubah"
        Me.btubahjual.UseVisualStyleBackColor = True
        '
        'bthapusjual
        '
        Me.bthapusjual.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bthapusjual.Location = New System.Drawing.Point(675, 446)
        Me.bthapusjual.Name = "bthapusjual"
        Me.bthapusjual.Size = New System.Drawing.Size(126, 41)
        Me.bthapusjual.TabIndex = 93
        Me.bthapusjual.Text = "Hapus"
        Me.bthapusjual.UseVisualStyleBackColor = True
        '
        'btlaporan
        '
        Me.btlaporan.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btlaporan.Location = New System.Drawing.Point(13, 96)
        Me.btlaporan.Name = "btlaporan"
        Me.btlaporan.Size = New System.Drawing.Size(10, 10)
        Me.btlaporan.TabIndex = 91
        Me.btlaporan.Text = "Laporan"
        Me.btlaporan.UseVisualStyleBackColor = True
        '
        'bttambahjual
        '
        Me.bttambahjual.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttambahjual.Location = New System.Drawing.Point(509, 446)
        Me.bttambahjual.Name = "bttambahjual"
        Me.bttambahjual.Size = New System.Drawing.Size(148, 41)
        Me.bttambahjual.TabIndex = 90
        Me.bttambahjual.Text = "Tambah"
        Me.bttambahjual.UseVisualStyleBackColor = True
        '
        'tbidjual
        '
        Me.tbidjual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidjual.Location = New System.Drawing.Point(204, 129)
        Me.tbidjual.Multiline = True
        Me.tbidjual.Name = "tbidjual"
        Me.tbidjual.Size = New System.Drawing.Size(194, 31)
        Me.tbidjual.TabIndex = 89
        '
        'lbstakhir
        '
        Me.lbstakhir.AutoSize = True
        Me.lbstakhir.BackColor = System.Drawing.Color.Black
        Me.lbstakhir.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbstakhir.ForeColor = System.Drawing.SystemColors.Control
        Me.lbstakhir.Location = New System.Drawing.Point(33, 359)
        Me.lbstakhir.Name = "lbstakhir"
        Me.lbstakhir.Size = New System.Drawing.Size(124, 31)
        Me.lbstakhir.TabIndex = 88
        Me.lbstakhir.Text = "No Batch:"
        '
        'tbdisc
        '
        Me.tbdisc.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbdisc.Location = New System.Drawing.Point(592, 278)
        Me.tbdisc.Multiline = True
        Me.tbdisc.Name = "tbdisc"
        Me.tbdisc.Size = New System.Drawing.Size(356, 31)
        Me.tbdisc.TabIndex = 85
        '
        'lbdisc
        '
        Me.lbdisc.AutoSize = True
        Me.lbdisc.BackColor = System.Drawing.Color.Black
        Me.lbdisc.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbdisc.ForeColor = System.Drawing.SystemColors.Control
        Me.lbdisc.Location = New System.Drawing.Point(456, 281)
        Me.lbdisc.Name = "lbdisc"
        Me.lbdisc.Size = New System.Drawing.Size(97, 31)
        Me.lbdisc.TabIndex = 84
        Me.lbdisc.Text = "Diskon:"
        '
        'tbbeli
        '
        Me.tbbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbbeli.Location = New System.Drawing.Point(229, 399)
        Me.tbbeli.Multiline = True
        Me.tbbeli.Name = "tbbeli"
        Me.tbbeli.Size = New System.Drawing.Size(166, 31)
        Me.tbbeli.TabIndex = 83
        '
        'lbbeli
        '
        Me.lbbeli.AutoSize = True
        Me.lbbeli.BackColor = System.Drawing.Color.Black
        Me.lbbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbbeli.ForeColor = System.Drawing.SystemColors.Control
        Me.lbbeli.Location = New System.Drawing.Point(33, 399)
        Me.lbbeli.Name = "lbbeli"
        Me.lbbeli.Size = New System.Drawing.Size(174, 31)
        Me.lbbeli.TabIndex = 82
        Me.lbbeli.Text = "Harga Jual Rp:"
        '
        'tbjual
        '
        Me.tbjual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbjual.Location = New System.Drawing.Point(229, 315)
        Me.tbjual.Multiline = True
        Me.tbjual.Name = "tbjual"
        Me.tbjual.Size = New System.Drawing.Size(166, 31)
        Me.tbjual.TabIndex = 81
        '
        'lbjual
        '
        Me.lbjual.AutoSize = True
        Me.lbjual.BackColor = System.Drawing.Color.Black
        Me.lbjual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbjual.ForeColor = System.Drawing.SystemColors.Control
        Me.lbjual.Location = New System.Drawing.Point(34, 315)
        Me.lbjual.Name = "lbjual"
        Me.lbjual.Size = New System.Drawing.Size(163, 31)
        Me.lbjual.TabIndex = 80
        Me.lbjual.Text = "Kode Barang:"
        '
        'lbtgljual
        '
        Me.lbtgljual.AutoSize = True
        Me.lbtgljual.BackColor = System.Drawing.Color.Black
        Me.lbtgljual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbtgljual.ForeColor = System.Drawing.SystemColors.Control
        Me.lbtgljual.Location = New System.Drawing.Point(541, 87)
        Me.lbtgljual.Name = "lbtgljual"
        Me.lbtgljual.Size = New System.Drawing.Size(203, 31)
        Me.lbtgljual.TabIndex = 74
        Me.lbtgljual.Text = "Tahun Penjualan:"
        '
        'tbnamabrg
        '
        Me.tbnamabrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnamabrg.Location = New System.Drawing.Point(592, 315)
        Me.tbnamabrg.Multiline = True
        Me.tbnamabrg.Name = "tbnamabrg"
        Me.tbnamabrg.Size = New System.Drawing.Size(356, 31)
        Me.tbnamabrg.TabIndex = 73
        '
        'lbnama
        '
        Me.lbnama.AutoSize = True
        Me.lbnama.BackColor = System.Drawing.Color.Black
        Me.lbnama.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnama.ForeColor = System.Drawing.SystemColors.Control
        Me.lbnama.Location = New System.Drawing.Point(419, 315)
        Me.lbnama.Name = "lbnama"
        Me.lbnama.Size = New System.Drawing.Size(167, 31)
        Me.lbnama.TabIndex = 72
        Me.lbnama.Text = "Nama Barang:"
        '
        'tbpajakjual
        '
        Me.tbpajakjual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbpajakjual.Location = New System.Drawing.Point(201, 88)
        Me.tbpajakjual.Multiline = True
        Me.tbpajakjual.Name = "tbpajakjual"
        Me.tbpajakjual.Size = New System.Drawing.Size(259, 31)
        Me.tbpajakjual.TabIndex = 71
        '
        'lbnopajak
        '
        Me.lbnopajak.AutoSize = True
        Me.lbnopajak.BackColor = System.Drawing.Color.Black
        Me.lbnopajak.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnopajak.ForeColor = System.Drawing.SystemColors.Control
        Me.lbnopajak.Location = New System.Drawing.Point(37, 87)
        Me.lbnopajak.Name = "lbnopajak"
        Me.lbnopajak.Size = New System.Drawing.Size(119, 31)
        Me.lbnopajak.TabIndex = 70
        Me.lbnopajak.Text = "No Pajak:"
        '
        'tbtotjual
        '
        Me.tbtotjual.Font = New System.Drawing.Font("Times New Roman", 20.0!)
        Me.tbtotjual.Location = New System.Drawing.Point(201, 34)
        Me.tbtotjual.Multiline = True
        Me.tbtotjual.Name = "tbtotjual"
        Me.tbtotjual.Size = New System.Drawing.Size(743, 42)
        Me.tbtotjual.TabIndex = 69
        '
        'lbtotjual
        '
        Me.lbtotjual.AutoSize = True
        Me.lbtotjual.BackColor = System.Drawing.Color.Black
        Me.lbtotjual.Font = New System.Drawing.Font("Times New Roman", 22.0!)
        Me.lbtotjual.ForeColor = System.Drawing.SystemColors.Control
        Me.lbtotjual.Location = New System.Drawing.Point(33, 34)
        Me.lbtotjual.Name = "lbtotjual"
        Me.lbtotjual.Size = New System.Drawing.Size(152, 42)
        Me.lbtotjual.TabIndex = 68
        Me.lbtotjual.Text = "Total Rp."
        '
        'dgvbarang
        '
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Location = New System.Drawing.Point(43, 741)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.RowTemplate.Height = 24
        Me.dgvbarang.Size = New System.Drawing.Size(10, 10)
        Me.dgvbarang.TabIndex = 67
        '
        'tbidcust
        '
        Me.tbidcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidcust.Location = New System.Drawing.Point(205, 174)
        Me.tbidcust.Multiline = True
        Me.tbidcust.Name = "tbidcust"
        Me.tbidcust.Size = New System.Drawing.Size(195, 31)
        Me.tbidcust.TabIndex = 104
        '
        'lbidcust
        '
        Me.lbidcust.AutoSize = True
        Me.lbidcust.BackColor = System.Drawing.Color.Black
        Me.lbidcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbidcust.ForeColor = System.Drawing.SystemColors.Control
        Me.lbidcust.Location = New System.Drawing.Point(8, 174)
        Me.lbidcust.Name = "lbidcust"
        Me.lbidcust.Size = New System.Drawing.Size(191, 31)
        Me.lbidcust.TabIndex = 103
        Me.lbidcust.Text = "Kode Customer:"
        '
        'btretur
        '
        Me.btretur.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btretur.Location = New System.Drawing.Point(800, 442)
        Me.btretur.Name = "btretur"
        Me.btretur.Size = New System.Drawing.Size(148, 41)
        Me.btretur.TabIndex = 112
        Me.btretur.Text = "Retur"
        Me.btretur.UseVisualStyleBackColor = True
        '
        'texbox3
        '
        Me.texbox3.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.texbox3.Location = New System.Drawing.Point(592, 362)
        Me.texbox3.Multiline = True
        Me.texbox3.Name = "texbox3"
        Me.texbox3.Size = New System.Drawing.Size(356, 31)
        Me.texbox3.TabIndex = 116
        '
        'tb_penjualan
        '
        Me.tb_penjualan.Location = New System.Drawing.Point(744, 93)
        Me.tb_penjualan.Name = "tb_penjualan"
        Me.tb_penjualan.Size = New System.Drawing.Size(200, 22)
        Me.tb_penjualan.TabIndex = 117
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(436, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 31)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Total Jual"
        '
        'tbtotaljual
        '
        Me.tbtotaljual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbtotaljual.Location = New System.Drawing.Point(592, 405)
        Me.tbtotaljual.Multiline = True
        Me.tbtotaljual.Name = "tbtotaljual"
        Me.tbtotaljual.Size = New System.Drawing.Size(356, 31)
        Me.tbtotaljual.TabIndex = 119
        '
        'btcust
        '
        Me.btcust.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcust.Location = New System.Drawing.Point(547, 132)
        Me.btcust.Name = "btcust"
        Me.btcust.Size = New System.Drawing.Size(192, 41)
        Me.btcust.TabIndex = 121
        Me.btcust.Text = "Data Customer"
        Me.btcust.UseVisualStyleBackColor = True
        '
        'bttutupjual
        '
        Me.bttutupjual.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttutupjual.Appearance.Options.UseFont = True
        Me.bttutupjual.ImageOptions.Image = CType(resources.GetObject("bttutupjual.ImageOptions.Image"), System.Drawing.Image)
        Me.bttutupjual.Location = New System.Drawing.Point(72, 443)
        Me.bttutupjual.Name = "bttutupjual"
        Me.bttutupjual.Size = New System.Drawing.Size(137, 41)
        Me.bttutupjual.TabIndex = 114
        Me.bttutupjual.Text = "Tutup"
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btsimpan.Location = New System.Drawing.Point(345, 446)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(148, 41)
        Me.btsimpan.TabIndex = 121
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(72, 174)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(873, 266)
        Me.GridControl1.TabIndex = 122
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(76, 174)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(869, 266)
        Me.GridControl2.TabIndex = 123
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.GridControl2)
        Me.Panel1.Controls.Add(Me.bttambahjual)
        Me.Panel1.Controls.Add(Me.bthapusjual)
        Me.Panel1.Controls.Add(Me.btubahjual)
        Me.Panel1.Controls.Add(Me.bttutupjual)
        Me.Panel1.Controls.Add(Me.GridControl1)
        Me.Panel1.Controls.Add(Me.btlaporan)
        Me.Panel1.Controls.Add(Me.btsimpan)
        Me.Panel1.Location = New System.Drawing.Point(-1, 315)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 512)
        Me.Panel1.TabIndex = 120
        '
        'formpenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.lines_stripes_black_background_119743_3840x2400
        Me.ClientSize = New System.Drawing.Size(990, 814)
        Me.Controls.Add(Me.btcust)
        Me.Controls.Add(Me.tbtotaljual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.texbox3)
        Me.Controls.Add(Me.btretur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbstakhir)
        Me.Controls.Add(Me.tbdisc)
        Me.Controls.Add(Me.lbdisc)
        Me.Controls.Add(Me.tbbeli)
        Me.Controls.Add(Me.lbbeli)
        Me.Controls.Add(Me.tbjual)
        Me.Controls.Add(Me.lbjual)
        Me.Controls.Add(Me.tbnamabrg)
        Me.Controls.Add(Me.lbnama)
        Me.Controls.Add(Me.dgvbarang)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tb_penjualan)
        Me.Controls.Add(Me.tbidcust)
        Me.Controls.Add(Me.lbidcust)
        Me.Controls.Add(Me.btlihatbrg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbidjual)
        Me.Controls.Add(Me.lbtgljual)
        Me.Controls.Add(Me.tbpajakjual)
        Me.Controls.Add(Me.lbnopajak)
        Me.Controls.Add(Me.tbtotjual)
        Me.Controls.Add(Me.lbtotjual)
        Me.Name = "formpenjualan"
        Me.Text = "Data Penjualan"
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btlihatbrg As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btubahjual As System.Windows.Forms.Button
    Friend WithEvents bthapusjual As System.Windows.Forms.Button
    Friend WithEvents btlaporan As System.Windows.Forms.Button
    Friend WithEvents bttambahjual As System.Windows.Forms.Button
    Friend WithEvents tbidjual As System.Windows.Forms.TextBox
    Friend WithEvents lbstakhir As System.Windows.Forms.Label
    Friend WithEvents tbdisc As System.Windows.Forms.TextBox
    Friend WithEvents lbdisc As System.Windows.Forms.Label
    Friend WithEvents tbbeli As System.Windows.Forms.TextBox
    Friend WithEvents lbbeli As System.Windows.Forms.Label
    Friend WithEvents tbjual As System.Windows.Forms.TextBox
    Friend WithEvents lbjual As System.Windows.Forms.Label
    Friend WithEvents lbtgljual As System.Windows.Forms.Label
    Friend WithEvents tbnamabrg As System.Windows.Forms.TextBox
    Friend WithEvents lbnama As System.Windows.Forms.Label
    Friend WithEvents tbpajakjual As System.Windows.Forms.TextBox
    Friend WithEvents lbnopajak As System.Windows.Forms.Label
    Friend WithEvents tbtotjual As System.Windows.Forms.TextBox
    Friend WithEvents lbtotjual As System.Windows.Forms.Label
    Friend WithEvents dgvbarang As System.Windows.Forms.DataGridView
    Friend WithEvents tbidcust As System.Windows.Forms.TextBox
    Friend WithEvents lbidcust As System.Windows.Forms.Label
    Friend WithEvents btretur As System.Windows.Forms.Button
    Friend WithEvents bttutupjual As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents texbox3 As System.Windows.Forms.TextBox
    Friend WithEvents tb_penjualan As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbtotaljual As System.Windows.Forms.TextBox
    Friend WithEvents btcust As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
