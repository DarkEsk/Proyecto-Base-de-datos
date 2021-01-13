Public Class AgregarEquiposDeportivos
    Private Sub AgregarEquiposDeportivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tec As New AgregarEquiposComandos(TextBoxEquipo.Text, TextBoxEntrenador.Text, TextBoxNombre.Text, TextBoxTec.Text)
        tec.PoblarDataGridEquipos(DataGridEquipos)
        tec.PoblarDataGridEntrenadores(DataGridEntrenadores)
        tec.PoblarDataGridtec(DataGridTec)
    End Sub
    Private Sub Buttonguardar_Click(sender As Object, e As EventArgs) Handles Buttonguardar.Click
        If TextBoxEquipo.Text = "" Then
            MessageBox.Show("Agregar numero positivo o no existente en la tabla !!")
        ElseIf TextBoxEntrenador.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxNombre.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxTec.Text = "" Then
            MessageBox.Show("Capturar nombre !!")


        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarEquiposComandos(TextBoxEquipo.Text, TextBoxEntrenador.Text, TextBoxNombre.Text, TextBoxTec.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If (tec.consultaidcarrera() And tec.consultaidalumnos() And tec.consultaidtec() And tec.consultaidequipos() And tec.consultaidentrenadores()) = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.insertaequipo() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("equipo Registrado ...")
            Else
                MessageBox.Show("este equipo ya esta regristado, prueba con otro...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridEquipos(DataGridEquipos)
        End If
    End Sub
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim tec As New AgregarEquiposComandos(TextBoxEquipo.Text, TextBoxEntrenador.Text, TextBoxNombre.Text, TextBoxTec.Text)

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
            tec.PoblarDataGridEquipos(DataGridEquipos)
        End If


    End Sub
    Private Sub Buttonnuevo_Click(sender As Object, e As EventArgs) Handles Buttonnuevo.Click
        Dim tec As New AgregarEquiposComandos(TextBoxEquipo.Text, TextBoxEntrenador.Text, TextBoxNombre.Text, TextBoxTec.Text)

        tec.limpiar()
    End Sub

    Private Sub id_carrera_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxEquipo.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Buttonactualizar_Click(sender As Object, e As EventArgs) Handles Buttonactualizar.Click
        If TextBoxEquipo.Text = "" Then
            MessageBox.Show("Agregar numero de la tabla !!")
        ElseIf TextBoxEntrenador.Text = "" Then
            MessageBox.Show("Capturar numero del entrenador !!")
        ElseIf TextBoxNombre.Text = "" Then
            MessageBox.Show("Capturar nuevo nombre !!")
        ElseIf TextBoxTec.Text = "" Then
            MessageBox.Show("Capturar nuevo id !!")


        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarEquiposComandos(TextBoxEquipo.Text, TextBoxEntrenador.Text, TextBoxNombre.Text, TextBoxTec.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If tec.consultaidequipos() = True Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.actualizar() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("equipo cambiado ...")
            Else
                MessageBox.Show("este equipo no existe, cheque la tabla...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridEquipos(DataGridEquipos)
        End If
    End Sub
    Private Sub DataGridEntrenadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridEntrenadores.CellContentClick
        Dim tec As New AgregarEquiposComandos(TextBoxEquipo.Text, TextBoxEntrenador.Text, TextBoxNombre.Text, TextBoxTec.Text)

        tec.ponerencuadros()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridEquipos.CellContentClick

    End Sub
End Class
