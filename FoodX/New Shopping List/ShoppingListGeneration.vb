Public Class ShoppingListGeneration

    Public mealPlan As MealPlan = New MealPlan
    Public mealsRequired As MealsRequired = New MealsRequired

    Public Sub generateList()

        getMealsFromPlan()
        calculateIngredientsRequired()

    End Sub

    Private Sub getMealsFromPlan()

        Dim mealID As String

        '#####clearShoppingList()

        mealPlan.setContents()
        mealsRequired.setColumns()

        For Each row As DataRow In mealPlan.table.Rows

            For Each column As DataColumn In mealPlan.table.Columns

                mealID = mealPlan.getCurrentValue

                If Not (mealID = "0") Then
                    mealsRequired.addMeal(mealID)
                End If

                mealPlan.increaseColumnCount()
            Next

            mealPlan.setColumnIndexToZero()
            mealPlan.increaseRowCount()
        Next

        mealsRequired.printTable()

    End Sub

    Public Sub calculateIngredientsRequired()

        Dim meals As Meals = New Meals
        Dim mealIngredients As MealIngredients = New MealIngredients

        Dim serves As Integer
        Dim stock As Integer
        Dim servings As Integer
        Dim servingsRequired As Integer
        Dim batchesRequired As Integer

        Dim mealID As String

        meals.setContents()
        mealIngredients.setContents()

        Dim ingredientsForSelectedMeal() As System.Data.DataRow


        mealsRequired.setRowColumnIndexToZero()

        For Each mealsRequiredRow As DataRow In mealsRequired.table.Rows

            mealID = mealsRequired.getCurrentMealID
            servings = mealsRequired.getServingsRequired
            serves = meals.getServing(mealID)
            stock = meals.getStock(mealID)

            servingsRequired = calculateServingsRequired(servings, stock)

            If servingsRequired > 0 Then

                batchesRequired = calculateBactchesRequired(servingsRequired, serves)
                ingredientsForSelectedMeal = mealIngredients.getSelectedMealIngredients(mealID)

                For Each mealIngredientsRow As DataRow In mealIngredients.table.Rows



                    mealIngredients.increaseRowCount()
                Next

            End If

        Next


        MsgBox("Complete")

    End Sub

    Function calculateServingsRequired(servings, stock)

        Return servings - stock

    End Function

    Function calculateBactchesRequired(servingsRequired, serves)

        Return Math.Round(servingsRequired / serves, 0)

    End Function

End Class
