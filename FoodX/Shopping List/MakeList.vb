Public Class MakeList
    Private Sub MakeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundWorker.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork

        Dim shoppingList As ShoppingListGeneration
        shoppingList = New ShoppingListGeneration
        shoppingList.generateList()

    End Sub

    Private Sub BackgroundWorkerRunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted

        Dim oForm As ShoppingList

        oForm = New ShoppingList()
        oForm.Show()

        Me.Close()

    End Sub
End Class