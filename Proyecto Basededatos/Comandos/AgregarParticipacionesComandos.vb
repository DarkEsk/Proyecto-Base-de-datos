Public Class AgregarParticipacionesComandos
    Private idHorario As String
    Private Fecha As String
    Private Hora As String
    ''Private Minuto As String

    Public Sub New(ByVal Horario_Ho As String, ByVal Fecha_Ho As String,
                    ByVal Hora_Ho As String)
        'le asignamos a nuestras variables locales el id_tec y el tec_nombre
        idHorario = Horario_Ho
        Fecha = Fecha_Ho
        Hora = Hora_Ho
        ''Minuto = Minuto_Ho
    End Sub

    Public Sub New()

    End Sub

    Public Function consultaTodoslosHorarios() As Object ''regresa un objeto
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
        strSQL = "SELECT fecha_participa,hora,id_equipo from participaciones order by id_equipo asc"
        consultaTodoslosHorarios = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridHorarios(ByVal HorarioDGV As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        HorarioDGV.DataSource = consultaTodoslosHorarios()

        'Con el refresh actualiza el contenido del DGV

        HorarioDGV.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        HorarioDGV.Columns.Item(0).Width = 100
        HorarioDGV.Columns.Item(1).Width = 100
    End Sub
    Public Function consultaTodoslosHorariosGrid() As Object ''regresa un objeto
        Dim strSQL As String
        Dim xCnx As New Oracle

        Dim columna As Integer
        columna = AgregarParticipaciones.HorarioDGV.CurrentCellAddress.Y

        idHorario = AgregarParticipaciones.HorarioDGV.Rows(columna).Cells(2).Value

        'Consulta datos de todas los generos registradas en la tabla
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        'los generos que se han registrado
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'creamos el query para la consulta en sql
        strSQL = "select equiposdeportivos.id_tec, equiposdeportivos.nombre from equiposdeportivos, participaciones where equiposdeportivos.id_equipo = participaciones.id_equipo
                 and participaciones.id_equipo =" & idHorario
        consultaTodoslosHorariosGrid = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridHorariosSeleccionados(ByVal equipoDGV As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        equipoDGV.DataSource = consultaTodoslosHorariosGrid()

        'Con el refresh actualiza el contenido del DGV

        equipoDGV.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        equipoDGV.Columns.Item(0).Width = 100
        equipoDGV.Columns.Item(1).Width = 100
    End Sub
    Public Function consultaLosHorariosGrid() As Object ''regresa un objeto
        Dim strSQL As String
        Dim xCnx As New Oracle

        Dim columna As Integer
        columna = AgregarParticipaciones.equipoDGV.CurrentCellAddress.Y

        idHorario = AgregarParticipaciones.equipoDGV.Rows(columna).Cells(0).Value

        'Consulta datos de todas los generos registradas en la tabla
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        'los generos que se han registrado
        '----------------------------------------------------------------------------------
        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        'creamos el query para la consulta en sql
        strSQL = "SELECT participaciones.fecha_participa,participaciones.hora,participaciones.id_equipo
                 from participaciones, equiposdeportivos
                 where participaciones.id_equipo = equiposdeportivos.id_equipo
                 and equiposdeportivos.id_equipo =" & idHorario
        consultaLosHorariosGrid = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridEquiposSeleccionados(ByVal horarioDGV As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        horarioDGV.DataSource = consultaLosHorariosGrid()

        'Con el refresh actualiza el contenido del DGV

        horarioDGV.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        horarioDGV.Columns.Item(0).Width = 100
        horarioDGV.Columns.Item(1).Width = 100
    End Sub

    Public Function consultaidHora() As Boolean 'Regresa un boleano

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

        strSQL = "SELECT * FROM participaciones" &
                 "WHERE Hora ='" & AgregarParticipaciones.TxtHora.Text & "'" ''& AgregarHorario.TxtMinuto.Text & "'"
        'en ves de poner el id pedimos que^^^^ lo traiga del textbox seleccionado
        consultaidHora = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidHora = True
        End If
    End Function

    Public Function consultaTodoslosEquipos() As Object ''regresa un objeto
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
        strSQL = "SELECT id_equipo,nombre from equiposdeportivos order by id_equipo asc"
        consultaTodoslosEquipos = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridEquipos(ByVal equipoDGV As DataGridView) ''regresa el DGV
        'Método que lee todas los tecs
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        equipoDGV.DataSource = consultaTodoslosEquipos()

        'Con el refresh actualiza el contenido del DGV

        equipoDGV.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        equipoDGV.Columns.Item(0).Width = 100
        equipoDGV.Columns.Item(1).Width = 100
    End Sub

    Public Function consultaidHorario() As Boolean 'Regresa un boleano

        'CON ESTE METODO HACEMOS LA CONSULTA DE QUE EL REGISTRO SE ENCUENTRE O NO(SE UTILIZA EN "AGREGAR GENEROS")

        ' Utilizada para obtener el ID del tec seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        Dim fecha As String
        fecha = AgregarParticipaciones.FechaJuego.Value


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM participaciones " &
                 "WHERE id_equipo =" & AgregarParticipaciones.TxtEquipo.Text & "
                 And fecha_participa = '" & fecha.Substring(0, 10) & "'
                 And Hora = '" & AgregarParticipaciones.TxtHora.Text & "'" ''& AgregarHorario.TxtMinuto.Text & "'"
        'en ves de poner el id pedimos que^^^^ lo traiga del textbox seleccionado
        consultaidHorario = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidHorario = True
        End If
    End Function

    Public Function consultaidEquipo() As Boolean 'Regresa un boleano

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

        strSQL = "SELECT * FROM equiposdeportivos " &
                 "WHERE id_equipo =" & AgregarParticipaciones.TxtEquipo.Text & ""

        'en ves de poner el id pedimos que^^^^ lo traiga del textbox seleccionado
        consultaidEquipo = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaidEquipo = True
        End If
    End Function

    Public Sub insertarHorario() 'no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle

        ''hacemos la insercion en la tabla y le pasamos lo que tenga en idtec y tecnombre
        strSql = "INSERT INTO participaciones VALUES(" & idHorario & ",'" & Fecha &
                                                      "','" & Hora & "')"
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub eliminaHorario() 'no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim renglon As Integer

        renglon = AgregarParticipaciones.HorarioDGV.CurrentCellAddress.Y

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido
        Try
            strSql = "delete from participaciones where id_equipo = " & AgregarParticipaciones.HorarioDGV.Rows(renglon).Cells(2).Value &
                "and fecha_participa ='" & AgregarParticipaciones.HorarioDGV.Rows(renglon).Cells(0).Value &
                "' and hora = '" & AgregarParticipaciones.HorarioDGV.Rows(renglon).Cells(1).Value & "'"
            xCnx.objetoCommand(strSql)
            ''mpstramos un mensaje de que se ha eliminado 
            MessageBox.Show("Registro Eliminado")
        Catch ex As Exception
            ''si tiene hijos no se elimnia y se muestra el mensaje
            MessageBox.Show("Este dato contiene referencias, eliminar referencias antes")
        End Try
    End Sub

    Public Sub limpiarHorario() ''no regresa nada 
        ''limpiamos los texbox
        AgregarParticipaciones.TxtEquipo.Clear()
        AgregarParticipaciones.TxtHora.Clear()
        'AgregarHorario.TxtFecha.Clear()

    End Sub

    Public Sub actualizarHorario() ''no regresa nada
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim fecha As String
        fecha = AgregarParticipaciones.FechaJuego.Value

        Dim columna As Integer
        columna = AgregarParticipaciones.HorarioDGV.CurrentCellAddress.Y
        Dim FechaCom As String

        FechaCom = AgregarParticipaciones.HorarioDGV.Rows(columna).Cells(0).Value
        idHorario = AgregarParticipaciones.HorarioDGV.Rows(columna).Cells(2).Value
        Hora = AgregarParticipaciones.HorarioDGV.Rows(columna).Cells(1).Value

        ''hacemos el query donde hacemos el update en sql
        strSql = "update participaciones set id_equipo = " & AgregarParticipaciones.TxtEquipo.Text &
            ",Fecha_participa = '" & fecha.Substring(0, 10) & "', Hora = '" & AgregarParticipaciones.TxtHora.Text & "'
            where id_equipo ='" & idHorario & "' 
            and fecha_participa = '" & FechaCom & "'
            and hora = '" & Hora & "'"
        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub ponerencuadrosHorario()
        'CON ESTE METODO PONEMOS EN EL TXTBOX LO SELECCIONADO EN EL DGV
        Dim columna As Integer
        columna = AgregarParticipaciones.HorarioDGV.CurrentCellAddress.Y
        'EL TXTBOX SERA IGUAL A LO QUE TENGA EL DGV EN ESA CELDA|||
        AgregarParticipaciones.TxtEquipo.Text = AgregarParticipaciones.HorarioDGV.Rows(columna).Cells(2).Value
        AgregarParticipaciones.TxtHora.Text = AgregarParticipaciones.HorarioDGV.Rows(columna).Cells(1).Value
        '' AgregarHorario.TxtMinuto.Text = AgregarHorario.HorarioDGV.Rows(columna).Cells(2).Value
        AgregarParticipaciones.FechaJuego.Text = AgregarParticipaciones.HorarioDGV.Rows(columna).Cells(0).Value

    End Sub
    Public Sub ponerencuadrosHorariot()
        'CON ESTE METODO PONEMOS EN EL TXTBOX LO SELECCIONADO EN EL DGV
        Dim columna As Integer
        columna = AgregarParticipaciones.equipoDGV.CurrentCellAddress.Y
        'EL TXTBOX SERA IGUAL A LO QUE TENGA EL DGV EN ESA CELDA|||
        AgregarParticipaciones.TxtEquipo.Text = AgregarParticipaciones.equipoDGV.Rows(columna).Cells(0).Value

    End Sub
End Class
