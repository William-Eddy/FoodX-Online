Public Class ChangeMealPlan

    Public Shared day As Integer
    Private Sub ChangeMealPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Public Sub New(ByVal dayID As String)

        InitializeComponent()

        day = dayID

    End Sub


End Class