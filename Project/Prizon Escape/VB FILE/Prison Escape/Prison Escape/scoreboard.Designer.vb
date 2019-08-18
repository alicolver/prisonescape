<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scoreboard
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
        Me.lstBNames = New System.Windows.Forms.ListBox()
        Me.lstBTimes = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnHow2Play = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lstBPositions = New System.Windows.Forms.ListBox()
        Me.lstIPositions = New System.Windows.Forms.ListBox()
        Me.lstITimes = New System.Windows.Forms.ListBox()
        Me.lstINames = New System.Windows.Forms.ListBox()
        Me.lstEPositions = New System.Windows.Forms.ListBox()
        Me.lstETimes = New System.Windows.Forms.ListBox()
        Me.lstENames = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstBNames
        '
        Me.lstBNames.FormattingEnabled = True
        Me.lstBNames.Location = New System.Drawing.Point(45, 62)
        Me.lstBNames.Margin = New System.Windows.Forms.Padding(2)
        Me.lstBNames.MultiColumn = True
        Me.lstBNames.Name = "lstBNames"
        Me.lstBNames.Size = New System.Drawing.Size(122, 199)
        Me.lstBNames.TabIndex = 0
        '
        'lstBTimes
        '
        Me.lstBTimes.FormattingEnabled = True
        Me.lstBTimes.Location = New System.Drawing.Point(170, 62)
        Me.lstBTimes.Margin = New System.Windows.Forms.Padding(2)
        Me.lstBTimes.MultiColumn = True
        Me.lstBTimes.Name = "lstBTimes"
        Me.lstBTimes.Size = New System.Drawing.Size(92, 199)
        Me.lstBTimes.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(849, 21)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 70)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnHow2Play
        '
        Me.btnHow2Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHow2Play.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnHow2Play.Location = New System.Drawing.Point(849, 108)
        Me.btnHow2Play.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHow2Play.Name = "btnHow2Play"
        Me.btnHow2Play.Size = New System.Drawing.Size(117, 70)
        Me.btnHow2Play.TabIndex = 4
        Me.btnHow2Play.Text = "How to Play"
        Me.btnHow2Play.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnStart.Location = New System.Drawing.Point(849, 190)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(117, 70)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lstBPositions
        '
        Me.lstBPositions.FormattingEnabled = True
        Me.lstBPositions.Location = New System.Drawing.Point(12, 62)
        Me.lstBPositions.MultiColumn = True
        Me.lstBPositions.Name = "lstBPositions"
        Me.lstBPositions.Size = New System.Drawing.Size(30, 199)
        Me.lstBPositions.TabIndex = 6
        '
        'lstIPositions
        '
        Me.lstIPositions.FormattingEnabled = True
        Me.lstIPositions.Location = New System.Drawing.Point(311, 62)
        Me.lstIPositions.Name = "lstIPositions"
        Me.lstIPositions.Size = New System.Drawing.Size(30, 199)
        Me.lstIPositions.TabIndex = 9
        '
        'lstITimes
        '
        Me.lstITimes.FormattingEnabled = True
        Me.lstITimes.Location = New System.Drawing.Point(469, 62)
        Me.lstITimes.Margin = New System.Windows.Forms.Padding(2)
        Me.lstITimes.Name = "lstITimes"
        Me.lstITimes.Size = New System.Drawing.Size(92, 199)
        Me.lstITimes.TabIndex = 8
        '
        'lstINames
        '
        Me.lstINames.FormattingEnabled = True
        Me.lstINames.Location = New System.Drawing.Point(345, 62)
        Me.lstINames.Margin = New System.Windows.Forms.Padding(2)
        Me.lstINames.Name = "lstINames"
        Me.lstINames.Size = New System.Drawing.Size(122, 199)
        Me.lstINames.TabIndex = 7
        '
        'lstEPositions
        '
        Me.lstEPositions.FormattingEnabled = True
        Me.lstEPositions.Location = New System.Drawing.Point(593, 62)
        Me.lstEPositions.Name = "lstEPositions"
        Me.lstEPositions.Size = New System.Drawing.Size(30, 199)
        Me.lstEPositions.TabIndex = 12
        '
        'lstETimes
        '
        Me.lstETimes.FormattingEnabled = True
        Me.lstETimes.Location = New System.Drawing.Point(751, 62)
        Me.lstETimes.Margin = New System.Windows.Forms.Padding(2)
        Me.lstETimes.Name = "lstETimes"
        Me.lstETimes.Size = New System.Drawing.Size(92, 199)
        Me.lstETimes.TabIndex = 11
        '
        'lstENames
        '
        Me.lstENames.FormattingEnabled = True
        Me.lstENames.Location = New System.Drawing.Point(627, 62)
        Me.lstENames.Margin = New System.Windows.Forms.Padding(2)
        Me.lstENames.Name = "lstENames"
        Me.lstENames.Size = New System.Drawing.Size(122, 199)
        Me.lstENames.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Beginner"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(359, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Intermediate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(673, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Expert"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Pos."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(167, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(466, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(748, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(342, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(624, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(308, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Pos."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(590, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Pos."
        '
        'scoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 272)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstEPositions)
        Me.Controls.Add(Me.lstETimes)
        Me.Controls.Add(Me.lstENames)
        Me.Controls.Add(Me.lstIPositions)
        Me.Controls.Add(Me.lstITimes)
        Me.Controls.Add(Me.lstINames)
        Me.Controls.Add(Me.lstBPositions)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnHow2Play)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstBTimes)
        Me.Controls.Add(Me.lstBNames)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "scoreboard"
        Me.Text = "Scoreboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBNames As ListBox
    Friend WithEvents lstBTimes As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnHow2Play As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lstBPositions As System.Windows.Forms.ListBox
    Friend WithEvents lstIPositions As System.Windows.Forms.ListBox
    Friend WithEvents lstITimes As System.Windows.Forms.ListBox
    Friend WithEvents lstINames As System.Windows.Forms.ListBox
    Friend WithEvents lstEPositions As System.Windows.Forms.ListBox
    Friend WithEvents lstETimes As System.Windows.Forms.ListBox
    Friend WithEvents lstENames As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
