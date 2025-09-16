Public Class Form2

    Private Sub btnCerrarCuenta_Click(sender As Object, e As EventArgs) Handles btnCerrarCuenta.Click
        Dim resultado As Boolean = Form1.cuenta.extraer()
        Select Case resultado
            Case True
                MsgBox("Cuenta cerrada exitosamente")
                Me.Close()
            Case False
                MsgBox("Error al cerrar la cuenta, tiene saldo negativo")
        End Select
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnExtracción_Click(sender As Object, e As EventArgs) Handles btnExtracción.Click
        Dim resultado As Boolean
        If Val(txtImporte.Text) = 0 Then
            MsgBox("No se puede realizar la extraccion, debe ingresar el importe")
        Else
            If (Val(txtImporte.Text) > 0) Then
                resultado = Form1.cuenta.extraer(Convert.ToInt32(txtImporte.Text))
                Select Case resultado
                    Case True
                        MsgBox("Se realizo la extracción con exito")
                        lblSaldo.Text = Form1.cuenta.saldo2
                    Case False
                        MsgBox("No se pudo realizar la extracción por falta de dinero o bien su descubierto es superado.")
                End Select
            Else
                MsgBox("No se admiten numeros negativos")
            End If

        End If


    End Sub

    Private Sub btnDeposito_Click(sender As Object, e As EventArgs) Handles btnDeposito.Click
        If Val(txtImporte.Text) = 0 Then
            MsgBox("No se pudo realizar el deposito, debe ingresar el importe")
        Else
            If Val(txtImporte.Text) > 0 Then
                lblSaldo.Text = Form1.cuenta.depositar(Convert.ToInt32(txtImporte.Text))
                MsgBox("El depósito fue realizado con éxito")
            Else
                MsgBox("No se admiten numeros negativos")
            End If

        End If

    End Sub

    Private Sub btnExtraerTodo_Click(sender As Object, e As EventArgs) Handles btnExtraerTodo.Click
        Dim resultado As Boolean
        resultado = Form1.cuenta.extraer()
        Select Case resultado
            Case True
                MsgBox("Se extrajo todo el dinero con exito")
                lblSaldo.Text = Convert.ToString(Form1.cuenta.saldo2)
            Case False
                MsgBox("No se puede realizar la extraccion debido al saldo deudor")
        End Select
    End Sub
End Class