
Public Class FrmReservas

    Dim ObjReserva As New Funciones
    Dim Obj As New Reservas
    Dim Gra As Graphics

    Private Sub FrmReservas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ObjReserva.AgregarFechas(CBFecha)

    End Sub

    Private Sub CBFecha_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CBFecha.SelectedIndexChanged

        LBHorario.Items.Clear()
        ObjReserva.AgregarHoras(LBHorario, CBFecha.Text)

    End Sub

    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BConsultar.Click

        If LBHorario.SelectedItem Is Nothing Then

            MsgBox("Seleccione un horario por favor", vbCritical)

        Else

            Dim Funcion As Integer = ObjReserva.Buscar(CBFecha.Text, LBHorario.Text)

            Gra = PB.CreateGraphics

            Gra.Clear(Color.White)

            Obj.Dibujar(Funcion, Gra)

        End If

    End Sub

    
    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        If MsgBox("Esta seguro que desea salir", vbQuestion + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub BCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BCancelar.Click

        Gra.Clear(Color.White)
        CBFecha.SelectedIndex = 0
        LBHorario.SelectedItem = Nothing

    End Sub
End Class
