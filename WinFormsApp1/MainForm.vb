
Imports System.Data.Odbc

Public Class FrmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDb2()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmNewOpp.Show()
    End Sub
    Private Sub ConnectDb2()
        ' Adapted from your JDBC URL in memory
        Dim connString As String =
            "Driver={IBM DB2 ODBC DRIVER};" &
            "Database=bludb;" &
            "Hostname=b1bc1829-6f45-4cd4-bef4-10cf081900bf.c1ogj3sd0tgtu0lqde00.databases.appdomain.cloud;" &
            "Port=32304;" &
            "Protocol=TCPIP;" &
            "Uid=plm02017;" &
            "Pwd=SyjXaXAOjtIQaUHt;" &
            "Security=SSL;"

        Using conn As New OdbcConnection(connString)
            conn.Open()

            Dim cmd As New OdbcCommand("SELECT CURRENT DATE FROM SYSIBM.SYSDUMMY1", conn)
            Dim result As Object = cmd.ExecuteScalar()
            MessageBox.Show("Connected! Db2 current date is: " & result.ToString())
        End Using

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
