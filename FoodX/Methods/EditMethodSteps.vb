Public Class EditMethodSteps

    Dim EditMealForm As EditMeal
    Dim stepID As String
    Dim methods As Methods = New Methods
    Private Sub EditSteps_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setMethodContents()
        setDataToFields()

    End Sub

    Public Sub New(stepID, masterForm)

        InitializeComponent()

        Me.stepID = stepID
        EditMealForm = masterForm

    End Sub

    Private Sub setMethodContents()

        methods.addConditions("stepID", stepID)
        methods.executeSelect()

    End Sub

    Public Sub setDataToFields()

        Me.txtOrderID = methods.getCurrentOrderID()
        Me.txtInstruction = methods.getCurrentInstruction()

    End Sub

    Public Sub updateRecord()

        methods.addValues("orderID", Me.txtOrderID)
        methods.addValues("instruction", Me.txtInstruction)
        methods.addConditions("stepID", stepID)
        methods.executeUpdate()

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        updateRecord()
        EditMealForm.setMethodSteps()
        Me.Close()

    End Sub
End Class