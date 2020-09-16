Public Class EditMeasurement

    Dim measurementID As String
    Dim masterForm As Main_Menu
    Dim measurements As BodyMeasurements = New BodyMeasurements

    Private Sub EditMeasurement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not (measurementID = Nothing) Then

            loadCurrentMeasurements()
            Me.txtDate.Enabled = False
            Me.butSave.Text = "Save"
        Else

            Me.txtDate.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)

        End If

    End Sub

    Public Sub New(masterForm, Optional measurementID = Nothing)

        InitializeComponent()

        Me.measurementID = measurementID
        Me.masterForm = masterForm

    End Sub

    Private Sub loadCurrentMeasurements()

        measurements.setContentsForMeasurementID(measurementID)

        Me.txtDate.Text = measurements.getCurrentDate
        Me.txtWeight.Text = measurements.getCurrentWeight
        Me.txtWaist.Text = measurements.getCurrentWaist
        Me.txtChest.Text = measurements.getCurrentChest
        Me.txtShoulders.Text = measurements.getCurrentShoulders
        Me.txtThigh.Text = measurements.getCurrentThigh
        Me.txtBicep.Text = measurements.getCurrentBicep
        Me.txtForearm.Text = measurements.getCurrentForearm
        Me.txtBodyFat.Text = measurements.getCurrentBodyFat

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        If measurementID = Nothing Then

            addMeasurement()

        Else

            updateMeasurement()

        End If

    End Sub

    Private Sub updateMeasurement()

        addValues()
        measurements.executeUpdate()
        updateAndClose()

    End Sub
    Private Sub addMeasurement()

        addValues()
        measurements.executeInsert()
        updateAndClose()

    End Sub

    Private Sub addValues()

        measurements.addValues("date", Me.txtDate.Text)
        measurements.addValues("weight", Me.txtWeight.Text)
        measurements.addValues("waist", Me.txtWaist.Text)
        measurements.addValues("chest", Me.txtChest.Text)
        measurements.addValues("shoulders", Me.txtShoulders.Text)
        measurements.addValues("thigh", Me.txtThigh.Text)
        measurements.addValues("bicep", Me.txtBicep.Text)
        measurements.addValues("forearm", Me.txtForearm.Text)
        measurements.addValues("bodyFat", Me.txtBodyFat.Text)
        measurements.addConditions("measurementID", measurementID)

    End Sub

    Private Sub updateAndClose()

        masterForm.updateMeasurementsListview()
        Me.Close()

    End Sub



End Class