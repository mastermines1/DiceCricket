Public Class frmDiceCricket
    Dim playerName As String
    Dim score As Integer = 0
    Dim roll As Integer
    Dim out As Boolean = False
    Dim nameInputted As Boolean = False
    Dim leaderboard = New Integer() {0, 0, 0, 0, 0}
    Dim leadernames(4) As String
    Private Sub btnAddName_click(sender As Object, e As EventArgs) Handles btnAddName.Click
        If nameInputted = False Then
            playerName = txtInsertName.Text
            lblMessages.Text = lblMessages.Text & vbCrLf & "Hello " & playerName
            nameInputted = True
        End If
    End Sub
    Private Sub btnNextGame_click(sender As Object, e As EventArgs) Handles btnNextGame.Click
        out = False
        txtRolls.Text = ""
        lblMessages.Text = "Lets play dice cricket!"
        score = 0
        nameInputted = False
    End Sub
    Private Sub btnRoll_click(sender As Object, e As EventArgs) Handles btnRoll.Click
        If out = False Then
            Randomize()
            roll = Int((6 - 1 + 1) * Rnd() + 1)
            score = score + roll
            txtRolls.Text = txtRolls.Text & roll & vbCrLf
            If roll = 5 Then
                If score = 5 Then
                    txtTotal.Text = score
                    lblMessages.Text = lblMessages.Text & vbCrLf & "You're out for a duck!"
                    out = True
                End If
                If score <> 5 Then
                    txtTotal.Text = score
                    lblMessages.Text = lblMessages.Text & vbCrLf & "You're out!" & vbCrLf & "Your final score was " & score
                    out = True
                End If

                'leaderboard code (very optomised ik)
                If score >= leaderboard(4) Then
                    leaderboard(0) = leaderboard(1)
                    leaderboard(1) = leaderboard(2)
                    leaderboard(3) = leaderboard(4)
                    leaderboard(4) = score
                    leadernames(0) = leadernames(1)
                    leadernames(1) = leadernames(2)
                    leadernames(3) = leadernames(4)
                    leadernames(4) = playerName
                ElseIf score >= leaderboard(3) Then
                    leaderboard(0) = leaderboard(1)
                    leaderboard(1) = leaderboard(2)
                    leaderboard(2) = leaderboard(3)
                    leaderboard(3) = score
                    leadernames(0) = leadernames(1)
                    leadernames(1) = leadernames(2)
                    leadernames(2) = leadernames(3)
                    leadernames(3) = playerName
                ElseIf score >= leaderboard(2) Then
                    leaderboard(0) = leaderboard(1)
                    leaderboard(1) = leaderboard(2)
                    leaderboard(2) = score
                    leadernames(0) = leadernames(1)
                    leadernames(1) = leadernames(2)
                    leadernames(2) = playerName
                ElseIf score >= leaderboard(1) Then
                    leaderboard(0) = leaderboard(1)
                    leaderboard(1) = score
                    leadernames(0) = leadernames(1)
                    leadernames(1) = playerName
                ElseIf score >= leaderboard(0) Then
                    leaderboard(0) = score
                    leadernames(0) = playerName
                End If

                lblLeaderboard.Text = "Leaderboard:" & vbCrLf & leadernames(4) & ": " & leaderboard(4) & vbCrLf & leadernames(3) & ": " & leaderboard(3) & vbCrLf & leadernames(2) & ": " & leaderboard(2) & vbCrLf & leadernames(1) & ": " & leaderboard(1) & vbCrLf & leadernames(0) & ": " & leaderboard(0)
            End If
        End If
    End Sub
End Class