Public Class menu

    Dim utilizador As String

    Public Sub restart()
        pb_restart.Visible = False
        txtbox_nome.Text = ""
        txtbox_nome.Enabled = True
        tema.contador = 0
        tema.temaProgramacao()
        tema.progress_1.Value = 0
    End Sub


    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = cb_tema
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbox_nome.TextChanged
        If (txtbox_nome.TextLength > 14) Then
            txtbox_erro.Visible = True
            pb_erro.Visible = True
            cb_tema.Enabled = False


        Else
            txtbox_erro.Visible = False
            utilizador = txtbox_nome.Text
            pb_erro.Visible = False
            cb_tema.Enabled = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (txtbox_nome.Text <> "") Then
            Me.Hide()
            tema.Show()
            txtbox_nome.Enabled = False
        End If
        tema.lbl_utilizador.Text = txtbox_nome.Text
        tema.lb_certas.Text = 0
        tema.lb_erradas.Text = 0
        tema.txt_tema.Text = cb_tema.SelectedItem

    End Sub

    Private Sub pb_erro_Click(sender As Object, e As EventArgs) Handles pb_erro.Click
        txtbox_nome.Text = ""


    End Sub

    Private Sub pb_restart_Click(sender As Object, e As EventArgs) Handles pb_restart.Click
        restart()


    End Sub
End Class
