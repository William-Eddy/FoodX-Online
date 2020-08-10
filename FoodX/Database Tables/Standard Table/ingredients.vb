Public Class ingredients

    Inherits DatabaseTable

    Public Sub setContents()

        setTableContents("SELECT `ingredientID`, `quantity` FROM `tblMealIngredients`")

    End Sub



End Class
