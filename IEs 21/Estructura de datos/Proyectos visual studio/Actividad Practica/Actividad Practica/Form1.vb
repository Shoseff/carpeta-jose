Public Class Sistema
    Private ObjListaEnlazada As New ListaSImple
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nvo As New Nodo
        nvo.NumeroDeCuenta = Val(txtNumCuenta.Text)
        nvo.Nombre = Val(txtNombre.Text)
        nvo.LimiteDeCredito = Val(txtLimCredito.Text)
        nvo.Deuda = Val(txtDeuda.Text)

        ObjListaEnlazada.Agregar(nvo)
        ObjListaEnlazada.Recorrer(cboNumCuenta)
        ObjListaEnlazada.Recorrer(dgvListado, OpcionListado())
        txtNumCuenta.Text = ""
        txtNombre.Text = ""
        txtLimCredito.Text = ""
        txtDeuda.Text = ""
        cboNumCuenta.SelectedIndex = 0
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If ObjListaEnlazada.Primero Is Nothing Then
            MessageBox.Show("No hay elementos en la lista")
        Else
            ObjListaEnlazada.Eliminar(cboNumCuenta.SelectedItem)
            ObjListaEnlazada.Recorrer(cboNumCuenta)
            ObjListaEnlazada.Recorrer(dgvListado, OpcionListado())
            If ObjListaEnlazada.Primero Is Nothing Then
                cboNumCuenta.SelectedIndex = -1
            Else
                cboNumCuenta.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Function OpcionListado() As Boolean
        If radTodos.Checked = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub radTodos_CheckedChanged(sender As Object, e As EventArgs) Handles radTodos.CheckedChanged
        ObjListaEnlazada.Recorrer(dgvListado, OpcionListado())
    End Sub
End Class
