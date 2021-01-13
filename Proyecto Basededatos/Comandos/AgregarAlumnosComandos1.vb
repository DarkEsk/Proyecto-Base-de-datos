Public Class AgregarAlumnosComandos1
    Private noControl As String
    Private idGenero As String
    Private idCarrera As String
    Private idEquipo As String
    Private nombre As String
    Private paterno As String
    Private materno As String

    Public Sub New(ByVal no_Control As String, ByVal id_genero As String, ByVal id_carrera As String, ByVal id_equipo As String, ByVal nombreAlumno As String, ByVal nombrePaterno As String, ByVal nombreMaterno As String)
        noControl = no_Control
        idGenero = id_genero
        idCarrera = id_carrera
        idEquipo = id_equipo
        nombre = nombreAlumno
        paterno = nombrePaterno
        materno = nombreMaterno
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
    Public Function consultaTodosLosGeneros() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * from generos order by id_genero asc"
        consultaTodosLosGeneros = xCnx.objetoDataAdapter(strSQL)
    End Function
    Public Sub PoblarDataGridGeneros(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodosLosGeneros()

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

    Public Sub insertaalumno()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "INSERT INTO alumnos VALUES(" & noControl & "," & idGenero & ", " & idCarrera & ", " & idEquipo & ", '" & nombre & "', '" & paterno & "', '" & materno & "')"
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub eliminaalumnos()
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = AgregarAlumnos.DataGridGeneros.CurrentCellAddress.Y

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        Try
            strSql = "delete from alumnos where no_control = " & AgregarAlumnos.DataGridGeneros.Rows(renglon).Cells(0).Value
            xCnx.objetoCommand(strSql)
            MessageBox.Show("Registro Eliminado")
        Catch ex As Exception
            MessageBox.Show("Este dato contiene referencias, eliminar referencias antes")
        End Try
    End Sub

    Public Sub limpiar()
        AgregarAlumnos.TextBoxNoControl.Clear()
        AgregarAlumnos.TextBoxIdGenero.Clear()
        AgregarAlumnos.TextBoxIdCarrera.Clear()
        AgregarAlumnos.TextBoxIdEquipo.Clear()
        AgregarAlumnos.TextBoxNombre.Clear()
        AgregarAlumnos.TextBoxPaterno.Clear()
        AgregarAlumnos.TextBoxMaterno.Clear()

    End Sub

    Public Sub actualizar()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "update alumnos 
	set no_control = " & noControl & "
    ,id_genero = " & idGenero & "
    ,id_carrera = " & idCarrera & "
    ,id_Equipo = " & idEquipo & "
    ,nombreAlumno = " & nombre & "
    ,nombrePaterno = " & paterno & "
	,nombreMaterno = '" & nombre & "' 
    where no_control=" & noControl
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub ponerencuadros()
        Dim columna As Integer
        columna = AgregarAlumnos.DataGridGeneros.CurrentCellAddress.Y
        AgregarAlumnos.TextBoxNoControl.Text = AgregarAlumnos.DataGridGeneros.Rows(columna).Cells(0).Value
        AgregarAlumnos.TextBoxIdGenero.Text = AgregarAlumnos.DataGridGeneros.Rows(columna).Cells(1).Value
        AgregarAlumnos.TextBoxIdCarrera.Text = AgregarAlumnos.DataGridGeneros.Rows(columna).Cells(2).Value
        AgregarAlumnos.TextBoxIdEquipo.Text = AgregarAlumnos.DataGridGeneros.Rows(columna).Cells(3).Value
        AgregarAlumnos.TextBoxNombre.Text = AgregarAlumnos.DataGridGeneros.Rows(columna).Cells(4).Value
        AgregarAlumnos.TextBoxPaterno.Text = AgregarAlumnos.DataGridGeneros.Rows(columna).Cells(5).Value
        AgregarAlumnos.TextBoxMaterno.Text = AgregarAlumnos.DataGridGeneros.Rows(columna).Cells(6).Value
    End Sub
End Class

