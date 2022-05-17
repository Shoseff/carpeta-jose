Public Class Form1

    Dim ObjUsuario As New Usuarios
    Dim ObjGrupo As New Grupos
    Dim ObjGrupoUsuario As New GruposUsuarios

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ObjGrupo.Cargar(LB)
        ObjUsuario.Cargar(LV)

    End Sub

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click

        Try

            For Each A As ListViewItem In LV.Items
                Dim Ok As Boolean = ObjGrupoUsuario.Buscar(LB.SelectedValue, A.ImageIndex)

                If Ok = True Then

                    If A.Checked = False Then
                        ObjGrupoUsuario.Eliminar(LB.SelectedValue, A.ImageIndex)
                    End If

                End If

                If Ok = False Then

                    If A.Checked = True Then
                        ObjGrupoUsuario.Grabar(LB.SelectedValue, A.ImageIndex)
                    End If

                End If

            Next

            MsgBox("Los datos han sido actualizados")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub LB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB.SelectedIndexChanged

        ObjUsuario.Limpiar(LV)
        ObjGrupoUsuario.Ver(LB.SelectedValue, LV)

    End Sub

    Private Sub LV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV.SelectedIndexChanged

    End Sub
End Class
