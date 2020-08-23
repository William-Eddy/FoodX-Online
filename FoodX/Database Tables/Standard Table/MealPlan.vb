Public Class MealPlan

    Inherits DatabaseTable

    Public calCount As Integer
    Public fatCount As Integer
    Public proCount As Integer
    Public carbCount As Integer

    Public Sub setContents()


        MainConnectionAccess.conndb.addColumns("preWorkout", 0)
        MainConnectionAccess.conndb.addColumns("breakfast", 0)
        MainConnectionAccess.conndb.addColumns("lunch", 0)
        MainConnectionAccess.conndb.addColumns("dinner", 0)
        MainConnectionAccess.conndb.addColumns("snack", 0)
        MainConnectionAccess.conndb.addColumns("drink1", 0)
        MainConnectionAccess.conndb.addColumns("drink2", 0)
        executeSelect("tblMealPlan")

    End Sub
    Function getMealID(day, meal)

        Return getValue(Day, meal)

    End Function


End Class
