Public Class NutritionCalculation

    Inherits BodyMeasurements

    Public Sub New()

        refreshGoals()

    End Sub

    Private Sub refreshGoals()

        setContents()

        Dim mostRecentMeasurementID As Integer = 0
        Dim currentMeasurementID As Integer

        For Each row In table.Rows

            currentMeasurementID = Int(getCurrentMeasurementID())

            If currentMeasurementID > mostRecentMeasurementID Then
                mostRecentMeasurementID = currentMeasurementID
            End If

            increaseRowCount()
        Next

        setContentsForMeasurementID(Str(mostRecentMeasurementID))

    End Sub

    Function getCalorieGoal()



    End Function


End Class
