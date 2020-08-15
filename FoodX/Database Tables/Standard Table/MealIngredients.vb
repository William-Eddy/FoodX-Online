Public Class MealIngredients

    Inherits DatabaseTable

    Public Sub setContents()

        setTableContents("SELECT `mealID`, `ingredientID`, `quantity` FROM `tblMealIngredients`")

    End Sub

    Function getTotalIngredientQuantity(batchesRequired)

        Return getCurrentIngredientQuantityPerBatch() * batchesRequired

    End Function
    Function getCurrentIngredientQuantityPerBatch()

        Return getCurrentRowValue(2)

    End Function
    Function getCurrentIngredientID()

        Return getCurrentRowValue(1)

    End Function

    Function getCurrentMealID()

        Return getCurrentRowValue(0)

    End Function











End Class
