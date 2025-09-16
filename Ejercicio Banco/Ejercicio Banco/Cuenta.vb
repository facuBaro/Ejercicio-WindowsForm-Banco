Imports System.Text.RegularExpressions

Public Class Cuenta
    Private id As Integer
    Private nombreyapellido As String
    Private direccion As String
    Private dni As Integer
    Private telefono As Integer
    Private tipoCuenta As Char
    Private descubierto As Integer
    Private saldo As Integer
    Public Property id2 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            If id < 0 Then
                MsgBox("Error en el ID")
            Else
                id = value
            End If
        End Set
    End Property
    Public Property nombreyapellido2 As String
        Get
            Return nombreyapellido
        End Get
        Set(value As String)
            Dim longitud As Integer
            Dim aux As Integer

            longitud = Len(value)
            For i = 0 To longitud - 1

                If IsNumeric(value(i)) Then
                    aux = aux + 1
                End If
            Next i
            If aux >= 1 Then
                MsgBox("Nombre invalido, no debe contener valores numericos")

            Else
                nombreyapellido = value
            End If
        End Set
    End Property

    Public Property direccion2 As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property
    Public Property dni2 As Integer
        Get
            Return dni
        End Get
        Set(value As Integer)
            If value > 0 Then
                dni = value
            Else
                MsgBox("Valor de DNI invalido")

            End If
        End Set
    End Property
    Public Property telefono2 As Integer
        Get
            Return telefono
        End Get
        Set(value As Integer)
            If value > 0 Then
                telefono = value
            Else
                MsgBox("Valor de telefono invalido")

            End If
        End Set
    End Property
    Public Property tipodecuenta2 As Char
        Get
            Return tipoCuenta
        End Get
        Set(value As Char)
            If value <> "A" And value <> "C" Then
                MsgBox("Tipo de Cuenta Invalido")
            Else
                tipoCuenta = value
            End If
        End Set
    End Property
    Public Property descubierto2 As Integer
        Get
            Return descubierto
        End Get
        Set(value As Integer)
            descubierto = value
        End Set
    End Property
    Public Property saldo2 As Integer
        Get
            Return saldo
        End Get
        Set(value As Integer)
            saldo = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(nombreyapellido As String, direccion As String, dni As Integer, telefono As Integer, tipocuenta As Char, descubierto As Integer)
        Me.nombreyapellido2 = nombreyapellido
        Me.direccion2 = direccion
        Me.dni2 = dni
        Me.telefono2 = telefono
        Me.tipodecuenta2 = tipocuenta
        Me.descubierto2 = descubierto

    End Sub
    Public Function datos() As String
        Dim resultado As String

        resultado = "id: " + Convert.ToString(id) + " - " + nombreyapellido + " - " + direccion + " - " + Convert.ToString(telefono) + " - " + "TipoCta: " + tipoCuenta
        id = id + 1
        Return resultado
    End Function
    Public Function depositar(monto As Integer) As Integer
        saldo = saldo + monto
        Return saldo
    End Function
    Public Function extraer(monto As Integer) As Boolean
        Dim resultado As Boolean
        If descubierto = 0 Then
            If monto <= saldo Then
                saldo = saldo - monto
                resultado = True
            Else
                resultado = False
            End If

        End If
        If descubierto > 0 Then
            If (saldo - monto) >= (descubierto * -1) Then
                saldo = saldo - monto
                resultado = True
            Else
                resultado = False
            End If
        End If

        Return resultado
    End Function
    Public Function extraer() As Boolean
        Dim resultado As Boolean

        If saldo < 0 Then
            resultado = False
        Else
            saldo = 0
            resultado = True
        End If



        Return resultado
    End Function
End Class
