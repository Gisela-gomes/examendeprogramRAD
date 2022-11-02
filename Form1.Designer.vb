<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
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
        Me.TXTUSUARIO = New System.Windows.Forms.TextBox()
        Me.TXTPASS = New System.Windows.Forms.TextBox()
        Me.BTNINGRESAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTUSUARIO
        '
        Me.TXTUSUARIO.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TXTUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTUSUARIO.Location = New System.Drawing.Point(35, 147)
        Me.TXTUSUARIO.Name = "TXTUSUARIO"
        Me.TXTUSUARIO.Size = New System.Drawing.Size(240, 25)
        Me.TXTUSUARIO.TabIndex = 0
        '
        'TXTPASS
        '
        Me.TXTPASS.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TXTPASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPASS.Location = New System.Drawing.Point(35, 195)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASS.Size = New System.Drawing.Size(240, 25)
        Me.TXTPASS.TabIndex = 1
        Me.TXTPASS.UseSystemPasswordChar = True
        '
        'BTNINGRESAR
        '
        Me.BTNINGRESAR.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNINGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNINGRESAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNINGRESAR.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNINGRESAR.Location = New System.Drawing.Point(35, 244)
        Me.BTNINGRESAR.Name = "BTNINGRESAR"
        Me.BTNINGRESAR.Size = New System.Drawing.Size(240, 35)
        Me.BTNINGRESAR.TabIndex = 2
        Me.BTNINGRESAR.Text = "Ingresar"
        Me.BTNINGRESAR.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.examendeprogramRAD.My.Resources.Resources.USER
        Me.PictureBox1.Location = New System.Drawing.Point(90, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(309, 363)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNINGRESAR)
        Me.Controls.Add(Me.TXTPASS)
        Me.Controls.Add(Me.TXTUSUARIO)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTUSUARIO As TextBox
    Friend WithEvents TXTPASS As TextBox
    Friend WithEvents BTNINGRESAR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
