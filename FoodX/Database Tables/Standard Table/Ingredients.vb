Public Class Ingredients
    Inherits DatabaseTable

    Public Sub setContents()

        setTableContents("SELECT `name` , `quantity`, `measurement` FROM `tblIngredients`")

    End Sub

    Function getQuantityInStock(ingredientID)

        Return getSingleSearchValue("ingredientID", ingredientID, "quantity")

    End Function






End Class
