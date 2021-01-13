Public Class AgregarEstadosComandos
    Public idEstado As Integer
    Public miEstado As String
    Public nombre As String
    Public idGenero As String

    Public Sub New()
        'Si tus variables son de otro tipo (numeric,Integer, etc) tendrías que iniciarlas en 0
        idEstado = 0
        nombre = ""
    End Sub


    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal nuevoId As Integer, ByVal nuevoNombre As String)
        'Aquí recibimos los datos
        idEstado = nuevoId
        nombre = nuevoNombre
    End Sub

    'Metodos get y set
    Public Property getSetidEstado() As Integer
        Get
            Return idEstado
        End Get
        Set(ByVal Value As Integer)
            idEstado = Value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal Value As String)
            nombre = Value
        End Set
    End Property

    'Inserta nueva ciudad en la tabla correspondiente
    'la tabla tiene 4 atributos, por lo tanto se requieren de 4 valores
    Public Sub insertaEstado()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If idEstado <> 0 And nombre <> "" Then
            'Realiza inserción de datos

            strSql = "INSERT INTO estados VALUES(" & idEstado & ", '" & nombre & "')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje 
            MsgBox("Faltan datos por ingresar", MsgBoxStyle.Critical, "ATENCIÓN")
        End If
    End Sub

    'Actualiza datos de una ciudad específica
    Public Sub actualizaEstado()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idEstado <> 0 And nombre <> "" Then

            'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
            ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
            ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

            strSql = "UPDATE estados set nombre='" & nombre &
                     "' WHERE id_estados =" & idEstado
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos por ingresar", MsgBoxStyle.Critical, "ATENCIÓN")
        End If
    End Sub

    Public Function consultaUnEstado() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_estados, nombre " &
                 " FROM estados " &
                 "WHERE id_estados =" & AgregarEstados.Txt_idEstado.Text
        consultaUnEstado = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_estados")) Then
                idEstado = 0
            Else
                idEstado = CStr(xDT.Rows(0)("id_estados"))
                AgregarEstados.Txt_nombre.Text = CStr(xDT.Rows(0)("nombre"))
            End If
            consultaUnEstado = True
        End If
    End Function

    Public Function consultaTodosCd() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT id_estados as ID, nombre as nombre " &
               " FROM estados ORDER BY nombre asc"

        consultaTodosCd = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridCd(ByVal DGVtecsNM As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVtecsNM.DataSource = consultaTodosCd()

        'Con el refresh actualiza el contenido del DGV

        DGVtecsNM.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVtecsNM.Columns.Item(0).Width = 200
        DGVtecsNM.Columns.Item(1).Width = 900
    End Sub

    Public Function validaTecs() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        'el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        'cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM TecsNM " &
                 " WHERE id_estados = " & AgregarEstados.Txt_idEstado.Text
        validaTecs = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            If IsDBNull(xDT.Rows(0)("id_estados")) Then
                idGenero = 0
            Else
                miEstado = CStr(xDT.Rows(0)("id_estados"))
            End If
            validaTecs = True
        End If
    End Function

    Public Sub eliminaEstado()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        If idEstado <> 0 And nombre <> "" Then
            strSql = "DELETE FROM estados " &
                     " where id_estados = " & AgregarEstados.Txt_idEstado.Text

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos por asignar", MsgBoxStyle.Critical, "ATENCIÓN")
        End If
    End Sub

End Class