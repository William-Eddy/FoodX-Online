Public Class Meals
    Inherits DatabaseTable

    Public Sub setContents()

        MainConnectionAccess.conndb.addCriteria("mealID", 0)
        MainConnectionAccess.conndb.addCriteria("serves", 0)
        MainConnectionAccess.conndb.addCriteria("stock", 0)
        setTableContents(MainConnectionAccess.conndb.executeSelect("tblMeal"))

    End Sub

    Function getServing(mealID)

        Return Int(getSingleSearchValue("mealID", mealID, "serves"))

    End Function

    Function getStock(mealID)

        Return Int(getSingleSearchValue("mealID", mealID, "stock"))

    End Function

    Function getMealName(mealID)

        Dim mealName As String
        mealName = getSingleSearchValue("mealID", mealID, "name")
        Return mealName

    End Function





End Class
