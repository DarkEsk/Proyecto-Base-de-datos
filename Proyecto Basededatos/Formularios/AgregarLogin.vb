Public Class AgregarLogin
    Private Sub AgregarLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tec As New AgregarLoginComandos(TextBoxUsuario.Text, TextBoxNombre.Text, TextBoxContraseña.Text)
        tec.PoblarDataGridUsuarios(DataGridUsuarios)

    End Sub
    Private Sub Buttonguardar_Click(sender As Object, e As EventArgs) Handles Buttonguardar.Click
        If TextBoxUsuario.Text = "" Then
            MessageBox.Show("Agregar numero positivo o no existente en la tabla !!")
        ElseIf TextBoxNombre.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxContraseña.Text = "" Then
            MessageBox.Show("Capturar contraseña !!")

        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarLoginComandos(TextBoxUsuario.Text, TextBoxNombre.Text, TextBoxContraseña.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If (tec.consultaidusuarios() And tec.consultaidalumnos() And tec.consultaidtec() And tec.consultaiddepartamentos()) = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.insertausuario() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("usuario Registrado ...")
            Else
                MessageBox.Show("este usuario ya esta regristado, prueba con otro...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridUsuarios(DataGridUsuarios)
        End If
    End Sub
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim tec As New AgregarLoginComandos(TextBoxUsuario.Text, TextBoxNombre.Text, TextBoxContraseña.Text)

        'Con el método validaColonias, verificamos que la ciudad que se quiere eliminar NO tenga colonias
        Dim columna As Integer
        Dim renglon As Integer
        Try
            columna = DataGridUsuarios.CurrentCellAddress.Y
            renglon = DataGridUsuarios.Rows(columna).Cells(0).Value
        Catch ex As Exception
            MessageBox.Show("No ha seleccionado un renglon")
        End Try

        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro de la ciudad
            tec.eliminausuarios()


            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            tec.PoblarDataGridUsuarios(DataGridUsuarios)
        End If


    End Sub
    Private Sub Buttonnuevo_Click(sender As Object, e As EventArgs) Handles Buttonnuevo.Click
        Dim tec As New AgregarLoginComandos(TextBoxUsuario.Text, TextBoxNombre.Text, TextBoxContraseña.Text)

        tec.limpiar()
    End Sub

    Private Sub id_carrera_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxUsuario.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Buttonactualizar_Click(sender As Object, e As EventArgs) Handles Buttonactualizar.Click
        If TextBoxUsuario.Text = "" Then
            MessageBox.Show("Agregar numero de la tabla !!")
        ElseIf TextBoxNombre.Text = "" Then
            MessageBox.Show("Capturar un nombre !!")
        ElseIf TextBoxContraseña.Text = "" Then
            MessageBox.Show("Capturar contraseña para el usuario !!")

        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarLoginComandos(TextBoxUsuario.Text, TextBoxNombre.Text, TextBoxContraseña.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If tec.consultaidusuarios() = True Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.actualizar() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("usuario cambiado ...")
            Else
                MessageBox.Show("este usuario no existe, cheque la tabla...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridUsuarios(DataGridUsuarios)
        End If
    End Sub
    Private Sub DataGridEntrenadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUsuarios.CellContentClick
        Dim tec As New AgregarLoginComandos(TextBoxUsuario.Text, TextBoxNombre.Text, TextBoxContraseña.Text)

        tec.ponerencuadros()
    End Sub
End Class