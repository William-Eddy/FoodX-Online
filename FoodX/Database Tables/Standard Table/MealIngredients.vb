Public Class MealIngredients

    Inherits DatabaseTable

    Public Sub setContents()

        setTableContents("SELECT `mealID`, `ingredientID`, `quantity` FROM `tblMealIngredients`")

    End Sub

    Function getTotalIngredientQuantity(batchesRequired)

        Return getCurrentIngredientQuantityPerBatch() * batchesRequired

    End Function
    Function getCurrentIngredientQuantityPerBatch()

        Return getCurrentRowValue("quantity")

    End Function
    Function getCurrentIngredientID()

        Return getCurrentRowValue("ingredientID")

    End Function

    Function getCurrentMealID()

        Return getCurrentRowValue("mealID")

    End Function

    Function getCurrentQuantity()

        Return getCurrentRowValue("quantity")

    End Function
    Function getMealID()

        Return getCurrentRowValue("mealID")

    End Function

    Public Overloads Sub executeSelect()

        executeSelect("tblMealIngredients")

    End Sub

End Class
