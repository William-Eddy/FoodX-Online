Public Class IngredientBarcodes
    Inherits DatabaseTable

    Public Sub setContents(barcode)

        addColumnsForReturn("ingredientID")
        addColumnsForReturn("quantity")
        addColumnsForReturn("price")
        addConditions("barcode", barcode)
        executeSelect("tblIngredientBarcodes")

    End Sub

    Function getIngredientID()

        Return table.Rows(0).Item(0).ToString()

    End Function

    Function getQuantity()

        Return table.Rows(0).Item(1).ToString()

    End Function

    Function getPrice()

        Return table.Rows(0).Item(2).ToString()

    End Function


End Class
