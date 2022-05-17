Public Class frmEstructuraDeDatos
    Private Sub DatosDelDesarrolladorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDelDesarrolladorToolStripMenuItem.Click
        frmDatosDelDesarrollador.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ColaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColaToolStripMenuItem.Click
        frmCola.Show()
    End Sub

    Private Sub PilaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PilaToolStripMenuItem.Click
        frmPila.Show()
    End Sub

    Private Sub ListaEnlazadaSimpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaEnlazadaSimpleToolStripMenuItem.Click
        frmListaSimple.Show()
    End Sub

    Private Sub ListaDoblementeEnlazadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDoblementeEnlazadaToolStripMenuItem.Click
        frmListaDoblementeEnlazada.Show()

    End Sub

    Private Sub ArbolBinarioDeBusquedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArbolBinarioDeBusquedaToolStripMenuItem.Click
        frmArbol.Show()
    End Sub
End Class
