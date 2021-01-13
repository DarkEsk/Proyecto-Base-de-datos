Public Class AgregarCarreras
    Private Sub AgregarCarreras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tec As New AgregarCarreracomandos(TextBoxCarrera.Text, TextBoxNombre.Text, TextBoxTec.Text)
        tec.PoblarDataGridCarreras(DataGridCarreras)
        tec.PoblarDataGridTec(DataGridTec)
    End Sub

    Private Sub Buttonguardar_Click(sender As Object, e As EventArgs) Handles Buttonguardar.Click
        If TextBoxCarrera.Text = "" Then
            MessageBox.Show("Agregar numero positivo o no existente en la tabla !!")
        ElseIf TextBoxNombre.Text = "" Then
            MessageBox.Show("Capturar nombre !!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarCarreracomandos(TextBoxCarrera.Text, TextBoxNombre.Text, TextBoxTec.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If (tec.consultaidcarrera() And tec.consultaidtec()) = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.insertacarrera() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("carrera Registrado ...")
            Else
                MessageBox.Show("esta carrera ya esta regristada, prueba con otra...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridCarreras(DataGridCarreras)
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim tec As New AgregarCarreracomandos(TextBoxCarrera.Text, TextBoxNombre.Text, TextBoxTec.Text)
        'Con el método validaColonias, verificamos que la ciudad que se quiere eliminar NO tenga colonias
        Dim columna As Integer
        Dim renglon As Integer
        Try
            columna = DataGridCarreras.CurrentCellAddress.Y
            renglon = DataGridCarreras.Rows(columna).Cells(0).Value
        Catch ex As Exception
            MessageBox.Show("No ha seleccionado un renglon")
        End Try

        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro de la ciudad
            tec.eliminacarreras()


            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            tec.PoblarDataGridCarreras(DataGridCarreras)
        End If


    End Sub

    Private Sub Buttonnuevo_Click(sender As Object, e As EventArgs) Handles Buttonnuevo.Click
        Dim tec As New AgregarCarreracomandos(TextBoxCarrera.Text, TextBoxNombre.Text, TextBoxTec.Text)
        tec.limpiar()
    End Sub

    Private Sub id_carrera_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCarrera.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Buttonactualizar_Click(sender As Object, e As EventArgs) Handles Buttonactualizar.Click
        If TextBoxCarrera.Text = "" Then
            MessageBox.Show("Agregar numero de la tabla !!")
        ElseIf TextBoxNombre.Text = "" Then
            MessageBox.Show("Capturar nuevo nombre de la carrera !!")
        ElseIf TextBoxTec.Text = "" Then
            MessageBox.Show("Capturar nuevo id para del tec !!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarCarreracomandos(TextBoxCarrera.Text, TextBoxNombre.Text, TextBoxTec.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If tec.consultaidcarrera() = True Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.actualizar() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("carrera cambiada ...")
            Else
                MessageBox.Show("esta carrera no existe, cheque la tabla...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridCarreras(DataGridCarreras)
        End If
    End Sub

    Private Sub DataGridCarreras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCarreras.CellContentClick
        Dim tec As New AgregarCarreracomandos(TextBoxCarrera.Text, TextBoxNombre.Text, TextBoxTec.Text)
        tec.ponerencuadros()
    End Sub

    Private Sub TextBoxCarrera_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCarrera.TextChanged

    End Sub
End Class