Attribute VB_Name = "modFunciones"
Option Explicit

Global cnnApp As ADODB.Connection
Global RutaBD As String
Global ArchivoIni As String

Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long  'Leer archivos INI
Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Long 'Escribir en archivos INI

Sub Main()
Dim I As Integer

    ArchivoIni = App.Path & "\config.ini"
    
    If Len(Dir(ArchivoIni)) > 0 Then
        Dim Est As String
        Est = String$(255, " ")
        I = GetPrivateProfileString("Aplicacion", "BD", "", Est, Len(Est), ArchivoIni)
        If I > 0 Then
            RutaBD = RTrim$(Est)
        End If
        If Len(Trim$(RutaBD)) = 0 Then
            MsgBox "No se puede establecer rutas de base de datos", vbCritical
            End
        End If
        If Len(Trim$(Dir(RutaBD))) = 0 Then
            MsgBox "Archivo no se encuentra en la ruta especificada", vbCritical
        End If
    End If

    RutaBD = Mid(RutaBD, 1, Len(RutaBD) - 1)
    
    Dim strError As String
    On Error GoTo ErrorHandler

    Dim CadenaConexion As String
    
    CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & RutaBD & ";Persist Security Info=False"
    
    Set cnnApp = New ADODB.Connection
    cnnApp.Open CadenaConexion
    
    
    frmRegNotas.Show
    Exit Sub

ErrorHandler:

Dim errLoop As ADODB.Error
' Enumera la colección Errors y muestra las propiedades de cada uno de los objetos Error.
For Each errLoop In cnnApp.Errors
    strError = "Error #" & errLoop.Number & vbCr & "" & errLoop.Description & vbCr & "(Origen: " & errLoop.Source & ")" & vbCr & "(Estado de SQL: " & errLoop.SQLState & ")" & vbCr & "(Error nativo: " & errLoop.NativeError & ")" & vbCr
    If errLoop.HelpFile = "" Then
        strError = strError & "No hay un archivo de Ayuda disponible" & vbCr & vbCr
    Else
        strError = strError & "(Archivo de Ayuda: " & errLoop.HelpFile & ")" & vbCr & "(Contexto de Ayuda: " & errLoop.HelpContext & ")" & vbCr & vbCr
    End If
    MsgBox strError, vbCritical
    Next
Resume Next

End Sub

Public Function Salir() As Boolean
    If MsgBox("Desea terminar el programa", vbQuestion + vbYesNo) = vbYes Then
        Salir = True
    Else
        Salir = False
    End If
End Function

