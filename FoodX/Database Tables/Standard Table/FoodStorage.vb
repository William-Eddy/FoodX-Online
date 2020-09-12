Public Class FoodStorage
    Inherits DatabaseTable

    Dim tableName As String = "tblFoodStorage"

    Public Overloads Sub executeSelect()

        executeSelect(tableName)

    End Sub

    Function getFreezerCapacity()

        setContents()
        Return getCurrentRowValue("freezerCapacity")

    End Function
    Function getFreezerCurrentStock()

        setContents()
        Return getCurrentRowValue("freezerCurrentStock")

    End Function

    Private Sub setContents()

        executeSelect()

    End Sub

End Class
