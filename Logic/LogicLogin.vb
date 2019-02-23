Imports Model
Imports Data

Public Class LogicLogin
    Private datalog As New DataLogin

    Public Function Login(ByVal nama As String, ByVal pass As String) As ModelLogin
        Return datalog.Login(nama, pass)
    End Function

    Public Function Logout()
        Return datalog.Logout()
    End Function
End Class
