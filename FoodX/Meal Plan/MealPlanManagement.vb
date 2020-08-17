Public Class MealPlanManagement

    Public mealPlan As MealPlan
    Public meals As NutritionalInfo

    Function getMeal(day, meal)

        Dim mealID As String

        mealID = mealPlan.getMealID(day, meal)

        Return meals.getMealName(mealID)

        meals.addNutritonalInfo(mealID)

    End Function

    Public Sub setMealsContent()

        meals.setContents()

    End Sub

    Public Sub setMealPlanContent()

        mealPlan.setContents()

    End Sub

    Public Sub resetNurtionalInfo()

        meals.resetNutritionalCounts()

    End Sub
End Class
