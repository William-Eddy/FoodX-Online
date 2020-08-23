Public Class AddEditMealIngredient

    Dim mealIngredientID As Integer

    Private Sub AddEditMealIngredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setIngredientDropdown()

        If mealIngredientID = 0 Then

            'something
        Else




        End If

    End Sub

    Public Sub New(ByVal mealIngredientIDToEdit As Integer)

        mealIngredientID = mealIngredientIDToEdit

    End Sub

    Private Sub setIngredientDropdown()

        Dim ingredientDropdown As IngredientDropDown = New IngredientDropDown

        ingredientDropdown.setContents()

        With cbxIngredientList

            .DataSource = ingredientDropdown.getDataSource
            .ValueMember = ingredientDropdown.getValueMember
            .DisplayMember = ingredientDropdown.getDisplayMember

        End With

    End Sub

End Class