Public Class data
    Dim respostasProg() As String = {"RASPBERRY PI", "ARDUINO", "PYTHON", "GONÇALO FERREIRA", "JAVASCRIPT", "VSCODE", "C++", "C", "COBOL", "OUT SYSTEMS"}
    Dim respostasCult() As String = {"RASPBERRY PI", "ARDUINO", "PYTHON", "GONÇALO FERREIRA", "JAVASCRIPT", "VSCODE", "C++", "C", "COBOL", "OUT SYSTEMS"}
    Dim respostasBand() As String = {"RASPBERRY PI", "ARDUINO", "PYTHON", "GONÇALO FERREIRA", "JAVASCRIPT", "VSCODE", "C++", "C", "COBOL", "OUT SYSTEMS"}


    Public Sub checkAnswer(counter As Integer, answer As String)
        If counter < 10 Then


            Select Case menu.cb_tema.SelectedItem.ToString
                Case "Programação"
                    If respostasProg(counter) = answer Then
                        tema.lb_certas.Text += 1

                    Else
                        tema.lb_erradas.Text += 1
                    End If
                Case "Cultura Geral"
                    If respostasCult(counter) = answer Then
                        tema.lb_certas.Text += 1

                    Else
                        tema.lb_erradas.Text += 1
                    End If
                Case "Bandeiras"
                    If respostasBand(counter) = answer Then
                        tema.lb_certas.Text += 1

                    Else
                        tema.lb_erradas.Text += 1
                    End If
            End Select

        End If
        tema.contador += 1
        tema.escolhaTema()
        tema.progress_1.PerformStep()
        final.lb_certas.Text = If(tema.lb_certas.Text = 10, "", "0") + tema.lb_certas.Text
        final.lb_erradas.Text = If(tema.lb_erradas.Text = 10, "", "0") + tema.lb_erradas.Text
    End Sub

End Class
