<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formsupplier
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formsupplier))
        Me.dgvsupplier = New System.Windows.Forms.DataGridView()
        Me.btbatalsup = New System.Windows.Forms.Button()
        Me.btubahsup = New System.Windows.Forms.Button()
        Me.bthapussup = New System.Windows.Forms.Button()
        Me.bttambahsup = New System.Windows.Forms.Button()
        Me.tbtelpsup = New System.Windows.Forms.TextBox()
        Me.lbtelpsup = New System.Windows.Forms.Label()
        Me.tbkotasup = New System.Windows.Forms.TextBox()
        Me.lbkotasup = New System.Windows.Forms.Label()
        Me.tbalamatsup = New System.Windows.Forms.TextBox()
        Me.lbalamatsup = New System.Windows.Forms.Label()
        Me.tbnamasup = New System.Windows.Forms.TextBox()
        Me.lbnamasup = New System.Windows.Forms.Label()
        Me.tbkodesup = New System.Windows.Forms.TextBox()
        Me.lbkodesup = New System.Windows.Forms.Label()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.bttutupsup = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.dgvsupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvsupplier
        '
        Me.dgvsupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsupplier.Location = New System.Drawing.Point(973, 414)
        Me.dgvsupplier.Name = "dgvsupplier"
        Me.dgvsupplier.RowTemplate.Height = 24
        Me.dgvsupplier.Size = New System.Drawing.Size(10, 16)
        Me.dgvsupplier.TabIndex = 5
        '
        'btbatalsup
        '
        Me.btbatalsup.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btbatalsup.Location = New System.Drawing.Point(973, 439)
        Me.btbatalsup.Name = "btbatalsup"
        Me.btbatalsup.Size = New System.Drawing.Size(10, 10)
        Me.btbatalsup.TabIndex = 54
        Me.btbatalsup.Text = "Batal"
        Me.btbatalsup.UseVisualStyleBackColor = True
        '
        'btubahsup
        '
        Me.btubahsup.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahsup.Location = New System.Drawing.Point(849, 565)
        Me.btubahsup.Name = "btubahsup"
        Me.btubahsup.Size = New System.Drawing.Size(126, 41)
        Me.btubahsup.TabIndex = 53
        Me.btubahsup.Text = "Ubah"
        Me.btubahsup.UseVisualStyleBackColor = True
        '
        'bthapussup
        '
        Me.bthapussup.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bthapussup.Location = New System.Drawing.Point(703, 565)
        Me.bthapussup.Name = "bthapussup"
        Me.bthapussup.Size = New System.Drawing.Size(126, 41)
        Me.bthapussup.TabIndex = 52
        Me.bthapussup.Text = "Hapus"
        Me.bthapussup.UseVisualStyleBackColor = True
        '
        'bttambahsup
        '
        Me.bttambahsup.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttambahsup.Location = New System.Drawing.Point(548, 565)
        Me.bttambahsup.Name = "bttambahsup"
        Me.bttambahsup.Size = New System.Drawing.Size(140, 41)
        Me.bttambahsup.TabIndex = 51
        Me.bttambahsup.Text = "Tambah"
        Me.bttambahsup.UseVisualStyleBackColor = True
        '
        'tbtelpsup
        '
        Me.tbtelpsup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbtelpsup.Location = New System.Drawing.Point(246, 504)
        Me.tbtelpsup.Multiline = True
        Me.tbtelpsup.Name = "tbtelpsup"
        Me.tbtelpsup.Size = New System.Drawing.Size(333, 31)
        Me.tbtelpsup.TabIndex = 44
        '
        'lbtelpsup
        '
        Me.lbtelpsup.AutoSize = True
        Me.lbtelpsup.BackColor = System.Drawing.Color.Black
        Me.lbtelpsup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbtelpsup.ForeColor = System.Drawing.SystemColors.Control
        Me.lbtelpsup.Location = New System.Drawing.Point(12, 504)
        Me.lbtelpsup.Name = "lbtelpsup"
        Me.lbtelpsup.Size = New System.Drawing.Size(108, 31)
        Me.lbtelpsup.TabIndex = 43
        Me.lbtelpsup.Text = "Telepon:"
        '
        'tbkotasup
        '
        Me.tbkotasup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbkotasup.Location = New System.Drawing.Point(246, 467)
        Me.tbkotasup.Multiline = True
        Me.tbkotasup.Name = "tbkotasup"
        Me.tbkotasup.Size = New System.Drawing.Size(333, 31)
        Me.tbkotasup.TabIndex = 42
        '
        'lbkotasup
        '
        Me.lbkotasup.AutoSize = True
        Me.lbkotasup.BackColor = System.Drawing.Color.Black
        Me.lbkotasup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkotasup.ForeColor = System.Drawing.SystemColors.Control
        Me.lbkotasup.Location = New System.Drawing.Point(12, 467)
        Me.lbkotasup.Name = "lbkotasup"
        Me.lbkotasup.Size = New System.Drawing.Size(73, 31)
        Me.lbkotasup.TabIndex = 41
        Me.lbkotasup.Text = "Kota:"
        '
        'tbalamatsup
        '
        Me.tbalamatsup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbalamatsup.Location = New System.Drawing.Point(246, 427)
        Me.tbalamatsup.Multiline = True
        Me.tbalamatsup.Name = "tbalamatsup"
        Me.tbalamatsup.Size = New System.Drawing.Size(333, 31)
        Me.tbalamatsup.TabIndex = 36
        '
        'lbalamatsup
        '
        Me.lbalamatsup.AutoSize = True
        Me.lbalamatsup.BackColor = System.Drawing.Color.Black
        Me.lbalamatsup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbalamatsup.ForeColor = System.Drawing.SystemColors.Control
        Me.lbalamatsup.Location = New System.Drawing.Point(10, 427)
        Me.lbalamatsup.Name = "lbalamatsup"
        Me.lbalamatsup.Size = New System.Drawing.Size(199, 31)
        Me.lbalamatsup.TabIndex = 35
        Me.lbalamatsup.Text = "Alamat Supplier:"
        '
        'tbnamasup
        '
        Me.tbnamasup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnamasup.Location = New System.Drawing.Point(244, 390)
        Me.tbnamasup.Multiline = True
        Me.tbnamasup.Name = "tbnamasup"
        Me.tbnamasup.Size = New System.Drawing.Size(335, 31)
        Me.tbnamasup.TabIndex = 34
        '
        'lbnamasup
        '
        Me.lbnamasup.AutoSize = True
        Me.lbnamasup.BackColor = System.Drawing.Color.Black
        Me.lbnamasup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbnamasup.ForeColor = System.Drawing.SystemColors.Control
        Me.lbnamasup.Location = New System.Drawing.Point(12, 390)
        Me.lbnamasup.Name = "lbnamasup"
        Me.lbnamasup.Size = New System.Drawing.Size(183, 31)
        Me.lbnamasup.TabIndex = 33
        Me.lbnamasup.Text = "Nama Supplier:"
        '
        'tbkodesup
        '
        Me.tbkodesup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbkodesup.Location = New System.Drawing.Point(244, 348)
        Me.tbkodesup.Multiline = True
        Me.tbkodesup.Name = "tbkodesup"
        Me.tbkodesup.Size = New System.Drawing.Size(337, 31)
        Me.tbkodesup.TabIndex = 32
        '
        'lbkodesup
        '
        Me.lbkodesup.AutoSize = True
        Me.lbkodesup.BackColor = System.Drawing.Color.Black
        Me.lbkodesup.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.lbkodesup.ForeColor = System.Drawing.SystemColors.Control
        Me.lbkodesup.Location = New System.Drawing.Point(13, 348)
        Me.lbkodesup.Name = "lbkodesup"
        Me.lbkodesup.Size = New System.Drawing.Size(179, 31)
        Me.lbkodesup.TabIndex = 31
        Me.lbkodesup.Text = "Kode Supplier:"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Darkroom"
        '
        'bttutupsup
        '
        Me.bttutupsup.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttutupsup.Appearance.Options.UseFont = True
        Me.bttutupsup.ImageOptions.Image = CType(resources.GetObject("bttutupsup.ImageOptions.Image"), System.Drawing.Image)
        Me.bttutupsup.Location = New System.Drawing.Point(19, 562)
        Me.bttutupsup.Name = "bttutupsup"
        Me.bttutupsup.Size = New System.Drawing.Size(137, 41)
        Me.bttutupsup.TabIndex = 116
        Me.bttutupsup.Text = "Tutup"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 30)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(971, 303)
        Me.GridControl1.TabIndex = 118
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'formsupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.lines_stripes_black_background_119743_3840x2400
        Me.ClientSize = New System.Drawing.Size(995, 642)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.dgvsupplier)
        Me.Controls.Add(Me.bttutupsup)
        Me.Controls.Add(Me.btbatalsup)
        Me.Controls.Add(Me.btubahsup)
        Me.Controls.Add(Me.bthapussup)
        Me.Controls.Add(Me.bttambahsup)
        Me.Controls.Add(Me.tbtelpsup)
        Me.Controls.Add(Me.lbtelpsup)
        Me.Controls.Add(Me.tbkotasup)
        Me.Controls.Add(Me.lbkotasup)
        Me.Controls.Add(Me.tbalamatsup)
        Me.Controls.Add(Me.lbalamatsup)
        Me.Controls.Add(Me.tbnamasup)
        Me.Controls.Add(Me.lbnamasup)
        Me.Controls.Add(Me.tbkodesup)
        Me.Controls.Add(Me.lbkodesup)
        Me.Name = "formsupplier"
        Me.Text = "Data Supplier"
        CType(Me.dgvsupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvsupplier As System.Windows.Forms.DataGridView
    Friend WithEvents btbatalsup As System.Windows.Forms.Button
    Friend WithEvents btubahsup As System.Windows.Forms.Button
    Friend WithEvents bthapussup As System.Windows.Forms.Button
    Friend WithEvents bttambahsup As System.Windows.Forms.Button
    Friend WithEvents tbtelpsup As System.Windows.Forms.TextBox
    Friend WithEvents lbtelpsup As System.Windows.Forms.Label
    Friend WithEvents tbkotasup As System.Windows.Forms.TextBox
    Friend WithEvents lbkotasup As System.Windows.Forms.Label
    Friend WithEvents tbalamatsup As System.Windows.Forms.TextBox
    Friend WithEvents lbalamatsup As System.Windows.Forms.Label
    Friend WithEvents tbnamasup As System.Windows.Forms.TextBox
    Friend WithEvents lbnamasup As System.Windows.Forms.Label
    Friend WithEvents tbkodesup As System.Windows.Forms.TextBox
    Friend WithEvents lbkodesup As System.Windows.Forms.Label
    Friend WithEvents bttutupsup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
