Public Class NewIngredient
    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        Dim ingredients As Ingredients = New Ingredients

        ingredients.addValues("name", Me.txtName.Text)
        ingredients.executeInsert("tblIngredients")

        Me.Close()

    End Sub

    Private Sub NewIngredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class