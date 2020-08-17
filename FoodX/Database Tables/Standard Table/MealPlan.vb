Public Class MealPlan

    Inherits DatabaseTable

    Public calCount As Integer
    Public fatCount As Integer
    Public proCount As Integer
    Public carbCount As Integer

    Public Sub setContents()


        MainConnectionAccess.conndb.addCriteria("preWorkout", 0)
        MainConnectionAccess.conndb.addCriteria("breakfast", 0)
        MainConnectionAccess.conndb.addCriteria("lunch", 0)
        MainConnectionAccess.conndb.addCriteria("dinner", 0)
        MainConnectionAccess.conndb.addCriteria("snack", 0)
        MainConnectionAccess.conndb.addCriteria("drink1", 0)
        MainConnectionAccess.conndb.addCriteria("drink2", 0)
        executeSelect("tblMealPlan")

    End Sub
    Function getMealID(day, meal)

        Return getValue(Day, meal)

    End Function


End Class
