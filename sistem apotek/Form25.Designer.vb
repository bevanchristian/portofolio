<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formmenu))
        Me.btmaster = New DevExpress.XtraEditors.SimpleButton()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.btransaksi = New DevExpress.XtraEditors.SimpleButton()
        Me.btreport = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btclose = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btmaster
        '
        Me.btmaster.Appearance.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmaster.Appearance.Options.UseFont = True
        Me.btmaster.ImageOptions.Image = CType(resources.GetObject("btmaster.ImageOptions.Image"), System.Drawing.Image)
        Me.btmaster.Location = New System.Drawing.Point(32, 342)
        Me.btmaster.Name = "btmaster"
        Me.btmaster.Size = New System.Drawing.Size(185, 66)
        Me.btmaster.TabIndex = 0
        Me.btmaster.Text = "Master"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Darkroom"
        '
        'btransaksi
        '
        Me.btransaksi.Appearance.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btransaksi.Appearance.Options.UseFont = True
        Me.btransaksi.ImageOptions.Image = CType(resources.GetObject("btransaksi.ImageOptions.Image"), System.Drawing.Image)
        Me.btransaksi.Location = New System.Drawing.Point(316, 342)
        Me.btransaksi.Name = "btransaksi"
        Me.btransaksi.Size = New System.Drawing.Size(203, 66)
        Me.btransaksi.TabIndex = 1
        Me.btransaksi.Text = "Transaksi"
        '
        'btreport
        '
        Me.btreport.Appearance.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btreport.Appearance.Options.UseFont = True
        Me.btreport.ImageOptions.Image = CType(resources.GetObject("btreport.ImageOptions.Image"), System.Drawing.Image)
        Me.btreport.Location = New System.Drawing.Point(596, 342)
        Me.btreport.Name = "btreport"
        Me.btreport.Size = New System.Drawing.Size(185, 66)
        Me.btreport.TabIndex = 2
        Me.btreport.Text = "Laporan"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 249)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(141, 443)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(503, 94)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "BMD Pharmacy"
        '
        'btclose
        '
        Me.btclose.ImageOptions.Image = CType(resources.GetObject("btclose.ImageOptions.Image"), System.Drawing.Image)
        Me.btclose.Location = New System.Drawing.Point(749, 477)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(53, 57)
        Me.btclose.TabIndex = 33
        '
        'formmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(854, 546)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btreport)
        Me.Controls.Add(Me.btransaksi)
        Me.Controls.Add(Me.btmaster)
        Me.Name = "formmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btmaster As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents btransaksi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btreport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btclose As DevExpress.XtraEditors.SimpleButton
End Class
