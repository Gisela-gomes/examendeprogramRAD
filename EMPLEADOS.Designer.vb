<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLEADOS
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
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNEDITAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTTEL = New System.Windows.Forms.TextBox()
        Me.TXTDIRECCION = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CBSUCURSAL = New System.Windows.Forms.ComboBox()
        Me.TXTNIVEL = New System.Windows.Forms.TextBox()
        Me.TXTIDSUCURSAL = New System.Windows.Forms.TextBox()
        Me.TXTBUSCAR = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNELIMINAR.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNELIMINAR.Location = New System.Drawing.Point(401, 419)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(100, 35)
        Me.BTNELIMINAR.TabIndex = 21
        Me.BTNELIMINAR.Text = "Eliminar"
        Me.BTNELIMINAR.UseVisualStyleBackColor = False
        '
        'BTNEDITAR
        '
        Me.BTNEDITAR.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNEDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEDITAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNEDITAR.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNEDITAR.Location = New System.Drawing.Point(299, 419)
        Me.BTNEDITAR.Name = "BTNEDITAR"
        Me.BTNEDITAR.Size = New System.Drawing.Size(100, 35)
        Me.BTNEDITAR.TabIndex = 20
        Me.BTNEDITAR.Text = "Editar"
        Me.BTNEDITAR.UseVisualStyleBackColor = False
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNGUARDAR.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNGUARDAR.Location = New System.Drawing.Point(198, 419)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(100, 35)
        Me.BTNGUARDAR.TabIndex = 19
        Me.BTNGUARDAR.Text = "Guardar"
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 194)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(722, 219)
        Me.DataGridView1.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOMBRE"
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
        'Column5
        '
        Me.Column5.HeaderText = "FECHA"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "SUCURSAL"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "NIVEL ACCESO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(761, 35)
        Me.Panel1.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(279, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Registro de Empleados"
        '
        'TXTTEL
        '
        Me.TXTTEL.Location = New System.Drawing.Point(391, 91)
        Me.TXTTEL.Name = "TXTTEL"
        Me.TXTTEL.Size = New System.Drawing.Size(154, 25)
        Me.TXTTEL.TabIndex = 16
        '
        'TXTDIRECCION
        '
        Me.TXTDIRECCION.Location = New System.Drawing.Point(78, 128)
        Me.TXTDIRECCION.Name = "TXTDIRECCION"
        Me.TXTDIRECCION.Size = New System.Drawing.Size(470, 25)
        Me.TXTDIRECCION.TabIndex = 15
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(78, 94)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(242, 25)
        Me.TXTNOMBRE.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(9, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(323, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Telefono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(10, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(548, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Fecha Ingreso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label6.Location = New System.Drawing.Point(9, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Sucursal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label7.Location = New System.Drawing.Point(453, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label8.Location = New System.Drawing.Point(550, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Nivel Acceso"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(647, 89)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 25)
        Me.DateTimePicker1.TabIndex = 26
        '
        'CBSUCURSAL
        '
        Me.CBSUCURSAL.FormattingEnabled = True
        Me.CBSUCURSAL.Location = New System.Drawing.Point(78, 163)
        Me.CBSUCURSAL.Name = "CBSUCURSAL"
        Me.CBSUCURSAL.Size = New System.Drawing.Size(369, 25)
        Me.CBSUCURSAL.TabIndex = 27
        '
        'TXTNIVEL
        '
        Me.TXTNIVEL.Location = New System.Drawing.Point(647, 129)
        Me.TXTNIVEL.Name = "TXTNIVEL"
        Me.TXTNIVEL.Size = New System.Drawing.Size(102, 25)
        Me.TXTNIVEL.TabIndex = 28
        '
        'TXTIDSUCURSAL
        '
        Me.TXTIDSUCURSAL.Location = New System.Drawing.Point(481, 163)
        Me.TXTIDSUCURSAL.Name = "TXTIDSUCURSAL"
        Me.TXTIDSUCURSAL.Size = New System.Drawing.Size(67, 25)
        Me.TXTIDSUCURSAL.TabIndex = 29
        '
        'TXTBUSCAR
        '
        Me.TXTBUSCAR.Location = New System.Drawing.Point(61, 49)
        Me.TXTBUSCAR.Name = "TXTBUSCAR"
        Me.TXTBUSCAR.Size = New System.Drawing.Size(317, 25)
        Me.TXTBUSCAR.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(10, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Buscar"
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNBUSCAR.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNBUSCAR.Location = New System.Drawing.Point(384, 43)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(100, 35)
        Me.BTNBUSCAR.TabIndex = 32
        Me.BTNBUSCAR.Text = "Buscar"
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'EMPLEADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 466)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTBUSCAR)
        Me.Controls.Add(Me.TXTIDSUCURSAL)
        Me.Controls.Add(Me.TXTNIVEL)
        Me.Controls.Add(Me.CBSUCURSAL)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.BTNEDITAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TXTTEL)
        Me.Controls.Add(Me.TXTDIRECCION)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.OrangeRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EMPLEADOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNELIMINAR As Button
    Friend WithEvents BTNEDITAR As Button
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTTEL As TextBox
    Friend WithEvents TXTDIRECCION As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CBSUCURSAL As ComboBox
    Friend WithEvents TXTNIVEL As TextBox
    Friend WithEvents TXTIDSUCURSAL As TextBox
    Friend WithEvents TXTBUSCAR As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BTNBUSCAR As Button
End Class
