Public Class SplashScreen

    Public Shared oForm As Main_Menu

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick

        oForm = New Main_Menu()
        oForm.Show()
        Me.Close()

    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
