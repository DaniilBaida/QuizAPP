<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class final
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(final))
        Me.pb_restart = New System.Windows.Forms.PictureBox()
        Me.lb_certas = New System.Windows.Forms.Label()
        Me.lb_erradas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pb_restart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_restart
        '
        Me.pb_restart.BackColor = System.Drawing.Color.Transparent
        Me.pb_restart.Image = CType(resources.GetObject("pb_restart.Image"), System.Drawing.Image)
        Me.pb_restart.Location = New System.Drawing.Point(379, 338)
        Me.pb_restart.Name = "pb_restart"
        Me.pb_restart.Size = New System.Drawing.Size(42, 69)
        Me.pb_restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_restart.TabIndex = 7
        Me.pb_restart.TabStop = False
        '
        'lb_certas
        '
        Me.lb_certas.AutoSize = True
        Me.lb_certas.BackColor = System.Drawing.Color.Transparent
        Me.lb_certas.Font = New System.Drawing.Font("MADE TOMMY", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_certas.ForeColor = System.Drawing.Color.White
        Me.lb_certas.Location = New System.Drawing.Point(378, 183)
        Me.lb_certas.MaximumSize = New System.Drawing.Size(150, 0)
        Me.lb_certas.Name = "lb_certas"
        Me.lb_certas.Size = New System.Drawing.Size(44, 33)
        Me.lb_certas.TabIndex = 10
        Me.lb_certas.Text = "10"
        Me.lb_certas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_erradas
        '
        Me.lb_erradas.AutoSize = True
        Me.lb_erradas.BackColor = System.Drawing.Color.Transparent
        Me.lb_erradas.Font = New System.Drawing.Font("MADE TOMMY", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_erradas.ForeColor = System.Drawing.Color.White
        Me.lb_erradas.Location = New System.Drawing.Point(378, 285)
        Me.lb_erradas.MaximumSize = New System.Drawing.Size(150, 0)
        Me.lb_erradas.Name = "lb_erradas"
        Me.lb_erradas.Size = New System.Drawing.Size(44, 33)
        Me.lb_erradas.TabIndex = 11
        Me.lb_erradas.Text = "10"
        Me.lb_erradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.QuizAPP.My.Resources.Resources._exit
        Me.PictureBox1.Location = New System.Drawing.Point(731, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'final
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.QuizAPP.My.Resources.Resources.final
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lb_erradas)
        Me.Controls.Add(Me.lb_certas)
        Me.Controls.Add(Me.pb_restart)
        Me.ForeColor = System.Drawing.Color.CadetBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "final"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "final"
        CType(Me.pb_restart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_restart As PictureBox
    Friend WithEvents lb_certas As Label
    Friend WithEvents lb_erradas As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
