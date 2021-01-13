Public Class Generos


    Private Sub TxtGenero_TextChanged(sender As Object, e As EventArgs) Handles TxtGenero.TextChanged

    End Sub

    Private Sub GenerosDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GenerosDGV.CellContentClick
        Dim tec As New AgregarGenerosComandos
        tec.ponerencuadros()
    End Sub

    Private Sub AgregarGeneros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CON ESTO ESTAMOS AGREGADO AL DGV LOS DATOS YA EXISTENTES
        Dim tec As New AgregarGenerosComandos
        tec.PoblarDataGridGenero(GenerosDGV)
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ''CHECAMOS QUE NO ESTEN VACIOS LOS TXTBOX 
        If TxtIdGenero.Text = "" Then
            MessageBox.Show("Agregar numero positivo o no existente en la tabla !!")
        ElseIf TxtGenero.Text = "" Then
            MessageBox.Show("Capturar nombre del genero!!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarGenerosComandos(TxtIdGenero.Text, TxtGenero.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado
            'CONSULTAMOS QUE NO EXISTA ESE REGISTRO 
            If tec.consultaidGeneros() = False Then
                'Si el genero NO está registrada, la inserta como una nueva
                tec.insertarGenero() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("Genero Registrado ...")
            Else
                MessageBox.Show("este Genero ya esta regristado, pruebe con otro...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridGenero(GenerosDGV)
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim tec As New AgregarGenerosComandos

        Dim columna As Integer
        Dim renglon As Integer
        ''con el try checamos que haya seleccionado algo para eliminar
        Try
            columna = GenerosDGV.CurrentCellAddress.Y
            renglon = GenerosDGV.Rows(columna).Cells(0).Value
        Catch ex As Exception
            MessageBox.Show("No ha seleccionado un renglon")
        End Try

        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro de la ciudad
            tec.eliminaGenero()


            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            tec.PoblarDataGridGenero(GenerosDGV)
        End If

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Dim tec As New AgregarGenerosComandos
        tec.limpiarGenero()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtIdGenero.Text = "" Then
            MessageBox.Show("Agregar numero de la tabla !!")
        ElseIf TxtGenero.Text = "" Then
            MessageBox.Show("Capturar nuevo nombre del Genero !!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarGenerosComandos(TxtIdGenero.Text, TxtGenero.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If tec.consultaidGeneros() = True Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.actualizarGenero() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("Genero cambiado ...")
            Else
                MessageBox.Show("este Genero no existe, cheque la tabla...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridGenero(GenerosDGV)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class