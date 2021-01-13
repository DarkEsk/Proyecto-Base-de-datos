Imports Oracle.DataAccess.Client
Public Class comadosdellamada

    Public Sub poblarCombotec(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle
        'Ejemplo para llenar un combo con información, se recibe como 
        ' parámetro el nombre del combo

        strSql = "SELECT nombre FROM tecsnm Order By nombre asc"
        Lista = xCnx.objetoDataReader(strSql)

        'Limpia el contenido del combo, para ser rellendo
        objeto.Items.Clear()

        'Con el while le coloca los renglones encontrados al combo
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub
    Public Sub poblarComboEstados(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle
        'Ejemplo para llenar un combo con información, se recibe como 
        ' parámetro el nombre del combo

        strSql = "SELECT nombre FROM Estados Order By nombre asc"
        Lista = xCnx.objetoDataReader(strSql)

        'Limpia el contenido del combo, para ser rellendo
        objeto.Items.Clear()

        'Con el while le coloca los renglones encontrados al combo
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Sub poblarCombocarreras(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'Con éste query llenamos el combo con los datos de los estados del país que tenemos selecionado
        strSql = "SELECT carreras.nombre " &
                 " FROM carreras, tecsnm " &
                 "WHERE carreras.id_tec = tecsnm.id_tec and " &
                 "      tecsnm.nombre = '" & Tec.ComboTec.Text & "' Order By carreras.nombre asc"
        Lista = xCnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Sub poblarComboDepartamentos(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'Con éste query llenamos el combo con los datos de los estados del país que tenemos selecionado
        strSql = "SELECT departamentos.descripcion " &
                 " FROM departamentos, tecsnm " &
                 "WHERE departamentos.id_tec = tecsnm.id_tec and " &
                 "      tecsnm.nombre = '" & Tec.ComboTec.Text & "' Order By departamentos.descripcion asc"
        Lista = xCnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()

    End Sub

    Public Sub poblarComboentrenadores(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'Con éste query llenamos el combo con los datos de los estados del país que tenemos selecionado
        strSql = "SELECT entrenadores.nombre " &
                 " FROM entrenadores, departamentos " &
                 "WHERE entrenadores.id_departamento = departamentos.id_departamento and " &
                 "      departamentos.descripcion = '" & Tec.ComboDepartamentos.Text & "' Order By entrenadores.nombre asc"
        Lista = xCnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Sub poblarCombohoras(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = Tec.DataGridequipos.CurrentCellAddress.Y
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'Con éste query llenamos el combo con los datos de los estados del país que tenemos selecionado
        strSql = "SELECT participaciones.hora " &
                 " FROM participaciones, equiposdeportivos " &
                 "WHERE participaciones.id_equipo = equiposdeportivos.id_equipo and " &
                 "      participaciones.id_equipo = '" & Tec.DataGridequipos.Rows(renglon).Cells(0).Value & "' Order By participaciones.hora asc"
        Lista = xCnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Function consultaTodosalumnos() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT no_control as NoControl, alumnos.nombre as Nombre, alumnos.paterno as Materno, alumnos.materno as Materno " &
                 " FROM alumnos, carreras, tecsnm " &
                 " WHERE tecsnm.id_tec = carreras.id_tec AND " &
                       " carreras.id_carrera = alumnos.id_carrera and " &
                       " carreras.nombre = '" & Tec.ComboCarrera.Text & "' and " &
                       " tecsnm.nombre = '" & Tec.ComboTec.Text & "'" &
                       " ORDER BY no_control asc"
        consultaTodosalumnos = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridAlumnos(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodosalumnos()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
    End Sub

    Public Function consultaTodosequipos() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_equipo as NoEquipo, equiposdeportivos.nombre as Nombre
                      From entrenadores, equiposdeportivos
                      Where entrenadores.id_entrenador = equiposdeportivos.id_entrenador And
                      entrenadores.nombre = '" & Tec.ComboEntrenadores.Text & "'
              ORDER BY id_equipo asc"
        consultaTodosequipos = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridequipos(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodosequipos()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
    End Sub

    Public Function consultaTodosintegrantes() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = Tec.DataGridequipos.CurrentCellAddress.Y

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT integrantesequipos.no_control as Nocontrol, alumnos.nombre as Nombre
		FROM alumnos, integrantesequipos, equiposdeportivos
		WHERE equiposdeportivos.id_equipo = integrantesequipos.id_equipo and
		alumnos.no_control = integrantesequipos.no_control and
		integrantesequipos.id_equipo = " & Tec.DataGridequipos.Rows(renglon).Cells(0).Value & "
		order by integrantesequipos.no_control asc"
        consultaTodosintegrantes = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridintegrantes(ByVal GDValumnos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodosintegrantes()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 200
        GDValumnos.Columns.Item(1).Width = 900
    End Sub

End Class
