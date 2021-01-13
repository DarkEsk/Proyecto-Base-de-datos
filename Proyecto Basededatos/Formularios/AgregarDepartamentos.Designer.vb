<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarDepartamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarDepartamentos))
        Me.Buttonactualizar = New System.Windows.Forms.Button()
        Me.Buttonguardar = New System.Windows.Forms.Button()
        Me.Buttonnuevo = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.DataGridDepartamentos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDepartamentos = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.TextBoxTec = New System.Windows.Forms.TextBox()
        Me.DataGridTec = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxEstados = New System.Windows.Forms.TextBox()
        Me.DataGridEstados = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridTec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttonactualizar
        '
        Me.Buttonactualizar.Location = New System.Drawing.Point(144, 306)
        Me.Buttonactualizar.Name = "Buttonactualizar"
        Me.Buttonactualizar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonactualizar.TabIndex = 32
        Me.Buttonactualizar.Text = "Actualizar"
        Me.Buttonactualizar.UseVisualStyleBackColor = True
        '
        'Buttonguardar
        '
        Me.Buttonguardar.Location = New System.Drawing.Point(306, 306)
        Me.Buttonguardar.Name = "Buttonguardar"
        Me.Buttonguardar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonguardar.TabIndex = 31
        Me.Buttonguardar.Text = "Guardar"
        Me.Buttonguardar.UseVisualStyleBackColor = True
        '
        'Buttonnuevo
        '
        Me.Buttonnuevo.Location = New System.Drawing.Point(63, 306)
        Me.Buttonnuevo.Name = "Buttonnuevo"
        Me.Buttonnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Buttonnuevo.TabIndex = 30
        Me.Buttonnuevo.Text = "Nuevo"
        Me.Buttonnuevo.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(225, 306)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 29
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'DataGridDepartamentos
        '
        Me.DataGridDepartamentos.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDepartamentos.Location = New System.Drawing.Point(485, 112)
        Me.DataGridDepartamentos.Name = "DataGridDepartamentos"
        Me.DataGridDepartamentos.Size = New System.Drawing.Size(378, 163)
        Me.DataGridDepartamentos.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 31)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "idTec"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 31)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(5, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 31)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "IdDepartamento"
        '
        'TextBoxDepartamentos
        '
        Me.TextBoxDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDepartamentos.Location = New System.Drawing.Point(225, 79)
        Me.TextBoxDepartamentos.Name = "TextBoxDepartamentos"
        Me.TextBoxDepartamentos.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxDepartamentos.TabIndex = 24
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(225, 132)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxDescripcion.TabIndex = 23
        '
        'TextBoxTec
        '
        Me.TextBoxTec.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTec.Location = New System.Drawing.Point(225, 186)
        Me.TextBoxTec.Name = "TextBoxTec"
        Me.TextBoxTec.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxTec.TabIndex = 22
        '
        'DataGridTec
        '
        Me.DataGridTec.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridTec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTec.Location = New System.Drawing.Point(485, 326)
        Me.DataGridTec.Name = "DataGridTec"
        Me.DataGridTec.Size = New System.Drawing.Size(378, 163)
        Me.DataGridTec.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label4.Location = New System.Drawing.Point(479, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 31)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Registros Tec"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label5.Location = New System.Drawing.Point(479, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(323, 31)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Registros Departamentos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(99, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 31)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "idEstado"
        '
        'TextBoxEstados
        '
        Me.TextBoxEstados.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEstados.Location = New System.Drawing.Point(225, 241)
        Me.TextBoxEstados.Name = "TextBoxEstados"
        Me.TextBoxEstados.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxEstados.TabIndex = 36
        '
        'DataGridEstados
        '
        Me.DataGridEstados.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEstados.Location = New System.Drawing.Point(43, 395)
        Me.DataGridEstados.Name = "DataGridEstados"
        Me.DataGridEstados.Size = New System.Drawing.Size(378, 163)
        Me.DataGridEstados.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label7.Location = New System.Drawing.Point(37, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(236, 31)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Registros Estados"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(539, 55)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Agregar Departamentos"
        '
        'AgregarDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(875, 578)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridEstados)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxEstados)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridTec)
        Me.Controls.Add(Me.Buttonactualizar)
        Me.Controls.Add(Me.Buttonguardar)
        Me.Controls.Add(Me.Buttonnuevo)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.DataGridDepartamentos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDepartamentos)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.TextBoxTec)
        Me.Name = "AgregarDepartamentos"
        Me.Text = "AgregarDepartamentos"
        CType(Me.DataGridDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridTec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridEstados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buttonactualizar As Button
    Friend WithEvents Buttonguardar As Button
    Friend WithEvents Buttonnuevo As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents DataGridDepartamentos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDepartamentos As TextBox
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents TextBoxTec As TextBox
    Friend WithEvents DataGridTec As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxEstados As TextBox
    Friend WithEvents DataGridEstados As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
