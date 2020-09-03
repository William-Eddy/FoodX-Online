Public Class IngredientDropDown

    Public ingredients As Ingredients = New Ingredients
    Public Sub setContents()

        ingredients.addColumnsForReturn("ingredientID")
        ingredients.addColumnsForReturn("name")
        ingredients.addColumnsForReturn("measurement")

        ingredients.executeSelect("tblIngredients")

    End Sub

    Function getValueMember()

        Return "ingredientID"

    End Function

    Function getDisplayMember()

        Return "name"

    End Function

    Function getDataSource()

        Return ingredients.table

    End Function

    Function getUnit(ingredientID)

        Return ingredients.getSingleSearchValue("ingredientID", ingredientID, "measurement")

    End Function

End Class
