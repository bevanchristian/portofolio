<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formlogin))
        Me.lbuser = New System.Windows.Forms.Label()
        Me.lbpass = New System.Windows.Forms.Label()
        Me.tbuser = New System.Windows.Forms.TextBox()
        Me.tbpass = New System.Windows.Forms.TextBox()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.bttutup = New DevExpress.XtraEditors.SimpleButton()
        Me.btlogin = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbuser
        '
        Me.lbuser.AutoSize = True
        Me.lbuser.BackColor = System.Drawing.Color.Black
        Me.lbuser.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbuser.ForeColor = System.Drawing.Color.Transparent
        Me.lbuser.Location = New System.Drawing.Point(356, 284)
        Me.lbuser.Name = "lbuser"
        Me.lbuser.Size = New System.Drawing.Size(140, 30)
        Me.lbuser.TabIndex = 1
        Me.lbuser.Text = "Username:"
        '
        'lbpass
        '
        Me.lbpass.AutoSize = True
        Me.lbpass.BackColor = System.Drawing.Color.Transparent
        Me.lbpass.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpass.ForeColor = System.Drawing.Color.White
        Me.lbpass.Location = New System.Drawing.Point(361, 328)
        Me.lbpass.Name = "lbpass"
        Me.lbpass.Size = New System.Drawing.Size(135, 30)
        Me.lbpass.TabIndex = 2
        Me.lbpass.Text = "Password:"
        '
        'tbuser
        '
        Me.tbuser.Font = New System.Drawing.Font("SimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbuser.Location = New System.Drawing.Point(502, 281)
        Me.tbuser.Multiline = True
        Me.tbuser.Name = "tbuser"
        Me.tbuser.Size = New System.Drawing.Size(207, 34)
        Me.tbuser.TabIndex = 3
        '
        'tbpass
        '
        Me.tbpass.Font = New System.Drawing.Font("SimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpass.Location = New System.Drawing.Point(502, 321)
        Me.tbpass.Multiline = True
        Me.tbpass.Name = "tbpass"
        Me.tbpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpass.Size = New System.Drawing.Size(207, 33)
        Me.tbpass.TabIndex = 4
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Darkroom"
        '
        'bttutup
        '
        Me.bttutup.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutup.Appearance.Options.UseFont = True
        Me.bttutup.ImageOptions.Image = CType(resources.GetObject("bttutup.ImageOptions.Image"), System.Drawing.Image)
        Me.bttutup.Location = New System.Drawing.Point(603, 367)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(45, 35)
        Me.bttutup.TabIndex = 9
        '
        'btlogin
        '
        Me.btlogin.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btlogin.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btlogin.Appearance.Options.UseFont = True
        Me.btlogin.Appearance.Options.UseForeColor = True
        Me.btlogin.ImageOptions.Image = CType(resources.GetObject("btlogin.ImageOptions.Image"), System.Drawing.Image)
        Me.btlogin.Location = New System.Drawing.Point(654, 367)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(43, 35)
        Me.btlogin.TabIndex = 8
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.unnamed
        Me.PictureBox4.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(296, 249)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'formlogin
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Appearance.ForeColor = System.Drawing.Color.Azure
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.WindowsApplication1.My.Resources.Resources.lines_stripes_black_background_119743_3840x2400
        Me.ClientSize = New System.Drawing.Size(730, 410)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.tbpass)
        Me.Controls.Add(Me.tbuser)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.lbpass)
        Me.Controls.Add(Me.lbuser)
        Me.Name = "formlogin"
        Me.Text = "Log In"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbuser As System.Windows.Forms.Label
    Friend WithEvents lbpass As System.Windows.Forms.Label
    Friend WithEvents tbuser As System.Windows.Forms.TextBox
    Friend WithEvents tbpass As System.Windows.Forms.TextBox
    Friend WithEvents btlogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttutup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox

End Class
