<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scales))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtScale = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.lblScale = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'txtScale
        '
        Me.txtScale.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScale.Location = New System.Drawing.Point(90, 8)
        Me.txtScale.Name = "txtScale"
        Me.txtScale.Size = New System.Drawing.Size(125, 21)
        Me.txtScale.TabIndex = 0
        '
        'SerialPort1
        '
        Me.SerialPort1.DiscardNull = True
        '
        'lblScale
        '
        Me.lblScale.AutoSize = True
        Me.lblScale.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScale.Location = New System.Drawing.Point(9, 11)
        Me.lblScale.Name = "lblScale"
        Me.lblScale.Size = New System.Drawing.Size(62, 15)
        Me.lblScale.TabIndex = 1
        Me.lblScale.Text = "Message:"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(163, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(90, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Connect"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Scales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 67)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblScale)
        Me.Controls.Add(Me.txtScale)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Scales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maheen Textile Mills (pvt) Ltd."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtScale As System.Windows.Forms.TextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents lblScale As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
