Imports System.Data.Odbc

Module Module1


    Public Class Db2ConnectionManager
        Private Shared _connection As OdbcConnection

        Public Shared ReadOnly Property Connection As OdbcConnection
            Get
                If _connection Is Nothing Then
                    _connection = New OdbcConnection(
                        "Driver={IBM DB2 ODBC DRIVER};" &
                        "Database=bludb;" &
                        "Hostname=b1bc1829-6f45-4cd4-bef4-10cf081900bf.c1ogj3sd0tgtu0lqde00.databases.appdomain.cloud;" &
                        "Port=32304;" &
                        "Protocol=TCPIP;" &
                        "Uid=plm02017;" &
                        "Pwd=SyjXaXAOjtIQaUHt;" &
                        "Security=SSL;")
                    _connection.Open()
                End If
                Return _connection
            End Get
        End Property
    End Class
End Module
