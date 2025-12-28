Public Class frmProveedores


    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarProveedor()
    End Sub

    Private Sub llenarProveedor()

        Dim sql As String = "select id_proveedor as 'ID PROVEEDOR', nombre as 'NOMBRE Y APELLIDO', cuit AS 'CUIT', 
                             telefono AS 'TELEFONO', direccion AS 'DIRECCION' from Proveedor"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("Proveedor")
        adp.Fill(ds.Tables("Proveedor"))
        Me.dgvProveedor.DataSource = ds.Tables("Proveedor")
    End Sub



    'BTN PARA AGREGAR PROVEEDOR
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        flag_abm = 1 'ALTA

        HabilitarDeshabilitarControles(Me, True)
        Me.btnListo.Visible = True
        Me.txtNombre_Cliente.Focus()

    End Sub

    'FUNCION PARA GENERAR PROVEEDOR
    Private Sub NuevoProveedor()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL sin id_cliente porque es identity
        Dim sql As String = "INSERT INTO Proveedor (nombre, cuit, telefono, direccion) " &
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
                            llenarProveedor()

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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        flag_abm = 2
        wcp = Me.dgvProveedor.CurrentRow.Cells(0).Value
        Me.txtNombre_Cliente.Text = Me.dgvProveedor.CurrentRow.Cells(1).Value.ToString
        Me.txtCuit.Text = Me.dgvProveedor.CurrentRow.Cells(2).Value.ToString
        Me.txtTelefono.Text = Me.dgvProveedor.CurrentRow.Cells(3).Value.ToString
        Me.txtDireccion.Text = Me.dgvProveedor.CurrentRow.Cells(4).Value.ToString
        Me.btnListo.Visible = True
        HabilitarDeshabilitarControles(Me, True)
        Me.txtNombre_Cliente.Focus()
    End Sub



    'funcion modificar PROVEEDOR    
    Private Sub ModificarProveedor()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL con los campos correctos
        Dim sql As String = "UPDATE Proveedor SET " &
                        "nombre = '" & Me.txtNombre_Cliente.Text & "', " &
                        "cuit = '" & Me.txtCuit.Text & "', " &
                        "telefono = '" & Me.txtTelefono.Text & "', " &
                        "direccion = '" & Me.txtDireccion.Text & "' " &
                        "WHERE id_Proveedor = " & wcp

        cmd.CommandText = sql

        ' Validaciones

        If Me.txtNombre_Cliente.Text <> "" Then
            If Me.txtCuit.Text <> "" Then
                If Me.txtTelefono.Text <> "" Then
                    If Me.txtDireccion.Text <> "" Then
                        Try
                            cmd.ExecuteNonQuery()
                            llenarProveedor()

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


    'BTN PARA ELIMINAR PROVEEDOR
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        flag_abm = 3
        wcp = Me.dgvProveedor.CurrentRow.Cells(0).Value
        Me.txtNombre_Cliente.Text = Me.dgvProveedor.CurrentRow.Cells(1).Value.ToString
        Me.txtCuit.Text = Me.dgvProveedor.CurrentRow.Cells(2).Value.ToString
        Me.txtTelefono.Text = Me.dgvProveedor.CurrentRow.Cells(3).Value.ToString
        Me.txtDireccion.Text = Me.dgvProveedor.CurrentRow.Cells(4).Value.ToString
        Me.btnListo.Visible = True
        HabilitarDeshabilitarControles(Me, True)
        Me.txtNombre_Cliente.Focus()
    End Sub



    'FUNCION PARA ELIMINAR PROVEEDOR
    Private Sub EliminarProveedor()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete Proveedor where id_Proveedor = " & wcp & ""
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()

            llenarProveedor()
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
            NuevoProveedor()
        ElseIf flag_abm = 2 Then 'UPDATE
            ModificarProveedor()
        ElseIf flag_abm = 3 Then 'DELETE
            EliminarProveedor()
        End If

        HabilitarDeshabilitarControles(Me, False)
    End Sub
End Class