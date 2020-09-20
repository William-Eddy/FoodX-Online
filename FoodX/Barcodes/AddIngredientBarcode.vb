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

        ingredientID = IngredientBarcodes.getCurrentIngredientID

        name = Ingredients.getIngredientName(ingredientID)

        insertArray = {ingredientID, name, IngredientBarcodes.getCurrentQuantity, FormatCurrency(IngredientBarcodes.getCurrentPrice)}

        Return insertArray

    End Function

    Function getPrice()

        Return IngredientBarcodes.getCurrentPrice

    End Function



End Class
