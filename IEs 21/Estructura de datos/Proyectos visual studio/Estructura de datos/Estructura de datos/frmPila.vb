Public Class frmPila

    Private ObjCola As New Pila
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nvo As New Nodo
        nvo.Codigo = txtCodigo.Text
        nvo.Nombre = txtNombre.Text
        nvo.Tramite = txtTramite.Text
        ObjCola.Agregar(nvo)
        ObjCola.Listar(lstPila)
        ObjCola.Listar(dgvPila)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If ObjCola.Primero IsNot Nothing Then
            lblCodigoE.Text = ObjCola.Primero.Codigo
            lblNombreE.Text = ObjCola.Primero.Nombre
            lblTramiteE.Text = ObjCola.Primero.Tramite
            ObjCola.Eliminar()
            ObjCola.Listar(lstPila)
            ObjCola.Listar(dgvPila)
        Else
            MessageBox.Show("No hay datos")
        End If
    End Sub
End Class