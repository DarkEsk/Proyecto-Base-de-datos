<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEquiposDeportivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarEquiposDeportivos))
        Me.Buttonactualizar = New System.Windows.Forms.Button()
        Me.Buttonguardar = New System.Windows.Forms.Button()
        Me.Buttonnuevo = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.DataGridEntrenadores = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEquipo = New System.Windows.Forms.TextBox()
        Me.TextBoxEntrenador = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxTec = New System.Windows.Forms.TextBox()
        Me.DataGridEquipos = New System.Windows.Forms.DataGridView()
        Me.DataGridTec = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridEntrenadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridTec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttonactualizar
        '
        Me.Buttonactualizar.Location = New System.Drawing.Point(145, 373)
        Me.Buttonactualizar.Name = "Buttonactualizar"
        Me.Buttonactualizar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonactualizar.TabIndex = 32
        Me.Buttonactualizar.Text = "Actualizar"
        Me.Buttonactualizar.UseVisualStyleBackColor = True
        '
        'Buttonguardar
        '
        Me.Buttonguardar.Location = New System.Drawing.Point(307, 373)
        Me.Buttonguardar.Name = "Buttonguardar"
        Me.Buttonguardar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonguardar.TabIndex = 31
        Me.Buttonguardar.Text = "Guardar"
        Me.Buttonguardar.UseVisualStyleBackColor = True
        '
        'Buttonnuevo
        '
        Me.Buttonnuevo.Location = New System.Drawing.Point(64, 373)
        Me.Buttonnuevo.Name = "Buttonnuevo"
        Me.Buttonnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Buttonnuevo.TabIndex = 30
        Me.Buttonnuevo.Text = "Nuevo"
        Me.Buttonnuevo.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(226, 373)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 29
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'DataGridEntrenadores
        '
        Me.DataGridEntrenadores.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEntrenadores.Location = New System.Drawing.Point(404, 244)
        Me.DataGridEntrenadores.Name = "DataGridEntrenadores"
        Me.DataGridEntrenadores.Size = New System.Drawing.Size(370, 146)
        Me.DataGridEntrenadores.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 31)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 31)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "IdEntrenador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(16, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 31)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "IdEquipo"
        '
        'TextBoxEquipo
        '
        Me.TextBoxEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEquipo.Location = New System.Drawing.Point(145, 86)
        Me.TextBoxEquipo.Name = "TextBoxEquipo"
        Me.TextBoxEquipo.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxEquipo.TabIndex = 24
        '
        'TextBoxEntrenador
        '
        Me.TextBoxEntrenador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEntrenador.Location = New System.Drawing.Point(193, 156)
        Me.TextBoxEntrenador.Name = "TextBoxEntrenador"
        Me.TextBoxEntrenador.Size = New System.Drawing.Size(189, 38)
        Me.TextBoxEntrenador.TabIndex = 23
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(145, 226)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxNombre.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 31)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "idTec"
        '
        'TextBoxTec
        '
        Me.TextBoxTec.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTec.Location = New System.Drawing.Point(145, 287)
        Me.TextBoxTec.Name = "TextBoxTec"
        Me.TextBoxTec.Size = New System.Drawing.Size(240, 38)
        Me.TextBoxTec.TabIndex = 33
        '
        'DataGridEquipos
        '
        Me.DataGridEquipos.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEquipos.Location = New System.Drawing.Point(404, 54)
        Me.DataGridEquipos.Name = "DataGridEquipos"
        Me.DataGridEquipos.Size = New System.Drawing.Size(370, 146)
        Me.DataGridEquipos.TabIndex = 35
        '
        'DataGridTec
        '
        Me.DataGridTec.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridTec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTec.Location = New System.Drawing.Point(404, 442)
        Me.DataGridTec.Name = "DataGridTec"
        Me.DataGridTec.Size = New System.Drawing.Size(370, 146)
        Me.DataGridTec.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(398, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 31)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Registros Equipos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(398, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(300, 31)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Registros Entrenadores"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(398, 408)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 31)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Registros Tec"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-1, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(383, 55)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Agregar Equipos"
        '
        'AgregarEquiposDeportivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 626)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridTec)
        Me.Controls.Add(Me.DataGridEquipos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxTec)
        Me.Controls.Add(Me.Buttonactualizar)
        Me.Controls.Add(Me.Buttonguardar)
        Me.Controls.Add(Me.Buttonnuevo)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.DataGridEntrenadores)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxEquipo)
        Me.Controls.Add(Me.TextBoxEntrenador)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Name = "AgregarEquiposDeportivos"
        Me.Text = "AgregarEquiposDeportivos"
        CType(Me.DataGridEntrenadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridTec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buttonactualizar As Button
    Friend WithEvents Buttonguardar As Button
    Friend WithEvents Buttonnuevo As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents DataGridEntrenadores As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxEquipo As TextBox
    Friend WithEvents TextBoxEntrenador As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxTec As TextBox
    Friend WithEvents DataGridEquipos As DataGridView
    Friend WithEvents DataGridTec As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
