'Oliver Dalmi
'10/12/16
'Rock Paper Scissors
Public Class Form1
    Enum Choice
        Rock
        Paper
        Scissors
    End Enum
    Enum Result
        Loss
        Tie
        Win
    End Enum

    Dim wins As Integer = 0
    Dim losses As Integer = 0
    Dim ties As Integer = 0
    Dim computerChoice As Integer
    Dim printComputerChoice As New Dictionary(Of Integer, String)

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        If (radPaper.Checked = True) Or (radRock.Checked = True) Or (radScissors.Checked = True) Then
            Dim playerChoice As Integer
            If radPaper.Checked = True Then
                playerChoice = Choice.Paper
            ElseIf radRock.Checked = True Then
                playerChoice = Choice.Rock
            Else
                playerChoice = Choice.Scissors
            End If

            processResult(findWinner(playerChoice))

            lblComputerChoice.Text = "The computer chose " & printComputerChoice.Item(computerChoice)
        End If
    End Sub

    Private Sub ResetScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetScoreToolStripMenuItem.Click
        wins = 0
        losses = 0
        ties = 0
        lblWins.Text = "Wins: 0"
        lblTies.Text = "Ties: 0"
        lblLosses.Text = "Losses: 0"
        ToolTip1.SetToolTip(lblWins, "You have won 0 times.")
        ToolTip1.SetToolTip(lblTies, "There have been 0 ties.")
        ToolTip1.SetToolTip(lblLosses, "You have lost 0 times.")
        lblComputerChoice.Text = "Result"
        radPaper.Checked = False
        radRock.Checked = False
        radScissors.Checked = False
    End Sub

    Private Function findWinner(playerChoice As Integer)
        Randomize()
        computerChoice = Math.Floor(3 * Rnd())

        If computerChoice = playerChoice Then
            Return Result.Tie
        ElseIf playerChoice = Choice.Paper Then
            If computerChoice = Choice.Rock Then
                Return Result.Win
            Else
                Return Result.Loss
            End If
        ElseIf playerChoice = Choice.Rock Then
            If computerChoice = Choice.Scissors Then
                Return Result.Win
            Else
                Return Result.Loss
            End If
        Else
            If computerChoice = Choice.Paper Then
                Return Result.Win
            Else
                Return Result.Loss
            End If
        End If
    End Function

    Private Sub processResult(playerResult As Integer)
        Select Case playerResult
            Case Result.Loss
                losses += 1
                lblLosses.Text = "Losses: " + Str(losses)
                ToolTip1.SetToolTip(lblLosses, "You have lost" & Str(losses) & " times.")
            Case Result.Tie
                ties += 1
                lblTies.Text = "Ties: " + Str(ties)
                ToolTip1.SetToolTip(lblTies, "There have been" & Str(ties) & " ties.")
            Case Result.Win
                wins += 1
                lblWins.Text = "Wins: " + Str(wins)
                ToolTip1.SetToolTip(lblWins, "You have won" & Str(wins) & " times.")
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        printComputerChoice.Add(0, "rock.")
        printComputerChoice.Add(1, "paper.")
        printComputerChoice.Add(2, "scissors.")
    End Sub
End Class