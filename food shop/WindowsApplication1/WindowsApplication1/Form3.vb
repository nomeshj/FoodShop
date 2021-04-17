Imports System.Data.OleDb


Public Class Form3
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim sum1 As Integer


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("enter  customer name")
        ElseIf TextBox2.Text = "" Then
            MsgBox("enter mobile no")
        ElseIf TextBox3.Text = "" Then
            MsgBox("enter order no")
        ElseIf sum1 = 0 Then
            MsgBox("Calculate Total")
        Else
            pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SE\Desktop\food shop\Database1.accdb"
            connstring = pro
            myconnection.ConnectionString = connstring
            myconnection.Open()
            command = "insert into Customer([Customer_name],[Order_no],[Mobile_no],[Amount_paid]) values ('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "','" & sum1 & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
            cmd.Parameters.Add(New OleDbParameter("Customer_name", CType(TextBox1.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Order_no", CType(TextBox3.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Mobile_no", CType(TextBox2.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Amount_paid", CType(Label18.Text, String)))
            MsgBox("record save")
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myconnection.Close()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        _
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim sum As Integer
        If CheckBox1.Checked = True Then
            sum = sum + 50
        End If

        If CheckBox2.Checked = True Then
            sum = sum + 60
        End If
        If CheckBox3.Checked = True Then
            sum = sum + 110
        End If
        If CheckBox4.Checked = True Then
            sum = sum + 120
        End If
        If CheckBox5.Checked = True Then
            sum = sum + 110
        End If
        If CheckBox6.Checked = True Then
            sum = sum + 70
        End If
        If CheckBox7.Checked = True Then
            sum = sum + 60
        End If
        If CheckBox8.Checked = True Then
            sum = sum + 80
        End If
        If CheckBox9.Checked = True Then
            sum = sum + 110
        End If
        If CheckBox10.Checked = True Then
            sum = sum + 90
        End If
        If CheckBox11.Checked = True Then
            sum = sum + 150
        End If
        If CheckBox12.Checked = True Then
            sum = sum + 40
        End If
        If CheckBox13.Checked = True Then
            sum = sum + 60
        End If
        If CheckBox14.Checked = True Then
            sum = sum + 60
        End If
        If CheckBox15.Checked = True Then
            sum = sum + 70
        End If

        sum1 = sum
        Label18.Text = sum.ToString()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If TextBox1.Text = "" Then
            MsgBox("enter  customer name")
        ElseIf TextBox2.Text = "" Then
            MsgBox("enter mobile no")
        ElseIf TextBox3.Text = "" Then
            MsgBox("enter order no")
        ElseIf sum1 = 0 Then
            MsgBox("Calculate the Total")
        Else
            Label19.Text = "customer name = " + TextBox1.Text + vbNewLine + "Mobile no = " + TextBox2.Text + vbNewLine + "Order no = " + TextBox3.Text + vbNewLine + "======================" + vbNewLine + "Total = " + Label18.Text

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class