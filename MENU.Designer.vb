<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CATALOGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRAREMPLEADOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARSUCURSALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CATALOGOSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.OrangeRed
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CATALOGOSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(754, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CATALOGOSToolStripMenuItem
        '
        Me.CATALOGOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRAREMPLEADOSToolStripMenuItem, Me.REGISTRARSUCURSALESToolStripMenuItem, Me.CATALOGOSToolStripMenuItem1})
        Me.CATALOGOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CATALOGOSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CATALOGOSToolStripMenuItem.Name = "CATALOGOSToolStripMenuItem"
        Me.CATALOGOSToolStripMenuItem.Size = New System.Drawing.Size(95, 21)
        Me.CATALOGOSToolStripMenuItem.Text = "CATALOGOS"
        '
        'REGISTRAREMPLEADOSToolStripMenuItem
        '
        Me.REGISTRAREMPLEADOSToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed
        Me.REGISTRAREMPLEADOSToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.REGISTRAREMPLEADOSToolStripMenuItem.Name = "REGISTRAREMPLEADOSToolStripMenuItem"
        Me.REGISTRAREMPLEADOSToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.REGISTRAREMPLEADOSToolStripMenuItem.Text = "REGISTRAR EMPLEADOS"
        '
        'REGISTRARSUCURSALESToolStripMenuItem
        '
        Me.REGISTRARSUCURSALESToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed
        Me.REGISTRARSUCURSALESToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.REGISTRARSUCURSALESToolStripMenuItem.Name = "REGISTRARSUCURSALESToolStripMenuItem"
        Me.REGISTRARSUCURSALESToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.REGISTRARSUCURSALESToolStripMenuItem.Text = "REGISTRAR SUCURSALES"
        '
        'CATALOGOSToolStripMenuItem1
        '
        Me.CATALOGOSToolStripMenuItem1.BackColor = System.Drawing.Color.OrangeRed
        Me.CATALOGOSToolStripMenuItem1.ForeColor = System.Drawing.Color.Maroon
        Me.CATALOGOSToolStripMenuItem1.Name = "CATALOGOSToolStripMenuItem1"
        Me.CATALOGOSToolStripMenuItem1.Size = New System.Drawing.Size(226, 22)
        Me.CATALOGOSToolStripMenuItem1.Text = "SALIR"
        '
        'MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(754, 527)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CATALOGOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRAREMPLEADOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRARSUCURSALESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CATALOGOSToolStripMenuItem1 As ToolStripMenuItem
End Class
