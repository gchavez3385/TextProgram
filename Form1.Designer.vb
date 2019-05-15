<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gregory_Chavez_Simple_Visual_Basic_Text_Program
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
        Me.btnClickMe = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.btnChangeColor = New System.Windows.Forms.Button()
        Me.btnChangeLanguage = New System.Windows.Forms.Button()
        Me.btnChangeLocation = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClickMe
        '
        Me.btnClickMe.Location = New System.Drawing.Point(13, 154)
        Me.btnClickMe.Name = "btnClickMe"
        Me.btnClickMe.Size = New System.Drawing.Size(109, 23)
        Me.btnClickMe.TabIndex = 0
        Me.btnClickMe.Text = "Click Me"
        Me.btnClickMe.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(13, 212)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Location = New System.Drawing.Point(122, 87)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(0, 13)
        Me.lblHello.TabIndex = 2
        '
        'btnChangeColor
        '
        Me.btnChangeColor.Location = New System.Drawing.Point(13, 183)
        Me.btnChangeColor.Name = "btnChangeColor"
        Me.btnChangeColor.Size = New System.Drawing.Size(109, 23)
        Me.btnChangeColor.TabIndex = 3
        Me.btnChangeColor.Text = "Change Color"
        Me.btnChangeColor.UseVisualStyleBackColor = True
        '
        'btnChangeLanguage
        '
        Me.btnChangeLanguage.Location = New System.Drawing.Point(157, 154)
        Me.btnChangeLanguage.Name = "btnChangeLanguage"
        Me.btnChangeLanguage.Size = New System.Drawing.Size(115, 23)
        Me.btnChangeLanguage.TabIndex = 4
        Me.btnChangeLanguage.Text = "Change Language"
        Me.btnChangeLanguage.UseVisualStyleBackColor = True
        '
        'btnChangeLocation
        '
        Me.btnChangeLocation.Location = New System.Drawing.Point(157, 183)
        Me.btnChangeLocation.Name = "btnChangeLocation"
        Me.btnChangeLocation.Size = New System.Drawing.Size(115, 23)
        Me.btnChangeLocation.TabIndex = 5
        Me.btnChangeLocation.Text = "Change Location"
        Me.btnChangeLocation.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(157, 212)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(115, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Gregory_Chavez_Simple_Visual_Basic_Text_Program
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnChangeLocation)
        Me.Controls.Add(Me.btnChangeLanguage)
        Me.Controls.Add(Me.btnChangeColor)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClickMe)
        Me.Name = "Gregory_Chavez_Simple_Visual_Basic_Text_Program"
        Me.Text = "Simple Visual Basic Text Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClickMe As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblHello As Label
    Friend WithEvents btnChangeColor As Button
    Friend WithEvents btnChangeLanguage As Button
    Friend WithEvents btnChangeLocation As Button
    Friend WithEvents btnReset As Button
End Class
