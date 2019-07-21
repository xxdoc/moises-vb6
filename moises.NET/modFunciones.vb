Option Strict Off
Option Explicit On
Module modFunciones
	
	Public cnnApp As ADODB.Connection
	Public RutaBD As String
	Public ArchivoIni As String
	
	Public Declare Function GetPrivateProfileString Lib "kernel32"  Alias "GetPrivateProfileStringA"(ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer 'Leer archivos INI
	Public Declare Function WritePrivateProfileString Lib "kernel32"  Alias "WritePrivateProfileStringA"(ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer 'Escribir en archivos INI
	
	'UPGRADE_WARNING: La aplicación terminará cuando Sub Main() finalice. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="E08DDC71-66BA-424F-A612-80AF11498FF8"'
	Public Sub Main()
		Dim I As Short
		
		ArchivoIni = My.Application.Info.DirectoryPath & "\config.ini"
		
		'UPGRADE_WARNING: Dir tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		Dim Est As String
		If Len(Dir(ArchivoIni)) > 0 Then
			Est = New String(" ", 255)
			I = GetPrivateProfileString("Aplicacion", "BD", "", Est, Len(Est), ArchivoIni)
			If I > 0 Then
				RutaBD = RTrim(Est)
			End If
			If Len(Trim(RutaBD)) = 0 Then
				MsgBox("No se puede establecer rutas de base de datos", MsgBoxStyle.Critical)
				End
			End If
			'UPGRADE_WARNING: Dir tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If Len(Trim(Dir(RutaBD))) = 0 Then
				MsgBox("Archivo no se encuentra en la ruta especificada", MsgBoxStyle.Critical)
			End If
		End If
		
		RutaBD = Mid(RutaBD, 1, Len(RutaBD) - 1)
		
		Dim strError As String
		On Error GoTo ErrorHandler
		
		Dim CadenaConexion As String
		
		CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & RutaBD & ";Persist Security Info=False"
		
		cnnApp = New ADODB.Connection
		cnnApp.Open(CadenaConexion)
		
		
		frmRegNotas.Show()
		Exit Sub
		
ErrorHandler: 
		
		Dim errLoop As ADODB.Error
		' Enumera la colección Errors y muestra las propiedades de cada uno de los objetos Error.
		For	Each errLoop In cnnApp.Errors
			strError = "Error #" & errLoop.Number & vbCr & "" & errLoop.Description & vbCr & "(Origen: " & errLoop.Source & ")" & vbCr & "(Estado de SQL: " & errLoop.SQLState & ")" & vbCr & "(Error nativo: " & errLoop.NativeError & ")" & vbCr
			If errLoop.HelpFile = "" Then
				strError = strError & "No hay un archivo de Ayuda disponible" & vbCr & vbCr
			Else
				strError = strError & "(Archivo de Ayuda: " & errLoop.HelpFile & ")" & vbCr & "(Contexto de Ayuda: " & errLoop.HelpContext & ")" & vbCr & vbCr
			End If
			MsgBox(strError, MsgBoxStyle.Critical)
		Next errLoop
		Resume Next
		
	End Sub
	
	Public Function Salir() As Boolean
		If MsgBox("Desea terminar el programa", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
			Salir = True
		Else
			Salir = False
		End If
	End Function
End Module