Public Class Ingredients
    Inherits DatabaseTable

    Public Sub setContents()

        addColumnsForReturn("name")
        addColumnsForReturn("quantity")
        addColumnsForReturn("measurement")
        addColumnsForReturn("ingredientID")
        addColumnsForReturn("price")

        executeSelect()

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

    Function getCurrentIngredientName()

        Return getCurrentRowValue("name")

    End Function

    Function getCurrentQuantity()

        Return getCurrentRowValue("quantity")

    End Function
    Function getCurrentPrice()

        Return getCurrentRowValue("price")

    End Function

    Function getCurrentUnit()

        Return getCurrentRowValue("measurement")

    End Function

    Public Overloads Sub executeSelect()

        executeSelect("tblIngredients")

    End Sub
    Public Overloads Sub executeUpdate()

        executeUpdate("tblIngredients")

    End Sub

    Public Overloads Sub executeInsert()

        executeInsert("tblIngredients")

    End Sub

    Public Overloads Sub executeDelete()

        executeDelete("tblIngredients")

    End Sub

End Class
