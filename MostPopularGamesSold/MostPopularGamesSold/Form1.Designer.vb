<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostPopularGames
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
        Me.lstGames = New System.Windows.Forms.ListBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblGameDownloads = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstGames
        '
        Me.lstGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGames.FormattingEnabled = True
        Me.lstGames.ItemHeight = 16
        Me.lstGames.Location = New System.Drawing.Point(24, 42)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(211, 164)
        Me.lstGames.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(22, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(215, 20)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Top 10 Selling Mobile Games"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(47, 242)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(164, 16)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total Downloads: XXXXXX"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGameDownloads
        '
        Me.lblGameDownloads.AutoSize = True
        Me.lblGameDownloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameDownloads.Location = New System.Drawing.Point(20, 215)
        Me.lblGameDownloads.Name = "lblGameDownloads"
        Me.lblGameDownloads.Size = New System.Drawing.Size(219, 16)
        Me.lblGameDownloads.TabIndex = 4
        Me.lblGameDownloads.Text = "Selected Game Downloads: XXXXX"
        Me.lblGameDownloads.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblGameDownloads.Visible = False
        '
        'frmMostPopularGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 271)
        Me.Controls.Add(Me.lblGameDownloads)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lstGames)
        Me.Name = "frmMostPopularGames"
        Me.Text = "Most Popular Games"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGames As ListBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblGameDownloads As Label
End Class
