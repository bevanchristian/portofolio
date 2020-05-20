<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formstok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formstok))
        Me.tbstokmasuk = New System.Windows.Forms.TextBox()
        Me.lbmasuk = New System.Windows.Forms.Label()
        Me.btopname = New System.Windows.Forms.Button()
        Me.lbkotacust = New System.Windows.Forms.Label()
        Me.lbkeluar = New System.Windows.Forms.Label()
        Me.tbidbarangstok = New System.Windows.Forms.TextBox()
        Me.lbnamacust = New System.Windows.Forms.Label()
        Me.tbidstok = New System.Windows.Forms.TextBox()
        Me.lbkodecust = New System.Windows.Forms.Label()
        Me.tbstokakhir = New System.Windows.Forms.TextBox()
        Me.dgvstok = New System.Windows.Forms.DataGridView()
        Me.cbnamabarangstok = New System.Windows.Forms.ComboBox()
        Me.btubahstok = New System.Windows.Forms.Button()
        Me.btpenerimaanstok = New System.Windows.Forms.Button()
        Me.bthistorystok = New System.Windows.Forms.Button()
        Me.btlaporan = New System.Windows.Forms.Button()
        Me.btutupterima = New DevExpress.XtraEditors.SimpleButton()
        Me.btsimpanstok = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.dgvstok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbstokmasuk
        '
        Me.tbstokmasuk.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbstokmasuk.Location = New System.Drawing.Point(202, 343)
        Me.tbstokmasuk.Multiline = True
        Me.tbstokmasuk.Name = "tbstokmasuk"
        Me.tbstokmasuk.Size = New System.Drawing.Size(800, 31)
        Me.tbstokmasuk.TabIndex = 111
        '
        'lbmasuk
        '
        Me.lbmasuk.AutoSize = True
        Me.lbmasuk.BackColor = System.Drawing.Color.Transparent
        Me.lbmasuk.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbmasuk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbmasuk.Location = New System.Drawing.Point(15, 346)
        Me.lbmasuk.Name = "lbmasuk"
        Me.lbmasuk.Size = New System.Drawing.Size(150, 31)
        Me.lbmasuk.TabIndex = 110
        Me.lbmasuk.Text = "Stok Masuk:"
        '
        'btopname
        '
        Me.btopname.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btopname.Location = New System.Drawing.Point(829, 520)
        Me.btopname.Name = "btopname"
        Me.btopname.Size = New System.Drawing.Size(210, 41)
        Me.btopname.TabIndex = 108
        Me.btopname.Text = "Stok Opname"
        Me.btopname.UseVisualStyleBackColor = True
        '
        'lbkotacust
        '
        Me.lbkotacust.AutoSize = True
        Me.lbkotacust.BackColor = System.Drawing.Color.Transparent
        Me.lbkotacust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkotacust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbkotacust.Location = New System.Drawing.Point(17, 300)
        Me.lbkotacust.Name = "lbkotacust"
        Me.lbkotacust.Size = New System.Drawing.Size(167, 31)
        Me.lbkotacust.TabIndex = 103
        Me.lbkotacust.Text = "Nama Barang:"
        '
        'lbkeluar
        '
        Me.lbkeluar.AutoSize = True
        Me.lbkeluar.BackColor = System.Drawing.Color.Transparent
        Me.lbkeluar.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbkeluar.Location = New System.Drawing.Point(18, 387)
        Me.lbkeluar.Name = "lbkeluar"
        Me.lbkeluar.Size = New System.Drawing.Size(138, 31)
        Me.lbkeluar.TabIndex = 102
        Me.lbkeluar.Text = "Stok Akhir:"
        '
        'tbidbarangstok
        '
        Me.tbidbarangstok.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidbarangstok.Location = New System.Drawing.Point(200, 258)
        Me.tbidbarangstok.Multiline = True
        Me.tbidbarangstok.Name = "tbidbarangstok"
        Me.tbidbarangstok.Size = New System.Drawing.Size(802, 31)
        Me.tbidbarangstok.TabIndex = 101
        '
        'lbnamacust
        '
        Me.lbnamacust.AutoSize = True
        Me.lbnamacust.BackColor = System.Drawing.Color.Transparent
        Me.lbnamacust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnamacust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbnamacust.Location = New System.Drawing.Point(17, 258)
        Me.lbnamacust.Name = "lbnamacust"
        Me.lbnamacust.Size = New System.Drawing.Size(131, 31)
        Me.lbnamacust.TabIndex = 100
        Me.lbnamacust.Text = "ID Barang:"
        '
        'tbidstok
        '
        Me.tbidstok.Enabled = False
        Me.tbidstok.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidstok.Location = New System.Drawing.Point(200, 216)
        Me.tbidstok.Multiline = True
        Me.tbidstok.Name = "tbidstok"
        Me.tbidstok.Size = New System.Drawing.Size(802, 31)
        Me.tbidstok.TabIndex = 99
        '
        'lbkodecust
        '
        Me.lbkodecust.AutoSize = True
        Me.lbkodecust.BackColor = System.Drawing.Color.Transparent
        Me.lbkodecust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkodecust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbkodecust.Location = New System.Drawing.Point(18, 216)
        Me.lbkodecust.Name = "lbkodecust"
        Me.lbkodecust.Size = New System.Drawing.Size(104, 31)
        Me.lbkodecust.TabIndex = 98
        Me.lbkodecust.Text = "ID Stok:"
        '
        'tbstokakhir
        '
        Me.tbstokakhir.Enabled = False
        Me.tbstokakhir.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbstokakhir.Location = New System.Drawing.Point(200, 387)
        Me.tbstokakhir.Multiline = True
        Me.tbstokakhir.Name = "tbstokakhir"
        Me.tbstokakhir.Size = New System.Drawing.Size(802, 31)
        Me.tbstokakhir.TabIndex = 112
        '
        'dgvstok
        '
        Me.dgvstok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstok.Location = New System.Drawing.Point(1024, 193)
        Me.dgvstok.Name = "dgvstok"
        Me.dgvstok.RowTemplate.Height = 24
        Me.dgvstok.Size = New System.Drawing.Size(10, 10)
        Me.dgvstok.TabIndex = 116
        '
        'cbnamabarangstok
        '
        Me.cbnamabarangstok.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.cbnamabarangstok.FormattingEnabled = True
        Me.cbnamabarangstok.Location = New System.Drawing.Point(202, 300)
        Me.cbnamabarangstok.Name = "cbnamabarangstok"
        Me.cbnamabarangstok.Size = New System.Drawing.Size(800, 30)
        Me.cbnamabarangstok.TabIndex = 117
        '
        'btubahstok
        '
        Me.btubahstok.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahstok.Location = New System.Drawing.Point(500, 520)
        Me.btubahstok.Name = "btubahstok"
        Me.btubahstok.Size = New System.Drawing.Size(139, 41)
        Me.btubahstok.TabIndex = 118
        Me.btubahstok.Text = "Ubah"
        Me.btubahstok.UseVisualStyleBackColor = True
        '
        'btpenerimaanstok
        '
        Me.btpenerimaanstok.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btpenerimaanstok.Location = New System.Drawing.Point(343, 520)
        Me.btpenerimaanstok.Name = "btpenerimaanstok"
        Me.btpenerimaanstok.Size = New System.Drawing.Size(139, 41)
        Me.btpenerimaanstok.TabIndex = 119
        Me.btpenerimaanstok.Text = "Penerimaan"
        Me.btpenerimaanstok.UseVisualStyleBackColor = True
        '
        'bthistorystok
        '
        Me.bthistorystok.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthistorystok.Location = New System.Drawing.Point(189, 520)
        Me.bthistorystok.Name = "bthistorystok"
        Me.bthistorystok.Size = New System.Drawing.Size(139, 41)
        Me.bthistorystok.TabIndex = 120
        Me.bthistorystok.Text = "History"
        Me.bthistorystok.UseVisualStyleBackColor = True
        '
        'btlaporan
        '
        Me.btlaporan.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btlaporan.Location = New System.Drawing.Point(998, 193)
        Me.btlaporan.Name = "btlaporan"
        Me.btlaporan.Size = New System.Drawing.Size(10, 10)
        Me.btlaporan.TabIndex = 121
        Me.btlaporan.Text = "Laporan"
        Me.btlaporan.UseVisualStyleBackColor = True
        '
        'btutupterima
        '
        Me.btutupterima.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btutupterima.Appearance.Options.UseFont = True
        Me.btutupterima.ImageOptions.Image = CType(resources.GetObject("btutupterima.ImageOptions.Image"), System.Drawing.Image)
        Me.btutupterima.Location = New System.Drawing.Point(12, 520)
        Me.btutupterima.Name = "btutupterima"
        Me.btutupterima.Size = New System.Drawing.Size(137, 41)
        Me.btutupterima.TabIndex = 115
        Me.btutupterima.Text = "Tutup"
        '
        'btsimpanstok
        '
        Me.btsimpanstok.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btsimpanstok.Appearance.Options.UseFont = True
        Me.btsimpanstok.ImageOptions.Image = CType(resources.GetObject("btsimpanstok.ImageOptions.Image"), System.Drawing.Image)
        Me.btsimpanstok.Location = New System.Drawing.Point(658, 522)
        Me.btsimpanstok.Name = "btsimpanstok"
        Me.btsimpanstok.Size = New System.Drawing.Size(153, 39)
        Me.btsimpanstok.TabIndex = 114
        Me.btsimpanstok.Text = "Simpan"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(21, 10)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(981, 177)
        Me.GridControl1.TabIndex = 122
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'Formstok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1051, 573)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btlaporan)
        Me.Controls.Add(Me.bthistorystok)
        Me.Controls.Add(Me.btpenerimaanstok)
        Me.Controls.Add(Me.btubahstok)
        Me.Controls.Add(Me.cbnamabarangstok)
        Me.Controls.Add(Me.dgvstok)
        Me.Controls.Add(Me.btutupterima)
        Me.Controls.Add(Me.btsimpanstok)
        Me.Controls.Add(Me.tbstokakhir)
        Me.Controls.Add(Me.tbstokmasuk)
        Me.Controls.Add(Me.lbmasuk)
        Me.Controls.Add(Me.btopname)
        Me.Controls.Add(Me.lbkotacust)
        Me.Controls.Add(Me.lbkeluar)
        Me.Controls.Add(Me.tbidbarangstok)
        Me.Controls.Add(Me.lbnamacust)
        Me.Controls.Add(Me.tbidstok)
        Me.Controls.Add(Me.lbkodecust)
        Me.Name = "Formstok"
        Me.Text = "Stok"
        CType(Me.dgvstok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbstokmasuk As System.Windows.Forms.TextBox
    Friend WithEvents lbmasuk As System.Windows.Forms.Label
    Friend WithEvents btopname As System.Windows.Forms.Button
    Friend WithEvents lbkotacust As System.Windows.Forms.Label
    Friend WithEvents lbkeluar As System.Windows.Forms.Label
    Friend WithEvents tbidbarangstok As System.Windows.Forms.TextBox
    Friend WithEvents lbnamacust As System.Windows.Forms.Label
    Friend WithEvents tbidstok As System.Windows.Forms.TextBox
    Friend WithEvents lbkodecust As System.Windows.Forms.Label
    Friend WithEvents tbstokakhir As System.Windows.Forms.TextBox
    Friend WithEvents btsimpanstok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btutupterima As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvstok As System.Windows.Forms.DataGridView
    Friend WithEvents cbnamabarangstok As System.Windows.Forms.ComboBox
    Friend WithEvents btubahstok As System.Windows.Forms.Button
    Friend WithEvents btpenerimaanstok As System.Windows.Forms.Button
    Friend WithEvents bthistorystok As System.Windows.Forms.Button
    Friend WithEvents btlaporan As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
