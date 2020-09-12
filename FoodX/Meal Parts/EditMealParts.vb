Public Class EditMealParts

    Dim editMeal As EditMeal
    Dim mealParts As MealParts = New MealParts
    Dim mealPartID As String
    Dim mealID As String

    Public Sub New(editMeal, mealID, Optional mealPartID = Nothing)

        InitializeComponent()

        Me.mealPartID = mealPartID
        Me.editMeal = editMeal
        Me.mealID = mealID

    End Sub

    Private Sub EditMealParts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not (mealPartID = Nothing) Then

            setExisitngValues()
            butDelete.Visible = True

        End If

    End Sub

    Private Sub setExisitngValues()

        mealParts.setPartsContentsForSpecificMealPartID(mealPartID)

        Me.txtName.Text = mealParts.getCurrentPartName
        Me.txtPerContainer.Text = mealParts.getCurrentPerContainer
        Me.txtPerServing.Text = mealParts.getCurrentPerServing

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        If mealPartID = Nothing Then

            addPart()

        Else

            updatePart()

        End If

    End Sub

    Private Sub updatePart()

        setValues()
        mealParts.addConditions("mealPartID", mealPartID)
        mealParts.executeUpdate()
        closeAndUpdate()

    End Sub

    Private Sub addPart()

        setValues()
        mealParts.addValues("mealID", mealID)
        mealParts.executeInsert()
        closeAndUpdate()

    End Sub

    Private Sub setValues()

        mealParts.addValues("name", Me.txtName.Text)
        mealParts.addValues("perContainer", Me.txtPerContainer.Text)
        mealParts.addValues("perServing", Me.txtPerServing.Text)

    End Sub

    Private Sub closeAndUpdate()

        editMeal.setMealPartsView()
        Me.Close()

    End Sub

    Private Sub butDelete_Click(sender As Object, e As EventArgs) Handles butDelete.Click

        Dim message As MsgBoxResult = MsgBox("Are you sure you want to delete this part?", vbYesNo, "Delete")

        If message = vbYes Then

            mealParts.addConditions("mealPartID", mealPartID)
            mealParts.executeDelete()

            closeAndUpdate()

        End If

    End Sub
End Class