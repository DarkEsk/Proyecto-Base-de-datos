<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEntrenadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarEntrenadores))
        Me.Buttonactualizar = New System.Windows.Forms.Button()
        Me.Buttonguardar = New System.Windows.Forms.Button()
        Me.Buttonnuevo = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.DataGridEntrenadores = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxEntrenador = New System.Windows.Forms.TextBox()
        Me.TextBoxIdGenero = New System.Windows.Forms.TextBox()
        Me.TextBoxDepartamento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxMaterno = New System.Windows.Forms.TextBox()
        Me.TextBoxPaterno = New System.Windows.Forms.TextBox()
        Me.DataGridGeneros = New System.Windows.Forms.DataGridView()
        Me.DataGridDepartamentos = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridEntrenadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridGeneros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttonactualizar
        '
        Me.Buttonactualizar.Location = New System.Drawing.Point(161, 511)
        Me.Buttonactualizar.Name = "Buttonactualizar"
        Me.Buttonactualizar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonactualizar.TabIndex = 54
        Me.Buttonactualizar.Text = "Actualizar"
        Me.Buttonactualizar.UseVisualStyleBackColor = True
        '
        'Buttonguardar
        '
        Me.Buttonguardar.Location = New System.Drawing.Point(323, 511)
        Me.Buttonguardar.Name = "Buttonguardar"
        Me.Buttonguardar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonguardar.TabIndex = 53
        Me.Buttonguardar.Text = "Guardar"
        Me.Buttonguardar.UseVisualStyleBackColor = True
        '
        'Buttonnuevo
        '
        Me.Buttonnuevo.Location = New System.Drawing.Point(80, 511)
        Me.Buttonnuevo.Name = "Buttonnuevo"
        Me.Buttonnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Buttonnuevo.TabIndex = 52
        Me.Buttonnuevo.Text = "Nuevo"
        Me.Buttonnuevo.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(242, 511)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 51
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'DataGridEntrenadores
        '
        Me.DataGridEntrenadores.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEntrenadores.Location = New System.Drawing.Point(447, 37)
        Me.DataGridEntrenadores.Name = "DataGridEntrenadores"
        Me.DataGridEntrenadores.Size = New System.Drawing.Size(341, 127)
        Me.DataGridEntrenadores.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 31)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "idDepartamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 31)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "idGenero"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label6.Location = New System.Drawing.Point(10, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 31)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "idEntrenador"
        '
        'TextBoxEntrenador
        '
        Me.TextBoxEntrenador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEntrenador.Location = New System.Drawing.Point(185, 88)
        Me.TextBoxEntrenador.Name = "TextBoxEntrenador"
        Me.TextBoxEntrenador.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxEntrenador.TabIndex = 44
        '
        'TextBoxIdGenero
        '
        Me.TextBoxIdGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdGenero.Location = New System.Drawing.Point(185, 158)
        Me.TextBoxIdGenero.Name = "TextBoxIdGenero"
        Me.TextBoxIdGenero.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxIdGenero.TabIndex = 43
        '
        'TextBoxDepartamento
        '
        Me.TextBoxDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDepartamento.Location = New System.Drawing.Point(223, 228)
        Me.TextBoxDepartamento.Name = "TextBoxDepartamento"
        Me.TextBoxDepartamento.Size = New System.Drawing.Size(202, 38)
        Me.TextBoxDepartamento.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 31)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Paterno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 31)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Materno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(69, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nombre"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(185, 289)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxNombre.TabIndex = 38
        '
        'TextBoxMaterno
        '
        Me.TextBoxMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMaterno.Location = New System.Drawing.Point(185, 419)
        Me.TextBoxMaterno.Name = "TextBoxMaterno"
        Me.TextBoxMaterno.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxMaterno.TabIndex = 37
        '
        'TextBoxPaterno
        '
        Me.TextBoxPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaterno.Location = New System.Drawing.Point(185, 359)
        Me.TextBoxPaterno.Name = "TextBoxPaterno"
        Me.TextBoxPaterno.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxPaterno.TabIndex = 36
        '
        'DataGridGeneros
        '
        Me.DataGridGeneros.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridGeneros.Location = New System.Drawing.Point(447, 212)
        Me.DataGridGeneros.Name = "DataGridGeneros"
        Me.DataGridGeneros.Size = New System.Drawing.Size(341, 127)
        Me.DataGridGeneros.TabIndex = 55
        '
        'DataGridDepartamentos
        '
        Me.DataGridDepartamentos.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDepartamentos.Location = New System.Drawing.Point(447, 395)
        Me.DataGridDepartamentos.Name = "DataGridDepartamentos"
        Me.DataGridDepartamentos.Size = New System.Drawing.Size(341, 127)
        Me.DataGridDepartamentos.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(441, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(309, 31)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Registro Departamentos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(441, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(286, 31)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Registro Entrenadores"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(441, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(227, 31)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Registro Generos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-7, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(448, 55)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Agregar Entrenador"
        '
        'AgregarEntrenadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 534)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridDepartamentos)
        Me.Controls.Add(Me.DataGridGeneros)
        Me.Controls.Add(Me.Buttonactualizar)
        Me.Controls.Add(Me.Buttonguardar)
        Me.Controls.Add(Me.Buttonnuevo)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.DataGridEntrenadores)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxEntrenador)
        Me.Controls.Add(Me.TextBoxIdGenero)
        Me.Controls.Add(Me.TextBoxDepartamento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxMaterno)
        Me.Controls.Add(Me.TextBoxPaterno)
        Me.Name = "AgregarEntrenadores"
        Me.Text = "AgregarEntrenadores"
        CType(Me.DataGridEntrenadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridGeneros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buttonactualizar As Button
    Friend WithEvents Buttonguardar As Button
    Friend WithEvents Buttonnuevo As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents DataGridEntrenadores As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxEntrenador As TextBox
    Friend WithEvents TextBoxIdGenero As TextBox
    Friend WithEvents TextBoxDepartamento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxMaterno As TextBox
    Friend WithEvents TextBoxPaterno As TextBox
    Friend WithEvents DataGridGeneros As DataGridView
    Friend WithEvents DataGridDepartamentos As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
