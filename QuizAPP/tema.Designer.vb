<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tema
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tema))
        Me.pb_voltar = New System.Windows.Forms.PictureBox()
        Me.lbl_utilizador = New System.Windows.Forms.Label()
        Me.lb_erradas = New System.Windows.Forms.Label()
        Me.lb_certas = New System.Windows.Forms.Label()
        Me.txt_tema = New System.Windows.Forms.Label()
        Me.pb_perguntas = New System.Windows.Forms.PictureBox()
        Me.bt_1 = New System.Windows.Forms.Button()
        Me.bt_2 = New System.Windows.Forms.Button()
        Me.bt_3 = New System.Windows.Forms.Button()
        Me.bt_4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_contador = New System.Windows.Forms.Label()
        Me.progress_1 = New System.Windows.Forms.ProgressBar()
        CType(Me.pb_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_perguntas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_voltar
        '
        Me.pb_voltar.BackColor = System.Drawing.Color.Transparent
        Me.pb_voltar.Image = CType(resources.GetObject("pb_voltar.Image"), System.Drawing.Image)
        Me.pb_voltar.Location = New System.Drawing.Point(1, -4)
        Me.pb_voltar.Name = "pb_voltar"
        Me.pb_voltar.Size = New System.Drawing.Size(76, 85)
        Me.pb_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_voltar.TabIndex = 0
        Me.pb_voltar.TabStop = False
        '
        'lbl_utilizador
        '
        Me.lbl_utilizador.AutoSize = True
        Me.lbl_utilizador.BackColor = System.Drawing.Color.Transparent
        Me.lbl_utilizador.Font = New System.Drawing.Font("MADE TOMMY", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_utilizador.ForeColor = System.Drawing.Color.White
        Me.lbl_utilizador.Location = New System.Drawing.Point(193, 8)
        Me.lbl_utilizador.MaximumSize = New System.Drawing.Size(150, 0)
        Me.lbl_utilizador.Name = "lbl_utilizador"
        Me.lbl_utilizador.Size = New System.Drawing.Size(79, 19)
        Me.lbl_utilizador.TabIndex = 1
        Me.lbl_utilizador.Text = "EXEMPLO"
        Me.lbl_utilizador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_erradas
        '
        Me.lb_erradas.AutoSize = True
        Me.lb_erradas.BackColor = System.Drawing.Color.Transparent
        Me.lb_erradas.Font = New System.Drawing.Font("MADE TOMMY", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_erradas.ForeColor = System.Drawing.Color.White
        Me.lb_erradas.Location = New System.Drawing.Point(749, 31)
        Me.lb_erradas.MaximumSize = New System.Drawing.Size(150, 0)
        Me.lb_erradas.Name = "lb_erradas"
        Me.lb_erradas.Size = New System.Drawing.Size(14, 17)
        Me.lb_erradas.TabIndex = 8
        Me.lb_erradas.Text = "1"
        Me.lb_erradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_certas
        '
        Me.lb_certas.AutoSize = True
        Me.lb_certas.BackColor = System.Drawing.Color.Transparent
        Me.lb_certas.Font = New System.Drawing.Font("MADE TOMMY", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_certas.ForeColor = System.Drawing.Color.White
        Me.lb_certas.Location = New System.Drawing.Point(749, 10)
        Me.lb_certas.MaximumSize = New System.Drawing.Size(150, 0)
        Me.lb_certas.Name = "lb_certas"
        Me.lb_certas.Size = New System.Drawing.Size(14, 17)
        Me.lb_certas.TabIndex = 9
        Me.lb_certas.Text = "1"
        Me.lb_certas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_tema
        '
        Me.txt_tema.AutoSize = True
        Me.txt_tema.BackColor = System.Drawing.Color.Transparent
        Me.txt_tema.Font = New System.Drawing.Font("MADE TOMMY", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_tema.ForeColor = System.Drawing.Color.White
        Me.txt_tema.Location = New System.Drawing.Point(194, 34)
        Me.txt_tema.MaximumSize = New System.Drawing.Size(150, 0)
        Me.txt_tema.Name = "txt_tema"
        Me.txt_tema.Size = New System.Drawing.Size(79, 19)
        Me.txt_tema.TabIndex = 10
        Me.txt_tema.Text = "EXEMPLO"
        Me.txt_tema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_perguntas
        '
        Me.pb_perguntas.BackColor = System.Drawing.Color.Transparent
        Me.pb_perguntas.Image = Global.QuizAPP.My.Resources.Resources.outsystems
        Me.pb_perguntas.Location = New System.Drawing.Point(257, 74)
        Me.pb_perguntas.Name = "pb_perguntas"
        Me.pb_perguntas.Size = New System.Drawing.Size(286, 179)
        Me.pb_perguntas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_perguntas.TabIndex = 11
        Me.pb_perguntas.TabStop = False
        '
        'bt_1
        '
        Me.bt_1.BackColor = System.Drawing.Color.Teal
        Me.bt_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_1.Font = New System.Drawing.Font("MADE TOMMY", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bt_1.ForeColor = System.Drawing.Color.White
        Me.bt_1.Location = New System.Drawing.Point(244, 269)
        Me.bt_1.Name = "bt_1"
        Me.bt_1.Size = New System.Drawing.Size(143, 37)
        Me.bt_1.TabIndex = 12
        Me.bt_1.Text = "ARDUINO"
        Me.bt_1.UseVisualStyleBackColor = False
        '
        'bt_2
        '
        Me.bt_2.BackColor = System.Drawing.Color.Teal
        Me.bt_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_2.Font = New System.Drawing.Font("MADE TOMMY", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bt_2.ForeColor = System.Drawing.Color.White
        Me.bt_2.Location = New System.Drawing.Point(414, 269)
        Me.bt_2.Name = "bt_2"
        Me.bt_2.Size = New System.Drawing.Size(143, 37)
        Me.bt_2.TabIndex = 13
        Me.bt_2.Text = "ARDUINO"
        Me.bt_2.UseVisualStyleBackColor = False
        '
        'bt_3
        '
        Me.bt_3.BackColor = System.Drawing.Color.Teal
        Me.bt_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_3.Font = New System.Drawing.Font("MADE TOMMY", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bt_3.ForeColor = System.Drawing.Color.White
        Me.bt_3.Location = New System.Drawing.Point(243, 331)
        Me.bt_3.Name = "bt_3"
        Me.bt_3.Size = New System.Drawing.Size(143, 37)
        Me.bt_3.TabIndex = 14
        Me.bt_3.Text = "ARDUINO"
        Me.bt_3.UseVisualStyleBackColor = False
        '
        'bt_4
        '
        Me.bt_4.BackColor = System.Drawing.Color.Teal
        Me.bt_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_4.Font = New System.Drawing.Font("MADE TOMMY", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bt_4.ForeColor = System.Drawing.Color.White
        Me.bt_4.Location = New System.Drawing.Point(414, 331)
        Me.bt_4.Name = "bt_4"
        Me.bt_4.Size = New System.Drawing.Size(143, 37)
        Me.bt_4.TabIndex = 15
        Me.bt_4.Text = "ARDUINO"
        Me.bt_4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(365, 381)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'lbl_contador
        '
        Me.lbl_contador.AutoSize = True
        Me.lbl_contador.BackColor = System.Drawing.Color.White
        Me.lbl_contador.Font = New System.Drawing.Font("MADE TOMMY", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_contador.ForeColor = System.Drawing.Color.Black
        Me.lbl_contador.Location = New System.Drawing.Point(387, 410)
        Me.lbl_contador.MaximumSize = New System.Drawing.Size(150, 0)
        Me.lbl_contador.Name = "lbl_contador"
        Me.lbl_contador.Size = New System.Drawing.Size(20, 15)
        Me.lbl_contador.TabIndex = 17
        Me.lbl_contador.Text = "01"
        Me.lbl_contador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'progress_1
        '
        Me.progress_1.BackColor = System.Drawing.Color.BlueViolet
        Me.progress_1.ForeColor = System.Drawing.Color.IndianRed
        Me.progress_1.Location = New System.Drawing.Point(-2, 444)
        Me.progress_1.Maximum = 90000
        Me.progress_1.Name = "progress_1"
        Me.progress_1.Size = New System.Drawing.Size(805, 10)
        Me.progress_1.Step = 10000
        Me.progress_1.TabIndex = 18
        '
        'tema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizAPP.My.Resources.Resources.fundo_tema
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.progress_1)
        Me.Controls.Add(Me.lbl_contador)
        Me.Controls.Add(Me.bt_4)
        Me.Controls.Add(Me.bt_3)
        Me.Controls.Add(Me.bt_2)
        Me.Controls.Add(Me.bt_1)
        Me.Controls.Add(Me.pb_perguntas)
        Me.Controls.Add(Me.txt_tema)
        Me.Controls.Add(Me.lb_certas)
        Me.Controls.Add(Me.lb_erradas)
        Me.Controls.Add(Me.lbl_utilizador)
        Me.Controls.Add(Me.pb_voltar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.pb_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_perguntas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_voltar As PictureBox
    Friend WithEvents lbl_utilizador As Label
    Friend WithEvents lb_erradas As Label
    Friend WithEvents lb_certas As Label
    Friend WithEvents txt_tema As Label
    Friend WithEvents pb_perguntas As PictureBox
    Friend WithEvents bt_1 As Button
    Friend WithEvents bt_2 As Button
    Friend WithEvents bt_3 As Button
    Friend WithEvents bt_4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_contador As Label
    Friend WithEvents progress_1 As ProgressBar
End Class
