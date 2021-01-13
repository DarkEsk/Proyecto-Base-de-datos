Public Class AgregarDepartamentoscomandos
    Private idDepartamentos As String
    Private idDescripcion As String
    Private idTec As String
    Private idEstado As String


    Public Sub New(ByVal id_departamento As String, ByVal descripcion As String, ByVal id_tec As String, ByVal id_estados As String)
        idDepartamentos = id_departamento
        idDescripcion = descripcion
        idTec = id_tec
        idEstado = id_estados

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
    Public Function consultaTodosLosDepartamentos() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * from departamentos order by id_departamento asc"
        consultaTodosLosDepartamentos = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridDepartamentos(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodosLosDepartamentos()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
    End Sub
    Public Function consultaTodosLosEstados() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * from estados order by id_estados asc"
        consultaTodosLosEstados = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridEstados(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodosLosEstados()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
    End Sub

    Public Function consultaiddepartamentos() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM departamentos " &
                 "WHERE id_departamento='" & AgregarDepartamentos.TextBoxDepartamentos.Text & "'"
        consultaiddepartamentos = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaiddepartamentos = True
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
    Public Function consultaidestados() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM estados " &
                 "WHERE id_estados='" & AgregarEstados.Txt_idEstado.Text & "'"
        consultaidestados = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidestados = True
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

    Public Sub insertadepartamentos()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "INSERT INTO departamentos VALUES(" & idDepartamentos & ",'" & idDescripcion & "', " & idTec & ", " & idEstado & ")"
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub eliminadepartamentos()
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = AgregarDepartamentos.DataGridDepartamentos.CurrentCellAddress.Y

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        Try
            strSql = "delete from departamentos where id_departamento = " & AgregarDepartamentos.DataGridDepartamentos.Rows(renglon).Cells(0).Value
            xCnx.objetoCommand(strSql)
            MessageBox.Show("Registro Eliminado")
        Catch ex As Exception
            MessageBox.Show("Este dato contiene referencias, eliminar referencias antes")
        End Try
    End Sub


    Public Sub limpiar()
        AgregarDepartamentos.TextBoxDepartamentos.Clear()
        AgregarDepartamentos.TextBoxDescripcion.Clear()
        AgregarDepartamentos.TextBoxTec.Clear()
    End Sub

    Public Sub actualizar()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "update departamentos 
	set id_departamento = " & idDepartamentos & "
	,descripcion = '" & idDescripcion & "' 
    ,id_tec = " & idTec & "
    where id_estados=" & idEstado
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub ponerencuadros()
        Dim columna As Integer
        columna = AgregarDepartamentos.DataGridDepartamentos.CurrentCellAddress.Y
        AgregarDepartamentos.TextBoxDepartamentos.Text = AgregarDepartamentos.DataGridDepartamentos.Rows(columna).Cells(0).Value
        AgregarDepartamentos.TextBoxDescripcion.Text = AgregarDepartamentos.DataGridDepartamentos.Rows(columna).Cells(1).Value
        AgregarDepartamentos.TextBoxTec.Text = AgregarDepartamentos.DataGridDepartamentos.Rows(columna).Cells(2).Value
        AgregarDepartamentos.TextBoxEstados.Text = AgregarDepartamentos.DataGridEstados.Rows(columna).Cells(2).Value


    End Sub
End Class


