Public Class EditMethodSteps

    Dim EditMealForm As EditMeal
    Dim stepID As String
    Dim mealID As String
    Dim methods As Methods = New Methods
    Dim newStep As Boolean = False
    Private Sub EditSteps_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If stepID = Nothing Then

            newStep = True
            stepID = methods.getHighestOrderID(mealID) + 1
            Me.txtOrderID.Text = stepID

        Else

            setMethodContents()
            setDataToFields()

        End If

        changeSaveButtonText()


    End Sub

    Public Sub New(masterForm, mealID, Optional stepID = Nothing)

        InitializeComponent()

        Me.mealID = mealID
        Me.stepID = stepID
        EditMealForm = masterForm

    End Sub

    Private Sub setMethodContents()

        methods.addConditions("stepID", stepID)
        methods.executeSelect()

    End Sub

    Public Sub setDataToFields()

        Me.txtOrderID.Text = methods.getCurrentOrderID()
        Me.txtInstruction.Text = methods.getCurrentInstruction()

    End Sub

    Public Sub updateStep()

        methods.addValues("orderID", Me.txtOrderID.Text)
        methods.addValues("instruction", Me.txtInstruction.Text)
        methods.addConditions("stepID", stepID)
        methods.executeUpdate()

    End Sub

    Public Sub addStep()

        methods.addValues("orderID", Me.txtOrderID.Text)
        methods.addValues("mealID", mealID)
        methods.addValues("instruction", Me.txtInstruction.Text)
        methods.executeInsert()

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        If newStep = True Then
            addStep()
        Else
            updateStep()
        End If

        EditMealForm.setMethodStepsView()
        Me.Close()

    End Sub

    Private Sub changeSaveButtonText()

        If newStep = True Then
            butSave.Text = "Add"
        Else
            butSave.Text = "Save"
        End If

    End Sub
End Class