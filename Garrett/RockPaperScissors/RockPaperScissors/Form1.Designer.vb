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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblOpponentScore = New System.Windows.Forms.Label()
        Me.grpPlayerChoice = New System.Windows.Forms.GroupBox()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.lblTies = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpPlayerChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(266, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Play"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.Location = New System.Drawing.Point(12, 77)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(72, 13)
        Me.lblPlayerScore.TabIndex = 3
        Me.lblPlayerScore.Text = "Your Score: 0"
        '
        'lblOpponentScore
        '
        Me.lblOpponentScore.AutoSize = True
        Me.lblOpponentScore.Location = New System.Drawing.Point(157, 77)
        Me.lblOpponentScore.Name = "lblOpponentScore"
        Me.lblOpponentScore.Size = New System.Drawing.Size(104, 13)
        Me.lblOpponentScore.TabIndex = 5
        Me.lblOpponentScore.Text = "Opponent's Score: 0"
        '
        'grpPlayerChoice
        '
        Me.grpPlayerChoice.Controls.Add(Me.radPaper)
        Me.grpPlayerChoice.Controls.Add(Me.radScissors)
        Me.grpPlayerChoice.Controls.Add(Me.radRock)
        Me.grpPlayerChoice.Location = New System.Drawing.Point(12, 27)
        Me.grpPlayerChoice.Name = "grpPlayerChoice"
        Me.grpPlayerChoice.Size = New System.Drawing.Size(242, 47)
        Me.grpPlayerChoice.TabIndex = 8
        Me.grpPlayerChoice.TabStop = False
        Me.grpPlayerChoice.Text = "Choose an Option"
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(98, 19)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(53, 17)
        Me.radPaper.TabIndex = 2
        Me.radPaper.TabStop = True
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(167, 19)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(64, 17)
        Me.radScissors.TabIndex = 1
        Me.radScissors.TabStop = True
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(32, 19)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(51, 17)
        Me.radRock.TabIndex = 0
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'lblTies
        '
        Me.lblTies.AutoSize = True
        Me.lblTies.Location = New System.Drawing.Point(107, 77)
        Me.lblTies.Name = "lblTies"
        Me.lblTies.Size = New System.Drawing.Size(39, 13)
        Me.lblTies.TabIndex = 11
        Me.lblTies.Text = "Ties: 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 164)
        Me.Controls.Add(Me.lblTies)
        Me.Controls.Add(Me.grpPlayerChoice)
        Me.Controls.Add(Me.lblOpponentScore)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpPlayerChoice.ResumeLayout(False)
        Me.grpPlayerChoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents lblPlayerScore As Label
    Friend WithEvents lblOpponentScore As Label
    Friend WithEvents grpPlayerChoice As GroupBox
    Friend WithEvents radPaper As RadioButton
    Friend WithEvents radScissors As RadioButton
    Friend WithEvents radRock As RadioButton
    Friend WithEvents lblTies As Label
End Class
