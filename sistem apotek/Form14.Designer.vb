<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formreturbeli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formreturbeli))
        Me.tbretur = New System.Windows.Forms.DateTimePicker()
        Me.tbnamabarang = New System.Windows.Forms.TextBox()
        Me.lbnama = New System.Windows.Forms.Label()
        Me.tbkodebarang = New System.Windows.Forms.TextBox()
        Me.lbjual = New System.Windows.Forms.Label()
        Me.btlihatbrg = New System.Windows.Forms.Button()
        Me.lbidcust = New System.Windows.Forms.Label()
        Me.tbidsuplier = New System.Windows.Forms.TextBox()
        Me.lbstakhir = New System.Windows.Forms.Label()
        Me.lbbeli = New System.Windows.Forms.Label()
        Me.tbjumlah = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.Label()
        Me.tbreturpembelian = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbidpembelian = New System.Windows.Forms.TextBox()
        Me.idpembelian = New System.Windows.Forms.Label()
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        Me.btubahrb = New System.Windows.Forms.Button()
        Me.btlaporan = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.bthapusrb = New DevExpress.XtraEditors.SimpleButton()
        Me.bttambahrb = New DevExpress.XtraEditors.SimpleButton()
        Me.bttutuprbeli = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbretur
        '
        Me.tbretur.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.tbretur.Location = New System.Drawing.Point(269, 331)
        Me.tbretur.Name = "tbretur"
        Me.tbretur.Size = New System.Drawing.Size(256, 34)
        Me.tbretur.TabIndex = 172
        '
        'tbnamabarang
        '
        Me.tbnamabarang.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnamabarang.Location = New System.Drawing.Point(269, 210)
        Me.tbnamabarang.Multiline = True
        Me.tbnamabarang.Name = "tbnamabarang"
        Me.tbnamabarang.Size = New System.Drawing.Size(256, 31)
        Me.tbnamabarang.TabIndex = 170
        '
        'lbnama
        '
        Me.lbnama.AutoSize = True
        Me.lbnama.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.lbnama.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbnama.Location = New System.Drawing.Point(34, 214)
        Me.lbnama.Name = "lbnama"
        Me.lbnama.Size = New System.Drawing.Size(150, 29)
        Me.lbnama.TabIndex = 169
        Me.lbnama.Text = "Nama Barang"
        '
        'tbkodebarang
        '
        Me.tbkodebarang.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbkodebarang.Location = New System.Drawing.Point(269, 162)
        Me.tbkodebarang.Multiline = True
        Me.tbkodebarang.Name = "tbkodebarang"
        Me.tbkodebarang.Size = New System.Drawing.Size(256, 31)
        Me.tbkodebarang.TabIndex = 166
        '
        'lbjual
        '
        Me.lbjual.AutoSize = True
        Me.lbjual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbjual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbjual.Location = New System.Drawing.Point(33, 165)
        Me.lbjual.Name = "lbjual"
        Me.lbjual.Size = New System.Drawing.Size(157, 31)
        Me.lbjual.TabIndex = 165
        Me.lbjual.Text = "Kode Barang"
        '
        'btlihatbrg
        '
        Me.btlihatbrg.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btlihatbrg.Location = New System.Drawing.Point(732, 424)
        Me.btlihatbrg.Name = "btlihatbrg"
        Me.btlihatbrg.Size = New System.Drawing.Size(192, 41)
        Me.btlihatbrg.TabIndex = 162
        Me.btlihatbrg.Text = "Data Barang"
        Me.btlihatbrg.UseVisualStyleBackColor = True
        '
        'lbidcust
        '
        Me.lbidcust.AutoSize = True
        Me.lbidcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbidcust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbidcust.Location = New System.Drawing.Point(33, 123)
        Me.lbidcust.Name = "lbidcust"
        Me.lbidcust.Size = New System.Drawing.Size(141, 31)
        Me.lbidcust.TabIndex = 161
        Me.lbidcust.Text = "ID Supplier"
        '
        'tbidsuplier
        '
        Me.tbidsuplier.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidsuplier.Location = New System.Drawing.Point(269, 115)
        Me.tbidsuplier.Multiline = True
        Me.tbidsuplier.Name = "tbidsuplier"
        Me.tbidsuplier.Size = New System.Drawing.Size(256, 31)
        Me.tbidsuplier.TabIndex = 160
        '
        'lbstakhir
        '
        Me.lbstakhir.AutoSize = True
        Me.lbstakhir.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbstakhir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbstakhir.Location = New System.Drawing.Point(33, 294)
        Me.lbstakhir.Name = "lbstakhir"
        Me.lbstakhir.Size = New System.Drawing.Size(125, 31)
        Me.lbstakhir.TabIndex = 159
        Me.lbstakhir.Text = "No Faktur"
        '
        'lbbeli
        '
        Me.lbbeli.AutoSize = True
        Me.lbbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbbeli.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbbeli.Location = New System.Drawing.Point(33, 334)
        Me.lbbeli.Name = "lbbeli"
        Me.lbbeli.Size = New System.Drawing.Size(166, 31)
        Me.lbbeli.TabIndex = 155
        Me.lbbeli.Text = "Tanggal Retur"
        '
        'tbjumlah
        '
        Me.tbjumlah.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbjumlah.Location = New System.Drawing.Point(269, 250)
        Me.tbjumlah.Multiline = True
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(256, 31)
        Me.tbjumlah.TabIndex = 154
        '
        'jumlah
        '
        Me.jumlah.AutoSize = True
        Me.jumlah.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.jumlah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.jumlah.Location = New System.Drawing.Point(33, 253)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(92, 31)
        Me.jumlah.TabIndex = 153
        Me.jumlah.Text = "Jumlah"
        '
        'tbreturpembelian
        '
        Me.tbreturpembelian.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbreturpembelian.Location = New System.Drawing.Point(269, 78)
        Me.tbreturpembelian.Multiline = True
        Me.tbreturpembelian.Name = "tbreturpembelian"
        Me.tbreturpembelian.Size = New System.Drawing.Size(256, 31)
        Me.tbreturpembelian.TabIndex = 148
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(33, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 31)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "ID Retur Pembelian"
        '
        'tbidpembelian
        '
        Me.tbidpembelian.Font = New System.Drawing.Font("Times New Roman", 20.0!)
        Me.tbidpembelian.Location = New System.Drawing.Point(269, 38)
        Me.tbidpembelian.Multiline = True
        Me.tbidpembelian.Name = "tbidpembelian"
        Me.tbidpembelian.Size = New System.Drawing.Size(256, 29)
        Me.tbidpembelian.TabIndex = 146
        '
        'idpembelian
        '
        Me.idpembelian.AutoSize = True
        Me.idpembelian.Font = New System.Drawing.Font("Times New Roman", 22.0!)
        Me.idpembelian.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.idpembelian.Location = New System.Drawing.Point(29, 25)
        Me.idpembelian.Name = "idpembelian"
        Me.idpembelian.Size = New System.Drawing.Size(218, 42)
        Me.idpembelian.TabIndex = 145
        Me.idpembelian.Text = "ID Pembelian"
        '
        'dgvbarang
        '
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Location = New System.Drawing.Point(39, 480)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.RowTemplate.Height = 24
        Me.dgvbarang.Size = New System.Drawing.Size(10, 262)
        Me.dgvbarang.TabIndex = 144
        '
        'btubahrb
        '
        Me.btubahrb.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahrb.Location = New System.Drawing.Point(377, 765)
        Me.btubahrb.Name = "btubahrb"
        Me.btubahrb.Size = New System.Drawing.Size(125, 41)
        Me.btubahrb.TabIndex = 178
        Me.btubahrb.Text = "Ubah"
        Me.btubahrb.UseVisualStyleBackColor = True
        '
        'btlaporan
        '
        Me.btlaporan.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btlaporan.Location = New System.Drawing.Point(9, 720)
        Me.btlaporan.Name = "btlaporan"
        Me.btlaporan.Size = New System.Drawing.Size(10, 10)
        Me.btlaporan.TabIndex = 175
        Me.btlaporan.Text = "Laporan"
        Me.btlaporan.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(269, 294)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox1.TabIndex = 182
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btsimpan.Location = New System.Drawing.Point(821, 765)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(125, 41)
        Me.btsimpan.TabIndex = 183
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'bthapusrb
        '
        Me.bthapusrb.Appearance.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.bthapusrb.Appearance.Options.UseFont = True
        Me.bthapusrb.ImageOptions.Image = CType(resources.GetObject("bthapusrb.ImageOptions.Image"), System.Drawing.Image)
        Me.bthapusrb.Location = New System.Drawing.Point(675, 767)
        Me.bthapusrb.Name = "bthapusrb"
        Me.bthapusrb.Size = New System.Drawing.Size(140, 41)
        Me.bthapusrb.TabIndex = 181
        Me.bthapusrb.Text = "Hapus"
        '
        'bttambahrb
        '
        Me.bttambahrb.Appearance.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.bttambahrb.Appearance.Options.UseFont = True
        Me.bttambahrb.ImageOptions.Image = CType(resources.GetObject("bttambahrb.ImageOptions.Image"), System.Drawing.Image)
        Me.bttambahrb.Location = New System.Drawing.Point(518, 767)
        Me.bttambahrb.Name = "bttambahrb"
        Me.bttambahrb.Size = New System.Drawing.Size(146, 40)
        Me.bttambahrb.TabIndex = 180
        Me.bttambahrb.Text = "Tambah"
        '
        'bttutuprbeli
        '
        Me.bttutuprbeli.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttutuprbeli.Appearance.Options.UseFont = True
        Me.bttutuprbeli.ImageOptions.Image = CType(resources.GetObject("bttutuprbeli.ImageOptions.Image"), System.Drawing.Image)
        Me.bttutuprbeli.Location = New System.Drawing.Point(25, 768)
        Me.bttutuprbeli.Name = "bttutuprbeli"
        Me.bttutuprbeli.Size = New System.Drawing.Size(137, 41)
        Me.bttutuprbeli.TabIndex = 179
        Me.bttutuprbeli.Text = "Tutup"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(25, 480)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(927, 282)
        Me.GridControl1.TabIndex = 184
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.unnamed
        Me.PictureBox4.Location = New System.Drawing.Point(717, -2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(295, 245)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 191
        Me.PictureBox4.TabStop = False
        '
        'formreturbeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1010, 818)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.bthapusrb)
        Me.Controls.Add(Me.bttambahrb)
        Me.Controls.Add(Me.bttutuprbeli)
        Me.Controls.Add(Me.btubahrb)
        Me.Controls.Add(Me.btlaporan)
        Me.Controls.Add(Me.tbretur)
        Me.Controls.Add(Me.tbnamabarang)
        Me.Controls.Add(Me.lbnama)
        Me.Controls.Add(Me.tbkodebarang)
        Me.Controls.Add(Me.lbjual)
        Me.Controls.Add(Me.btlihatbrg)
        Me.Controls.Add(Me.lbidcust)
        Me.Controls.Add(Me.tbidsuplier)
        Me.Controls.Add(Me.lbstakhir)
        Me.Controls.Add(Me.lbbeli)
        Me.Controls.Add(Me.tbjumlah)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.tbreturpembelian)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbidpembelian)
        Me.Controls.Add(Me.idpembelian)
        Me.Controls.Add(Me.dgvbarang)
        Me.Name = "formreturbeli"
        Me.Text = "Retur Pembelian"
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbretur As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents lbnama As System.Windows.Forms.Label
    Friend WithEvents tbkodebarang As System.Windows.Forms.TextBox
    Friend WithEvents lbjual As System.Windows.Forms.Label
    Friend WithEvents btlihatbrg As System.Windows.Forms.Button
    Friend WithEvents lbidcust As System.Windows.Forms.Label
    Friend WithEvents tbidsuplier As System.Windows.Forms.TextBox
    Friend WithEvents lbstakhir As System.Windows.Forms.Label
    Friend WithEvents lbbeli As System.Windows.Forms.Label
    Friend WithEvents tbjumlah As System.Windows.Forms.TextBox
    Friend WithEvents jumlah As System.Windows.Forms.Label
    Friend WithEvents tbreturpembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbidpembelian As System.Windows.Forms.TextBox
    Friend WithEvents idpembelian As System.Windows.Forms.Label
    Friend WithEvents dgvbarang As System.Windows.Forms.DataGridView
    Friend WithEvents btubahrb As System.Windows.Forms.Button
    Friend WithEvents btlaporan As System.Windows.Forms.Button
    Friend WithEvents bttutuprbeli As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttambahrb As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bthapusrb As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
