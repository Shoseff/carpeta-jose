Public Class frmListaDoblementeEnlazada
    Private ObjListaDoble As New ListaDoblementeEnlazada
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nvo As New Nodo
        nvo.Codigo = txtCodigo.Text
        nvo.Nombre = txtNombre.Text
        nvo.Tramite = txtTramite.Text

        ObjListaDoble.agregar(nvo)
        ObjListaDoble.listar(cboCodigo)
        ObjListaDoble.listar(lstLES)
        ObjListaDoble.listar_descendiente(dgvLES)
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtTramite.Text = ""
        cboCodigo.SelectedIndex = 0
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If ObjListaDoble.Primero Is Nothing Then
            MessageBox.Show("No hay elementos en la lista")
        Else
            ObjListaDoble.eliminar(cboCodigo.SelectedItem)
            ObjListaDoble.listar(cboCodigo)
            ObjListaDoble.listar(lstLES)
            ObjListaDoble.listar_descendiente(dgvLES)
            If ObjListaDoble.Primero Is Nothing Then
                cboCodigo.SelectedIndex = -1
            Else
                cboCodigo.SelectedIndex = 0
            End If
        End If
    End Sub
End Class