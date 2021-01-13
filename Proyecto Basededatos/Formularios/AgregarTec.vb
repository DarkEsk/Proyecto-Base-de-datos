Public Class AgregarTec
    Private Sub AgregarTec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tec As New AgregarTeccomandos
        tec.PoblarDataGridtec(DataGridtec)
        tec.PoblarDataGridEstados(DGVestados)
        tec.PoblarDataGridCiudades(DGVciudades)
        ''tec.poblarComboCiudades(CmbCiudades)


    End Sub

    Private Sub Buttonguardar_Click(sender As Object, e As EventArgs) Handles Buttonguardar.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Agregar numero positivo o no existente en la tabla !!")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Capturar nombre del tec !!")
        ElseIf TextBoxEstado.Text = "" Then
            MessageBox.Show("Capturar el estado del tec !!")
        ElseIf TxtCP.Text = "" Then
            MessageBox.Show("Capturar CP del tec !!")
        ElseIf TxtCalle.Text = "" Then
            MessageBox.Show("Capturar calle del tec !!")
        ElseIf TxtTelefono.Text = "" Then
            MessageBox.Show("Capturar telefono del tec !!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarTeccomandos(TextBox1.Text, TextBox2.Text, TextBoxEstado.Text, TxtCP.Text, TxtCalle.Text, TxtTelefono.Text,
                                              CmbCiudades.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If tec.consultaidtec() = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.insertatec() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("tec Registrado ...")
            Else
                MessageBox.Show("este tec ya esta regristado, pruebe con otro...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridtec(DataGridtec)
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim tec As New AgregarTeccomandos
        'Con el método validaColonias, verificamos que la ciudad que se quiere eliminar NO tenga colonias
        Dim columna As Integer
        Dim renglon As Integer
        Try
            columna = DataGridtec.CurrentCellAddress.Y
            renglon = DataGridtec.Rows(columna).Cells(0).Value
        Catch ex As Exception
            MessageBox.Show("No ha seleccionado un renglon")
        End Try

        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro de la ciudad
            tec.eliminatec()


            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            tec.PoblarDataGridtec(DataGridtec)
        End If


    End Sub

    Private Sub Buttonnuevo_Click(sender As Object, e As EventArgs) Handles Buttonnuevo.Click
        Dim tec As New AgregarTeccomandos
        tec.limpiar()
    End Sub

    Private Sub id_tec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Buttonactualizar_Click(sender As Object, e As EventArgs) Handles Buttonactualizar.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Agregar numero de la tabla !!")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Capturar nuevo nombre del tec !!")
        ElseIf TextBoxEstado.Text = "" Then
            MessageBox.Show("Capturar el nuevo estado del tec !!")
        ElseIf TxtCP.Text = "" Then
            MessageBox.Show("Capturar nuevo CP del tec !!")
        ElseIf TxtCalle.Text = "" Then
            MessageBox.Show("Capturar nueva calle del tec !!")
        ElseIf TxtTelefono.Text = "" Then
            MessageBox.Show("Capturar nuevo telefono del tec !!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tec As New AgregarTeccomandos(TextBox1.Text, TextBox2.Text, TextBoxEstado.Text,
                                              TxtCP.Text, TxtCalle.Text, TxtTelefono.Text,
                                              CmbCiudades.Text)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If tec.consultaidtec() = True Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tec.actualizar() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("tec cambiado ...")
            Else
                MessageBox.Show("este tec no existe, cheque la tabla...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tec.PoblarDataGridtec(DataGridtec)
        End If
    End Sub

    Private Sub DataGridtec_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridtec.CellContentClick
        Dim tec As New AgregarTeccomandos
        tec.ponerencuadros()
        tec.PoblarDataGriEstadoSeleccionado(DGVestados)
        ''tec.PoblarDataGridtecSeleccionado(DGVestados)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CmbEstados_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim tec As New AgregarTeccomandos
        tec.poblarComboCiudadesConEstados(CmbCiudades)
    End Sub


    Private Sub DGVestados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVestados.CellContentClick
        Dim tec As New AgregarTeccomandos
        tec.PoblarDataGridtecSeleccionado(DataGridtec)
    End Sub

    Private Sub BtnAct_Click(sender As Object, e As EventArgs)
        Dim tec As New AgregarTeccomandos
        tec.PoblarDataGridtec(DataGridtec)
        tec.PoblarDataGridEstados(DGVestados)
        tec.PoblarDataGridCiudades(DGVciudades)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TxtCP_TextChanged(sender As Object, e As EventArgs) Handles TxtCP.TextChanged

    End Sub

    Private Sub TxtCalle_TextChanged(sender As Object, e As EventArgs) Handles TxtCalle.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEstado.TextChanged

    End Sub
End Class