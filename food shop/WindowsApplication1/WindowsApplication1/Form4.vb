Imports System.Data.OleDb

Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SE\Desktop\food shop\Database1.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand("select id,Customer_name,Order_no,Mobile_no,Amount_paid from Customer", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd
        Dim table1 As New DataTable
        table1.Clear()
        da.Fill(table1)
        DataGridView1.DataSource = table1
        conn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class