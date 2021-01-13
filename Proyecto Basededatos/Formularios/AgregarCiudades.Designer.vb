<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCiudades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarCiudades))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdEstado = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EstadosDGV = New System.Windows.Forms.DataGridView()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtIdCiudad = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.CiudadesDGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.EstadosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(426, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 25)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Registros Estados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(426, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 25)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Registros Ciudades"
        '
        'TxtIdEstado
        '
        Me.TxtIdEstado.Location = New System.Drawing.Point(143, 200)
        Me.TxtIdEstado.Multiline = True
        Me.TxtIdEstado.Name = "TxtIdEstado"
        Me.TxtIdEstado.Size = New System.Drawing.Size(137, 25)
        Me.TxtIdEstado.TabIndex = 31
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(143, 160)
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(137, 25)
        Me.TxtNombre.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "idEstado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Nombre"
        '
        'EstadosDGV
        '
        Me.EstadosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstadosDGV.Location = New System.Drawing.Point(431, 247)
        Me.EstadosDGV.Name = "EstadosDGV"
        Me.EstadosDGV.Size = New System.Drawing.Size(267, 150)
        Me.EstadosDGV.TabIndex = 38
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(98, 283)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(66, 27)
        Me.BtnActualizar.TabIndex = 35
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(170, 283)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(66, 27)
        Me.BtnEliminar.TabIndex = 34
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(242, 283)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(66, 27)
        Me.BtnAgregar.TabIndex = 33
        Me.BtnAgregar.Text = "Guardar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtIdCiudad
        '
        Me.TxtIdCiudad.Location = New System.Drawing.Point(143, 115)
        Me.TxtIdCiudad.Multiline = True
        Me.TxtIdCiudad.Name = "TxtIdCiudad"
        Me.TxtIdCiudad.Size = New System.Drawing.Size(137, 25)
        Me.TxtIdCiudad.TabIndex = 29
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(20, 283)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(66, 27)
        Me.BtnLimpiar.TabIndex = 32
        Me.BtnLimpiar.Text = "Nuevo"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'CiudadesDGV
        '
        Me.CiudadesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CiudadesDGV.Location = New System.Drawing.Point(431, 37)
        Me.CiudadesDGV.Name = "CiudadesDGV"
        Me.CiudadesDGV.Size = New System.Drawing.Size(267, 150)
        Me.CiudadesDGV.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "idCiudad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(413, 55)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Agregar Ciudades"
        '
        'AgregarCiudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(757, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtIdEstado)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EstadosDGV)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtIdCiudad)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.CiudadesDGV)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarCiudades"
        Me.Text = "AgregarCiudades"
        CType(Me.EstadosDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdEstado As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EstadosDGV As DataGridView
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtIdCiudad As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents CiudadesDGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
