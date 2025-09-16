Public Class Form1
    Public cuenta As Cuenta

    Private Sub btnAltaClienteAhorros_Click(sender As Object, e As EventArgs) Handles btnAltaClienteAhorros.Click
        cuenta = Nothing
        If txtNombreyApellidoAhorro.Text = "" Or txtDireccionAhorro.Text = "" Or txtDNIAhorro.Text = "" Or txtTelefonoAhorro.Text = "" Then
            MsgBox("Complete todos los datos requeridos")
        Else
            cuenta = New Cuenta(txtNombreyApellidoAhorro.Text, txtDireccionAhorro.Text, Convert.ToInt32(txtDNIAhorro.Text), Convert.ToInt32(txtTelefonoAhorro.Text), "A", 0)
            MsgBox(cuenta.datos())
            Form2.Show()
        End If

    End Sub

    Private Sub btnCancelarAhorros_Click(sender As Object, e As EventArgs) Handles btnCancelarAhorros.Click
        txtNombreyApellidoAhorro.Clear()
        txtDireccionAhorro.Clear()
        txtDNIAhorro.Clear()
        txtTelefonoAhorro.Clear()
        cuenta = Nothing
    End Sub

    Private Sub btnAltaClienteCorriente_Click(sender As Object, e As EventArgs) Handles btnAltaClienteCorriente.Click
        cuenta = Nothing
        If txtNombreyApellidoCorriente.Text = "" Or txtDireccionCorriente.Text = "" Or txtDNICorriente.Text = "" Or txtTelefonoCorriente.Text = "" Or txtDescubiertoCorriente.Text = "" Then
            MsgBox("Complete todos los datos requeridos")
        Else
            cuenta = New Cuenta(txtNombreyApellidoCorriente.Text, txtDireccionCorriente.Text, Convert.ToInt32(txtDNICorriente.Text), Convert.ToInt32(txtTelefonoCorriente.Text), "C", Convert.ToInt32(txtDescubiertoCorriente.Text))
            MsgBox(cuenta.datos())
            Form2.Show()

        End If

    End Sub

    Private Sub txtCancelarCorriente_Click(sender As Object, e As EventArgs) Handles txtCancelarCorriente.Click
        txtNombreyApellidoCorriente.Clear()
        txtDireccionCorriente.Clear()
        txtDNICorriente.Clear()
        txtTelefonoCorriente.Clear()
        txtDescubiertoCorriente.Clear()
        cuenta = Nothing
    End Sub
End Class
