<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Minesweeper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Minesweeper))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.b1 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b6 = New System.Windows.Forms.Button()
        Me.b5 = New System.Windows.Forms.Button()
        Me.b4 = New System.Windows.Forms.Button()
        Me.b9 = New System.Windows.Forms.Button()
        Me.b8 = New System.Windows.Forms.Button()
        Me.b7 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B10 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.b9)
        Me.GroupBox1.Controls.Add(Me.b8)
        Me.GroupBox1.Controls.Add(Me.b7)
        Me.GroupBox1.Controls.Add(Me.b6)
        Me.GroupBox1.Controls.Add(Me.b5)
        Me.GroupBox1.Controls.Add(Me.b4)
        Me.GroupBox1.Controls.Add(Me.b3)
        Me.GroupBox1.Controls.Add(Me.b2)
        Me.GroupBox1.Controls.Add(Me.b1)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 233)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'b1
        '
        Me.b1.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.Location = New System.Drawing.Point(0, -1)
        Me.b1.Margin = New System.Windows.Forms.Padding(0)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(80, 80)
        Me.b1.TabIndex = 4
        Me.b1.Text = "*"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.Location = New System.Drawing.Point(78, -1)
        Me.b2.Margin = New System.Windows.Forms.Padding(0)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(80, 80)
        Me.b2.TabIndex = 5
        Me.b2.Text = "*"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b3.Location = New System.Drawing.Point(157, -1)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(80, 80)
        Me.b3.TabIndex = 6
        Me.b3.Text = "*"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b6
        '
        Me.b6.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b6.Location = New System.Drawing.Point(156, 77)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(80, 80)
        Me.b6.TabIndex = 9
        Me.b6.Text = "*"
        Me.b6.UseVisualStyleBackColor = True
        '
        'b5
        '
        Me.b5.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b5.Location = New System.Drawing.Point(78, 76)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(80, 80)
        Me.b5.TabIndex = 8
        Me.b5.Text = "*"
        Me.b5.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b4.Location = New System.Drawing.Point(0, 75)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(80, 80)
        Me.b4.TabIndex = 7
        Me.b4.Text = "*"
        Me.b4.UseVisualStyleBackColor = True
        '
        'b9
        '
        Me.b9.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b9.Location = New System.Drawing.Point(157, 154)
        Me.b9.Name = "b9"
        Me.b9.Size = New System.Drawing.Size(80, 80)
        Me.b9.TabIndex = 12
        Me.b9.Text = "*"
        Me.b9.UseVisualStyleBackColor = True
        '
        'b8
        '
        Me.b8.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b8.Location = New System.Drawing.Point(78, 154)
        Me.b8.Name = "b8"
        Me.b8.Size = New System.Drawing.Size(80, 80)
        Me.b8.TabIndex = 11
        Me.b8.Text = "*"
        Me.b8.UseVisualStyleBackColor = True
        '
        'b7
        '
        Me.b7.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b7.Location = New System.Drawing.Point(0, 153)
        Me.b7.Name = "b7"
        Me.b7.Size = New System.Drawing.Size(80, 80)
        Me.b7.TabIndex = 10
        Me.b7.Text = "*"
        Me.b7.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 2200
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 2400
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 2600
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        Me.Timer5.Interval = 2800
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(80, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'B10
        '
        Me.B10.Location = New System.Drawing.Point(300, 302)
        Me.B10.Name = "B10"
        Me.B10.Size = New System.Drawing.Size(75, 23)
        Me.B10.TabIndex = 3
        Me.B10.Text = "Start"
        Me.B10.UseVisualStyleBackColor = True
        Me.B10.Visible = False
        '
        'Minesweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 341)
        Me.Controls.Add(Me.B10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Minesweeper"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents b9 As Button
    Friend WithEvents b8 As Button
    Friend WithEvents b7 As Button
    Friend WithEvents b6 As Button
    Friend WithEvents b5 As Button
    Friend WithEvents b4 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents B10 As Button
End Class
