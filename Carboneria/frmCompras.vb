Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmCompras


    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDetalleCompra()
        llenarDetalleCompraInsumos()
        llenarDetalleCompraProducto()
        llenarDetalleCompraCarbon()
        CargarComboProveedor()
        CargarComboInsumo()
    End Sub


    Private Sub llenarDetalleCompra()

        Dim sql As String = "select compra.id_compra AS 'ID COMPRA', Proveedor.nombre AS NOMBRE, fecha as 'FECHA DE COMPRA',
                   tipo_compra AS 'TIPO DE COMPRA', total AS TOTAL  from compra
                   inner join Proveedor on Compra.id_proveedor = Proveedor.id_proveedor"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("compra")
        adp.Fill(ds.Tables("compra"))
        Me.dgvDetalleCompra.DataSource = ds.Tables("compra")
    End Sub


    Private Sub llenarDetalleCompraInsumos()

        Dim sql As String = "SELECT id_detalle as 'ID DETALLE', id_compra as 'ID COMPRA', Insumo.nombre as 'NOMBRE DE INSUMO', cantidad AS CANTIDAD, 
                   precio_unitario AS 'PRECIO UNITARIO' FROM DetalleCompraInsumo
                   INNER JOIN Insumo ON Insumo.id_insumo = DetalleCompraInsumo.id_insumo "
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("DetalleCompraInsumo")
        adp.Fill(ds.Tables("DetalleCompraInsumo"))
        Me.dgvDetalleCompraInsumos.DataSource = ds.Tables("DetalleCompraInsumo")
    End Sub

    Private Sub llenarDetalleCompraProducto()

        Dim sql As String = "SELECT id_detalle AS 'ID DETALLE',id_compra as 'ID COMPRA', Producto.nombre as 'NOMBRE DE PRODUCTO', 
                   cantidad AS CANTIDAD, precio_unitario AS 'PRECIO UNITARIO', subtotal AS SUBTOTAL
                   FROM DetalleCompraProducto
                   INNER JOIN Producto ON DetalleCompraProducto.id_producto = Producto.id_producto"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("DetalleCompraProducto")
        adp.Fill(ds.Tables("DetalleCompraProducto"))
        Me.dgvDetalleCompraProducto.DataSource = ds.Tables("DetalleCompraProducto")
    End Sub


    Private Sub llenarDetalleCompraCarbon()

        Dim sql As String = "SELECT id_movimiento as 'ID MOVIMIENTO',id_compra as 'ID COMPRA' , fecha as FECHA, tipo_movimiento as  'TIPO DE MOVIMIENTO', 
                             cantidad_kg as 'CANTIDAD DE KILOS'
                             FROM StockCarbon"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("StockCarbon")
        adp.Fill(ds.Tables("StockCarbon"))
        Me.dgvDetalleCompraCarbon.DataSource = ds.Tables("StockCarbon")
    End Sub

    'cargar ComboBox de Lista de Precios
    Private Sub CargarComboProveedor()
        Dim sql As String = "SELECT id_proveedor, nombre FROM Proveedor"
        Dim da As New SqlDataAdapter(sql, Conexion.conexion)
        Dim dt As New DataTable()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            cboProveedor.DataSource = dt
            cboProveedor.DisplayMember = "nombre"   ' lo que se muestra
            cboProveedor.ValueMember = "id_proveedor"         ' el valor interno
            cboProveedor.SelectedIndex = -1               ' arranca vacío
        Else
            MsgBox("No hay listas de precio cargadas.", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub CargarComboInsumo()
        Dim sql As String = "SELECT id_insumo, nombre FROM Insumo"
        Dim da As New SqlDataAdapter(sql, Conexion.conexion)
        Dim dt As New DataTable()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            cboNombreInsumo.DataSource = dt
            cboNombreInsumo.DisplayMember = "nombre"   ' lo que se muestra
            cboNombreInsumo.ValueMember = "id_insumo"         ' el valor interno
            cboNombreInsumo.SelectedIndex = -1               ' arranca vacío
        Else
            MsgBox("No hay listas de precio cargadas.", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    'BOTON PARA AREGAR COMPRA
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        flag_abm = 1 'ALTA

        HabilitarDeshabilitarControles(Me, True)
        Me.btnListo.Visible = True
        Me.dtpFecha.Focus()
    End Sub


    Private Sub NuevaCompra()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL sin id_compra (identity)
        Dim sql As String = "INSERT INTO Compra (id_proveedor, fecha, tipo_compra, total) " &
                        "VALUES (" & Me.cboProveedor.SelectedValue & ", '" & Me.dtpFecha.Value.ToString("yyyy-MM-dd") & "', '" &
                        Me.cboTipoCompra.SelectedItem.ToString & "', '" & Me.txtTotal.Text & "')"

        cmd.CommandText = sql

        ' Validaciones
        If Me.cboProveedor.SelectedIndex <> -1 Then
            If Me.dtpFecha.Value <> Nothing Then
                If Me.cboTipoCompra.SelectedIndex <> -1 Then
                    If Me.txtTotal.Text <> "" Then
                        Try
                            cmd.ExecuteNonQuery()
                            llenarDetalleCompra() ' refresca listado de compras

                            ' Limpiar campos
                            Me.cboProveedor.SelectedIndex = -1
                            Me.dtpFecha.Value = DateTime.Now
                            Me.cboTipoCompra.SelectedIndex = -1
                            Me.txtTotal.Clear()
                            Me.btnListo.Visible = False
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    Else
                        MsgBox("El campo TOTAL no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    MsgBox("Debe seleccionar un TIPO DE COMPRA.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Debe seleccionar una FECHA.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Debe seleccionar un PROVEEDOR.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        flag_abm = 2
        wcp = Me.dgvDetalleCompra.CurrentRow.Cells(0).Value
        Me.cboProveedor.Text = Me.dgvDetalleCompra.CurrentRow.Cells(1).Value.ToString
        Me.dtpFecha.Text = Me.dgvDetalleCompra.CurrentRow.Cells(2).Value.ToString
        Me.cboTipoMovimiento.Text = Me.dgvDetalleCompra.CurrentRow.Cells(3).Value.ToString
        Me.txtTotal.Text = Me.dgvDetalleCompra.CurrentRow.Cells(4).Value.ToString
        Me.btnListo.Visible = True
        HabilitarDeshabilitarControles(Me, True)
        Me.dtpFecha.Focus()
    End Sub


    ' FUNCION PARA MODIFICAR COMPRA
    Private Sub ModificarCompra()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL con los campos correctos
        Dim sql As String = "UPDATE Compra SET " &
                        "id_proveedor = " & Me.cboProveedor.SelectedValue & ", " &
                        "fecha = '" & Me.dtpFecha.Value.ToString("yyyy-MM-dd") & "', " &
                        "tipo_compra = '" & Me.cboTipoMovimiento.SelectedItem.ToString & "', " &
                        "total = '" & Me.txtTotal.Text & "' " &
                        "WHERE id_compra = " & wcp

        cmd.CommandText = sql

        ' Validaciones
        If Me.cboProveedor.SelectedIndex <> -1 Then
            If Me.dtpFecha.Value <> Nothing Then
                If Me.cboTipoMovimiento.SelectedIndex <> -1 Then
                    If Me.txtTotal.Text <> "" Then
                        Try
                            cmd.ExecuteNonQuery()
                            llenarDetalleCompra() ' refresca listado de compras

                            ' Reset de campos
                            Me.cboProveedor.SelectedIndex = -1
                            Me.dtpFecha.Value = DateTime.Now
                            Me.cboTipoMovimiento.SelectedIndex = -1
                            Me.txtTotal.Clear()
                            Me.btnListo.Visible = False
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    Else
                        MsgBox("El campo TOTAL no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    MsgBox("Debe seleccionar un TIPO DE COMPRA.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Debe seleccionar una FECHA.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Debe seleccionar un PROVEEDOR.", MsgBoxStyle.Critical, "Error")
            Me.cboProveedor.Focus()
        End If
    End Sub
    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'INSERT
            NuevaCompra()
        ElseIf flag_abm = 2 Then 'UPDATE
            ModificarCompra()
        ElseIf flag_abm = 3 Then 'DELETE

        End If

        HabilitarDeshabilitarControles(Me, False)
    End Sub
    '-----------------------------------------------pagina de detalle compra carbon-------------------------------------------------------------------------------------------------
    Private Sub btnIdCompra_Click(sender As Object, e As EventArgs) Handles btnIdCompra.Click
        flag_where = 1
        Dim frm As New frmDgvCompra
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnAgregarCarbon_Click(sender As Object, e As EventArgs) Handles btnAgregarCarbon.Click
        flag_abm = 3 'ALTA

        HabilitarDeshabilitarControles(Me, True)
        Me.btnListoCarbon.Visible = True
        Me.dtpFechaMovimiento.Focus()
    End Sub

        Private Sub NuevaMovimientoCarbon()
            cmd.Connection = Conexion.conexion
            cmd.CommandType = CommandType.Text

            ' Armamos el SQL sin id_movimiento (identity)
            Dim sql As String = "INSERT INTO StockCarbon (id_compra, fecha, tipo_movimiento, cantidad_kg) " &
                            "VALUES (" & Me.txtIdCompra.Text & ", '" & Me.dtpFechaMovimiento.Value.ToString("yyyy-MM-dd") & "', '" &
                            Me.cboTipoMovimiento.SelectedItem.ToString & "', '" & Me.txtCantidadKg.Text & "')"

            cmd.CommandText = sql

            ' Validaciones
            If Me.txtIdCompra.Text <> "" AndAlso IsNumeric(Me.txtIdCompra.Text) Then
                If Me.dtpFecha.Value <> Nothing Then
                    If Me.cboTipoMovimiento.SelectedIndex <> -1 Then
                        If Me.txtCantidadKg.Text <> "" AndAlso IsNumeric(Me.txtCantidadKg.Text) Then
                            Try
                                cmd.ExecuteNonQuery()
                                llenarDetalleCompraCarbon() ' refresca listado de movimientos de carbón

                                ' Limpiar campos
                                Me.txtIdCompra.Clear()
                                Me.dtpFechaMovimiento.Value = DateTime.Now
                                Me.cboTipoMovimiento.SelectedIndex = -1
                                Me.txtCantidadKg.Clear()
                                Me.btnListo.Visible = False
                            Catch ex As Exception
                                MsgBox("Error al insertar movimiento de carbón: " & ex.Message, MsgBoxStyle.Critical, "Error")
                            End Try
                        Else
                            MsgBox("El campo CANTIDAD DE KILOS debe ser numérico y no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                        End If
                    Else
                        MsgBox("Debe seleccionar un TIPO DE MOVIMIENTO.", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    MsgBox("Debe seleccionar una FECHA.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Debe ingresar un ID DE COMPRA válido.", MsgBoxStyle.Critical, "Error")
            End If
        End Sub

    Private Sub btnModificarCarbon_Click(sender As Object, e As EventArgs) Handles btnModificarCarbon.Click
        flag_abm = 4
        wcp = Me.dgvDetalleCompraCarbon.CurrentRow.Cells(0).Value
        Me.txtIdCompra.Text = Me.dgvDetalleCompraCarbon.CurrentRow.Cells(1).Value.ToString
        Me.dtpFechaMovimiento.Text = Me.dgvDetalleCompraCarbon.CurrentRow.Cells(2).Value.ToString
        Me.cboTipoMovimiento.Text = Me.dgvDetalleCompraCarbon.CurrentRow.Cells(3).Value.ToString
        Me.txtCantidadKg.Text = Me.dgvDetalleCompraCarbon.CurrentRow.Cells(4).Value.ToString
        HabilitarDeshabilitarControles(Me, True)
        Me.btnListoCarbon.Visible = True
        Me.dtpFechaMovimiento.Focus()
    End Sub

    ' FUNCION PARA MODIFICAR MOVIMIENTO DE CARBON
    Private Sub ModificarMovimientoCarbon()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL con los campos correctos
        Dim sql As String = "UPDATE StockCarbon SET " &
                        "id_compra = " & Me.txtIdCompra.Text & ", " &
                        "fecha = '" & Me.dtpFechaMovimiento.Value.ToString("yyyy-MM-dd") & "', " &
                        "tipo_movimiento = '" & Me.cboTipoMovimiento.SelectedItem.ToString & "', " &
                        "cantidad_kg = '" & Me.txtCantidadKg.Text & "' " &
                        "WHERE id_movimiento = " & wcp

        cmd.CommandText = sql

        ' Validaciones
        If Me.txtIdCompra.Text <> "" AndAlso IsNumeric(Me.txtIdCompra.Text) Then
            If Me.dtpFecha.Value <> Nothing Then
                If Me.cboTipoMovimiento.SelectedIndex <> -1 Then
                    If Me.txtCantidadKg.Text <> "" AndAlso IsNumeric(Me.txtCantidadKg.Text) Then
                        Try
                            cmd.ExecuteNonQuery()
                            llenarDetalleCompraCarbon() ' refresca listado de movimientos

                            ' Reset de campos
                            Me.txtIdCompra.Clear()
                            Me.dtpFechaMovimiento.Value = DateTime.Now
                            Me.cboTipoMovimiento.SelectedIndex = -1
                            Me.txtCantidadKg.Clear()
                            Me.btnListo.Visible = False
                        Catch ex As Exception
                            MsgBox("Error al modificar movimiento de carbón: " & ex.Message, MsgBoxStyle.Critical, "Error")
                        End Try
                    Else
                        MsgBox("El campo CANTIDAD DE KILOS debe ser numérico y no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                        Me.txtCantidadKg.Focus()
                    End If
                Else
                    MsgBox("Debe seleccionar un TIPO DE MOVIMIENTO.", MsgBoxStyle.Critical, "Error")
                    Me.cboTipoMovimiento.Focus()
                End If
            Else
                MsgBox("Debe seleccionar una FECHA.", MsgBoxStyle.Critical, "Error")
                Me.dtpFecha.Focus()
            End If
        Else
            MsgBox("Debe ingresar un ID DE COMPRA válido.", MsgBoxStyle.Critical, "Error")
            Me.txtIdCompra.Focus()
        End If
    End Sub

    Private Sub btnListoCarbon_Click(sender As Object, e As EventArgs) Handles btnListoCarbon.Click
        If flag_abm = 3 Then 'INSERT
            NuevaMovimientoCarbon()
        ElseIf flag_abm = 4 Then 'UPDATE
            ModificarMovimientoCarbon()
        End If

        HabilitarDeshabilitarControles(Me, False)
    End Sub


    '-------------------------------------------DETALLE DE COMPRA DE INSUMO-------------------------------------------------------------------------------------------------------
    Private Sub btnIdCompraInsumo_Click(sender As Object, e As EventArgs) Handles btnIdCompraInsumo.Click
        flag_where = 2
        flag_dgv = 1
        Dim frm As New frmDgvCompra
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnAgregarDetalleInsumo_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalleInsumo.Click
        flag_abm = 5 'ALTA

        HabilitarDeshabilitarControles(Me, True)
        Me.btnListoInsumo.Visible = True
        Me.dtpFecha.Focus()
    End Sub
    Private Sub NuevaDetalleCompraInsumo()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL sin id_detalle (identity)
        Dim sql As String = "INSERT INTO DetalleCompraInsumo (id_compra, id_insumo, cantidad, precio_unitario) " &
                        "VALUES (" & Me.txtIdCompraInsumo.Text & ", " & Me.cboNombreInsumo.SelectedValue & ", " &
                        Me.txtCantidadInsumo.Text & ", " & Me.txtPrecioUnitario.Text & ") 
                        update StockInsumo set cantidad = " & Me.txtCantidadInsumo.Text & " where id_insumo = " & Me.cboNombreInsumo.SelectedValue & ""

        cmd.CommandText = sql

        ' Validaciones
        If Me.txtIdCompraInsumo.Text <> "" AndAlso IsNumeric(Me.txtIdCompraInsumo.Text) Then
            If Me.cboNombreInsumo.SelectedIndex <> -1 Then
                If Me.txtCantidadInsumo.Text <> "" AndAlso IsNumeric(Me.txtCantidadInsumo.Text) Then
                    If Me.txtPrecioUnitario.Text <> "" AndAlso IsNumeric(Me.txtPrecioUnitario.Text) Then
                        Try
                            cmd.ExecuteNonQuery()
                            llenarDetalleCompraInsumos() ' refresca listado de insumos

                            ' Reset de campos
                            Me.txtIdCompraInsumo.Clear()
                            Me.cboNombreInsumo.SelectedIndex = -1
                            Me.txtCantidadInsumo.Clear()
                            Me.txtPrecioUnitario.Clear()
                            Me.btnListo.Visible = False
                        Catch ex As Exception
                            MsgBox("Error al insertar detalle de insumo: " & ex.Message, MsgBoxStyle.Critical, "Error")
                        End Try
                    Else
                        MsgBox("El campo PRECIO UNITARIO debe ser numérico y no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                        Me.txtPrecioUnitario.Focus()
                    End If
                Else
                    MsgBox("El campo CANTIDAD debe ser numérico y no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                    Me.txtCantidadInsumo.Focus()
                End If
            Else
                MsgBox("Debe seleccionar un INSUMO.", MsgBoxStyle.Critical, "Error")
                Me.cboNombreInsumo.Focus()
            End If
        Else
            MsgBox("Debe ingresar un ID DE COMPRA válido.", MsgBoxStyle.Critical, "Error")
            Me.txtIdCompraInsumo.Focus()
        End If
    End Sub


    Private Sub btnModificarInsumo_Click(sender As Object, e As EventArgs) Handles btnModificarInsumo.Click
        flag_abm = 6
        wcp = Me.dgvDetalleCompraInsumos.CurrentRow.Cells(0).Value
        Me.txtIdCompraInsumo.Text = Me.dgvDetalleCompraInsumos.CurrentRow.Cells(1).Value.ToString
        Me.cboNombreInsumo.Text = Me.dgvDetalleCompraInsumos.CurrentRow.Cells(2).Value.ToString
        Me.txtCantidadInsumo.Text = Me.dgvDetalleCompraInsumos.CurrentRow.Cells(3).Value.ToString
        Me.txtPrecioUnitario.Text = Me.dgvDetalleCompraInsumos.CurrentRow.Cells(4).Value.ToString
        HabilitarDeshabilitarControles(Me, True)
        Me.btnListoCarbon.Visible = True
        Me.cboNombreInsumo.Focus()
    End Sub

    Private Sub ModificarDetalleCompraInsumo()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL con los campos correctos
        Dim sql As String = "UPDATE DetalleCompraInsumo SET " &
                        "id_compra = " & Me.txtIdCompraInsumo.Text & ", " &
                        "id_insumo = " & Me.cboNombreInsumo.SelectedValue & ", " &
                        "cantidad = " & Me.txtCantidadInsumo.Text & ", " &
                        "precio_unitario = " & Me.txtPrecioUnitario.Text & " " &
                        "WHERE id_detalle = " & wcp & "; " &
                                                            _
                        "UPDATE StockInsumo SET cantidad = cantidad + " & Me.txtCantidadInsumo.Text & " " &
                        "WHERE id_insumo = " & Me.cboNombreInsumo.SelectedValue

        cmd.CommandText = sql

        ' Validaciones
        If Me.txtIdCompraInsumo.Text <> "" AndAlso IsNumeric(Me.txtIdCompraInsumo.Text) Then
            If Me.cboNombreInsumo.SelectedIndex <> -1 Then
                If Me.txtCantidadInsumo.Text <> "" AndAlso IsNumeric(Me.txtCantidadInsumo.Text) Then
                    If Me.txtPrecioUnitario.Text <> "" AndAlso IsNumeric(Me.txtPrecioUnitario.Text) Then
                        Try
                            cmd.ExecuteNonQuery()
                            llenarDetalleCompraInsumos() ' refresca listado de insumos

                            ' Reset de campos
                            Me.txtIdCompraInsumo.Clear()
                            Me.cboNombreInsumo.SelectedIndex = -1
                            Me.txtCantidadInsumo.Clear()
                            Me.txtPrecioUnitario.Clear()
                            Me.btnListo.Visible = False
                        Catch ex As Exception
                            MsgBox("Error al modificar detalle de compra y actualizar stock: " & ex.Message, MsgBoxStyle.Critical, "Error")
                        End Try
                    Else
                        MsgBox("El campo PRECIO UNITARIO debe ser numérico y no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                        Me.txtPrecioUnitario.Focus()
                    End If
                Else
                    MsgBox("El campo CANTIDAD debe ser numérico y no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                    Me.txtCantidadInsumo.Focus()
                End If
            Else
                MsgBox("Debe seleccionar un INSUMO.", MsgBoxStyle.Critical, "Error")
                Me.cboNombreInsumo.Focus()
            End If
        Else
            MsgBox("Debe ingresar un ID DE COMPRA válido.", MsgBoxStyle.Critical, "Error")
            Me.txtIdCompraInsumo.Focus()
        End If
    End Sub

    Private Sub btnListoInsumo_Click(sender As Object, e As EventArgs) Handles btnListoInsumo.Click
        If flag_abm = 5 Then 'INSERT
            NuevaDetalleCompraInsumo()
        ElseIf flag_abm = 6 Then 'UPDATE
            ModificarDetalleCompraInsumo()
        End If

        HabilitarDeshabilitarControles(Me, False)
    End Sub


End Class