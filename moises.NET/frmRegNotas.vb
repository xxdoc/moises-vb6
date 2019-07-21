Option Strict Off
Option Explicit On
Friend Class frmRegNotas
	Inherits System.Windows.Forms.Form
	Dim Proceso As String
	Dim rstAlumno As ADODB.Recordset
	Dim sSQl As String
	Dim I As Short
	Dim sPassword As String
	
	Sub HabilitarBotones()
		'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		Toolbar1.Items.Item(1).Enabled = True
		'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		Toolbar1.Items.Item(2).Enabled = True
		'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		Toolbar1.Items.Item(3).Enabled = False
		'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		Toolbar1.Items.Item(5).Enabled = False
		'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		Toolbar1.Items.Item(6).Enabled = False
	End Sub
	
	Sub DeshabilitarBotones()
		'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		Toolbar1.Items.Item(1).Enabled = False
		'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		Toolbar1.Items.Item(2).Enabled = False
		'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		Toolbar1.Items.Item(3).Enabled = False
		'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		Toolbar1.Items.Item(5).Enabled = True
		'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		Toolbar1.Items.Item(6).Enabled = True
	End Sub
	
	Sub Limpiar()
		txtNombre.Text = ""
		txtApellido.Text = ""
		txtCedula.Text = ""
		dtpFechaNac.Value = #1/1/1980#
	End Sub
	
	Private Sub btnBuscarCedula_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBuscarCedula.Click
		rstAlumno = New ADODB.Recordset
		sSQl = "Select * from Alumnos where Cedula='" & txtCedula.Text & "'"
		
		rstAlumno.Open(sSQl, cnnApp, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rstAlumno.RecordCount = 0 Then
			If Proceso = "I" Then
				Frame1.Enabled = True
				txtNombre.Focus()
			Else
				MsgBox("Registro no existe")
			End If
		Else
			If Proceso <> "I" Then
				txtNombre.Text = rstAlumno.Fields("nombre").Value & ""
				txtApellido.Text = rstAlumno.Fields("apellido").Value & ""
				dtpFechaNac.Value = rstAlumno.Fields("fecha_nac").Value & ""
				Frame1.Enabled = True
				cajaPestana.Enabled = True
				txtNombre.Focus()
			Else
				MsgBox("Registro ya existe")
				txtCedula.SelectionStart = 0
				txtCedula.SelectionLength = Len(txtCedula.Text)
				txtCedula.Focus()
			End If
		End If
	End Sub
	
	Private Sub frmRegNotas_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Proceso = "M"
		lblInstrucciones.Text = "Formato de busqueda: V12345678 o E12345678"
	End Sub
	
	Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button1.Click, _Toolbar1_Button2.Click, _Toolbar1_Button3.Click, _Toolbar1_Button4.Click, _Toolbar1_Button5.Click, _Toolbar1_Button6.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		On Error Resume Next
		Select Case Button.Name
			Case "Agregar"
				Proceso = "I"
				GoTo Terminar
			Case "Modificar"
				Proceso = "M"
				GoTo Terminar
			Case "Eliminar"
				Proceso = "E"
				GoTo Terminar
			Case "Guardar"
				If Proceso = "I" Then
					rstAlumno.AddNew()
				Else
					rstAlumno.Fields("cedula").Value = txtCedula.Text
					rstAlumno.Fields("nombre").Value = txtNombre.Text
					rstAlumno.Fields("apellido").Value = txtApellido.Text
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto dtpFechaNac.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					rstAlumno.Fields("fecha_nac").Value = dtpFechaNac.Value
					rstAlumno.Update()
					GoTo Terminar2
				End If
			Case "Salir"
				Me.Close()
		End Select
		Exit Sub
		
Terminar: 
		DeshabilitarBotones()
		Frame1.Enabled = True
		txtCedula.Focus()
		Exit Sub
		
Terminar2: 
		rstAlumno.Close()
		'UPGRADE_NOTE: El objeto rstAlumno no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rstAlumno = Nothing
		Limpiar()
		HabilitarBotones()
		Frame1.Enabled = False
		cajaPestana.Enabled = False
	End Sub
End Class