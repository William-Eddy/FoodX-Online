Public Class changeServing

    Dim mealID As String
    Dim newServing As Integer
    Dim multiplier As Double
    Dim mealIngredients As MealIngredients = New MealIngredients
    Dim meals As MealsWithNutritionalInfo = New MealsWithNutritionalInfo

    Public Sub New(mealID, newServing)

        Me.mealID = mealID
        Me.newServing = newServing

    End Sub

    Public Sub executeChange()

        setMealsContent()
        setMealIngredientsContent()

        setMultiplier()

        updateIngredientQuantities()

    End Sub

    Public Sub setMultiplier()

        Dim previousServing As Integer = meals.getCurrentServings
        multiplier = (1 / previousServing) * newServing

    End Sub

    Private Sub setMealsContent()

        meals.addConditions("mealID", mealID)
        meals.executeSelect()

    End Sub

    Private Sub setMealIngredientsContent()

        mealIngredients.addConditions("mealID", mealID)
        mealIngredients.executeSelect()

    End Sub

    Private Sub updateNutritionalInfo()

        meals.addValues("fat", (multiply(meals.getFat)))
        meals.addValues("protein", (multiply(meals.getProtein)))
        meals.addValues("carbs", (multiply(meals.getCarbs)))
        meals.addValues("calories", (multiply(meals.getCalories)))
        meals.addConditions("mealID", mealID)
        meals.executeUpdate()

    End Sub

    Private Sub updateIngredientQuantities()

        mealIngredients.setRowColumnIndexToZero()
        Dim currentQuantity As Integer

        For Each row In mealIngredients.table.Rows

            currentQuantity = mealIngredients.getCurrentQuantity

            mealIngredients.addValues("quantity", multiply(currentQuantity))
            mealIngredients.addConditions("mealIngredientsID", mealIngredients.getCurrentMealIngredientID)
            mealIngredients.executeUpdate()

            mealIngredients.increaseRowCount()

        Next


    End Sub

    Function multiply(currentValue)

        Return Math.Ceiling(currentValue * multiplier)

    End Function




End Class
