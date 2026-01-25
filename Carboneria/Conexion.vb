Module Conexion
    Public cmd As New SqlClient.SqlCommand
    Public dr As SqlClient.SqlDataReader

    ' Tu cadena de conexión original
    Public conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-UQO21FA\SQLEXPRESSFEDE;Initial Catalog=CarboneriaDB;Integrated Security=true;user id=sa;password=fefeelmejor")

    Public Sub conectar()
        Try
            ' Intentamos abrir la conexión
            conexion.Open()
        Catch ex As Exception
            ' TRUCO: Si el error es porque "ya está abierta", NO mostramos nada y seguimos.
            ' Solo mostramos MsgBox si es un error real (ej. mal la contraseña o servidor apagado)
            If conexion.State <> ConnectionState.Open Then
                MsgBox("Error al conectar con el servidor: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End If
        End Try

        ' IMPORTANTE: Esto se ejecuta SIEMPRE, esté abierta de antes o recién abierta.
        ' Esto asegura que el comando siempre tenga la conexión lista.
        cmd.Connection = conexion
    End Sub

    Public Sub desconectar()
        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        Catch ex As Exception
            ' Ignoramos errores al cerrar
        End Try
    End Sub

End Module