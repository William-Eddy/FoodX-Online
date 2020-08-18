Public Class MealPlanManagement

    Public mealPlan As MealPlan = New MealPlan
    Public meals As NutritionalInfo = New NutritionalInfo
    Public mealOptions As Meals = meals

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

    Public Sub setMealOptions(mealType)

        mealOptions.addConditions("category", mealType)
        mealOptions.executeSelect("tblMeal")

    End Sub

    Function getMealOptionDataSource()

        Return mealOptions.table

    End Function

    Function getMealOptionValueMember()

        Return mealOptions.table.Columns(0).ToString

    End Function

    Function getMealOptionDisplayMember()

        Return mealOptions.table.Columns(1).ToString

    End Function

End Class
