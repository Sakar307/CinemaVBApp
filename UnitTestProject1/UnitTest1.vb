Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CinemaVBApp

<TestClass()> Public Class UnitTest1
    <TestMethod()> Public Sub Adult_Before_5_Test()
        Dim form1 As Form = New Form
        Dim adult_before_5 = form1.Adult_Before_5(2, "person", "wednesday", 4)

        Assert.AreEqual(29.0, adult_before_5)
    End Sub
    <TestMethod()> Public Sub Adult_After_5_Test()
        Dim form1 As Form = New Form
        Dim adult_before_5 = form1.Adult_After_5(2, "person", "wednesday", 6)
        Assert.AreEqual(35.0, adult_before_5)
    End Sub
    <TestMethod()> Public Sub Adult_tuesday_Allday_Test()
        Dim form1 As Form = New Form
        Dim Adult_Tuesday_Allday = form1.Adult_Tuesday_Allday(2, "person", "tuesday", 6)
        Assert.AreEqual(26.0, Adult_Tuesday_Allday)
    End Sub
    <TestMethod()> Public Sub Child_Under16_allday_test()
        Dim form1 As Form = New Form
        Dim Child_Under16_Allday = form1.Child_Under16_Allday(1, "person", "tuesday", 6, 12)
        Assert.AreEqual(12.0, Child_Under16_Allday)
    End Sub
    <TestMethod()> Public Sub Senior_65andAbove_test()
        Dim form1 As Form = New Form
        Dim senior_65andAbove_Allday = form1.Senior_65andAbove_Allday(1, "person", "tuesday", 6, 67)
        Assert.AreEqual(12.5, senior_65andAbove_Allday)
    End Sub
    <TestMethod()> Public Sub Student_Allday_test()
        Dim form1 As Form = New Form
        Dim Student_Allday = form1.Student_Allday(2, "Student", "Monday", 6)
        Assert.AreEqual(28.0, Student_Allday)
    End Sub
    <TestMethod()> Public Sub Family_Allday_test()
        Dim form1 As Form = New Form
        Dim Family_Allday = form1.Family_Allday(2, "Family", "Monday", 6)
        Assert.AreEqual(92.0, Family_Allday)
    End Sub
    <TestMethod()> Public Sub Chick_Flcik_thursday_test()
        Dim form1 As Form = New Form
        Dim Chick_Flick_Thursday = form1.Chick_Flick_Thrusday(1, "ChickFlick", "Thursday", 6)
        Assert.AreEqual(21.5, Chick_Flick_Thursday)
    End Sub
    <TestMethod()> Public Sub Kids_Carers_Wednesday_test()
        Dim form1 As Form = New Form
        Dim Kids_Carers_Wednesday = form1.Kids_Carers_Wednesday(1, "KidsandCarers", "Wednesday", 6)
        Assert.AreEqual(12.0, Kids_Carers_Wednesday)
    End Sub
End Class