Public Class EditMealManagement

    Dim mealID As Integer

    Public meals As MealsWithNutritionalInfo = New MealsWithNutritionalInfo
    Public mealIngredients As MealIngredients = New MealIngredients
    Public ingredients As Ingredients = New Ingredients

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
    Function getNumberOfServings()
        Return meals.getCurrentRowValue("serves")
    End Function
    Function getStock()
        Return meals.getCurrentRowValue("stock")
    End Function
    Function getCategory()
        Return meals.getCurrentRowValue("category")
    End Function
    Function getCalories()
        Return meals.getCurrentRowValue("calories")
    End Function
    Function getCarbs()
        Return meals.getCurrentRowValue("carbs")
    End Function
    Function getFat()
        Return meals.getCurrentRowValue("fat")
    End Function
    Function getProtein()
        Return meals.getCurrentRowValue("protein")
    End Function

End Class
