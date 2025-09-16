<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnCancelarAhorros = New Button()
        btnAltaClienteAhorros = New Button()
        txtTelefonoAhorro = New TextBox()
        txtDNIAhorro = New TextBox()
        txtDireccionAhorro = New TextBox()
        txtNombreyApellidoAhorro = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        txtCancelarCorriente = New Button()
        btnAltaClienteCorriente = New Button()
        txtDescubiertoCorriente = New TextBox()
        Label9 = New Label()
        txtTelefonoCorriente = New TextBox()
        txtDNICorriente = New TextBox()
        txtDireccionCorriente = New TextBox()
        txtNombreyApellidoCorriente = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(-2, -2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(529, 342)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        TabPage1.Controls.Add(btnCancelarAhorros)
        TabPage1.Controls.Add(btnAltaClienteAhorros)
        TabPage1.Controls.Add(txtTelefonoAhorro)
        TabPage1.Controls.Add(txtDNIAhorro)
        TabPage1.Controls.Add(txtDireccionAhorro)
        TabPage1.Controls.Add(txtNombreyApellidoAhorro)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(521, 314)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Caja de Ahorros"
        ' 
        ' btnCancelarAhorros
        ' 
        btnCancelarAhorros.Location = New Point(190, 254)
        btnCancelarAhorros.Name = "btnCancelarAhorros"
        btnCancelarAhorros.Size = New Size(88, 23)
        btnCancelarAhorros.TabIndex = 9
        btnCancelarAhorros.Text = "Cancelar"
        btnCancelarAhorros.UseVisualStyleBackColor = True
        ' 
        ' btnAltaClienteAhorros
        ' 
        btnAltaClienteAhorros.Location = New Point(59, 254)
        btnAltaClienteAhorros.Name = "btnAltaClienteAhorros"
        btnAltaClienteAhorros.Size = New Size(108, 23)
        btnAltaClienteAhorros.TabIndex = 8
        btnAltaClienteAhorros.Text = "Alta Cliente"
        btnAltaClienteAhorros.UseVisualStyleBackColor = True
        ' 
        ' txtTelefonoAhorro
        ' 
        txtTelefonoAhorro.Location = New Point(190, 152)
        txtTelefonoAhorro.Name = "txtTelefonoAhorro"
        txtTelefonoAhorro.Size = New Size(100, 23)
        txtTelefonoAhorro.TabIndex = 7
        ' 
        ' txtDNIAhorro
        ' 
        txtDNIAhorro.Location = New Point(190, 118)
        txtDNIAhorro.Name = "txtDNIAhorro"
        txtDNIAhorro.Size = New Size(100, 23)
        txtDNIAhorro.TabIndex = 6
        ' 
        ' txtDireccionAhorro
        ' 
        txtDireccionAhorro.Location = New Point(190, 80)
        txtDireccionAhorro.Name = "txtDireccionAhorro"
        txtDireccionAhorro.Size = New Size(100, 23)
        txtDireccionAhorro.TabIndex = 5
        ' 
        ' txtNombreyApellidoAhorro
        ' 
        txtNombreyApellidoAhorro.Location = New Point(190, 39)
        txtNombreyApellidoAhorro.Name = "txtNombreyApellidoAhorro"
        txtNombreyApellidoAhorro.Size = New Size(100, 23)
        txtNombreyApellidoAhorro.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 3
        Label4.Text = "Telefono:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 2
        Label3.Text = "DNI:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 1
        Label2.Text = "Dirección:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre y Apellido:"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        TabPage2.Controls.Add(txtCancelarCorriente)
        TabPage2.Controls.Add(btnAltaClienteCorriente)
        TabPage2.Controls.Add(txtDescubiertoCorriente)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(txtTelefonoCorriente)
        TabPage2.Controls.Add(txtDNICorriente)
        TabPage2.Controls.Add(txtDireccionCorriente)
        TabPage2.Controls.Add(txtNombreyApellidoCorriente)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label8)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(521, 314)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Cuenta Corriente"
        ' 
        ' txtCancelarCorriente
        ' 
        txtCancelarCorriente.Location = New Point(283, 263)
        txtCancelarCorriente.Name = "txtCancelarCorriente"
        txtCancelarCorriente.Size = New Size(93, 23)
        txtCancelarCorriente.TabIndex = 15
        txtCancelarCorriente.Text = "Cancelar"
        txtCancelarCorriente.UseVisualStyleBackColor = True
        ' 
        ' btnAltaClienteCorriente
        ' 
        btnAltaClienteCorriente.Location = New Point(148, 263)
        btnAltaClienteCorriente.Name = "btnAltaClienteCorriente"
        btnAltaClienteCorriente.Size = New Size(103, 23)
        btnAltaClienteCorriente.TabIndex = 14
        btnAltaClienteCorriente.Text = "Alta Cliente"
        btnAltaClienteCorriente.UseVisualStyleBackColor = True
        ' 
        ' txtDescubiertoCorriente
        ' 
        txtDescubiertoCorriente.Location = New Point(245, 217)
        txtDescubiertoCorriente.Name = "txtDescubiertoCorriente"
        txtDescubiertoCorriente.Size = New Size(100, 23)
        txtDescubiertoCorriente.TabIndex = 13
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(113, 225)
        Label9.Name = "Label9"
        Label9.Size = New Size(82, 15)
        Label9.TabIndex = 12
        Label9.Text = "Descubierto: $"
        ' 
        ' txtTelefonoCorriente
        ' 
        txtTelefonoCorriente.Location = New Point(245, 180)
        txtTelefonoCorriente.Name = "txtTelefonoCorriente"
        txtTelefonoCorriente.Size = New Size(100, 23)
        txtTelefonoCorriente.TabIndex = 11
        ' 
        ' txtDNICorriente
        ' 
        txtDNICorriente.Location = New Point(245, 139)
        txtDNICorriente.Name = "txtDNICorriente"
        txtDNICorriente.Size = New Size(100, 23)
        txtDNICorriente.TabIndex = 10
        ' 
        ' txtDireccionCorriente
        ' 
        txtDireccionCorriente.Location = New Point(245, 101)
        txtDireccionCorriente.Name = "txtDireccionCorriente"
        txtDireccionCorriente.Size = New Size(100, 23)
        txtDireccionCorriente.TabIndex = 9
        ' 
        ' txtNombreyApellidoCorriente
        ' 
        txtNombreyApellidoCorriente.Location = New Point(245, 65)
        txtNombreyApellidoCorriente.Name = "txtNombreyApellidoCorriente"
        txtNombreyApellidoCorriente.Size = New Size(100, 23)
        txtNombreyApellidoCorriente.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(113, 183)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 7
        Label5.Text = "Telefono:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(113, 147)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 15)
        Label6.TabIndex = 6
        Label6.Text = "DNI:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(113, 109)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 15)
        Label7.TabIndex = 5
        Label7.Text = "Dirección:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(113, 68)
        Label8.Name = "Label8"
        Label8.Size = New Size(110, 15)
        Label8.TabIndex = 4
        Label8.Text = "Nombre y Apellido:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(525, 331)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtDireccionAhorro As TextBox
    Friend WithEvents txtNombreyApellidoAhorro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefonoAhorro As TextBox
    Friend WithEvents txtDNIAhorro As TextBox
    Friend WithEvents txtCancelarCorriente As Button
    Friend WithEvents btnAltaClienteCorriente As Button
    Friend WithEvents txtDescubiertoCorriente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTelefonoCorriente As TextBox
    Friend WithEvents txtDNICorriente As TextBox
    Friend WithEvents txtDireccionCorriente As TextBox
    Friend WithEvents txtNombreyApellidoCorriente As TextBox
    Friend WithEvents btnCancelarAhorros As Button
    Friend WithEvents btnAltaClienteAhorros As Button

End Class
