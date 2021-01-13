<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarParticipaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarParticipaciones))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FechaJuego = New System.Windows.Forms.DateTimePicker()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.equipoDGV = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtHora = New System.Windows.Forms.TextBox()
        Me.TxtEquipo = New System.Windows.Forms.TextBox()
        Me.HorarioDGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.equipoDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaJuego
        '
        Me.FechaJuego.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaJuego.Location = New System.Drawing.Point(148, 146)
        Me.FechaJuego.Name = "FechaJuego"
        Me.FechaJuego.Size = New System.Drawing.Size(245, 38)
        Me.FechaJuego.TabIndex = 31
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(123, 262)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 36
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(204, 262)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 35
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(285, 262)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 34
        Me.btnAgregar.Text = "Guardar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(39, 262)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 33
        Me.btnLimpiar.Text = "Nuevo"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 33)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Registros Equipos"
        '
        'equipoDGV
        '
        Me.equipoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.equipoDGV.Location = New System.Drawing.Point(421, 50)
        Me.equipoDGV.Name = "equipoDGV"
        Me.equipoDGV.Size = New System.Drawing.Size(335, 150)
        Me.equipoDGV.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(415, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(354, 33)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = " Registros Participaciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 31)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Hora "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 31)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Fecha"
        '
        'TxtHora
        '
        Me.TxtHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHora.Location = New System.Drawing.Point(148, 193)
        Me.TxtHora.Name = "TxtHora"
        Me.TxtHora.Size = New System.Drawing.Size(245, 38)
        Me.TxtHora.TabIndex = 32
        '
        'TxtEquipo
        '
        Me.TxtEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEquipo.Location = New System.Drawing.Point(148, 94)
        Me.TxtEquipo.Name = "TxtEquipo"
        Me.TxtEquipo.Size = New System.Drawing.Size(245, 38)
        Me.TxtEquipo.TabIndex = 29
        '
        'HorarioDGV
        '
        Me.HorarioDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HorarioDGV.Location = New System.Drawing.Point(421, 243)
        Me.HorarioDGV.Name = "HorarioDGV"
        Me.HorarioDGV.Size = New System.Drawing.Size(335, 150)
        Me.HorarioDGV.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 31)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "idEquipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(375, 42)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Agregar Participacion"
        '
        'AgregarParticipaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 489)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FechaJuego)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.equipoDGV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtHora)
        Me.Controls.Add(Me.TxtEquipo)
        Me.Controls.Add(Me.HorarioDGV)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarParticipaciones"
        Me.Text = "AgregarParticipaciones"
        CType(Me.equipoDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FechaJuego As DateTimePicker
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents equipoDGV As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtHora As TextBox
    Friend WithEvents TxtEquipo As TextBox
    Friend WithEvents HorarioDGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
