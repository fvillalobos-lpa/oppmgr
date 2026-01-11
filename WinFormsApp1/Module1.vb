Imports System.Data.Odbc
Imports System.Runtime.InteropServices

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




Public Class NativeMethods
    <StructLayout(LayoutKind.Sequential)>
    Public Structure SHFILEINFO
        Public hIcon As IntPtr
        Public iIcon As Integer
        Public dwAttributes As UInteger
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)>
        Public szTypeName As String
    End Structure

    <DllImport("shell32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function SHGetFileInfo(
        ByVal pszPath As String,
        ByVal dwFileAttributes As UInteger,
        ByRef psfi As SHFILEINFO,
        ByVal cbFileInfo As UInteger,
        ByVal uFlags As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function DestroyIcon(hIcon As IntPtr) As Boolean
    End Function

    Public Const SHGFI_ICON As UInteger = &H100
    Public Const SHGFI_SMALLICON As UInteger = &H1
End Class

