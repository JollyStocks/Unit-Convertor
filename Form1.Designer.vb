<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblHour = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHourClaim = New System.Windows.Forms.Label()
        Me.cmdClaimd = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Optjob1 = New System.Windows.Forms.RadioButton()
        Me.Optjob2 = New System.Windows.Forms.RadioButton()
        Me.lblClaimed = New System.Windows.Forms.TextBox()
        Me.hsbHourd = New System.Windows.Forms.HScrollBar()
        Me.SuspendLayout()
        '
        'lblHour
        '
        Me.lblHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.Location = New System.Drawing.Point(256, 123)
        Me.lblHour.Multiline = True
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(283, 38)
        Me.lblHour.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(163, 52)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(309, 39)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Payroll for the day"
        '
        'lblHourClaim
        '
        Me.lblHourClaim.AutoSize = True
        Me.lblHourClaim.BackColor = System.Drawing.Color.Transparent
        Me.lblHourClaim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourClaim.Location = New System.Drawing.Point(49, 123)
        Me.lblHourClaim.Name = "lblHourClaim"
        Me.lblHourClaim.Size = New System.Drawing.Size(116, 24)
        Me.lblHourClaim.TabIndex = 4
        Me.lblHourClaim.Text = "Hours work"
        '
        'cmdClaimd
        '
        Me.cmdClaimd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClaimd.Location = New System.Drawing.Point(45, 244)
        Me.cmdClaimd.Name = "cmdClaimd"
        Me.cmdClaimd.Size = New System.Drawing.Size(120, 59)
        Me.cmdClaimd.TabIndex = 5
        Me.cmdClaimd.Text = "Compter Claim"
        Me.cmdClaimd.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(46, 335)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(119, 47)
        Me.cmdClear.TabIndex = 6
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(45, 426)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(120, 56)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Optjob1
        '
        Me.Optjob1.AutoSize = True
        Me.Optjob1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Optjob1.Location = New System.Drawing.Point(256, 259)
        Me.Optjob1.Name = "Optjob1"
        Me.Optjob1.Size = New System.Drawing.Size(92, 28)
        Me.Optjob1.TabIndex = 8
        Me.Optjob1.TabStop = True
        Me.Optjob1.Text = "Cashier"
        Me.Optjob1.UseVisualStyleBackColor = True
        '
        'Optjob2
        '
        Me.Optjob2.AutoSize = True
        Me.Optjob2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Optjob2.Location = New System.Drawing.Point(400, 259)
        Me.Optjob2.Name = "Optjob2"
        Me.Optjob2.Size = New System.Drawing.Size(139, 28)
        Me.Optjob2.TabIndex = 9
        Me.Optjob2.TabStop = True
        Me.Optjob2.Text = "Store Keeper"
        Me.Optjob2.UseVisualStyleBackColor = True
        '
        'lblClaimed
        '
        Me.lblClaimed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaimed.Location = New System.Drawing.Point(256, 321)
        Me.lblClaimed.Multiline = True
        Me.lblClaimed.Name = "lblClaimed"
        Me.lblClaimed.Size = New System.Drawing.Size(283, 161)
        Me.lblClaimed.TabIndex = 10
        '
        'hsbHourd
        '
        Me.hsbHourd.LargeChange = 1
        Me.hsbHourd.Location = New System.Drawing.Point(45, 190)
        Me.hsbHourd.Maximum = 14
        Me.hsbHourd.Minimum = 1
        Me.hsbHourd.Name = "hsbHourd"
        Me.hsbHourd.Size = New System.Drawing.Size(492, 31)
        Me.hsbHourd.TabIndex = 11
        Me.hsbHourd.Value = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(672, 513)
        Me.Controls.Add(Me.hsbHourd)
        Me.Controls.Add(Me.lblClaimed)
        Me.Controls.Add(Me.Optjob2)
        Me.Controls.Add(Me.Optjob1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdClaimd)
        Me.Controls.Add(Me.lblHourClaim)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblHour)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHour As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblHourClaim As System.Windows.Forms.Label
    Friend WithEvents cmdClaimd As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Optjob1 As System.Windows.Forms.RadioButton
    Friend WithEvents Optjob2 As System.Windows.Forms.RadioButton
    Friend WithEvents lblClaimed As System.Windows.Forms.TextBox
    Friend WithEvents hsbHourd As System.Windows.Forms.HScrollBar

End Class
