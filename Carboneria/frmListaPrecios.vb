Public Class frmListaPrecios
    Private Sub frmListaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarLista()
    End Sub

    Private Sub llenarLista()

        Dim sql As String = "select id_lista as 'ID LISTA', nombre_lista as 'NOMBRE DE LISTA' from ListaPrecio"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("ListaPrecio")
        adp.Fill(ds.Tables("ListaPrecio"))
        Me.dgvListaPrecios.DataSource = ds.Tables("ListaPrecio")
    End Sub



    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        flag_abm = 1 'ALTA

        HabilitarDeshabilitarControles(Me, True)
        Me.btnListo.Visible = True
        Me.txtNombre_Lista.Focus()
    End Sub

    ' FUNCION PARA GENERAR LISTA DE PRECIO
    Private Sub NuevaListaPrecio()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL sin id_lista (identity)
        Dim sql As String = "INSERT INTO ListaPrecio (nombre_lista) " &
                        "VALUES ('" & Me.txtNombre_Lista.Text & "')"

        cmd.CommandText = sql

        ' Validaciones
        If Me.txtNombre_Lista.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                llenarLista() ' función que refresca el listado de listas de precio

                ' Limpiar campos
                Me.txtNombre_Lista.Clear()
                Me.btnListo.Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El campo NOMBRE DE LISTA no puede estar vacío.", MsgBoxStyle.Critical, "Error")
            Me.txtNombre_Lista.Focus()
        End If
    End Sub


    ' BOTON PARA MODIFICAR LISTA DE PRECIO
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        flag_abm = 2
        wcp = Me.dgvListaPrecios.CurrentRow.Cells(0).Value
        Me.txtNombre_Lista.Text = Me.dgvListaPrecios.CurrentRow.Cells(1).Value.ToString
        HabilitarDeshabilitarControles(Me, True)
        Me.btnListo.Visible = True
        Me.txtNombre_Lista.Focus()
    End Sub

    ' FUNCION PARA MODIFICAR LISTA DE PRECIO
    Private Sub ModificarListaPrecio()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Armamos el SQL con los campos correctos
        Dim sql As String = "UPDATE ListaPrecio SET " &
                        "nombre_lista = '" & Me.txtNombre_Lista.Text & "' " &
                        "WHERE id_lista = " & wcp

        cmd.CommandText = sql

        ' Validaciones
        If Me.txtNombre_Lista.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                llenarLista() ' refresca listado de listas de precio

                ' Reset de campos
                Me.txtNombre_Lista.Clear()
                Me.btnListo.Visible = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El campo NOMBRE DE LISTA no puede estar vacío.", MsgBoxStyle.Critical, "Error")
            Me.txtNombre_Lista.Focus()
        End If
    End Sub


    ' BOTON PARA ELIMINAR LISTA DE PRECIO
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        flag_abm = 2
        wcp = Me.dgvListaPrecios.CurrentRow.Cells(0).Value
        Me.txtNombre_Lista.Text = Me.dgvListaPrecios.CurrentRow.Cells(1).Value.ToString
        HabilitarDeshabilitarControles(Me, True)
        Me.txtNombre_Lista.Focus()
    End Sub

    ' FUNCION PARA ELIMINAR LISTA DE PRECIO
    Private Sub EliminarListaPrecio()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = "DELETE FROM ListaPrecio WHERE id_lista = " & wcp
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            llenarLista() ' refresca listado de listas

            ' Limpiar campos
            Me.txtNombre_Lista.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'INSERT
            NuevaListaPrecio()
        ElseIf flag_abm = 2 Then 'UPDATE
            ModificarListaPrecio()
        ElseIf flag_abm = 3 Then 'DELETE
            EliminarListaPrecio()
        End If


        HabilitarDeshabilitarControles(Me, False)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class