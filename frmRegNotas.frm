VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form frmRegNotas 
   Caption         =   "frmRegNotas"
   ClientHeight    =   6570
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9885
   LinkTopic       =   "Form1"
   ScaleHeight     =   6570
   ScaleWidth      =   9885
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame cajaPestana 
      Enabled         =   0   'False
      Height          =   4095
      Left            =   120
      TabIndex        =   6
      Top             =   2160
      Width           =   9615
      Begin TabDlg.SSTab SSTab1 
         Height          =   3615
         Left            =   120
         TabIndex        =   7
         Top             =   240
         Width           =   9255
         _ExtentX        =   16325
         _ExtentY        =   6376
         _Version        =   393216
         TabHeight       =   520
         TabCaption(0)   =   "Datos Basicos"
         TabPicture(0)   =   "frmRegNotas.frx":0000
         Tab(0).ControlEnabled=   -1  'True
         Tab(0).Control(0)=   "Frame2"
         Tab(0).Control(0).Enabled=   0   'False
         Tab(0).ControlCount=   1
         TabCaption(1)   =   "Notas"
         TabPicture(1)   =   "frmRegNotas.frx":001C
         Tab(1).ControlEnabled=   0   'False
         Tab(1).ControlCount=   0
         TabCaption(2)   =   "Notas"
         TabPicture(2)   =   "frmRegNotas.frx":0038
         Tab(2).ControlEnabled=   0   'False
         Tab(2).ControlCount=   0
         Begin VB.Frame Frame2 
            Height          =   2295
            Left            =   120
            TabIndex        =   8
            Top             =   600
            Width           =   8775
            Begin VB.TextBox txtNombre 
               Height          =   285
               Left            =   1320
               MaxLength       =   250
               TabIndex        =   11
               Top             =   360
               Width           =   3495
            End
            Begin VB.TextBox txtApellido 
               Height          =   285
               Left            =   1320
               MaxLength       =   250
               TabIndex        =   10
               Top             =   840
               Width           =   3495
            End
            Begin MSComCtl2.DTPicker dtpFechaNac 
               Height          =   375
               Left            =   2640
               TabIndex        =   9
               Top             =   1440
               Width           =   1815
               _ExtentX        =   3201
               _ExtentY        =   661
               _Version        =   393216
               Format          =   16777217
               CurrentDate     =   43570
            End
            Begin VB.Label Label2 
               AutoSize        =   -1  'True
               Caption         =   "Nombre"
               Height          =   195
               Left            =   600
               TabIndex        =   14
               Top             =   360
               Width           =   555
            End
            Begin VB.Label Label3 
               AutoSize        =   -1  'True
               Caption         =   "Apellido"
               Height          =   195
               Left            =   600
               TabIndex        =   13
               Top             =   840
               Width           =   555
            End
            Begin VB.Label Label4 
               AutoSize        =   -1  'True
               Caption         =   "Fecha de Nacimiento"
               Height          =   195
               Left            =   720
               TabIndex        =   12
               Top             =   1440
               Width           =   1515
            End
         End
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Buscar por cédula"
      Enabled         =   0   'False
      Height          =   1335
      Left            =   120
      TabIndex        =   1
      Top             =   720
      Width           =   4935
      Begin VB.CommandButton btnBuscarCedula 
         Caption         =   "Buscar"
         Height          =   375
         Left            =   3360
         TabIndex        =   4
         Top             =   360
         Width           =   1095
      End
      Begin VB.TextBox txtCedula 
         Height          =   285
         Left            =   1680
         TabIndex        =   3
         Top             =   360
         Width           =   1455
      End
      Begin VB.Label lblInstrucciones 
         AutoSize        =   -1  'True
         BackColor       =   &H80000018&
         Caption         =   "Instrucciones"
         Height          =   195
         Left            =   240
         TabIndex        =   5
         Top             =   840
         Width           =   945
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Numero de cédula"
         Height          =   195
         Left            =   240
         TabIndex        =   2
         Top             =   360
         Width           =   1305
      End
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   8760
      Top             =   840
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   5
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmRegNotas.frx":0054
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmRegNotas.frx":0166
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmRegNotas.frx":0278
            Key             =   ""
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmRegNotas.frx":038A
            Key             =   ""
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmRegNotas.frx":049C
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.Toolbar Toolbar1 
      Align           =   1  'Align Top
      Height          =   630
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   9885
      _ExtentX        =   17436
      _ExtentY        =   1111
      ButtonWidth     =   1323
      ButtonHeight    =   953
      Appearance      =   1
      ImageList       =   "ImageList1"
      _Version        =   393216
      BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
         NumButtons      =   6
         BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Agregar"
            Key             =   "Agregar"
            ImageIndex      =   1
         EndProperty
         BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Modificar"
            Key             =   "Modificar"
            ImageIndex      =   2
         EndProperty
         BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Eliminar"
            Key             =   "Eliminar"
            ImageIndex      =   3
         EndProperty
         BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Guardar"
            Key             =   "Guardar"
            ImageIndex      =   4
         EndProperty
         BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Salir"
            Key             =   "Salir"
            ImageIndex      =   5
         EndProperty
      EndProperty
   End
