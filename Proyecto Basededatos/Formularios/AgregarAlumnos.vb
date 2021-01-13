Public Class AgregarAlumnos
    Private Sub AgregarAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tec As New AgregarAlumnosComandos1(TextBoxNoControl.Text, TextBoxIdGenero.Text, TextBoxIdCarrera.Text, TextBoxIdEquipo.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)
        tec.PoblarDataGridAlumnos(DataGridAlumnos)
        tec.PoblarDataGridCarreras(DataGridCarreras)
        tec.PoblarDataGridGeneros(DataGridGeneros)
        tec.PoblarDataGridEquipos(DataGridEquipos)
    End Sub


    Private Sub Buttonguardar_Click(sender As Object, e As EventArgs) Handles Buttonguardar.Click
        If TextBoxNoControl.Text = "" Then
            MessageBox.Show("Agregar numero positivo o no existente en la tabla !!")
        ElseIf TextBoxIdGenero.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxIdCarrera.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxIdEquipo.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxNombre.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxPaterno.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxMaterno.Text = "" Then
            MessageBox.Show("Capturar nombre !!")


        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarAlumnosComandos1(TextBoxNoControl.Text, TextBoxIdGenero.Text, TextBoxIdCarrera.Text, TextBoxIdEquipo.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If (tec.consultaidcarrera() And tec.consultaidalumnos() And tec.consultaidtec()) = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.insertaalumno() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("alumno Registrado ...")
            Else
                MessageBox.Show("este alumno ya esta regristado, prueba con otro...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridAlumnos(DataGridAlumnos)
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim tec As New AgregarAlumnosComandos1(TextBoxNoControl.Text, TextBoxIdGenero.Text, TextBoxIdCarrera.Text, TextBoxIdEquipo.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)
        'Con el método validaColonias, verificamos que la ciudad que se quiere eliminar NO tenga colonias
        Dim columna As Integer
        Dim renglon As Integer
        Try
            columna = DataGridGeneros.CurrentCellAddress.Y
            renglon = DataGridGeneros.Rows(columna).Cells(0).Value
        Catch ex As Exception
            MessageBox.Show("No ha seleccionado un renglon")
        End Try

        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro de la ciudad
            tec.eliminaalumnos()


            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            tec.PoblarDataGridAlumnos(DataGridAlumnos)
        End If


    End Sub


    Private Sub Buttonnuevo_Click(sender As Object, e As EventArgs) Handles Buttonnuevo.Click
        Dim tec As New AgregarAlumnosComandos1(TextBoxNoControl.Text, TextBoxIdGenero.Text, TextBoxIdCarrera.Text, TextBoxIdEquipo.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)
        tec.limpiar()
    End Sub

    Private Sub id_carrera_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNoControl.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Buttonactualizar_Click(sender As Object, e As EventArgs) Handles Buttonactualizar.Click
        If TextBoxNoControl.Text = "" Then
            MessageBox.Show("Agregar numero de la tabla !!")
        ElseIf TextBoxIdGenero.Text = "" Then
            MessageBox.Show("Capturar nuevo nombre de la carrera !!")
        ElseIf TextBoxIdCarrera.Text = "" Then
            MessageBox.Show("Capturar nuevo id para del tec !!")
        ElseIf TextBoxIdEquipo.Text = "" Then
            MessageBox.Show("Capturar nuevo id para del tec !!")
        ElseIf TextBoxNombre.Text = "" Then
            MessageBox.Show("Capturar nuevo id para del tec !!")
        ElseIf TextBoxPaterno.Text = "" Then
            MessageBox.Show("Capturar nuevo id para del tec !!")
        ElseIf TextBoxMaterno.Text = "" Then
            MessageBox.Show("Capturar nuevo id para del tec !!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarAlumnosComandos1(TextBoxNoControl.Text, TextBoxIdGenero.Text, TextBoxIdCarrera.Text, TextBoxIdEquipo.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If tec.consultaidalumnos() = True Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.actualizar() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("alumno cambiado ...")
            Else
                MessageBox.Show("esta alumno no existe, cheque la tabla...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridAlumnos(DataGridAlumnos)
        End If
    End Sub

    Private Sub DataGridAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridGeneros.CellContentClick
        Dim tec As New AgregarAlumnosComandos1(TextBoxNoControl.Text, TextBoxIdGenero.Text, TextBoxIdCarrera.Text, TextBoxIdEquipo.Text, TextBoxNombre.Text, TextBoxPaterno.Text, TextBoxMaterno.Text)
        tec.ponerencuadros()
    End Sub
End Class