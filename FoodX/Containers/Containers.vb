Public Class Containers

    Dim mealParts As MealParts = New MealParts
    Dim meals As Meals = New Meals

    Dim totalNumberOfContainers As Integer
    Function getTotalNumberOfContainersInUse()

        mealParts.setContents()
        setMealsContents()

        Return getContainersInUse()

    End Function

    Function getContainersInUse()

        mealParts.setRowColumnIndexToZero()

        Dim mealID As String
        Dim mealStock As Integer

        For Each row In mealParts.table.Rows

            mealID = mealParts.getCurrentMealID
            mealStock = meals.getSingleSearchValue("mealID", mealID, "stock")

            addContainersToTotal(mealStock)

            mealParts.increaseRowCount()
        Next

        Return Me.totalNumberOfContainers

    End Function

    Function getNumberOfContainersForMeal(mealID)

        Dim serves As Integer

        initialiseContainerCalculations()

        mealParts.setPartsContentsForSpecificMealID(mealID)
        setMealsContents()

        For Each row In mealParts.table.Rows

            serves = meals.getSingleSearchValue("mealID", mealID, "serves")

            addContainersToTotal(serves)

            mealParts.increaseRowCount()
        Next

        Return totalNumberOfContainers

    End Function

    Private Sub initialiseContainerCalculations()

        mealParts.setRowColumnIndexToZero()
        totalNumberOfContainers = 0

    End Sub

    Public Sub setMealsContents()

        meals.addColumnsForReturn("stock")
        meals.addColumnsForReturn("serves")
        meals.addColumnsForReturn("mealID")
        meals.executeSelect()

    End Sub

    Private Sub addContainersToTotal(mealStock)

        Dim portionsPerContainer As Integer = mealParts.getCurrentPortionsPerContainer
        Dim subTotalOfContainers As Integer = Math.Ceiling(mealStock / portionsPerContainer)

        Me.totalNumberOfContainers += subTotalOfContainers

    End Sub


End Class
