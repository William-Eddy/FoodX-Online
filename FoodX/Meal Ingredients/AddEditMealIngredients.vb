Public Class AddEditMealIngredients

    Dim mealIngredients As MealIngredients = New MealIngredients
    Dim ingredients As Ingredients = New Ingredients

    Dim mealIngredientID As String
    Dim mealID As String
    Dim ingredientID As String

    Public Sub New(ByVal mealIngredientIDToEdit As Integer, ByVal relatedMealID As Integer)

        InitializeComponent()

        mealIngredientID = mealIngredientIDToEdit
        mealID = relatedMealID

        setMealIngredientsContents()
        setIngredientsContents()

    End Sub

    Private Sub AddEditMealIngredients_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        setIngredientDropdown()

        If Not (mealIngredientID = 0) Then

            ingredientID = mealIngredients.getCurrentIngredientID

            setCurrentIngredientID()
            setCurrentQuantity()
            setUnit()

        Else

            Me.cmbIngredients.Text = ""

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

    Private Sub setCurrentQuantity()

        Me.txtQuantity.Text = mealIngredients.getCurrentQuantity

    End Sub

    Private Sub setCurrentIngredientID()

        Me.cmbIngredients.SelectedValue = ingredientID

    End Sub
    Private Sub setUnit()

        Me.lblUnit.Text = getUnit()

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        Me.cmbIngredients.Select()
        Me.txtQuantity.Select()

        If mealIngredientID = 0 Then

            addNewMealIngredient()

        Else

            updateMealIngredient()

        End If

        Me.Close()

    End Sub

    Public Sub setMealIngredientsContents()

        mealIngredients.addColumnsForReturn("quantity")
        mealIngredients.addColumnsForReturn("ingredientID")
        mealIngredients.addColumnsForReturn("mealID")
        mealIngredients.addConditions("mealIngredientsID", mealIngredientID)
        mealIngredients.executeSelect("tblMealIngredients")

    End Sub

    Public Sub setIngredientsContents()

        ingredients.setContents()

    End Sub

    Function getUnit()

        Return ingredients.getUnit(ingredientID)

    End Function

    Private Sub updateMealIngredient()

        mealIngredients.addValues("ingredientID", Me.cmbIngredients.SelectedValue)
        mealIngredients.addValues("quantity", Me.txtQuantity.Text)
        mealIngredients.addConditions("mealIngredientsID", mealIngredientID)
        mealIngredients.executeUpdate("tblMealIngredients")

    End Sub


    Private Sub addNewMealIngredient()

        mealIngredients.addValues("ingredientID", Me.cmbIngredients.SelectedValue)
        mealIngredients.addValues("quantity", Me.txtQuantity.Text)
        mealIngredients.addValues("mealID", mealID)
        mealIngredients.executeInsert("tblMealIngredients")

    End Sub


End Class