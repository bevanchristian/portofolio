<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formhistorypenerimaan
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
        Me.btbatalpeg = New System.Windows.Forms.Button()
        Me.gchistory = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gchistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btbatalpeg
        '
        Me.btbatalpeg.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.btbatalpeg.Location = New System.Drawing.Point(524, 456)
        Me.btbatalpeg.Name = "btbatalpeg"
        Me.btbatalpeg.Size = New System.Drawing.Size(126, 41)
        Me.btbatalpeg.TabIndex = 152
        Me.btbatalpeg.Text = "Tutup"
        Me.btbatalpeg.UseVisualStyleBackColor = True
        '
        'gchistory
        '
        Me.gchistory.Location = New System.Drawing.Point(13, 13)
        Me.gchistory.MainView = Me.GridView1
        Me.gchistory.Name = "gchistory"
        Me.gchistory.Size = New System.Drawing.Size(653, 428)
        Me.gchistory.TabIndex = 153
        Me.gchistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gchistory
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'Formhistorypenerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(678, 509)
        Me.Controls.Add(Me.gchistory)
        Me.Controls.Add(Me.btbatalpeg)
        Me.Name = "Formhistorypenerimaan"
        Me.Text = "History Penerimaan"
        CType(Me.gchistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btbatalpeg As System.Windows.Forms.Button
    Friend WithEvents gchistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
