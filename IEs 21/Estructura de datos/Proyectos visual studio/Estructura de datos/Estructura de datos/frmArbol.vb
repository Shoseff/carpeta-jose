Public Class frmArbol
    Private ObjArbol As New Arbol
    Private Sub btnEquilibrar_Click(sender As Object, e As EventArgs) Handles btnEquilibrar.Click
        ObjArbol.Equlibrar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nvo As New Nodo
        nvo.Codigo = txtCodigo.Text
        nvo.Nombre = txtNombre.Text
        nvo.Tramite = txtTramite.Text

        ObjArbol.Agregar(nvo)
        ObjArbol.Listar(cboCodigo)
        ObjArbol.Listar(lstArbolIn, 1)
        ObjArbol.Listar(lstArbolPre, 2)
        ObjArbol.Listar(lstArbolPost, 3)
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtTramite.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjArbol.Eliminar(cboCodigo.Text)
        ObjArbol.Listar(cboCodigo)
        ObjArbol.Listar(lstArbolIn, 1)
        ObjArbol.Listar(lstArbolPre, 2)
        ObjArbol.Listar(lstArbolPost, 3)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim x As Nodo = ObjArbol.Buscar(cboCodigo.Text)
        MessageBox.Show(x.Codigo & " - " & x.Nombre)
    End Sub
End Class