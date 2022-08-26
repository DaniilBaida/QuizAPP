Public Class tema
    Public contador As Integer = 0
    Dim picture As Resources.ResourceManager
    Dim data As New data


    Public Sub temaProgramacao()


        Select Case contador
            Case 0

                pb_perguntas.Image = picture.GetObject("raspberry")
                bt_1.Text = "RASPBERRY PI"
                bt_2.Text = "IPHONE"
                bt_3.Text = "CLASSE CARRO"
                bt_4.Text = "BOA TARDE"


            Case 1

                pb_perguntas.Image = picture.GetObject("randuino")
                bt_1.Text = "ATEC"
                bt_2.Text = "CARNE"
                bt_3.Text = "ARDUINO"
                bt_4.Text = "DOROTEIA"
            Case 2

                pb_perguntas.Image = picture.GetObject("python")
                bt_1.Text = "C--"
                bt_2.Text = "PYTHON"
                bt_3.Text = "JAVA"
                bt_4.Text = "COBOL"


            Case 3

                pb_perguntas.Image = picture.GetObject("matrix")
                bt_1.Text = "HACKER"
                bt_2.Text = "MATRIX"
                bt_3.Text = "GONÇALO"
                bt_4.Text = "NUMEROS"
            Case 4

                pb_perguntas.Image = picture.GetObject("javascript")
                bt_1.Text = "FORTNITE"
                bt_2.Text = "NINTENTO"
                bt_3.Text = "JAVARDÃO"
                bt_4.Text = "JAVASCRIPT"


            Case 5

                pb_perguntas.Image = picture.GetObject("vscode")
                bt_1.Text = "VSCODE"
                bt_2.Text = "THONNY"
                bt_3.Text = "IDLE"
                bt_4.Text = "DEV BLOCKS"
            Case 6

                pb_perguntas.Image = picture.GetObject("c++")
                bt_1.Text = "C--"
                bt_2.Text = "C#"
                bt_3.Text = "C"
                bt_4.Text = "C++"


            Case 7

                pb_perguntas.Image = picture.GetObject("c")
                bt_1.Text = "VBA.NET.PT"
                bt_2.Text = "C"
                bt_3.Text = "JAVA"
                bt_4.Text = "C#"
            Case 8

                pb_perguntas.Image = picture.GetObject("cobol")
                bt_1.Text = "COBOL"
                bt_2.Text = "NOKIA"
                bt_3.Text = "PYTHON"
                bt_4.Text = "C**"


            Case 9

                pb_perguntas.Image = picture.GetObject("outsystems")
                bt_1.Text = "ROGER"
                bt_2.Text = "ARRASTAR"
                bt_3.Text = "ARDUINO"
                bt_4.Text = "OUT SYSTEMS"
            Case 10
                Me.Hide()
                final.Show()


        End Select
        lbl_contador.Text = If(contador = 9, "", "0") & contador + 1
    End Sub

    Public Sub temaCultura()


        Select Case contador
            Case 0


                pb_perguntas.Image = picture.GetObject("cult_1")
                bt_1.Text = "SAN MARINO"
                bt_2.Text = "VATICANO"
                bt_3.Text = "MALDIVAS"
                bt_4.Text = "PORTUGAL"


            Case 1

                pb_perguntas.Image = picture.GetObject("cult_2")
                bt_1.Text = "ZURIQUE"
                bt_2.Text = "GENEBRA"
                bt_3.Text = "BERNA"
                bt_4.Text = "PERNA"
            Case 2

                pb_perguntas.Image = picture.GetObject("cult_3")
                bt_1.Text = "200"
                bt_2.Text = "206"
                bt_3.Text = "212"
                bt_4.Text = "192"


            Case 3

                pb_perguntas.Image = picture.GetObject("cult_4")
                bt_1.Text = "ALEMÃO"
                bt_2.Text = "INGLÊS"
                bt_3.Text = "ESPANHOL"
                bt_4.Text = "CHINÊS"
            Case 4

                pb_perguntas.Image = picture.GetObject("cult_5")
                bt_1.Text = "JAPÃO"
                bt_2.Text = "CHINA"
                bt_3.Text = "PAQUISTÃO"
                bt_4.Text = "AFRICA"


            Case 5

                pb_perguntas.Image = picture.GetObject("cult_6")
                bt_1.Text = "ATENAS"
                bt_2.Text = "ROMA"
                bt_3.Text = "BICA"
                bt_4.Text = "NICCA"
            Case 6

                pb_perguntas.Image = picture.GetObject("cult_7")
                bt_1.Text = "BRASIL"
                bt_2.Text = "ESTADOS UNIDOS"
                bt_3.Text = "IRÃ"
                bt_4.Text = "PORTUGAL"


            Case 7

                pb_perguntas.Image = picture.GetObject("cult_8")
                bt_1.Text = "POMBO"
                bt_2.Text = "ÁGUIA"
                bt_3.Text = "ANDORINHA"
                bt_4.Text = "PARDAL"
            Case 8

                pb_perguntas.Image = picture.GetObject("cult_9")
                bt_1.Text = "SIDNEY"
                bt_2.Text = "CAMBERRA"
                bt_3.Text = "MELBOURNE"
                bt_4.Text = "AUSRE"


            Case 9

                pb_perguntas.Image = picture.GetObject("cult_10")
                bt_1.Text = "SALAMANDRA"
                bt_2.Text = "TATU"
                bt_3.Text = "CAMBERRA"
                bt_4.Text = "GAIVOTA"
            Case 10
                Me.Hide()
                final.Show()


        End Select
        lbl_contador.Text = If(contador = 9, "", "0") & contador + 1
    End Sub


    Public Sub escolhaTema()

        Select Case menu.cb_tema.SelectedItem.ToString
            Case "Programação"
                temaProgramacao()
            Case "Cultura Geral"
                temaCultura()
        End Select
    End Sub

    Private Sub temaProgramacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picture = New Resources.ResourceManager("QuizAPP.Resources", System.Reflection.Assembly.GetExecutingAssembly)
        lbl_utilizador.Text = menu.txtbox_nome.Text
        lb_certas.Text = 0
        lb_erradas.Text = 0
        txt_tema.Text = menu.cb_tema.SelectedItem
        escolhaTema()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pb_voltar.Click
        Hide()
        menu.Show()
        menu.pb_restart.Visible = True
    End Sub

    Private Sub bt_1_Click(sender As Object, e As EventArgs) Handles bt_1.Click
        data.checkAnswer(contador, bt_1.Text)
    End Sub

    Private Sub bt_2_Click(sender As Object, e As EventArgs) Handles bt_2.Click
        data.checkAnswer(contador, bt_2.Text)
    End Sub

    Private Sub bt_3_Click(sender As Object, e As EventArgs) Handles bt_3.Click
        data.checkAnswer(contador, bt_3.Text)
    End Sub

    Private Sub bt_4_Click(sender As Object, e As EventArgs) Handles bt_4.Click
        data.checkAnswer(contador, bt_4.Text)
    End Sub
End Class