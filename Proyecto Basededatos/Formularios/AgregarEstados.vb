Public Class AgregarEstados
    Private Sub AgregarEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim est As New AgregarEstadosComandos
        est.PoblarDataGridCd(DGVestados)

        Me.ToolTip1.SetToolTip(Me.BtnLimpia, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Clic para Eliminar información en el sistema...")
    End Sub
    Private Sub BtnLimpia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpia.Click

        Txt_idEstado.Text = 0
        Txt_nombre.Text = ""

        'Para poner o madar el cursor a una caja de textos
        Txt_nombre.Focus()
    End Sub

    Private Sub DGVestados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVestados.CellContentClick

        Dim renglon As Integer

        renglon = DGVestados.CurrentCellAddress.Y

        Txt_idEstado.Text = DGVestados.Rows(renglon).Cells(0).Value
        Txt_nombre.Text = DGVestados.Rows(renglon).Cells(1).Value

    End Sub

    Private Sub BtnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BtnGuardar.Click

        If Txt_idEstado.Text = "" Then
            MessageBox.Show("Capturar clave del Estado")
        ElseIf Txt_nombre.Text = "" Then
            MessageBox.Show("Capturar nombre del nombre")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim tecs As New AgregarEstadosComandos(Txt_idEstado.Text, Txt_nombre.Text)

            tecs.getSetidEstado = Txt_idEstado.Text
            tecs.getSetNombre = Txt_nombre.Text

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If tecs.consultaUnEstado() = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                tecs.insertaEstado() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("Estado Registrado")
            Else
                MessageBox.Show("Un estado ya tiene asignada esa ip")

            End If
            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            tecs.PoblarDataGridCd(DGVestados)
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEliminar.Click
        If Txt_idEstado.Text = "" Or Txt_nombre.Text = "" Then
            MessageBox.Show("Captura los datos completos")
        Else
            Dim gene As New AgregarEstadosComandos(Txt_idEstado.Text, Txt_nombre.Text)
            'Con el método validaColonias, verificamos que la ciudad que se quiere eliminar NO tenga colonias
            ' If Tecs.validaTecs() = True Then
            ' MsgBox("No se puede dar de baja la ciudad seleccionada, tiene colonias registradas...")
            ' Else
            If gene.validaTecs() = True Then
                MessageBox.Show("No se puede borrar, tiene datos dependientes")
            Else
                If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                    'Llamamos al método que elimina el registro de la ciudad
                    gene.eliminaEstado()
                    MessageBox.Show("Registro Eliminado")

                    'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                    gene.PoblarDataGridCd(DGVestados)
                End If
            End If
        End If
    End Sub

    Private Sub Txt_idcd_TextChanged(sender As Object, e As EventArgs)
        If Txt_idEstado.Text <> "" Then
            'Busca  un país en particular
            Dim gene As New AgregarEstadosComandos
            'Llamamos al método que elimina el registro
            gene.consultaUnEstado()
        End If
    End Sub

    Private Sub Txt_Tec_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Dim est As New AgregarEstadosComandos(Txt_idEstado.Text, Txt_nombre.Text)

        If (Txt_idEstado.Text) <> "" Then
            est.getSetidEstado = Txt_idEstado.Text
            est.getSetNombre = Txt_nombre.Text
        End If
    End Sub

    Private Sub Txt_idTec_TextChanged(sender As Object, e As EventArgs) Handles Txt_idEstado.TextChanged

        'METEODO PARA CUANDO METES INFO EN EL TEXBOX

        If Txt_idEstado.Text <> "" Then
            'Busca un pais en particula'
            Dim gene As New AgregarEstadosComandos
            'LLama el metodo que elimine el registro'
            gene.consultaUnEstado()
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        If Txt_idEstado.Text = "" Then
            MessageBox.Show("Capturar clave para el estado")
        ElseIf Txt_nombre.Text = "" Then
            MessageBox.Show("Capturar nombre del estado")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim gene As New AgregarEstadosComandos(Txt_idEstado.Text, Txt_nombre.Text)

            gene.getSetidEstado = Txt_idEstado.Text
            gene.getSetNombre = Txt_nombre.Text

            'Si la ciudad se encuentra registrada, se modifica la información
            gene.actualizaEstado() 'ACTUALIZA LA CIUDAD

            'Con ésta función mandamos una ventana de notificación al usuario final
            MsgBox("Estado   modificado")

            gene.PoblarDataGridCd(DGVestados)

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles Txt_nombre.TextChanged

    End Sub
End Class