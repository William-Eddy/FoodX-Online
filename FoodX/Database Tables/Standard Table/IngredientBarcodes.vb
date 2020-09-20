Public Class IngredientBarcodes
    Inherits DatabaseTable

    Dim tableName As String = "tblIngredientBarcodes"

    Public Overloads Sub executeInsert()

        executeInsert(tableName)

    End Sub

    Public Overloads Sub executeUpdate()

        executeUpdate(tableName)

    End Sub

    Public Overloads Sub executeSelect()

        executeSelect(tableName)

    End Sub
    Public Sub setContents(barcode)

        addColumnsForReturn("ingredientID")
        addColumnsForReturn("quantity")
        addColumnsForReturn("price")
        addConditions("barcode", barcode)
        executeSelect("tblIngredientBarcodes")

    End Sub

    Function getCurrentIngredientID()

        Return getCurrentRowValue("ingredientID")

    End Function

    Function getCurrentQuantity()

        Return getCurrentRowValue("quantity")

    End Function

    Function getCurrentPrice()

        Return getCurrentRowValue("price")

    End Function


End Class
