<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLondon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLondon))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.txtNumberOfTickets = New System.Windows.Forms.TextBox()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.radZone6 = New System.Windows.Forms.RadioButton()
        Me.radZone5 = New System.Windows.Forms.RadioButton()
        Me.radZone3 = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblCostTickets = New System.Windows.Forms.Label()
        Me.picTube = New System.Windows.Forms.PictureBox()
        Me.grpType.SuspendLayout()
        CType(Me.picTube, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHeading.Location = New System.Drawing.Point(12, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(373, 37)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Purchase London Tube Tickets"
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTickets.Location = New System.Drawing.Point(48, 78)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(169, 25)
        Me.lblTickets.TabIndex = 1
        Me.lblTickets.Text = "Number of Tickets:"
        '
        'txtNumberOfTickets
        '
        Me.txtNumberOfTickets.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumberOfTickets.Location = New System.Drawing.Point(223, 75)
        Me.txtNumberOfTickets.Name = "txtNumberOfTickets"
        Me.txtNumberOfTickets.Size = New System.Drawing.Size(55, 33)
        Me.txtNumberOfTickets.TabIndex = 2
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.radZone6)
        Me.grpType.Controls.Add(Me.radZone5)
        Me.grpType.Controls.Add(Me.radZone3)
        Me.grpType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpType.Location = New System.Drawing.Point(48, 139)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(230, 128)
        Me.grpType.TabIndex = 3
        Me.grpType.TabStop = False
        Me.grpType.Text = "Ticket Type: Select One"
        '
        'radZone6
        '
        Me.radZone6.AutoSize = True
        Me.radZone6.Location = New System.Drawing.Point(7, 93)
        Me.radZone6.Name = "radZone6"
        Me.radZone6.Size = New System.Drawing.Size(151, 25)
        Me.radZone6.TabIndex = 2
        Me.radZone6.Text = "Zones 1-6 (£6.00)"
        Me.radZone6.UseVisualStyleBackColor = True
        '
        'radZone5
        '
        Me.radZone5.AutoSize = True
        Me.radZone5.Location = New System.Drawing.Point(7, 61)
        Me.radZone5.Name = "radZone5"
        Me.radZone5.Size = New System.Drawing.Size(151, 25)
        Me.radZone5.TabIndex = 1
        Me.radZone5.Text = "Zones 1-5 (£5.90)"
        Me.radZone5.UseVisualStyleBackColor = True
        '
        'radZone3
        '
        Me.radZone3.AutoSize = True
        Me.radZone3.Checked = True
        Me.radZone3.Location = New System.Drawing.Point(7, 29)
        Me.radZone3.Name = "radZone3"
        Me.radZone3.Size = New System.Drawing.Size(151, 25)
        Me.radZone3.TabIndex = 0
        Me.radZone3.TabStop = True
        Me.radZone3.Text = "Zones 1-3 (£4.90)"
        Me.radZone3.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(48, 296)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(103, 32)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Buy Tickets"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(223, 296)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 32)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCost.Location = New System.Drawing.Point(48, 356)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(152, 25)
        Me.lblCost.TabIndex = 6
        Me.lblCost.Text = "Final Ticket Cost:"
        '
        'lblCostTickets
        '
        Me.lblCostTickets.AutoSize = True
        Me.lblCostTickets.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCostTickets.Location = New System.Drawing.Point(240, 356)
        Me.lblCostTickets.Name = "lblCostTickets"
        Me.lblCostTickets.Size = New System.Drawing.Size(86, 25)
        Me.lblCostTickets.TabIndex = 7
        Me.lblCostTickets.Text = "$0000.00"
        '
        'picTube
        '
        Me.picTube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picTube.Image = CType(resources.GetObject("picTube.Image"), System.Drawing.Image)
        Me.picTube.Location = New System.Drawing.Point(425, -3)
        Me.picTube.Name = "picTube"
        Me.picTube.Size = New System.Drawing.Size(272, 419)
        Me.picTube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTube.TabIndex = 8
        Me.picTube.TabStop = False
        '
        'frmLondon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(696, 407)
        Me.Controls.Add(Me.picTube)
        Me.Controls.Add(Me.lblCostTickets)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.txtNumberOfTickets)
        Me.Controls.Add(Me.lblTickets)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmLondon"
        Me.Text = "London Tube Tickets"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        CType(Me.picTube, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblTickets As Label
    Friend WithEvents txtNumberOfTickets As TextBox
    Friend WithEvents grpType As GroupBox
    Friend WithEvents radZone6 As RadioButton
    Friend WithEvents radZone5 As RadioButton
    Friend WithEvents radZone3 As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblCost As Label
    Friend WithEvents lblCostTickets As Label
    Friend WithEvents picTube As PictureBox
End Class
