Public Class ChangeMealPlan

    Dim day As Integer
    Dim mealPlanManagement As MealPlanManagement = New MealPlanManagement
    Dim loaded As Boolean = False
    Private Sub ChangeMealPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        populateDropdownOptions()
        getCurrentMealPlan()
        setDayTitle()

        loaded = True

    End Sub

    Public Sub New(ByVal dayID As String)

        InitializeComponent()
        day = dayID

        mealPlanManagement.setDay(day)

    End Sub

    Public Sub getCurrentMealPlan()

        mealPlanManagement.setMealPlanContent()
        mealPlanManagement.setMealsContent()
        mealPlanManagement.resetNurtionalInfo()

        Me.PreWorkout.Text = mealPlanManagement.getMeal(day, 0)
        Me.Breakfast.Text = mealPlanManagement.getMeal(day, 1)
        Me.Lunch.Text = mealPlanManagement.getMeal(day, 2)
        Me.Dinner.Text = mealPlanManagement.getMeal(day, 3)
        Me.Snack.Text = mealPlanManagement.getMeal(day, 4)
        Me.MornDrink.Text = mealPlanManagement.getMeal(day, 5)
        Me.AfternoonDrink.Text = mealPlanManagement.getMeal(day, 6)

        getNutritionalInfoTotals()

    End Sub

    Private Sub getNutritionalInfoTotals()

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

        mealPlanManagement.setMealOptions("Pre-workout/Snack")

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

        mealPlanManagement.setMealOptions("Lunch/Dinner")

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

        mealPlanManagement.setMealOptions("Drink")

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

    Private Sub PreWorkout_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PreWorkout.SelectedIndexChanged
        If loaded = True Then
            updateMealChoice("PreWorkout", Me.PreWorkout.SelectedValue)
        End If
    End Sub

    Private Sub MornDrink_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MornDrink.SelectedIndexChanged
        If loaded = True Then
            updateMealChoice("drink1", Me.MornDrink.SelectedValue)
        End If
    End Sub

    Private Sub Breakfast_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Breakfast.SelectedIndexChanged
        If loaded = True Then
            updateMealChoice("breakfast", Me.Breakfast.SelectedValue)
        End If
    End Sub

    Private Sub Lunch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lunch.SelectedIndexChanged
        If loaded = True Then
            updateMealChoice("lunch", Me.Lunch.SelectedValue)
        End If
    End Sub

    Private Sub AfternoonDrink_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AfternoonDrink.SelectedIndexChanged
        If loaded = True Then
            updateMealChoice("drink2", Me.AfternoonDrink.SelectedValue)
        End If
    End Sub

    Private Sub Snack_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Snack.SelectedIndexChanged
        If loaded = True Then
            updateMealChoice("snack", Me.Snack.SelectedValue)
        End If
    End Sub

    Private Sub Dinner_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dinner.SelectedIndexChanged
        If loaded = True Then
            updateMealChoice("dinner", Me.Dinner.SelectedValue)
        End If
    End Sub


    Private Sub updateMealChoice(mealTime, mealID)

        mealPlanManagement.updateMealChoice(mealTime, mealID)

        mealPlanManagement.resetNurtionalInfo()

        mealPlanManagement.addNutritonalInfo(Me.PreWorkout.SelectedValue, Me.PreWorkout.Text)
        mealPlanManagement.addNutritonalInfo(Me.MornDrink.SelectedValue, Me.MornDrink.Text)
        mealPlanManagement.addNutritonalInfo(Me.Breakfast.SelectedValue, Me.Breakfast.Text)
        mealPlanManagement.addNutritonalInfo(Me.Lunch.SelectedValue, Me.Lunch.Text)
        mealPlanManagement.addNutritonalInfo(Me.AfternoonDrink.SelectedValue, Me.AfternoonDrink.Text)
        mealPlanManagement.addNutritonalInfo(Me.Snack.SelectedValue, Me.Snack.Text)
        mealPlanManagement.addNutritonalInfo(Me.Dinner.SelectedValue, Me.Dinner.Text)

        getNutritionalInfoTotals()

    End Sub

    Private Sub butPreWorkoutMealOut_Click(sender As Object, e As EventArgs) Handles butPreWorkoutMealOut.Click

        mealPlanManagement.decreaseMealStock(Me.PreWorkout.SelectedValue)
        Me.butPreWorkoutMealOut.Enabled = False

    End Sub

    Private Sub butMornDrinkMealOut_Click(sender As Object, e As EventArgs) Handles butMornDrinkMealOut.Click

        mealPlanManagement.decreaseMealStock(Me.MornDrink.SelectedValue)
        Me.butMornDrinkMealOut.Enabled = False

    End Sub

    Private Sub butBreakfastMealOut_Click(sender As Object, e As EventArgs) Handles butBreakfastMealOut.Click

        mealPlanManagement.decreaseMealStock(Me.Breakfast.SelectedValue)
        Me.butBreakfastMealOut.Enabled = False

    End Sub

    Private Sub butLunchMealOut_Click(sender As Object, e As EventArgs) Handles butLunchMealOut.Click

        mealPlanManagement.decreaseMealStock(Me.Lunch.SelectedValue)
        Me.butLunchMealOut.Enabled = False

    End Sub

    Private Sub butAfternoonDrinkMealOut_Click(sender As Object, e As EventArgs) Handles butAfternoonDrinkMealOut.Click

        mealPlanManagement.decreaseMealStock(Me.AfternoonDrink.SelectedValue)
        Me.butAfternoonDrinkMealOut.Enabled = False

    End Sub

    Private Sub butSnackMealOut_Click(sender As Object, e As EventArgs) Handles butSnackMealOut.Click

        mealPlanManagement.decreaseMealStock(Me.Snack.SelectedValue)
        Me.butSnackMealOut.Enabled = False

    End Sub

    Private Sub butDinnerMealOut_Click(sender As Object, e As EventArgs) Handles butDinnerMealOut.Click

        mealPlanManagement.decreaseMealStock(Me.Dinner.SelectedValue)
        Me.butDinnerMealOut.Enabled = False

    End Sub
End Class