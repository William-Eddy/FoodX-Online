Public Class ShoppingListDisplay
    Public list As ListView

    Public Sub addColumnFormatting()

        list = New ListView

        With list
            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("Ingredient", 200)
            .Columns.Add("Quantity", 80)
        End With

    End Sub


    Public Sub addToShoppingList(name, insertArray)


        list.Items.Add(name).SubItems.AddRange(insertArray)

    End Sub



End Class
