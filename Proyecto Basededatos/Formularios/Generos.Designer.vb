<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Generos))
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtGenero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdGenero = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.GenerosDGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.GenerosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.Location = New System.Drawing.Point(313, 241)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(72, 24)
        Me.BtnAgregar.TabIndex = 12
        Me.BtnAgregar.Text = "Guardar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.Location = New System.Drawing.Point(235, 241)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(72, 24)
        Me.BtnEliminar.TabIndex = 13
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActualizar.Location = New System.Drawing.Point(157, 241)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(72, 24)
        Me.BtnActualizar.TabIndex = 14
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(424, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 29)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Generos registrados:"
        '
        'TxtGenero
        '
        Me.TxtGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGenero.Location = New System.Drawing.Point(171, 158)
        Me.TxtGenero.Name = "TxtGenero"
        Me.TxtGenero.Size = New System.Drawing.Size(225, 38)
        Me.TxtGenero.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(63, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Genero"
        '
        'TxtIdGenero
        '
        Me.TxtIdGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdGenero.Location = New System.Drawing.Point(171, 111)
        Me.TxtIdGenero.Name = "TxtIdGenero"
        Me.TxtIdGenero.Size = New System.Drawing.Size(225, 38)
        Me.TxtIdGenero.TabIndex = 8
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.Location = New System.Drawing.Point(79, 241)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(72, 24)
        Me.BtnLimpiar.TabIndex = 11
        Me.BtnLimpiar.Text = "Nuevo"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'GenerosDGV
        '
        Me.GenerosDGV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.GenerosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GenerosDGV.Location = New System.Drawing.Point(420, 90)
        Me.GenerosDGV.Name = "GenerosDGV"
        Me.GenerosDGV.Size = New System.Drawing.Size(369, 189)
        Me.GenerosDGV.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(37, 120)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "idGenero"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(394, 55)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Agregar Generos"
        '
        'Generos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(819, 315)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtGenero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtIdGenero)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GenerosDGV)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Generos"
        Me.Text = "Generos"
        CType(Me.GenerosDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtGenero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIdGenero As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents GenerosDGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
