Public Class AddIngredientBarcode

    Dim IngredientBarcodes As IngredientBarcodes = New IngredientBarcodes
    Dim Ingredients As Ingredients = New Ingredients

    Function getIngredientName(ingredientID)

        Ingredients.addColumnsForReturn("name")
        Ingredients.addConditions("ingredientID", ingredientID)
        Ingredients.executeSelect("tblIngredients")

        Return Ingredients.getIngredientName(ingredientID)

    End Function

    Function getBarcodeDataArray(barcode)

        Dim insertArray As String()
        Dim name As String
        Dim ingredientID As String

        IngredientBarcodes.setContents(barcode)

        Ingredients.setContents()

        ingredientID = IngredientBarcodes.getIngredientID

        name = Ingredients.getIngredientName(ingredientID)

        insertArray = {ingredientID, name, IngredientBarcodes.getQuantity, FormatCurrency(IngredientBarcodes.getPrice)}

        Return insertArray

    End Function

    Function addNewBarcode()



    End Function


End Class
