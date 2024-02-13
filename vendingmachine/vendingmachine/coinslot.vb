Public Class coinslot
    Dim _total As Decimal
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Event buyevent(p As Image)

    Public Property quarters As Integer
    Public Property nickles As Integer
    Public Property dimes As Integer
    Public Property dollhairs As Integer
    Public ReadOnly Property total As Decimal
        Get
            _total = dollhairs + quarters * 0.25 + dimes * 0.1 + nickles * 0.05
            Return _total
        End Get
    End Property
    Sub returncoins()
        RaiseEvent coinreturnevent(dollhairs, quarters, dimes, nickles)
        dollhairs = 0
        quarters = 0
        dimes = 0
        nickles = 0

    End Sub
    Sub insertquarter()
        quarters = quarters + 1
    End Sub
    Sub insertnickles()
        nickles = nickles + 1

    End Sub
    Sub insertdollar()
        dollhairs = dollhairs + 1

    End Sub
    Sub insertdimes()
        dimes = dimes + 1
    End Sub
    Sub buy(p As productcontroll)
        If p.count < 1 And p.productprice >= 0 Then
            p.buy()
            _total = _total - p.productprice
            dollhairs = 0
            quarters = 0
            dimes = 0
            nickles = _total / 0.05
            RaiseEvent buyevent(p.productpicture)

        End If
    End Sub
End Class
