Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormularioEnPanel(New frmClientes())

    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        AbrirFormularioEnPanel(New frmProveedores())

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormularioEnPanel(New frnProductos())

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnListaPrecios.Click
        AbrirFormularioEnPanel(New frmListaPrecios())
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnProductoPrecio.Click
        AbrirFormularioEnPanel(New frmProductoPrecio())
    End Sub

    Private Sub btnInsumos_Click(sender As Object, e As EventArgs) Handles btnInsumos.Click
        AbrirFormularioEnPanel(New frmInsumos())
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirFormularioEnPanel(New frmCompras())
    End Sub

    Private Sub AbrirFormularioEnPanel(formHijo As Form)
        ' Si ya hay un formulario cargado, cerrarlo y liberarlo
        If Me.PanelDerecho.Controls.Count <= 0 Then
        Else
            Dim viejoForm As Form = CType(Me.PanelDerecho.Controls(0), Form)
            viejoForm.Close()
            viejoForm.Dispose()
            Me.PanelDerecho.Controls.Clear()
        End If

        ' Configurar el formulario hijo
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill

        ' Agregarlo al panel
        Me.PanelDerecho.Controls.Add(formHijo)
        Me.PanelDerecho.Tag = formHijo

        ' Cuando se cierre con Me.Close, limpiar el panel
        AddHandler formHijo.FormClosed, Sub(sender, e)
                                            Me.PanelDerecho.Controls.Clear()
                                        End Sub

        formHijo.Show()
    End Sub


End Class