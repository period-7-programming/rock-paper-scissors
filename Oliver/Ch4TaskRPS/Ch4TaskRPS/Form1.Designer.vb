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
        Me.components = New System.ComponentModel.Container()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblLosses = New System.Windows.Forms.Label()
        Me.lblTies = New System.Windows.Forms.Label()
        Me.lblComputerChoice = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(110, 93)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "See Winner"
        Me.ToolTip1.SetToolTip(Me.btnPlay, "Play the game.")
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radScissors)
        Me.GroupBox1.Controls.Add(Me.radPaper)
        Me.GroupBox1.Controls.Add(Me.radRock)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Object:"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Select your choice of object.")
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(134, 19)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(64, 17)
        Me.radScissors.TabIndex = 2
        Me.radScissors.TabStop = True
        Me.radScissors.Text = "Scissors"
        Me.ToolTip1.SetToolTip(Me.radScissors, "Beats paper, loses to rock, ties with scissors.")
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(73, 19)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(53, 17)
        Me.radPaper.TabIndex = 1
        Me.radPaper.TabStop = True
        Me.radPaper.Text = "Paper"
        Me.ToolTip1.SetToolTip(Me.radPaper, "Beats rock, loses to scissors, ties with paper.")
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(7, 20)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(51, 17)
        Me.radRock.TabIndex = 0
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.ToolTip1.SetToolTip(Me.radRock, "Beats scissors, loses to paper, ties with rock.")
        Me.radRock.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(308, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetScoreToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'ResetScoreToolStripMenuItem
        '
        Me.ResetScoreToolStripMenuItem.Name = "ResetScoreToolStripMenuItem"
        Me.ResetScoreToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ResetScoreToolStripMenuItem.Text = "Reset Score"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Location = New System.Drawing.Point(56, 162)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(43, 13)
        Me.lblWins.TabIndex = 3
        Me.lblWins.Text = "Wins: 0"
        Me.ToolTip1.SetToolTip(Me.lblWins, "You have won 0 times.")
        '
        'lblLosses
        '
        Me.lblLosses.AutoSize = True
        Me.lblLosses.Location = New System.Drawing.Point(206, 162)
        Me.lblLosses.Name = "lblLosses"
        Me.lblLosses.Size = New System.Drawing.Size(52, 13)
        Me.lblLosses.TabIndex = 4
        Me.lblLosses.Text = "Losses: 0"
        Me.ToolTip1.SetToolTip(Me.lblLosses, "You have lost 0 times.")
        '
        'lblTies
        '
        Me.lblTies.AutoSize = True
        Me.lblTies.Location = New System.Drawing.Point(128, 162)
        Me.lblTies.Name = "lblTies"
        Me.lblTies.Size = New System.Drawing.Size(39, 13)
        Me.lblTies.TabIndex = 5
        Me.lblTies.Text = "Ties: 0"
        Me.ToolTip1.SetToolTip(Me.lblTies, "There has been 0 ties.")
        '
        'lblComputerChoice
        '
        Me.lblComputerChoice.Location = New System.Drawing.Point(56, 128)
        Me.lblComputerChoice.Name = "lblComputerChoice"
        Me.lblComputerChoice.Size = New System.Drawing.Size(183, 23)
        Me.lblComputerChoice.TabIndex = 6
        Me.lblComputerChoice.Text = "Result"
        Me.lblComputerChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 207)
        Me.Controls.Add(Me.lblComputerChoice)
        Me.Controls.Add(Me.lblTies)
        Me.Controls.Add(Me.lblLosses)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radScissors As RadioButton
    Friend WithEvents radPaper As RadioButton
    Friend WithEvents radRock As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblWins As Label
    Friend WithEvents lblLosses As Label
    Friend WithEvents lblTies As Label
    Friend WithEvents lblComputerChoice As Label
    Friend WithEvents ResetScoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
