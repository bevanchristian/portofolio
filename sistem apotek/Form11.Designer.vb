<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formgolongan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formgolongan))
        Me.tbnamagol = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbidgol = New System.Windows.Forms.TextBox()
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        Me.btbatalgol = New System.Windows.Forms.Button()
        Me.btubahgol = New System.Windows.Forms.Button()
        Me.bthapusgol = New System.Windows.Forms.Button()
        Me.bttambahgol = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bttutupgol = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbnamagol
        '
        Me.tbnamagol.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbnamagol.Location = New System.Drawing.Point(220, 76)
        Me.tbnamagol.Multiline = True
        Me.tbnamagol.Name = "tbnamagol"
        Me.tbnamagol.Size = New System.Drawing.Size(747, 31)
        Me.tbnamagol.TabIndex = 136
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label4.Location = New System.Drawing.Point(23, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 31)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Nama Golongan:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(52, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 31)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "ID Golongan:"
        '
        'tbidgol
        '
        Me.tbidgol.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.tbidgol.Location = New System.Drawing.Point(219, 31)
        Me.tbidgol.Multiline = True
        Me.tbidgol.Name = "tbidgol"
        Me.tbidgol.Size = New System.Drawing.Size(748, 31)
        Me.tbidgol.TabIndex = 130
        '
        'dgvbarang
        '
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Location = New System.Drawing.Point(29, 131)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.RowTemplate.Height = 24
        Me.dgvbarang.Size = New System.Drawing.Size(10, 28)
        Me.dgvbarang.TabIndex = 113
        '
        'btbatalgol
        '
        Me.btbatalgol.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btbatalgol.Location = New System.Drawing.Point(1056, 149)
        Me.btbatalgol.Name = "btbatalgol"
        Me.btbatalgol.Size = New System.Drawing.Size(10, 10)
        Me.btbatalgol.TabIndex = 140
        Me.btbatalgol.Text = "Batal"
        Me.btbatalgol.UseVisualStyleBackColor = True
        '
        'btubahgol
        '
        Me.btubahgol.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btubahgol.Location = New System.Drawing.Point(937, 591)
        Me.btubahgol.Name = "btubahgol"
        Me.btubahgol.Size = New System.Drawing.Size(126, 41)
        Me.btubahgol.TabIndex = 139
        Me.btubahgol.Text = "Ubah"
        Me.btubahgol.UseVisualStyleBackColor = True
        '
        'bthapusgol
        '
        Me.bthapusgol.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bthapusgol.Location = New System.Drawing.Point(799, 591)
        Me.bthapusgol.Name = "bthapusgol"
        Me.bthapusgol.Size = New System.Drawing.Size(126, 41)
        Me.bthapusgol.TabIndex = 138
        Me.bthapusgol.Text = "Hapus"
        Me.bthapusgol.UseVisualStyleBackColor = True
        '
        'bttambahgol
        '
        Me.bttambahgol.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttambahgol.Location = New System.Drawing.Point(628, 591)
        Me.bttambahgol.Name = "bttambahgol"
        Me.bttambahgol.Size = New System.Drawing.Size(148, 41)
        Me.bttambahgol.TabIndex = 137
        Me.bttambahgol.Text = "Tambah"
        Me.bttambahgol.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(13, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 10)
        Me.Button1.TabIndex = 142
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bttutupgol
        '
        Me.bttutupgol.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.bttutupgol.Appearance.Options.UseFont = True
        Me.bttutupgol.ImageOptions.Image = CType(resources.GetObject("bttutupgol.ImageOptions.Image"), System.Drawing.Image)
        Me.bttutupgol.Location = New System.Drawing.Point(2, 583)
        Me.bttutupgol.Name = "bttutupgol"
        Me.bttutupgol.Size = New System.Drawing.Size(137, 41)
        Me.bttutupgol.TabIndex = 141
        Me.bttutupgol.Text = "Tutup"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 165)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1054, 410)
        Me.GridControl1.TabIndex = 143
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Darkroom"
        '
        'formgolongan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.lines_stripes_black_background_119743_3840x2400
        Me.ClientSize = New System.Drawing.Size(1078, 644)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bttutupgol)
        Me.Controls.Add(Me.btbatalgol)
        Me.Controls.Add(Me.btubahgol)
        Me.Controls.Add(Me.bthapusgol)
        Me.Controls.Add(Me.bttambahgol)
        Me.Controls.Add(Me.tbnamagol)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbidgol)
        Me.Controls.Add(Me.dgvbarang)
        Me.Name = "formgolongan"
        Me.Text = "Golongan"
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbnamagol As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbidgol As System.Windows.Forms.TextBox
    Friend WithEvents dgvbarang As System.Windows.Forms.DataGridView
    Friend WithEvents btbatalgol As System.Windows.Forms.Button
    Friend WithEvents btubahgol As System.Windows.Forms.Button
    Friend WithEvents bthapusgol As System.Windows.Forms.Button
    Friend WithEvents bttambahgol As System.Windows.Forms.Button
    Friend WithEvents bttutupgol As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
End Class
