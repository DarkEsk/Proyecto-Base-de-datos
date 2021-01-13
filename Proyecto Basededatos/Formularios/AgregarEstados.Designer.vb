<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEstados
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarEstados))
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnLimpia = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DGVestados = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_idEstado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGVestados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(266, 204)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 37
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(185, 204)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 36
        Me.BtnActualizar.Text = "&Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(104, 204)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 34
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnLimpia
        '
        Me.BtnLimpia.Location = New System.Drawing.Point(23, 204)
        Me.BtnLimpia.Name = "BtnLimpia"
        Me.BtnLimpia.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpia.TabIndex = 35
        Me.BtnLimpia.Text = "&Nuevo"
        Me.BtnLimpia.UseVisualStyleBackColor = True
        '
        'DGVestados
        '
        Me.DGVestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVestados.Location = New System.Drawing.Point(386, 61)
        Me.DGVestados.Name = "DGVestados"
        Me.DGVestados.Size = New System.Drawing.Size(393, 196)
        Me.DGVestados.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(380, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(265, 38)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Registros Estados"
        '
        'Txt_nombre
        '
        Me.Txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nombre.Location = New System.Drawing.Point(133, 138)
        Me.Txt_nombre.Name = "Txt_nombre"
        Me.Txt_nombre.Size = New System.Drawing.Size(198, 38)
        Me.Txt_nombre.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 31)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 31)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "idEstado"
        '
        'Txt_idEstado
        '
        Me.Txt_idEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_idEstado.Location = New System.Drawing.Point(133, 86)
        Me.Txt_idEstado.Name = "Txt_idEstado"
        Me.Txt_idEstado.Size = New System.Drawing.Size(198, 38)
        Me.Txt_idEstado.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-9, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(383, 55)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Agregar Estados"
        '
        'AgregarEstados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 287)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGVestados)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_idEstado)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnLimpia)
        Me.Name = "AgregarEstados"
        Me.Text = "AgregarEstados"
        CType(Me.DGVestados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnLimpia As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DGVestados As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_nombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_idEstado As TextBox
    Friend WithEvents Label6 As Label
End Class
