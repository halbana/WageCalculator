<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WageCalculatorForm
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
      Me.wageLabel = New System.Windows.Forms.Label()
      Me.hoursLabel = New System.Windows.Forms.Label()
      Me.earningsLabel = New System.Windows.Forms.Label()
      Me.earningsResultLabel = New System.Windows.Forms.Label()
      Me.wageTextBox = New System.Windows.Forms.TextBox()
      Me.hoursTextBox = New System.Windows.Forms.TextBox()
      Me.calculateButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'wageLabel
      '
      Me.wageLabel.AutoSize = True
      Me.wageLabel.Location = New System.Drawing.Point(11, 15)
      Me.wageLabel.Name = "wageLabel"
      Me.wageLabel.Size = New System.Drawing.Size(77, 15)
      Me.wageLabel.TabIndex = 0
      Me.wageLabel.Text = "Hourly wage:"
      Me.wageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'hoursLabel
      '
      Me.hoursLabel.AutoSize = True
      Me.hoursLabel.Location = New System.Drawing.Point(11, 51)
      Me.hoursLabel.Name = "hoursLabel"
      Me.hoursLabel.Size = New System.Drawing.Size(81, 15)
      Me.hoursLabel.TabIndex = 1
      Me.hoursLabel.Text = "Weekly hours:"
      Me.hoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'earningsLabel
      '
      Me.earningsLabel.AutoSize = True
      Me.earningsLabel.Location = New System.Drawing.Point(11, 88)
      Me.earningsLabel.Name = "earningsLabel"
      Me.earningsLabel.Size = New System.Drawing.Size(87, 15)
      Me.earningsLabel.TabIndex = 2
      Me.earningsLabel.Text = "Gross earnings:"
      Me.earningsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'earningsResultLabel
      '
      Me.earningsResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.earningsResultLabel.Location = New System.Drawing.Point(110, 84)
      Me.earningsResultLabel.Name = "earningsResultLabel"
      Me.earningsResultLabel.Size = New System.Drawing.Size(82, 23)
      Me.earningsResultLabel.TabIndex = 3
      Me.earningsResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'wageTextBox
      '
      Me.wageTextBox.Location = New System.Drawing.Point(110, 12)
      Me.wageTextBox.Name = "wageTextBox"
      Me.wageTextBox.Size = New System.Drawing.Size(82, 23)
      Me.wageTextBox.TabIndex = 4
      Me.wageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'hoursTextBox
      '
      Me.hoursTextBox.Location = New System.Drawing.Point(110, 48)
      Me.hoursTextBox.Name = "hoursTextBox"
      Me.hoursTextBox.Size = New System.Drawing.Size(82, 23)
      Me.hoursTextBox.TabIndex = 5
      Me.hoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'calculateButton
      '
      Me.calculateButton.Location = New System.Drawing.Point(110, 121)
      Me.calculateButton.Name = "calculateButton"
      Me.calculateButton.Size = New System.Drawing.Size(82, 23)
      Me.calculateButton.TabIndex = 6
      Me.calculateButton.Text = "Calculate"
      Me.calculateButton.UseVisualStyleBackColor = True
      '
      'WageCalculatorForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(209, 158)
      Me.Controls.Add(Me.calculateButton)
      Me.Controls.Add(Me.hoursTextBox)
      Me.Controls.Add(Me.wageTextBox)
      Me.Controls.Add(Me.earningsResultLabel)
      Me.Controls.Add(Me.earningsLabel)
      Me.Controls.Add(Me.hoursLabel)
      Me.Controls.Add(Me.wageLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "WageCalculatorForm"
      Me.Text = "Wage Calculator"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents wageLabel As System.Windows.Forms.Label
   Friend WithEvents hoursLabel As System.Windows.Forms.Label
   Friend WithEvents earningsLabel As System.Windows.Forms.Label
   Friend WithEvents earningsResultLabel As System.Windows.Forms.Label
   Friend WithEvents wageTextBox As System.Windows.Forms.TextBox
   Friend WithEvents hoursTextBox As System.Windows.Forms.TextBox
   Friend WithEvents calculateButton As System.Windows.Forms.Button

End Class
