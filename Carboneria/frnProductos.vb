Public Class frnProductos
    Private Sub frnProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarProducto()
    End Sub

    Private Sub llenarProducto()

        Dim sql As String = "select id_producto as 'ID PRODUCTO', nombre as 'NOMBRE DE PRODCUTO',  
                             peso_Kg AS 'PESO EN KG', activo AS 'activo' from Producto"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("Producto")
        adp.Fill(ds.Tables("Producto"))
        Me.dgvProductos.DataSource = ds.Tables("Producto")
    End Sub

    'BOTON PARA AGREGAR PRODUCTO
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        flag_abm = 1 'ALTA

        HabilitarDeshabilitarControles(Me, True)
        Me.btnListo.Visible = True
        Me.txtNombre_Producto.Focus()
    End Sub

    ' FUNCION PARA GENERAR PRODUCTO
    Private Sub NuevoProducto()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL sin id_producto (identity) ni activo (default 1)
        Dim sql As String = "INSERT INTO Producto (nombre, peso_Kg) " &
                        "VALUES ('" & Me.txtNombre_Producto.Text & "', '" & Me.txtPeso.Text & "')"

        cmd.CommandText = sql

        ' Validaciones
        If Me.txtNombre_Producto.Text <> "" Then
            If Me.txtPeso.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    llenarProducto() ' función que refresca el listado de productos

                    ' Limpiar campos
                    Me.txtNombre_Producto.Clear()
                    Me.txtPeso.Clear()
                    Me.btnListo.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo PESO EN KG no puede estar vacío.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo NOMBRE DE PRODUCTO no puede estar vacío.", MsgBoxStyle.Critical, "Error")
            Me.txtNombre_Producto.Focus()
        End If
    End Sub

    'BOTON PARA MODIFICAR PRODUCTO
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        flag_abm = 2
        wcp = Me.dgvProductos.CurrentRow.Cells(0).Value
        Me.txtNombre_Producto.Text = Me.dgvProductos.CurrentRow.Cells(1).Value.ToString
        Me.txtPeso.Text = Me.dgvProductos.CurrentRow.Cells(2).Value.ToString
        Me.btnListo.Visible = True
        HabilitarDeshabilitarControles(Me, True)
        Me.txtNombre_Producto.Focus()
    End Sub


    ' FUNCION PARA MODIFICAR PRODUCTO
    Private Sub ModificarProducto()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL con los campos correctos
        Dim sql As String = "UPDATE Producto SET " &
                        "nombre = '" & Me.txtNombre_Producto.Text & "', " &
                        "peso_Kg = '" & Me.txtPeso.Text & "' " &
                        "WHERE id_producto = " & wcp

        cmd.CommandText = sql

        ' Validaciones
        If Me.txtNombre_Producto.Text <> "" Then
            If Me.txtPeso.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    llenarProducto() ' refresca listado de productos

                    ' Reset de campos
                    Me.txtNombre_Producto.Clear()
                    Me.txtPeso.Clear()
                    Me.btnListo.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo PESO EN KG no puede estar vacío.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo NOMBRE DE PRODUCTO no puede estar vacío.", MsgBoxStyle.Critical, "Error")
            Me.txtNombre_Producto.Focus()
        End If
    End Sub


    'boton para eliminar producto
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        flag_abm = 3
        wcp = Me.dgvProductos.CurrentRow.Cells(0).Value
        Me.txtNombre_Producto.Text = Me.dgvProductos.CurrentRow.Cells(1).Value.ToString
        Me.txtPeso.Text = Me.dgvProductos.CurrentRow.Cells(2).Value.ToString
        Me.btnListo.Visible = True
        HabilitarDeshabilitarControles(Me, True)
        Me.btnToggleProducto.Visible = True
        Me.txtNombre_Producto.Focus()
    End Sub


    ' FUNCION PARA BAJA LOGICA DE PRODUCTO
    Private Sub BajaLogicaProducto()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' En vez de eliminar, marcamos como inactivo
        Dim sql As String = "UPDATE Producto SET activo = 0 WHERE id_producto = " & wcp
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()

            llenarProducto() ' refresca listado de productos

            ' Limpiar campos
            Me.txtNombre_Producto.Clear()
            Me.txtPeso.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        btnToggleProducto.Visible = False
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'INSERT
            NuevoProducto()
        ElseIf flag_abm = 2 Then 'UPDATE
            ModificarProducto()
        ElseIf flag_abm = 3 Then 'DELETE
            BajaLogicaProducto()

        End If


        HabilitarDeshabilitarControles(Me, False)
    End Sub

    Private Sub ToggleProducto()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Marcamos como activo nuevamente
        Dim sql As String = "UPDATE Producto SET activo = 1 WHERE id_producto = " & wcp
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()

            llenarProducto() ' refresca listado de productos

            ' Limpiar campos
            Me.txtNombre_Producto.Clear()
            Me.txtPeso.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnToggleProducto_Click(sender As Object, e As EventArgs) Handles btnToggleProducto.Click
        ToggleProducto()
        btnToggleProducto.Visible = False
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class