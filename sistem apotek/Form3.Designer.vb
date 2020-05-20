<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formmenus
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim btkeluar As System.Windows.Forms.Button
        Me.btpembelian = New System.Windows.Forms.Button()
        Me.btpenjualan = New System.Windows.Forms.Button()
        Me.btgudang = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.lb3 = New System.Windows.Forms.Label()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.btgolongan = New System.Windows.Forms.Button()
        Me.btbarang = New System.Windows.Forms.Button()
        Me.btpegawai = New System.Windows.Forms.Button()
        Me.btsupplier = New System.Windows.Forms.Button()
        Me.btcustomer = New System.Windows.Forms.Button()
        Me.lbjabatan = New System.Windows.Forms.Label()
        Me.btlaporanbeli = New System.Windows.Forms.Button()
        Me.btlaporanjual = New System.Windows.Forms.Button()
        Me.btstok = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btubahjual = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        btkeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btkeluar
        '
        btkeluar.BackColor = System.Drawing.Color.Crimson
        btkeluar.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btkeluar.ForeColor = System.Drawing.Color.Wheat
        btkeluar.Location = New System.Drawing.Point(27, 531)
        btkeluar.Name = "btkeluar"
        btkeluar.Size = New System.Drawing.Size(95, 29)
        btkeluar.TabIndex = 11
        btkeluar.Text = "Keluar"
        btkeluar.UseVisualStyleBackColor = False
        AddHandler btkeluar.Click, AddressOf Me.btkeluar_Click
        '
        'btpembelian
        '
        Me.btpembelian.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btpembelian.Location = New System.Drawing.Point(27, 249)
        Me.btpembelian.Name = "btpembelian"
        Me.btpembelian.Size = New System.Drawing.Size(98, 24)
        Me.btpembelian.TabIndex = 1
        Me.btpembelian.Text = "Pembelian"
        Me.btpembelian.UseVisualStyleBackColor = True
        '
        'btpenjualan
        '
        Me.btpenjualan.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btpenjualan.Location = New System.Drawing.Point(27, 279)
        Me.btpenjualan.Name = "btpenjualan"
        Me.btpenjualan.Size = New System.Drawing.Size(95, 29)
        Me.btpenjualan.TabIndex = 2
        Me.btpenjualan.Text = "Penjualan"
        Me.btpenjualan.UseVisualStyleBackColor = True
        '
        'btgudang
        '
        Me.btgudang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btgudang.Location = New System.Drawing.Point(27, 314)
        Me.btgudang.Name = "btgudang"
        Me.btgudang.Size = New System.Drawing.Size(80, 31)
        Me.btgudang.TabIndex = 9
        Me.btgudang.Text = "Gudang"
        Me.btgudang.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 572)
        Me.Splitter1.TabIndex = 23
        Me.Splitter1.TabStop = False
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb3.ForeColor = System.Drawing.Color.White
        Me.lb3.Location = New System.Drawing.Point(23, 369)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(80, 22)
        Me.lb3.TabIndex = 19
        Me.lb3.Text = "Laporan"
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb2.ForeColor = System.Drawing.Color.White
        Me.lb2.Location = New System.Drawing.Point(21, 224)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(92, 23)
        Me.lb2.TabIndex = 15
        Me.lb2.Text = "Transaksi"
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.ForeColor = System.Drawing.Color.Transparent
        Me.lb1.Location = New System.Drawing.Point(21, 9)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(117, 23)
        Me.lb1.TabIndex = 14
        Me.lb1.Text = "Data Master"
        '
        'btgolongan
        '
        Me.btgolongan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btgolongan.Location = New System.Drawing.Point(25, 68)
        Me.btgolongan.Name = "btgolongan"
        Me.btgolongan.Size = New System.Drawing.Size(100, 29)
        Me.btgolongan.TabIndex = 12
        Me.btgolongan.Text = "Golongan"
        Me.btgolongan.UseVisualStyleBackColor = True
        '
        'btbarang
        '
        Me.btbarang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbarang.Location = New System.Drawing.Point(25, 34)
        Me.btbarang.Name = "btbarang"
        Me.btbarang.Size = New System.Drawing.Size(77, 28)
        Me.btbarang.TabIndex = 0
        Me.btbarang.Text = "Barang"
        Me.btbarang.UseVisualStyleBackColor = True
        '
        'btpegawai
        '
        Me.btpegawai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btpegawai.Location = New System.Drawing.Point(25, 103)
        Me.btpegawai.Name = "btpegawai"
        Me.btpegawai.Size = New System.Drawing.Size(88, 32)
        Me.btpegawai.TabIndex = 13
        Me.btpegawai.Text = "Pegawai"
        Me.btpegawai.UseVisualStyleBackColor = True
        '
        'btsupplier
        '
        Me.btsupplier.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsupplier.Location = New System.Drawing.Point(25, 141)
        Me.btsupplier.Name = "btsupplier"
        Me.btsupplier.Size = New System.Drawing.Size(93, 30)
        Me.btsupplier.TabIndex = 3
        Me.btsupplier.Text = "Supplier"
        Me.btsupplier.UseVisualStyleBackColor = True
        '
        'btcustomer
        '
        Me.btcustomer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcustomer.Location = New System.Drawing.Point(27, 177)
        Me.btcustomer.Name = "btcustomer"
        Me.btcustomer.Size = New System.Drawing.Size(101, 25)
        Me.btcustomer.TabIndex = 4
        Me.btcustomer.Text = "Customer"
        Me.btcustomer.UseVisualStyleBackColor = True
        '
        'lbjabatan
        '
        Me.lbjabatan.AutoSize = True
        Me.lbjabatan.Font = New System.Drawing.Font("Bodoni MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbjabatan.Location = New System.Drawing.Point(231, 9)
        Me.lbjabatan.Name = "lbjabatan"
        Me.lbjabatan.Size = New System.Drawing.Size(26, 36)
        Me.lbjabatan.TabIndex = 21
        Me.lbjabatan.Text = "-"
        '
        'btlaporanbeli
        '
        Me.btlaporanbeli.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btlaporanbeli.Location = New System.Drawing.Point(22, 394)
        Me.btlaporanbeli.Name = "btlaporanbeli"
        Me.btlaporanbeli.Size = New System.Drawing.Size(100, 30)
        Me.btlaporanbeli.TabIndex = 16
        Me.btlaporanbeli.Text = "Pembelian"
        Me.btlaporanbeli.UseVisualStyleBackColor = True
        '
        'btlaporanjual
        '
        Me.btlaporanjual.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btlaporanjual.Location = New System.Drawing.Point(22, 430)
        Me.btlaporanjual.Name = "btlaporanjual"
        Me.btlaporanjual.Size = New System.Drawing.Size(95, 31)
        Me.btlaporanjual.TabIndex = 17
        Me.btlaporanjual.Text = "Penjualan"
        Me.btlaporanjual.UseVisualStyleBackColor = True
        '
        'btstok
        '
        Me.btstok.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btstok.Location = New System.Drawing.Point(22, 467)
        Me.btstok.Name = "btstok"
        Me.btstok.Size = New System.Drawing.Size(70, 28)
        Me.btstok.TabIndex = 18
        Me.btstok.Text = "Stok"
        Me.btstok.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btubahjual)
        Me.Panel1.Controls.Add(btkeluar)
        Me.Panel1.Controls.Add(Me.btstok)
        Me.Panel1.Controls.Add(Me.btlaporanjual)
        Me.Panel1.Controls.Add(Me.btlaporanbeli)
        Me.Panel1.Controls.Add(Me.lb3)
        Me.Panel1.Controls.Add(Me.btgudang)
        Me.Panel1.Controls.Add(Me.btpenjualan)
        Me.Panel1.Controls.Add(Me.btpembelian)
        Me.Panel1.Controls.Add(Me.lb2)
        Me.Panel1.Controls.Add(Me.btbarang)
        Me.Panel1.Controls.Add(Me.btgolongan)
        Me.Panel1.Controls.Add(Me.btpegawai)
        Me.Panel1.Controls.Add(Me.lb1)
        Me.Panel1.Controls.Add(Me.btsupplier)
        Me.Panel1.Controls.Add(Me.btcustomer)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 572)
        Me.Panel1.TabIndex = 24
        '
        'btubahjual
        '
        Me.btubahjual.Location = New System.Drawing.Point(32, 506)
        Me.btubahjual.Name = "btubahjual"
        Me.btubahjual.Size = New System.Drawing.Size(75, 23)
        Me.btubahjual.TabIndex = 27
        Me.btubahjual.Text = "Ubah"
        Me.btubahjual.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape3, Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(200, 572)
        Me.ShapeContainer2.TabIndex = 15
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 2
        Me.LineShape5.X2 = 200
        Me.LineShape5.Y1 = 506
        Me.LineShape5.Y2 = 506
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 1
        Me.LineShape3.X2 = 199
        Me.LineShape3.Y1 = 356
        Me.LineShape3.Y2 = 356
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 1
        Me.LineShape2.X2 = 202
        Me.LineShape2.Y1 = 215
        Me.LineShape2.Y2 = 215
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(393, 572)
        Me.ShapeContainer1.TabIndex = 25
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 216
        Me.LineShape4.X2 = 365
        Me.LineShape4.Y1 = 48
        Me.LineShape4.Y2 = 48
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 75
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 23
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Darkroom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SketchFlow Print", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(220, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 26)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "BMD APOTEK"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(252, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "KAS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formmenus
        '
        Me.Appearance.BackColor = System.Drawing.Color.Teal
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 572)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbjabatan)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "formmenus"
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btpembelian As System.Windows.Forms.Button
    Friend WithEvents btpenjualan As System.Windows.Forms.Button
    Friend WithEvents btgudang As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents lb3 As System.Windows.Forms.Label
    Friend WithEvents lb2 As System.Windows.Forms.Label
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents btgolongan As System.Windows.Forms.Button
    Friend WithEvents btbarang As System.Windows.Forms.Button
    Friend WithEvents btpegawai As System.Windows.Forms.Button
    Friend WithEvents btsupplier As System.Windows.Forms.Button
    Friend WithEvents btcustomer As System.Windows.Forms.Button
    Friend WithEvents lbjabatan As System.Windows.Forms.Label
    Friend WithEvents btlaporanbeli As System.Windows.Forms.Button
    Friend WithEvents btlaporanjual As System.Windows.Forms.Button
    Friend WithEvents btstok As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btubahjual As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
