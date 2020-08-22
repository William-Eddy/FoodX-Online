Public Class EditMeal

    Dim mealID As String
    Dim editMealManagement As EditMealManagement

    Public Sub New(ByVal mealIDToEdit As String)

        InitializeComponent()

        mealID = mealIDToEdit

        editMealManagement = New EditMealManagement(mealID)

    End Sub

    Private Sub EditMeal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getCurrentMealData()

    End Sub
    Private Sub getCurrentMealData()

        editMealManagement.setContentsForSelectedMeal()

        Me.txtName.Text = editMealManagement.getMealName()


    End Sub
End Class