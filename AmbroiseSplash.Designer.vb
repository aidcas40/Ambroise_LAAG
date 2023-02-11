<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.pctLogoSplash = New System.Windows.Forms.PictureBox()
        Me.lblProgName = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        CType(Me.pctLogoSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctLogoSplash
        '
        Me.pctLogoSplash.Image = CType(resources.GetObject("pctLogoSplash.Image"), System.Drawing.Image)
        Me.pctLogoSplash.Location = New System.Drawing.Point(315, 150)
        Me.pctLogoSplash.Name = "pctLogoSplash"
        Me.pctLogoSplash.Size = New System.Drawing.Size(176, 132)
        Me.pctLogoSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLogoSplash.TabIndex = 0
        Me.pctLogoSplash.TabStop = False
        '
        'lblProgName
        '
        Me.lblProgName.AutoSize = True
        Me.lblProgName.Font = New System.Drawing.Font("Inter", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgName.ForeColor = System.Drawing.Color.White
        Me.lblProgName.Location = New System.Drawing.Point(350, 293)
        Me.lblProgName.Name = "lblProgName"
        Me.lblProgName.Size = New System.Drawing.Size(106, 25)
        Me.lblProgName.TabIndex = 1
        Me.lblProgName.Text = "Ambroise"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.White
        Me.lblCopyright.Location = New System.Drawing.Point(343, 329)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(121, 16)
        Me.lblCopyright.TabIndex = 2
        Me.lblCopyright.Text = "@Copyright LAAG"
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblProgName)
        Me.Controls.Add(Me.pctLogoSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSplashScreen"
        CType(Me.pctLogoSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctLogoSplash As PictureBox
    Friend WithEvents lblProgName As Label
    Friend WithEvents lblCopyright As Label
End Class
