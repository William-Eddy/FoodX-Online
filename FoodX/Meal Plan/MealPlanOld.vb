Public Class MealPlanOld
    Inherits DatabaseTableOld

    Public Shared mealOptions As DatabaseTableOld
    Public calCount As Integer
    Public fatCount As Integer
    Public proCount As Integer
    Public carbCount As Integer

    Public Sub setMealPlanTableData()

        table = MainConnectionAccess.conndb.getSQLDataTable("SELECT `preWorkout`, `breakfast`, `lunch`, `dinner`, `snack`, `drink1`, `drink2` FROM `tblMealPlan`")
        setIndexToZero()

    End Sub

    Public Sub setMealTableData()

        mealOptions = New DatabaseTableOld
        mealOptions.setTableContents("SELECT `mealID`, `name`, `carbs`, `fat`, `protein`, `calories` FROM `tblMeal`")

    End Sub

    Function getMeal(day, meal)

        Dim mealID As String
        Dim mealRow As Integer
        Dim nutRow As DataRow

        mealID = getValue(day, meal)
        setIndexToZero()

        For Each row As DataRow In mealOptions.table.Rows

            If mealID = "0" Then

                Return ""

            ElseIf mealOptions.getValue(currentRowIndex, 0) = mealID Then

                mealRow = currentRowIndex

            End If

            addRowCount()
        Next

        nutRow = mealOptions.table.Rows(mealRow)
        fatCount = fatCount + Int(nutRow("fat"))
        carbCount = carbCount + Int(nutRow("carbs"))
        proCount = proCount + Int(nutRow("protein"))
        calCount = calCount + Int(nutRow("calories"))

        Return mealOptions.getValue(mealRow, 1)

    End Function

    Public Sub setMealsTable(category As String)

        setTableContents("SELECT `mealID`, `name`, `category` FROM `tblMeal` WHERE category = '" + category + "'")

    End Sub

    Function getTable()

        Return table

    End Function

    Function getTotalCalories()

        Return calCount

    End Function

    Function getTotalFat()

        Return fatCount

    End Function

    Function getTotalCarbs()

        Return carbCount

    End Function

    Function getTotalProtein()

        Return proCount

    End Function

    Public Sub resetNutritionalCounts()

        calCount = 0
        fatCount = 0
        carbCount = 0
        proCount = 0

    End Sub

    Public Sub setNutritionalInfo()





    End Sub

End Class
