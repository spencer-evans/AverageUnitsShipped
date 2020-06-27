<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtEntryDisplay = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(87, 22)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(44, 17)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(141, 19)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(100, 22)
        Me.txtUnits.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtUnits, "Enter the number of units shipped")
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(247, 22)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(45, 17)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "Day 1"
        '
        'txtEntryDisplay
        '
        Me.txtEntryDisplay.Location = New System.Drawing.Point(67, 52)
        Me.txtEntryDisplay.Multiline = True
        Me.txtEntryDisplay.Name = "txtEntryDisplay"
        Me.txtEntryDisplay.ReadOnly = True
        Me.txtEntryDisplay.Size = New System.Drawing.Size(249, 163)
        Me.txtEntryDisplay.TabIndex = 3
        Me.txtEntryDisplay.TabStop = False
        Me.txtEntryDisplay.WordWrap = False
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(66, 218)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(250, 31)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblOutput, "Average Units Shipped")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(55, 276)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 29)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Enter Data")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(152, 275)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 30)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Clear form and start over")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(249, 275)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 29)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "End application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(378, 325)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtEntryDisplay)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblUnits)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents lblDays As Label
    Friend WithEvents txtEntryDisplay As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
