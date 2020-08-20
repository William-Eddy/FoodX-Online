Public Class MealPlanManagement

    Public mealPlan As MealPlan = New MealPlan
    Public meals As NutritionalInfo = New NutritionalInfo
    Public mealOptions As Meals = meals

    Public day As Integer

    Function getMeal(day, meal)

        Dim mealID As String
        Dim name As String

        mealID = mealPlan.getMealID(day, meal)

        name = meals.getMealName(mealID)

        If Not (name = "") Then

            addNutritonalInfo(mealID, name)

        End If

        Return meals.getMealName(mealID)

    End Function

    Public Sub setMealsContent()

        meals.setContents()

    End Sub

    Public Sub setMealPlanContent()

        mealPlan.setContents()

    End Sub

    Public Sub resetNurtionalInfo()

        meals.resetNutritionalCounts()

    End Sub

    Public Sub setMealOptions(mealType)

        mealOptions.addConditions("category", mealType)
        mealOptions.executeSelect("tblMeal")

        Dim dr As DataRow = mealOptions.table.NewRow
        dr("mealID") = 0
        dr("name") = ""
        mealOptions.table.Rows.Add(dr)

    End Sub

    Function getMealOptionDataSource()

        Return mealOptions.table

    End Function

    Function getMealOptionValueMember()

        Return mealOptions.table.Columns(0).ToString

    End Function

    Function getMealOptionDisplayMember()

        Return mealOptions.table.Columns(1).ToString

    End Function

    Public Sub updateMealChoice(mealTime, mealID)

        mealPlan.addValues(mealTime, mealID)
        mealPlan.addConditions("dayID", day)
        mealPlan.executeUpdate("tblMealPlan")

    End Sub

    Public Sub addNutritonalInfo(mealID, mealName)

        If Not (mealName = "") Then
            meals.addNutritonalInfo(mealID)
        End If


    End Sub

    Public Sub setDay(selectedDay)

        day = selectedDay

    End Sub

End Class
