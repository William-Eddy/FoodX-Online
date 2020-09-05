Public Class Ingredients
    Inherits DatabaseTable

    Public Sub setContents()

        addColumnsForReturn("name")
        addColumnsForReturn("quantity")
        addColumnsForReturn("measurement")
        addColumnsForReturn("ingredientID")
        addColumnsForReturn("price")

        executeSelect("tblIngredients")

    End Sub

    Function getQuantityInStock(ingredientID)

        Return getSingleSearchValue("ingredientID", ingredientID, "quantity")

    End Function

    Function getIngredientName(ingredientID)

        Return getSingleSearchValue("ingredientID", ingredientID, "name")

    End Function
    Function getQuantity(ingredientID)

        Return getSingleSearchValue("ingredientID", ingredientID, "quantity")

    End Function

    Function getUnit(ingredientID)

        Return getSingleSearchValue("ingredientID", ingredientID, "measurement")

    End Function

    Function getPrice(ingredientID)

        Return getSingleSearchValue("ingredientID", ingredientID, "price")

    End Function


End Class
