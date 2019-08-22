Public Class Form
    Public Function Adult_Before_5(quantity As Integer, person As String, day As String, time As Decimal) As Double
        Dim Actual_price As Double = 14.5
        Dim total_Price = Actual_price * quantity
        If time <= 5 Then
            Return total_Price
        Else Return 0
        End If

    End Function
    Public Function Adult_After_5(quantity As Integer, person As String, day As String, time As Decimal) As Double
        Dim Actual_price As Double = 17.5
        Dim total_Price = Actual_price * quantity
        If time >= 5 Then
            Return total_Price
        Else Return 0
        End If
    End Function

    Public Function Adult_Tuesday_Allday(quantity As Integer, person As String, day As String, time As Decimal) As Double
        Dim Actual_Price As Double = 13
        Dim total_price = Actual_Price * quantity
        If day = "tuesday" Then
            Return total_price
        Else Return 0
        End If
    End Function
    Public Function Child_Under16_Allday(quantity As Integer, person As String, day As String, time As Decimal, Age As Double) As Double
        Dim Actual_Price As Double = 12
        Dim total_price = Actual_Price * quantity
        If Age <= 16 Then
            Return total_price
        Else Return 0
        End If
    End Function
    Public Function Senior_65andAbove_Allday(quantity As Integer, person As String, day As String, time As Decimal, Age As Double) As Double
        Dim Actual_Price As Double = 12.5
        Dim total_price = Actual_Price * quantity
        If Age >= 65 Then
            Return total_price
        Else Return 0
        End If
    End Function
    Public Function Student_Allday(quantity As Integer, person As String, day As String, time As Decimal) As Double
        Dim Actual_Price As Double = 14.0
        Dim total_price = Actual_Price * quantity
        If person = "Student" Then
            Return total_price
        Else Return 0
        End If
    End Function
    Public Function Family_Allday(quantity As Integer, person As String, day As String, time As Decimal) As Double
        Dim Actual_Price As Double = 46.0
        Dim total_price = Actual_Price * quantity
        If person = "Family" Then
            Return total_price
        Else Return 0
        End If
    End Function
    Public Function Chick_Flick_Thrusday(quantity As Integer, person As String, day As String, time As Decimal) As Double
        Dim Actual_Price As Double = 21.5
        Dim total_price = Actual_Price * quantity
        If day = "Thursday" And person = "ChickFlick" Then
            Return total_price
        Else Return 0
        End If
    End Function
    Public Function Kids_Carers_Wednesday(quantity As Integer, person As String, day As String, time As Decimal) As Double
        Dim Actual_Price As Double = 12.0
        Dim total_price = Actual_Price * quantity
        If day = "Wednesday" And person = "KidsandCarers" Then
            Return total_price
        Else Return 0
        End If
    End Function
    Private Sub Cinemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
