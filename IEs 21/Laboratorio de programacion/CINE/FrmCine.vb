Public Class FrmCine

    Dim Obj As New Datos

    Private Sub FrmCine_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Obj.Construir(TV)

    End Sub

    Private Sub TV_NodeMouseClick(sender As Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TV.NodeMouseClick

        If e.Node.Level = 2 Then

            Dim CantPeliculas As Integer = Obj.TraerPeliculas(Val(e.Node.Tag), LV)
            Dim Fila As DataRow = Obj.ObtenerDatosActores(Val(e.Node.Tag))

            LabelNombre.Text = Fila("nombre")
            LabelFechaNac.Text = Fila("nacio")
            CantidadPeliculas.Text = CantPeliculas

        Else

            LV.Items.Clear()
            LabelNombre.Text = ""
            LabelFechaNac.Text = ""
            CantidadPeliculas.Text = ""

        End If



    End Sub
End Class