End
Attribute VB_Name = "frmRegNotas"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim Proceso As String
Dim rstAlumno As ADODB.Recordset
Dim sSQl As String
Dim I As Integer
Dim sPassword As String

Sub HabilitarBotones()
    Toolbar1.Buttons(1).Enabled = True
    Toolbar1.Buttons(2).Enabled = True
    Toolbar1.Buttons(3).Enabled = False
    Toolbar1.Buttons(5).Enabled = False
    Toolbar1.Buttons(6).Enabled = False
End Sub

Sub DeshabilitarBotones()
    Toolbar1.Buttons(1).Enabled = False
    Toolbar1.Buttons(2).Enabled = False
    Toolbar1.Buttons(3).Enabled = False
    Toolbar1.Buttons(5).Enabled = True
    Toolbar1.Buttons(6).Enabled = True
End Sub

Sub Limpiar()
    txtNombre.Text = ""
    txtApellido.Text = ""
    txtCedula.Text = ""
    dtpFechaNac.Value = #1/1/1980#
End Sub

Private Sub btnBuscarCedula_Click()
    Set rstAlumno = New ADODB.Recordset
    sSQl = "Select * from Alumnos where Cedula='" & txtCedula.Text & "'"
    
    rstAlumno.Open sSQl, cnnApp, adOpenStatic, adLockOptimistic
    
    If rstAlumno.RecordCount = 0 Then
        If Proceso = "I" Then
            Frame1.Enabled = True
            txtNombre.SetFocus
        Else
            MsgBox "Registro no existe"
        End If
    Else
        If Proceso <> "I" Then
            txtNombre.Text = rstAlumno.Fields("nombre") & ""
            txtApellido.Text = rstAlumno.Fields("apellido") & ""
            dtpFechaNac.Value = rstAlumno.Fields("fecha_nac") & ""
            Frame1.Enabled = True
            cajaPestana.Enabled = True
            txtNombre.SetFocus
        Else
            MsgBox "Registro ya existe"
            txtCedula.SelStart = 0
            txtCedula.SelLength = Len(txtCedula.Text)
            txtCedula.SetFocus
        End If
    End If
End Sub

Private Sub Form_Load()
    Proceso = "M"
    lblInstrucciones.Caption = "Formato de busqueda: V12345678 o E12345678"
End Sub

Private Sub Toolbar1_ButtonClick(ByVal Button As MSComctlLib.Button)
    On Error Resume Next
    Select Case Button.Key
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
                rstAlumno.AddNew
            Else
                rstAlumno.Fields("cedula") = txtCedula.Text
                rstAlumno.Fields("nombre") = txtNombre.Text
                rstAlumno.Fields("apellido") = txtApellido.Text
                rstAlumno.Fields("fecha_nac") = dtpFechaNac.Value
                rstAlumno.Update
                GoTo Terminar2
            End If
        Case "Salir"
            Unload Me
    End Select
Exit Sub

Terminar:
    DeshabilitarBotones
    Frame1.Enabled = True
    txtCedula.SetFocus
    Exit Sub

Terminar2:
    rstAlumno.Close
    Set rstAlumno = Nothing
    Limpiar
    HabilitarBotones
    Frame1.Enabled = False
    cajaPestana.Enabled = False
End Sub
