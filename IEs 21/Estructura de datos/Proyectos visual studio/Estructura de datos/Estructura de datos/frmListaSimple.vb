Public Class frmListaSimple
    Private ObjListaSimple As New ListaSimple

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nvo As New Nodo
        nvo.Codigo = txtCodigo.Text
        nvo.Nombre = txtNombre.Text
        nvo.Tramite = txtTramite.Text

        ObjListaSimple.Agregar(nvo)
        ObjListaSimple.Listar(cboCodigo)
        ObjListaSimple.Listar(lstLES)
        ObjListaSimple.Listar(dgvLES)
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtTramite.Text = ""
        cboCodigo.SelectedIndex = 0
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If ObjListaSimple.Primero Is Nothing Then
            MessageBox.Show("No hay elementos en la lista")
        Else
            ObjListaSimple.Eliminar(cboCodigo.SelectedItem)
            ObjListaSimple.Listar(cboCodigo)
            ObjListaSimple.Listar(lstLES)
            ObjListaSimple.Listar(dgvLES)
            If ObjListaSimple.Primero Is Nothing Then
                cboCodigo.SelectedIndex = -1
            Else
                cboCodigo.SelectedIndex = 0
            End If
        End If
    End Sub
End Class