Public Class Registrar
    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objPer As New Personas
        objPer.ver(cbPersona)
        Dim objCom As New Comidas
        objCom.ver(cbComida)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objMG As New LeGustan
        objMG.grabar(cbPersona.SelectedValue, cbComida.SelectedValue)
    End Sub
End Class