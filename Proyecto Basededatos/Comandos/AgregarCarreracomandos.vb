Public Class AgregarCarreracomandos
    Private idCarrera As String
    Private nombre As String
    Private idTec As String

    Public Sub New(ByVal id_Carrera As String, ByVal nombreCarrera As String, ByVal id_tec As String)
        idTec = id_tec
        nombre = nombreCarrera
        idCarrera = id_Carrera

    End Sub
    Public Function consultaTodosLosTec() As Object
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
        consultaTodosLosTec = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridTec(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodosLosTec()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
    End Sub
    Public Function consultaTodaslasCarreras() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * from carreras order by id_tec asc"
        consultaTodaslasCarreras = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridCarreras(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodaslasCarreras()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
    End Sub

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

    Public Sub insertacarrera()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "INSERT INTO carreras VALUES(" & idCarrera & ",'" & nombre & "', " & idTec & ")"
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub eliminacarreras()
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = AgregarCarreras.DataGridCarreras.CurrentCellAddress.Y

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        Try
            strSql = "delete from carreras where id_carrera = " & AgregarCarreras.DataGridCarreras.Rows(renglon).Cells(0).Value
            xCnx.objetoCommand(strSql)
            MessageBox.Show("Registro Eliminado")
        Catch ex As Exception
            MessageBox.Show("Este dato contiene referencias, eliminar referencias antes")
        End Try
    End Sub

    Public Sub limpiar()
        AgregarCarreras.TextBoxCarrera.Clear()
        AgregarCarreras.TextBoxNombre.Clear()
        AgregarCarreras.TextBoxTec.Clear()

    End Sub

    Public Sub actualizar()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "update carreras 
	set id_carrera = " & idCarrera & "
	,nombre = '" & nombre & "' 
    where id_tec=" & idTec
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub ponerencuadros()
        Dim columna As Integer
        columna = AgregarCarreras.DataGridCarreras.CurrentCellAddress.Y
        AgregarCarreras.TextBoxCarrera.Text = AgregarCarreras.DataGridCarreras.Rows(columna).Cells(0).Value
        AgregarCarreras.TextBoxNombre.Text = AgregarCarreras.DataGridCarreras.Rows(columna).Cells(1).Value
        AgregarCarreras.TextBoxTec.Text = AgregarCarreras.DataGridCarreras.Rows(columna).Cells(2).Value
    End Sub
End Class