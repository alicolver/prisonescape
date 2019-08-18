<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnScoreboard = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblMines = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlMine = New System.Windows.Forms.Panel()
        Me.lblMessages = New System.Windows.Forms.Label()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeginnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntermediateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMessage.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(0, 33)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(502, 389)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnScoreboard, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnHome, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMines, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblClock, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlMine, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMessages, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInstructions, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 33)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(502, 389)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'btnScoreboard
        '
        Me.btnScoreboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnScoreboard.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScoreboard.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnScoreboard.Location = New System.Drawing.Point(315, 332)
        Me.btnScoreboard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnScoreboard.Name = "btnScoreboard"
        Me.btnScoreboard.Size = New System.Drawing.Size(183, 52)
        Me.btnScoreboard.TabIndex = 7
        Me.btnScoreboard.Text = "Scoreboard"
        Me.btnScoreboard.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHome.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnHome.Location = New System.Drawing.Point(195, 332)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(112, 52)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'lblMines
        '
        Me.lblMines.BackColor = System.Drawing.Color.SteelBlue
        Me.lblMines.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMines.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMines.Location = New System.Drawing.Point(9, 9)
        Me.lblMines.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.lblMines.Name = "lblMines"
        Me.lblMines.Size = New System.Drawing.Size(173, 102)
        Me.lblMines.TabIndex = 0
        Me.lblMines.Text = "0"
        Me.lblMines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClock
        '
        Me.lblClock.BackColor = System.Drawing.Color.SteelBlue
        Me.lblClock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblClock.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(320, 9)
        Me.lblClock.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(173, 102)
        Me.lblClock.TabIndex = 1
        Me.lblClock.Text = "0"
        Me.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Image = Global.Prison_Escape.My.Resources.Resources.Smiley
        Me.Button1.Location = New System.Drawing.Point(200, 9)
        Me.Button1.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 102)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Start"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pnlMine
        '
        Me.pnlMine.BackColor = System.Drawing.Color.SteelBlue
        Me.TableLayoutPanel1.SetColumnSpan(Me.pnlMine, 3)
        Me.pnlMine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMine.Location = New System.Drawing.Point(9, 129)
        Me.pnlMine.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.pnlMine.Name = "pnlMine"
        Me.pnlMine.Size = New System.Drawing.Size(484, 127)
        Me.pnlMine.TabIndex = 3
        '
        'lblMessages
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblMessages, 3)
        Me.lblMessages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMessages.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessages.ForeColor = System.Drawing.Color.White
        Me.lblMessages.Location = New System.Drawing.Point(3, 265)
        Me.lblMessages.Name = "lblMessages"
        Me.lblMessages.Size = New System.Drawing.Size(496, 62)
        Me.lblMessages.TabIndex = 4
        Me.lblMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInstructions
        '
        Me.btnInstructions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnInstructions.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnInstructions.Location = New System.Drawing.Point(4, 332)
        Me.btnInstructions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(183, 52)
        Me.btnInstructions.TabIndex = 5
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripMenuItem1, Me.BeginnerToolStripMenuItem, Me.IntermediateToolStripMenuItem, Me.AdvancedToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(70, 29)
        Me.GameToolStripMenuItem.Text = "&Game"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(197, 30)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(194, 6)
        '
        'BeginnerToolStripMenuItem
        '
        Me.BeginnerToolStripMenuItem.Name = "BeginnerToolStripMenuItem"
        Me.BeginnerToolStripMenuItem.Size = New System.Drawing.Size(197, 30)
        Me.BeginnerToolStripMenuItem.Text = "&Beginner"
        '
        'IntermediateToolStripMenuItem
        '
        Me.IntermediateToolStripMenuItem.Name = "IntermediateToolStripMenuItem"
        Me.IntermediateToolStripMenuItem.Size = New System.Drawing.Size(197, 30)
        Me.IntermediateToolStripMenuItem.Text = "&Intermediate"
        '
        'AdvancedToolStripMenuItem
        '
        Me.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        Me.AdvancedToolStripMenuItem.Size = New System.Drawing.Size(197, 30)
        Me.AdvancedToolStripMenuItem.Text = "&Advanced"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(502, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 422)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Start"
        Me.Text = "PRISON ESCAPE"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblMines As Label
    Friend WithEvents lblClock As Label
    Friend WithEvents pnlMine As Panel
    Friend WithEvents lblMessages As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents BeginnerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntermediateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnScoreboard As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
End Class
