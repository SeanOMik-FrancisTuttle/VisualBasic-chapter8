<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartHomeMonthyElectricSavings
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
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblSaving = New System.Windows.Forms.Label()
        Me.btnDisplayStatistics = New System.Windows.Forms.Button()
        Me.lblAverageSavings = New System.Windows.Forms.Label()
        Me.lblMostSaving = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Location = New System.Drawing.Point(94, 38)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 21)
        Me.cboMonth.TabIndex = 0
        '
        'lblSaving
        '
        Me.lblSaving.AutoSize = True
        Me.lblSaving.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaving.Location = New System.Drawing.Point(121, 62)
        Me.lblSaving.Name = "lblSaving"
        Me.lblSaving.Size = New System.Drawing.Size(66, 20)
        Me.lblSaving.TabIndex = 1
        Me.lblSaving.Text = "$XX.XX"
        Me.lblSaving.Visible = False
        '
        'btnDisplayStatistics
        '
        Me.btnDisplayStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayStatistics.Location = New System.Drawing.Point(87, 85)
        Me.btnDisplayStatistics.Name = "btnDisplayStatistics"
        Me.btnDisplayStatistics.Size = New System.Drawing.Size(134, 23)
        Me.btnDisplayStatistics.TabIndex = 2
        Me.btnDisplayStatistics.Text = "Display Statistics"
        Me.btnDisplayStatistics.UseVisualStyleBackColor = True
        Me.btnDisplayStatistics.Visible = False
        '
        'lblAverageSavings
        '
        Me.lblAverageSavings.AutoSize = True
        Me.lblAverageSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSavings.Location = New System.Drawing.Point(74, 111)
        Me.lblAverageSavings.Name = "lblAverageSavings"
        Me.lblAverageSavings.Size = New System.Drawing.Size(160, 16)
        Me.lblAverageSavings.TabIndex = 3
        Me.lblAverageSavings.Text = "Average Savings: $XX.XX"
        Me.lblAverageSavings.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblAverageSavings.Visible = False
        '
        'lblMostSaving
        '
        Me.lblMostSaving.AutoSize = True
        Me.lblMostSaving.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostSaving.Location = New System.Drawing.Point(86, 137)
        Me.lblMostSaving.Name = "lblMostSaving"
        Me.lblMostSaving.Size = New System.Drawing.Size(137, 16)
        Me.lblMostSaving.TabIndex = 4
        Me.lblMostSaving.Text = "Most Savings: $XX.XX"
        Me.lblMostSaving.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblMostSaving.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Smart Home Monthy Electric Savings"
        '
        'frmSmartHomeMonthyElectricSavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartHomeMonthyElectricSavings.My.Resources.Resources.smarthome
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(308, 162)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMostSaving)
        Me.Controls.Add(Me.lblAverageSavings)
        Me.Controls.Add(Me.btnDisplayStatistics)
        Me.Controls.Add(Me.lblSaving)
        Me.Controls.Add(Me.cboMonth)
        Me.Name = "frmSmartHomeMonthyElectricSavings"
        Me.Text = "Smart Home Monthy Electric Savings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblSaving As Label
    Friend WithEvents btnDisplayStatistics As Button
    Friend WithEvents lblAverageSavings As Label
    Friend WithEvents lblMostSaving As Label
    Friend WithEvents Label1 As Label
End Class
