Imports System.Data.Odbc

Public Class Db2ConnectionManager






    Public Shared Function GetConnection() As OdbcConnection
        Dim connStr As String =
            "Driver={IBM DB2 ODBC DRIVER};" &
            "Database=" & My.Settings.DB2Database & ";" &
            "Hostname=" & My.Settings.DB2Host & ";" &
            "Port=" & My.Settings.DB2Port & ";" &
            "Protocol=TCPIP;" &
            "Uid=" & My.Settings.DB2Uid & ";" &
            "Pwd=" & My.Settings.DB2Pwd & ";" &
            "Security=SSL;"

        Dim conn As New OdbcConnection(connStr)
        conn.Open()
        Return conn
    End Function

End Class
