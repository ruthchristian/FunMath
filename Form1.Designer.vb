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
        Me.BTN = New System.Windows.Forms.Button()
        Me.TXTB1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Limacon = New System.Windows.Forms.CheckBox()
        Me.Cardioid = New System.Windows.Forms.CheckBox()
        Me.Circle = New System.Windows.Forms.CheckBox()
        Me.TXTB2 = New System.Windows.Forms.TextBox()
        Me.TXTB3 = New System.Windows.Forms.TextBox()
        Me.L1 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN
        '
        Me.BTN.Location = New System.Drawing.Point(0, 0)
        Me.BTN.Name = "BTN"
        Me.BTN.Size = New System.Drawing.Size(75, 23)
        Me.BTN.TabIndex = 0
        Me.BTN.Text = "MEH"
        Me.BTN.UseVisualStyleBackColor = True
        '
        'TXTB1
        '
        Me.TXTB1.Location = New System.Drawing.Point(117, 0)
        Me.TXTB1.Name = "TXTB1"
        Me.TXTB1.Size = New System.Drawing.Size(100, 20)
        Me.TXTB1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "File Name"
        '
        'Limacon
        '
        Me.Limacon.AutoSize = True
        Me.Limacon.Location = New System.Drawing.Point(12, 71)
        Me.Limacon.Name = "Limacon"
        Me.Limacon.Size = New System.Drawing.Size(66, 17)
        Me.Limacon.TabIndex = 4
        Me.Limacon.Text = "Limacon"
        Me.Limacon.UseVisualStyleBackColor = True
        '
        'Cardioid
        '
        Me.Cardioid.AutoSize = True
        Me.Cardioid.Location = New System.Drawing.Point(12, 94)
        Me.Cardioid.Name = "Cardioid"
        Me.Cardioid.Size = New System.Drawing.Size(64, 17)
        Me.Cardioid.TabIndex = 5
        Me.Cardioid.Text = "Cardioid"
        Me.Cardioid.UseVisualStyleBackColor = True
        '
        'Circle
        '
        Me.Circle.AutoSize = True
        Me.Circle.Location = New System.Drawing.Point(12, 117)
        Me.Circle.Name = "Circle"
        Me.Circle.Size = New System.Drawing.Size(52, 17)
        Me.Circle.TabIndex = 6
        Me.Circle.Text = "Circle"
        Me.Circle.UseVisualStyleBackColor = True
        '
        'TXTB2
        '
        Me.TXTB2.Location = New System.Drawing.Point(267, 0)
        Me.TXTB2.Name = "TXTB2"
        Me.TXTB2.Size = New System.Drawing.Size(100, 20)
        Me.TXTB2.TabIndex = 7
        Me.TXTB2.Visible = False
        '
        'TXTB3
        '
        Me.TXTB3.Location = New System.Drawing.Point(267, 57)
        Me.TXTB3.Name = "TXTB3"
        Me.TXTB3.Size = New System.Drawing.Size(100, 20)
        Me.TXTB3.TabIndex = 8
        Me.TXTB3.Visible = False
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(285, 23)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(61, 13)
        Me.L1.TabIndex = 9
        Me.L1.Text = "1st Number"
        Me.L1.Visible = False
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Location = New System.Drawing.Point(285, 80)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(65, 13)
        Me.L2.TabIndex = 10
        Me.L2.Text = "2nd Number"
        Me.L2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 293)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.TXTB3)
        Me.Controls.Add(Me.TXTB2)
        Me.Controls.Add(Me.Circle)
        Me.Controls.Add(Me.Cardioid)
        Me.Controls.Add(Me.Limacon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTB1)
        Me.Controls.Add(Me.BTN)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN As Button
    Friend WithEvents TXTB1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Limacon As CheckBox
    Friend WithEvents Cardioid As CheckBox
    Friend WithEvents Circle As CheckBox
    Friend WithEvents TXTB2 As TextBox
    Friend WithEvents TXTB3 As TextBox
    Friend WithEvents L1 As Label
    Friend WithEvents L2 As Label
End Class
