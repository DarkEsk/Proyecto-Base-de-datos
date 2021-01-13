<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarLogin))
        Me.DataGridUsuarios = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Buttonactualizar = New System.Windows.Forms.Button()
        Me.Buttonguardar = New System.Windows.Forms.Button()
        Me.Buttonnuevo = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridUsuarios
        '
        Me.DataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUsuarios.Location = New System.Drawing.Point(464, 55)
        Me.DataGridUsuarios.Name = "DataGridUsuarios"
        Me.DataGridUsuarios.Size = New System.Drawing.Size(340, 196)
        Me.DataGridUsuarios.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(461, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(268, 37)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Registros Usuarios"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(156, 126)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(256, 38)
        Me.TextBoxNombre.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 31)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 31)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "idUsuario"
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsuario.Location = New System.Drawing.Point(156, 84)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(256, 38)
        Me.TextBoxUsuario.TabIndex = 45
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContraseña.Location = New System.Drawing.Point(156, 170)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.Size = New System.Drawing.Size(256, 38)
        Me.TextBoxContraseña.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-5, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 31)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Contraseña"
        '
        'Buttonactualizar
        '
        Me.Buttonactualizar.Location = New System.Drawing.Point(143, 228)
        Me.Buttonactualizar.Name = "Buttonactualizar"
        Me.Buttonactualizar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonactualizar.TabIndex = 58
        Me.Buttonactualizar.Text = "Actualizar"
        Me.Buttonactualizar.UseVisualStyleBackColor = True
        '
        'Buttonguardar
        '
        Me.Buttonguardar.Location = New System.Drawing.Point(305, 228)
        Me.Buttonguardar.Name = "Buttonguardar"
        Me.Buttonguardar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonguardar.TabIndex = 57
        Me.Buttonguardar.Text = "Guardar"
        Me.Buttonguardar.UseVisualStyleBackColor = True
        '
        'Buttonnuevo
        '
        Me.Buttonnuevo.Location = New System.Drawing.Point(62, 228)
        Me.Buttonnuevo.Name = "Buttonnuevo"
        Me.Buttonnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Buttonnuevo.TabIndex = 56
        Me.Buttonnuevo.Text = "Nuevo"
        Me.Buttonnuevo.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(224, 228)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 55
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(2, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(399, 58)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Agregar Usuarios"
        '
        'AgregarLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(816, 263)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Buttonactualizar)
        Me.Controls.Add(Me.Buttonguardar)
        Me.Controls.Add(Me.Buttonnuevo)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridUsuarios)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Name = "AgregarLogin"
        Me.Text = "AgregarLogin"
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridUsuarios As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Buttonactualizar As Button
    Friend WithEvents Buttonguardar As Button
    Friend WithEvents Buttonnuevo As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Label4 As Label
End Class
