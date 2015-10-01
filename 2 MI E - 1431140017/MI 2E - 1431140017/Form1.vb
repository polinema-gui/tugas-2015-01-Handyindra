Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Turquoise Then
            Me.BackColor = Color.Crimson
        Else : Me.BackColor = Color.Turquoise
        End If
    End Sub
End Class
