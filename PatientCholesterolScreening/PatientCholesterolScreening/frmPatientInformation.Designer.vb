<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientInformation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstPatients = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstCholesterol = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSaveConsult = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSaved = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient"
        '
        'lstPatients
        '
        Me.lstPatients.FormattingEnabled = True
        Me.lstPatients.Location = New System.Drawing.Point(46, 70)
        Me.lstPatients.Name = "lstPatients"
        Me.lstPatients.Size = New System.Drawing.Size(120, 212)
        Me.lstPatients.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(371, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuBack
        '
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(117, 22)
        Me.mnuBack.Text = "Go Back"
        '
        'lstCholesterol
        '
        Me.lstCholesterol.FormattingEnabled = True
        Me.lstCholesterol.Location = New System.Drawing.Point(208, 70)
        Me.lstCholesterol.Name = "lstCholesterol"
        Me.lstCholesterol.Size = New System.Drawing.Size(120, 212)
        Me.lstCholesterol.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cholesterol"
        '
        'btnSaveConsult
        '
        Me.btnSaveConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveConsult.Location = New System.Drawing.Point(46, 289)
        Me.btnSaveConsult.Name = "btnSaveConsult"
        Me.btnSaveConsult.Size = New System.Drawing.Size(122, 46)
        Me.btnSaveConsult.TabIndex = 4
        Me.btnSaveConsult.Text = "Save for Later " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consult"
        Me.btnSaveConsult.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Patient Information"
        '
        'lblSaved
        '
        Me.lblSaved.AutoSize = True
        Me.lblSaved.Location = New System.Drawing.Point(87, 344)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(41, 13)
        Me.lblSaved.TabIndex = 6
        Me.lblSaved.Text = "Saved!"
        Me.lblSaved.Visible = False
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(188, 306)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(161, 16)
        Me.lblAverage.TabIndex = 7
        Me.lblAverage.Text = "Average Cholesterol: XXX"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmPatientInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 368)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSaveConsult)
        Me.Controls.Add(Me.lstCholesterol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstPatients)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPatientInformation"
        Me.Text = "Patient Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstPatients As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents lstCholesterol As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSaveConsult As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSaved As Label
    Friend WithEvents lblAverage As Label
End Class
