Public Class FrmAyuda


    Private Sub FrmAyuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objVen As New Vendedores
        objVen.Ver(GRILLA)
    End Sub

    Private Sub GRILLA_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRILLA.CellDoubleClick
        Documento = GRILLA.CurrentCell.Value
        Me.Close()
    End Sub
End Class