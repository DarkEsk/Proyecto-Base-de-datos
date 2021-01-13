<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarIntegrantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarIntegrantes))
        Me.DataGridIntegrantes = New System.Windows.Forms.DataGridView()
        Me.DataGridEquipos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Buttonnuevo = New System.Windows.Forms.Button()
        Me.Buttonguardar = New System.Windows.Forms.Button()
        Me.Buttonactualizar = New System.Windows.Forms.Button()
        Me.DataGridAlumnos = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxIdEquipo = New System.Windows.Forms.TextBox()
        Me.TextBoxNoControl = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridIntegrantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridIntegrantes
        '
        Me.DataGridIntegrantes.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridIntegrantes.Location = New System.Drawing.Point(481, 48)
        Me.DataGridIntegrantes.Name = "DataGridIntegrantes"
        Me.DataGridIntegrantes.Size = New System.Drawing.Size(249, 150)
        Me.DataGridIntegrantes.TabIndex = 55
        '
        'DataGridEquipos
        '
        Me.DataGridEquipos.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEquipos.Location = New System.Drawing.Point(481, 241)
        Me.DataGridEquipos.Name = "DataGridEquipos"
        Me.DataGridEquipos.Size = New System.Drawing.Size(249, 150)
        Me.DataGridEquipos.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(475, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 31)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Registros Integrantes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(475, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 31)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Registros Equipos"
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(258, 215)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 56
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Buttonnuevo
        '
        Me.Buttonnuevo.Location = New System.Drawing.Point(96, 215)
        Me.Buttonnuevo.Name = "Buttonnuevo"
        Me.Buttonnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Buttonnuevo.TabIndex = 57
        Me.Buttonnuevo.Text = "Nuevo"
        Me.Buttonnuevo.UseVisualStyleBackColor = True
        '
        'Buttonguardar
        '
        Me.Buttonguardar.Location = New System.Drawing.Point(339, 215)
        Me.Buttonguardar.Name = "Buttonguardar"
        Me.Buttonguardar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonguardar.TabIndex = 58
        Me.Buttonguardar.Text = "Guardar"
        Me.Buttonguardar.UseVisualStyleBackColor = True
        '
        'Buttonactualizar
        '
        Me.Buttonactualizar.Location = New System.Drawing.Point(177, 215)
        Me.Buttonactualizar.Name = "Buttonactualizar"
        Me.Buttonactualizar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonactualizar.TabIndex = 59
        Me.Buttonactualizar.Text = "Actualizar"
        Me.Buttonactualizar.UseVisualStyleBackColor = True
        '
        'DataGridAlumnos
        '
        Me.DataGridAlumnos.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAlumnos.Location = New System.Drawing.Point(46, 285)
        Me.DataGridAlumnos.Name = "DataGridAlumnos"
        Me.DataGridAlumnos.Size = New System.Drawing.Size(341, 140)
        Me.DataGridAlumnos.TabIndex = 63
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label10.Location = New System.Drawing.Point(40, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(242, 31)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Registros Alumnos"
        '
        'TextBoxIdEquipo
        '
        Me.TextBoxIdEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdEquipo.Location = New System.Drawing.Point(163, 149)
        Me.TextBoxIdEquipo.Name = "TextBoxIdEquipo"
        Me.TextBoxIdEquipo.Size = New System.Drawing.Size(293, 38)
        Me.TextBoxIdEquipo.TabIndex = 51
        '
        'TextBoxNoControl
        '
        Me.TextBoxNoControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNoControl.Location = New System.Drawing.Point(163, 75)
        Me.TextBoxNoControl.Name = "TextBoxNoControl"
        Me.TextBoxNoControl.Size = New System.Drawing.Size(293, 38)
        Me.TextBoxNoControl.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label6.Location = New System.Drawing.Point(7, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 31)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "NoControl"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 31)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "idEquipo"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(453, 58)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Agregar Integrantes"
        '
        'AgregarIntegrantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(804, 437)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridAlumnos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridEquipos)
        Me.Controls.Add(Me.Buttonactualizar)
        Me.Controls.Add(Me.Buttonguardar)
        Me.Controls.Add(Me.Buttonnuevo)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.DataGridIntegrantes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxNoControl)
        Me.Controls.Add(Me.TextBoxIdEquipo)
        Me.Name = "AgregarIntegrantes"
        Me.Text = "AgregarIntegrantes"
        CType(Me.DataGridIntegrantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridIntegrantes As DataGridView
    Friend WithEvents DataGridEquipos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Eliminar As Button
    Friend WithEvents Buttonnuevo As Button
    Friend WithEvents Buttonguardar As Button
    Friend WithEvents Buttonactualizar As Button
    Friend WithEvents DataGridAlumnos As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxIdEquipo As TextBox
    Friend WithEvents TextBoxNoControl As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
