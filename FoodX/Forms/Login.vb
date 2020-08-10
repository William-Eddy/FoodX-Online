Public Class Login
    Public Shared oForm As Main_Menu

    Private Sub imgProfilePic_MouseEnter(sender As Object, e As EventArgs) Handles imgProfilePic.MouseEnter
        Me.imgProfilePic.Visible = False
    End Sub

    Private Sub imgProfilePic_Click(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Me.imgProfilePic.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub imgProfilePicSelected_Click(sender As Object, e As EventArgs) Handles imgProfilePicSelected.Click

        oForm = New Main_Menu()
        oForm.Show()
        Me.Close()

    End Sub

End Class