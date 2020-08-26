Public Class MealsWithNutritionalInfo

    Inherits Meals

    Public calorieCount As Integer
    Public fatCount As Integer
    Public proteinCount As Integer
    Public carbCount As Integer
    Public Sub addNutritonalInfo(mealID)

        fatCount = fatCount + Int(getSingleSearchValue("mealID", mealID, "fat"))
        carbCount = carbCount + Int(getSingleSearchValue("mealID", mealID, "carbs"))
        proteinCount = proteinCount + Int(getSingleSearchValue("mealID", mealID, "protein"))
        calorieCount = calorieCount + Int(getSingleSearchValue("mealID", mealID, "calories"))

    End Sub

    Function getTotalCalories()

        Return calorieCount

    End Function

    Function getTotalFat()

        Return fatCount

    End Function

    Function getTotalCarbs()

        Return carbCount

    End Function

    Function getTotalProtein()

        Return proteinCount

    End Function

    Public Sub resetNutritionalCounts()

        calorieCount = 0
        fatCount = 0
        carbCount = 0
        proteinCount = 0

    End Sub

    Function getCategory()
        Return getCurrentRowValue("category")
    End Function
    Function getCalories()
        Return getCurrentRowValue("calories")
    End Function
    Function getCarbs()
        Return getCurrentRowValue("carbs")
    End Function
    Function getFat()
        Return getCurrentRowValue("fat")
    End Function
    Function getProtein()
        Return getCurrentRowValue("protein")
    End Function











End Class

