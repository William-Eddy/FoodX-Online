Public Class ShoppingListGenerationOld

    Public mealID As String
    Public mealPlan As MealPlanOld
    Public mealsRequired As DatabaseTableOld
    Public mealIngredients As DatabaseTableOld = New DatabaseTableOld
    Public ingredientsRequired As DatabaseTableOld
    Public shoppingList As DatabaseTableOld = New DatabaseTableOld
    Dim shoppingListView As ShoppingListDisplay = New ShoppingListDisplay

    Public Sub GenerateList()

        getMealsFromPlan()
        getIngredientQuantites()
        setShoppingListFormatting()
        checkIngredientAvailabilityAndInsert()

    End Sub

    Public Sub getMealsFromPlan()

        'initialise tables

        clearShoppingList()
        initialiseMealPlan()
        initialiseMealsRequired()

        'establish meals required

        For Each row As DataRow In mealPlan.table.Rows

            For Each column As DataColumn In mealPlan.table.Columns

                mealID = mealPlan.getValue(mealPlan.currentRowIndex, mealPlan.currentColumnIndex)

                If mealID = "0" Then
                    'nothing
                Else
                    mealsRequired.increaseQuantity(0, mealID, 1, 1)
                End If

                mealPlan.addColCount()
            Next

            mealPlan.currentColumnIndex = 0
            mealPlan.addRowCount()
        Next

    End Sub

    Public Sub getIngredientQuantites()

        'get ingredients required

        mealsRequired.setIndexToZero()

        Dim servingsRequired As Integer = 0
        Dim batchesRequired As Integer = 0
        Dim meal As DatabaseTableOld = New DatabaseTableOld
        Dim serves As Integer

        Dim ingredientQuantityPerBatch As Integer
        Dim ingredientID As Integer
        Dim totalIngredientQuantity As Integer = 0

        initialiseIngredientsRequired()

        For Each mealsRequiredRow As DataRow In mealsRequired.table.Rows

            'get meal info

            mealID = Int(mealsRequired.getCurrentValue("c", 0))
            servingsRequired = Int(mealsRequired.getCurrentValue("c", 1))
            batchesRequired = 0

            meal.setTableContents("SELECT `serves`, `stock` FROM `tblMeal` WHERE mealID=" + Str(mealID))
            serves = Int(meal.getValue(0, 0))

            servingsRequired = servingsRequired - Int(meal.getValue(0, 1))

            If servingsRequired > 0 Then

                setMealIngredients(mealID)

                batchesRequired = Math.Round(servingsRequired / serves, 0)
                mealIngredients.setIndexToZero()

                MainConnectionAccess.conndb.updatePendingMeals(mealID, batchesRequired) '############################################################

                For Each mealIngredientsRow As DataRow In mealIngredients.table.Rows

                    ingredientID = mealIngredients.getCurrentValue("c", 0)
                    ingredientQuantityPerBatch = mealIngredients.getValue(mealIngredients.currentRowIndex, 1)
                    totalIngredientQuantity = ingredientQuantityPerBatch * batchesRequired

                    ingredientsRequired.increaseQuantity(0, ingredientID, 1, totalIngredientQuantity)

                    mealIngredients.addRowCount()
                Next

            End If
            mealsRequired.addRowCount()

        Next

    End Sub

    Public Sub checkIngredientAvailabilityAndInsert()

        Dim ingredients As DatabaseTableOld
        Dim ingredientID As String
        Dim quantity As Integer
        Dim quantityRequired As Integer
        Dim realQuantityRequired As Integer
        Dim name As String
        Dim unit As String
        ingredientsRequired.setIndexToZero()

        shoppingListView.addColumnFormatting()

        For Each row As DataRow In ingredientsRequired.table.Rows

            ingredients = New DatabaseTableOld
            ingredients.initialise()

            ingredientID = ingredientsRequired.getCurrentValue("c", 0)
            ingredients.setTableContents("SELECT `quantity` , `name`, `measurement` FROM `tblIngredients` WHERE ingredientID=" + ingredientID)
            quantity = Int(ingredients.getValue(0, 0))
            name = ingredients.getValue(0, 1)
            quantityRequired = Int(ingredientsRequired.getValue(ingredientsRequired.currentRowIndex, 1))
            unit = ingredients.getValue(0, 2)

            realQuantityRequired = quantityRequired - quantity

            If realQuantityRequired > 0 Then
                MainConnectionAccess.conndb.addToShoppingList(ingredientID, realQuantityRequired, name, unit)
                shoppingList.addNewItem(name, realQuantityRequired)
            End If

            ingredientsRequired.addRowCount()
        Next

    End Sub

    Private Sub clearShoppingList()
        MainConnectionAccess.conndb.runAdapter("DELETE FROM `tblShoppingList`")
    End Sub

    Private Sub setAvailableStock()
        MainConnectionAccess.conndb.runAdapter("UPDATE `tblMeal` SET `available` = `stock`")
    End Sub

    Private Sub initialiseMealPlan()
        mealPlan = New MealPlanOld
        mealPlan.setMealPlanTableData()
    End Sub

    Private Sub initialiseMealsRequired()

        mealsRequired = New DatabaseTableOld

        mealsRequired.initialise()

        With mealsRequired.table.Columns

            .Add("mealID", GetType(Integer))
            .Add("quantity", GetType(Integer))

        End With

    End Sub

    Private Sub initialiseIngredientsRequired()

        ingredientsRequired = New DatabaseTableOld
        ingredientsRequired.initialise()

        With ingredientsRequired.table.Columns

            .Add("ingredientID", GetType(Integer))
            .Add("quantity", GetType(Integer))

        End With

    End Sub

    Public Sub setMealIngredients(mealID)

        mealIngredients.setTableContents("SELECT `ingredientID`, `quantity` FROM `tblMealIngredients` WHERE mealID=" + mealID)

    End Sub

    Function getIngredientID()

        Return mealIngredients.getValue(mealIngredients.currentRowIndex, 0)

    End Function

    Public Sub setShoppingListFormatting()

        shoppingList.initialise()
        With shoppingList.table.Columns

            .Add("name", GetType(String))
            .Add("quantity", GetType(Integer))

        End With

    End Sub

    Function getShoppingListItem(indexrow, indexcol)

        Return shoppingList.getValue(indexrow, indexcol)

    End Function

    Function getShoppingListCount()

        Return shoppingList.getRowCount

    End Function
End Class
