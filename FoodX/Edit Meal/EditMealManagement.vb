Public Class EditMealManagement

    Dim mealID As Integer

    Public meals As NutritionalInfo = New NutritionalInfo

    Public Sub New(ByVal mealIDToEdit As Integer)

        mealID = mealIDToEdit

    End Sub
    Public Sub setContentsForSelectedMeal()

        meals.addConditions("mealID", mealID)
        meals.executeSelect("tblMeal")

    End Sub
    Function getMealName()

        Return meals.getCurrentRowValue("name")

    End Function

End Class
