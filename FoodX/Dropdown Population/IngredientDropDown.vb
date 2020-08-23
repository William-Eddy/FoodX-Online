Public Class IngredientDropDown

    Dim ingredients As Ingredients = New Ingredients
    Public Sub setContents()

        ingredients.addColumnsForReturn("ingredientID")
        ingredients.addColumnsForReturn("name")

        ingredients.executeSelect("tblIngredients")

    End Sub

    Function getValueMember()

        Return ingredients.table.Columns(0)

    End Function

    Function getDisplayMember()

        Return ingredients.table.Columns(1)

    End Function

    Function getDataSource()

        Return ingredients.table

    End Function

End Class
