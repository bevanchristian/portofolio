<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formubahpenerimaan
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
        Me.dgvubahterima = New System.Windows.Forms.DataGridView()
        Me.tbnofakturubahterima = New System.Windows.Forms.TextBox()
        Me.tbidbrgubahterima = New System.Windows.Forms.TextBox()
        Me.lbalamatcust2 = New System.Windows.Forms.Label()
        Me.tbjumlahubahterima = New System.Windows.Forms.TextBox()
        Me.lbtelpcust = New System.Windows.Forms.Label()
        Me.tbnamabrgubahterima = New System.Windows.Forms.TextBox()
        Me.lbkotacust = New System.Windows.Forms.Label()
        Me.lbalamatcust1 = New System.Windows.Forms.Label()
        Me.lbnamacust = New System.Windows.Forms.Label()
        Me.lbkodecust = New System.Windows.Forms.Label()
        Me.bttutuppenerimaan = New System.Windows.Forms.Button()
        Me.btubahpenerimaan = New System.Windows.Forms.Button()
        Me.cbidubahterima = New System.Windows.Forms.ComboBox()
        Me.dtpubahterima = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.dgvubahterima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvubahterima
        '
        Me.dgvubahterima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvubahterima.Location = New System.Drawing.Point(26, 25)
        Me.dgvubahterima.Name = "dgvubahterima"
        Me.dgvubahterima.RowTemplate.Height = 24
        Me.dgvubahterima.Size = New System.Drawing.Size(24, 150)
        Me.dgvubahterima.TabIndex = 116
        '
        'tbnofakturubahterima
        '
        Me.tbnofakturubahterima.Enabled = False
        Me.tbnofakturubahterima.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnofakturubahterima.Location = New System.Drawing.Point(271, 269)
        Me.tbnofakturubahterima.Multiline = True
        Me.tbnofakturubahterima.Name = "tbnofakturubahterima"
        Me.tbnofakturubahterima.Size = New System.Drawing.Size(415, 31)
        Me.tbnofakturubahterima.TabIndex = 115
        '
        'tbidbrgubahterima
        '
        Me.tbidbrgubahterima.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidbrgubahterima.Location = New System.Drawing.Point(271, 347)
        Me.tbidbrgubahterima.Multiline = True
        Me.tbidbrgubahterima.Name = "tbidbrgubahterima"
        Me.tbidbrgubahterima.Size = New System.Drawing.Size(415, 31)
        Me.tbidbrgubahterima.TabIndex = 114
        '
        'lbalamatcust2
        '
        Me.lbalamatcust2.AutoSize = True
        Me.lbalamatcust2.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbalamatcust2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbalamatcust2.Location = New System.Drawing.Point(30, 350)
        Me.lbalamatcust2.Name = "lbalamatcust2"
        Me.lbalamatcust2.Size = New System.Drawing.Size(131, 31)
        Me.lbalamatcust2.TabIndex = 113
        Me.lbalamatcust2.Text = "ID Barang:"
        '
        'tbjumlahubahterima
        '
        Me.tbjumlahubahterima.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbjumlahubahterima.Location = New System.Drawing.Point(271, 424)
        Me.tbjumlahubahterima.Multiline = True
        Me.tbjumlahubahterima.Name = "tbjumlahubahterima"
        Me.tbjumlahubahterima.Size = New System.Drawing.Size(415, 31)
        Me.tbjumlahubahterima.TabIndex = 112
        '
        'lbtelpcust
        '
        Me.lbtelpcust.AutoSize = True
        Me.lbtelpcust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbtelpcust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbtelpcust.Location = New System.Drawing.Point(32, 427)
        Me.lbtelpcust.Name = "lbtelpcust"
        Me.lbtelpcust.Size = New System.Drawing.Size(98, 31)
        Me.lbtelpcust.TabIndex = 111
        Me.lbtelpcust.Text = "Jumlah:"
        '
        'tbnamabrgubahterima
        '
        Me.tbnamabrgubahterima.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnamabrgubahterima.Location = New System.Drawing.Point(271, 384)
        Me.tbnamabrgubahterima.Multiline = True
        Me.tbnamabrgubahterima.Name = "tbnamabrgubahterima"
        Me.tbnamabrgubahterima.Size = New System.Drawing.Size(415, 31)
        Me.tbnamabrgubahterima.TabIndex = 110
        '
        'lbkotacust
        '
        Me.lbkotacust.AutoSize = True
        Me.lbkotacust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkotacust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbkotacust.Location = New System.Drawing.Point(32, 390)
        Me.lbkotacust.Name = "lbkotacust"
        Me.lbkotacust.Size = New System.Drawing.Size(167, 31)
        Me.lbkotacust.TabIndex = 109
        Me.lbkotacust.Text = "Nama Barang:"
        '
        'lbalamatcust1
        '
        Me.lbalamatcust1.AutoSize = True
        Me.lbalamatcust1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbalamatcust1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbalamatcust1.Location = New System.Drawing.Point(30, 306)
        Me.lbalamatcust1.Name = "lbalamatcust1"
        Me.lbalamatcust1.Size = New System.Drawing.Size(222, 31)
        Me.lbalamatcust1.TabIndex = 108
        Me.lbalamatcust1.Text = "Tahun Penerimaan:"
        '
        'lbnamacust
        '
        Me.lbnamacust.AutoSize = True
        Me.lbnamacust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnamacust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbnamacust.Location = New System.Drawing.Point(32, 262)
        Me.lbnamacust.Name = "lbnamacust"
        Me.lbnamacust.Size = New System.Drawing.Size(131, 31)
        Me.lbnamacust.TabIndex = 107
        Me.lbnamacust.Text = "No Faktur:"
        '
        'lbkodecust
        '
        Me.lbkodecust.AutoSize = True
        Me.lbkodecust.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkodecust.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbkodecust.Location = New System.Drawing.Point(33, 196)
        Me.lbkodecust.Name = "lbkodecust"
        Me.lbkodecust.Size = New System.Drawing.Size(181, 31)
        Me.lbkodecust.TabIndex = 105
        Me.lbkodecust.Text = "ID Penerimaan:"
        '
        'bttutuppenerimaan
        '
        Me.bttutuppenerimaan.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttutuppenerimaan.Location = New System.Drawing.Point(26, 483)
        Me.bttutuppenerimaan.Name = "bttutuppenerimaan"
        Me.bttutuppenerimaan.Size = New System.Drawing.Size(126, 41)
        Me.bttutuppenerimaan.TabIndex = 151
        Me.bttutuppenerimaan.Text = "Tutup"
        Me.bttutuppenerimaan.UseVisualStyleBackColor = True
        '
        'btubahpenerimaan
        '
        Me.btubahpenerimaan.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahpenerimaan.Location = New System.Drawing.Point(560, 487)
        Me.btubahpenerimaan.Name = "btubahpenerimaan"
        Me.btubahpenerimaan.Size = New System.Drawing.Size(126, 41)
        Me.btubahpenerimaan.TabIndex = 152
        Me.btubahpenerimaan.Text = "Ubah"
        Me.btubahpenerimaan.UseVisualStyleBackColor = True
        '
        'cbidubahterima
        '
        Me.cbidubahterima.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbidubahterima.FormattingEnabled = True
        Me.cbidubahterima.Location = New System.Drawing.Point(271, 196)
        Me.cbidubahterima.Name = "cbidubahterima"
        Me.cbidubahterima.Size = New System.Drawing.Size(415, 30)
        Me.cbidubahterima.TabIndex = 153
        '
        'dtpubahterima
        '
        Me.dtpubahterima.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpubahterima.Location = New System.Drawing.Point(273, 306)
        Me.dtpubahterima.Name = "dtpubahterima"
        Me.dtpubahterima.Size = New System.Drawing.Size(413, 30)
        Me.dtpubahterima.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(33, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 31)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "ID dPenerimaan:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.TextBox1.Location = New System.Drawing.Point(271, 232)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(415, 31)
        Me.TextBox1.TabIndex = 156
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(410, 487)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(128, 41)
        Me.SimpleButton2.TabIndex = 158
        Me.SimpleButton2.Text = "Hapus"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(26, 25)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(660, 150)
        Me.GridControl1.TabIndex = 159
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'formubahpenerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(746, 540)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpubahterima)
        Me.Controls.Add(Me.cbidubahterima)
        Me.Controls.Add(Me.btubahpenerimaan)
        Me.Controls.Add(Me.bttutuppenerimaan)
        Me.Controls.Add(Me.dgvubahterima)
        Me.Controls.Add(Me.tbnofakturubahterima)
        Me.Controls.Add(Me.tbidbrgubahterima)
        Me.Controls.Add(Me.lbalamatcust2)
        Me.Controls.Add(Me.tbjumlahubahterima)
        Me.Controls.Add(Me.lbtelpcust)
        Me.Controls.Add(Me.tbnamabrgubahterima)
        Me.Controls.Add(Me.lbkotacust)
        Me.Controls.Add(Me.lbalamatcust1)
        Me.Controls.Add(Me.lbnamacust)
        Me.Controls.Add(Me.lbkodecust)
        Me.Name = "formubahpenerimaan"
        Me.Text = "Ubah Penerimaan"
        CType(Me.dgvubahterima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents dgvubahterima As System.Windows.Forms.DataGridView
    Friend WithEvents tbnofakturubahterima As System.Windows.Forms.TextBox
    Friend WithEvents tbidbrgubahterima As System.Windows.Forms.TextBox
    Friend WithEvents lbalamatcust2 As System.Windows.Forms.Label
    Friend WithEvents tbjumlahubahterima As System.Windows.Forms.TextBox
    Friend WithEvents lbtelpcust As System.Windows.Forms.Label
    Friend WithEvents tbnamabrgubahterima As System.Windows.Forms.TextBox
    Friend WithEvents lbkotacust As System.Windows.Forms.Label
    Friend WithEvents lbalamatcust1 As System.Windows.Forms.Label
    Friend WithEvents lbnamacust As System.Windows.Forms.Label
    Friend WithEvents lbkodecust As System.Windows.Forms.Label
    Friend WithEvents bttutuppenerimaan As System.Windows.Forms.Button
    Friend WithEvents btubahpenerimaan As System.Windows.Forms.Button
    Friend WithEvents cbidubahterima As System.Windows.Forms.ComboBox
    Friend WithEvents dtpubahterima As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
