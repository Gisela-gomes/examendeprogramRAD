<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUCURSALES
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTSUCURSAL = New System.Windows.Forms.TextBox()
        Me.TXTDIRECCION = New System.Windows.Forms.TextBox()
        Me.TXTTEL = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNEDITAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(16, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sucursal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(329, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(11, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección"
        '
        'TXTSUCURSAL
        '
        Me.TXTSUCURSAL.Location = New System.Drawing.Point(81, 54)
        Me.TXTSUCURSAL.Name = "TXTSUCURSAL"
        Me.TXTSUCURSAL.Size = New System.Drawing.Size(242, 25)
        Me.TXTSUCURSAL.TabIndex = 3
        '
        'TXTDIRECCION
        '
        Me.TXTDIRECCION.Location = New System.Drawing.Point(81, 88)
        Me.TXTDIRECCION.Name = "TXTDIRECCION"
        Me.TXTDIRECCION.Size = New System.Drawing.Size(470, 25)
        Me.TXTDIRECCION.TabIndex = 4
        '
        'TXTTEL
        '
        Me.TXTTEL.Location = New System.Drawing.Point(397, 51)
        Me.TXTTEL.Name = "TXTTEL"
        Me.TXTTEL.Size = New System.Drawing.Size(154, 25)
        Me.TXTTEL.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 35)
        Me.Panel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(179, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Aperturar Sucursal"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(535, 219)
        Me.DataGridView1.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "SUCURSAL"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "TEL"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "DIRECCION"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNGUARDAR.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNGUARDAR.Location = New System.Drawing.Point(129, 358)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(100, 35)
        Me.BTNGUARDAR.TabIndex = 8
        Me.BTNGUARDAR.Text = "Guardar"
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'BTNEDITAR
        '
        Me.BTNEDITAR.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNEDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEDITAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNEDITAR.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNEDITAR.Location = New System.Drawing.Point(235, 358)
        Me.BTNEDITAR.Name = "BTNEDITAR"
        Me.BTNEDITAR.Size = New System.Drawing.Size(100, 35)
        Me.BTNEDITAR.TabIndex = 9
        Me.BTNEDITAR.Text = "Editar"
        Me.BTNEDITAR.UseVisualStyleBackColor = False
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNELIMINAR.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNELIMINAR.Location = New System.Drawing.Point(341, 358)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(100, 35)
        Me.BTNELIMINAR.TabIndex = 10
        Me.BTNELIMINAR.Text = "Eliminar"
        Me.BTNELIMINAR.UseVisualStyleBackColor = False
        '
        'SUCURSALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(576, 404)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.BTNEDITAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TXTTEL)
        Me.Controls.Add(Me.TXTDIRECCION)
        Me.Controls.Add(Me.TXTSUCURSAL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.OrangeRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SUCURSALES"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTSUCURSAL As TextBox
    Friend WithEvents TXTDIRECCION As TextBox
    Friend WithEvents TXTTEL As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents BTNEDITAR As Button
    Friend WithEvents BTNELIMINAR As Button
End Class
