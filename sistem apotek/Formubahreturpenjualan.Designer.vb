<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formubahreturpenjualan
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
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.tbretur = New System.Windows.Forms.DateTimePicker()
        Me.bttambahrb = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        Me.tbfaktur = New System.Windows.Forms.RichTextBox()
        Me.tbjumlah = New System.Windows.Forms.RichTextBox()
        Me.tbnamabarang = New System.Windows.Forms.RichTextBox()
        Me.tbkodebarang = New System.Windows.Forms.RichTextBox()
        Me.tbidsuplier = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tbidpembelian = New System.Windows.Forms.RichTextBox()
        Me.lb_tglretur = New System.Windows.Forms.Label()
        Me.lb_nofaktur = New System.Windows.Forms.Label()
        Me.lb_jumlah = New System.Windows.Forms.Label()
        Me.lb_namabrg = New System.Windows.Forms.Label()
        Me.lb_kodebarang = New System.Windows.Forms.Label()
        Me.lb_idsupplier = New System.Windows.Forms.Label()
        Me.lb_returpemb = New System.Windows.Forms.Label()
        Me.Lb_idpembelian = New System.Windows.Forms.Label()
        Me.bthapusrb = New System.Windows.Forms.Button()
        Me.bttutuprb = New System.Windows.Forms.Button()
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.RadioButton2.Location = New System.Drawing.Point(859, 51)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(92, 21)
        Me.RadioButton2.TabIndex = 43
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Kelebihan"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.RadioButton1.Location = New System.Drawing.Point(658, 51)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(106, 21)
        Me.RadioButton1.TabIndex = 42
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Kekurangan"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'tbretur
        '
        Me.tbretur.Location = New System.Drawing.Point(349, 428)
        Me.tbretur.Name = "tbretur"
        Me.tbretur.Size = New System.Drawing.Size(200, 22)
        Me.tbretur.TabIndex = 41
        '
        'bttambahrb
        '
        Me.bttambahrb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttambahrb.Location = New System.Drawing.Point(775, 757)
        Me.bttambahrb.Name = "bttambahrb"
        Me.bttambahrb.Size = New System.Drawing.Size(127, 40)
        Me.bttambahrb.TabIndex = 40
        Me.bttambahrb.Text = "Ubah"
        Me.bttambahrb.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.Location = New System.Drawing.Point(615, 757)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(127, 40)
        Me.btsimpan.TabIndex = 39
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'dgvbarang
        '
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Location = New System.Drawing.Point(83, 481)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.RowTemplate.Height = 24
        Me.dgvbarang.Size = New System.Drawing.Size(969, 261)
        Me.dgvbarang.TabIndex = 38
        '
        'tbfaktur
        '
        Me.tbfaktur.Location = New System.Drawing.Point(349, 383)
        Me.tbfaktur.Name = "tbfaktur"
        Me.tbfaktur.Size = New System.Drawing.Size(257, 27)
        Me.tbfaktur.TabIndex = 37
        Me.tbfaktur.Text = ""
        '
        'tbjumlah
        '
        Me.tbjumlah.Location = New System.Drawing.Point(349, 338)
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(257, 27)
        Me.tbjumlah.TabIndex = 36
        Me.tbjumlah.Text = ""
        '
        'tbnamabarang
        '
        Me.tbnamabarang.Location = New System.Drawing.Point(349, 286)
        Me.tbnamabarang.Name = "tbnamabarang"
        Me.tbnamabarang.Size = New System.Drawing.Size(257, 27)
        Me.tbnamabarang.TabIndex = 35
        Me.tbnamabarang.Text = ""
        '
        'tbkodebarang
        '
        Me.tbkodebarang.Location = New System.Drawing.Point(349, 232)
        Me.tbkodebarang.Name = "tbkodebarang"
        Me.tbkodebarang.Size = New System.Drawing.Size(257, 27)
        Me.tbkodebarang.TabIndex = 34
        Me.tbkodebarang.Text = ""
        '
        'tbidsuplier
        '
        Me.tbidsuplier.Location = New System.Drawing.Point(349, 179)
        Me.tbidsuplier.Name = "tbidsuplier"
        Me.tbidsuplier.Size = New System.Drawing.Size(257, 27)
        Me.tbidsuplier.TabIndex = 33
        Me.tbidsuplier.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(349, 115)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(257, 24)
        Me.ComboBox1.TabIndex = 32
        '
        'tbidpembelian
        '
        Me.tbidpembelian.Location = New System.Drawing.Point(349, 45)
        Me.tbidpembelian.Name = "tbidpembelian"
        Me.tbidpembelian.Size = New System.Drawing.Size(257, 27)
        Me.tbidpembelian.TabIndex = 31
        Me.tbidpembelian.Text = ""
        '
        'lb_tglretur
        '
        Me.lb_tglretur.AutoSize = True
        Me.lb_tglretur.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tglretur.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_tglretur.Location = New System.Drawing.Point(78, 423)
        Me.lb_tglretur.Name = "lb_tglretur"
        Me.lb_tglretur.Size = New System.Drawing.Size(146, 27)
        Me.lb_tglretur.TabIndex = 30
        Me.lb_tglretur.Text = "Tanggal Retur"
        '
        'lb_nofaktur
        '
        Me.lb_nofaktur.AutoSize = True
        Me.lb_nofaktur.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nofaktur.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_nofaktur.Location = New System.Drawing.Point(78, 379)
        Me.lb_nofaktur.Name = "lb_nofaktur"
        Me.lb_nofaktur.Size = New System.Drawing.Size(101, 27)
        Me.lb_nofaktur.TabIndex = 29
        Me.lb_nofaktur.Text = "No Pajak"
        '
        'lb_jumlah
        '
        Me.lb_jumlah.AutoSize = True
        Me.lb_jumlah.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_jumlah.ForeColor = System.Drawing.SystemColors.Control
        Me.lb_jumlah.Location = New System.Drawing.Point(78, 334)
        Me.lb_jumlah.Name = "lb_jumlah"
        Me.lb_jumlah.Size = New System.Drawing.Size(80, 27)
        Me.lb_jumlah.TabIndex = 28
        Me.lb_jumlah.Text = "Jumlah"
        '
        'lb_namabrg
        '
        Me.lb_namabrg.AutoSize = True
        Me.lb_namabrg.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_namabrg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_namabrg.Location = New System.Drawing.Point(78, 282)
        Me.lb_namabrg.Name = "lb_namabrg"
        Me.lb_namabrg.Size = New System.Drawing.Size(144, 27)
        Me.lb_namabrg.TabIndex = 27
        Me.lb_namabrg.Text = "Nama Barang"
        '
        'lb_kodebarang
        '
        Me.lb_kodebarang.AutoSize = True
        Me.lb_kodebarang.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_kodebarang.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lb_kodebarang.Location = New System.Drawing.Point(78, 228)
        Me.lb_kodebarang.Name = "lb_kodebarang"
        Me.lb_kodebarang.Size = New System.Drawing.Size(139, 27)
        Me.lb_kodebarang.TabIndex = 26
        Me.lb_kodebarang.Text = "Kode Barang"
        '
        'lb_idsupplier
        '
        Me.lb_idsupplier.AutoSize = True
        Me.lb_idsupplier.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_idsupplier.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lb_idsupplier.Location = New System.Drawing.Point(78, 175)
        Me.lb_idsupplier.Name = "lb_idsupplier"
        Me.lb_idsupplier.Size = New System.Drawing.Size(136, 27)
        Me.lb_idsupplier.TabIndex = 25
        Me.lb_idsupplier.Text = "ID Customer"
        '
        'lb_returpemb
        '
        Me.lb_returpemb.AutoSize = True
        Me.lb_returpemb.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_returpemb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_returpemb.Location = New System.Drawing.Point(78, 112)
        Me.lb_returpemb.Name = "lb_returpemb"
        Me.lb_returpemb.Size = New System.Drawing.Size(198, 27)
        Me.lb_returpemb.TabIndex = 24
        Me.lb_returpemb.Text = "ID Retur Penjualan"
        '
        'Lb_idpembelian
        '
        Me.Lb_idpembelian.AutoSize = True
        Me.Lb_idpembelian.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_idpembelian.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lb_idpembelian.Location = New System.Drawing.Point(78, 41)
        Me.Lb_idpembelian.Name = "Lb_idpembelian"
        Me.Lb_idpembelian.Size = New System.Drawing.Size(138, 27)
        Me.Lb_idpembelian.TabIndex = 23
        Me.Lb_idpembelian.Text = "ID Penjualan"
        '
        'bthapusrb
        '
        Me.bthapusrb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapusrb.Location = New System.Drawing.Point(924, 757)
        Me.bthapusrb.Name = "bthapusrb"
        Me.bthapusrb.Size = New System.Drawing.Size(127, 40)
        Me.bthapusrb.TabIndex = 44
        Me.bthapusrb.Text = "Hapus"
        Me.bthapusrb.UseVisualStyleBackColor = True
        '
        'bttutuprb
        '
        Me.bttutuprb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutuprb.Location = New System.Drawing.Point(83, 757)
        Me.bttutuprb.Name = "bttutuprb"
        Me.bttutuprb.Size = New System.Drawing.Size(127, 40)
        Me.bttutuprb.TabIndex = 45
        Me.bttutuprb.Text = "Tutup"
        Me.bttutuprb.UseVisualStyleBackColor = True
        '
        'Formubahreturpenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1080, 877)
        Me.Controls.Add(Me.bttutuprb)
        Me.Controls.Add(Me.bthapusrb)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.tbretur)
        Me.Controls.Add(Me.bttambahrb)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.dgvbarang)
        Me.Controls.Add(Me.tbfaktur)
        Me.Controls.Add(Me.tbjumlah)
        Me.Controls.Add(Me.tbnamabarang)
        Me.Controls.Add(Me.tbkodebarang)
        Me.Controls.Add(Me.tbidsuplier)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.tbidpembelian)
        Me.Controls.Add(Me.lb_tglretur)
        Me.Controls.Add(Me.lb_nofaktur)
        Me.Controls.Add(Me.lb_jumlah)
        Me.Controls.Add(Me.lb_namabrg)
        Me.Controls.Add(Me.lb_kodebarang)
        Me.Controls.Add(Me.lb_idsupplier)
        Me.Controls.Add(Me.lb_returpemb)
        Me.Controls.Add(Me.Lb_idpembelian)
        Me.Name = "Formubahreturpenjualan"
        Me.Text = "Formubahreturpenjualan"
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents tbretur As System.Windows.Forms.DateTimePicker
    Friend WithEvents bttambahrb As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents dgvbarang As System.Windows.Forms.DataGridView
    Friend WithEvents tbfaktur As System.Windows.Forms.RichTextBox
    Friend WithEvents tbjumlah As System.Windows.Forms.RichTextBox
    Friend WithEvents tbnamabarang As System.Windows.Forms.RichTextBox
    Friend WithEvents tbkodebarang As System.Windows.Forms.RichTextBox
    Friend WithEvents tbidsuplier As System.Windows.Forms.RichTextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents tbidpembelian As System.Windows.Forms.RichTextBox
    Friend WithEvents lb_tglretur As System.Windows.Forms.Label
    Friend WithEvents lb_nofaktur As System.Windows.Forms.Label
    Friend WithEvents lb_jumlah As System.Windows.Forms.Label
    Friend WithEvents lb_namabrg As System.Windows.Forms.Label
    Friend WithEvents lb_kodebarang As System.Windows.Forms.Label
    Friend WithEvents lb_idsupplier As System.Windows.Forms.Label
    Friend WithEvents lb_returpemb As System.Windows.Forms.Label
    Friend WithEvents Lb_idpembelian As System.Windows.Forms.Label
    Friend WithEvents bthapusrb As System.Windows.Forms.Button
    Friend WithEvents bttutuprb As System.Windows.Forms.Button
End Class
