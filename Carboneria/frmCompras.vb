
Imports System.Data.SqlClient

Public Class frmCompras


    Dim totalCompra As Decimal = 0
    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProveedores()
        CargarTiposCompra()
        ConfigurarGrilla()
        dgvDetalle.AllowUserToAddRows = False ' Quita la fila del asterisco *
    End Sub

    Private Sub CargarProveedores()
        Try
            conectar()

            cmd.Connection = Conexion.conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT id_proveedor, nombre FROM Proveedor"

            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())

            cboProveedor.DataSource = dt
            cboProveedor.DisplayMember = "nombre"
            cboProveedor.ValueMember = "id_proveedor"
            cboProveedor.SelectedIndex = -1

            desconectar() ' Cerramos
        Catch ex As Exception
            MsgBox("Error al cargar proveedores: " & ex.Message)
            desconectar()
        End Try
    End Sub

    Private Sub CargarTiposCompra()
        ' Llenamos el combo de tipos manualmente
        cboTipoCompra.Items.Clear()
        cboTipoCompra.Items.Add("CARBON")
        cboTipoCompra.Items.Add("INSUMO")
        cboTipoCompra.Items.Add("PRODUCTO")
    End Sub

    Private Sub ConfigurarGrilla()
        dgvDetalle.Columns.Clear()

        ' --- PARTE 1: HACERLO MÁS ALTO ---
        ' La altura estándar es +/- 22. Pongámosle 40 para que sea bien alto.
        dgvDetalle.RowTemplate.Height = 45
        ' ---------------------------------


        ' 1. Columna ID (Invisible)
        dgvDetalle.Columns.Add("colId", "ID")
        dgvDetalle.Columns("colId").Visible = False

        ' 2. y 3. Columnas Normales (Usando FillWeight para que queden parejas como pediste antes)
        dgvDetalle.Columns.Add("colNombre", "Ítem")
        dgvDetalle.Columns("colNombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvDetalle.Columns("colNombre").FillWeight = 200 ' Nombre más ancho

        dgvDetalle.Columns.Add("colCantidad", "Cant/Peso")
        dgvDetalle.Columns("colCantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvDetalle.Columns("colCantidad").FillWeight = 100

        dgvDetalle.Columns.Add("colPrecio", "Precio Unit.")
        dgvDetalle.Columns("colPrecio").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvDetalle.Columns("colPrecio").FillWeight = 100

        dgvDetalle.Columns.Add("colSubtotal", "Subtotal")
        dgvDetalle.Columns("colSubtotal").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvDetalle.Columns("colSubtotal").FillWeight = 100

        ' --- PARTE 2: EL BOTÓN ROJO ---
        Dim btnEliminar As New DataGridViewButtonColumn()
        btnEliminar.Name = "colEliminar"
        btnEliminar.HeaderText = "Acción"
        btnEliminar.Text = "X LIBERAR" ' Un texto más corto a veces queda mejor si es alto
        btnEliminar.UseColumnTextForButtonValue = True
        btnEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        btnEliminar.FillWeight = 80

        ' IMPORTANTE: Cambiar el estilo a FLAT para que tome los colores
        btnEliminar.FlatStyle = FlatStyle.Flat

        ' Creamos un estilo personalizado
        Dim estiloRojo As New DataGridViewCellStyle()
        estiloRojo.BackColor = Color.Firebrick  ' Un rojo intenso pero profesional
        estiloRojo.ForeColor = Color.White      ' Texto blanco para que resalte
        estiloRojo.Font = New Font(dgvDetalle.Font, FontStyle.Bold) ' Texto en negrita
        estiloRojo.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Aplicamos el estilo a la columna del botón
        btnEliminar.DefaultCellStyle = estiloRojo
        ' ------------------------------

        dgvDetalle.Columns.Add(btnEliminar)
    End Sub

    Private Sub cboTipoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCompra.SelectedIndexChanged
        ' Limpiezas generales...
        cboItemArticulo.DataSource = Nothing
        cboItemArticulo.Items.Clear() ' Importante limpiar items manuales
        txtCantidad.Text = ""
        txtPrecioUnitario.Text = ""
        dgvDetalle.Rows.Clear()

        Dim query As String = ""

        Select Case cboTipoCompra.Text
            Case "INSUMO"
                ' Pasamos la consulta normal Y el nombre del ID real
                CargarComboArticulos("SELECT id_insumo, nombre FROM Insumo", "id_insumo")

            Case "PRODUCTO"
                ' Pasamos la consulta normal Y el nombre del ID real
                CargarComboArticulos("SELECT id_producto, nombre FROM Producto", "id_producto")

            Case "CARBON"
                ' Recuerda que este era manual, así que no llama a esta función
        End Select
    End Sub
    ' Agregamos un segundo parámetro: nombreColumnaId
    Private Sub CargarComboArticulos(consultaSql As String, nombreColumnaId As String)
        Try



            conectar()
            cmd.Connection = Conexion.conexion ' Usar la variable del Module
            cmd.CommandText = consultaSql

            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())

            cboItemArticulo.DataSource = dt
            cboItemArticulo.DisplayMember = "nombre"

            ' AQUÍ LA MAGIA: Usamos el nombre real de la columna
            cboItemArticulo.ValueMember = nombreColumnaId

            desconectar()
        Catch ex As Exception
            MsgBox("Error al cargar artículos: " & ex.Message)
            desconectar()
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        '1. Validaciones básicas
        If Not IsNumeric(txtCantidad.Text) OrElse CDec(txtCantidad.Text) <= 0 Then
            MessageBox.Show("Ingrese una cantidad válida.")
            Return
        End If
        If Not IsNumeric(txtPrecioUnitario.Text) OrElse CDec(txtPrecioUnitario.Text) <= 0 Then
            MessageBox.Show("Ingrese un precio válido.")
            Return
        End If

        ' --- INICIO DE LA CORRECCIÓN ---
        Dim idArticulo As Integer = 0
        Dim nombreArticulo As String = ""

        If cboTipoCompra.Text = "CARBON" Then
            ' Caso especial: Carbón
            idArticulo = 0
            nombreArticulo = "Carbón a Granel"
        Else
            ' Caso Insumos o Productos: Validamos que haya seleccionado algo real
            If cboItemArticulo.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, seleccione un artículo de la lista.")
                Return
            End If

            ' Tomamos los datos del combo (Solo si NO es carbón)
            idArticulo = Convert.ToInt32(cboItemArticulo.SelectedValue)
            nombreArticulo = cboItemArticulo.Text
        End If
        ' --- FIN DE LA LÓGICA DE SELECCIÓN ---

        ' 2. Calcular valores
        Dim cantidad As Decimal = CDec(txtCantidad.Text)
        Dim precio As Decimal = CDec(txtPrecioUnitario.Text)
        Dim subtotal As Decimal = cantidad * precio

        ' NOTA: AQUÍ BORRÉ LAS LÍNEAS REPETIDAS QUE TE DABAN ERROR
        ' (Dim idArticulo As Integer = ... y Dim nombreArticulo As String = ...)
        ' Ya tenemos los valores correctos en las variables de arriba.

        ' 3. Agregar a la Grilla
        dgvDetalle.Rows.Add(idArticulo, nombreArticulo, cantidad, precio, subtotal)

        ' 4. Actualizar Total General visual
        totalCompra += subtotal
        lblTotal.Text = "TOTAL: $" & totalCompra.ToString("N2")

        ' 5. Limpiar casillas para el siguiente ítem
        txtCantidad.Text = ""
        txtPrecioUnitario.Text = ""

        ' Volvemos el foco al combo solo si no es carbón (opcional)
        If cboTipoCompra.Text <> "CARBON" Then
            cboItemArticulo.Focus()
        Else
            txtCantidad.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' 1. Validaciones
        If dgvDetalle.Rows.Count = 0 Then
            MsgBox("Debe agregar al menos un ítem a la compra.")
            Return
        End If
        If cboProveedor.SelectedIndex = -1 Then
            MsgBox("Seleccione un proveedor.")
            Return
        End If

        Try
            conectar()

            ' INICIAR TRANSACCIÓN (Seguridad total)
            Dim transaccion As SqlClient.SqlTransaction = Conexion.conexion.BeginTransaction()
            cmd.Connection = Conexion.conexion
            cmd.Transaction = transaccion

            ' A. INSERTAR CABECERA (TABLA COMPRA)
            cmd.Parameters.Clear()
            cmd.CommandText = "INSERT INTO Compra (id_proveedor, fecha, tipo_compra, total) " &
                          "VALUES (@idProv, @fecha, @tipo, @total); " &
                          "SELECT SCOPE_IDENTITY();"

            cmd.Parameters.AddWithValue("@idProv", cboProveedor.SelectedValue)
            cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value)
            cmd.Parameters.AddWithValue("@tipo", cboTipoCompra.Text) ' Ojo: verifica si tu control se llama cboTipoCompra o cmbTipoCompra
            cmd.Parameters.AddWithValue("@total", CDec(totalCompra))

            ' Obtenemos el ID de la compra recién creada
            Dim idCompraGenerado As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' B. RECORRER GRILLA E INSERTAR DETALLES
            For Each fila As DataGridViewRow In dgvDetalle.Rows
                ' 1. PROTECCIÓN CONTRA LA FILA VACÍA (*)
                ' Si es la fila nueva del final, la ignoramos y pasamos a la siguiente.
                If fila.IsNewRow Then Continue For

                ' 2. OBTENER EL ID (Con protección si no encuentra la columna colId)
                Dim idItem As Integer = 0

                ' Intentamos leer por nombre "colId", si falla, leemos la columna 0 (índice)
                If dgvDetalle.Columns.Contains("colId") Then
                    idItem = CInt(fila.Cells("colId").Value)
                Else
                    ' Si no le cambiaste el nombre, asumimos que es la primera columna (índice 0)
                    idItem = CInt(fila.Cells(0).Value)
                End If

                Dim cantidad As Decimal = CDec(fila.Cells(2).Value) ' Verifica que Cantidad sea la columna 2
                Dim precio As Decimal = CDec(fila.Cells(3).Value)   ' Verifica que Precio sea la columna 3

                Select Case cboTipoCompra.Text
                    Case "CARBON"
                        ' --- CASO CARBÓN ---
                        cmd.Parameters.Clear() ' Limpiamos por seguridad
                        cmd.CommandText = "INSERT INTO StockCarbon (fecha, tipo_movimiento, cantidad_kg, id_compra) " &
                                      "VALUES (@fecha, 'COMPRA', @cant, @idCompra)"

                        cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value)
                        cmd.Parameters.AddWithValue("@cant", cantidad)
                        cmd.Parameters.AddWithValue("@idCompra", idCompraGenerado)
                        cmd.ExecuteNonQuery()

                    Case "INSUMO"
                        ' --- PASO 1: INSERTAR DETALLE ---
                        cmd.Parameters.Clear() ' <--- LIMPIAR ANTES DE EMPEZAR
                        cmd.CommandText = "INSERT INTO DetalleCompraInsumo (id_compra, id_insumo, cantidad, precio_unitario) " &
                                      "VALUES (@idCompra, @idItem, @cant, @prec)"

                        cmd.Parameters.AddWithValue("@idCompra", idCompraGenerado)
                        cmd.Parameters.AddWithValue("@idItem", idItem)
                        cmd.Parameters.AddWithValue("@cant", cantidad)
                        cmd.Parameters.AddWithValue("@prec", precio)
                        cmd.ExecuteNonQuery()

                        ' --- PASO 2: ACTUALIZAR STOCK (AQUÍ ESTABA EL ERROR) ---
                        cmd.Parameters.Clear() ' <--- ¡ESTA LÍNEA ES FUNDAMENTAL!

                        cmd.CommandText = "UPDATE StockInsumo SET cantidad = cantidad + @cant WHERE id_insumo = @idItem"
                        ' Volvemos a agregar SOLO los necesarios para el Update
                        cmd.Parameters.AddWithValue("@cant", cantidad)
                        cmd.Parameters.AddWithValue("@idItem", idItem)
                        cmd.ExecuteNonQuery()

                    Case "PRODUCTO"
                        ' --- PASO 1: INSERTAR DETALLE ---
                        cmd.Parameters.Clear() ' <--- LIMPIAR
                        cmd.CommandText = "INSERT INTO DetalleCompraProducto (id_compra, id_producto, cantidad, precio_unitario) " &
                                      "VALUES (@idCompra, @idItem, @cant, @prec)"

                        cmd.Parameters.AddWithValue("@idCompra", idCompraGenerado)
                        cmd.Parameters.AddWithValue("@idItem", idItem)
                        cmd.Parameters.AddWithValue("@cant", cantidad)
                        cmd.Parameters.AddWithValue("@prec", precio)
                        cmd.ExecuteNonQuery()

                        ' --- PASO 2: ACTUALIZAR STOCK ---
                        cmd.Parameters.Clear() ' <--- ¡NO OLVIDAR ESTA LÍNEA!

                        cmd.CommandText = "UPDATE StockProducto SET cantidad = cantidad + @cant WHERE id_producto = @idItem"
                        cmd.Parameters.AddWithValue("@cant", cantidad)
                        cmd.Parameters.AddWithValue("@idItem", idItem)
                        cmd.ExecuteNonQuery()

                End Select
            Next

            ' C. CONFIRMAR TODO
            transaccion.Commit()
            MsgBox("Compra registrada exitosamente.")

            ' Limpiar formulario para nueva carga
            dgvDetalle.Rows.Clear()
            lblTotal.Text = "TOTAL: $0.00"
            totalCompra = 0
            desconectar()

        Catch ex As Exception
            ' Si algo falla, deshacemos todo
            Try
                If cmd.Transaction IsNot Nothing Then cmd.Transaction.Rollback()
            Catch
            End Try

            MsgBox("Error al guardar la compra: " & ex.Message)
            desconectar()
        End Try
    End Sub

    Private Sub dgvDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellContentClick
        ' 1. Validamos que hayan hecho clic en una fila válida (no en el encabezado)
        If e.RowIndex < 0 Then Return

        ' 2. Verificamos si el clic fue en la columna "colEliminar"
        ' Si tu columna se llama diferente, cambia "colEliminar" por el nombre que le pusiste
        If dgvDetalle.Columns(e.ColumnIndex).Name = "colEliminar" Then

            ' A. Restar el subtotal del Total General
            ' Asegúrate de que la columna de Subtotal sea la correcta (aquí asumo que se llama "colSubtotal" o es la 4)
            ' Si usas nombres es más seguro: fila.Cells("colSubtotal").Value
            Dim subtotalABorrar As Decimal = CDec(dgvDetalle.Rows(e.RowIndex).Cells("colSubtotal").Value)

            totalCompra -= subtotalABorrar
            lblTotal.Text = "TOTAL: $" & totalCompra.ToString("N2")

            ' B. Borrar la fila de la grilla
            dgvDetalle.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    ' Método para permitir solo números y un solo punto decimal
    Private Sub ValidarSoloNumeros(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If

        ' Solo permitir un punto decimal
        If (e.KeyChar = "."c) AndAlso ((TryCast(sender, TextBox)).Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub

    ' Asignamos el evento a los Textbox
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        ValidarSoloNumeros(sender, e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioUnitario.KeyPress
        ValidarSoloNumeros(sender, e)
    End Sub


End Class