Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objLOC As New Localidades
        Dim objCUL As New Cultivos
        objLOC.Ver(cbLocalidad)
        objCUL.Ver(cbCultivo)
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim objPRO As New Produccion
        Dim TONELADAS As Integer = objPRO.Buscar(Val(txtAA.Text), Val(txtMM.Text), cbLocalidad.SelectedValue, cbCultivo.SelectedValue)
        txtToneladas.Text = TONELADAS

    End Sub
End Class
