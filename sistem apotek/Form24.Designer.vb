<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formubahstok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formubahstok))
        Me.dgvubahstok = New System.Windows.Forms.DataGridView()
        Me.lbkodecust = New System.Windows.Forms.Label()
        Me.tbidubahstok = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbkotacust = New System.Windows.Forms.Label()
        Me.tbidbrgubahstok = New System.Windows.Forms.TextBox()
        Me.lbmsk = New System.Windows.Forms.Label()
        Me.tbmasukubah = New System.Windows.Forms.TextBox()
        Me.lbakhir = New System.Windows.Forms.Label()
        Me.tbakhirubah = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpubahstok = New System.Windows.Forms.DateTimePicker()
        Me.btubahstok = New System.Windows.Forms.Button()
        Me.rbkurang = New System.Windows.Forms.RadioButton()
        Me.rblebih = New System.Windows.Forms.RadioButton()
        Me.cbnamabrgubahstok = New System.Windows.Forms.ComboBox()
        Me.tbkeluarubah = New System.Windows.Forms.TextBox()
        Me.lbkluar = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bttutupubahstok = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.dgvubahstok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvubahstok
        '
        Me.dgvubahstok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvubahstok.Location = New System.Drawing.Point(12, 12)
        Me.dgvubahstok.Name = "dgvubahstok"
        Me.dgvubahstok.RowTemplate.Height = 24
        Me.dgvubahstok.Size = New System.Drawing.Size(10, 150)
        Me.dgvubahstok.TabIndex = 0
        '
        'lbkodecust
        '
        Me.lbkodecust.AutoSize = True
        Me.lbkodecust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkodecust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbkodecust.Location = New System.Drawing.Point(12, 186)
        Me.lbkodecust.Name = "lbkodecust"
        Me.lbkodecust.Size = New System.Drawing.Size(98, 31)
        Me.lbkodecust.TabIndex = 114
        Me.lbkodecust.Text = "ID Stok"
        '
        'tbidubahstok
        '
        Me.tbidubahstok.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidubahstok.Location = New System.Drawing.Point(174, 186)
        Me.tbidubahstok.Multiline = True
        Me.tbidubahstok.Name = "tbidubahstok"
        Me.tbidubahstok.Size = New System.Drawing.Size(521, 31)
        Me.tbidubahstok.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 31)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Nama Barang:"
        '
        'lbkotacust
        '
        Me.lbkotacust.AutoSize = True
        Me.lbkotacust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkotacust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbkotacust.Location = New System.Drawing.Point(12, 278)
        Me.lbkotacust.Name = "lbkotacust"
        Me.lbkotacust.Size = New System.Drawing.Size(131, 31)
        Me.lbkotacust.TabIndex = 132
        Me.lbkotacust.Text = "ID Barang:"
        '
        'tbidbrgubahstok
        '
        Me.tbidbrgubahstok.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidbrgubahstok.Location = New System.Drawing.Point(174, 278)
        Me.tbidbrgubahstok.Multiline = True
        Me.tbidbrgubahstok.Name = "tbidbrgubahstok"
        Me.tbidbrgubahstok.Size = New System.Drawing.Size(521, 31)
        Me.tbidbrgubahstok.TabIndex = 133
        '
        'lbmsk
        '
        Me.lbmsk.AutoSize = True
        Me.lbmsk.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbmsk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbmsk.Location = New System.Drawing.Point(12, 354)
        Me.lbmsk.Name = "lbmsk"
        Me.lbmsk.Size = New System.Drawing.Size(150, 31)
        Me.lbmsk.TabIndex = 134
        Me.lbmsk.Text = "Stok Masuk:"
        '
        'tbmasukubah
        '
        Me.tbmasukubah.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbmasukubah.Location = New System.Drawing.Point(174, 354)
        Me.tbmasukubah.Multiline = True
        Me.tbmasukubah.Name = "tbmasukubah"
        Me.tbmasukubah.Size = New System.Drawing.Size(521, 31)
        Me.tbmasukubah.TabIndex = 135
        '
        'lbakhir
        '
        Me.lbakhir.AutoSize = True
        Me.lbakhir.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbakhir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbakhir.Location = New System.Drawing.Point(12, 461)
        Me.lbakhir.Name = "lbakhir"
        Me.lbakhir.Size = New System.Drawing.Size(138, 31)
        Me.lbakhir.TabIndex = 136
        Me.lbakhir.Text = "Stok Akhir:"
        '
        'tbakhirubah
        '
        Me.tbakhirubah.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbakhirubah.Location = New System.Drawing.Point(174, 461)
        Me.tbakhirubah.Multiline = True
        Me.tbakhirubah.Name = "tbakhirubah"
        Me.tbakhirubah.Size = New System.Drawing.Size(521, 31)
        Me.tbakhirubah.TabIndex = 137
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 511)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 31)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Tanggal Ubah Stok"
        '
        'dtpubahstok
        '
        Me.dtpubahstok.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpubahstok.Location = New System.Drawing.Point(248, 508)
        Me.dtpubahstok.Name = "dtpubahstok"
        Me.dtpubahstok.Size = New System.Drawing.Size(447, 34)
        Me.dtpubahstok.TabIndex = 139
        '
        'btubahstok
        '
        Me.btubahstok.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahstok.Location = New System.Drawing.Point(550, 559)
        Me.btubahstok.Name = "btubahstok"
        Me.btubahstok.Size = New System.Drawing.Size(139, 41)
        Me.btubahstok.TabIndex = 141
        Me.btubahstok.Text = "Ubah"
        Me.btubahstok.UseVisualStyleBackColor = True
        '
        'rbkurang
        '
        Me.rbkurang.AutoSize = True
        Me.rbkurang.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.rbkurang.Location = New System.Drawing.Point(270, 315)
        Me.rbkurang.Name = "rbkurang"
        Me.rbkurang.Size = New System.Drawing.Size(106, 21)
        Me.rbkurang.TabIndex = 142
        Me.rbkurang.TabStop = True
        Me.rbkurang.Text = "Kekurangan"
        Me.rbkurang.UseVisualStyleBackColor = True
        '
        'rblebih
        '
        Me.rblebih.AutoSize = True
        Me.rblebih.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.rblebih.Location = New System.Drawing.Point(472, 315)
        Me.rblebih.Name = "rblebih"
        Me.rblebih.Size = New System.Drawing.Size(92, 21)
        Me.rblebih.TabIndex = 143
        Me.rblebih.TabStop = True
        Me.rblebih.Text = "Kelebihan"
        Me.rblebih.UseVisualStyleBackColor = True
        '
        'cbnamabrgubahstok
        '
        Me.cbnamabrgubahstok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbnamabrgubahstok.FormattingEnabled = True
        Me.cbnamabrgubahstok.Location = New System.Drawing.Point(174, 234)
        Me.cbnamabrgubahstok.Name = "cbnamabrgubahstok"
        Me.cbnamabrgubahstok.Size = New System.Drawing.Size(521, 30)
        Me.cbnamabrgubahstok.TabIndex = 144
        '
        'tbkeluarubah
        '
        Me.tbkeluarubah.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbkeluarubah.Location = New System.Drawing.Point(174, 407)
        Me.tbkeluarubah.Multiline = True
        Me.tbkeluarubah.Name = "tbkeluarubah"
        Me.tbkeluarubah.Size = New System.Drawing.Size(521, 31)
        Me.tbkeluarubah.TabIndex = 147
        '
        'lbkluar
        '
        Me.lbkluar.AutoSize = True
        Me.lbkluar.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbkluar.Location = New System.Drawing.Point(12, 410)
        Me.lbkluar.Name = "lbkluar"
        Me.lbkluar.Size = New System.Drawing.Size(145, 31)
        Me.lbkluar.TabIndex = 148
        Me.lbkluar.Text = "Stok Keluar"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(405, 559)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 41)
        Me.Button1.TabIndex = 149
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bttutupubahstok
        '
        Me.bttutupubahstok.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttutupubahstok.Appearance.Options.UseFont = True
        Me.bttutupubahstok.ImageOptions.Image = CType(resources.GetObject("bttutupubahstok.ImageOptions.Image"), System.Drawing.Image)
        Me.bttutupubahstok.Location = New System.Drawing.Point(20, 559)
        Me.bttutupubahstok.Name = "bttutupubahstok"
        Me.bttutupubahstok.Size = New System.Drawing.Size(137, 41)
        Me.bttutupubahstok.TabIndex = 140
        Me.bttutupubahstok.Text = "Tutup"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 13)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(677, 149)
        Me.GridControl1.TabIndex = 150
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'formubahstok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(707, 620)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbkluar)
        Me.Controls.Add(Me.tbkeluarubah)
        Me.Controls.Add(Me.cbnamabrgubahstok)
        Me.Controls.Add(Me.rblebih)
        Me.Controls.Add(Me.rbkurang)
        Me.Controls.Add(Me.btubahstok)
        Me.Controls.Add(Me.bttutupubahstok)
        Me.Controls.Add(Me.dtpubahstok)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbakhirubah)
        Me.Controls.Add(Me.lbakhir)
        Me.Controls.Add(Me.tbmasukubah)
        Me.Controls.Add(Me.lbmsk)
        Me.Controls.Add(Me.tbidbrgubahstok)
        Me.Controls.Add(Me.lbkotacust)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbidubahstok)
        Me.Controls.Add(Me.lbkodecust)
        Me.Controls.Add(Me.dgvubahstok)
        Me.Name = "formubahstok"
        Me.Text = "Ubah Stok"
        CType(Me.dgvubahstok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvubahstok As System.Windows.Forms.DataGridView
    Friend WithEvents lbkodecust As System.Windows.Forms.Label
    Friend WithEvents tbidubahstok As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbkotacust As System.Windows.Forms.Label
    Friend WithEvents tbidbrgubahstok As System.Windows.Forms.TextBox
    Friend WithEvents tbmasukubah As System.Windows.Forms.TextBox
    Friend WithEvents lbakhir As System.Windows.Forms.Label
    Friend WithEvents tbakhirubah As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpubahstok As System.Windows.Forms.DateTimePicker
    Friend WithEvents bttutupubahstok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btubahstok As System.Windows.Forms.Button
    Friend WithEvents rbkurang As System.Windows.Forms.RadioButton
    Friend WithEvents rblebih As System.Windows.Forms.RadioButton
    Friend WithEvents cbnamabrgubahstok As System.Windows.Forms.ComboBox
    Friend WithEvents lbmsk As System.Windows.Forms.Label
    Friend WithEvents tbkeluarubah As System.Windows.Forms.TextBox
    Friend WithEvents lbkluar As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
