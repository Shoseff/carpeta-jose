Public Class FrmPrincipal

    Dim objVen As New Vendedores
    Dim objAva As New Avances

    Private Sub bPuntitos_Click(sender As Object, e As EventArgs) Handles bPuntitos.Click
        Dim FAYU As New FrmAyuda
        FAYU.ShowDialog()
        If Documento <> "" Then
            txtDni.Text = Documento
            rellenar()
        End If
    End Sub
    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim FILA As DataRow = objVen.Buscar(Val(txtDni.Text))
        Try
            txtNombre.Text = FILA("nombre")
            txtEmail.Text = FILA("email")
            txtCelular.Text = FILA("celular")
            If FILA("sexo") = "M" Then
                txtSexo.Text = "Masculino"
            Else
                txtSexo.Text = "Femenino"
            End If
            dtpIngreso.Value = FILA("ingreso")

            GRAFICAR(pbAvance)
        Catch ex As Exception
            MessageBox.Show("DNI no valido o la persona no ha comenzado el curso", "ERROR")
        End Try


    End Sub

    Public Sub GRAFICAR(PB As PictureBox)

        Dim objVen As New Vendedores
        Dim FILA As DataRow = objAva.Buscar(Val(txtDni.Text))
        Dim GRA As Graphics
        GRA = PB.CreateGraphics
        Dim Fuente As New Font("Arial", 15)
        Dim X As Integer = 0
        Dim Y As Integer = 0
        Dim ANCHO As Integer = 0
        Const ALTO As Integer = 60

        Dim porcentaje As String = FILA("porcentaje")
        ANCHO = porcentaje * (pbAvance.Width / 100)
        If ANCHO < 0 Then
            GRA.FillRectangle(Brushes.White, X, Y, PB.Width, PB.Height)
        End If

        GRA.FillRectangle(Brushes.White, X, Y, PB.Width, PB.Height)
        GRA.FillRectangle(Brushes.Green, X, Y, ANCHO, ALTO)

        GRA.DrawString(porcentaje, Fuente, Brushes.White, X, Y)

    End Sub

    Public Sub rellenar()
        Dim FILA As DataRow = objVen.Buscar(Val(txtDni.Text))
        Try
            txtNombre.Text = FILA("nombre")
            txtEmail.Text = FILA("email")
            txtCelular.Text = FILA("celular")
            If FILA("sexo") = "M" Then
                txtSexo.Text = "Masculino"
            Else
                txtSexo.Text = "Femenino"
            End If
            dtpIngreso.Value = FILA("ingreso")

            GRAFICAR(pbAvance)
        Catch ex As Exception
            MessageBox.Show("Dni no valido o la persona no ha comenzado el curso", "ERROR")
        End Try
    End Sub
End Class
