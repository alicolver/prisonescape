Public Class Form1
    Private Sub btnHow2Play_Click(sender As Object, e As EventArgs) Handles btnHow2Play.Click
        'Coding to go to instructions

        Me.Hide()   'closes this form
        My.Forms.Instructions.Show()    'shows instructions

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Forms.scoreboard.Show()  'shows scoreboard
        Me.Hide()   'closes this form

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Me.Hide()   'closes this form
        My.Forms.Start.Show()   'opens game form

    End Sub
End Class
