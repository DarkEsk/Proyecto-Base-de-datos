Public Class AgregarIntegrantesComandos
    Private noControl As String
    Private idEquipo As String


    Public Sub New(ByVal id_equipo As String, ByVal no_control As String)
        noControl = no_control
        idEquipo = id_equipo


    End Sub
    Public Function consultaTodosLosEquipos() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * from equiposdeportivos order by id_equipo asc"
        consultaTodosLosEquipos = xCnx.objetoDataAdapter(strSQL)
    End Function
    Public Sub PoblarDataGridEquipos(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodosLosEquipos()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
    End Sub
    Public Function consultaTodosLosAlumnos() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * from alumnos order by no_Control asc"
        consultaTodosLosAlumnos = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridAlumnos(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodosLosAlumnos()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
    End Sub
    Public Function consultaTodosLosIntegrantes() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * from integrantesequipos order by no_control asc"
        consultaTodosLosIntegrantes = xCnx.objetoDataAdapter(strSQL)
    End Function
    Public Sub PoblarDataGridIntegrantes(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodosLosIntegrantes()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
    End Sub

    Public Function consultaidentrenadores() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM entrenadores " &
                 "WHERE id_entrenador='" & AgregarEntrenadores.TextBoxEntrenador.Text & "'"
        consultaidentrenadores = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidentrenadores = True
        End If
    End Function
    Public Function consultaidalumnos() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM alumnos " &
                 "WHERE NO_CONTROL='" & AgregarAlumnos.TextBoxNoControl.Text & "'"
        consultaidalumnos = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidalumnos = True
        End If
    End Function
    Public Function consultaidcarrera() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM carreras " &
                 "WHERE ID_CARRERA='" & AgregarCarreras.TextBoxCarrera.Text & "'"
        consultaidcarrera = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidcarrera = True
        End If
    End Function

    Public Function consultaidequipos() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM equiposdeportivos " &
                 "WHERE id_equipo='" & AgregarEquiposDeportivos.TextBoxEquipo.Text & "'"
        consultaidequipos = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidequipos = True
        End If
    End Function
    Public Function consultaidintegrantes() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM integrantesequipos " &
                 "WHERE NO_CONTROL='" & AgregarIntegrantes.TextBoxNoControl.Text & "'"
        consultaidintegrantes = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidintegrantes = True
        End If
    End Function

    Public Function consultaidtec() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM tecsnm " &
                 "WHERE ID_TEC='" & AgregarTec.TextBox1.Text & "'"
        consultaidtec = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidtec = True
        End If
    End Function
    Public Sub insertaintegrante()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "INSERT INTO integrantesequipos VALUES(" & noControl & "," & idEquipo & ")"
        xCnx.objetoCommand(strSql)

    End Sub
    Public Sub eliminaintegrantes()
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = AgregarIntegrantes.DataGridIntegrantes.CurrentCellAddress.Y

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        Try
            strSql = "delete from integrantesequipos where no_control = " & AgregarIntegrantes.DataGridIntegrantes.Rows(renglon).Cells(0).Value
            xCnx.objetoCommand(strSql)
            MessageBox.Show("Registro Eliminado")
        Catch ex As Exception
            MessageBox.Show("Este dato contiene referencias, eliminar referencias antes")
        End Try
    End Sub
    Public Sub limpiar()
        AgregarIntegrantes.TextBoxNoControl.Clear()
        AgregarIntegrantes.TextBoxIdEquipo.Clear()

    End Sub
    Public Sub actualizar()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "update integrantesequipos 
	set no_control = " & noControl & "
    ,id_equipo = " & idEquipo & "
    where no_control=" & noControl
        xCnx.objetoCommand(strSql)

    End Sub
    Public Sub ponerencuadros()
        Dim columna As Integer
        columna = AgregarIntegrantes.DataGridIntegrantes.CurrentCellAddress.Y
        AgregarIntegrantes.TextBoxNoControl.Text = AgregarIntegrantes.DataGridIntegrantes.Rows(columna).Cells(0).Value
        AgregarIntegrantes.TextBoxIdEquipo.Text = AgregarIntegrantes.DataGridIntegrantes.Rows(columna).Cells(1).Value

    End Sub
End Class
