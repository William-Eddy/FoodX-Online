Public Class MealListviewFormatting

    Dim meals As Meals = New Meals

    Function getMealsFromDatabase(category)

        meals.addColumnsForReturn("mealID")
        meals.addColumnsForReturn("name")
        meals.addConditions("category", category)
        meals.executeSelect("tblMeal")

        Return meals.table

    End Function


End Class
