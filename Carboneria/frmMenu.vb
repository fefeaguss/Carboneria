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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormularioEnPanel(New frmListaPrecios())
    End Sub


    Private Sub AbrirFormularioEnPanel(formHijo As Form)
        ' Limpiar el panel antes de cargar otro formulario
        If Me.PanelDerecho.Controls.Count > 0 Then
            Me.PanelDerecho.Controls.RemoveAt(0)
        End If

        ' Configurar el formulario hijo
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill

        ' Agregarlo al panel
        Me.PanelDerecho.Controls.Add(formHijo)
        Me.PanelDerecho.Tag = formHijo
        formHijo.Show()
    End Sub


End Class