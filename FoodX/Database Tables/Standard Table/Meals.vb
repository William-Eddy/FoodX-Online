Public Class Meals
    Inherits DatabaseTable

    Public Sub setContents()

        setTableContents("SELECT `mealID`, `serves`, `stock` FROM `tblMeal`")

    End Sub

    Function getServing(mealID)

        Return Int(getSingleSearchValue("mealID", mealID, "serves"))

    End Function

    Function getStock(mealID)

        Return Int(getSingleSearchValue("mealID", mealID, "stock"))

    End Function


End Class
