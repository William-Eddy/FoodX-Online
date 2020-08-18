Public Class ChangeMealPlan

    Public Shared day As Integer
    Dim mealPlanManagement As MealPlanManagement = New MealPlanManagement
    Private Sub ChangeMealPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        populateDropdownOptions()
        getCurrentMealPlan()
        setDayTitle()

    End Sub

    Public Sub New(ByVal dayID As String)

        InitializeComponent()
        day = dayID

    End Sub

    Public Sub getCurrentMealPlan()

        mealPlanManagement.setMealPlanContent()
        mealPlanManagement.setMealsContent()
        mealPlanManagement.resetNurtionalInfo()

        Me.PreWorkout.Text = mealPlanManagement.getMeal(day, 1)
        Me.Breakfast.Text = mealPlanManagement.getMeal(day, 1)
        Me.Lunch.Text = mealPlanManagement.getMeal(day, 2)
        Me.Dinner.Text = mealPlanManagement.getMeal(day, 3)
        Me.Snack.Text = mealPlanManagement.getMeal(day, 4)
        Me.MornDrink.Text = mealPlanManagement.getMeal(day, 5)
        Me.AfternoonDrink.Text = mealPlanManagement.getMeal(day, 6)

        Me.Calories.Text = "Calories: " + Str(mealPlanManagement.meals.getTotalCalories)
        Me.Fat.Text = "Fat: " + Str(mealPlanManagement.meals.getTotalFat) + "g"
        Me.Protein.Text = "Protein: " + Str(mealPlanManagement.meals.getTotalProtein) + "g"
        Me.Carbs.Text = "Carbs: " + Str(mealPlanManagement.meals.getTotalCarbs) + "g"

    End Sub

    Public Sub populateDropdownOptions()

        Dim mealOptions As Meals
        mealOptions = New Meals

        mealPlanManagement.setMealOptions("Pre-workout/Snack")

        With Me.PreWorkout
            .DataSource = mealPlanManagement.getMealOptionDataSource
            .ValueMember = mealPlanManagement.getMealOptionValueMember
            .DisplayMember = mealPlanManagement.getMealOptionDisplayMember
        End With

        With Me.Snack
            .DataSource = mealPlanManagement.getMealOptionDataSource
            .ValueMember = mealPlanManagement.getMealOptionValueMember
            .DisplayMember = mealPlanManagement.getMealOptionDisplayMember
        End With


        mealPlanManagement.setMealOptions("Breakfast")

        With Me.Breakfast
            .DataSource = mealPlanManagement.getMealOptionDataSource
            .ValueMember = mealPlanManagement.getMealOptionValueMember
            .DisplayMember = mealPlanManagement.getMealOptionDisplayMember
        End With


        mealPlanManagement.setMealOptions("Lunch/Dinner")

        With Me.Lunch
            .DataSource = mealPlanManagement.getMealOptionDataSource
            .ValueMember = mealPlanManagement.getMealOptionValueMember
            .DisplayMember = mealPlanManagement.getMealOptionDisplayMember
        End With

        With Me.Dinner
            .DataSource = mealPlanManagement.getMealOptionDataSource
            .ValueMember = mealPlanManagement.getMealOptionValueMember
            .DisplayMember = mealPlanManagement.getMealOptionDisplayMember
        End With


        mealPlanManagement.setMealOptions("Drink")

        With Me.MornDrink
            .DataSource = mealPlanManagement.getMealOptionDataSource
            .ValueMember = mealPlanManagement.getMealOptionValueMember
            .DisplayMember = mealPlanManagement.getMealOptionDisplayMember
        End With

        With Me.AfternoonDrink
            .DataSource = mealPlanManagement.getMealOptionDataSource
            .ValueMember = mealPlanManagement.getMealOptionValueMember
            .DisplayMember = mealPlanManagement.getMealOptionDisplayMember
        End With

    End Sub

    Private Sub setDayTitle()

        Dim days As String() = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}

        mainGroupBox.Text = days(day)

    End Sub

End Class