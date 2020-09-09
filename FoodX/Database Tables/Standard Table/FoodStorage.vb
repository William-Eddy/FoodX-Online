Public Class FoodStorage
    Inherits DatabaseTable

    Dim tableName As String = "tblFoodStorage"

    Public Overloads Sub executeUpdate()

        executeUpdate(tableName)

    End Sub




End Class
