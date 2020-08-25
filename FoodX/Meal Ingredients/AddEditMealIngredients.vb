Public Class AddEditMealIngredients

    Dim mealIngredientID As Integer

    Public Sub New(ByVal mealIngredientIDToEdit As Integer)

        InitializeComponent()

        mealIngredientID = mealIngredientIDToEdit

    End Sub

    Private Sub AddEditMealIngredients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setIngredientDropdown()

        If mealIngredientID = 0 Then

            'something
        Else

            Me.cmbIngredients.SelectedValue = mealIngredientID

        End If

    End Sub

    Private Sub setIngredientDropdown()

        Dim ingredientDropdown As IngredientDropDown = New IngredientDropDown

        ingredientDropdown.setContents()

        With cmbIngredients

            .DataSource = ingredientDropdown.getDataSource
            .ValueMember = ingredientDropdown.getValueMember
            .DisplayMember = ingredientDropdown.getDisplayMember

        End With

    End Sub



End Class