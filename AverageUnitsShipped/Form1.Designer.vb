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
        Me.txtEmployee1 = New System.Windows.Forms.TextBox()
        Me.lblEmp1Average = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEmp2Average = New System.Windows.Forms.Label()
        Me.lblEmp3Average = New System.Windows.Forms.Label()
        Me.lblFinalAverage = New System.Windows.Forms.Label()
        Me.txtEmployee2 = New System.Windows.Forms.TextBox()
        Me.txtEmployee3 = New System.Windows.Forms.TextBox()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(19, 25)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(44, 17)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(69, 25)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(62, 22)
        Me.txtUnits.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtUnits, "Enter the number of units shipped")
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(361, 25)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(45, 17)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "Day 1"
        '
        'txtEmployee1
        '
        Me.txtEmployee1.Location = New System.Drawing.Point(21, 95)
        Me.txtEmployee1.Multiline = True
        Me.txtEmployee1.Name = "txtEmployee1"
        Me.txtEmployee1.ReadOnly = True
        Me.txtEmployee1.Size = New System.Drawing.Size(142, 163)
        Me.txtEmployee1.TabIndex = 4
        Me.txtEmployee1.TabStop = False
        Me.txtEmployee1.WordWrap = False
        '
        'lblEmp1Average
        '
        Me.lblEmp1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp1Average.Location = New System.Drawing.Point(21, 266)
        Me.lblEmp1Average.Name = "lblEmp1Average"
        Me.lblEmp1Average.Size = New System.Drawing.Size(142, 31)
        Me.lblEmp1Average.TabIndex = 5
        Me.lblEmp1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblEmp1Average, "Average Units Shipped")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(127, 354)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 29)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Enter Data")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(216, 353)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 30)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Clear form and start over")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(305, 353)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 29)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "End application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEmp2Average
        '
        Me.lblEmp2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp2Average.Location = New System.Drawing.Point(182, 266)
        Me.lblEmp2Average.Name = "lblEmp2Average"
        Me.lblEmp2Average.Size = New System.Drawing.Size(142, 31)
        Me.lblEmp2Average.TabIndex = 8
        Me.lblEmp2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblEmp2Average, "Average Units Shipped")
        '
        'lblEmp3Average
        '
        Me.lblEmp3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp3Average.Location = New System.Drawing.Point(343, 266)
        Me.lblEmp3Average.Name = "lblEmp3Average"
        Me.lblEmp3Average.Size = New System.Drawing.Size(142, 31)
        Me.lblEmp3Average.TabIndex = 11
        Me.lblEmp3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblEmp3Average, "Average Units Shipped")
        '
        'lblFinalAverage
        '
        Me.lblFinalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalAverage.Location = New System.Drawing.Point(22, 306)
        Me.lblFinalAverage.Name = "lblFinalAverage"
        Me.lblFinalAverage.Size = New System.Drawing.Size(463, 31)
        Me.lblFinalAverage.TabIndex = 12
        Me.lblFinalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblFinalAverage, "Average Units Shipped")
        '
        'txtEmployee2
        '
        Me.txtEmployee2.Location = New System.Drawing.Point(182, 95)
        Me.txtEmployee2.Multiline = True
        Me.txtEmployee2.Name = "txtEmployee2"
        Me.txtEmployee2.ReadOnly = True
        Me.txtEmployee2.Size = New System.Drawing.Size(142, 163)
        Me.txtEmployee2.TabIndex = 7
        Me.txtEmployee2.TabStop = False
        Me.txtEmployee2.WordWrap = False
        '
        'txtEmployee3
        '
        Me.txtEmployee3.Location = New System.Drawing.Point(343, 95)
        Me.txtEmployee3.Multiline = True
        Me.txtEmployee3.Name = "txtEmployee3"
        Me.txtEmployee3.ReadOnly = True
        Me.txtEmployee3.Size = New System.Drawing.Size(142, 163)
        Me.txtEmployee3.TabIndex = 10
        Me.txtEmployee3.TabStop = False
        Me.txtEmployee3.WordWrap = False
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee1.Location = New System.Drawing.Point(51, 71)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(92, 17)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(212, 70)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee2.TabIndex = 6
        Me.lblEmployee2.Text = "Employee 2"
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(373, 70)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee3.TabIndex = 9
        Me.lblEmployee3.Text = "Employee 3"
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(506, 407)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblFinalAverage)
        Me.Controls.Add(Me.lblEmp3Average)
        Me.Controls.Add(Me.lblEmp2Average)
        Me.Controls.Add(Me.txtEmployee3)
        Me.Controls.Add(Me.txtEmployee2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblEmp1Average)
        Me.Controls.Add(Me.txtEmployee1)
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
    Friend WithEvents txtEmployee1 As TextBox
    Friend WithEvents lblEmp1Average As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtEmployee2 As TextBox
    Friend WithEvents txtEmployee3 As TextBox
    Friend WithEvents lblEmp2Average As Label
    Friend WithEvents lblEmp3Average As Label
    Friend WithEvents lblFinalAverage As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
End Class
