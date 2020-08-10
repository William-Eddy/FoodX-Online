Public Class MealsRequired

    Inherits QuantityList

    Function getCurrentMealID()

        Return getCurrentRowValue(0)

    End Function

    Public Sub addMeal(mealID)

        addItem(mealID, 1)

    End Sub

    Public Sub setMealColumns()

        setColumns()

    End Sub

    Function getServingsRequired()

        Return getCurrentRowValue(1)

    End Function
End Class
