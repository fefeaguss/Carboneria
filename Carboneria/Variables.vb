Module Variables
    Public flag_abm As Integer = 0
    Public wcp As Integer = 0
    Public flag_where As Integer = 0
    Public Codigos_id As Integer = 0
    Public flag_dgv As Integer = 0
    Public flag_dgv1 As Integer = 0
    Public fecha_desde As Date
    Public fecha_hasta As Date
    Public CodExpediente As Integer = 0
    Public Sub HabilitarDeshabilitarControles(form As Form, habilitar As Boolean)


        ' Itera a través de los controles en el formulario
        For Each control As Control In form.Controls
            ' Verifica si el control es una caja de texto, un botón o un DateTimePicker
            If TypeOf control Is TextBox Then
                Dim cajaTexto As TextBox = CType(control, TextBox)
                ' Habilita o deshabilita la caja de texto según la opción indicada
                cajaTexto.Enabled = habilitar
            ElseIf TypeOf control Is Button Then
                Dim boton As Button = CType(control, Button)
                ' Habilita o deshabilita el botón según la opción indicada
                boton.Enabled = habilitar
            ElseIf TypeOf control Is DateTimePicker Then
                Dim dateTimePicker As DateTimePicker = CType(control, DateTimePicker)
                ' Habilita o deshabilita el DateTimePicker según la opción indicada
                dateTimePicker.Enabled = habilitar
            End If
        Next
    End Sub
End Module
