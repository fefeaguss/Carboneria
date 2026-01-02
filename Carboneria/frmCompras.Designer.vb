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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.cboTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.tcDetalleCompras = New System.Windows.Forms.TabControl()
        Me.pgDetalleCompraGeneral = New System.Windows.Forms.TabPage()
        Me.dgvDetalleCompra = New System.Windows.Forms.DataGridView()
        Me.pgDetalleCompraInsumos = New System.Windows.Forms.TabPage()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCantidadInsumo = New System.Windows.Forms.TextBox()
        Me.btnListoInsumo = New System.Windows.Forms.Button()
        Me.btnModificarInsumo = New System.Windows.Forms.Button()
        Me.btnAgregarDetalleInsumo = New System.Windows.Forms.Button()
        Me.txtIdCompraInsumo = New System.Windows.Forms.TextBox()
        Me.btnIdCompraInsumo = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboNombreInsumo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvDetalleCompraInsumos = New System.Windows.Forms.DataGridView()
        Me.pgDetalleCompraProductos = New System.Windows.Forms.TabPage()
        Me.txtPrecioUnitarioProducto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCantidadProducto = New System.Windows.Forms.TextBox()
        Me.btnListoProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.txtIdCompraProducto = New System.Windows.Forms.TextBox()
        Me.btnIdCompraProducto = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboNombreProducto = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvDetalleCompraProducto = New System.Windows.Forms.DataGridView()
        Me.pgDetalleCompraCarbon = New System.Windows.Forms.TabPage()
        Me.txtCantidadKg = New System.Windows.Forms.TextBox()
        Me.btnListoCarbon = New System.Windows.Forms.Button()
        Me.btnModificarCarbon = New System.Windows.Forms.Button()
        Me.btnAgregarCarbon = New System.Windows.Forms.Button()
        Me.txtIdCompra = New System.Windows.Forms.TextBox()
        Me.btnIdCompra = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.dgvDetalleCompraCarbon = New System.Windows.Forms.DataGridView()
        Me.cboTipoCompra = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.btnAgregar = New System.Windows.Forms.PictureBox()
        Me.btnListo = New System.Windows.Forms.PictureBox()
        Me.tcDetalleCompras.SuspendLayout()
        Me.pgDetalleCompraGeneral.SuspendLayout()
        CType(Me.dgvDetalleCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgDetalleCompraInsumos.SuspendLayout()
        CType(Me.btnIdCompraInsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleCompraInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgDetalleCompraProductos.SuspendLayout()
        CType(Me.btnIdCompraProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleCompraProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgDetalleCompraCarbon.SuspendLayout()
        CType(Me.btnIdCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleCompraCarbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnListo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(60, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "PROVEEDOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(281, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "TOTAL DE COMPRA"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(283, 120)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(200, 26)
        Me.txtTotal.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(60, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "FECHA DE LA COMPRA"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(63, 73)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFecha.Size = New System.Drawing.Size(200, 26)
        Me.dtpFecha.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 13)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "TIPO DE MOVIMIENTO"
        '
        'cboProveedor
        '
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(64, 120)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(199, 26)
        Me.cboProveedor.TabIndex = 110
        '
        'cboTipoMovimiento
        '
        Me.cboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMovimiento.FormattingEnabled = True
        Me.cboTipoMovimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboTipoMovimiento.Items.AddRange(New Object() {"COMPRA"})
        Me.cboTipoMovimiento.Location = New System.Drawing.Point(7, 135)
        Me.cboTipoMovimiento.Name = "cboTipoMovimiento"
        Me.cboTipoMovimiento.Size = New System.Drawing.Size(199, 28)
        Me.cboTipoMovimiento.TabIndex = 111
        '
        'tcDetalleCompras
        '
        Me.tcDetalleCompras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcDetalleCompras.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tcDetalleCompras.Controls.Add(Me.pgDetalleCompraGeneral)
        Me.tcDetalleCompras.Controls.Add(Me.pgDetalleCompraInsumos)
        Me.tcDetalleCompras.Controls.Add(Me.pgDetalleCompraProductos)
        Me.tcDetalleCompras.Controls.Add(Me.pgDetalleCompraCarbon)
        Me.tcDetalleCompras.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tcDetalleCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcDetalleCompras.HotTrack = True
        Me.tcDetalleCompras.ItemSize = New System.Drawing.Size(300, 28)
        Me.tcDetalleCompras.Location = New System.Drawing.Point(12, 201)
        Me.tcDetalleCompras.Multiline = True
        Me.tcDetalleCompras.Name = "tcDetalleCompras"
        Me.tcDetalleCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tcDetalleCompras.SelectedIndex = 0
        Me.tcDetalleCompras.Size = New System.Drawing.Size(1164, 578)
        Me.tcDetalleCompras.TabIndex = 117
        '
        'pgDetalleCompraGeneral
        '
        Me.pgDetalleCompraGeneral.Controls.Add(Me.dgvDetalleCompra)
        Me.pgDetalleCompraGeneral.Location = New System.Drawing.Point(4, 32)
        Me.pgDetalleCompraGeneral.Name = "pgDetalleCompraGeneral"
        Me.pgDetalleCompraGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pgDetalleCompraGeneral.Size = New System.Drawing.Size(1156, 542)
        Me.pgDetalleCompraGeneral.TabIndex = 0
        Me.pgDetalleCompraGeneral.Text = "DETALLE DE COMPRA GENERAL"
        Me.pgDetalleCompraGeneral.UseVisualStyleBackColor = True
        '
        'dgvDetalleCompra
        '
        Me.dgvDetalleCompra.AllowUserToAddRows = False
        Me.dgvDetalleCompra.AllowUserToDeleteRows = False
        Me.dgvDetalleCompra.AllowUserToResizeColumns = False
        Me.dgvDetalleCompra.AllowUserToResizeRows = False
        Me.dgvDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalleCompra.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.dgvDetalleCompra.Location = New System.Drawing.Point(3, 3)
        Me.dgvDetalleCompra.Name = "dgvDetalleCompra"
        Me.dgvDetalleCompra.ReadOnly = True
        Me.dgvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleCompra.Size = New System.Drawing.Size(1150, 536)
        Me.dgvDetalleCompra.TabIndex = 91
        '
        'pgDetalleCompraInsumos
        '
        Me.pgDetalleCompraInsumos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pgDetalleCompraInsumos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pgDetalleCompraInsumos.Controls.Add(Me.txtPrecioUnitario)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.Label11)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.txtCantidadInsumo)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.btnListoInsumo)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.btnModificarInsumo)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.btnAgregarDetalleInsumo)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.txtIdCompraInsumo)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.btnIdCompraInsumo)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.Label9)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.Label10)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.cboNombreInsumo)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.Label12)
        Me.pgDetalleCompraInsumos.Controls.Add(Me.dgvDetalleCompraInsumos)
        Me.pgDetalleCompraInsumos.ForeColor = System.Drawing.SystemColors.InfoText
        Me.pgDetalleCompraInsumos.Location = New System.Drawing.Point(4, 32)
        Me.pgDetalleCompraInsumos.Name = "pgDetalleCompraInsumos"
        Me.pgDetalleCompraInsumos.Padding = New System.Windows.Forms.Padding(3)
        Me.pgDetalleCompraInsumos.Size = New System.Drawing.Size(1156, 542)
        Me.pgDetalleCompraInsumos.TabIndex = 1
        Me.pgDetalleCompraInsumos.Text = "DETALLE DE COMPRA INSUMOS"
        Me.pgDetalleCompraInsumos.UseVisualStyleBackColor = True
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(24, 107)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(198, 26)
        Me.txtPrecioUnitario.TabIndex = 136
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(20, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 13)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "PRECIO UNITARIO"
        '
        'txtCantidadInsumo
        '
        Me.txtCantidadInsumo.Location = New System.Drawing.Point(249, 49)
        Me.txtCantidadInsumo.Name = "txtCantidadInsumo"
        Me.txtCantidadInsumo.Size = New System.Drawing.Size(198, 26)
        Me.txtCantidadInsumo.TabIndex = 134
        '
        'btnListoInsumo
        '
        Me.btnListoInsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListoInsumo.Location = New System.Drawing.Point(501, 107)
        Me.btnListoInsumo.Name = "btnListoInsumo"
        Me.btnListoInsumo.Size = New System.Drawing.Size(83, 28)
        Me.btnListoInsumo.TabIndex = 133
        Me.btnListoInsumo.Text = "Listo"
        Me.btnListoInsumo.UseVisualStyleBackColor = True
        '
        'btnModificarInsumo
        '
        Me.btnModificarInsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarInsumo.Location = New System.Drawing.Point(675, 81)
        Me.btnModificarInsumo.Name = "btnModificarInsumo"
        Me.btnModificarInsumo.Size = New System.Drawing.Size(83, 28)
        Me.btnModificarInsumo.TabIndex = 132
        Me.btnModificarInsumo.Text = "Modificar"
        Me.btnModificarInsumo.UseVisualStyleBackColor = True
        '
        'btnAgregarDetalleInsumo
        '
        Me.btnAgregarDetalleInsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDetalleInsumo.Location = New System.Drawing.Point(675, 49)
        Me.btnAgregarDetalleInsumo.Name = "btnAgregarDetalleInsumo"
        Me.btnAgregarDetalleInsumo.Size = New System.Drawing.Size(83, 28)
        Me.btnAgregarDetalleInsumo.TabIndex = 131
        Me.btnAgregarDetalleInsumo.Text = "Agregar"
        Me.btnAgregarDetalleInsumo.UseVisualStyleBackColor = True
        '
        'txtIdCompraInsumo
        '
        Me.txtIdCompraInsumo.Enabled = False
        Me.txtIdCompraInsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCompraInsumo.Location = New System.Drawing.Point(247, 107)
        Me.txtIdCompraInsumo.Name = "txtIdCompraInsumo"
        Me.txtIdCompraInsumo.Size = New System.Drawing.Size(200, 26)
        Me.txtIdCompraInsumo.TabIndex = 130
        '
        'btnIdCompraInsumo
        '
        Me.btnIdCompraInsumo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIdCompraInsumo.Image = CType(resources.GetObject("btnIdCompraInsumo.Image"), System.Drawing.Image)
        Me.btnIdCompraInsumo.Location = New System.Drawing.Point(454, 107)
        Me.btnIdCompraInsumo.Name = "btnIdCompraInsumo"
        Me.btnIdCompraInsumo.Size = New System.Drawing.Size(31, 26)
        Me.btnIdCompraInsumo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnIdCompraInsumo.TabIndex = 129
        Me.btnIdCompraInsumo.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(246, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "ID DE LA COMPRA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(245, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "CANTIDAD"
        '
        'cboNombreInsumo
        '
        Me.cboNombreInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNombreInsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNombreInsumo.FormattingEnabled = True
        Me.cboNombreInsumo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboNombreInsumo.Items.AddRange(New Object() {"COMPRA"})
        Me.cboNombreInsumo.Location = New System.Drawing.Point(23, 49)
        Me.cboNombreInsumo.Name = "cboNombreInsumo"
        Me.cboNombreInsumo.Size = New System.Drawing.Size(199, 26)
        Me.cboNombreInsumo.TabIndex = 125
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(19, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 13)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "NOMBRE DE INSUMO"
        '
        'dgvDetalleCompraInsumos
        '
        Me.dgvDetalleCompraInsumos.AllowUserToAddRows = False
        Me.dgvDetalleCompraInsumos.AllowUserToDeleteRows = False
        Me.dgvDetalleCompraInsumos.AllowUserToResizeColumns = False
        Me.dgvDetalleCompraInsumos.AllowUserToResizeRows = False
        Me.dgvDetalleCompraInsumos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleCompraInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalleCompraInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleCompraInsumos.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.dgvDetalleCompraInsumos.Location = New System.Drawing.Point(6, 211)
        Me.dgvDetalleCompraInsumos.Name = "dgvDetalleCompraInsumos"
        Me.dgvDetalleCompraInsumos.ReadOnly = True
        Me.dgvDetalleCompraInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleCompraInsumos.Size = New System.Drawing.Size(1138, 323)
        Me.dgvDetalleCompraInsumos.TabIndex = 92
        '
        'pgDetalleCompraProductos
        '
        Me.pgDetalleCompraProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pgDetalleCompraProductos.Controls.Add(Me.txtPrecioUnitarioProducto)
        Me.pgDetalleCompraProductos.Controls.Add(Me.Label13)
        Me.pgDetalleCompraProductos.Controls.Add(Me.txtCantidadProducto)
        Me.pgDetalleCompraProductos.Controls.Add(Me.btnListoProducto)
        Me.pgDetalleCompraProductos.Controls.Add(Me.btnModificarProducto)
        Me.pgDetalleCompraProductos.Controls.Add(Me.btnAgregarProducto)
        Me.pgDetalleCompraProductos.Controls.Add(Me.txtIdCompraProducto)
        Me.pgDetalleCompraProductos.Controls.Add(Me.btnIdCompraProducto)
        Me.pgDetalleCompraProductos.Controls.Add(Me.Label14)
        Me.pgDetalleCompraProductos.Controls.Add(Me.Label15)
        Me.pgDetalleCompraProductos.Controls.Add(Me.cboNombreProducto)
        Me.pgDetalleCompraProductos.Controls.Add(Me.Label16)
        Me.pgDetalleCompraProductos.Controls.Add(Me.dgvDetalleCompraProducto)
        Me.pgDetalleCompraProductos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pgDetalleCompraProductos.Location = New System.Drawing.Point(4, 32)
        Me.pgDetalleCompraProductos.Name = "pgDetalleCompraProductos"
        Me.pgDetalleCompraProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.pgDetalleCompraProductos.Size = New System.Drawing.Size(1156, 542)
        Me.pgDetalleCompraProductos.TabIndex = 2
        Me.pgDetalleCompraProductos.Text = "DETALLE DE COMPRA DE PRODUCTOS"
        Me.pgDetalleCompraProductos.UseVisualStyleBackColor = True
        '
        'txtPrecioUnitarioProducto
        '
        Me.txtPrecioUnitarioProducto.Location = New System.Drawing.Point(269, 154)
        Me.txtPrecioUnitarioProducto.Name = "txtPrecioUnitarioProducto"
        Me.txtPrecioUnitarioProducto.Size = New System.Drawing.Size(198, 26)
        Me.txtPrecioUnitarioProducto.TabIndex = 148
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(265, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 13)
        Me.Label13.TabIndex = 147
        Me.Label13.Text = "PRECIO UNITARIO"
        '
        'txtCantidadProducto
        '
        Me.txtCantidadProducto.Location = New System.Drawing.Point(267, 98)
        Me.txtCantidadProducto.Name = "txtCantidadProducto"
        Me.txtCantidadProducto.Size = New System.Drawing.Size(198, 26)
        Me.txtCantidadProducto.TabIndex = 146
        '
        'btnListoProducto
        '
        Me.btnListoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListoProducto.Location = New System.Drawing.Point(493, 154)
        Me.btnListoProducto.Name = "btnListoProducto"
        Me.btnListoProducto.Size = New System.Drawing.Size(83, 28)
        Me.btnListoProducto.TabIndex = 145
        Me.btnListoProducto.Text = "Listo"
        Me.btnListoProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProducto.Location = New System.Drawing.Point(654, 127)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(83, 28)
        Me.btnModificarProducto.TabIndex = 144
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Location = New System.Drawing.Point(654, 95)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(83, 28)
        Me.btnAgregarProducto.TabIndex = 143
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'txtIdCompraProducto
        '
        Me.txtIdCompraProducto.Enabled = False
        Me.txtIdCompraProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCompraProducto.Location = New System.Drawing.Point(17, 154)
        Me.txtIdCompraProducto.Name = "txtIdCompraProducto"
        Me.txtIdCompraProducto.Size = New System.Drawing.Size(200, 26)
        Me.txtIdCompraProducto.TabIndex = 142
        '
        'btnIdCompraProducto
        '
        Me.btnIdCompraProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIdCompraProducto.Image = CType(resources.GetObject("btnIdCompraProducto.Image"), System.Drawing.Image)
        Me.btnIdCompraProducto.Location = New System.Drawing.Point(223, 154)
        Me.btnIdCompraProducto.Name = "btnIdCompraProducto"
        Me.btnIdCompraProducto.Size = New System.Drawing.Size(31, 26)
        Me.btnIdCompraProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnIdCompraProducto.TabIndex = 141
        Me.btnIdCompraProducto.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(16, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 13)
        Me.Label14.TabIndex = 140
        Me.Label14.Text = "ID DE LA COMPRA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(263, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 139
        Me.Label15.Text = "CANTIDAD"
        '
        'cboNombreProducto
        '
        Me.cboNombreProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNombreProducto.FormattingEnabled = True
        Me.cboNombreProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboNombreProducto.Location = New System.Drawing.Point(18, 96)
        Me.cboNombreProducto.Name = "cboNombreProducto"
        Me.cboNombreProducto.Size = New System.Drawing.Size(199, 26)
        Me.cboNombreProducto.TabIndex = 138
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(14, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(154, 13)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "NOMBRE DE PRODUCTO"
        '
        'dgvDetalleCompraProducto
        '
        Me.dgvDetalleCompraProducto.AllowUserToAddRows = False
        Me.dgvDetalleCompraProducto.AllowUserToDeleteRows = False
        Me.dgvDetalleCompraProducto.AllowUserToResizeColumns = False
        Me.dgvDetalleCompraProducto.AllowUserToResizeRows = False
        Me.dgvDetalleCompraProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleCompraProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalleCompraProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleCompraProducto.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.dgvDetalleCompraProducto.Location = New System.Drawing.Point(6, 296)
        Me.dgvDetalleCompraProducto.Name = "dgvDetalleCompraProducto"
        Me.dgvDetalleCompraProducto.ReadOnly = True
        Me.dgvDetalleCompraProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleCompraProducto.Size = New System.Drawing.Size(1142, 238)
        Me.dgvDetalleCompraProducto.TabIndex = 92
        '
        'pgDetalleCompraCarbon
        '
        Me.pgDetalleCompraCarbon.Controls.Add(Me.txtCantidadKg)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.btnListoCarbon)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.btnModificarCarbon)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.btnAgregarCarbon)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.txtIdCompra)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.btnIdCompra)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.Label8)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.Label5)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.Label2)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.dtpFechaMovimiento)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.dgvDetalleCompraCarbon)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.cboTipoMovimiento)
        Me.pgDetalleCompraCarbon.Controls.Add(Me.Label6)
        Me.pgDetalleCompraCarbon.Location = New System.Drawing.Point(4, 32)
        Me.pgDetalleCompraCarbon.Name = "pgDetalleCompraCarbon"
        Me.pgDetalleCompraCarbon.Padding = New System.Windows.Forms.Padding(3)
        Me.pgDetalleCompraCarbon.Size = New System.Drawing.Size(1156, 542)
        Me.pgDetalleCompraCarbon.TabIndex = 3
        Me.pgDetalleCompraCarbon.Text = "DETALLE DE COMPRA CARBON"
        Me.pgDetalleCompraCarbon.UseVisualStyleBackColor = True
        '
        'txtCantidadKg
        '
        Me.txtCantidadKg.Location = New System.Drawing.Point(231, 79)
        Me.txtCantidadKg.Name = "txtCantidadKg"
        Me.txtCantidadKg.Size = New System.Drawing.Size(198, 26)
        Me.txtCantidadKg.TabIndex = 122
        '
        'btnListoCarbon
        '
        Me.btnListoCarbon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListoCarbon.Location = New System.Drawing.Point(483, 137)
        Me.btnListoCarbon.Name = "btnListoCarbon"
        Me.btnListoCarbon.Size = New System.Drawing.Size(83, 28)
        Me.btnListoCarbon.TabIndex = 121
        Me.btnListoCarbon.Text = "Listo"
        Me.btnListoCarbon.UseVisualStyleBackColor = True
        '
        'btnModificarCarbon
        '
        Me.btnModificarCarbon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCarbon.Location = New System.Drawing.Point(657, 111)
        Me.btnModificarCarbon.Name = "btnModificarCarbon"
        Me.btnModificarCarbon.Size = New System.Drawing.Size(83, 28)
        Me.btnModificarCarbon.TabIndex = 120
        Me.btnModificarCarbon.Text = "Modificar"
        Me.btnModificarCarbon.UseVisualStyleBackColor = True
        '
        'btnAgregarCarbon
        '
        Me.btnAgregarCarbon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCarbon.Location = New System.Drawing.Point(657, 79)
        Me.btnAgregarCarbon.Name = "btnAgregarCarbon"
        Me.btnAgregarCarbon.Size = New System.Drawing.Size(83, 28)
        Me.btnAgregarCarbon.TabIndex = 119
        Me.btnAgregarCarbon.Text = "Agregar"
        Me.btnAgregarCarbon.UseVisualStyleBackColor = True
        '
        'txtIdCompra
        '
        Me.txtIdCompra.Enabled = False
        Me.txtIdCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCompra.Location = New System.Drawing.Point(229, 137)
        Me.txtIdCompra.Name = "txtIdCompra"
        Me.txtIdCompra.Size = New System.Drawing.Size(200, 26)
        Me.txtIdCompra.TabIndex = 118
        '
        'btnIdCompra
        '
        Me.btnIdCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIdCompra.Image = CType(resources.GetObject("btnIdCompra.Image"), System.Drawing.Image)
        Me.btnIdCompra.Location = New System.Drawing.Point(436, 137)
        Me.btnIdCompra.Name = "btnIdCompra"
        Me.btnIdCompra.Size = New System.Drawing.Size(31, 26)
        Me.btnIdCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnIdCompra.TabIndex = 117
        Me.btnIdCompra.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(228, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "ID DE LA COMPRA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(227, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 13)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "CANTIDAD DE KILOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "FECHA"
        '
        'dtpFechaMovimiento
        '
        Me.dtpFechaMovimiento.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMovimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMovimiento.Location = New System.Drawing.Point(6, 78)
        Me.dtpFechaMovimiento.Name = "dtpFechaMovimiento"
        Me.dtpFechaMovimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaMovimiento.Size = New System.Drawing.Size(200, 26)
        Me.dtpFechaMovimiento.TabIndex = 110
        '
        'dgvDetalleCompraCarbon
        '
        Me.dgvDetalleCompraCarbon.AllowUserToAddRows = False
        Me.dgvDetalleCompraCarbon.AllowUserToDeleteRows = False
        Me.dgvDetalleCompraCarbon.AllowUserToResizeColumns = False
        Me.dgvDetalleCompraCarbon.AllowUserToResizeRows = False
        Me.dgvDetalleCompraCarbon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleCompraCarbon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalleCompraCarbon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleCompraCarbon.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.dgvDetalleCompraCarbon.Location = New System.Drawing.Point(6, 296)
        Me.dgvDetalleCompraCarbon.Name = "dgvDetalleCompraCarbon"
        Me.dgvDetalleCompraCarbon.ReadOnly = True
        Me.dgvDetalleCompraCarbon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleCompraCarbon.Size = New System.Drawing.Size(1144, 240)
        Me.dgvDetalleCompraCarbon.TabIndex = 93
        '
        'cboTipoCompra
        '
        Me.cboTipoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCompra.FormattingEnabled = True
        Me.cboTipoCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboTipoCompra.Items.AddRange(New Object() {"CARBON", "INSUMO", "PRODUCTO"})
        Me.cboTipoCompra.Location = New System.Drawing.Point(284, 71)
        Me.cboTipoCompra.Name = "cboTipoCompra"
        Me.cboTipoCompra.Size = New System.Drawing.Size(199, 28)
        Me.cboTipoCompra.TabIndex = 119
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(280, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "TIPO DE COMPRA"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(1108, 148)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(54, 47)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnModificar.TabIndex = 116
        Me.btnModificar.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(1032, 148)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(55, 47)
        Me.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAgregar.TabIndex = 115
        Me.btnAgregar.TabStop = False
        '
        'btnListo
        '
        Me.btnListo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListo.Image = CType(resources.GetObject("btnListo.Image"), System.Drawing.Image)
        Me.btnListo.Location = New System.Drawing.Point(510, 119)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(116, 27)
        Me.btnListo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnListo.TabIndex = 108
        Me.btnListo.TabStop = False
        Me.btnListo.Visible = False
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 782)
        Me.Controls.Add(Me.cboTipoCompra)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tcDetalleCompras)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnListo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCompras"
        Me.Text = "frmCompras"
        Me.tcDetalleCompras.ResumeLayout(False)
        Me.pgDetalleCompraGeneral.ResumeLayout(False)
        CType(Me.dgvDetalleCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgDetalleCompraInsumos.ResumeLayout(False)
        Me.pgDetalleCompraInsumos.PerformLayout()
        CType(Me.btnIdCompraInsumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleCompraInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgDetalleCompraProductos.ResumeLayout(False)
        Me.pgDetalleCompraProductos.PerformLayout()
        CType(Me.btnIdCompraProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleCompraProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgDetalleCompraCarbon.ResumeLayout(False)
        Me.pgDetalleCompraCarbon.PerformLayout()
        CType(Me.btnIdCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleCompraCarbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnListo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnListo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents cboTipoMovimiento As ComboBox
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents btnAgregar As PictureBox
    Friend WithEvents tcDetalleCompras As TabControl
    Friend WithEvents pgDetalleCompraGeneral As TabPage
    Friend WithEvents pgDetalleCompraInsumos As TabPage
    Friend WithEvents pgDetalleCompraProductos As TabPage
    Friend WithEvents dgvDetalleCompra As DataGridView
    Friend WithEvents dgvDetalleCompraInsumos As DataGridView
    Friend WithEvents dgvDetalleCompraProducto As DataGridView
    Friend WithEvents pgDetalleCompraCarbon As TabPage
    Friend WithEvents dgvDetalleCompraCarbon As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaMovimiento As DateTimePicker
    Friend WithEvents cboTipoCompra As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnIdCompra As PictureBox
    Friend WithEvents txtIdCompra As TextBox
    Friend WithEvents btnListoCarbon As Button
    Friend WithEvents btnModificarCarbon As Button
    Friend WithEvents btnAgregarCarbon As Button
    Friend WithEvents txtCantidadKg As TextBox
    Friend WithEvents txtCantidadInsumo As TextBox
    Friend WithEvents btnListoInsumo As Button
    Friend WithEvents btnModificarInsumo As Button
    Friend WithEvents btnAgregarDetalleInsumo As Button
    Friend WithEvents txtIdCompraInsumo As TextBox
    Friend WithEvents btnIdCompraInsumo As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboNombreInsumo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPrecioUnitarioProducto As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCantidadProducto As TextBox
    Friend WithEvents btnListoProducto As Button
    Friend WithEvents btnModificarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents txtIdCompraProducto As TextBox
    Friend WithEvents btnIdCompraProducto As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cboNombreProducto As ComboBox
    Friend WithEvents Label16 As Label
End Class
