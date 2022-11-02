Public Class MENU
    Private Sub REGISTRAREMPLEADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRAREMPLEADOSToolStripMenuItem.Click
        EMPLEADOS.ShowDialog()

    End Sub

    Private Sub REGISTRARSUCURSALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARSUCURSALESToolStripMenuItem.Click
        SUCURSALES.ShowDialog()

    End Sub

    Private Sub CATALOGOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CATALOGOSToolStripMenuItem1.Click
        Application.Exit()

    End Sub
End Class