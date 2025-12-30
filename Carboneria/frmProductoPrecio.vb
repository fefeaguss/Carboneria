Imports System.Data.SqlClient

Public Class frmProductoPrecio
    Private Sub frmProductoPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarProductoPrecio()
        CargarComboProductos()
        CargarComboListaPrecio()
    End Sub

    Private Sub llenarProductoPrecio()

        Dim sql As String = "select ProductoPrecio.id_producto AS 'ID PRODUCTO', Producto.nombre as 'NOMBRE DEL PRODUCTO', 
                            ListaPrecio.nombre_lista AS 'NOMBRE DE LISTA PRECIO', precio as 'PRECIO' from ProductoPrecio
                            inner join Producto on ProductoPrecio.id_producto = Producto.id_producto
                            inner join ListaPrecio on ProductoPrecio.id_lista = ListaPrecio.id_lista"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("ProductoPrecio")
        adp.Fill(ds.Tables("ProductoPrecio"))
        Me.dgvProductoPrecio.DataSource = ds.Tables("ProductoPrecio")
    End Sub

    ' Cargar ComboBox de Productos
    Private Sub CargarComboProductos()
        Dim sql As String = "SELECT id_producto, nombre FROM Producto "
        Dim da As New SqlDataAdapter(sql, Conexion.conexion)
        Dim dt As New DataTable()
        da.Fill(dt)

        ' Asignar al ComboBox
        Me.cboNombreProducto.DataSource = dt
        Me.cboNombreProducto.DisplayMember = "nombre"   ' lo que se muestra
        Me.cboNombreProducto.ValueMember = "id_producto" ' el valor interno
        Me.cboNombreProducto.SelectedIndex = -1          ' que arranque vacío
    End Sub

    'cargar ComboBox de Lista de Precios
    Private Sub CargarComboListaPrecio()
        Dim sql As String = "SELECT id_lista, nombre_lista FROM ListaPrecio"
        Dim da As New SqlDataAdapter(sql, Conexion.conexion)
        Dim dt As New DataTable()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            cboListaPrecio.DataSource = dt
            cboListaPrecio.DisplayMember = "nombre_lista"   ' lo que se muestra
            cboListaPrecio.ValueMember = "id_lista"         ' el valor interno
            cboListaPrecio.SelectedIndex = -1               ' arranca vacío
        Else
            MsgBox("No hay listas de precio cargadas.", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub


    'boton AGREGAR PRECIO DE PRODUCTO
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        flag_abm = 1 'ALTA

        HabilitarDeshabilitarControles(Me, True)
        Me.btnListo.Visible = True
        Me.cboNombreProducto.Focus()

    End Sub

    ' FUNCION PARA GENERAR PRODUCTO PRECIO
    Private Sub NuevoProductoPrecio()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL sin id_productoPrecio (identity)
        Dim sql As String = "INSERT INTO ProductoPrecio (id_producto, id_lista, precio) " &
                        "VALUES (" & Me.cboNombreProducto.SelectedValue & ", " & Me.cboListaPrecio.SelectedValue & ", '" & Me.txtPrecio.Text & "')"

        cmd.CommandText = sql

        ' Validaciones
        If Me.cboNombreProducto.SelectedIndex <> -1 Then
            If Me.cboListaPrecio.SelectedIndex <> -1 Then
                If Me.txtPrecio.Text <> "" Then
                    Try
                        cmd.ExecuteNonQuery()
                        llenarProductoPrecio() ' refresca listado de precios

                        ' Limpiar campos
                        Me.cboNombreProducto.SelectedIndex = -1
                        Me.cboListaPrecio.SelectedIndex = -1
                        Me.txtPrecio.Clear()
                        Me.btnListo.Visible = False
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    MsgBox("El campo PRECIO no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Debe seleccionar una LISTA DE PRECIO.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Debe seleccionar un PRODUCTO.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        flag_abm = 2
        wcp = Me.dgvProductoPrecio.CurrentRow.Cells(0).Value
        Me.cboNombreProducto.Text = Me.dgvProductoPrecio.CurrentRow.Cells(1).Value.ToString
        Me.cboListaPrecio.Text = Me.dgvProductoPrecio.CurrentRow.Cells(2).Value.ToString
        Me.txtPrecio.Text = Me.dgvProductoPrecio.CurrentRow.Cells(3).Value.ToString
        Me.btnListo.Visible = True
        HabilitarDeshabilitarControles(Me, True)
        Me.cboNombreProducto.Focus()
    End Sub

    ' FUNCION PARA MODIFICAR PRODUCTO PRECIO
    Private Sub ModificarProductoPrecio()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL con los campos correctos
        Dim sql As String = "UPDATE ProductoPrecio SET " &
                        "id_producto = " & Me.cboNombreProducto.SelectedValue & ", " &
                        "id_lista = " & Me.cboListaPrecio.SelectedValue & ", " &
                        "precio = '" & Me.txtPrecio.Text & "' " &
                        "WHERE id_producto = " & wcp

        cmd.CommandText = sql

        ' Validaciones
        If Me.cboNombreProducto.SelectedIndex <> -1 Then
            If Me.cboListaPrecio.SelectedIndex <> -1 Then
                If Me.txtPrecio.Text <> "" Then
                    Try
                        cmd.ExecuteNonQuery()
                        llenarProductoPrecio() ' refresca listado de precios

                        ' Reset de campos
                        Me.cboNombreProducto.SelectedIndex = -1
                        Me.cboListaPrecio.SelectedIndex = -1
                        Me.txtPrecio.Clear()
                        Me.btnListo.Visible = False
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    MsgBox("El campo PRECIO no puede estar vacío.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Debe seleccionar una LISTA DE PRECIO.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Debe seleccionar un PRODUCTO.", MsgBoxStyle.Critical, "Error")
            Me.cboNombreProducto.Focus()
        End If
    End Sub

    'boton ELIMINAR PRECIO DE PRODUCTO
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        flag_abm = 3
        wcp = Me.dgvProductoPrecio.CurrentRow.Cells(0).Value
        Me.cboNombreProducto.Text = Me.dgvProductoPrecio.CurrentRow.Cells(1).Value.ToString
        Me.cboListaPrecio.Text = Me.dgvProductoPrecio.CurrentRow.Cells(2).Value.ToString
        Me.txtPrecio.Text = Me.dgvProductoPrecio.CurrentRow.Cells(3).Value.ToString
        Me.btnListo.Visible = True
        HabilitarDeshabilitarControles(Me, True)
        Me.cboNombreProducto.Focus()
    End Sub


    ' FUNCION PARA ELIMINAR PRODUCTO PRECIO
    Private Sub EliminarProductoPrecio()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Eliminamos el registro de ProductoPrecio según su ID
        Dim sql As String = "DELETE FROM ProductoPrecio WHERE id_Precio = " & wcp
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()

            ' Refrescar listado
            llenarProductoPrecio()

            ' Limpiar campos
            Me.cboNombreProducto.SelectedIndex = -1
            Me.cboListaPrecio.SelectedIndex = -1
            Me.txtPrecio.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'INSERT
            NuevoProductoPrecio()
        ElseIf flag_abm = 2 Then 'UPDATE
            ModificarProductoPrecio()
        ElseIf flag_abm = 3 Then 'DELETE
            EliminarProductoPrecio()
        End If

        HabilitarDeshabilitarControles(Me, False)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class