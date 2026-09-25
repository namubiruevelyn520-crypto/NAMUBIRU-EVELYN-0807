Public Class BankAccount
    Private _balance As Decimal

    Public ReadOnly Property Balance As Decimal
        Get
            Return _balance
        End Get
    End Property

    Public Sub Deposit(ByVal amount As Decimal)
        If amount <= 0 Then
            Console.WriteLine("Invalid deposit.")
        Else
            _balance += amount
        End If
    End Sub

    Public Sub Withdraw(ByVal amount As Decimal)
        If amount <= 0 Then
            Console.WriteLine("Invalid withdrawal.")
        ElseIf amount > _balance Then
            Console.WriteLine("Insufficient funds.")
        Else
            _balance -= amount
        End If
    End Sub
End Class

Module Program
    Sub Main()
        Dim account As New BankAccount()

        account.Deposit(100000)
        account.Withdraw(30000)

        Console.WriteLine("Balance: " & account.Balance)

        Console.ReadLine()
    End Sub
End Module

