Public Class frmInsumos
    Private Sub frmInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarInsumos()
    End Sub

    Private Sub llenarInsumos()

        Dim sql As String = "select id_insumo as 'ID INSUMO', nombre as 'NOMBRE DE INSUMO', unidad as 'UNIDAD' from Insumo"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("Insumo")
        adp.Fill(ds.Tables("Insumo"))
        Me.dgvInsumos.DataSource = ds.Tables("Insumo")
    End Sub




    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        flag_abm = 1 'ALTA

        HabilitarDeshabilitarControles(Me, True)
        Me.btnListo.Visible = True
        Me.txtNombreInsumo.Focus()
    End Sub


    ' FUNCION PARA GENERAR INSUMO
    Private Sub NuevoInsumo()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL sin id_insumo (identity)
        Dim sql As String = "INSERT INTO Insumo (nombre, unidad) " &
                        "VALUES ('" & Me.txtNombreInsumo.Text & "', '" & Me.txtUnidad.Text & "')"

        cmd.CommandText = sql

        ' Validaciones
        If Me.txtNombreInsumo.Text <> "" Then
            If Me.txtUnidad.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    llenarInsumos() ' función que refresca el listado de insumos

                    ' Limpiar campos
                    Me.txtNombreInsumo.Clear()
                    Me.txtUnidad.Clear()
                    Me.btnListo.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo UNIDAD no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                Me.txtUnidad.Focus()
            End If
        Else
            MsgBox("El campo NOMBRE DE INSUMO no puede estar vacío.", MsgBoxStyle.Critical, "Error")
            Me.txtNombreInsumo.Focus()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        flag_abm = 2
        wcp = Me.dgvInsumos.CurrentRow.Cells(0).Value
        Me.txtNombreInsumo.Text = Me.dgvInsumos.CurrentRow.Cells(1).Value.ToString
        Me.txtUnidad.Text = Me.dgvInsumos.CurrentRow.Cells(2).Value.ToString
        HabilitarDeshabilitarControles(Me, True)
        Me.txtNombreInsumo.Focus()
    End Sub


    ' FUNCION PARA MODIFICAR INSUMO
    Private Sub ModificarInsumo()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL con los campos correctos
        Dim sql As String = "UPDATE Insumo SET " &
                        "nombre = '" & Me.txtNombreInsumo.Text & "', " &
                        "unidad = '" & Me.txtUnidad.Text & "' " &
                        "WHERE id_insumo = " & wcp

        cmd.CommandText = sql

        ' Validaciones
        If Me.txtNombreInsumo.Text <> "" Then
            If Me.txtUnidad.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    llenarInsumos() ' refresca listado de insumos

                    ' Reset de campos
                    Me.txtNombreInsumo.Clear()
                    Me.txtUnidad.Clear()
                    Me.btnListo.Visible = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo UNIDAD no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                Me.txtUnidad.Focus()
            End If
        Else
            MsgBox("El campo NOMBRE DE INSUMO no puede estar vacío.", MsgBoxStyle.Critical, "Error")
            Me.txtNombreInsumo.Focus()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        flag_abm = 3
        wcp = Me.dgvInsumos.CurrentRow.Cells(0).Value
        Me.txtNombreInsumo.Text = Me.dgvInsumos.CurrentRow.Cells(1).Value.ToString
        Me.txtUnidad.Text = Me.dgvInsumos.CurrentRow.Cells(2).Value.ToString
        HabilitarDeshabilitarControles(Me, True)
        Me.txtNombreInsumo.Focus()
    End Sub


    ' FUNCION PARA ELIMINAR INSUMO
    Private Sub EliminarInsumo()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = "DELETE FROM Insumo WHERE id_insumo = " & wcp
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            llenarInsumos() ' refresca listado de insumos

            ' Limpiar campos
            Me.txtNombreInsumo.Clear()
            Me.txtUnidad.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'INSERT
            NuevoInsumo()
        ElseIf flag_abm = 2 Then 'UPDATE
            ModificarInsumo()
        ElseIf flag_abm = 3 Then 'DELETE
            EliminarInsumo()
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class