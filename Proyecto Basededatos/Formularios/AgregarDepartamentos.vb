Public Class AgregarDepartamentos
    Private Sub AgregarDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tec As New AgregarDepartamentoscomandos(TextBoxDepartamentos.Text, TextBoxDescripcion.Text, TextBoxTec.Text, TextBoxEstados.Text)
        tec.PoblarDataGridDepartamentos(DataGridDepartamentos)
        tec.PoblarDataGridtec(DataGridTec)
        tec.PoblarDataGridEstados(DataGridEstados)
    End Sub

    Private Sub Buttonguardar_Click(sender As Object, e As EventArgs) Handles Buttonguardar.Click
        If TextBoxDepartamentos.Text = "" Then
            MessageBox.Show("Agregar numero positivo o no existente en la tabla !!")
        ElseIf TextBoxDescripcion.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        ElseIf TextBoxTec.Text = "" Then
            MessageBox.Show("Capturar id !!")
        ElseIf TextBoxEstados.Text = "" Then
            MessageBox.Show("Capturar id !!")


        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarDepartamentoscomandos(TextBoxDepartamentos.Text, TextBoxDescripcion.Text, TextBoxTec.Text, TextBoxEstados.Text)
            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If (tec.consultaidcarrera() And tec.consultaidalumnos() And tec.consultaidtec() And tec.consultaiddepartamentos() And tec.consultaidestados) = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.insertadepartamentos() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("departamento Registrado ...")
            Else
                MessageBox.Show("este departamento ya esta regristado, prueba con otro...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridDepartamentos(DataGridDepartamentos)
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim tec As New AgregarDepartamentoscomandos(TextBoxDepartamentos.Text, TextBoxDescripcion.Text, TextBoxTec.Text, TextBoxEstados.Text)
        'Con el método validaColonias, verificamos que la ciudad que se quiere eliminar NO tenga colonias
        Dim columna As Integer
        Dim renglon As Integer
        Try
            columna = DataGridDepartamentos.CurrentCellAddress.Y
            renglon = DataGridDepartamentos.Rows(columna).Cells(0).Value
        Catch ex As Exception
            MessageBox.Show("No ha seleccionado un renglon")
        End Try

        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro de la ciudad
            tec.eliminadepartamentos()


            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            tec.PoblarDataGridDepartamentos(DataGridDepartamentos)
        End If


    End Sub

    Private Sub Buttonnuevo_Click(sender As Object, e As EventArgs) Handles Buttonnuevo.Click
        Dim tec As New AgregarDepartamentoscomandos(TextBoxDepartamentos.Text, TextBoxDescripcion.Text, TextBoxTec.Text, TextBoxEstados.Text)
        tec.limpiar()
    End Sub

    Private Sub id_carrera_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxDepartamentos.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Buttonactualizar_Click(sender As Object, e As EventArgs) Handles Buttonactualizar.Click
        If TextBoxDepartamentos.Text = "" Then
            MessageBox.Show("Agregar numero de la tabla !!")
        ElseIf TextBoxDescripcion.Text = "" Then
            MessageBox.Show("Capturar nuevo descripcion del departamento !!")
        ElseIf TextBoxTec.Text = "" Then
            MessageBox.Show("Capturar nuevo id para del tec !!")
        ElseIf TextBoxEstados.Text = "" Then
            MessageBox.Show("Capturar id !!")

        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarDepartamentoscomandos(TextBoxDepartamentos.Text, TextBoxDescripcion.Text, TextBoxTec.Text, TextBoxEstados.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If tec.consultaiddepartamentos() = True Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.actualizar() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("departamento cambiado ...")
            Else
                MessageBox.Show("esta departamento no existe, cheque la tabla...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridDepartamentos(DataGridDepartamentos)
        End If
    End Sub

    Private Sub DataGridDepartamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridDepartamentos.CellContentClick
        Dim tec As New AgregarDepartamentoscomandos(TextBoxDepartamentos.Text, TextBoxDescripcion.Text, TextBoxTec.Text, TextBoxEstados.Text)
        tec.ponerencuadros()
    End Sub
End Class