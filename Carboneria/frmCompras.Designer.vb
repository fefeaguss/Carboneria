<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboItemArticulo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboTipoCompra = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.dgvDetalle)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtPrecioUnitario)
        Me.Panel1.Controls.Add(Me.lblCantidad)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cboItemArticulo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cboTipoCompra)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboProveedor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(39, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 644)
        Me.Panel1.TabIndex = 0
        '
        'dgvDetalle
        '
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(0, 278)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(808, 316)
        Me.dgvDetalle.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Orange
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "DETALLE DE COMPRA"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(648, 198)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(121, 26)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(437, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Precio Unitario"
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(440, 198)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(122, 24)
        Me.txtPrecioUnitario.TabIndex = 12
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(279, 177)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(66, 18)
        Me.lblCantidad.TabIndex = 11
        Me.lblCantidad.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(282, 198)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(122, 24)
        Me.txtCantidad.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Item/Articulo:"
        '
        'cboItemArticulo
        '
        Me.cboItemArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemArticulo.FormattingEnabled = True
        Me.cboItemArticulo.Location = New System.Drawing.Point(6, 198)
        Me.cboItemArticulo.Name = "cboItemArticulo"
        Me.cboItemArticulo.Size = New System.Drawing.Size(218, 26)
        Me.cboItemArticulo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.PaleGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "AGREGA ITEM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(645, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipó de Compra:"
        '
        'cboTipoCompra
        '
        Me.cboTipoCompra.FormattingEnabled = True
        Me.cboTipoCompra.Location = New System.Drawing.Point(648, 76)
        Me.cboTipoCompra.Name = "cboTipoCompra"
        Me.cboTipoCompra.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoCompra.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(282, 76)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(138, 24)
        Me.dtpFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Proveedor:"
        '
        'cboProveedor
        '
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(3, 76)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(218, 26)
        Me.cboProveedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATOS GENERALES"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(36, 704)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(59, 18)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "TOTAL:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(668, 697)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(82, 34)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(756, 697)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(91, 34)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(102, 704)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 13
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 782)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCompras"
        Me.Text = "frmCompras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cboItemArticulo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboTipoCompra As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label11 As Label
End Class
