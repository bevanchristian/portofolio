<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formpembelian
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formpembelian))
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.bttambahbeli = New System.Windows.Forms.Button()
        Me.lbstakhir = New System.Windows.Forms.Label()
        Me.tbhrgbeli = New System.Windows.Forms.TextBox()
        Me.lbhrgbeli = New System.Windows.Forms.Label()
        Me.tbkodejual = New System.Windows.Forms.TextBox()
        Me.lbkodejual = New System.Windows.Forms.Label()
        Me.tbfakturbeli = New System.Windows.Forms.TextBox()
        Me.lbfakturbeli = New System.Windows.Forms.Label()
        Me.Textbox3 = New System.Windows.Forms.TextBox()
        Me.lbnamasup = New System.Windows.Forms.Label()
        Me.tbidbeli = New System.Windows.Forms.TextBox()
        Me.lbidbeli = New System.Windows.Forms.Label()
        Me.tbnamabrg = New System.Windows.Forms.TextBox()
        Me.lbnamabrg = New System.Windows.Forms.Label()
        Me.tbkodesup = New System.Windows.Forms.TextBox()
        Me.lbkodesup = New System.Windows.Forms.Label()
        Me.tbtotbeli = New System.Windows.Forms.TextBox()
        Me.lbtotbeli = New System.Windows.Forms.Label()
        Me.dgvpembelian = New System.Windows.Forms.DataGridView()
        Me.bthapusbeli = New System.Windows.Forms.Button()
        Me.lbtglbeli = New System.Windows.Forms.Label()
        Me.btviewsup = New System.Windows.Forms.Button()
        Me.btviewbarang = New System.Windows.Forms.Button()
        Me.tbbathbeli = New System.Windows.Forms.TextBox()
        Me.lbexpirebeli = New System.Windows.Forms.Label()
        Me.btretur = New System.Windows.Forms.Button()
        Me.Textbox2 = New System.Windows.Forms.TextBox()
        Me.tyyh = New System.Windows.Forms.Label()
        Me.textbox1 = New System.Windows.Forms.DateTimePicker()
        Me.bttambahorder = New System.Windows.Forms.Button()
        Me.btubahbeli = New System.Windows.Forms.Button()
        Me.btlaporan = New System.Windows.Forms.Button()
        Me.btutupbeli = New DevExpress.XtraEditors.SimpleButton()
        Me.totalbelitb = New System.Windows.Forms.TextBox()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CardView1
        '
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.GridControl1
        Me.CardView1.Name = "CardView1"
        Me.CardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'GridControl1
        '
        GridLevelNode1.LevelTemplate = Me.CardView1
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(56, 98)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(932, 253)
        Me.GridControl1.TabIndex = 107
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.CardView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'bttambahbeli
        '
        Me.bttambahbeli.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttambahbeli.Location = New System.Drawing.Point(565, 378)
        Me.bttambahbeli.Name = "bttambahbeli"
        Me.bttambahbeli.Size = New System.Drawing.Size(148, 41)
        Me.bttambahbeli.TabIndex = 56
        Me.bttambahbeli.Text = "Simpan"
        Me.bttambahbeli.UseVisualStyleBackColor = True
        '
        'lbstakhir
        '
        Me.lbstakhir.AutoSize = True
        Me.lbstakhir.BackColor = System.Drawing.Color.Black
        Me.lbstakhir.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbstakhir.ForeColor = System.Drawing.SystemColors.Control
        Me.lbstakhir.Location = New System.Drawing.Point(58, 264)
        Me.lbstakhir.Name = "lbstakhir"
        Me.lbstakhir.Size = New System.Drawing.Size(131, 31)
        Me.lbstakhir.TabIndex = 54
        Me.lbstakhir.Text = "No. Batch:"
        '
        'tbhrgbeli
        '
        Me.tbhrgbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbhrgbeli.Location = New System.Drawing.Point(215, 307)
        Me.tbhrgbeli.Multiline = True
        Me.tbhrgbeli.Name = "tbhrgbeli"
        Me.tbhrgbeli.Size = New System.Drawing.Size(166, 31)
        Me.tbhrgbeli.TabIndex = 49
        '
        'lbhrgbeli
        '
        Me.lbhrgbeli.AutoSize = True
        Me.lbhrgbeli.BackColor = System.Drawing.Color.Black
        Me.lbhrgbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbhrgbeli.ForeColor = System.Drawing.SystemColors.Control
        Me.lbhrgbeli.Location = New System.Drawing.Point(22, 307)
        Me.lbhrgbeli.Name = "lbhrgbeli"
        Me.lbhrgbeli.Size = New System.Drawing.Size(175, 31)
        Me.lbhrgbeli.TabIndex = 48
        Me.lbhrgbeli.Text = "Harga Beli Rp:"
        '
        'tbkodejual
        '
        Me.tbkodejual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbkodejual.Location = New System.Drawing.Point(215, 223)
        Me.tbkodejual.Multiline = True
        Me.tbkodejual.Name = "tbkodejual"
        Me.tbkodejual.Size = New System.Drawing.Size(166, 31)
        Me.tbkodejual.TabIndex = 47
        '
        'lbkodejual
        '
        Me.lbkodejual.AutoSize = True
        Me.lbkodejual.BackColor = System.Drawing.Color.Black
        Me.lbkodejual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkodejual.ForeColor = System.Drawing.SystemColors.Control
        Me.lbkodejual.Location = New System.Drawing.Point(34, 223)
        Me.lbkodejual.Name = "lbkodejual"
        Me.lbkodejual.Size = New System.Drawing.Size(163, 31)
        Me.lbkodejual.TabIndex = 46
        Me.lbkodejual.Text = "Kode Barang:"
        '
        'tbfakturbeli
        '
        Me.tbfakturbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbfakturbeli.Location = New System.Drawing.Point(240, 76)
        Me.tbfakturbeli.Multiline = True
        Me.tbfakturbeli.Name = "tbfakturbeli"
        Me.tbfakturbeli.Size = New System.Drawing.Size(186, 31)
        Me.tbfakturbeli.TabIndex = 45
        '
        'lbfakturbeli
        '
        Me.lbfakturbeli.AutoSize = True
        Me.lbfakturbeli.BackColor = System.Drawing.Color.Black
        Me.lbfakturbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbfakturbeli.ForeColor = System.Drawing.SystemColors.Control
        Me.lbfakturbeli.Location = New System.Drawing.Point(94, 79)
        Me.lbfakturbeli.Name = "lbfakturbeli"
        Me.lbfakturbeli.Size = New System.Drawing.Size(138, 31)
        Me.lbfakturbeli.TabIndex = 44
        Me.lbfakturbeli.Text = "No. Faktur:"
        '
        'Textbox3
        '
        Me.Textbox3.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Textbox3.Location = New System.Drawing.Point(639, 116)
        Me.Textbox3.Multiline = True
        Me.Textbox3.Name = "Textbox3"
        Me.Textbox3.Size = New System.Drawing.Size(295, 31)
        Me.Textbox3.TabIndex = 43
        '
        'lbnamasup
        '
        Me.lbnamasup.AutoSize = True
        Me.lbnamasup.BackColor = System.Drawing.Color.Black
        Me.lbnamasup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnamasup.ForeColor = System.Drawing.SystemColors.Control
        Me.lbnamasup.Location = New System.Drawing.Point(536, 113)
        Me.lbnamasup.Name = "lbnamasup"
        Me.lbnamasup.Size = New System.Drawing.Size(97, 31)
        Me.lbnamasup.TabIndex = 42
        Me.lbnamasup.Text = "Diskon:"
        '
        'tbidbeli
        '
        Me.tbidbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidbeli.Location = New System.Drawing.Point(639, 79)
        Me.tbidbeli.Multiline = True
        Me.tbidbeli.Name = "tbidbeli"
        Me.tbidbeli.Size = New System.Drawing.Size(295, 31)
        Me.tbidbeli.TabIndex = 41
        '
        'lbidbeli
        '
        Me.lbidbeli.AutoSize = True
        Me.lbidbeli.BackColor = System.Drawing.Color.Black
        Me.lbidbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbidbeli.ForeColor = System.Drawing.SystemColors.Control
        Me.lbidbeli.Location = New System.Drawing.Point(465, 79)
        Me.lbidbeli.Name = "lbidbeli"
        Me.lbidbeli.Size = New System.Drawing.Size(168, 31)
        Me.lbidbeli.TabIndex = 40
        Me.lbidbeli.Text = "ID Pembelian:"
        '
        'tbnamabrg
        '
        Me.tbnamabrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnamabrg.Location = New System.Drawing.Point(578, 223)
        Me.tbnamabrg.Multiline = True
        Me.tbnamabrg.Name = "tbnamabrg"
        Me.tbnamabrg.Size = New System.Drawing.Size(356, 31)
        Me.tbnamabrg.TabIndex = 39
        '
        'lbnamabrg
        '
        Me.lbnamabrg.AutoSize = True
        Me.lbnamabrg.BackColor = System.Drawing.Color.Black
        Me.lbnamabrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnamabrg.ForeColor = System.Drawing.SystemColors.Control
        Me.lbnamabrg.Location = New System.Drawing.Point(405, 223)
        Me.lbnamabrg.Name = "lbnamabrg"
        Me.lbnamabrg.Size = New System.Drawing.Size(167, 31)
        Me.lbnamabrg.TabIndex = 38
        Me.lbnamabrg.Text = "Nama Barang:"
        '
        'tbkodesup
        '
        Me.tbkodesup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbkodesup.Location = New System.Drawing.Point(240, 113)
        Me.tbkodesup.Multiline = True
        Me.tbkodesup.Name = "tbkodesup"
        Me.tbkodesup.Size = New System.Drawing.Size(186, 31)
        Me.tbkodesup.TabIndex = 37
        '
        'lbkodesup
        '
        Me.lbkodesup.AutoSize = True
        Me.lbkodesup.BackColor = System.Drawing.Color.Black
        Me.lbkodesup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkodesup.ForeColor = System.Drawing.SystemColors.Control
        Me.lbkodesup.Location = New System.Drawing.Point(53, 116)
        Me.lbkodesup.Name = "lbkodesup"
        Me.lbkodesup.Size = New System.Drawing.Size(179, 31)
        Me.lbkodesup.TabIndex = 36
        Me.lbkodesup.Text = "Kode Supplier:"
        '
        'tbtotbeli
        '
        Me.tbtotbeli.Font = New System.Drawing.Font("Times New Roman", 20.0!)
        Me.tbtotbeli.Location = New System.Drawing.Point(191, 19)
        Me.tbtotbeli.Multiline = True
        Me.tbtotbeli.Name = "tbtotbeli"
        Me.tbtotbeli.Size = New System.Drawing.Size(743, 42)
        Me.tbtotbeli.TabIndex = 33
        '
        'lbtotbeli
        '
        Me.lbtotbeli.AutoSize = True
        Me.lbtotbeli.BackColor = System.Drawing.Color.Black
        Me.lbtotbeli.Font = New System.Drawing.Font("Times New Roman", 22.0!)
        Me.lbtotbeli.ForeColor = System.Drawing.SystemColors.Control
        Me.lbtotbeli.Location = New System.Drawing.Point(29, 19)
        Me.lbtotbeli.Name = "lbtotbeli"
        Me.lbtotbeli.Size = New System.Drawing.Size(152, 42)
        Me.lbtotbeli.TabIndex = 32
        Me.lbtotbeli.Text = "Total Rp."
        '
        'dgvpembelian
        '
        Me.dgvpembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpembelian.Location = New System.Drawing.Point(26, 639)
        Me.dgvpembelian.Name = "dgvpembelian"
        Me.dgvpembelian.RowTemplate.Height = 24
        Me.dgvpembelian.Size = New System.Drawing.Size(10, 10)
        Me.dgvpembelian.TabIndex = 31
        '
        'bthapusbeli
        '
        Me.bthapusbeli.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bthapusbeli.Location = New System.Drawing.Point(719, 378)
        Me.bthapusbeli.Name = "bthapusbeli"
        Me.bthapusbeli.Size = New System.Drawing.Size(126, 41)
        Me.bthapusbeli.TabIndex = 59
        Me.bthapusbeli.Text = "Hapus"
        Me.bthapusbeli.UseVisualStyleBackColor = True
        '
        'lbtglbeli
        '
        Me.lbtglbeli.AutoSize = True
        Me.lbtglbeli.BackColor = System.Drawing.Color.Black
        Me.lbtglbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbtglbeli.ForeColor = System.Drawing.SystemColors.Control
        Me.lbtglbeli.Location = New System.Drawing.Point(20, 150)
        Me.lbtglbeli.Name = "lbtglbeli"
        Me.lbtglbeli.Size = New System.Drawing.Size(225, 31)
        Me.lbtglbeli.TabIndex = 61
        Me.lbtglbeli.Text = "Tanggal Pembelian:"
        '
        'btviewsup
        '
        Me.btviewsup.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btviewsup.Location = New System.Drawing.Point(500, 158)
        Me.btviewsup.Name = "btviewsup"
        Me.btviewsup.Size = New System.Drawing.Size(227, 41)
        Me.btviewsup.TabIndex = 62
        Me.btviewsup.Text = "Data Supplier"
        Me.btviewsup.UseVisualStyleBackColor = True
        '
        'btviewbarang
        '
        Me.btviewbarang.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btviewbarang.Location = New System.Drawing.Point(742, 158)
        Me.btviewbarang.Name = "btviewbarang"
        Me.btviewbarang.Size = New System.Drawing.Size(192, 41)
        Me.btviewbarang.TabIndex = 63
        Me.btviewbarang.Text = "Data Barang"
        Me.btviewbarang.UseVisualStyleBackColor = True
        '
        'tbbathbeli
        '
        Me.tbbathbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbbathbeli.Location = New System.Drawing.Point(215, 267)
        Me.tbbathbeli.Multiline = True
        Me.tbbathbeli.Name = "tbbathbeli"
        Me.tbbathbeli.Size = New System.Drawing.Size(166, 31)
        Me.tbbathbeli.TabIndex = 64
        '
        'lbexpirebeli
        '
        Me.lbexpirebeli.AutoSize = True
        Me.lbexpirebeli.BackColor = System.Drawing.Color.Black
        Me.lbexpirebeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbexpirebeli.ForeColor = System.Drawing.SystemColors.Control
        Me.lbexpirebeli.Location = New System.Drawing.Point(417, 264)
        Me.lbexpirebeli.Name = "lbexpirebeli"
        Me.lbexpirebeli.Size = New System.Drawing.Size(150, 31)
        Me.lbexpirebeli.TabIndex = 65
        Me.lbexpirebeli.Text = "Expire Date:"
        '
        'btretur
        '
        Me.btretur.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btretur.Location = New System.Drawing.Point(786, 340)
        Me.btretur.Name = "btretur"
        Me.btretur.Size = New System.Drawing.Size(148, 41)
        Me.btretur.TabIndex = 67
        Me.btretur.Text = "Retur"
        Me.btretur.UseVisualStyleBackColor = True
        '
        'Textbox2
        '
        Me.Textbox2.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Textbox2.Location = New System.Drawing.Point(578, 264)
        Me.Textbox2.Multiline = True
        Me.Textbox2.Name = "Textbox2"
        Me.Textbox2.Size = New System.Drawing.Size(356, 31)
        Me.Textbox2.TabIndex = 102
        '
        'tyyh
        '
        Me.tyyh.AutoSize = True
        Me.tyyh.BackColor = System.Drawing.Color.Black
        Me.tyyh.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tyyh.ForeColor = System.Drawing.SystemColors.Control
        Me.tyyh.Location = New System.Drawing.Point(422, 301)
        Me.tyyh.Name = "tyyh"
        Me.tyyh.Size = New System.Drawing.Size(157, 31)
        Me.tyyh.TabIndex = 103
        Me.tyyh.Text = "Jumlah Beli :"
        '
        'textbox1
        '
        Me.textbox1.Location = New System.Drawing.Point(240, 159)
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(200, 22)
        Me.textbox1.TabIndex = 105
        '
        'bttambahorder
        '
        Me.bttambahorder.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttambahorder.Location = New System.Drawing.Point(392, 378)
        Me.bttambahorder.Name = "bttambahorder"
        Me.bttambahorder.Size = New System.Drawing.Size(145, 41)
        Me.bttambahorder.TabIndex = 106
        Me.bttambahorder.Text = "Tambah"
        Me.bttambahorder.UseVisualStyleBackColor = True
        '
        'btubahbeli
        '
        Me.btubahbeli.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahbeli.Location = New System.Drawing.Point(851, 378)
        Me.btubahbeli.Name = "btubahbeli"
        Me.btubahbeli.Size = New System.Drawing.Size(126, 41)
        Me.btubahbeli.TabIndex = 60
        Me.btubahbeli.Text = "Ubah"
        Me.btubahbeli.UseVisualStyleBackColor = True
        '
        'btlaporan
        '
        Me.btlaporan.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btlaporan.Location = New System.Drawing.Point(31, 269)
        Me.btlaporan.Name = "btlaporan"
        Me.btlaporan.Size = New System.Drawing.Size(10, 10)
        Me.btlaporan.TabIndex = 57
        Me.btlaporan.Text = "Laporan"
        Me.btlaporan.UseVisualStyleBackColor = True
        '
        'btutupbeli
        '
        Me.btutupbeli.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btutupbeli.Appearance.Options.UseFont = True
        Me.btutupbeli.ImageOptions.Image = CType(resources.GetObject("btutupbeli.ImageOptions.Image"), System.Drawing.Image)
        Me.btutupbeli.Location = New System.Drawing.Point(85, 366)
        Me.btutupbeli.Name = "btutupbeli"
        Me.btutupbeli.Size = New System.Drawing.Size(137, 41)
        Me.btutupbeli.TabIndex = 100
        Me.btutupbeli.Text = "Tutup"
        '
        'totalbelitb
        '
        Me.totalbelitb.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.totalbelitb.Location = New System.Drawing.Point(581, 0)
        Me.totalbelitb.Multiline = True
        Me.totalbelitb.Name = "totalbelitb"
        Me.totalbelitb.Size = New System.Drawing.Size(356, 31)
        Me.totalbelitb.TabIndex = 104
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(62, 98)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(915, 253)
        Me.GridControl2.TabIndex = 108
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
        Me.Panel1.Controls.Add(Me.GridControl1)
        Me.Panel1.Controls.Add(Me.totalbelitb)
        Me.Panel1.Controls.Add(Me.btutupbeli)
        Me.Panel1.Controls.Add(Me.btlaporan)
        Me.Panel1.Controls.Add(Me.btubahbeli)
        Me.Panel1.Controls.Add(Me.bttambahorder)
        Me.Panel1.Controls.Add(Me.bthapusbeli)
        Me.Panel1.Controls.Add(Me.bttambahbeli)
        Me.Panel1.Location = New System.Drawing.Point(-3, 298)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 466)
        Me.Panel1.TabIndex = 107
        '
        'formpembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.lines_stripes_black_background_119743_3840x2400
        Me.ClientSize = New System.Drawing.Size(997, 756)
        Me.Controls.Add(Me.tyyh)
        Me.Controls.Add(Me.Textbox2)
        Me.Controls.Add(Me.lbexpirebeli)
        Me.Controls.Add(Me.tbbathbeli)
        Me.Controls.Add(Me.lbstakhir)
        Me.Controls.Add(Me.tbhrgbeli)
        Me.Controls.Add(Me.lbhrgbeli)
        Me.Controls.Add(Me.btretur)
        Me.Controls.Add(Me.dgvpembelian)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.textbox1)
        Me.Controls.Add(Me.btviewbarang)
        Me.Controls.Add(Me.btviewsup)
        Me.Controls.Add(Me.lbtglbeli)
        Me.Controls.Add(Me.tbkodejual)
        Me.Controls.Add(Me.lbkodejual)
        Me.Controls.Add(Me.tbfakturbeli)
        Me.Controls.Add(Me.lbfakturbeli)
        Me.Controls.Add(Me.Textbox3)
        Me.Controls.Add(Me.lbnamasup)
        Me.Controls.Add(Me.tbidbeli)
        Me.Controls.Add(Me.lbidbeli)
        Me.Controls.Add(Me.tbnamabrg)
        Me.Controls.Add(Me.lbnamabrg)
        Me.Controls.Add(Me.tbkodesup)
        Me.Controls.Add(Me.lbkodesup)
        Me.Controls.Add(Me.tbtotbeli)
        Me.Controls.Add(Me.lbtotbeli)
        Me.Name = "formpembelian"
        Me.Text = "Data Pembelian"
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttambahbeli As System.Windows.Forms.Button
    Friend WithEvents lbstakhir As System.Windows.Forms.Label
    Friend WithEvents tbhrgbeli As System.Windows.Forms.TextBox
    Friend WithEvents lbhrgbeli As System.Windows.Forms.Label
    Friend WithEvents tbkodejual As System.Windows.Forms.TextBox
    Friend WithEvents lbkodejual As System.Windows.Forms.Label
    Friend WithEvents tbfakturbeli As System.Windows.Forms.TextBox
    Friend WithEvents lbfakturbeli As System.Windows.Forms.Label
    Friend WithEvents Textbox3 As System.Windows.Forms.TextBox
    Friend WithEvents lbnamasup As System.Windows.Forms.Label
    Friend WithEvents tbidbeli As System.Windows.Forms.TextBox
    Friend WithEvents lbidbeli As System.Windows.Forms.Label
    Friend WithEvents tbnamabrg As System.Windows.Forms.TextBox
    Friend WithEvents lbnamabrg As System.Windows.Forms.Label
    Friend WithEvents tbkodesup As System.Windows.Forms.TextBox
    Friend WithEvents lbkodesup As System.Windows.Forms.Label
    Friend WithEvents tbtotbeli As System.Windows.Forms.TextBox
    Friend WithEvents lbtotbeli As System.Windows.Forms.Label
    Friend WithEvents dgvpembelian As System.Windows.Forms.DataGridView
    Friend WithEvents bthapusbeli As System.Windows.Forms.Button
    Friend WithEvents lbtglbeli As System.Windows.Forms.Label
    Friend WithEvents btviewsup As System.Windows.Forms.Button
    Friend WithEvents btviewbarang As System.Windows.Forms.Button
    Friend WithEvents tbbathbeli As System.Windows.Forms.TextBox
    Friend WithEvents lbexpirebeli As System.Windows.Forms.Label
    Friend WithEvents btretur As System.Windows.Forms.Button
    Friend WithEvents Textbox2 As System.Windows.Forms.TextBox
    Friend WithEvents tyyh As System.Windows.Forms.Label
    Friend WithEvents textbox1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents bttambahorder As System.Windows.Forms.Button
    Friend WithEvents btubahbeli As System.Windows.Forms.Button
    Friend WithEvents btlaporan As System.Windows.Forms.Button
    Friend WithEvents btutupbeli As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents totalbelitb As System.Windows.Forms.TextBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
