
Public Class Tec
    Private Sub Tec_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim tec As New comadosdellamada

        tec.poblarCombotec(ComboTec)

        cnx.Close()
    End Sub

    Private Sub Combotec_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboTec.SelectedIndexChanged
        Dim tec As New comadosdellamada
        tec.poblarCombocarreras(ComboCarrera)
        tec.poblarComboDepartamentos(ComboDepartamentos)
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Comboentrenadores_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboEntrenadores.SelectedIndexChanged
        Dim tec As New comadosdellamada
        tec.PoblarDataGridequipos(DataGridequipos)
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Combodepas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboDepartamentos.SelectedIndexChanged
        Dim tec As New comadosdellamada
        tec.poblarComboentrenadores(ComboEntrenadores)
    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridequipos.CellContentClick
        Dim tec As New comadosdellamada

        tec.PoblarDataGridintegrantes(DataGridIntegrantes)
        tec.poblarCombohoras(ComboHoras)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    End Sub

    Private Sub ComboCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCarrera.SelectedIndexChanged
        Dim tec As New comadosdellamada
        tec.PoblarDataGridAlumnos(DataGridAlumnos)
    End Sub

    Private Sub TecToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TecToolStripMenuItem.Click
        AgregarTec.ShowDialog()
    End Sub

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        AgregarCarreras.ShowDialog()

    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosToolStripMenuItem.Click
        AgregarAlumnos.ShowDialog()

    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        AgregarDepartamentos.ShowDialog()
    End Sub

    Private Sub EntrenadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrenadoresToolStripMenuItem.Click
        AgregarEntrenadores.ShowDialog()
    End Sub

    Private Sub GenerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerosToolStripMenuItem.Click
        Generos.ShowDialog()
    End Sub

    Private Sub EquiposDesportvosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquiposDesportvosToolStripMenuItem.Click
        AgregarEquiposDeportivos.ShowDialog()
    End Sub

    Private Sub IntegrantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegrantesToolStripMenuItem.Click
        AgregarIntegrantes.ShowDialog()
    End Sub

    Private Sub HorarioDeJuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorarioDeJuegoToolStripMenuItem.Click
        AgregarParticipaciones.ShowDialog()
    End Sub

    Private Sub EstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosToolStripMenuItem.Click
        AgregarEstados.ShowDialog()
    End Sub

    Private Sub CiudadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadesToolStripMenuItem.Click
        AgregarCiudades.ShowDialog()
    End Sub
End Class