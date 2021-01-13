Public Class AgregarEntrenadoresComandos
    Private idEntrenador As String
    Private idGenero As String
    Private idDepartamento As String
    Private nombre As String
    Private paterno As String
    Private materno As String

    Public Sub New(ByVal id_entrenador As String, ByVal id_genero As String, ByVal id_departamento As String, ByVal nombreEntrenador As String, ByVal nombrePaterno As String, ByVal nombreMaterno As String)
        idEntrenador = id_entrenador
        idGenero = id_genero
        idDepartamento = id_departamento
        nombre = nombreEntrenador
        paterno = nombrePaterno
        materno = nombreMaterno
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
    Public Sub insertaentrenador()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "INSERT INTO entrenadores VALUES(" & idEntrenador & "," & idGenero & ", " & idDepartamento & ", '" & nombre & "', '" & paterno & "', '" & materno & "')"
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub eliminaentrenadores()
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = AgregarEntrenadores.DataGridEntrenadores.CurrentCellAddress.Y

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
        AgregarEntrenadores.TextBoxEntrenador.Clear()
        AgregarEntrenadores.TextBoxIdGenero.Clear()
        AgregarEntrenadores.TextBoxDepartamento.Clear()
        AgregarEntrenadores.TextBoxNombre.Clear()
        AgregarEntrenadores.TextBoxPaterno.Clear()
        AgregarEntrenadores.TextBoxMaterno.Clear()

    End Sub
    Public Sub actualizar()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        strSql = "update entrenadores 
	set id_entrenador = " & idEntrenador & "
    ,id_genero = " & idGenero & "
    ,id_departamento = " & idDepartamento & "
    ,nombre = '" & nombre & "'
    ,paterno = '" & paterno & "'
	,materno = '" & materno & "' 
    where id_entrenador=" & idEntrenador
        xCnx.objetoCommand(strSql)

    End Sub
    Public Sub ponerencuadros()
        Dim columna As Integer
        columna = AgregarEntrenadores.DataGridEntrenadores.CurrentCellAddress.Y
        AgregarEntrenadores.TextBoxEntrenador.Text = AgregarEntrenadores.DataGridEntrenadores.Rows(columna).Cells(0).Value
        AgregarEntrenadores.TextBoxIdGenero.Text = AgregarEntrenadores.DataGridEntrenadores.Rows(columna).Cells(1).Value
        AgregarEntrenadores.TextBoxDepartamento.Text = AgregarEntrenadores.DataGridEntrenadores.Rows(columna).Cells(2).Value
        AgregarEntrenadores.TextBoxNombre.Text = AgregarEntrenadores.DataGridEntrenadores.Rows(columna).Cells(4).Value
        AgregarEntrenadores.TextBoxPaterno.Text = AgregarEntrenadores.DataGridEntrenadores.Rows(columna).Cells(5).Value
        AgregarEntrenadores.TextBoxMaterno.Text = AgregarEntrenadores.DataGridEntrenadores.Rows(columna).Cells(5).Value

    End Sub
End Class
