<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOutput))
        Me.grbHaircutDetails = New System.Windows.Forms.GroupBox()
        Me.lblHaircutType = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.grbBillingAddress = New System.Windows.Forms.GroupBox()
        Me.lblFullNameOut = New System.Windows.Forms.Label()
        Me.lblOFullName = New System.Windows.Forms.Label()
        Me.grbHaircutDetails.SuspendLayout()
        Me.grbBillingAddress.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbHaircutDetails
        '
        Me.grbHaircutDetails.Controls.Add(Me.lblHaircutType)
        Me.grbHaircutDetails.Controls.Add(Me.lblTotal)
        Me.grbHaircutDetails.Controls.Add(Me.lblPrice)
        Me.grbHaircutDetails.Controls.Add(Me.lblProduct)
        Me.grbHaircutDetails.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbHaircutDetails.Location = New System.Drawing.Point(12, 12)
        Me.grbHaircutDetails.Name = "grbHaircutDetails"
        Me.grbHaircutDetails.Size = New System.Drawing.Size(390, 224)
        Me.grbHaircutDetails.TabIndex = 0
        Me.grbHaircutDetails.TabStop = False
        Me.grbHaircutDetails.Text = "Haircut Details"
        '
        'lblHaircutType
        '
        Me.lblHaircutType.AutoSize = True
        Me.lblHaircutType.Location = New System.Drawing.Point(12, 70)
        Me.lblHaircutType.Name = "lblHaircutType"
        Me.lblHaircutType.Size = New System.Drawing.Size(0, 16)
        Me.lblHaircutType.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(286, 32)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(38, 16)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(158, 32)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(39, 16)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(12, 32)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(57, 16)
        Me.lblProduct.TabIndex = 1
        Me.lblProduct.Text = "Product"
        '
        'grbBillingAddress
        '
        Me.grbBillingAddress.Controls.Add(Me.lblFullNameOut)
        Me.grbBillingAddress.Controls.Add(Me.lblOFullName)
        Me.grbBillingAddress.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbBillingAddress.Location = New System.Drawing.Point(408, 14)
        Me.grbBillingAddress.Name = "grbBillingAddress"
        Me.grbBillingAddress.Size = New System.Drawing.Size(341, 221)
        Me.grbBillingAddress.TabIndex = 1
        Me.grbBillingAddress.TabStop = False
        Me.grbBillingAddress.Text = "Billing Address"
        '
        'lblFullNameOut
        '
        Me.lblFullNameOut.AutoSize = True
        Me.lblFullNameOut.Location = New System.Drawing.Point(158, 32)
        Me.lblFullNameOut.Name = "lblFullNameOut"
        Me.lblFullNameOut.Size = New System.Drawing.Size(0, 16)
        Me.lblFullNameOut.TabIndex = 2
        '
        'lblOFullName
        '
        Me.lblOFullName.AutoSize = True
        Me.lblOFullName.Location = New System.Drawing.Point(12, 32)
        Me.lblOFullName.Name = "lblOFullName"
        Me.lblOFullName.Size = New System.Drawing.Size(70, 16)
        Me.lblOFullName.TabIndex = 1
        Me.lblOFullName.Text = "Full Name"
        '
        'frmOutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.grbBillingAddress)
        Me.Controls.Add(Me.grbHaircutDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOutput"
        Me.Text = "Ambroise"
        Me.grbHaircutDetails.ResumeLayout(False)
        Me.grbHaircutDetails.PerformLayout()
        Me.grbBillingAddress.ResumeLayout(False)
        Me.grbBillingAddress.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbHaircutDetails As GroupBox
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblHaircutType As Label
    Friend WithEvents grbBillingAddress As GroupBox
    Friend WithEvents lblFullNameOut As Label
    Friend WithEvents lblOFullName As Label
End Class
