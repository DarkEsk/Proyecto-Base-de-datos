Public Class AgregarParticipaciones
    Public actualizado As Boolean
    Public eliminado As Boolean
    Public insertado As Boolean

    Private Sub AgregarParticipaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tec As New AgregarParticipacionesComandos
        tec.PoblarDataGridHorarios(HorarioDGV)
        tec.PoblarDataGridEquipos(equipoDGV)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim fecha As String
        fecha = FechaJuego.Value

        If TxtEquipo.Text = "" Then
            MessageBox.Show("Agregar numero positivo o no existente en la tabla !!")
        ElseIf TxtHora.Text = "" Then
            MessageBox.Show("Capturar la hora del juego !!")
        ElseIf FechaJuego.Text = "" Then
            MessageBox.Show("Capturar una fecha del juego !!")
        Else
            ''si todos los textbox estan rellenados ahora ingresar el entrenador
            Dim tec As New AgregarParticipacionesComandos(TxtEquipo.Text, fecha.Substring(0, 10),
                                           TxtHora.Text)


            If (tec.consultaidHorario()) = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.insertarHorario() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("Horario Registrado ...")
            Else
                MessageBox.Show("este Horario ya esta regristado, pruebe con otro...")
            End If

            tec.PoblarDataGridHorarios(HorarioDGV)

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim tec As New AgregarParticipacionesComandos
        'Con el método validaColonias, verificamos que la ciudad que se quiere eliminar NO tenga colonias
        Dim columna As Integer
        Dim renglon As Integer

        'Try
        '    columna = HorarioDGV.CurrentCellAddress.Y
        '    renglon = HorarioDGV.Rows(columna).Cells(0).Value
        'Catch ex As Exception
        '    MessageBox.Show("No ha seleccionado un renglon")
        'End Try

        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro de la ciudad
            tec.eliminaHorario()


            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            tec.PoblarDataGridHorarios(HorarioDGV)
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim tec As New AgregarParticipacionesComandos
        tec.limpiarHorario()
    End Sub

    Private Sub HorarioDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HorarioDGV.CellContentClick
        Dim tec As New AgregarParticipacionesComandos
        tec.ponerencuadrosHorario()
        tec.PoblarDataGridHorariosSeleccionados(equipoDGV)
    End Sub
    Private Sub equipoDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles equipoDGV.CellContentClick
        Dim tec As New AgregarParticipacionesComandos
        tec.ponerencuadrosHorariot()
        tec.PoblarDataGridEquiposSeleccionados(HorarioDGV)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If TxtEquipo.Text = "" Then
            MessageBox.Show("Agregar numero positivo o no existente en la tabla !!")
        ElseIf TxtHora.Text = "" Then
            MessageBox.Show("Capturar la hora del juego !!")
        ElseIf FechaJuego.Text = "" Then
            MessageBox.Show("Capturar una fecha del juego !!")
        Else
            ''si todos los textbox estan rellenados ahora ingresar el entrenador
            Dim tec As New AgregarParticipacionesComandos(TxtEquipo.Text, FechaJuego.Text,
                                           TxtHora.Text)

            If (tec.consultaidEquipo()) = True Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.actualizarHorario() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("Horario actualizado ...")
            Else
                MessageBox.Show("este equipo no existe, pruebe con otro...")
            End If

            tec.PoblarDataGridHorarios(HorarioDGV)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim tec As New AgregarParticipacionesComandos
        tec.PoblarDataGridHorarios(HorarioDGV)
        tec.PoblarDataGridEquipos(equipoDGV)
    End Sub

    Private Sub FechaJuego_ValueChanged(sender As Object, e As EventArgs) Handles FechaJuego.ValueChanged

    End Sub
End Class