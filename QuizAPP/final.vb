Public Class final
    Private Sub final_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pb_restart_Click(sender As Object, e As EventArgs) Handles pb_restart.Click
        Me.Hide()
        menu.restart()
        menu.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
End Class