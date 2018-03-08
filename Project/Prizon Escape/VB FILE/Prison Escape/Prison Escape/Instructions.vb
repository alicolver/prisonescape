Public Class Instructions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()  'closes this form
        My.Forms.Form1.Show()   'opens home

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()  'closes this form
        My.Forms.Start.Show()   'opens new game

    End Sub
End Class