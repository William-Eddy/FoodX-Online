Public Class Meals
    Inherits DatabaseTable

    Public Overloads Sub executeSelect()

        MyBase.executeSelect("tblMeal")

    End Sub

    Function getServing(mealID)

        Return Int(getSingleSearchValue("mealID", mealID, "serves"))

    End Function

    Function getStock(mealID)

        Return Int(getSingleSearchValue("mealID", mealID, "stock"))

    End Function

    Function getMealName(mealID)

        Dim mealName As String

        If mealID = 0 Then
            Return ""
        Else
            mealName = getSingleSearchValue("mealID", mealID, "name")
            Return mealName
        End If

    End Function

    Function getCurrentMealName()
        Return getCurrentRowValue("name")
    End Function
    Function getNumberOfServings()
        Return getCurrentRowValue("serves")
    End Function
    Function getStock()
        Return getCurrentRowValue("stock")
    End Function

End Class
