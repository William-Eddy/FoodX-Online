Public Class MealParts

    Inherits DatabaseTable

    Public Sub setPartsContentsForSpecificMealID(mealID)

        addConditions("mealID", mealID)
        executeSelect()

    End Sub
    Public Sub setPartsContentsForSpecificMealPartID(mealPartID)

        addConditions("mealPartID", mealPartID)
        executeSelect()

    End Sub

    Public Sub setContents()

        executeSelect()

    End Sub

    Public Overloads Sub executeUpdate()

        executeUpdate("tblMealParts")

    End Sub

    Public Overloads Sub executeInsert()

        executeInsert("tblMealParts")

    End Sub

    Private Overloads Sub executeSelect()

        executeSelect("tblMealParts")

    End Sub

    Function getCurrentMealPartID()

        Return getCurrentRowValue("mealPartID")

    End Function
    Function getCurrentMealID()

        Return getCurrentRowValue("mealID")

    End Function
    Function getCurrentPartName()

        Return getCurrentRowValue("name")

    End Function

    Function getCurrentPerContainer()

        Return getCurrentRowValue("perContainer")

    End Function
    Function getCurrentPerServing()

        Return getCurrentRowValue("perServing")

    End Function

    Function getCurrentTotalContainers()

        Return getCurrentRowValue("totalContainers")

    End Function

    Function getCurrentPortionsPerContainer()

        Return (getCurrentPerContainer() / getCurrentPerServing())

    End Function


End Class
