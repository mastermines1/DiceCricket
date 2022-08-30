Public Class frmDiceCricket
    Dim playerName As String
    Dim score As Integer = 0
    Dim roll As Integer
    Dim out As Boolean = False
    Dim nameInputted As Boolean = False
    Dim leaderboard = New Integer() {0, 0, 0, 0}
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
        lblMessages.Text = ""
        score = 0
        playerName = ""
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

                'leaderboard code
                For x As Integer = 4 To 0
                    If leaderboard(x) = 0 Then
                        leaderboard(x) = score
                    ElseIf score > leaderboard(x) Then
                        leaderboard(x + 2) = leaderboard(x + 1)
                        leaderboard(x + 1) = score
                    ElseIf score < leaderboard(x) Then
                        leaderboard(x + 1) = leaderboard(x)
                        leaderboard(x) = score
                    ElseIf score <> leaderboard(x) Then
                        If leaderboard(x + 1) = 0 Then

                        End If

                    End If
                Next

                For y As Integer = 0 To 4
                    lblLeaderboard.Text = lblLeaderboard.Text & vbCrLf & leaderboard(y)
                Next
            End If
        End If
    End Sub

End Class