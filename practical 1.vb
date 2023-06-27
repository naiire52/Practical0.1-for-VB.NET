Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("You've succesfully logged in", "HIO IMEWEZA")
        Dim r As VariantType
        r = MessageBox.Show("Are you sure you want to close the application?", "CONFIRM EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If r = vbYes Then
            Me.Close()
        End If
    End Sub
End Class