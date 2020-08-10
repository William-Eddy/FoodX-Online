Public Class MealIngredients

    Inherits DatabaseTable

    Public Sub setContents()

        setTableContents("SELECT `mealID`, `ingredientID`, `quantity` FROM `tblMealIngredients`")

    End Sub

    Function getSelectedMealIngredients(mealID)

        Return getTableSelect("mealID", mealID)

    End Function


End Class
