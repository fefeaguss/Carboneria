Public Class frmProductoPrecio
    Private Sub frmProductoPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarProductoPrecio()
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
End Class