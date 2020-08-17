Public Class ShoppingListGeneration

    Public mealPlan As MealPlan = New MealPlan
    Public mealsRequired As MealsRequired = New MealsRequired
    Public ingredientsRequired As IngredientsRequired = New IngredientsRequired
    Public databaseOperations As ShoppingListDatabaseOperations = New ShoppingListDatabaseOperations

    Public Sub generateList()

        databaseOperations.clearShoppingList()
        databaseOperations.clearPending()

        getMealsFromPlan()
        calculateIngredientsRequired()
        checkIngredientAvailabilityAndInsert()

    End Sub

    Private Sub getMealsFromPlan()

        Dim mealID As String

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

        Dim batchesRequired As Integer

        Dim ingredientID As Integer
        Dim totalIngredientQuantity As Integer

        meals.setContents()
        mealIngredients.setContents()

        mealsRequired.setRowColumnIndexToZero()
        ingredientsRequired.setColumns()

        For Each mealsRequiredRow As DataRow In mealsRequired.table.Rows

            Dim mealID As String = mealsRequired.getCurrentMealID
            Dim servings As Integer = mealsRequired.getServingsRequired
            Dim serves As Integer = meals.getServing(mealID)
            Dim stock As Integer = meals.getStock(mealID)


            Dim servingsRequired As Integer = calculateServingsRequired(servings, stock)

            If servingsRequired > 0 Then

                batchesRequired = calculateBactchesRequired(servingsRequired, serves)

                databaseOperations.updatePendingMeals(mealID, (batchesRequired * serves))

                For Each selectedRow As DataRow In mealIngredients.table.Rows

                    Dim currentMealID As String = Str(mealIngredients.getCurrentMealID)

                    If currentMealID = Str(mealID) Then

                        ingredientID = mealIngredients.getCurrentIngredientID
                        totalIngredientQuantity = mealIngredients.getTotalIngredientQuantity(batchesRequired)

                        ingredientsRequired.addIngredient(ingredientID, totalIngredientQuantity)

                    End If

                    mealIngredients.increaseRowCount()
                Next

            End If

            mealsRequired.increaseRowCount()

        Next

        ingredientsRequired.printTable()

    End Sub
    Public Sub checkIngredientAvailabilityAndInsert()

        Dim ingredients As Ingredients = New Ingredients

        Dim ingredientID As String
        Dim ingredientName As String
        Dim quantityInStock As Integer
        Dim quantityRequired As Integer

        Dim quantityRequiredToBuy As Integer


        ingredients.setContents()
        ingredientsRequired.setRowColumnIndexToZero()

        For Each row As DataRow In ingredientsRequired.table.Rows

            ingredientID = ingredientsRequired.getCurrentIngredientID
            ingredientName = ingredients.getIngredientName(ingredientID)
            quantityInStock = ingredients.getQuantityInStock(ingredientID)
            quantityRequired = ingredientsRequired.getCurrentQuantity

            quantityRequiredToBuy = quantityRequired - quantityInStock

            If quantityRequiredToBuy > 0 Then

                databaseOperations.addIngredientValue("ingredientID", ingredientID)
                databaseOperations.addIngredientValue("quantity", quantityRequiredToBuy)
                databaseOperations.addIngredientValue("name", ingredientName)
                databaseOperations.executeInsertCommand()

            End If

            ingredientsRequired.increaseRowCount()
        Next

    End Sub

    Function calculateServingsRequired(servings, stock)

        Return servings - stock

    End Function

    Function calculateBactchesRequired(servingsRequired, serves)

        Dim batchesRequired As Double

        batchesRequired = servingsRequired / serves

        Return Math.Ceiling(batchesRequired)

    End Function

End Class
