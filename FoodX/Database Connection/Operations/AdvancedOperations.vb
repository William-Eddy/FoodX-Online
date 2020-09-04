Public Class AdvancedOperations

    Dim ingredients As Ingredients = New Ingredients
    Dim meals As Meals = New Meals

    Public Sub resetPrices()

        If confirmMessage() = vbYes Then

            ingredients.addValues("price", 0)
            runIngredientUpdate()

            completeMessage()

        End If

    End Sub

    Public Sub resetIngredientStock()

        If confirmMessage() = vbYes Then

            ingredients.addValues("quantity", 0)
            runIngredientUpdate()

            completeMessage()

        End If

    End Sub

    Public Sub resetMealStock()

        If confirmMessage() = vbYes Then

            meals.addValues("stock", 0)
            runMealUpdate()

            completeMessage()

        End If

    End Sub

    Public Sub resetPendingStock()

        If confirmMessage() = vbYes Then

            meals.addValues("pending", 0)
            runMealUpdate()

            completeMessage()

        End If

    End Sub

    Private Sub runIngredientUpdate()

        ingredients.activateOverride()
        ingredients.executeUpdate("tblIngredients")

    End Sub
    Private Sub runMealUpdate()

        meals.activateOverride()
        meals.executeUpdate("tblMeal")

    End Sub


    Function confirmMessage()

        Dim message As MsgBoxResult

        message = MsgBox("Are you sure you want to continue?", vbYesNo, "Operations")

        Return message

    End Function

    Private Sub completeMessage()

        MsgBox("Operation successful", vbOKOnly, "Operations")

    End Sub

End Class
