
Module Conexion
    Public cmd As New SqlClient.SqlCommand
    Public dr As SqlClient.SqlDataReader
    'Public conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-UQO21FA\SQLEXPRESSFEDE;Initial Catalog=ejercicio_5;Integrated Security=false ;user id=sa;password=fefeelmejor")
    Public conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-UQO21FA\SQLEXPRESSFEDE;Initial Catalog=CarboneriaDB;Integrated Security=true;user id=sa;password=fefeelmejor")
    Public Sub conectar() 'FUNCION PARA ABRIR LA CONEXIONv
        Try
            conexion.Open()
            cmd.Connection = conexion
        Catch ex As Exception
            MsgBox("Error al conectar con el servidor.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Module
