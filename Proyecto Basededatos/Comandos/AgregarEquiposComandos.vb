Public Class AgregarEquiposComandos
    Private idEquipo As String
    Private idEntrenador As String
    Private nombre As String
    Private idTec As String
    Public Sub New(ByVal id_equipo As String, ByVal id_entrenador As String, ByVal nombreEquipo As String, ByVal id_tec As String)
        idEquipo = id_equipo
        idEntrenador = id_entrenador
        nombre = nombreEquipo
        idTec = id_tec

    End Sub
    Public Function consultaTodosLosEntrenadores() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * from entrenadores order by id_entrenador asc"
        consultaTodosLosEntrenadores = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridEntrenadores(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodosLosEntrenadores()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
    End Sub
    Public Function consultaTodoslostec() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * from tecsnm order by id_tec asc"
        consultaTodoslostec = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridtec(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodoslostec()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
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
    Public Sub insertaequipo()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "INSERT INTO equiposdeportivos VALUES(" & idEquipo & "," & idEntrenador & ", '" & nombre & "', " & idTec & ")"
        xCnx.objetoCommand(strSql)

    End Sub
    Public Sub eliminaentrenadores()
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = AgregarEquiposDeportivos.DataGridEntrenadores.CurrentCellAddress.Y

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        Try
            strSql = "delete from entrenadores where id_entrenador = " & AgregarEntrenadores.DataGridEntrenadores.Rows(renglon).Cells(0).Value
            xCnx.objetoCommand(strSql)
            MessageBox.Show("Registro Eliminado")
        Catch ex As Exception
            MessageBox.Show("Este dato contiene referencias, eliminar referencias antes")
        End Try
    End Sub
    Public Sub limpiar()
        AgregarEquiposDeportivos.TextBoxEquipo.Clear()
        AgregarEquiposDeportivos.TextBoxEntrenador.Clear()
        AgregarEquiposDeportivos.TextBoxNombre.Clear()
        AgregarEquiposDeportivos.TextBoxTec.Clear()

    End Sub
    Public Sub actualizar()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "update equiposdeportivos 
	set id_equipo = " & idEquipo & "
    ,id_entrenador = " & idEntrenador & "
    ,nombre = '" & nombre & "'
  	,id_tec = " & idTec & " 
    where id_equipo=" & idEquipo
        xCnx.objetoCommand(strSql)

    End Sub
    Public Sub ponerencuadros()
        Dim columna As Integer
        columna = AgregarEquiposDeportivos.DataGridEntrenadores.CurrentCellAddress.Y
        AgregarEquiposDeportivos.TextBoxEquipo.Text = AgregarEquiposDeportivos.DataGridEntrenadores.Rows(columna).Cells(0).Value
        AgregarEquiposDeportivos.TextBoxEntrenador.Text = AgregarEquiposDeportivos.DataGridEntrenadores.Rows(columna).Cells(1).Value
        AgregarEquiposDeportivos.TextBoxNombre.Text = AgregarEquiposDeportivos.DataGridEntrenadores.Rows(columna).Cells(2).Value
        AgregarEquiposDeportivos.TextBoxTec.Text = AgregarEquiposDeportivos.DataGridEntrenadores.Rows(columna).Cells(4).Value
    End Sub
End Class
