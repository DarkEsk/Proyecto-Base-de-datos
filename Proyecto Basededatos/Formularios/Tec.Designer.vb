<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tec))
        Me.ComboTec = New System.Windows.Forms.ComboBox()
        Me.ComboCarrera = New System.Windows.Forms.ComboBox()
        Me.ComboDepartamentos = New System.Windows.Forms.ComboBox()
        Me.ComboEntrenadores = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboHoras = New System.Windows.Forms.ComboBox()
        Me.DataGridAlumnos = New System.Windows.Forms.DataGridView()
        Me.DataGridequipos = New System.Windows.Forms.DataGridView()
        Me.DataGridIntegrantes = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarrerasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrenadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquiposDesportvosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntegrantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorarioDeJuegoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiudadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridequipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridIntegrantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboTec
        '
        Me.ComboTec.FormattingEnabled = True
        Me.ComboTec.Location = New System.Drawing.Point(103, 34)
        Me.ComboTec.Name = "ComboTec"
        Me.ComboTec.Size = New System.Drawing.Size(121, 21)
        Me.ComboTec.TabIndex = 0
        '
        'ComboCarrera
        '
        Me.ComboCarrera.FormattingEnabled = True
        Me.ComboCarrera.Location = New System.Drawing.Point(103, 79)
        Me.ComboCarrera.Name = "ComboCarrera"
        Me.ComboCarrera.Size = New System.Drawing.Size(121, 21)
        Me.ComboCarrera.TabIndex = 1
        '
        'ComboDepartamentos
        '
        Me.ComboDepartamentos.FormattingEnabled = True
        Me.ComboDepartamentos.Location = New System.Drawing.Point(571, 37)
        Me.ComboDepartamentos.Name = "ComboDepartamentos"
        Me.ComboDepartamentos.Size = New System.Drawing.Size(121, 21)
        Me.ComboDepartamentos.TabIndex = 2
        '
        'ComboEntrenadores
        '
        Me.ComboEntrenadores.FormattingEnabled = True
        Me.ComboEntrenadores.Location = New System.Drawing.Point(571, 82)
        Me.ComboEntrenadores.Name = "ComboEntrenadores"
        Me.ComboEntrenadores.Size = New System.Drawing.Size(121, 21)
        Me.ComboEntrenadores.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(71, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tec"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(56, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Carrera"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(486, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Departamentos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(495, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Entrenadores"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(738, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Horas"
        '
        'ComboHoras
        '
        Me.ComboHoras.FormattingEnabled = True
        Me.ComboHoras.Location = New System.Drawing.Point(779, 37)
        Me.ComboHoras.Name = "ComboHoras"
        Me.ComboHoras.Size = New System.Drawing.Size(121, 21)
        Me.ComboHoras.TabIndex = 8
        '
        'DataGridAlumnos
        '
        Me.DataGridAlumnos.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAlumnos.Location = New System.Drawing.Point(12, 156)
        Me.DataGridAlumnos.Name = "DataGridAlumnos"
        Me.DataGridAlumnos.Size = New System.Drawing.Size(409, 236)
        Me.DataGridAlumnos.TabIndex = 10
        '
        'DataGridequipos
        '
        Me.DataGridequipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridequipos.Location = New System.Drawing.Point(427, 156)
        Me.DataGridequipos.Name = "DataGridequipos"
        Me.DataGridequipos.Size = New System.Drawing.Size(409, 236)
        Me.DataGridequipos.TabIndex = 11
        '
        'DataGridIntegrantes
        '
        Me.DataGridIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridIntegrantes.Location = New System.Drawing.Point(842, 156)
        Me.DataGridIntegrantes.Name = "DataGridIntegrantes"
        Me.DataGridIntegrantes.Size = New System.Drawing.Size(385, 236)
        Me.DataGridIntegrantes.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(171, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Alumnos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(597, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Equipos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(991, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Integrantes"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1232, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TecToolStripMenuItem, Me.CarrerasToolStripMenuItem, Me.AlumnosToolStripMenuItem, Me.DepartamentosToolStripMenuItem, Me.EntrenadoresToolStripMenuItem, Me.EquiposDesportvosToolStripMenuItem, Me.IntegrantesToolStripMenuItem, Me.HorarioDeJuegoToolStripMenuItem, Me.GenerosToolStripMenuItem, Me.EstadosToolStripMenuItem, Me.CiudadesToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Menu"
        '
        'TecToolStripMenuItem
        '
        Me.TecToolStripMenuItem.Name = "TecToolStripMenuItem"
        Me.TecToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TecToolStripMenuItem.Text = "Tec"
        '
        'CarrerasToolStripMenuItem
        '
        Me.CarrerasToolStripMenuItem.Name = "CarrerasToolStripMenuItem"
        Me.CarrerasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CarrerasToolStripMenuItem.Text = "Carreras"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'EntrenadoresToolStripMenuItem
        '
        Me.EntrenadoresToolStripMenuItem.Name = "EntrenadoresToolStripMenuItem"
        Me.EntrenadoresToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.EntrenadoresToolStripMenuItem.Text = "Entrenadores"
        '
        'EquiposDesportvosToolStripMenuItem
        '
        Me.EquiposDesportvosToolStripMenuItem.Name = "EquiposDesportvosToolStripMenuItem"
        Me.EquiposDesportvosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.EquiposDesportvosToolStripMenuItem.Text = "EquiposDesportvos"
        '
        'IntegrantesToolStripMenuItem
        '
        Me.IntegrantesToolStripMenuItem.Name = "IntegrantesToolStripMenuItem"
        Me.IntegrantesToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.IntegrantesToolStripMenuItem.Text = "Integrantes"
        '
        'HorarioDeJuegoToolStripMenuItem
        '
        Me.HorarioDeJuegoToolStripMenuItem.Name = "HorarioDeJuegoToolStripMenuItem"
        Me.HorarioDeJuegoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.HorarioDeJuegoToolStripMenuItem.Text = "Horario de juego"
        '
        'GenerosToolStripMenuItem
        '
        Me.GenerosToolStripMenuItem.Name = "GenerosToolStripMenuItem"
        Me.GenerosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.GenerosToolStripMenuItem.Text = "Generos"
        '
        'EstadosToolStripMenuItem
        '
        Me.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem"
        Me.EstadosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.EstadosToolStripMenuItem.Text = "Estados"
        '
        'CiudadesToolStripMenuItem
        '
        Me.CiudadesToolStripMenuItem.Name = "CiudadesToolStripMenuItem"
        Me.CiudadesToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CiudadesToolStripMenuItem.Text = "Ciudades"
        '
        'Tec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1232, 493)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridIntegrantes)
        Me.Controls.Add(Me.DataGridequipos)
        Me.Controls.Add(Me.DataGridAlumnos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboHoras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboEntrenadores)
        Me.Controls.Add(Me.ComboDepartamentos)
        Me.Controls.Add(Me.ComboCarrera)
        Me.Controls.Add(Me.ComboTec)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Cornsilk
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Tec"
        Me.Text = "Form1"
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridequipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridIntegrantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboTec As ComboBox
    Friend WithEvents ComboCarrera As ComboBox
    Friend WithEvents ComboDepartamentos As ComboBox
    Friend WithEvents ComboEntrenadores As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboHoras As ComboBox
    Friend WithEvents DataGridAlumnos As DataGridView
    Friend WithEvents DataGridequipos As DataGridView
    Friend WithEvents DataGridIntegrantes As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TecToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarrerasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrenadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquiposDesportvosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntegrantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorarioDeJuegoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiudadesToolStripMenuItem As ToolStripMenuItem
End Class
