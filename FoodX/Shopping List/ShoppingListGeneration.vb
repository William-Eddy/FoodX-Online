Public Class ShoppingListGeneration

    Public mealPlan As MealPlan = New MealPlan
    Public mealsRequired As MealsRequired = New MealsRequired
    Public ingredientsRequired As IngredientsRequired = New IngredientsRequired
    Public databaseOperations As ShoppingListDatabaseOperations = New ShoppingListDatabaseOperations
    Dim emailList As ShoppingListEmail = New ShoppingListEmail
    Dim containers As Containers = New Containers
    Dim foodStorage As FoodStorage = New FoodStorage

    Dim containerTotal As Integer
    Dim freezerCapacity As Integer
    Dim containersInUse As Integer

    Public Sub generateList()

        databaseOperations.clearShoppingList()
        databaseOperations.clearPending()

        setFreezerCapacity()
        setContainersInUse()
        containers.setMealsContents()

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

                    If checkForCapacity(mealID) = True Then
                        mealsRequired.addMeal(mealID)
                    Else
                        Exit Sub
                    End If

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

        meals.executeSelect()
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

                mealIngredients.setRowColumnIndexToZero()

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
        Dim price As Double
        Dim totalPrice As Double
        Dim unit As String

        Dim quantityRequiredToBuy As Integer

        emailList.setEmailSetup()
        emailList.setBodyPart1()

        ingredients.setContents()
        ingredientsRequired.setRowColumnIndexToZero()

        For Each row As DataRow In ingredientsRequired.table.Rows

            ingredientID = ingredientsRequired.getCurrentIngredientID
            ingredientName = ingredients.getIngredientName(ingredientID)
            quantityInStock = ingredients.getQuantityInStock(ingredientID)
            price = ingredients.getPrice(ingredientID)
            quantityRequired = ingredientsRequired.getCurrentQuantity
            unit = ingredients.getUnit(ingredientID)


            quantityRequiredToBuy = quantityRequired - quantityInStock

            If quantityRequiredToBuy > 0 Then

                databaseOperations.addIngredientValue("ingredientID", ingredientID)
                databaseOperations.addIngredientValue("quantity", quantityRequiredToBuy)
                databaseOperations.addIngredientValue("name", ingredientName)
                databaseOperations.executeInsertCommand()

                emailList.addIngredient(ingredientName, price, quantityRequiredToBuy, unit)

                totalPrice += price

            End If

            ingredientsRequired.increaseRowCount()
        Next

        sendEmail()

    End Sub

    Function calculateServingsRequired(servings, stock)

        Return servings - stock

    End Function

    Function calculateBactchesRequired(servingsRequired, serves)

        Dim batchesRequired As Double

        batchesRequired = servingsRequired / serves

        Return Math.Ceiling(batchesRequired)

    End Function

    Function checkForCapacity(mealID)

        containerTotal = +containers.getNumberOfContainersForMeal(mealID)

        If containerTotal > (freezerCapacity - containersInUse) Then

            MsgBox("The freezer capacity has been reached!")
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub setFreezerCapacity()

        freezerCapacity = foodStorage.getFreezerCapacity()

    End Sub

    Private Sub setContainersInUse()

        containersInUse = containers.getTotalNumberOfContainersInUse

    End Sub

    Private Sub sendEmail()

        emailList.setBodyPart2()
        emailList.addTotal()
        emailList.setBodyPart3()
        emailList.setToBody()
        emailList.sendEmail()

    End Sub

End Class
