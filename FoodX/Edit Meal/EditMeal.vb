Public Class EditMeal

    Dim mealID As String
    Dim editMealManagement As EditMealManagement

    Public Sub New(ByVal mealIDToEdit As String)

        InitializeComponent()

        mealID = mealIDToEdit

        editMealManagement = New EditMealManagement(mealID)

    End Sub

    Private Sub EditMeal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setCurrentMealData()

    End Sub

    Private Sub setIngredientsView()

        lbIngredients.DisplayMember = "id"
        lbIngredients.ValueMember = "Ingredient"
        lbIngredients.DataSource = editMealManagement.getMealIngredientsTable

    End Sub
    Private Sub setCurrentMealData()

        editMealManagement.setContentsForSelectedMeal()

        setCurrentMealDetails()
        setCurrentNutritionalData()
        setIngredientsView()

    End Sub
    Private Sub setCurrentMealDetails()

        Me.txtName.Text = editMealManagement.getMealName()
        Me.txtServes.Text = editMealManagement.getNumberOfServings()
        Me.txtStock.Text = editMealManagement.getStock()
        Me.cboCategory.Text = editMealManagement.getCategory()

    End Sub

    Private Sub setCurrentNutritionalData()

        Me.txtCalories.Text = editMealManagement.getCalories()
        Me.txtCarbs.Text = editMealManagement.getCarbs()
        Me.txtFat.Text = editMealManagement.getFat()
        Me.txtProtein.Text = editMealManagement.getProtein()

    End Sub

    Private Sub setIngredientsListViewFormat()


    End Sub

End Class