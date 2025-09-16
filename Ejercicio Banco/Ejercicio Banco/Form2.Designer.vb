<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        lblSaldo = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        txtImporte = New TextBox()
        Label2 = New Label()
        btnCerrarCuenta = New Button()
        btnSalir = New Button()
        btnExtracción = New Button()
        btnDeposito = New Button()
        btnExtraerTodo = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel1.Controls.Add(lblSaldo)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(34, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(384, 56)
        Panel1.TabIndex = 0
        ' 
        ' lblSaldo
        ' 
        lblSaldo.AutoSize = True
        lblSaldo.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSaldo.Location = New Point(247, 15)
        lblSaldo.Name = "lblSaldo"
        lblSaldo.Size = New Size(22, 25)
        lblSaldo.TabIndex = 1
        lblSaldo.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(75, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 25)
        Label1.TabIndex = 0
        Label1.Text = "Saldo     $"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(txtImporte)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(34, 74)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 100)
        Panel2.TabIndex = 1
        ' 
        ' txtImporte
        ' 
        txtImporte.Location = New Point(50, 48)
        txtImporte.Name = "txtImporte"
        txtImporte.Size = New Size(100, 23)
        txtImporte.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(75, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 0
        Label2.Text = "Importe"
        ' 
        ' btnCerrarCuenta
        ' 
        btnCerrarCuenta.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnCerrarCuenta.Location = New Point(84, 207)
        btnCerrarCuenta.Name = "btnCerrarCuenta"
        btnCerrarCuenta.Size = New Size(95, 36)
        btnCerrarCuenta.TabIndex = 2
        btnCerrarCuenta.Text = "Cerrar Cuenta"
        btnCerrarCuenta.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnSalir.Location = New Point(281, 207)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(95, 36)
        btnSalir.TabIndex = 3
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnExtracción
        ' 
        btnExtracción.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnExtracción.Location = New Point(281, 122)
        btnExtracción.Name = "btnExtracción"
        btnExtracción.Size = New Size(95, 36)
        btnExtracción.TabIndex = 4
        btnExtracción.Text = "Extraer"
        btnExtracción.UseVisualStyleBackColor = False
        ' 
        ' btnDeposito
        ' 
        btnDeposito.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnDeposito.Location = New Point(281, 74)
        btnDeposito.Name = "btnDeposito"
        btnDeposito.Size = New Size(95, 36)
        btnDeposito.TabIndex = 5
        btnDeposito.Text = "Deposito"
        btnDeposito.UseVisualStyleBackColor = False
        ' 
        ' btnExtraerTodo
        ' 
        btnExtraerTodo.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnExtraerTodo.Location = New Point(281, 164)
        btnExtraerTodo.Name = "btnExtraerTodo"
        btnExtraerTodo.Size = New Size(95, 37)
        btnExtraerTodo.TabIndex = 6
        btnExtraerTodo.Text = "Extraer todo "
        btnExtraerTodo.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(469, 280)
        Controls.Add(btnExtraerTodo)
        Controls.Add(btnDeposito)
        Controls.Add(btnExtracción)
        Controls.Add(btnSalir)
        Controls.Add(btnCerrarCuenta)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSaldo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCerrarCuenta As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnExtracción As Button
    Friend WithEvents btnDeposito As Button
    Friend WithEvents btnExtraerTodo As Button
End Class
