Imports Oracle.DataAccess.Client
Public Class AgregarTeccomandos
    ''creamos las variables que estamos utilizando donde guardamos el idtec y el nombre del tec
    Private idtec As String
    Private tecnombre As String
    Private idestado As String
    Private CP As String
    Private calle As String
    Private Telefono As String
    Private idciudad As String

    Public Sub New(ByVal id_tec As String, ByVal tec_nombre As String,
                   ByVal id_estado As String, ByVal CP As String,
                   ByVal calle As String, ByVal telefono As String,
                   ByVal ciudad As String)
        'le asignamos a nuestras variables locales el id_tec y el tec_nombre
        idtec = id_tec
        tecnombre = tec_nombre
        idestado = id_estado
        CP = CP
        calle = calle
        telefono = telefono
        idciudad = ciudad

    End Sub

    Public Sub New()

    End Sub


    Public Function consultaTodoslostec() As Object ''regresa un objeto
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los tecs registradas en la tabla
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        'los tecs que se han registrado
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'creamos el query para la consulta en sql
        strSQL = "SELECT * from tecsnm order by id_tec asc"
        consultaTodoslostec = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridtec(ByVal GDValumnos As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDValumnos.DataSource = consultaTodoslostec()

        'Con el refresh actualiza el contenido del DGV

        GDValumnos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDValumnos.Columns.Item(0).Width = 50
        GDValumnos.Columns.Item(1).Width = 100
    End Sub
    Public Function consultaTodoslostecGrid() As Object ''regresa un objeto
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim estados As String
        estados = AgregarTec.TextBoxEstado.Text
        'Dim renglon As Integer

        'renglon = AgregarCarrera.CarrerasDGV.CurrentCellAddress.Y

        'Consulta datos de todas los tecs registradas en la tabla
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        'los tecs que se han registrado
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'creamos el query para la consulta en sql
        strSQL = "select tecsnm.id_tec, tecsnm.nombre from tecsnm, estados where tecsnm.id_estado = estados.nombre 
                and estados.nombre = '" & estados & "'"
        consultaTodoslostecGrid = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridtecSeleccionado(ByVal DataGridtec As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DataGridtec.DataSource = consultaTodoslostecGrid()

        'Con el refresh actualiza el contenido del DGV

        DataGridtec.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DataGridtec.Columns.Item(0).Width = 50
        DataGridtec.Columns.Item(1).Width = 100
    End Sub

    Public Function consultaTodoslosEstadosGrid() As Object ''regresa un objeto
        Dim strSQL As String
        Dim xCnx As New Oracle


        'Consulta datos de todas los tecs registradas en la tabla
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        'los tecs que se han registrado
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'creamos el query para la consulta en sql
        strSQL = "select estados.id_estados, estados.nombre from estados, tecsnm where estados.nombre = tecsnm.id_estado 
                    and tecsnm.id_tec =" & AgregarTec.TextBox1.Text
        consultaTodoslosEstadosGrid = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGriEstadoSeleccionado(ByVal DGVestados As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVestados.DataSource = consultaTodoslosEstadosGrid()

        'Con el refresh actualiza el contenido del DGV

        DGVestados.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVestados.Columns.Item(0).Width = 50
        DGVestados.Columns.Item(1).Width = 100
    End Sub
    Public Function consultaTodoslosEstados() As Object ''regresa un objeto
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los tecs registradas en la tabla
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        'los tecs que se han registrado
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'creamos el query para la consulta en sql
        strSQL = "SELECT * from estados order by id_estados asc"
        consultaTodoslosEstados = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridEstados(ByVal DGVestados As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVestados.DataSource = consultaTodoslosEstados()

        'Con el refresh actualiza el contenido del DGV

        DGVestados.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVestados.Columns.Item(0).Width = 50
        DGVestados.Columns.Item(1).Width = 100
    End Sub

    Public Function consultaTodoslasCiudades() As Object ''regresa un objeto
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los tecs registradas en la tabla
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        'los tecs que se han registrado
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'creamos el query para la consulta en sql
        strSQL = "SELECT * from ciudades order by id_ciudad asc"
        consultaTodoslasCiudades = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridCiudades(ByVal DGVciudades As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVciudades.DataSource = consultaTodoslasCiudades()

        'Con el refresh actualiza el contenido del DGV

        DGVciudades.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVciudades.Columns.Item(0).Width = 50
        DGVciudades.Columns.Item(1).Width = 100
    End Sub
    Public Sub poblarComboEstados(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle
        'Ejemplo para llenar un combo con información, se recibe como 
        ' parámetro el nombre del combo

        strSql = "SELECT nombre FROM estados Order By nombre asc"
        Lista = xCnx.objetoDataReader(strSql)

        'Limpia el contenido del combo, para ser rellendo
        objeto.Items.Clear()

        'Con el while le coloca los renglones encontrados al combo
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Sub poblarComboCiudades(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle
        'Ejemplo para llenar un combo con información, se recibe como 
        ' parámetro el nombre del combo

        strSql = "SELECT nombre FROM ciudades Order By nombre asc"
        Lista = xCnx.objetoDataReader(strSql)

        'Limpia el contenido del combo, para ser rellendo
        objeto.Items.Clear()

        'Con el while le coloca los renglones encontrados al combo
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Sub poblarComboCiudadesConEstados(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle
        'Ejemplo para llenar un combo con información, se recibe como 
        ' parámetro el nombre del combo

        strSql = "select ciudades.nombre from estados,
                ciudades where estados.id_estados = ciudades.id_estado 
                And estados.nombre = '" & AgregarTec.TextBoxEstado.Text & "'"
        Lista = xCnx.objetoDataReader(strSql)

        'Limpia el contenido del combo, para ser rellendo
        objeto.Items.Clear()

        'Con el while le coloca los renglones encontrados al combo
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub
    Public Function consultaidtec() As Boolean 'Regresa un boleano

        ' Utilizada para obtener el ID del tec seleccionado, ejemplo para cuando
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
        'en ves de poner el id pedimos que^^^^ lo traiga del textbox seleccionado
        consultaidtec = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidtec = True
        End If
    End Function

    Public Sub insertatec() 'no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle

        ''hacemos la insercion en la tabla y le pasamos lo que tenga en idtec y tecnombre
        strSql = "INSERT INTO tecsnm VALUES(" & AgregarTec.TextBox1.Text &
            ",'" & AgregarTec.TextBox2.Text &
            "','" & AgregarTec.TextBoxEstado.Text &
            "','" & AgregarTec.TxtCP.Text &
            "','" & AgregarTec.TxtCalle.Text &
            "',' " & AgregarTec.TxtTelefono.Text & "')"
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub eliminatec() 'no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = AgregarTec.DataGridtec.CurrentCellAddress.Y

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        Try
            strSql = "delete from tecsnm where id_tec = " & AgregarTec.DataGridtec.Rows(renglon).Cells(0).Value
            xCnx.objetoCommand(strSql)
            ''mpstramos un mensaje de que se ha eliminado 
            MessageBox.Show("Registro Eliminado")
        Catch ex As Exception
            ''si tiene hijos no se elimnia y se muestra el mensaje
            MessageBox.Show("Este dato contiene referencias, eliminar referencias antes")
        End Try
    End Sub

    Public Sub limpiar() ''no regresa nada 
        ''limpiamos los texbox
        AgregarTec.TextBox1.Clear()
        AgregarTec.TextBox2.Clear()
        AgregarTec.TextBoxEstado.Clear()
        AgregarTec.TxtCalle.Clear()
        AgregarTec.TxtCP.Clear()
        AgregarTec.TxtTelefono.Clear()
    End Sub

    Public Sub actualizar() ''no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle

        'hacemos el query donde hacemos el update en sql
        strSql = "update tecsnm 
	             set id_tec =" & AgregarTec.TextBox1.Text & "
	            ,nombre = '" & AgregarTec.TextBox2.Text & "',
                id_estados = '" & AgregarTec.TextBoxEstado.Text & "', 
                CP = '" & AgregarTec.TxtCP.Text & "', 
               calle = '" & AgregarTec.TxtCalle.Text & "'
	           ,telefono = '" & AgregarTec.TxtTelefono.Text & "'
                where id_tec = " & AgregarTec.TextBox1.Text

        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub ponerencuadros()
        Dim columna As Integer
        columna = AgregarTec.DataGridtec.CurrentCellAddress.Y
        AgregarTec.TextBox1.Text = AgregarTec.DataGridtec.Rows(columna).Cells(0).Value
        AgregarTec.TextBox2.Text = AgregarTec.DataGridtec.Rows(columna).Cells(1).Value
        AgregarTec.TextBoxEstado.Text = AgregarTec.DataGridtec.Rows(columna).Cells(2).Value
        AgregarTec.TxtCP.Text = AgregarTec.DataGridtec.Rows(columna).Cells(3).Value
        AgregarTec.TxtCalle.Text = AgregarTec.DataGridtec.Rows(columna).Cells(4).Value
        AgregarTec.TxtTelefono.Text = AgregarTec.DataGridtec.Rows(columna).Cells(5).Value
    End Sub

End Class
