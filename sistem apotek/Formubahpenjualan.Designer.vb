<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formubahpenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formubahpenjualan))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tb_penjualan = New System.Windows.Forms.DateTimePicker()
        Me.tbtotaljual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.texbox3 = New System.Windows.Forms.TextBox()
        Me.btretur = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btlihatbrg = New System.Windows.Forms.Button()
        Me.lbtgljual = New System.Windows.Forms.Label()
        Me.btubahjual = New System.Windows.Forms.Button()
        Me.bthapusjual = New System.Windows.Forms.Button()
        Me.btbatalbeli = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.lbstakhir = New System.Windows.Forms.Label()
        Me.tbbeli = New System.Windows.Forms.TextBox()
        Me.lbbeli = New System.Windows.Forms.Label()
        Me.tbjual = New System.Windows.Forms.TextBox()
        Me.lbjual = New System.Windows.Forms.Label()
        Me.tbpajakjual = New System.Windows.Forms.TextBox()
        Me.lbnopajak = New System.Windows.Forms.Label()
        Me.tbdisc = New System.Windows.Forms.TextBox()
        Me.tbidjual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbnamabrg = New System.Windows.Forms.TextBox()
        Me.lbnama = New System.Windows.Forms.Label()
        Me.tbidcust = New System.Windows.Forms.TextBox()
        Me.lbidcust = New System.Windows.Forms.Label()
        Me.tbtotjual = New System.Windows.Forms.TextBox()
        Me.lbtotjual = New System.Windows.Forms.Label()
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        Me.lbdisc = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btutupbeli = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(211, 106)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 24)
        Me.ComboBox1.TabIndex = 174
        '
        'tb_penjualan
        '
        Me.tb_penjualan.Location = New System.Drawing.Point(700, 99)
        Me.tb_penjualan.Name = "tb_penjualan"
        Me.tb_penjualan.Size = New System.Drawing.Size(200, 22)
        Me.tb_penjualan.TabIndex = 173
        '
        'tbtotaljual
        '
        Me.tbtotaljual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbtotaljual.Location = New System.Drawing.Point(621, 301)
        Me.tbtotaljual.Multiline = True
        Me.tbtotaljual.Name = "tbtotaljual"
        Me.tbtotaljual.Size = New System.Drawing.Size(295, 31)
        Me.tbtotaljual.TabIndex = 172
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(465, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 31)
        Me.Label3.TabIndex = 171
        Me.Label3.Text = "Jumlah Beli :"
        '
        'texbox3
        '
        Me.texbox3.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.texbox3.Location = New System.Drawing.Point(621, 264)
        Me.texbox3.Multiline = True
        Me.texbox3.Name = "texbox3"
        Me.texbox3.Size = New System.Drawing.Size(295, 31)
        Me.texbox3.TabIndex = 170
        '
        'btretur
        '
        Me.btretur.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btretur.Location = New System.Drawing.Point(782, 360)
        Me.btretur.Name = "btretur"
        Me.btretur.Size = New System.Drawing.Size(148, 41)
        Me.btretur.TabIndex = 168
        Me.btretur.Text = "Retur"
        Me.btretur.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(460, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 31)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Expire Date:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.TextBox1.Location = New System.Drawing.Point(211, 312)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 31)
        Me.TextBox1.TabIndex = 166
        '
        'btlihatbrg
        '
        Me.btlihatbrg.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btlihatbrg.Location = New System.Drawing.Point(724, 136)
        Me.btlihatbrg.Name = "btlihatbrg"
        Me.btlihatbrg.Size = New System.Drawing.Size(192, 41)
        Me.btlihatbrg.TabIndex = 165
        Me.btlihatbrg.Text = "Data Barang"
        Me.btlihatbrg.UseVisualStyleBackColor = True
        '
        'lbtgljual
        '
        Me.lbtgljual.AutoSize = True
        Me.lbtgljual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbtgljual.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbtgljual.Location = New System.Drawing.Point(469, 90)
        Me.lbtgljual.Name = "lbtgljual"
        Me.lbtgljual.Size = New System.Drawing.Size(219, 31)
        Me.lbtgljual.TabIndex = 163
        Me.lbtgljual.Text = "Tanggal Penjualan:"
        '
        'btubahjual
        '
        Me.btubahjual.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahjual.Location = New System.Drawing.Point(849, 692)
        Me.btubahjual.Name = "btubahjual"
        Me.btubahjual.Size = New System.Drawing.Size(126, 41)
        Me.btubahjual.TabIndex = 162
        Me.btubahjual.Text = "Ubah"
        Me.btubahjual.UseVisualStyleBackColor = True
        '
        'bthapusjual
        '
        Me.bthapusjual.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bthapusjual.Location = New System.Drawing.Point(700, 692)
        Me.bthapusjual.Name = "bthapusjual"
        Me.bthapusjual.Size = New System.Drawing.Size(126, 41)
        Me.bthapusjual.TabIndex = 161
        Me.bthapusjual.Text = "Hapus"
        Me.bthapusjual.UseVisualStyleBackColor = True
        '
        'btbatalbeli
        '
        Me.btbatalbeli.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btbatalbeli.Location = New System.Drawing.Point(28, 361)
        Me.btbatalbeli.Name = "btbatalbeli"
        Me.btbatalbeli.Size = New System.Drawing.Size(10, 10)
        Me.btbatalbeli.TabIndex = 160
        Me.btbatalbeli.Text = "Batal"
        Me.btbatalbeli.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btsimpan.Location = New System.Drawing.Point(533, 692)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(148, 41)
        Me.btsimpan.TabIndex = 159
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'lbstakhir
        '
        Me.lbstakhir.AutoSize = True
        Me.lbstakhir.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbstakhir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbstakhir.Location = New System.Drawing.Point(54, 309)
        Me.lbstakhir.Name = "lbstakhir"
        Me.lbstakhir.Size = New System.Drawing.Size(131, 31)
        Me.lbstakhir.TabIndex = 158
        Me.lbstakhir.Text = "No. Batch:"
        '
        'tbbeli
        '
        Me.tbbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbbeli.Location = New System.Drawing.Point(211, 352)
        Me.tbbeli.Multiline = True
        Me.tbbeli.Name = "tbbeli"
        Me.tbbeli.Size = New System.Drawing.Size(166, 31)
        Me.tbbeli.TabIndex = 157
        '
        'lbbeli
        '
        Me.lbbeli.AutoSize = True
        Me.lbbeli.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbbeli.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbbeli.Location = New System.Drawing.Point(72, 352)
        Me.lbbeli.Name = "lbbeli"
        Me.lbbeli.Size = New System.Drawing.Size(78, 31)
        Me.lbbeli.TabIndex = 156
        Me.lbbeli.Text = "Harga"
        '
        'tbjual
        '
        Me.tbjual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbjual.Location = New System.Drawing.Point(211, 268)
        Me.tbjual.Multiline = True
        Me.tbjual.Name = "tbjual"
        Me.tbjual.Size = New System.Drawing.Size(166, 31)
        Me.tbjual.TabIndex = 155
        '
        'lbjual
        '
        Me.lbjual.AutoSize = True
        Me.lbjual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbjual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbjual.Location = New System.Drawing.Point(30, 268)
        Me.lbjual.Name = "lbjual"
        Me.lbjual.Size = New System.Drawing.Size(163, 31)
        Me.lbjual.TabIndex = 154
        Me.lbjual.Text = "Kode Barang:"
        '
        'tbpajakjual
        '
        Me.tbpajakjual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbpajakjual.Location = New System.Drawing.Point(986, 23)
        Me.tbpajakjual.Multiline = True
        Me.tbpajakjual.Name = "tbpajakjual"
        Me.tbpajakjual.Size = New System.Drawing.Size(10, 10)
        Me.tbpajakjual.TabIndex = 153
        '
        'lbnopajak
        '
        Me.lbnopajak.AutoSize = True
        Me.lbnopajak.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnopajak.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbnopajak.Location = New System.Drawing.Point(30, 99)
        Me.lbnopajak.Name = "lbnopajak"
        Me.lbnopajak.Size = New System.Drawing.Size(120, 31)
        Me.lbnopajak.TabIndex = 152
        Me.lbnopajak.Text = "No. Pajak"
        '
        'tbdisc
        '
        Me.tbdisc.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbdisc.Location = New System.Drawing.Point(621, 183)
        Me.tbdisc.Multiline = True
        Me.tbdisc.Name = "tbdisc"
        Me.tbdisc.Size = New System.Drawing.Size(295, 31)
        Me.tbdisc.TabIndex = 151
        '
        'tbidjual
        '
        Me.tbidjual.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidjual.Location = New System.Drawing.Point(211, 136)
        Me.tbidjual.Multiline = True
        Me.tbidjual.Name = "tbidjual"
        Me.tbidjual.Size = New System.Drawing.Size(186, 31)
        Me.tbidjual.TabIndex = 149
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(30, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 31)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "ID Penjualan:"
        '
        'tbnamabrg
        '
        Me.tbnamabrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnamabrg.Location = New System.Drawing.Point(621, 223)
        Me.tbnamabrg.Multiline = True
        Me.tbnamabrg.Name = "tbnamabrg"
        Me.tbnamabrg.Size = New System.Drawing.Size(295, 31)
        Me.tbnamabrg.TabIndex = 147
        '
        'lbnama
        '
        Me.lbnama.AutoSize = True
        Me.lbnama.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnama.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbnama.Location = New System.Drawing.Point(448, 223)
        Me.lbnama.Name = "lbnama"
        Me.lbnama.Size = New System.Drawing.Size(167, 31)
        Me.lbnama.TabIndex = 146
        Me.lbnama.Text = "Nama Barang:"
        '
        'tbidcust
        '
        Me.tbidcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidcust.Location = New System.Drawing.Point(211, 181)
        Me.tbidcust.Multiline = True
        Me.tbidcust.Name = "tbidcust"
        Me.tbidcust.Size = New System.Drawing.Size(186, 31)
        Me.tbidcust.TabIndex = 145
        '
        'lbidcust
        '
        Me.lbidcust.AutoSize = True
        Me.lbidcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbidcust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbidcust.Location = New System.Drawing.Point(26, 178)
        Me.lbidcust.Name = "lbidcust"
        Me.lbidcust.Size = New System.Drawing.Size(185, 31)
        Me.lbidcust.TabIndex = 144
        Me.lbidcust.Text = "Kode Customer"
        '
        'tbtotjual
        '
        Me.tbtotjual.Font = New System.Drawing.Font("Times New Roman", 20.0!)
        Me.tbtotjual.Location = New System.Drawing.Point(187, 39)
        Me.tbtotjual.Multiline = True
        Me.tbtotjual.Name = "tbtotjual"
        Me.tbtotjual.Size = New System.Drawing.Size(743, 42)
        Me.tbtotjual.TabIndex = 143
        '
        'lbtotjual
        '
        Me.lbtotjual.AutoSize = True
        Me.lbtotjual.Font = New System.Drawing.Font("Times New Roman", 22.0!)
        Me.lbtotjual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbtotjual.Location = New System.Drawing.Point(25, 39)
        Me.lbtotjual.Name = "lbtotjual"
        Me.lbtotjual.Size = New System.Drawing.Size(152, 42)
        Me.lbtotjual.TabIndex = 142
        Me.lbtotjual.Text = "Total Rp."
        '
        'dgvbarang
        '
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Location = New System.Drawing.Point(12, 360)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.RowTemplate.Height = 24
        Me.dgvbarang.Size = New System.Drawing.Size(10, 10)
        Me.dgvbarang.TabIndex = 141
        '
        'lbdisc
        '
        Me.lbdisc.AutoSize = True
        Me.lbdisc.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbdisc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbdisc.Location = New System.Drawing.Point(481, 186)
        Me.lbdisc.Name = "lbdisc"
        Me.lbdisc.Size = New System.Drawing.Size(97, 31)
        Me.lbdisc.TabIndex = 150
        Me.lbdisc.Text = "Diskon:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(526, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 41)
        Me.Button1.TabIndex = 175
        Me.Button1.Text = "Customer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btutupbeli
        '
        Me.btutupbeli.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btutupbeli.Appearance.Options.UseFont = True
        Me.btutupbeli.ImageOptions.Image = CType(resources.GetObject("btutupbeli.ImageOptions.Image"), System.Drawing.Image)
        Me.btutupbeli.Location = New System.Drawing.Point(60, 692)
        Me.btutupbeli.Name = "btutupbeli"
        Me.btutupbeli.Size = New System.Drawing.Size(137, 41)
        Me.btutupbeli.TabIndex = 169
        Me.btutupbeli.Text = "Tutup"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(60, 407)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(917, 261)
        Me.GridControl1.TabIndex = 178
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(501, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 17)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "Ubah Untuk Kekurangan Penjualan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(427, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "NOTES ="
        '
        'formubahpenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1018, 748)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.tb_penjualan)
        Me.Controls.Add(Me.tbtotaljual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.texbox3)
        Me.Controls.Add(Me.btutupbeli)
        Me.Controls.Add(Me.btretur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btlihatbrg)
        Me.Controls.Add(Me.lbtgljual)
        Me.Controls.Add(Me.btubahjual)
        Me.Controls.Add(Me.bthapusjual)
        Me.Controls.Add(Me.btbatalbeli)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.lbstakhir)
        Me.Controls.Add(Me.tbbeli)
        Me.Controls.Add(Me.lbbeli)
        Me.Controls.Add(Me.tbjual)
        Me.Controls.Add(Me.lbjual)
        Me.Controls.Add(Me.tbpajakjual)
        Me.Controls.Add(Me.lbnopajak)
        Me.Controls.Add(Me.tbdisc)
        Me.Controls.Add(Me.lbdisc)
        Me.Controls.Add(Me.tbidjual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbnamabrg)
        Me.Controls.Add(Me.lbnama)
        Me.Controls.Add(Me.tbidcust)
        Me.Controls.Add(Me.lbidcust)
        Me.Controls.Add(Me.tbtotjual)
        Me.Controls.Add(Me.lbtotjual)
        Me.Controls.Add(Me.dgvbarang)
        Me.Name = "formubahpenjualan"
        Me.Text = "Formubahpenjualan"
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents tb_penjualan As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbtotaljual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents texbox3 As System.Windows.Forms.TextBox
    Friend WithEvents btutupbeli As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btretur As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btlihatbrg As System.Windows.Forms.Button
    Friend WithEvents lbtgljual As System.Windows.Forms.Label
    Friend WithEvents btubahjual As System.Windows.Forms.Button
    Friend WithEvents bthapusjual As System.Windows.Forms.Button
    Friend WithEvents btbatalbeli As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents lbstakhir As System.Windows.Forms.Label
    Friend WithEvents tbbeli As System.Windows.Forms.TextBox
    Friend WithEvents lbbeli As System.Windows.Forms.Label
    Friend WithEvents tbjual As System.Windows.Forms.TextBox
    Friend WithEvents lbjual As System.Windows.Forms.Label
    Friend WithEvents tbpajakjual As System.Windows.Forms.TextBox
    Friend WithEvents lbnopajak As System.Windows.Forms.Label
    Friend WithEvents tbdisc As System.Windows.Forms.TextBox
    Friend WithEvents tbidjual As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbnamabrg As System.Windows.Forms.TextBox
    Friend WithEvents lbnama As System.Windows.Forms.Label
    Friend WithEvents tbidcust As System.Windows.Forms.TextBox
    Friend WithEvents lbidcust As System.Windows.Forms.Label
    Friend WithEvents tbtotjual As System.Windows.Forms.TextBox
    Friend WithEvents lbtotjual As System.Windows.Forms.Label
    Friend WithEvents dgvbarang As System.Windows.Forms.DataGridView
    Friend WithEvents lbdisc As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
