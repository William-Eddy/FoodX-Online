Public Class Meals
    Inherits DatabaseTable

    Public Sub setContents()

        setTableContents("SELECT `serves`, `stock` FROM `tblMeal`")

    End Sub

    Function getServing(mealID)

        Return Int(search("mealID", mealID, "serves"))

    End Function

    Function getStock(mealID)

        Return Int(search("mealID", mealID, "stock"))

    End Function


End Class
