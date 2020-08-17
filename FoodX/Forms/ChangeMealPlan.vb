Public Class ChangeMealPlan

    Public Shared day As Integer
    Dim mealPlanManagement As MealPlanManagement = New MealPlanManagement
    Private Sub ChangeMealPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'populateDropdownOptions()
        getCurrentMealPlan()

    End Sub

    Public Sub New(ByVal dayID As String)

        InitializeComponent()

        day = dayID

    End Sub

    Public Sub getCurrentMealPlan()

        Dim day As Integer

        day = 0

        mealPlanManagement.setMealPlanContent()
        mealPlanManagement.setMealsContent()
        mealPlanManagement.resetNurtionalInfo()

        Me.monPreWorkout.Text = mealPlanManagement.getMeal(day, 1)
        Me.monBreakfast.Text = mealPlanManagement.getMeal(day, 1)
        Me.monLunch.Text = mealPlanManagement.getMeal(day, 2)
        Me.monDinner.Text = mealPlanManagement.getMeal(day, 3)
        Me.monSnack.Text = mealPlanManagement.getMeal(day, 4)
        Me.monMornDrink.Text = mealPlanManagement.getMeal(day, 5)
        Me.monAfternoonDrink.Text = mealPlanManagement.getMeal(day, 6)

        Me.MonCalories.Text = "Calories: " + Str(mealPlanManagement.meals.getTotalCalories)
        Me.monFat.Text = "Fat: " + Str(mealPlanManagement.meals.getTotalFat) + "g"
        Me.monProtein.Text = "Protein: " + Str(mealPlanManagement.meals.getTotalProtein) + "g"
        Me.monCarbs.Text = "Carbs: " + Str(mealPlanManagement.meals.getTotalCarbs) + "g"

    End Sub


    Public Sub populateDropdownOptions()

        Dim mealOptions As MealPlanOld
        mealOptions = New MealPlanOld

        mealOptions.setMealsTable("Pre-workout/Snack")

        With Me.monPreWorkout
            .DataSource = mealOptions.getTable
            .ValueMember = mealOptions.getTable.Columns(0).ToString
            .DisplayMember = mealOptions.getTable.Columns(1).ToString
        End With

        mealOptions.setMealsTable("Pre-workout/Snack")

        With Me.monSnack
            .DataSource = mealOptions.getTable
            .ValueMember = mealOptions.getTable.Columns(0).ToString
            .DisplayMember = mealOptions.getTable.Columns(1).ToString
        End With


        mealOptions.setMealsTable("Breakfast")

        With Me.monBreakfast
            .DataSource = mealOptions.getTable
            .ValueMember = mealOptions.getTable.Columns(0).ToString
            .DisplayMember = mealOptions.getTable.Columns(1).ToString
        End With


        mealOptions.setMealsTable("Lunch/Dinner")

        With Me.monLunch
            .DataSource = mealOptions.getTable
            .ValueMember = mealOptions.getTable.Columns(0).ToString
            .DisplayMember = mealOptions.getTable.Columns(1).ToString
        End With

        mealOptions.setMealsTable("Lunch/Dinner")

        With Me.monDinner
            .DataSource = mealOptions.getTable
            .ValueMember = mealOptions.getTable.Columns(0).ToString
            .DisplayMember = mealOptions.getTable.Columns(1).ToString
        End With


        mealOptions.setMealsTable("Drink")

        With Me.monMornDrink
            .DataSource = mealOptions.getTable
            .ValueMember = mealOptions.getTable.Columns(0).ToString
            .DisplayMember = mealOptions.getTable.Columns(1).ToString
        End With

        mealOptions.setMealsTable("Drink")

        With Me.monAfternoonDrink
            .DataSource = mealOptions.getTable
            .ValueMember = mealOptions.getTable.Columns(0).ToString
            .DisplayMember = mealOptions.getTable.Columns(1).ToString
        End With

    End Sub

End Class