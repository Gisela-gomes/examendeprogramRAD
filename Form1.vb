Imports System.Data.SqlClient
Public Class LOGIN
    Private Sub BTNINGRESAR_Click(sender As Object, e As EventArgs) Handles BTNINGRESAR.Click
        Dim CON As New SqlClient.SqlConnection(My.Settings.CONEXION)
        CON.Open()

        Dim READER As SqlClient.SqlDataReader
        Dim CMD As New SqlClient.SqlCommand("SELECT * FROM USUARIOS where USUARIO ='" & TXTUSUARIO.Text & "' AND CLAVE = '" & TXTPASS.Text & "'", CON)
        READER = CMD.ExecuteReader

        If READER.Read Then
            If READER.Item("ACTIVO") = True Then
                VARIABLESPUBLICAS.IDUSUARIO = READER.Item("USUARIO")
                VARIABLESPUBLICAS.NIVELACCESO = READER.Item("NIVELACCESO")
                VARIABLESPUBLICAS.NOMBRUSUARIO = READER.Item("NOMBRE")

                MENU.ShowDialog()
                Me.Dispose()

            Else
                MessageBox.Show("USUARIO INACTIVO")
            End If

        Else
            MessageBox.Show("USUARIO INCORRECTO")

        End If

    End Sub
End Class
