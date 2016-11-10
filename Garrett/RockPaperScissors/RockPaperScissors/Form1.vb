'Garrett Manley
'10-25-16
'Rock Paper Scissors

Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Enum Choice
        rock
        paper
        scissors
    End Enum

    Dim wins As Integer = 0
    Dim losses As Integer = 0
    Dim ties As Integer = 0

    Dim yourChoice As Integer
    Dim opponentChoice As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Select Case yourChoice
            Case radRock.Checked
                yourChoice = Choice.rock
            Case radPaper.Checked
                yourChoice = Choice.paper
            Case radScissors.Checked
                yourChoice = Choice.scissors

        End Select
        'opponent stuff

        Randomize()
        opponentChoice = Math.Floor(Rnd() * 3)

        ' choice detectors

        If yourChoice = opponentChoice Then
            ties += 1
        ElseIf yourChoice = Choice.rock And opponentChoice = Choice.paper Then
            losses += 1
        ElseIf yourChoice = Choice.rock And opponentChoice = Choice.scissors Then
            wins += 1
        ElseIf yourChoice = Choice.paper And opponentChoice = Choice.rock Then
            wins += 1
        ElseIf yourChoice = Choice.paper And opponentChoice = Choice.scissors Then
            losses += 1
        ElseIf yourChoice = Choice.scissors And opponentChoice = Choice.paper Then
            wins += 1
        ElseIf yourChoice = Choice.scissors And opponentChoice = Choice.rock Then
            losses += 1

        End If

        lblOpponentScore.Text = "Opponent's Score:" + Str(losses)
        lblPlayerScore.Text = "Your Score:" + Str(wins)
        lblTies.Text = "Ties:" + Str(ties)

    End Sub
End Class
