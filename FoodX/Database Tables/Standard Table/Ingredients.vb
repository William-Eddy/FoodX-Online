Public Class Ingredients
    Inherits DatabaseTable

    Public Sub setContents()

        setTableContents("SELECT `name` , `quantity`, `measurement`, `ingredientID` FROM `tblIngredients`")

    End Sub

    Function getQuantityInStock(ingredientID)

        Return getSingleSearchValue("ingredientID", ingredientID, "quantity")

    End Function

    Function getIngredientName(ingredientID)

        Return getSingleSearchValue("ingredientID", ingredientID, "name")

    End Function

    Function getUnit(ingredientID)

        Return getSingleSearchValue("ingredientID", ingredientID, "measurement")

    End Function


End Class
