Public Class IngredientDropDown

    Public ingredients As Ingredients = New Ingredients
    Public Sub setContents()

        ingredients.addColumnsForReturn("ingredientID")
        ingredients.addColumnsForReturn("name")

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

End Class
