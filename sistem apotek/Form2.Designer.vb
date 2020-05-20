<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formbarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formbarang))
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        Me.tbkodebrg = New System.Windows.Forms.TextBox()
        Me.lbkodebrg = New System.Windows.Forms.Label()
        Me.tbnamabrg = New System.Windows.Forms.TextBox()
        Me.lbnamabrg = New System.Windows.Forms.Label()
        Me.tbexpbrg = New System.Windows.Forms.TextBox()
        Me.lbexpbrg = New System.Windows.Forms.Label()
        Me.tbbatchbrg = New System.Windows.Forms.TextBox()
        Me.lbbatchbrg = New System.Windows.Forms.Label()
        Me.tbjualbrg = New System.Windows.Forms.TextBox()
        Me.lbjualbrg = New System.Windows.Forms.Label()
        Me.tbbelibrg = New System.Windows.Forms.TextBox()
        Me.lbbelibrg = New System.Windows.Forms.Label()
        Me.tbdiscbrg = New System.Windows.Forms.TextBox()
        Me.lbdiscbrg = New System.Windows.Forms.Label()
        Me.bttambahbrg = New System.Windows.Forms.Button()
        Me.bthapusbrg = New System.Windows.Forms.Button()
        Me.btubahbrg = New System.Windows.Forms.Button()
        Me.btbatalbrg = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bttutupbrg = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvbarang
        '
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Location = New System.Drawing.Point(936, 245)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.RowTemplate.Height = 24
        Me.dgvbarang.Size = New System.Drawing.Size(10, 20)
        Me.dgvbarang.TabIndex = 0
        '
        'tbkodebrg
        '
        Me.tbkodebrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbkodebrg.Location = New System.Drawing.Point(194, 326)
        Me.tbkodebrg.Multiline = True
        Me.tbkodebrg.Name = "tbkodebrg"
        Me.tbkodebrg.Size = New System.Drawing.Size(216, 31)
        Me.tbkodebrg.TabIndex = 6
        '
        'lbkodebrg
        '
        Me.lbkodebrg.AutoSize = True
        Me.lbkodebrg.BackColor = System.Drawing.Color.Black
        Me.lbkodebrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkodebrg.ForeColor = System.Drawing.SystemColors.Control
        Me.lbkodebrg.Location = New System.Drawing.Point(25, 326)
        Me.lbkodebrg.Name = "lbkodebrg"
        Me.lbkodebrg.Size = New System.Drawing.Size(163, 31)
        Me.lbkodebrg.TabIndex = 5
        Me.lbkodebrg.Text = "Kode Barang:"
        '
        'tbnamabrg
        '
        Me.tbnamabrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnamabrg.Location = New System.Drawing.Point(194, 368)
        Me.tbnamabrg.Multiline = True
        Me.tbnamabrg.Name = "tbnamabrg"
        Me.tbnamabrg.Size = New System.Drawing.Size(216, 31)
        Me.tbnamabrg.TabIndex = 8
        '
        'lbnamabrg
        '
        Me.lbnamabrg.AutoSize = True
        Me.lbnamabrg.BackColor = System.Drawing.Color.Black
        Me.lbnamabrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnamabrg.ForeColor = System.Drawing.SystemColors.Control
        Me.lbnamabrg.Location = New System.Drawing.Point(25, 368)
        Me.lbnamabrg.Name = "lbnamabrg"
        Me.lbnamabrg.Size = New System.Drawing.Size(167, 31)
        Me.lbnamabrg.TabIndex = 7
        Me.lbnamabrg.Text = "Nama Barang:"
        '
        'tbexpbrg
        '
        Me.tbexpbrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbexpbrg.Location = New System.Drawing.Point(194, 405)
        Me.tbexpbrg.Multiline = True
        Me.tbexpbrg.Name = "tbexpbrg"
        Me.tbexpbrg.Size = New System.Drawing.Size(216, 31)
        Me.tbexpbrg.TabIndex = 10
        '
        'lbexpbrg
        '
        Me.lbexpbrg.AutoSize = True
        Me.lbexpbrg.BackColor = System.Drawing.Color.Black
        Me.lbexpbrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbexpbrg.ForeColor = System.Drawing.SystemColors.Control
        Me.lbexpbrg.Location = New System.Drawing.Point(25, 405)
        Me.lbexpbrg.Name = "lbexpbrg"
        Me.lbexpbrg.Size = New System.Drawing.Size(150, 31)
        Me.lbexpbrg.TabIndex = 9
        Me.lbexpbrg.Text = "Expire Date:"
        '
        'tbbatchbrg
        '
        Me.tbbatchbrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbbatchbrg.Location = New System.Drawing.Point(571, 326)
        Me.tbbatchbrg.Multiline = True
        Me.tbbatchbrg.Name = "tbbatchbrg"
        Me.tbbatchbrg.Size = New System.Drawing.Size(295, 31)
        Me.tbbatchbrg.TabIndex = 12
        '
        'lbbatchbrg
        '
        Me.lbbatchbrg.AutoSize = True
        Me.lbbatchbrg.BackColor = System.Drawing.Color.Black
        Me.lbbatchbrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbbatchbrg.ForeColor = System.Drawing.SystemColors.Control
        Me.lbbatchbrg.Location = New System.Drawing.Point(434, 326)
        Me.lbbatchbrg.Name = "lbbatchbrg"
        Me.lbbatchbrg.Size = New System.Drawing.Size(131, 31)
        Me.lbbatchbrg.TabIndex = 11
        Me.lbbatchbrg.Text = "No. Batch:"
        '
        'tbjualbrg
        '
        Me.tbjualbrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbjualbrg.Location = New System.Drawing.Point(194, 445)
        Me.tbjualbrg.Multiline = True
        Me.tbjualbrg.Name = "tbjualbrg"
        Me.tbjualbrg.Size = New System.Drawing.Size(216, 31)
        Me.tbjualbrg.TabIndex = 16
        '
        'lbjualbrg
        '
        Me.lbjualbrg.AutoSize = True
        Me.lbjualbrg.BackColor = System.Drawing.Color.Black
        Me.lbjualbrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbjualbrg.ForeColor = System.Drawing.SystemColors.Control
        Me.lbjualbrg.Location = New System.Drawing.Point(25, 445)
        Me.lbjualbrg.Name = "lbjualbrg"
        Me.lbjualbrg.Size = New System.Drawing.Size(135, 31)
        Me.lbjualbrg.TabIndex = 15
        Me.lbjualbrg.Text = "Harga Jual:"
        '
        'tbbelibrg
        '
        Me.tbbelibrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbbelibrg.Location = New System.Drawing.Point(194, 482)
        Me.tbbelibrg.Multiline = True
        Me.tbbelibrg.Name = "tbbelibrg"
        Me.tbbelibrg.Size = New System.Drawing.Size(216, 31)
        Me.tbbelibrg.TabIndex = 18
        '
        'lbbelibrg
        '
        Me.lbbelibrg.AutoSize = True
        Me.lbbelibrg.BackColor = System.Drawing.Color.Black
        Me.lbbelibrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbbelibrg.ForeColor = System.Drawing.SystemColors.Control
        Me.lbbelibrg.Location = New System.Drawing.Point(25, 482)
        Me.lbbelibrg.Name = "lbbelibrg"
        Me.lbbelibrg.Size = New System.Drawing.Size(136, 31)
        Me.lbbelibrg.TabIndex = 17
        Me.lbbelibrg.Text = "Harga Beli:"
        '
        'tbdiscbrg
        '
        Me.tbdiscbrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbdiscbrg.Location = New System.Drawing.Point(571, 366)
        Me.tbdiscbrg.Multiline = True
        Me.tbdiscbrg.Name = "tbdiscbrg"
        Me.tbdiscbrg.Size = New System.Drawing.Size(295, 31)
        Me.tbdiscbrg.TabIndex = 20
        '
        'lbdiscbrg
        '
        Me.lbdiscbrg.AutoSize = True
        Me.lbdiscbrg.BackColor = System.Drawing.Color.Black
        Me.lbdiscbrg.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbdiscbrg.ForeColor = System.Drawing.SystemColors.Control
        Me.lbdiscbrg.Location = New System.Drawing.Point(434, 366)
        Me.lbdiscbrg.Name = "lbdiscbrg"
        Me.lbdiscbrg.Size = New System.Drawing.Size(97, 31)
        Me.lbdiscbrg.TabIndex = 19
        Me.lbdiscbrg.Text = "Disc: %"
        '
        'bttambahbrg
        '
        Me.bttambahbrg.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttambahbrg.Location = New System.Drawing.Point(652, 551)
        Me.bttambahbrg.Name = "bttambahbrg"
        Me.bttambahbrg.Size = New System.Drawing.Size(148, 41)
        Me.bttambahbrg.TabIndex = 25
        Me.bttambahbrg.Text = "Tambah"
        Me.bttambahbrg.UseVisualStyleBackColor = True
        '
        'bthapusbrg
        '
        Me.bthapusbrg.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bthapusbrg.Location = New System.Drawing.Point(505, 554)
        Me.bthapusbrg.Name = "bthapusbrg"
        Me.bthapusbrg.Size = New System.Drawing.Size(126, 41)
        Me.bthapusbrg.TabIndex = 26
        Me.bthapusbrg.Text = "Hapus"
        Me.bthapusbrg.UseVisualStyleBackColor = True
        '
        'btubahbrg
        '
        Me.btubahbrg.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahbrg.Location = New System.Drawing.Point(350, 551)
        Me.btubahbrg.Name = "btubahbrg"
        Me.btubahbrg.Size = New System.Drawing.Size(126, 41)
        Me.btubahbrg.TabIndex = 27
        Me.btubahbrg.Text = "Ubah"
        Me.btubahbrg.UseVisualStyleBackColor = True
        '
        'btbatalbrg
        '
        Me.btbatalbrg.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btbatalbrg.Location = New System.Drawing.Point(790, 554)
        Me.btbatalbrg.Name = "btbatalbrg"
        Me.btbatalbrg.Size = New System.Drawing.Size(10, 10)
        Me.btbatalbrg.TabIndex = 29
        Me.btbatalbrg.Text = "Batal"
        Me.btbatalbrg.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(941, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 10)
        Me.Button1.TabIndex = 118
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bttutupbrg
        '
        Me.bttutupbrg.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttutupbrg.Appearance.Options.UseFont = True
        Me.bttutupbrg.ImageOptions.Image = CType(resources.GetObject("bttutupbrg.ImageOptions.Image"), System.Drawing.Image)
        Me.bttutupbrg.Location = New System.Drawing.Point(27, 554)
        Me.bttutupbrg.Name = "bttutupbrg"
        Me.bttutupbrg.Size = New System.Drawing.Size(137, 41)
        Me.bttutupbrg.TabIndex = 116
        Me.bttutupbrg.Text = "Tutup"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(18, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(918, 296)
        Me.GridControl1.TabIndex = 118
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'formbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.lines_stripes_black_background_119743_3840x2400
        Me.ClientSize = New System.Drawing.Size(951, 604)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.bttambahbrg)
        Me.Controls.Add(Me.dgvbarang)
        Me.Controls.Add(Me.bttutupbrg)
        Me.Controls.Add(Me.btbatalbrg)
        Me.Controls.Add(Me.btubahbrg)
        Me.Controls.Add(Me.bthapusbrg)
        Me.Controls.Add(Me.tbdiscbrg)
        Me.Controls.Add(Me.lbdiscbrg)
        Me.Controls.Add(Me.tbbelibrg)
        Me.Controls.Add(Me.lbbelibrg)
        Me.Controls.Add(Me.tbjualbrg)
        Me.Controls.Add(Me.lbjualbrg)
        Me.Controls.Add(Me.tbbatchbrg)
        Me.Controls.Add(Me.lbbatchbrg)
        Me.Controls.Add(Me.tbexpbrg)
        Me.Controls.Add(Me.lbexpbrg)
        Me.Controls.Add(Me.tbnamabrg)
        Me.Controls.Add(Me.lbnamabrg)
        Me.Controls.Add(Me.tbkodebrg)
        Me.Controls.Add(Me.lbkodebrg)
        Me.Name = "formbarang"
        Me.Text = "Data Barang"
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvbarang As System.Windows.Forms.DataGridView
    Friend WithEvents tbkodebrg As System.Windows.Forms.TextBox
    Friend WithEvents lbkodebrg As System.Windows.Forms.Label
    Friend WithEvents tbnamabrg As System.Windows.Forms.TextBox
    Friend WithEvents lbnamabrg As System.Windows.Forms.Label
    Friend WithEvents tbexpbrg As System.Windows.Forms.TextBox
    Friend WithEvents lbexpbrg As System.Windows.Forms.Label
    Friend WithEvents tbbatchbrg As System.Windows.Forms.TextBox
    Friend WithEvents lbbatchbrg As System.Windows.Forms.Label
    Friend WithEvents tbjualbrg As System.Windows.Forms.TextBox
    Friend WithEvents lbjualbrg As System.Windows.Forms.Label
    Friend WithEvents tbbelibrg As System.Windows.Forms.TextBox
    Friend WithEvents lbbelibrg As System.Windows.Forms.Label
    Friend WithEvents tbdiscbrg As System.Windows.Forms.TextBox
    Friend WithEvents lbdiscbrg As System.Windows.Forms.Label
    Friend WithEvents bttambahbrg As System.Windows.Forms.Button
    Friend WithEvents bthapusbrg As System.Windows.Forms.Button
    Friend WithEvents btubahbrg As System.Windows.Forms.Button
    Friend WithEvents btbatalbrg As System.Windows.Forms.Button
    Friend WithEvents bttutupbrg As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
