Public Class EditMeal

    Dim mealID As String
    Dim ingredientDisplay As MealIngredientDisplay

    Public meals As MealsWithNutritionalInfo = New MealsWithNutritionalInfo
    Public mealIngredients As MealIngredients = New MealIngredients
    Public ingredients As Ingredients = New Ingredients
    Public mealParts As MealParts = New MealParts
    Dim methods As Methods = New Methods

    Dim mainMenuForm As Main_Menu
    Dim editMealPartsForm As EditMealParts

    Dim saved As Boolean = False

    Public Sub New(mealIDToEdit, mainMenu)

        InitializeComponent()
        mealID = mealIDToEdit

        mainMenu.GetType()

        mainMenuForm = mainMenu

    End Sub

    Private Sub EditMeal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setCategoryOptions()

        If Not (mealID = 0) Then

            setCurrentMealData()

        End If

    End Sub

    Public Sub setContentsForSelectedMeal()

        meals.addConditions("mealID", mealID)
        meals.executeSelect("tblMeal")

    End Sub

    Public Sub setMethodStepsContent()

        methods.addConditions("mealID", mealID)
        methods.executeSelect()

    End Sub

    Public Sub setIngredientsView()

        lvIngredients.Clear()

        ingredientDisplay = New MealIngredientDisplay(mealID)

        Dim ingredientID As String
        Dim mealIngredientID As String
        Dim name As String
        Dim quantity As String

        Dim insertArray As String()

        setIngredientsListViewFormat()

        ingredientDisplay.setTableContents()

        For Each row As DataRow In ingredientDisplay.getMealIngredientRows()

            ingredientID = ingredientDisplay.getIngredientID
            mealIngredientID = ingredientDisplay.getMealIngredientID
            name = ingredientDisplay.getIngredientName(ingredientID)
            quantity = ingredientDisplay.getIngredientQuantity + ingredientDisplay.getIngredientUnit(ingredientID)

            insertArray = {name, quantity}
            Me.lvIngredients.Items.Add(mealIngredientID).SubItems.AddRange(insertArray)

            ingredientDisplay.mealIngredients.increaseRowCount()

        Next

    End Sub

    Public Sub setMethodStepsView()

        lvMethodSteps.Clear()
        Dim insertArray As String()

        setMethodStepsContent()
        setMethodStepsFormat()

        For Each row As DataRow In methods.table.Rows

            insertArray = {methods.getCurrentOrderID, methods.getCurrentInstruction}
            Me.lvMethodSteps.Items.Add(methods.getCurrentStepID).SubItems.AddRange(insertArray)

            methods.increaseRowCount()

        Next

        methods.setRowColumnIndexToZero()

    End Sub

    Public Sub setMealPartsView()

        lvMealParts.Clear()
        setMealPartsListViewFormat()

        Dim insertArray As String()

        mealParts.setPartsContentsForSpecificMeal(mealID)

        For Each row As DataRow In mealParts.table.Rows

            insertArray = {mealParts.getCurrentPartName, mealParts.getCurrentPerContainer, mealParts.getCurrentTotalContainers}
            Me.lvMealParts.Items.Add(mealParts.getCurrentMealPartID).SubItems.AddRange(insertArray)

            mealParts.increaseRowCount()

        Next

        mealParts.setRowColumnIndexToZero()

    End Sub
    Private Sub setCurrentMealData()

        setContentsForSelectedMeal()

        setCurrentMealDetails()
        setCurrentNutritionalData()
        setIngredientsView()

        setMethodStepsView()
        setMealPartsView()

    End Sub

    Private Sub setCategoryOptions()

        cmbCategory.DataSource = {"Pre-workout/Snack", "Breakfast", "Lunch/Dinner", "Drink"}

    End Sub

    Private Sub setCurrentMealDetails()

        Me.txtName.Text = meals.getCurrentMealName()
        Me.txtServes.Text = meals.getNumberOfServings()
        Me.txtStock.Text = meals.getStock()
        Me.cmbCategory.Text = meals.getCategory()

    End Sub

    Private Sub setCurrentNutritionalData()

        Me.txtCalories.Text = meals.getCalories()
        Me.txtCarbs.Text = meals.getCarbs()
        Me.txtFat.Text = meals.getFat()
        Me.txtProtein.Text = meals.getProtein()

    End Sub

    Private Sub setIngredientsListViewFormat()

        With Me.lvIngredients

            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("mealIngredientID", 0)
            .Columns.Add("Ingredient", 180)
            .Columns.Add("Quantity")
            .GridLines = True

        End With

    End Sub

    Private Sub setMethodStepsFormat()

        With Me.lvMethodSteps

            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("stepID", 0)
            .Columns.Add("Step No.", 65)
            .Columns.Add("Instruction", 500)
            .GridLines = True

        End With

    End Sub
    Private Sub setMealPartsListViewFormat()

        With Me.lvMealParts

            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("mealPartID", 0)
            .Columns.Add("Part", 160)
            .Columns.Add("Per Container", 70)
            .Columns.Add("Total Containers")
            .GridLines = True

        End With

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        Dim editMealIngredientForm As AddEditMealIngredients = New AddEditMealIngredients(0, mealID, Me)

        editMealIngredientForm.Show()

    End Sub

    Private Sub lvIngredients_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvIngredients.DoubleClick

        Dim editIngredientForm As AddEditMealIngredients = New AddEditMealIngredients(Me.lvIngredients.FocusedItem.Text, mealID, Me)
        editIngredientForm.Show()

    End Sub

    Private Sub butSaveAndClose_click(sender As Object, e As EventArgs) Handles butSaveAndClose.Click

        If mealID = 0 Then

            addNewMeal()
        Else
            updateMeal()

        End If

        saved = True

        updateMealListviews()
        Me.Close()

    End Sub

    Private Sub EditMeal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If saved = False Then

            If (MessageBox.Show("Are you sure you want to exit without saving? Any changes will be lost.", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
                e.Cancel = True
            Else
                updateMealListviews()
            End If

        End If

    End Sub

    Private Sub addNewMeal()

        addUpdateInsertValues()
        meals.executeInsert("tblMeal")

    End Sub

    Private Sub updateMeal()

        addUpdateInsertValues()
        meals.addConditions("mealID", mealID)
        meals.executeUpdate("tblMeal")

    End Sub

    Private Sub addUpdateInsertValues()

        meals.addValues("name", Me.txtName.Text)
        meals.addValues("serves", Me.txtServes.Text)
        meals.addValues("stock", Me.txtStock.Text)
        meals.addValues("category", Me.cmbCategory.Text)

        meals.addValues("calories", Me.txtCalories.Text)
        meals.addValues("carbs", Me.txtCarbs.Text)
        meals.addValues("fat", Me.txtFat.Text)
        meals.addValues("Protein", Me.txtProtein.Text)

    End Sub

    Private Sub updateMealListviews()

        mainMenuForm.populateMealListviews()

    End Sub

    Private Sub butDelete_Click(sender As Object, e As EventArgs) Handles butDelete.Click

        If (MessageBox.Show("Are you sure you want to delete this meal?", "Delete meal", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then

            meals.addConditions("mealID", mealID)
            mealIngredients.executeDelete("tblMeal")

            updateMealListviews()
            saved = True
            Me.Close()
        End If


    End Sub

    Private Sub lvMethodSteps_DoubleClick(sender As Object, e As EventArgs) Handles lvMethodSteps.DoubleClick

        Dim editStep As EditMethodSteps

        Dim stepID As String = Me.lvMethodSteps.FocusedItem.Text

        editStep = New EditMethodSteps(Me, mealID, stepID)

        editStep.Show()

    End Sub

    Private Sub butAddStep_Click(sender As Object, e As EventArgs) Handles butAddStep.Click

        Dim editStep As EditMethodSteps = New EditMethodSteps(Me, mealID)
        editStep.Show()

    End Sub

    Private Sub butEmailMethod_Click(sender As Object, e As EventArgs) Handles butEmailMethod.Click

        Dim methodEmail As MethodEmail = New MethodEmail(mealID)
        methodEmail.sendMethodEmail()

    End Sub

    Private Sub lvMealParts_DoubleClick(sender As Object, e As EventArgs) Handles lvMealParts.DoubleClick

        editMealPartsForm = New EditMealParts(Me, mealID, lvMealParts.FocusedItem.Text)
        editMealPartsForm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        editMealPartsForm = New EditMealParts(Me, mealID)
        editMealPartsForm.Show()

    End Sub
End Class