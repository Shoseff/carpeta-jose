Public Class Form1

    Private ObjCliente As New ClaseCliente
    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        ObjCliente.Comprar(txtImporte.Text)
        lblDeuda.Text = ObjCliente.Deuda
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        ObjCliente.Pagar(txtImporte.Text)
        lblDeuda.Text = ObjCliente.Deuda
    End Sub
End Class
