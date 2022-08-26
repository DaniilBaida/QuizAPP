<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu))
        Me.txtbox_nome = New System.Windows.Forms.TextBox()
        Me.cb_tema = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtbox_erro = New System.Windows.Forms.TextBox()
        Me.pb_erro = New System.Windows.Forms.PictureBox()
        Me.pb_restart = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_erro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_restart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbox_nome
        '
        Me.txtbox_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_nome.Font = New System.Drawing.Font("MADE TOMMY", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbox_nome.Location = New System.Drawing.Point(342, 227)
        Me.txtbox_nome.Name = "txtbox_nome"
        Me.txtbox_nome.PlaceholderText = "Insira o seu nome"
        Me.txtbox_nome.Size = New System.Drawing.Size(112, 17)
        Me.txtbox_nome.TabIndex = 0
        Me.txtbox_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_tema
        '
        Me.cb_tema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_tema.Font = New System.Drawing.Font("MADE TOMMY", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cb_tema.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cb_tema.FormattingEnabled = True
        Me.cb_tema.Items.AddRange(New Object() {"Programação", "Cultura Geral"})
        Me.cb_tema.Location = New System.Drawing.Point(334, 284)
        Me.cb_tema.Name = "cb_tema"
        Me.cb_tema.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cb_tema.Size = New System.Drawing.Size(132, 24)
        Me.cb_tema.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.QuizAPP.My.Resources.Resources._exit
        Me.PictureBox1.Location = New System.Drawing.Point(724, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(364, 335)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'txtbox_erro
        '
        Me.txtbox_erro.BackColor = System.Drawing.Color.Red
        Me.txtbox_erro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbox_erro.Font = New System.Drawing.Font("MADE TOMMY", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbox_erro.ForeColor = System.Drawing.Color.White
        Me.txtbox_erro.Location = New System.Drawing.Point(274, 254)
        Me.txtbox_erro.Name = "txtbox_erro"
        Me.txtbox_erro.Size = New System.Drawing.Size(253, 24)
        Me.txtbox_erro.TabIndex = 4
        Me.txtbox_erro.Text = "Insira um nome inferior a 11 caracteres"
        Me.txtbox_erro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbox_erro.Visible = False
        '
        'pb_erro
        '
        Me.pb_erro.BackColor = System.Drawing.Color.Transparent
        Me.pb_erro.Image = Global.QuizAPP.My.Resources.Resources._error
        Me.pb_erro.Location = New System.Drawing.Point(353, 335)
        Me.pb_erro.Name = "pb_erro"
        Me.pb_erro.Size = New System.Drawing.Size(94, 79)
        Me.pb_erro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pb_erro.TabIndex = 5
        Me.pb_erro.TabStop = False
        Me.pb_erro.Visible = False
        '
        'pb_restart
        '
        Me.pb_restart.BackColor = System.Drawing.Color.Transparent
        Me.pb_restart.Image = CType(resources.GetObject("pb_restart.Image"), System.Drawing.Image)
        Me.pb_restart.Location = New System.Drawing.Point(307, 224)
        Me.pb_restart.Name = "pb_restart"
        Me.pb_restart.Size = New System.Drawing.Size(23, 24)
        Me.pb_restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_restart.TabIndex = 6
        Me.pb_restart.TabStop = False
        Me.pb_restart.Visible = False
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizAPP.My.Resources.Resources.BackgroundImage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pb_restart)
        Me.Controls.Add(Me.pb_erro)
        Me.Controls.Add(Me.txtbox_erro)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cb_tema)
        Me.Controls.Add(Me.txtbox_nome)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_erro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_restart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbox_nome As TextBox
    Friend WithEvents cb_tema As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtbox_erro As TextBox
    Friend WithEvents pb_erro As PictureBox
    Friend WithEvents pb_restart As PictureBox
End Class
