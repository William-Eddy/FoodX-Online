Public Class NutritionCalculation

    Inherits BodyMeasurements

    Dim calorieGoal As Integer
    Dim fatGoal As Integer
    Dim proteinGoal As Integer
    Dim carbsGoal As Integer

    Public Sub New()

        calculateGoals()

    End Sub

    Private Sub setLatestMeasurementData()

        setContents()

        Dim mostRecentMeasurementID As Integer = 0
        Dim currentMeasurementID As Integer

        setRowColumnIndexToZero()

        For Each row In table.Rows

            currentMeasurementID = Int(getCurrentMeasurementID())

            If currentMeasurementID > mostRecentMeasurementID Then
                mostRecentMeasurementID = currentMeasurementID
            End If

            increaseRowCount()
        Next

        setContentsForMeasurementID(Str(mostRecentMeasurementID))
        setRowColumnIndexToZero()

    End Sub

    Private Sub calculateGoals()

        setLatestMeasurementData()

        Dim weightInPounds As Integer = Int(getCurrentWeight()) * 2.205
        Dim heightInInches As Integer = (Int(My.Settings.heightFeet) * 12) + Int(My.Settings.heightInches)
        Dim age As Integer = Int(My.Settings.age)

        Dim activityLevel As Double = 1.55
        Dim percentageForWeightGain As Double = 1.25

        Dim bmr As Integer
        Dim tdee As Integer

        bmr = 655 + (4.35 * weightInPounds) + (4.7 * heightInInches) - (4.7 * age)
        tdee = bmr * activityLevel

        calorieGoal = (tdee) * percentageForWeightGain


        proteinGoal = (tdee * 0.3) / 4
        carbsGoal = (tdee * 0.35) / 4
        fatGoal = (tdee * 0.35) / 9

    End Sub


    Function getCalorieGoal()

        Return calorieGoal

    End Function
    Function getProteinGoal()

        Return proteinGoal

    End Function
    Function getFatGoal()

        Return fatGoal

    End Function
    Function getCarbsGoal()

        Return carbsGoal

    End Function

End Class
