Public Class AgregarGenerosComandos
    Private idgenero As String
    Private GenNombre As String

    Public Sub New(ByVal id_genero As String, ByVal gen_nombre As String)
        'le asignamos a nuestras variables locales el id_tec y el tec_nombre
        idgenero = id_genero
        GenNombre = gen_nombre
    End Sub

    Public Sub New()

    End Sub

    Public Function consultaTodoslosGeneros() As Object ''regresa un objeto
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
        strSQL = "SELECT * from generos order by id_genero asc"
        consultaTodoslosGeneros = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridGenero(ByVal GenerosDGV As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GenerosDGV.DataSource = consultaTodoslosGeneros()

        'Con el refresh actualiza el contenido del DGV

        GenerosDGV.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GenerosDGV.Columns.Item(0).Width = 200
        GenerosDGV.Columns.Item(1).Width = 900
    End Sub

    Public Function consultaidGeneros() As Boolean 'Regresa un boleano

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

        strSQL = "SELECT * FROM generos " &
                 "WHERE id_genero ='" & Generos.TxtIdGenero.Text & "'"
        'en ves de poner el id pedimos que^^^^ lo traiga del textbox seleccionado
        consultaidGeneros = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidGeneros = True
        End If
    End Function

    Public Sub insertarGenero() 'no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle

        ''hacemos la insercion en la tabla y le pasamos lo que tenga en idtec y tecnombre
        strSql = "INSERT INTO generos VALUES(" & idgenero & ",'" & GenNombre & "')"
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub eliminaGenero() 'no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = Generos.GenerosDGV.CurrentCellAddress.Y

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        Try
            strSql = "delete from generos where id_genero = " & Generos.GenerosDGV.Rows(renglon).Cells(0).Value
            xCnx.objetoCommand(strSql)
            ''mpstramos un mensaje de que se ha eliminado 
            MessageBox.Show("Registro Eliminado")
        Catch ex As Exception
            ''si tiene hijos no se elimnia y se muestra el mensaje
            MessageBox.Show("Este dato contiene referencias, eliminar referencias antes")
        End Try
    End Sub

    Public Sub limpiarGenero() ''no regresa nada 
        ''limpiamos los texbox
        Generos.TxtIdGenero.Clear()
        Generos.TxtGenero.Clear()

    End Sub

    Public Sub actualizarGenero() ''no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle

        'hacemos el query donde hacemos el update en sql
        strSql = "update generos 
	            set id_genero = " & idgenero & "
	            ,descripcion = '" & GenNombre & "' 
                 where id_genero=" & idgenero
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub ponerencuadros()
        'CON ESTE METODO PONEMOS EN EL TXTBOX LO SELECCIONADO EN EL DGV
        Dim columna As Integer
        columna = Generos.GenerosDGV.CurrentCellAddress.Y
        'EL TXTBOX SERA IGUAL A LO QUE TENGA EL DGV EN ESA CELDA|||
        Generos.TxtIdGenero.Text = Generos.GenerosDGV.Rows(columna).Cells(0).Value
        Generos.TxtGenero.Text = Generos.GenerosDGV.Rows(columna).Cells(1).Value
    End Sub



End Class
