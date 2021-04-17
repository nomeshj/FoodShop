Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        If TextBox1.Text = "kalpesh" And TextBox2.Text = "kalpesh123" Then
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Invalid user")
        End If
       


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub
End Class
