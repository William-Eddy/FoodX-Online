Public Class NewBarcode

    Dim ingData As DataTable
    Dim inbarcode As String

    Public Sub New(ByVal barcode As String)

        InitializeComponent()

        inbarcode = barcode

    End Sub

    Private Sub NewBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ingData = MainConnectionAccess.conndb.runAdapter("SELECT `ingredientID`, `name` FROM `tblIngredients`")
        'cbxIngredientList.DataSource = ingData

        With cbxIngredientList

            .DataSource = ingData
            .ValueMember = ingData.Columns(0).ToString
            .DisplayMember = ingData.Columns(1).ToString

        End With



    End Sub

    Private Sub cbxIngredientList_DropDownClosed(sender As Object, e As EventArgs) Handles cbxIngredientList.Leave

        ingData = MainConnectionAccess.conndb.runAdapter("SELECT `measurement` FROM `tblIngredients` WHERE ingredientID= " + Str(Me.cbxIngredientList.SelectedValue))

        Me.lblUnit.Text = ingData.Rows(0).Item(0).ToString()


    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        Dim pricedub As Double
        Dim insertArray As String()
        pricedub = Me.txtPrice.Text

        MainConnectionAccess.conndb.addNewProduct(inbarcode, Me.cbxIngredientList.SelectedValue, Me.txtQuantity.Text, pricedub)

        insertArray = {Me.cbxIngredientList.SelectedValue, "Test", Me.txtQuantity.Text, pricedub}

        Me.Close()
        Main_Menu.Focus()

        Main_Menu.AddToIngListView(inbarcode, insertArray)

        'lvIngredients.Items.Add(inbarcode)

        ' Main_Menu.DataGridView.Rows.Add(inbarcode)


    End Sub
End Class