Public Class MealPlan

    Inherits DatabaseTable

    Public calCount As Integer
    Public fatCount As Integer
    Public proCount As Integer
    Public carbCount As Integer

    Public Sub setContents()

        setTableContents(MainConnectionAccess.conndb.executeSelect("tblMealPlan"))

    End Sub
    Function getMealID(day, meal)

        Return getValue(Day, meal)

    End Function


End Class
