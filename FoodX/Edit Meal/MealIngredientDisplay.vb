Public Class MealIngredientDisplay

    Public mealID As Integer
    Public mealIngredients As MealIngredients = New MealIngredients
    Public ingredients As Ingredients = New Ingredients

    Public Sub New(ByVal mealIDToEdit As Integer)

        mealID = mealIDToEdit

    End Sub

    Public Sub setTableContents()

        mealIngredients.addColumnsForReturn("ingredientID")
        mealIngredients.addColumnsForReturn("quantity")
        mealIngredients.addConditions("mealID", mealID)
        mealIngredients.executeSelect("tblMealIngredients")

        ingredients.setContents()

    End Sub

    Function getMealIngredientRows()

        Return mealIngredients.table.Rows

    End Function

    Function getIngredientID()

        Return mealIngredients.getCurrentRowValue(0)

    End Function

    Function getIngredientQuantity()

        Return mealIngredients.getCurrentRowValue(1)

    End Function
    Function getIngredientName(ingredientID)

        Return ingredients.getIngredientName(ingredientID)

    End Function

    Function getIngredientUnit(ingredientID)

        Dim unit As String

        unit = ingredients.getUnit(ingredientID)

        If unit = "Unit" Then
            Return ""
        Else
            Return unit
        End If

    End Function


End Class
