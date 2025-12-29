<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.PanelDerecho = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnProductos)
        Me.Panel1.Controls.Add(Me.btnCompras)
        Me.Panel1.Controls.Add(Me.btnProveedores)
        Me.Panel1.Controls.Add(Me.btnClientes)
        Me.Panel1.Controls.Add(Me.btnVentas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 658)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(0, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 48)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Lista de Precios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProductos.Location = New System.Drawing.Point(0, 207)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(197, 48)
        Me.btnProductos.TabIndex = 4
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnCompras
        '
        Me.btnCompras.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompras.Location = New System.Drawing.Point(0, 455)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(197, 48)
        Me.btnCompras.TabIndex = 3
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProveedores.Location = New System.Drawing.Point(0, 261)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(197, 48)
        Me.btnProveedores.TabIndex = 2
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClientes.Location = New System.Drawing.Point(0, 153)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(197, 48)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVentas.Location = New System.Drawing.Point(0, 509)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(197, 48)
        Me.btnVentas.TabIndex = 0
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'PanelDerecho
        '
        Me.PanelDerecho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDerecho.Location = New System.Drawing.Point(197, 0)
        Me.PanelDerecho.Name = "PanelDerecho"
        Me.PanelDerecho.Size = New System.Drawing.Size(1015, 658)
        Me.PanelDerecho.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(0, 369)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 48)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Precio del Producto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 658)
        Me.Controls.Add(Me.PanelDerecho)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnCompras As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelDerecho As Panel
    Friend WithEvents Button2 As Button
End Class
