Public Class EditMealManagement

    Dim mealID As Integer

    Public meals As NutritionalInfo = New NutritionalInfo
    Public mealIngredients As MealIngredients = New MealIngredients
    Public ingredients As Ingredients = New Ingredients
    Dim ingredientsForMeal As DatabaseTable = New DatabaseTable

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

    Function getMealIngredientsTable()

        ingredientsForMeal = New DatabaseTable

        Dim ingredientID As String
        Dim name As String
        Dim quantity As String

        ingredients.setContents()
        setMealIngredientsContents()
        setMealIngredientsTableColumns()

        For Each row As DataRow In mealIngredients.table.Rows

            ingredientID = mealIngredients.getCurrentRowValue(0)
            name = ingredients.getIngredientName(ingredientID)
            quantity = mealIngredients.getCurrentRowValue(1)

            ingredientsForMeal.table.Rows.Add(ingredientID, name, quantity)

            mealIngredients.increaseRowCount()

        Next

        Return ingredientsForMeal.table

    End Function

    Public Sub setMealIngredientsContents()

        mealIngredients.addColumnsForReturn("ingredientID")
        mealIngredients.addColumnsForReturn("quantity")
        mealIngredients.addConditions("mealID", mealID)
        mealIngredients.executeSelect("tblMealIngredients")

    End Sub
    Private Sub setMealIngredientsTableColumns()

        With ingredientsForMeal.table.Columns

            .Add("id", GetType(String))
            .Add("Ingredient", GetType(String))
            .Add("Quantity", GetType(String))

        End With

    End Sub

End Class
