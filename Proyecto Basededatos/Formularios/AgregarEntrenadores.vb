Public Class AgregarEntrenadores
    Private Sub AgregarEntrenadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tec As New AgregarEntrenadoresComandos(TextBoxEntrenador.Text, TextBoxIdGenero.Text, TextBoxDepartamento.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)
        tec.PoblarDataGridEntrenadores(DataGridEntrenadores)
        tec.PoblarDataGridGeneros(DataGridGeneros)
        tec.PoblarDataGridDepartamentos(DataGridDepartamentos)
    End Sub
    Private Sub Buttonguardar_Click(sender As Object, e As EventArgs) Handles Buttonguardar.Click
        If TextBoxEntrenador.Text = "" Then
            MessageBox.Show("Agregar numero positivo o no existente en la tabla !!")
        ElseIf TextBoxIdGenero.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxDepartamento.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxNombre.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxPaterno.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxMaterno.Text = "" Then
            MessageBox.Show("Capturar nombre !!")

        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarEntrenadoresComandos(TextBoxEntrenador.Text, TextBoxIdGenero.Text, TextBoxDepartamento.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If (tec.consultaidcarrera() And tec.consultaidalumnos() And tec.consultaidtec() And tec.consultaiddepartamentos() And tec.consultaidentrenadores()) = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.insertaentrenador() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("entrenador Registrado ...")
            Else
                MessageBox.Show("este entrenador ya esta regristado, prueba con otro...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridEntrenadores(DataGridEntrenadores)
        End If
    End Sub
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim tec As New AgregarEntrenadoresComandos(TextBoxEntrenador.Text, TextBoxIdGenero.Text, TextBoxDepartamento.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)

        'Con el método validaColonias, verificamos que la ciudad que se quiere eliminar NO tenga colonias
        Dim columna As Integer
        Dim renglon As Integer
        Try
            columna = DataGridEntrenadores.CurrentCellAddress.Y
            renglon = DataGridEntrenadores.Rows(columna).Cells(0).Value
        Catch ex As Exception
            MessageBox.Show("No ha seleccionado un renglon")
        End Try

        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro de la ciudad
            tec.eliminaentrenadores()


            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            tec.PoblarDataGridEntrenadores(DataGridEntrenadores)
        End If


    End Sub
    Private Sub Buttonnuevo_Click(sender As Object, e As EventArgs) Handles Buttonnuevo.Click
        Dim tec As New AgregarEntrenadoresComandos(TextBoxEntrenador.Text, TextBoxIdGenero.Text, TextBoxDepartamento.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)

        tec.limpiar()
    End Sub

    Private Sub id_carrera_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxEntrenador.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Buttonactualizar_Click(sender As Object, e As EventArgs) Handles Buttonactualizar.Click
        If TextBoxEntrenador.Text = "" Then
            MessageBox.Show("Agregar numero de la tabla !!")
        ElseIf TextBoxIdGenero.Text = "" Then
            MessageBox.Show("Capturar numero del genero !!")
        ElseIf TextBoxDepartamento.Text = "" Then
            MessageBox.Show("Capturar nuevo id para del departamento !!")
        ElseIf TextBoxNombre.Text = "" Then
            MessageBox.Show("Capturar nuevo nombre !!")
        ElseIf TextBoxPaterno.Text = "" Then
            MessageBox.Show("Capturar nuevo nombre paterno !!")
        ElseIf TextBoxMaterno.Text = "" Then
            MessageBox.Show("Capturar nuevo nombre materno !!")

        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarEntrenadoresComandos(TextBoxEntrenador.Text, TextBoxIdGenero.Text, TextBoxDepartamento.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If tec.consultaidentrenadores() = True Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.actualizar() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("entrenador cambiado ...")
            Else
                MessageBox.Show("este entrenador no existe, cheque la tabla...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridEntrenadores(DataGridEntrenadores)
        End If
    End Sub
    Private Sub DataGridEntrenadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridEntrenadores.CellContentClick
        Dim tec As New AgregarEntrenadoresComandos(TextBoxEntrenador.Text, TextBoxIdGenero.Text, TextBoxDepartamento.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)

        tec.ponerencuadros()
    End Sub
End Class