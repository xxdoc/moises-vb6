<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRegNotas
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
	End Sub
	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents txtNombre As System.Windows.Forms.TextBox
	Public WithEvents txtApellido As System.Windows.Forms.TextBox
	Public WithEvents dtpFechaNac As AxMSComCtl2.AxDTPicker
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
	Public WithEvents cajaPestana As System.Windows.Forms.GroupBox
	Public WithEvents btnBuscarCedula As System.Windows.Forms.Button
	Public WithEvents txtCedula As System.Windows.Forms.TextBox
	Public WithEvents lblInstrucciones As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents ImageList1 As System.Windows.Forms.ImageList
	Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRegNotas))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cajaPestana = New System.Windows.Forms.GroupBox
		Me.SSTab1 = New System.Windows.Forms.TabControl
		Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.txtNombre = New System.Windows.Forms.TextBox
		Me.txtApellido = New System.Windows.Forms.TextBox
		Me.dtpFechaNac = New AxMSComCtl2.AxDTPicker
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage
		Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.btnBuscarCedula = New System.Windows.Forms.Button
		Me.txtCedula = New System.Windows.Forms.TextBox
		Me.lblInstrucciones = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.ImageList1 = New System.Windows.Forms.ImageList
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton
		Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton
		Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton
		Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripSeparator
		Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton
		Me._Toolbar1_Button6 = New System.Windows.Forms.ToolStripButton
		Me.cajaPestana.SuspendLayout()
		Me.SSTab1.SuspendLayout()
		Me._SSTab1_TabPage0.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtpFechaNac, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "frmRegNotas"
		Me.ClientSize = New System.Drawing.Size(659, 438)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmRegNotas"
		Me.cajaPestana.Enabled = False
		Me.cajaPestana.Size = New System.Drawing.Size(641, 273)
		Me.cajaPestana.Location = New System.Drawing.Point(8, 144)
		Me.cajaPestana.TabIndex = 6
		Me.cajaPestana.BackColor = System.Drawing.SystemColors.Control
		Me.cajaPestana.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cajaPestana.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cajaPestana.Visible = True
		Me.cajaPestana.Name = "cajaPestana"
		Me.SSTab1.Size = New System.Drawing.Size(617, 241)
		Me.SSTab1.Location = New System.Drawing.Point(8, 16)
		Me.SSTab1.TabIndex = 7
		Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
		Me.SSTab1.Name = "SSTab1"
		Me._SSTab1_TabPage0.Text = "Datos Basicos"
		Me.Frame2.Size = New System.Drawing.Size(585, 153)
		Me.Frame2.Location = New System.Drawing.Point(8, 40)
		Me.Frame2.TabIndex = 8
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.txtNombre.AutoSize = False
		Me.txtNombre.Size = New System.Drawing.Size(233, 19)
		Me.txtNombre.Location = New System.Drawing.Point(88, 24)
		Me.txtNombre.Maxlength = 250
		Me.txtNombre.TabIndex = 11
		Me.txtNombre.AcceptsReturn = True
		Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
		Me.txtNombre.CausesValidation = True
		Me.txtNombre.Enabled = True
		Me.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNombre.HideSelection = True
		Me.txtNombre.ReadOnly = False
		Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNombre.MultiLine = False
		Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNombre.TabStop = True
		Me.txtNombre.Visible = True
		Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNombre.Name = "txtNombre"
		Me.txtApellido.AutoSize = False
		Me.txtApellido.Size = New System.Drawing.Size(233, 19)
		Me.txtApellido.Location = New System.Drawing.Point(88, 56)
		Me.txtApellido.Maxlength = 250
		Me.txtApellido.TabIndex = 10
		Me.txtApellido.AcceptsReturn = True
		Me.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtApellido.BackColor = System.Drawing.SystemColors.Window
		Me.txtApellido.CausesValidation = True
		Me.txtApellido.Enabled = True
		Me.txtApellido.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtApellido.HideSelection = True
		Me.txtApellido.ReadOnly = False
		Me.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtApellido.MultiLine = False
		Me.txtApellido.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtApellido.TabStop = True
		Me.txtApellido.Visible = True
		Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtApellido.Name = "txtApellido"
		dtpFechaNac.OcxState = CType(resources.GetObject("dtpFechaNac.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtpFechaNac.Size = New System.Drawing.Size(121, 25)
		Me.dtpFechaNac.Location = New System.Drawing.Point(176, 96)
		Me.dtpFechaNac.TabIndex = 9
		Me.dtpFechaNac.Name = "dtpFechaNac"
		Me.Label2.Text = "Nombre"
		Me.Label2.Size = New System.Drawing.Size(37, 13)
		Me.Label2.Location = New System.Drawing.Point(40, 24)
		Me.Label2.TabIndex = 14
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = True
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label3.Text = "Apellido"
		Me.Label3.Size = New System.Drawing.Size(37, 13)
		Me.Label3.Location = New System.Drawing.Point(40, 56)
		Me.Label3.TabIndex = 13
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = True
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label4.Text = "Fecha de Nacimiento"
		Me.Label4.Size = New System.Drawing.Size(101, 13)
		Me.Label4.Location = New System.Drawing.Point(48, 96)
		Me.Label4.TabIndex = 12
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = True
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me._SSTab1_TabPage1.Text = "Notas"
		Me._SSTab1_TabPage2.Text = "Notas"
		Me.Frame1.Text = "Buscar por cédula"
		Me.Frame1.Enabled = False
		Me.Frame1.Size = New System.Drawing.Size(329, 89)
		Me.Frame1.Location = New System.Drawing.Point(8, 48)
		Me.Frame1.TabIndex = 1
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.btnBuscarCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBuscarCedula.Text = "Buscar"
		Me.btnBuscarCedula.Size = New System.Drawing.Size(73, 25)
		Me.btnBuscarCedula.Location = New System.Drawing.Point(224, 24)
		Me.btnBuscarCedula.TabIndex = 4
		Me.btnBuscarCedula.BackColor = System.Drawing.SystemColors.Control
		Me.btnBuscarCedula.CausesValidation = True
		Me.btnBuscarCedula.Enabled = True
		Me.btnBuscarCedula.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBuscarCedula.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBuscarCedula.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBuscarCedula.TabStop = True
		Me.btnBuscarCedula.Name = "btnBuscarCedula"
		Me.txtCedula.AutoSize = False
		Me.txtCedula.Size = New System.Drawing.Size(97, 19)
		Me.txtCedula.Location = New System.Drawing.Point(112, 24)
		Me.txtCedula.TabIndex = 3
		Me.txtCedula.AcceptsReturn = True
		Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCedula.BackColor = System.Drawing.SystemColors.Window
		Me.txtCedula.CausesValidation = True
		Me.txtCedula.Enabled = True
		Me.txtCedula.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCedula.HideSelection = True
		Me.txtCedula.ReadOnly = False
		Me.txtCedula.Maxlength = 0
		Me.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCedula.MultiLine = False
		Me.txtCedula.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCedula.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCedula.TabStop = True
		Me.txtCedula.Visible = True
		Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCedula.Name = "txtCedula"
		Me.lblInstrucciones.BackColor = System.Drawing.SystemColors.Info
		Me.lblInstrucciones.Text = "Instrucciones"
		Me.lblInstrucciones.Size = New System.Drawing.Size(63, 13)
		Me.lblInstrucciones.Location = New System.Drawing.Point(16, 56)
		Me.lblInstrucciones.TabIndex = 5
		Me.lblInstrucciones.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblInstrucciones.Enabled = True
		Me.lblInstrucciones.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblInstrucciones.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblInstrucciones.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblInstrucciones.UseMnemonic = True
		Me.lblInstrucciones.Visible = True
		Me.lblInstrucciones.AutoSize = True
		Me.lblInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblInstrucciones.Name = "lblInstrucciones"
		Me.Label1.Text = "Numero de cédula"
		Me.Label1.Size = New System.Drawing.Size(87, 13)
		Me.Label1.Location = New System.Drawing.Point(16, 24)
		Me.Label1.TabIndex = 2
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList1.Images.SetKeyName(0, "")
		Me.ImageList1.Images.SetKeyName(1, "")
		Me.ImageList1.Images.SetKeyName(2, "")
		Me.ImageList1.Images.SetKeyName(3, "")
		Me.ImageList1.Images.SetKeyName(4, "")
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(659, 42)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 0
		Me.Toolbar1.ImageList = ImageList1
		Me.Toolbar1.Name = "Toolbar1"
		Me._Toolbar1_Button1.Size = New System.Drawing.Size(51, 37)
		Me._Toolbar1_Button1.AutoSize = False
		Me._Toolbar1_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button1.CheckOnClick = False
		Me._Toolbar1_Button1.Text = "Agregar"
		Me._Toolbar1_Button1.Name = "Agregar"
		Me._Toolbar1_Button1.ImageIndex = 0
		Me._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._Toolbar1_Button2.Size = New System.Drawing.Size(51, 37)
		Me._Toolbar1_Button2.AutoSize = False
		Me._Toolbar1_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button2.CheckOnClick = False
		Me._Toolbar1_Button2.Text = "Modificar"
		Me._Toolbar1_Button2.Name = "Modificar"
		Me._Toolbar1_Button2.ImageIndex = 1
		Me._Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._Toolbar1_Button3.Size = New System.Drawing.Size(51, 37)
		Me._Toolbar1_Button3.AutoSize = False
		Me._Toolbar1_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button3.CheckOnClick = False
		Me._Toolbar1_Button3.Text = "Eliminar"
		Me._Toolbar1_Button3.Name = "Eliminar"
		Me._Toolbar1_Button3.ImageIndex = 2
		Me._Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._Toolbar1_Button4.Size = New System.Drawing.Size(51, 37)
		Me._Toolbar1_Button4.AutoSize = False
		Me._Toolbar1_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        'Me._Toolbar1_Button4.CheckOnClick = False
		Me._Toolbar1_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._Toolbar1_Button5.Size = New System.Drawing.Size(51, 37)
		Me._Toolbar1_Button5.AutoSize = False
		Me._Toolbar1_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button5.CheckOnClick = False
		Me._Toolbar1_Button5.Text = "Guardar"
		Me._Toolbar1_Button5.Name = "Guardar"
		Me._Toolbar1_Button5.ImageIndex = 3
		Me._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._Toolbar1_Button6.Size = New System.Drawing.Size(51, 37)
		Me._Toolbar1_Button6.AutoSize = False
		Me._Toolbar1_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button6.CheckOnClick = False
		Me._Toolbar1_Button6.Text = "Salir"
		Me._Toolbar1_Button6.Name = "Salir"
		Me._Toolbar1_Button6.ImageIndex = 4
		Me._Toolbar1_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Controls.Add(cajaPestana)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Toolbar1)
		Me.cajaPestana.Controls.Add(SSTab1)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage0)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage1)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage2)
		Me._SSTab1_TabPage0.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(txtNombre)
		Me.Frame2.Controls.Add(txtApellido)
		Me.Frame2.Controls.Add(dtpFechaNac)
		Me.Frame2.Controls.Add(Label2)
		Me.Frame2.Controls.Add(Label3)
		Me.Frame2.Controls.Add(Label4)
		Me.Frame1.Controls.Add(btnBuscarCedula)
		Me.Frame1.Controls.Add(txtCedula)
		Me.Frame1.Controls.Add(lblInstrucciones)
		Me.Frame1.Controls.Add(Label1)
		Me.Toolbar1.Items.Add(_Toolbar1_Button1)
		Me.Toolbar1.Items.Add(_Toolbar1_Button2)
		Me.Toolbar1.Items.Add(_Toolbar1_Button3)
		Me.Toolbar1.Items.Add(_Toolbar1_Button4)
		Me.Toolbar1.Items.Add(_Toolbar1_Button5)
		Me.Toolbar1.Items.Add(_Toolbar1_Button6)
		CType(Me.dtpFechaNac, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cajaPestana.ResumeLayout(False)
		Me.SSTab1.ResumeLayout(False)
		Me._SSTab1_TabPage0.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class