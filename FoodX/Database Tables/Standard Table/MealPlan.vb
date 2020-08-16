Public Class MealPlan

    Inherits DatabaseTable

    Public Sub setContents()

        setTableContents("SELECT `preWorkout`, `breakfast`, `lunch`, `dinner`, `snack`, `drink1`, `drink2` FROM `tblMealPlan`")

    End Sub



End Class
