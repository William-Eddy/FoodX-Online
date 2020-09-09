Public Class EditIngredient

    Dim stockForm As Stock
    Dim ingredients As Ingredients = New Ingredients
    Dim ingredientID As String
    Public Sub New(stockForm As Stock, Optional ingredientID As String = Nothing)

        InitializeComponent()

        Me.stockForm = stockForm
        Me.ingredientID = ingredientID

    End Sub

    Private Sub EditIngredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not (ingredientID = Nothing) Then

            setCurrentIngredientData()
            butDelete.Visible = True

        Else
            butDelete.Visible = False

        End If

    End Sub

    Private Sub setCurrentIngredientData()

        setIngredientTablecontent()

        Me.txtIngredient.Text = ingredients.getCurrentIngredientName()
        Me.txtQuantity.Text = ingredients.getCurrentQuantity()
        Me.txtPrice.Text = ingredients.getCurrentPrice()
        Me.cmoUnit.Text = ingredients.getCurrentUnit()

    End Sub

    Private Sub setIngredientTablecontent()

        ingredients.addConditions("ingredientID", ingredientID)
        ingredients.executeSelect()

    End Sub

    Private Sub updateIngredient()

        ingredients.addConditions("ingredientID", ingredientID)
        ingredients.executeUpdate()

    End Sub

    Private Sub addIngredient()

        ingredients.executeInsert()

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        addInsertAndUpdateValues()

        If Not (ingredientID = Nothing) Then

            updateIngredient()
        Else
            addIngredient()
        End If

        closeAndUpdate()

    End Sub
    Private Sub addInsertAndUpdateValues()

        ingredients.addValues("name", Me.txtIngredient.Text)
        ingredients.addValues("quantity", Me.txtQuantity.Text)
        ingredients.addValues("price", Me.txtPrice.Text)
        ingredients.addValues("measurement", Me.cmoUnit.SelectedItem.ToString)

    End Sub

    Private Sub butDelete_Click(sender As Object, e As EventArgs) Handles butDelete.Click

        Dim message As MsgBoxResult = MsgBox("Are you sure you want to delete this ingredient?", vbYesNo, "Stock Management")

        If message = vbYes Then

            deleteIngredient()

        End If

        closeAndUpdate()

    End Sub

    Private Sub deleteIngredient()

        ingredients.addConditions("ingredientID", ingredientID)
        ingredients.executeDelete()

    End Sub

    Private Sub closeAndUpdate()

        stockForm.populateIngredientStock()
        Me.Close()

    End Sub

End Class