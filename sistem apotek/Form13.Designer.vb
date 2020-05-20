<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formreturjual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formreturjual))
        Me.tbnamabarang = New System.Windows.Forms.TextBox()
        Me.lbalamatcust = New System.Windows.Forms.Label()
        Me.tbkodebarang = New System.Windows.Forms.TextBox()
        Me.gfdzfg = New System.Windows.Forms.Label()
        Me.btlihatbrg = New System.Windows.Forms.Button()
        Me.lbidcust = New System.Windows.Forms.Label()
        Me.tbidsuplier = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.Label()
        Me.tbreturpenjualan = New System.Windows.Forms.TextBox()
        Me.lbreturpenjualan = New System.Windows.Forms.Label()
        Me.tbidpenjualan = New System.Windows.Forms.TextBox()
        Me.idpenjualan = New System.Windows.Forms.Label()
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        Me.tbjumlah = New System.Windows.Forms.TextBox()
        Me.btubahrj = New System.Windows.Forms.Button()
        Me.btbatalrj = New System.Windows.Forms.Button()
        Me.lbstakhir = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbbeli = New System.Windows.Forms.Label()
        Me.tbretur = New System.Windows.Forms.DateTimePicker()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.bthapusrj = New DevExpress.XtraEditors.SimpleButton()
        Me.bttambahrj = New DevExpress.XtraEditors.SimpleButton()
        Me.bttutuprjual = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbnamabarang
        '
        Me.tbnamabarang.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnamabarang.Location = New System.Drawing.Point(291, 208)
        Me.tbnamabarang.Multiline = True
        Me.tbnamabarang.Name = "tbnamabarang"
        Me.tbnamabarang.Size = New System.Drawing.Size(260, 31)
        Me.tbnamabarang.TabIndex = 140
        '
        'lbalamatcust
        '
        Me.lbalamatcust.AutoSize = True
        Me.lbalamatcust.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.lbalamatcust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbalamatcust.Location = New System.Drawing.Point(57, 210)
        Me.lbalamatcust.Name = "lbalamatcust"
        Me.lbalamatcust.Size = New System.Drawing.Size(150, 29)
        Me.lbalamatcust.TabIndex = 139
        Me.lbalamatcust.Text = "Nama Barang"
        '
        'tbkodebarang
        '
        Me.tbkodebarang.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbkodebarang.Location = New System.Drawing.Point(291, 167)
        Me.tbkodebarang.Multiline = True
        Me.tbkodebarang.Name = "tbkodebarang"
        Me.tbkodebarang.Size = New System.Drawing.Size(260, 31)
        Me.tbkodebarang.TabIndex = 136
        '
        'gfdzfg
        '
        Me.gfdzfg.AutoSize = True
        Me.gfdzfg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.gfdzfg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gfdzfg.Location = New System.Drawing.Point(56, 170)
        Me.gfdzfg.Name = "gfdzfg"
        Me.gfdzfg.Size = New System.Drawing.Size(157, 31)
        Me.gfdzfg.TabIndex = 135
        Me.gfdzfg.Text = "Kode Barang"
        '
        'btlihatbrg
        '
        Me.btlihatbrg.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btlihatbrg.Location = New System.Drawing.Point(760, 397)
        Me.btlihatbrg.Name = "btlihatbrg"
        Me.btlihatbrg.Size = New System.Drawing.Size(192, 41)
        Me.btlihatbrg.TabIndex = 132
        Me.btlihatbrg.Text = "Data Barang"
        Me.btlihatbrg.UseVisualStyleBackColor = True
        '
        'lbidcust
        '
        Me.lbidcust.AutoSize = True
        Me.lbidcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbidcust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbidcust.Location = New System.Drawing.Point(56, 128)
        Me.lbidcust.Name = "lbidcust"
        Me.lbidcust.Size = New System.Drawing.Size(153, 31)
        Me.lbidcust.TabIndex = 131
        Me.lbidcust.Text = "ID Customer"
        '
        'tbidsuplier
        '
        Me.tbidsuplier.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidsuplier.Location = New System.Drawing.Point(292, 120)
        Me.tbidsuplier.Multiline = True
        Me.tbidsuplier.Name = "tbidsuplier"
        Me.tbidsuplier.Size = New System.Drawing.Size(259, 31)
        Me.tbidsuplier.TabIndex = 130
        '
        'jumlah
        '
        Me.jumlah.AutoSize = True
        Me.jumlah.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.jumlah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.jumlah.Location = New System.Drawing.Point(58, 252)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(92, 31)
        Me.jumlah.TabIndex = 123
        Me.jumlah.Text = "Jumlah"
        '
        'tbreturpenjualan
        '
        Me.tbreturpenjualan.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbreturpenjualan.Location = New System.Drawing.Point(292, 83)
        Me.tbreturpenjualan.Multiline = True
        Me.tbreturpenjualan.Name = "tbreturpenjualan"
        Me.tbreturpenjualan.Size = New System.Drawing.Size(259, 31)
        Me.tbreturpenjualan.TabIndex = 117
        '
        'lbreturpenjualan
        '
        Me.lbreturpenjualan.AutoSize = True
        Me.lbreturpenjualan.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbreturpenjualan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbreturpenjualan.Location = New System.Drawing.Point(56, 83)
        Me.lbreturpenjualan.Name = "lbreturpenjualan"
        Me.lbreturpenjualan.Size = New System.Drawing.Size(224, 31)
        Me.lbreturpenjualan.TabIndex = 116
        Me.lbreturpenjualan.Text = "ID Retur Penjualan"
        '
        'tbidpenjualan
        '
        Me.tbidpenjualan.Font = New System.Drawing.Font("Times New Roman", 20.0!)
        Me.tbidpenjualan.Location = New System.Drawing.Point(292, 42)
        Me.tbidpenjualan.Multiline = True
        Me.tbidpenjualan.Name = "tbidpenjualan"
        Me.tbidpenjualan.Size = New System.Drawing.Size(259, 30)
        Me.tbidpenjualan.TabIndex = 115
        '
        'idpenjualan
        '
        Me.idpenjualan.AutoSize = True
        Me.idpenjualan.Font = New System.Drawing.Font("Times New Roman", 22.0!)
        Me.idpenjualan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.idpenjualan.Location = New System.Drawing.Point(52, 30)
        Me.idpenjualan.Name = "idpenjualan"
        Me.idpenjualan.Size = New System.Drawing.Size(209, 42)
        Me.idpenjualan.TabIndex = 114
        Me.idpenjualan.Text = "ID Penjualan"
        '
        'dgvbarang
        '
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Location = New System.Drawing.Point(62, 485)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.RowTemplate.Height = 24
        Me.dgvbarang.Size = New System.Drawing.Size(10, 262)
        Me.dgvbarang.TabIndex = 113
        '
        'tbjumlah
        '
        Me.tbjumlah.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbjumlah.Location = New System.Drawing.Point(291, 252)
        Me.tbjumlah.Multiline = True
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(260, 31)
        Me.tbjumlah.TabIndex = 124
        '
        'btubahrj
        '
        Me.btubahrj.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahrj.Location = New System.Drawing.Point(589, 752)
        Me.btubahrj.Name = "btubahrj"
        Me.btubahrj.Size = New System.Drawing.Size(126, 41)
        Me.btubahrj.TabIndex = 148
        Me.btubahrj.Text = "Ubah"
        Me.btubahrj.UseVisualStyleBackColor = True
        '
        'btbatalrj
        '
        Me.btbatalrj.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btbatalrj.Location = New System.Drawing.Point(449, 752)
        Me.btbatalrj.Name = "btbatalrj"
        Me.btbatalrj.Size = New System.Drawing.Size(126, 41)
        Me.btbatalrj.TabIndex = 145
        Me.btbatalrj.Text = "Batal"
        Me.btbatalrj.UseVisualStyleBackColor = True
        '
        'lbstakhir
        '
        Me.lbstakhir.AutoSize = True
        Me.lbstakhir.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbstakhir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbstakhir.Location = New System.Drawing.Point(59, 294)
        Me.lbstakhir.Name = "lbstakhir"
        Me.lbstakhir.Size = New System.Drawing.Size(113, 31)
        Me.lbstakhir.TabIndex = 184
        Me.lbstakhir.Text = "No Pajak"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(291, 294)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 24)
        Me.ComboBox1.TabIndex = 185
        '
        'lbbeli
        '
        Me.lbbeli.AutoSize = True
        Me.lbbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbbeli.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbbeli.Location = New System.Drawing.Point(59, 340)
        Me.lbbeli.Name = "lbbeli"
        Me.lbbeli.Size = New System.Drawing.Size(166, 31)
        Me.lbbeli.TabIndex = 186
        Me.lbbeli.Text = "Tanggal Retur"
        '
        'tbretur
        '
        Me.tbretur.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.tbretur.Location = New System.Drawing.Point(291, 340)
        Me.tbretur.Name = "tbretur"
        Me.tbretur.Size = New System.Drawing.Size(260, 34)
        Me.tbretur.TabIndex = 187
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btsimpan.Location = New System.Drawing.Point(879, 753)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(126, 41)
        Me.btsimpan.TabIndex = 188
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'bthapusrj
        '
        Me.bthapusrj.Appearance.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.bthapusrj.Appearance.Options.UseFont = True
        Me.bthapusrj.ImageOptions.Image = CType(resources.GetObject("bthapusrj.ImageOptions.Image"), System.Drawing.Image)
        Me.bthapusrj.Location = New System.Drawing.Point(12, 686)
        Me.bthapusrj.Name = "bthapusrj"
        Me.bthapusrj.Size = New System.Drawing.Size(10, 10)
        Me.bthapusrj.TabIndex = 183
        Me.bthapusrj.Text = "Hapus"
        '
        'bttambahrj
        '
        Me.bttambahrj.Appearance.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.bttambahrj.Appearance.Options.UseFont = True
        Me.bttambahrj.ImageOptions.Image = CType(resources.GetObject("bttambahrj.ImageOptions.Image"), System.Drawing.Image)
        Me.bttambahrj.Location = New System.Drawing.Point(721, 752)
        Me.bttambahrj.Name = "bttambahrj"
        Me.bttambahrj.Size = New System.Drawing.Size(147, 40)
        Me.bttambahrj.TabIndex = 182
        Me.bttambahrj.Text = "Tambah"
        '
        'bttutuprjual
        '
        Me.bttutuprjual.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttutuprjual.Appearance.Options.UseFont = True
        Me.bttutuprjual.ImageOptions.Image = CType(resources.GetObject("bttutuprjual.ImageOptions.Image"), System.Drawing.Image)
        Me.bttutuprjual.Location = New System.Drawing.Point(51, 753)
        Me.bttutuprjual.Name = "bttutuprjual"
        Me.bttutuprjual.Size = New System.Drawing.Size(137, 41)
        Me.bttutuprjual.TabIndex = 149
        Me.bttutuprjual.Text = "Tutup"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(51, 444)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(954, 303)
        Me.GridControl1.TabIndex = 189
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.unnamed
        Me.PictureBox4.Location = New System.Drawing.Point(742, -6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(295, 245)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 190
        Me.PictureBox4.TabStop = False
        '
        'formreturjual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1036, 845)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.tbretur)
        Me.Controls.Add(Me.lbbeli)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lbstakhir)
        Me.Controls.Add(Me.bthapusrj)
        Me.Controls.Add(Me.bttambahrj)
        Me.Controls.Add(Me.bttutuprjual)
        Me.Controls.Add(Me.btubahrj)
        Me.Controls.Add(Me.btbatalrj)
        Me.Controls.Add(Me.tbnamabarang)
        Me.Controls.Add(Me.lbalamatcust)
        Me.Controls.Add(Me.tbkodebarang)
        Me.Controls.Add(Me.gfdzfg)
        Me.Controls.Add(Me.btlihatbrg)
        Me.Controls.Add(Me.lbidcust)
        Me.Controls.Add(Me.tbidsuplier)
        Me.Controls.Add(Me.tbjumlah)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.tbreturpenjualan)
        Me.Controls.Add(Me.lbreturpenjualan)
        Me.Controls.Add(Me.tbidpenjualan)
        Me.Controls.Add(Me.idpenjualan)
        Me.Controls.Add(Me.dgvbarang)
        Me.Name = "formreturjual"
        Me.Text = "Retur Penjualan"
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents lbalamatcust As System.Windows.Forms.Label
    Friend WithEvents tbkodebarang As System.Windows.Forms.TextBox
    Friend WithEvents gfdzfg As System.Windows.Forms.Label
    Friend WithEvents btlihatbrg As System.Windows.Forms.Button
    Friend WithEvents lbidcust As System.Windows.Forms.Label
    Friend WithEvents tbidsuplier As System.Windows.Forms.TextBox
    Friend WithEvents jumlah As System.Windows.Forms.Label
    Friend WithEvents tbreturpenjualan As System.Windows.Forms.TextBox
    Friend WithEvents lbreturpenjualan As System.Windows.Forms.Label
    Friend WithEvents tbidpenjualan As System.Windows.Forms.TextBox
    Friend WithEvents idpenjualan As System.Windows.Forms.Label
    Friend WithEvents dgvbarang As System.Windows.Forms.DataGridView
    Friend WithEvents tbjumlah As System.Windows.Forms.TextBox
    Friend WithEvents btubahrj As System.Windows.Forms.Button
    Friend WithEvents btbatalrj As System.Windows.Forms.Button
    Friend WithEvents bttutuprjual As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bthapusrj As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttambahrj As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbstakhir As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbbeli As System.Windows.Forms.Label
    Friend WithEvents tbretur As System.Windows.Forms.DateTimePicker
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
