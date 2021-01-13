<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarAlumnos))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxIdEquipo = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxPaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxNoControl = New System.Windows.Forms.TextBox()
        Me.TextBoxIdGenero = New System.Windows.Forms.TextBox()
        Me.TextBoxIdCarrera = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxMaterno = New System.Windows.Forms.TextBox()
        Me.DataGridGeneros = New System.Windows.Forms.DataGridView()
        Me.Buttonactualizar = New System.Windows.Forms.Button()
        Me.Buttonguardar = New System.Windows.Forms.Button()
        Me.Buttonnuevo = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.DataGridAlumnos = New System.Windows.Forms.DataGridView()
        Me.DataGridCarreras = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridEquipos = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DataGridGeneros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridCarreras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 429)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 31)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Paterno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 31)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "idEquipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(7, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nombre"
        '
        'TextBoxIdEquipo
        '
        Me.TextBoxIdEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdEquipo.Location = New System.Drawing.Point(151, 296)
        Me.TextBoxIdEquipo.Name = "TextBoxIdEquipo"
        Me.TextBoxIdEquipo.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxIdEquipo.TabIndex = 19
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(151, 366)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxNombre.TabIndex = 18
        '
        'TextBoxPaterno
        '
        Me.TextBoxPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaterno.Location = New System.Drawing.Point(151, 426)
        Me.TextBoxPaterno.Name = "TextBoxPaterno"
        Me.TextBoxPaterno.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxPaterno.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 31)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "idCarrera"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 31)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "idGenero"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label6.Location = New System.Drawing.Point(1, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 31)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "NoControl"
        '
        'TextBoxNoControl
        '
        Me.TextBoxNoControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNoControl.Location = New System.Drawing.Point(151, 95)
        Me.TextBoxNoControl.Name = "TextBoxNoControl"
        Me.TextBoxNoControl.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxNoControl.TabIndex = 25
        '
        'TextBoxIdGenero
        '
        Me.TextBoxIdGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdGenero.Location = New System.Drawing.Point(151, 165)
        Me.TextBoxIdGenero.Name = "TextBoxIdGenero"
        Me.TextBoxIdGenero.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxIdGenero.TabIndex = 24
        '
        'TextBoxIdCarrera
        '
        Me.TextBoxIdCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdCarrera.Location = New System.Drawing.Point(151, 235)
        Me.TextBoxIdCarrera.Name = "TextBoxIdCarrera"
        Me.TextBoxIdCarrera.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxIdCarrera.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 486)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 31)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Materno"
        '
        'TextBoxMaterno
        '
        Me.TextBoxMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMaterno.Location = New System.Drawing.Point(151, 479)
        Me.TextBoxMaterno.Name = "TextBoxMaterno"
        Me.TextBoxMaterno.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxMaterno.TabIndex = 29
        '
        'DataGridGeneros
        '
        Me.DataGridGeneros.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridGeneros.Location = New System.Drawing.Point(425, 234)
        Me.DataGridGeneros.Name = "DataGridGeneros"
        Me.DataGridGeneros.Size = New System.Drawing.Size(341, 140)
        Me.DataGridGeneros.TabIndex = 31
        '
        'Buttonactualizar
        '
        Me.Buttonactualizar.Location = New System.Drawing.Point(130, 537)
        Me.Buttonactualizar.Name = "Buttonactualizar"
        Me.Buttonactualizar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonactualizar.TabIndex = 35
        Me.Buttonactualizar.Text = "Actualizar"
        Me.Buttonactualizar.UseVisualStyleBackColor = True
        '
        'Buttonguardar
        '
        Me.Buttonguardar.Location = New System.Drawing.Point(292, 537)
        Me.Buttonguardar.Name = "Buttonguardar"
        Me.Buttonguardar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonguardar.TabIndex = 34
        Me.Buttonguardar.Text = "Guardar"
        Me.Buttonguardar.UseVisualStyleBackColor = True
        '
        'Buttonnuevo
        '
        Me.Buttonnuevo.Location = New System.Drawing.Point(49, 537)
        Me.Buttonnuevo.Name = "Buttonnuevo"
        Me.Buttonnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Buttonnuevo.TabIndex = 33
        Me.Buttonnuevo.Text = "Nuevo"
        Me.Buttonnuevo.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(211, 537)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 32
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'DataGridAlumnos
        '
        Me.DataGridAlumnos.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAlumnos.Location = New System.Drawing.Point(425, 45)
        Me.DataGridAlumnos.Name = "DataGridAlumnos"
        Me.DataGridAlumnos.Size = New System.Drawing.Size(341, 140)
        Me.DataGridAlumnos.TabIndex = 36
        '
        'DataGridCarreras
        '
        Me.DataGridCarreras.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCarreras.Location = New System.Drawing.Point(425, 430)
        Me.DataGridCarreras.Name = "DataGridCarreras"
        Me.DataGridCarreras.Size = New System.Drawing.Size(341, 140)
        Me.DataGridCarreras.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label8.Location = New System.Drawing.Point(419, 396)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(243, 31)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Registros Carreras"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label9.Location = New System.Drawing.Point(419, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(241, 31)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Registros Generos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label10.Location = New System.Drawing.Point(419, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(242, 31)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Registros Alumnos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label11.Location = New System.Drawing.Point(41, 563)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(235, 31)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Registros Equipos"
        '
        'DataGridEquipos
        '
        Me.DataGridEquipos.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEquipos.Location = New System.Drawing.Point(47, 597)
        Me.DataGridEquipos.Name = "DataGridEquipos"
        Me.DataGridEquipos.Size = New System.Drawing.Size(341, 140)
        Me.DataGridEquipos.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(396, 55)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Agregar Alumnos"
        '
        'AgregarAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridEquipos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridCarreras)
        Me.Controls.Add(Me.DataGridAlumnos)
        Me.Controls.Add(Me.Buttonactualizar)
        Me.Controls.Add(Me.Buttonguardar)
        Me.Controls.Add(Me.Buttonnuevo)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.DataGridGeneros)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxMaterno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxNoControl)
        Me.Controls.Add(Me.TextBoxIdGenero)
        Me.Controls.Add(Me.TextBoxIdCarrera)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxIdEquipo)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxPaterno)
        Me.Name = "AgregarAlumnos"
        Me.Text = "AgregarAlumnos"
        CType(Me.DataGridGeneros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridCarreras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxIdEquipo As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxPaterno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNoControl As TextBox
    Friend WithEvents TextBoxIdGenero As TextBox
    Friend WithEvents TextBoxIdCarrera As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxMaterno As TextBox
    Friend WithEvents DataGridGeneros As DataGridView
    Friend WithEvents Buttonactualizar As Button
    Friend WithEvents Buttonguardar As Button
    Friend WithEvents Buttonnuevo As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents DataGridAlumnos As DataGridView
    Friend WithEvents DataGridCarreras As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridEquipos As DataGridView
    Friend WithEvents Label12 As Label
End Class
