Public Class Form1

    Function f(x As Decimal) As Decimal
        Dim y As Decimal

        y = CDec(Math.Sin(x))

        'If x > 0 Then
        '    y = Math.Sin(x)
        'ElseIf x = 0 Then
        '    MsgBox("x  = 0  Finalizado")
        'ElseIf x < 0 Then
        '    y = Math.Sin(x)
        'End If

        Return y
    End Function

    Function dameSignoyFuncion(x As Decimal) As Decimal
        Dim r As Decimal
        If Math.Sign(x) <> 0 Then
            r = f(x)
            Return r
        Else
            Return 0
        End If
    End Function

    Private Function CArea() As Decimal
        Dim i, n As Integer
        Dim b, Base, h, pi, y, a, c, x, result As Decimal

        pi = Math.PI

        a = 1.5
        c = (3 * pi) / 2


        n = CInt(TextBoxN.Text)
        'h = x / n



        For i = 0 To n - 1
            x = (a + c) / 2
            y = dameSignoyFuncion(x)
            ''El condicional esta mal, debo hacer que si x tiene el simbolo mayor que 0 significa
            ''que el valor de a = x
            'y al reves con el c (negativo)
            If y > 0 Then
                a = x
            ElseIf y < 0 Then
                c = x
            ElseIf y = 0 Then
                MsgBox("x = 0")
            End If


            'b = f(a + (i * h))
            'Base = f(a + ((i + 1) * h))
            'result += ((b + Base) / 2) * h
        Next
        TextBoxResultado.Text = y
    End Function

    'Function verificaciones(a As Decimal, c As Decimal, n As Integer) As String
    '    If a = 0 Then
    '        MsgBox("el valor a es igual a 0 por lo tanto ya sabemos qué es 0")
    '    ElseIf c = 0 Then
    '        MsgBox("el valor c es igual a 0 por lo tanto ya sabemos qué es 0")
    '    ElseIf n = 0 Then
    '        MsgBox("el valor n debe ser superior a 0")
    '    ElseIf (a And c) < 0 Or (a And c) > 0 Then
    '        MsgBox("los dos valores a y c no pueden tener el mismo signo")
    '    End If

    'End Function
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        'verificaciones(a, c, n)
        CArea()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
