Imports System.Data.Odbc

Public Class Db2ConnectionManager



    Private Const ConnStr As String =
            "Driver={IBM DB2 ODBC DRIVER};" &
            "Database=bludb;" &
            "Hostname=b1bc1829-6f45-4cd4-bef4-10cf081900bf.c1ogj3sd0tgtu0lqde00.databases.appdomain.cloud;" &
            "Port=32304;" &
            "Protocol=TCPIP;" &
            "Uid=plm02017;" &
            "Pwd=SyjXaXAOjtIQaUHt;" &
            "Security=SSL;"

        Public Shared Function GetConnection() As OdbcConnection
            Dim conn As New OdbcConnection(ConnStr)
            conn.Open()
            Return conn
        End Function

End Class
