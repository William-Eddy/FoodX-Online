Public Class IngredientsRequired
    Inherits QuantityList

    Public Sub addIngredient(ingredientID, quantity)

        addItem(ingredientID, quantity)

    End Sub

    Function getCurrentIngredientID()

        Return getCurrentRowValue(0)

    End Function

    Function getCurrentQuantity()

        Return getCurrentRowValue(1)

    End Function

End Class
