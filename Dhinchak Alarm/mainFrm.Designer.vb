<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.setButton = New System.Windows.Forms.Button()
        Me.alarmTimer = New System.Windows.Forms.Timer(Me.components)
        Me.timeLeftLabel = New System.Windows.Forms.Label()
        Me.hourUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MinuteUpDown = New System.Windows.Forms.NumericUpDown()
        Me.alarmSoundSelector = New System.Windows.Forms.ComboBox()
        CType(Me.hourUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinuteUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'setButton
        '
        Me.setButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setButton.Location = New System.Drawing.Point(169, 260)
        Me.setButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.setButton.Name = "setButton"
        Me.setButton.Size = New System.Drawing.Size(131, 40)
        Me.setButton.TabIndex = 3
        Me.setButton.Text = "Set"
        Me.setButton.UseVisualStyleBackColor = True
        '
        'alarmTimer
        '
        Me.alarmTimer.Interval = 1000
        '
        'timeLeftLabel
        '
        Me.timeLeftLabel.AutoSize = True
        Me.timeLeftLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLeftLabel.Location = New System.Drawing.Point(16, 14)
        Me.timeLeftLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timeLeftLabel.Name = "timeLeftLabel"
        Me.timeLeftLabel.Size = New System.Drawing.Size(110, 45)
        Me.timeLeftLabel.TabIndex = 4
        Me.timeLeftLabel.Text = "Label1"
        '
        'hourUpDown
        '
        Me.hourUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hourUpDown.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourUpDown.Location = New System.Drawing.Point(5, 260)
        Me.hourUpDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.hourUpDown.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.hourUpDown.Name = "hourUpDown"
        Me.hourUpDown.Size = New System.Drawing.Size(78, 39)
        Me.hourUpDown.TabIndex = 1
        '
        'MinuteUpDown
        '
        Me.MinuteUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MinuteUpDown.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinuteUpDown.Location = New System.Drawing.Point(91, 260)
        Me.MinuteUpDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinuteUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.MinuteUpDown.Name = "MinuteUpDown"
        Me.MinuteUpDown.Size = New System.Drawing.Size(70, 39)
        Me.MinuteUpDown.TabIndex = 2
        '
        'alarmSoundSelector
        '
        Me.alarmSoundSelector.AccessibleDescription = "Select songs from Dhinchak Pooja (or other reputed singers)"
        Me.alarmSoundSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.alarmSoundSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.alarmSoundSelector.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alarmSoundSelector.FormattingEnabled = True
        Me.alarmSoundSelector.Items.AddRange(New Object() {"Selfie Maine Le Li Aaj", "Dilon Ka Shooter"})
        Me.alarmSoundSelector.Location = New System.Drawing.Point(307, 260)
        Me.alarmSoundSelector.Name = "alarmSoundSelector"
        Me.alarmSoundSelector.Size = New System.Drawing.Size(287, 40)
        Me.alarmSoundSelector.TabIndex = 4
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 303)
        Me.Controls.Add(Me.alarmSoundSelector)
        Me.Controls.Add(Me.MinuteUpDown)
        Me.Controls.Add(Me.hourUpDown)
        Me.Controls.Add(Me.timeLeftLabel)
        Me.Controls.Add(Me.setButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Dhinchak Alarm"
        CType(Me.hourUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinuteUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents setButton As Button
    Friend WithEvents alarmTimer As Timer
    Friend WithEvents timeLeftLabel As Label
    Friend WithEvents hourUpDown As NumericUpDown
    Friend WithEvents MinuteUpDown As NumericUpDown
    Friend WithEvents alarmSoundSelector As ComboBox
End Class
