<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDgvCompra
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
        Me.dgvDetalleCompra = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDetalleCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgvDetalleCompra.Location = New System.Drawing.Point(0, 0)
        Me.dgvDetalleCompra.Name = "dgvDetalleCompra"
        Me.dgvDetalleCompra.ReadOnly = True
        Me.dgvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleCompra.Size = New System.Drawing.Size(705, 520)
        Me.dgvDetalleCompra.TabIndex = 92
        '
        'frmDgvCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 520)
        Me.Controls.Add(Me.dgvDetalleCompra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDgvCompra"
        Me.Text = "frmDgvCompra"
        CType(Me.dgvDetalleCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDetalleCompra As DataGridView
End Class
