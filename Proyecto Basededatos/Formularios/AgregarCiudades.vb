Public Class AgregarCiudades
    Private Sub AgregarCiudades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tec As New AgregarCiudadesComandos
        tec.PoblarDataGridCiudades(CiudadesDGV)
        tec.PoblarDataGridEstados(EstadosDGV)
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtIdCiudad.Text = "" Then
            MessageBox.Show("Agregar numero positivo o no existente en la tabla !!")
        ElseIf TxtNombre.Text = "" Then
            MessageBox.Show("Capturar nombre de la ciudad !!")
        ElseIf TxtIdEstado.Text = "" Then
            MessageBox.Show("Capturar id del estado !!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarCiudadesComandos(TxtIdCiudad.Text, TxtNombre.Text, TxtIdEstado.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If (tec.consultaidCiudad() And tec.consultaidEstados()) = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.insertarCiudad() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("Ciudad Registrado ...")
            Else
                MessageBox.Show("esta Ciudad ya esta regristado, pruebe con otro...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridCiudades(CiudadesDGV)
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim tec As New AgregarCiudadesComandos
        'Con el método validaColonias, verificamos que la ciudad que se quiere eliminar NO tenga colonias
        Dim columna As Integer
        Dim renglon As Integer
        Try
            columna = CiudadesDGV.CurrentCellAddress.Y
            renglon = CiudadesDGV.Rows(columna).Cells(0).Value
        Catch ex As Exception
            MessageBox.Show("No ha seleccionado un renglon")
        End Try

        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro de la ciudad
            tec.eliminaCiudad()


            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            tec.PoblarDataGridCiudades(CiudadesDGV)
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Dim tec As New AgregarCiudadesComandos
        tec.limpiarCiudad()
    End Sub

    Private Sub CiudadesDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CiudadesDGV.CellContentClick
        Dim tec As New AgregarCiudadesComandos
        tec.ponerencuadrosCiudades()
        tec.PoblarDataGridEstadosSeleccionado(EstadosDGV)

    End Sub

    Private Sub EstadosDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EstadosDGV.CellContentClick
        Dim tec As New AgregarCiudadesComandos
        tec.ponerencuadrosEstados()
        tec.PoblarDataGridCiudadesSeleccionado(CiudadesDGV)

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtIdCiudad.Text = "" Then
            MessageBox.Show("Agregar nuevo numero de la ciudad !!")
        ElseIf TxtNombre.Text = "" Then
            MessageBox.Show("Capturar nuevo nombre de la ciudad !!")
        ElseIf TxtNombre.Text = "" Then
            MessageBox.Show("Capturar nuevo id del estado de la ciudad!!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarCiudadesComandos(TxtIdCiudad.Text, TxtNombre.Text, TxtIdEstado.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If tec.consultaidCiudad() = True Then
                If tec.consultaidEstados() = True Then
                    'Si la ciudad NO está registrada, la inserta como una nueva
                    tec.actualizarCiudad() 'INSERTA NUEVA CIUDAD

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("Ciudad cambiado ...")
                Else
                    MessageBox.Show("este Id de estado no existe, cheque la tabla...")
                End If
            Else
                MessageBox.Show("este id de ciudad no existe, cheque la tabla...")
            End If
            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridCiudades(CiudadesDGV)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Dim tec As New AgregarCiudadesComandos
        tec.PoblarDataGridCiudades(CiudadesDGV)
        tec.PoblarDataGridEstados(EstadosDGV)
    End Sub
End Class