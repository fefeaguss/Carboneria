Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarClientes()
    End Sub

    Private Sub llenarClientes()

        Dim sql As String = "select id_cliente as 'ID CLIENTE', nombre_apellido as 'NOMBRE Y APELLIDO', cuit AS 'CUIT', 
                             telefono AS 'TELEFONO', direccion AS 'DIRECCION' from Cliente"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("Cliente")
        adp.Fill(ds.Tables("Cliente"))
        Me.dgvClientes.DataSource = ds.Tables("Cliente")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        flag_abm = 1 'ALTA

        HabilitarDeshabilitarControles(Me, True)
        Me.btnListo.Visible = True
        Me.txtNombre_Cliente.Focus()

    End Sub

    'Generar cliente
    Private Sub NuevoCliente()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL sin id_cliente porque es identity
        Dim sql As String = "INSERT INTO Cliente (nombre_apellido, cuit, telefono, direccion) " &
                            "VALUES ('" & Me.txtNombre_Cliente.Text & "', '" & Me.txtCuit.Text & "', '" &
                            Me.txtTelefono.Text & "', '" & Me.txtDireccion.Text & "')"

        cmd.CommandText = sql

        ' Validaciones
        If Me.txtNombre_Cliente.Text <> "" Then
            If Me.txtCuit.Text <> "" Then
                If Me.txtTelefono.Text <> "" Then
                    If Me.txtDireccion.Text <> "" Then
                        Try
                            cmd.ExecuteNonQuery()
                            llenarClientes()

                            ' Limpiar campos
                            Me.txtNombre_Cliente.Clear()
                            Me.txtCuit.Clear()
                            Me.txtTelefono.Clear()
                            Me.txtDireccion.Clear()
                            Me.btnListo.Visible = False
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    Else
                        MsgBox("El campo DIRECCION no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    MsgBox("El campo TELEFONO no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("El campo CUIT no puede estar vacío.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo NOMBRE Y APELLIDO no puede estar vacío.", MsgBoxStyle.Critical, "Error")
            Me.txtNombre_Cliente.Focus()
        End If
    End Sub

    'btn modificar cliente
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        flag_abm = 2
        wcp = Me.dgvClientes.CurrentRow.Cells(0).Value
        Me.txtNombre_Cliente.Text = Me.dgvClientes.CurrentRow.Cells(1).Value.ToString
        Me.txtCuit.Text = Me.dgvClientes.CurrentRow.Cells(2).Value.ToString
        Me.txtTelefono.Text = Me.dgvClientes.CurrentRow.Cells(3).Value.ToString
        Me.txtDireccion.Text = Me.dgvClientes.CurrentRow.Cells(4).Value.ToString
        Me.btnListo.Visible = True
        HabilitarDeshabilitarControles(Me, True)
        Me.txtNombre_Cliente.Focus()
    End Sub

    'funcion modificar cliente
    Private Sub ModificarCliente()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL con los campos correctos
        Dim sql As String = "UPDATE Cliente SET " &
                        "nombre_apellido = '" & Me.txtNombre_Cliente.Text & "', " &
                        "cuit = '" & Me.txtCuit.Text & "', " &
                        "telefono = '" & Me.txtTelefono.Text & "', " &
                        "direccion = '" & Me.txtDireccion.Text & "' " &
                        "WHERE id_cliente = " & wcp

        cmd.CommandText = sql

        ' Validaciones

        If Me.txtNombre_Cliente.Text <> "" Then
                If Me.txtCuit.Text <> "" Then
                    If Me.txtTelefono.Text <> "" Then
                        If Me.txtDireccion.Text <> "" Then
                            Try
                                cmd.ExecuteNonQuery()
                                llenarClientes()

                                ' Reset de campos
                                
                                Me.txtNombre_Cliente.Clear()
                                Me.txtCuit.Clear()
                                Me.txtTelefono.Clear()
                                Me.txtDireccion.Clear()
                                Me.btnListo.Visible = False
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        Else
                            MsgBox("El campo DIRECCION no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                        End If
                    Else
                        MsgBox("El campo TELEFONO no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    MsgBox("El campo CUIT no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                End If
            Else
            MsgBox("El campo NOMBRE Y APELLIDO no puede estar vacío.", MsgBoxStyle.Critical, "Error")
            Me.txtNombre_Cliente.Focus()
        End If

    End Sub


    'btn eliminar cleinte
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        flag_abm = 3
        wcp = Me.dgvClientes.CurrentRow.Cells(0).Value
        Me.txtNombre_Cliente.Text = Me.dgvClientes.CurrentRow.Cells(1).Value.ToString
        Me.txtCuit.Text = Me.dgvClientes.CurrentRow.Cells(2).Value.ToString
        Me.txtTelefono.Text = Me.dgvClientes.CurrentRow.Cells(3).Value.ToString
        Me.txtDireccion.Text = Me.dgvClientes.CurrentRow.Cells(4).Value.ToString
        Me.btnListo.Visible = True
        HabilitarDeshabilitarControles(Me, True)
        Me.txtNombre_Cliente.Focus()
    End Sub


    'FUNCION PARA ELIMINAR CLIENTE
    Private Sub EliminarCliente()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete Cliente where id_cliente = " & wcp & ""
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()

            llenarClientes()
            Me.txtNombre_Cliente.Clear()
            Me.txtCuit.Clear()
            Me.txtTelefono.Clear()
            Me.txtDireccion.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'INSERT
            NuevoCliente()
        ElseIf flag_abm = 2 Then 'UPDATE
            ModificarCliente()
        ElseIf flag_abm = 3 Then 'DELETE
            EliminarCliente()
        End If

        HabilitarDeshabilitarControles(Me, False)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class