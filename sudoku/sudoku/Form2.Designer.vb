<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAWAL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAWAL))
        Me.ButtonSTART = New System.Windows.Forms.Button()
        Me.RadioButtonEASY = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMEDIUM = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHARD = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ButtonSTART
        '
        Me.ButtonSTART.BackColor = System.Drawing.Color.Red
        Me.ButtonSTART.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSTART.ForeColor = System.Drawing.Color.White
        Me.ButtonSTART.Location = New System.Drawing.Point(330, 163)
        Me.ButtonSTART.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSTART.Name = "ButtonSTART"
        Me.ButtonSTART.Size = New System.Drawing.Size(137, 57)
        Me.ButtonSTART.TabIndex = 0
        Me.ButtonSTART.Text = "START"
        Me.ButtonSTART.UseVisualStyleBackColor = False
        '
        'RadioButtonEASY
        '
        Me.RadioButtonEASY.AutoSize = True
        Me.RadioButtonEASY.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonEASY.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonEASY.Location = New System.Drawing.Point(354, 237)
        Me.RadioButtonEASY.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonEASY.Name = "RadioButtonEASY"
        Me.RadioButtonEASY.Size = New System.Drawing.Size(91, 27)
        Me.RadioButtonEASY.TabIndex = 1
        Me.RadioButtonEASY.TabStop = True
        Me.RadioButtonEASY.Text = "EASY"
        Me.RadioButtonEASY.UseVisualStyleBackColor = False
        '
        'RadioButtonMEDIUM
        '
        Me.RadioButtonMEDIUM.AutoSize = True
        Me.RadioButtonMEDIUM.Font = New System.Drawing.Font("Cooper Black", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonMEDIUM.Location = New System.Drawing.Point(354, 283)
        Me.RadioButtonMEDIUM.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonMEDIUM.Name = "RadioButtonMEDIUM"
        Me.RadioButtonMEDIUM.Size = New System.Drawing.Size(117, 25)
        Me.RadioButtonMEDIUM.TabIndex = 2
        Me.RadioButtonMEDIUM.TabStop = True
        Me.RadioButtonMEDIUM.Text = "MEDIUM"
        Me.RadioButtonMEDIUM.UseVisualStyleBackColor = True
        '
        'RadioButtonHARD
        '
        Me.RadioButtonHARD.AutoSize = True
        Me.RadioButtonHARD.Font = New System.Drawing.Font("Cooper Black", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonHARD.Location = New System.Drawing.Point(354, 325)
        Me.RadioButtonHARD.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonHARD.Name = "RadioButtonHARD"
        Me.RadioButtonHARD.Size = New System.Drawing.Size(92, 25)
        Me.RadioButtonHARD.TabIndex = 3
        Me.RadioButtonHARD.TabStop = True
        Me.RadioButtonHARD.Text = "HARD"
        Me.RadioButtonHARD.UseVisualStyleBackColor = True
        '
        'FormAWAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(810, 445)
        Me.Controls.Add(Me.RadioButtonHARD)
        Me.Controls.Add(Me.RadioButtonMEDIUM)
        Me.Controls.Add(Me.RadioButtonEASY)
        Me.Controls.Add(Me.ButtonSTART)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormAWAL"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSTART As System.Windows.Forms.Button
    Friend WithEvents RadioButtonEASY As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMEDIUM As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonHARD As System.Windows.Forms.RadioButton
End Class
