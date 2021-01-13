Public Class Login
    Public idUsuario As Integer
    Public miUsuario As Integer

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_usuario FROM Usuarios " &
                 "WHERE nombre= '" & TextBoxUsuario.Text &
                 "' AND contrasena= '" & TextBoxContraseña.Text & "'"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_usuario")) Then
                idUsuario = ""
            Else
                idUsuario = CStr(xDT.Rows(0)("id_usuario"))
                miUsuario = idUsuario
                MessageBox.Show("Usuario Aceptado, bienvenido.")
                Tec.Show()
            End If
        Else
            MessageBox.Show("Usuario Rechazado, pruebe con otro usuario")
        End If

    End Sub


    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarLogin.ShowDialog()
    End Sub
End Class