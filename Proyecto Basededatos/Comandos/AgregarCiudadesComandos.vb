Public Class AgregarCiudadesComandos
    Private idCiudad As String
    Private Nombre As String
    Private idEstado As String

    Public Sub New(ByVal id_Ciudad As String, ByVal Ciudad_nombre As String,
                   ByVal id_Estado As String)
        'le asignamos a nuestras variables locales el id_tec y el tec_nombre
        idCiudad = id_Ciudad
        Nombre = Ciudad_nombre
        idEstado = id_Estado
    End Sub

    Public Sub New()

    End Sub

    Public Function consultaTodoslasCiudades() As Object ''regresa un objeto
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los generos registradas en la tabla
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        'los generos que se han registrado
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'creamos el query para la consulta en sql
        strSQL = "SELECT * from ciudades order by id_ciudad asc"
        consultaTodoslasCiudades = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridCiudades(ByVal CiudadesDGV As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        CiudadesDGV.DataSource = consultaTodoslasCiudades()

        'Con el refresh actualiza el contenido del DGV

        CiudadesDGV.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        CiudadesDGV.Columns.Item(0).Width = 100
        CiudadesDGV.Columns.Item(1).Width = 100
    End Sub

    Public Function consultaidCiudad() As Boolean 'Regresa un boleano

        'CON ESTE METODO HACEMOS LA CONSULTA DE QUE EL REGISTRO SE ENCUENTRE O NO(SE UTILIZA EN "AGREGAR GENEROS")

        ' Utilizada para obtener el ID del tec seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM ciudades " &
                 "WHERE id_ciudad ='" & AgregarCiudades.TxtIdCiudad.Text & "'"
        'en ves de poner el id pedimos que^^^^ lo traiga del textbox seleccionado
        consultaidCiudad = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidCiudad = True
        End If
    End Function

    Public Function consultaTodoslosEstados() As Object ''regresa un objeto
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los generos registradas en la tabla
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        'los generos que se han registrado
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'creamos el query para la consulta en sql
        strSQL = "SELECT * from estados order by id_estados asc"
        consultaTodoslosEstados = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridEstados(ByVal EstadosDGV As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        EstadosDGV.DataSource = consultaTodoslosEstados()

        'Con el refresh actualiza el contenido del DGV

        EstadosDGV.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        EstadosDGV.Columns.Item(0).Width = 100
        EstadosDGV.Columns.Item(1).Width = 100
    End Sub

    Public Function consultaidEstados() As Boolean 'Regresa un boleano

        'CON ESTE METODO HACEMOS LA CONSULTA DE QUE EL REGISTRO SE ENCUENTRE O NO(SE UTILIZA EN "AGREGAR GENEROS")

        ' Utilizada para obtener el ID del tec seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM estados " &
                 "WHERE id_estados ='" & AgregarCiudades.TxtIdEstado.Text & "'"
        'en ves de poner el id pedimos que^^^^ lo traiga del textbox seleccionado
        consultaidEstados = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidEstados = True
        End If
    End Function

    Public Sub insertarCiudad() 'no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle

        ''hacemos la insercion en la tabla y le pasamos lo que tenga en idtec y tecnombre
        strSql = "INSERT INTO ciudades VALUES(" & idCiudad & ",'" & Nombre & "'," & idEstado & ")"
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub eliminaCiudad() 'no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = AgregarCiudades.CiudadesDGV.CurrentCellAddress.Y

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        Try
            strSql = "delete from ciudades where id_ciudad = " & AgregarCiudades.CiudadesDGV.Rows(renglon).Cells(0).Value
            xCnx.objetoCommand(strSql)
            ''mpstramos un mensaje de que se ha eliminado 
            MessageBox.Show("Registro Eliminado")
        Catch ex As Exception
            ''si tiene hijos no se elimnia y se muestra el mensaje
            MessageBox.Show("Este dato contiene referencias, eliminar referencias antes")
        End Try
    End Sub

    Public Sub limpiarCiudad() ''no regresa nada 
        ''limpiamos los texbox
        AgregarCiudades.TxtIdCiudad.Clear()
        AgregarCiudades.TxtNombre.Clear()
        AgregarCiudades.TxtIdEstado.Clear()

    End Sub

    Public Sub actualizarCiudad() ''no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle

        'hacemos el query donde hacemos el update en sql
        strSql = "update ciudades
	            set id_ciudad = " & idCiudad & "
	            ,nombre = '" & Nombre & "', id_estados = " & idEstado & "
                 where id_ciudad =" & idCiudad
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub ponerencuadrosCiudades()
        'CON ESTE METODO PONEMOS EN EL TXTBOX LO SELECCIONADO EN EL DGV
        Dim columna As Integer
        columna = AgregarCiudades.CiudadesDGV.CurrentCellAddress.Y
        'EL TXTBOX SERA IGUAL A LO QUE TENGA EL DGV EN ESA CELDA|||
        AgregarCiudades.TxtIdCiudad.Text = AgregarCiudades.CiudadesDGV.Rows(columna).Cells(0).Value
        AgregarCiudades.TxtNombre.Text = AgregarCiudades.CiudadesDGV.Rows(columna).Cells(1).Value
        AgregarCiudades.TxtIdEstado.Text = AgregarCiudades.CiudadesDGV.Rows(columna).Cells(2).Value
    End Sub

    Public Sub ponerencuadrosEstados()
        'CON ESTE METODO PONEMOS EN EL TXTBOX LO SELECCIONADO EN EL DGV
        Dim columna As Integer
        columna = AgregarCiudades.EstadosDGV.CurrentCellAddress.Y
        'EL TXTBOX SERA IGUAL A LO QUE TENGA EL DGV EN ESA CELDA|||
        AgregarCiudades.TxtIdEstado.Text = AgregarCiudades.EstadosDGV.Rows(columna).Cells(0).Value

    End Sub

    Public Function consultaTodoslasCiudadesGrid() As Object ''regresa un objeto
        Dim strSQL As String
        Dim xCnx As New Oracle

        Dim columna As Integer
        columna = AgregarCiudades.EstadosDGV.CurrentCellAddress.Y

        idEstado = AgregarCiudades.EstadosDGV.Rows(columna).Cells(0).Value
        'Consulta datos de todas los generos registradas en la tabla
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        'los generos que se han registrado
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'creamos el query para la consulta en sql
        strSQL = "select ciudades.id_ciudad, ciudades.nombre, ciudades.id_estado from ciudades,estados
                where ciudades.id_estado = estados.id_estados
                and estados.id_estados =" & idEstado
        consultaTodoslasCiudadesGrid = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridCiudadesSeleccionado(ByVal CiudadesDGV As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        CiudadesDGV.DataSource = consultaTodoslasCiudadesGrid()

        'Con el refresh actualiza el contenido del DGV

        CiudadesDGV.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        CiudadesDGV.Columns.Item(0).Width = 85
        CiudadesDGV.Columns.Item(1).Width = 85
    End Sub

    ''/////////////////////////////////////////////////////////////////

    Public Function consultaTodoslosEstadosGrid() As Object ''regresa un objeto
        Dim strSQL As String
        Dim xCnx As New Oracle

        Dim columna As Integer
        columna = AgregarCiudades.CiudadesDGV.CurrentCellAddress.Y

        idCiudad = AgregarCiudades.CiudadesDGV.Rows(columna).Cells(0).Value
        'Consulta datos de todas los generos registradas en la tabla
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        'los generos que se han registrado
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'creamos el query para la consulta en sql
        strSQL = "select estados.id_estados, estados.nombre from estados, ciudades
                where estados.id_estados = ciudades.id_estado 
                and ciudades.id_estado =" & idCiudad
        consultaTodoslosEstadosGrid = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridEstadosSeleccionado(ByVal EstadosDGV As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        EstadosDGV.DataSource = consultaTodoslosEstadosGrid()

        'Con el refresh actualiza el contenido del DGV

        EstadosDGV.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        EstadosDGV.Columns.Item(0).Width = 85
        EstadosDGV.Columns.Item(1).Width = 85
    End Sub


End Class


