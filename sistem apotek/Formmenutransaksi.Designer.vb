<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formmenutransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formmenutransaksi))
        Me.btpembelian = New DevExpress.XtraEditors.SimpleButton()
        Me.btpenjualan = New DevExpress.XtraEditors.SimpleButton()
        Me.btgudang = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btclose = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btpembelian
        '
        Me.btpembelian.Appearance.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btpembelian.Appearance.Options.UseFont = True
        Me.btpembelian.ImageOptions.Image = CType(resources.GetObject("btpembelian.ImageOptions.Image"), System.Drawing.Image)
        Me.btpembelian.Location = New System.Drawing.Point(95, 343)
        Me.btpembelian.Name = "btpembelian"
        Me.btpembelian.Size = New System.Drawing.Size(185, 49)
        Me.btpembelian.TabIndex = 26
        Me.btpembelian.Text = "Pembelian"
        '
        'btpenjualan
        '
        Me.btpenjualan.Appearance.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btpenjualan.Appearance.Options.UseFont = True
        Me.btpenjualan.ImageOptions.Image = CType(resources.GetObject("btpenjualan.ImageOptions.Image"), System.Drawing.Image)
        Me.btpenjualan.Location = New System.Drawing.Point(315, 343)
        Me.btpenjualan.Name = "btpenjualan"
        Me.btpenjualan.Size = New System.Drawing.Size(181, 49)
        Me.btpenjualan.TabIndex = 27
        Me.btpenjualan.Text = "Penjualan"
        '
        'btgudang
        '
        Me.btgudang.Appearance.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btgudang.Appearance.Options.UseFont = True
        Me.btgudang.ImageOptions.Image = CType(resources.GetObject("btgudang.ImageOptions.Image"), System.Drawing.Image)
        Me.btgudang.Location = New System.Drawing.Point(533, 343)
        Me.btgudang.Name = "btgudang"
        Me.btgudang.Size = New System.Drawing.Size(190, 49)
        Me.btgudang.TabIndex = 28
        Me.btgudang.Text = "Gudang"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 249)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(148, 435)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(503, 94)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "BMD Pharmacy"
        '
        'btclose
        '
        Me.btclose.ImageOptions.Image = CType(resources.GetObject("btclose.ImageOptions.Image"), System.Drawing.Image)
        Me.btclose.Location = New System.Drawing.Point(740, 474)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(53, 57)
        Me.btclose.TabIndex = 32
        '
        'Formmenutransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.lines_stripes_black_background_119743_3840x2400
        Me.ClientSize = New System.Drawing.Size(805, 538)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btgudang)
        Me.Controls.Add(Me.btpenjualan)
        Me.Controls.Add(Me.btpembelian)
        Me.Name = "Formmenutransaksi"
        Me.Text = "Transaksi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btpembelian As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btpenjualan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btgudang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btclose As DevExpress.XtraEditors.SimpleButton
End Class
