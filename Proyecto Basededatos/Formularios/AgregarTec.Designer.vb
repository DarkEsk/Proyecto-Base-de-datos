<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarTec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarTec))
        Me.DGVciudades = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DGVestados = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCalle = New System.Windows.Forms.TextBox()
        Me.TxtCP = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buttonactualizar = New System.Windows.Forms.Button()
        Me.Buttonguardar = New System.Windows.Forms.Button()
        Me.Buttonnuevo = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.DataGridtec = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxEstado = New System.Windows.Forms.TextBox()
        Me.CmbCiudades = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGVciudades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVestados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridtec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVciudades
        '
        Me.DGVciudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVciudades.Location = New System.Drawing.Point(460, 253)
        Me.DGVciudades.Name = "DGVciudades"
        Me.DGVciudades.Size = New System.Drawing.Size(375, 134)
        Me.DGVciudades.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(456, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 24)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Registros Ciudades"
        '
        'DGVestados
        '
        Me.DGVestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVestados.Location = New System.Drawing.Point(468, 447)
        Me.DGVestados.Name = "DGVestados"
        Me.DGVestados.Size = New System.Drawing.Size(367, 134)
        Me.DGVestados.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(456, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 24)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Registros tec"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 24)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 24)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Calle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 24)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "CP"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(145, 311)
        Me.TxtTelefono.Multiline = True
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(252, 36)
        Me.TxtTelefono.TabIndex = 29
        '
        'TxtCalle
        '
        Me.TxtCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCalle.Location = New System.Drawing.Point(112, 271)
        Me.TxtCalle.Multiline = True
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(285, 34)
        Me.TxtCalle.TabIndex = 28
        '
        'TxtCP
        '
        Me.TxtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCP.Location = New System.Drawing.Point(95, 232)
        Me.TxtCP.Multiline = True
        Me.TxtCP.Name = "TxtCP"
        Me.TxtCP.Size = New System.Drawing.Size(302, 33)
        Me.TxtCP.TabIndex = 27
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(114, 122)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(283, 37)
        Me.TextBox1.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(181, 160)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 36)
        Me.TextBox2.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nombre del tec"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "id Tec"
        '
        'Buttonactualizar
        '
        Me.Buttonactualizar.Location = New System.Drawing.Point(144, 388)
        Me.Buttonactualizar.Name = "Buttonactualizar"
        Me.Buttonactualizar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonactualizar.TabIndex = 35
        Me.Buttonactualizar.Text = "&Actualizar"
        Me.Buttonactualizar.UseVisualStyleBackColor = True
        '
        'Buttonguardar
        '
        Me.Buttonguardar.Location = New System.Drawing.Point(306, 388)
        Me.Buttonguardar.Name = "Buttonguardar"
        Me.Buttonguardar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonguardar.TabIndex = 37
        Me.Buttonguardar.Text = "&Guardar"
        Me.Buttonguardar.UseVisualStyleBackColor = True
        '
        'Buttonnuevo
        '
        Me.Buttonnuevo.Location = New System.Drawing.Point(63, 388)
        Me.Buttonnuevo.Name = "Buttonnuevo"
        Me.Buttonnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Buttonnuevo.TabIndex = 34
        Me.Buttonnuevo.Text = "&Nuevo"
        Me.Buttonnuevo.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(225, 388)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 36
        Me.Eliminar.Text = "&Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'DataGridtec
        '
        Me.DataGridtec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridtec.Location = New System.Drawing.Point(460, 67)
        Me.DataGridtec.Name = "DataGridtec"
        Me.DataGridtec.Size = New System.Drawing.Size(375, 139)
        Me.DataGridtec.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(53, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 24)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "id Estado"
        '
        'TextBoxEstado
        '
        Me.TextBoxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEstado.Location = New System.Drawing.Point(142, 197)
        Me.TextBoxEstado.Multiline = True
        Me.TextBoxEstado.Name = "TextBoxEstado"
        Me.TextBoxEstado.Size = New System.Drawing.Size(254, 33)
        Me.TextBoxEstado.TabIndex = 50
        '
        'CmbCiudades
        '
        Me.CmbCiudades.FormattingEnabled = True
        Me.CmbCiudades.Location = New System.Drawing.Point(885, 25)
        Me.CmbCiudades.Name = "CmbCiudades"
        Me.CmbCiudades.Size = New System.Drawing.Size(108, 21)
        Me.CmbCiudades.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(464, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 24)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Registros Estados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 91)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "TecNM"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AgregarTec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(854, 593)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBoxEstado)
        Me.Controls.Add(Me.DGVciudades)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGVestados)
        Me.Controls.Add(Me.CmbCiudades)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtCalle)
        Me.Controls.Add(Me.TxtCP)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Buttonactualizar)
        Me.Controls.Add(Me.Buttonguardar)
        Me.Controls.Add(Me.Buttonnuevo)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.DataGridtec)
        Me.Name = "AgregarTec"
        Me.Text = "AgregarTec"
        CType(Me.DGVciudades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVestados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridtec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVciudades As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents DGVestados As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtCalle As TextBox
    Friend WithEvents TxtCP As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Buttonactualizar As Button
    Friend WithEvents Buttonguardar As Button
    Friend WithEvents Buttonnuevo As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents DataGridtec As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxEstado As TextBox
    Friend WithEvents CmbCiudades As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
End Class
