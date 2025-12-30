Imports System.Data.SqlClient

Public Class frmCompras
    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTipoCompra()
    End Sub

    Private Sub LlenarDetalleCompra(id_compra As Integer, tipo_compra As String)
        Dim sql As String = ""
        Dim ds As New DataSet()
        Dim adp As SqlClient.SqlDataAdapter

        If String.IsNullOrEmpty(tipo_compra) Or tipo_compra = "CARBON" Then
            ' Mostrar TODAS las compras (cabecera + detalle)
            sql = "select compra.id_compra AS 'ID COMPRA', Proveedor.nombre AS NOMBRE, fecha as 'FECHA DE COMPRA',
                   tipo_compra AS 'TIPO DE COMPRA', total AS TOTAL  from compra
                   inner join Proveedor on Compra.id_proveedor = Proveedor.id_proveedor"

            adp = New SqlClient.SqlDataAdapter(sql, Conexion.conexion)
            ds.Tables.Add("Compra")
            adp.Fill(ds.Tables("Compra"))
            dgvCompras.DataSource = ds.Tables("Compra")

            ' Mostrar solo el grid general
            dgvCompras.Visible = True
            dgvDetalleCompraProdcuto.Visible = False
            dgvDetalleCompraInsumo.Visible = False

        ElseIf tipo_compra = "PRODUCTO" Then
            sql = "SELECT id_detalle AS 'ID DETALLE',id_compra as 'ID COMPRA', Producto.nombre as 'NOMBRE DE PRODUCTO', 
                   cantidad AS CANTIDAD, precio_unitario AS 'PRECIO UNITARIO', subtotal AS SUBTOTAL
                   FROM DetalleCompraProducto
                   INNER JOIN Producto ON DetalleCompraProducto.id_producto = Producto.id_producto
                   WHERE id_detalle =  " & id_compra

            adp = New SqlClient.SqlDataAdapter(sql, Conexion.conexion)
            ds.Tables.Add("DetalleCompraProducto")
            adp.Fill(ds.Tables("DetalleCompraProducto"))
            dgvDetalleCompraProdcuto.DataSource = ds.Tables("DetalleCompraProducto")

            dgvDetalleCompraProdcuto.Visible = True
            dgvDetalleCompraInsumo.Visible = False
            dgvCompras.Visible = False

        ElseIf tipo_compra = "INSUMO" Then
            sql = "SELECT id_detalle as 'ID DETALLE', Insumo.nombre as 'NOMBRE DE INSUMO', cantidad AS CANTIDAD, 
                   precio_unitario AS 'PRECIO UNITARIO' FROM DetalleCompraInsumo
                   INNER JOIN Insumo ON Insumo.id_insumo = DetalleCompraInsumo.id_insumo
                   WHERE id_compra = " & id_compra

            adp = New SqlClient.SqlDataAdapter(sql, Conexion.conexion)
            ds.Tables.Add("DetalleCompraInsumo")
            adp.Fill(ds.Tables("DetalleCompraInsumo"))
            dgvDetalleCompraInsumo.DataSource = ds.Tables("DetalleCompraInsumo")

            dgvDetalleCompraInsumo.Visible = True
            dgvDetalleCompraProdcuto.Visible = False
            dgvCompras.Visible = False
        End If
    End Sub
    Private Sub cboTipoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCompra.SelectedIndexChanged
        If cboTipoCompra.SelectedIndex <> -1 Then
            Dim tipo As String = cboTipoCompra.SelectedItem.ToString()
            ' Acá deberías pasar el id_compra real, por ahora uso 0 como ejemplo
            LlenarDetalleCompra(0, tipo)
        End If
    End Sub


    Private Sub CargarTipoCompra()
        ' Limpiar ítems previos
        cboTipoCompra.Items.Clear()

        ' Agregar opciones fijas
        cboTipoCompra.Items.Add("INSUMO")
        cboTipoCompra.Items.Add("CARBON")
        cboTipoCompra.Items.Add("PRODUCTO")

        ' Arrancar vacío
        cboTipoCompra.SelectedIndex = -1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click

    End Sub
End Class