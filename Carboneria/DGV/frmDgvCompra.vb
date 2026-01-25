Public Class frmDgvCompra
    Private Sub frmDgvCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If flag_dgv = 0 Then
            llenarDetalleCompraCarbon()
        ElseIf flag_dgv = 1 Then
            llenarDetalleCompraInsumo()
        ElseIf flag_dgv = 2 Then
            llenarDetalleCompraProducto()
        End If
        flag_dgv = 0
    End Sub

    Private Sub llenarDetalleCompraCarbon()
        flag_dgv = 0
        Dim sql As String = "select compra.id_compra AS 'ID COMPRA', Proveedor.nombre AS NOMBRE, fecha as 'FECHA DE COMPRA',
                   tipo_compra AS 'TIPO DE COMPRA', total AS TOTAL  from compra
                   inner join Proveedor on Compra.id_proveedor = Proveedor.id_proveedor where tipo_compra = 'CARBON'"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("compra")
        adp.Fill(ds.Tables("compra"))
        Me.dgvDetalleCompra.DataSource = ds.Tables("compra")
    End Sub

    Private Sub llenarDetalleCompraInsumo()
        flag_dgv = 1
        Dim sql As String = "select compra.id_compra AS 'ID COMPRA', Proveedor.nombre AS NOMBRE, fecha as 'FECHA DE COMPRA',
                   tipo_compra AS 'TIPO DE COMPRA', total AS TOTAL  from compra
                   inner join Proveedor on Compra.id_proveedor = Proveedor.id_proveedor where tipo_compra = 'INSUMO'"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("compra")
        adp.Fill(ds.Tables("compra"))
        Me.dgvDetalleCompra.DataSource = ds.Tables("compra")
    End Sub

    Private Sub llenarDetalleCompraProducto()
        flag_dgv = 2
        Dim sql As String = "select compra.id_compra AS 'ID COMPRA', Proveedor.nombre AS NOMBRE, fecha as 'FECHA DE COMPRA',
                   tipo_compra AS 'TIPO DE COMPRA', total AS TOTAL  from compra
                   inner join Proveedor on Compra.id_proveedor = Proveedor.id_proveedor where tipo_compra = 'PRODUCTO'"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("compra")
        adp.Fill(ds.Tables("compra"))
        Me.dgvDetalleCompra.DataSource = ds.Tables("compra")
    End Sub


    'Private Sub dgvDetalleCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDetalleCompra.KeyDown
    '    If flag_where = 1 Then
    '        If e.KeyData = Keys.Enter Then
    '            Dim frm As frmCompras = CType(Owner, frmCompras)

    '            ' Accedemos al TextBox dentro del TabPage pgDetalleCompraCarbon
    '            Dim txtIdCompra As TextBox = CType(frm.pgDetalleCompraCarbon.Controls("txtIdCompra"), TextBox)
    '            txtIdCompra.Text = Me.dgvDetalleCompra.CurrentRow.Cells(0).Value.ToString()

    '            Me.Close()
    '        End If

    '    ElseIf flag_where = 2 Then
    '        If e.KeyData = Keys.Enter Then
    '            Dim frm As frmCompras = CType(Owner, frmCompras)

    '            ' Accedemos al TextBox dentro del TabPage pgDetalleCompraCarbon
    '            Dim txtIdCompra As TextBox = CType(frm.pgDetalleCompraInsumos.Controls("txtIdCompraInsumo"), TextBox)
    '            txtIdCompra.Text = Me.dgvDetalleCompra.CurrentRow.Cells(0).Value.ToString()

    '            Me.Close()
    '        End If

    '    ElseIf flag_where = 3 Then
    '        If e.KeyData = Keys.Enter Then
    '            Dim frm As frmCompras = CType(Owner, frmCompras)
    '            ' Accedemos al TextBox dentro del TabPage pgDetalleCompraCarbon
    '            Dim txtIdCompra As TextBox = CType(frm.pgDetalleCompraProductos.Controls("txtIdCompraProducto"), TextBox)
    '            txtIdCompra.Text = Me.dgvDetalleCompra.CurrentRow.Cells(0).Value.ToString()
    '            Me.Close()
    '        End If
    '        flag_where = 0
    '    End If
    'End Sub
End Class