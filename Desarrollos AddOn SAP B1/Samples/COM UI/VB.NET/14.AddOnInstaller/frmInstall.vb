'//  SAP MANAGE DI API 2006 SDK Sample
'//****************************************************************************
'//
'//  File:      frmInstall.vb
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
'//****************************************************************************
'// This sample creates an add-on installer for SBO.
'// An installation for SBO should be build in a spesific way.
'// 1) It should be able to accept a command line parameter from SBO.
'//    This parameter is a string built from 2 strings devided by "|".
'//    The first string is the path recommended by SBO for installation folder.
'//    The second string is the location of "AddOnInstallAPI.dll".
'//    For example, a command line parameter that looks like this:
'//    "C:\MyAddon|C:\Program Files\SAP Manage\SAP Business One\AddOnInstallAPI.dll"
'//    Means that the recommended installation folder for this addon is "C:\MyAddon"
'//    and the location of "AddOnInstallAPI.dll" is - 
'//                 "C:\Program Files\SAP Manage\SAP Business One\AddOnInstallAPI.dll"
'// 2) When the installation is complete the installer must call the function 
'//    "EndInstall" from "AddOnInstallAPI.dll" to inform SBO the installation is complete.
'//    This dll contains 3 functions that can be used during the installation.
'//    The functions are: 
'//         1) EndInstall - Signals SBO that the installation is complete.
'//         2) SetAddOnFolder - Use it if you want to change the installation folder.
'//         3) RestartNeeded - Use it if your installation requires a restart, it will cause
'//            the SBO application to close itself after the installation is complete.
'//    All 3 functions return a 32 bit integer. There are 2 possible values for this integer.
'//    0 - Success, 1 - Failure.
'// 3) The installer must be one executable file.
'// 4) After your installer is ready you need to create an add-on registration file.
'//    In order to create it you have a utility - "Add-On Registration Data Creator"
'//    you can find it in -
'//       "..\SAP Manage\SAP Business One SDK\Tools\AddOnRegDataGen\AddOnRegDataGen.exe".
'//    This utility creates a file with the extention 'ard', you will be asked to 
'//    point to this file when you register your addon.

Imports System
Imports System.Runtime.InteropServices
Imports Microsoft.Win32


Public Class frmInstall
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblHeadLine As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDest As System.Windows.Forms.TextBox
    Friend WithEvents chkRestart As System.Windows.Forms.CheckBox
    Friend WithEvents chkDefaultFolder As System.Windows.Forms.CheckBox
    Friend WithEvents cmdInstall As System.Windows.Forms.Button
    Friend WithEvents FileWatcher As System.IO.FileSystemWatcher
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdInstall = New System.Windows.Forms.Button
        Me.lblHeadLine = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDest = New System.Windows.Forms.TextBox
        Me.chkRestart = New System.Windows.Forms.CheckBox
        Me.chkDefaultFolder = New System.Windows.Forms.CheckBox
        Me.FileWatcher = New System.IO.FileSystemWatcher
        Me.cmdCancel = New System.Windows.Forms.Button
        CType(Me.FileWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdInstall
        '
        Me.cmdInstall.Location = New System.Drawing.Point(24, 216)
        Me.cmdInstall.Name = "cmdInstall"
        Me.cmdInstall.Size = New System.Drawing.Size(96, 23)
        Me.cmdInstall.TabIndex = 1
        Me.cmdInstall.Text = "Install Add-on"
        '
        'lblHeadLine
        '
        Me.lblHeadLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblHeadLine.Location = New System.Drawing.Point(16, 16)
        Me.lblHeadLine.Name = "lblHeadLine"
        Me.lblHeadLine.Size = New System.Drawing.Size(416, 24)
        Me.lblHeadLine.TabIndex = 2
        Me.lblHeadLine.Text = "This Installer is a sample for Sap Business One. "
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "It will install a "" Hello World "" add-on"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Installation Folder recieved from SBO application"
        '
        'txtDest
        '
        Me.txtDest.Enabled = False
        Me.txtDest.Location = New System.Drawing.Point(24, 112)
        Me.txtDest.Name = "txtDest"
        Me.txtDest.Size = New System.Drawing.Size(472, 20)
        Me.txtDest.TabIndex = 5
        Me.txtDest.Text = ""
        '
        'chkRestart
        '
        Me.chkRestart.Location = New System.Drawing.Point(24, 176)
        Me.chkRestart.Name = "chkRestart"
        Me.chkRestart.TabIndex = 6
        Me.chkRestart.Text = "Ask for a restart"
        '
        'chkDefaultFolder
        '
        Me.chkDefaultFolder.Checked = True
        Me.chkDefaultFolder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDefaultFolder.Location = New System.Drawing.Point(24, 144)
        Me.chkDefaultFolder.Name = "chkDefaultFolder"
        Me.chkDefaultFolder.Size = New System.Drawing.Size(160, 24)
        Me.chkDefaultFolder.TabIndex = 7
        Me.chkDefaultFolder.Text = "Use path supplied by SBO"
        '
        'FileWatcher
        '
        Me.FileWatcher.EnableRaisingEvents = True
        Me.FileWatcher.SynchronizingObject = Me
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(128, 216)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(120, 23)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Cancel Installation"
        '
        'frmInstall
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(522, 263)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.chkDefaultFolder)
        Me.Controls.Add(Me.chkRestart)
        Me.Controls.Add(Me.txtDest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeadLine)
        Me.Controls.Add(Me.cmdInstall)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInstall"
        Me.Text = "Addon Installation Sample"
        CType(Me.FileWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Data members"
    Private sAddonName As String = "HelloWorld"
    Private strDll As String ' The path of "AddOnInstallAPI.dll"
    Private strDest As String ' Installation target path
    Private bFileCreated As Boolean ' True if the file was created
#End Region

#Region "Declarations"
    ' Declaring the functions inside "AddOnInstallAPI.dll"

    'EndInstall - Signals SBO that the installation is complete.
    Declare Function EndInstallEx Lib "AddOnInstallAPI.dll" (ByVal str As String, ByVal b As Boolean) As Int32
    'EndUnInstall - Signals SBO that the uninstallation is complete.
    Declare Function EndUninstall Lib "AddOnInstallAPI.dll" (ByVal str As String, ByVal b As Boolean) As Int32
    'SetAddOnFolder - Use it if you want to change the installation folder.
    Declare Function SetAddOnFolder Lib "AddOnInstallAPI.dll" (ByVal srrPath As String) As Int32
    'RestartNeeded - Use it if your installation requires a restart, it will cause
    'the SBO application to close itself after the installation is complete.
    Declare Function RestartNeeded Lib "AddOnInstallAPI.dll" () As Int32
    'the SBO application to close itself after the installation is complete.
    Declare Function B1Info Lib "AddOnInstallAPI.dll" (ByRef lpBuffer As String, ByVal length As Int32) As Int32

#End Region

#Region "Methods"

    ' Read the addon path from the registry
    Public Function ReadPath() As String
        Dim sAns As String
        Dim sErr As String = ""

        sAns = RegValue(RegistryHive.LocalMachine, "SOFTWARE", "HelloWorld", sErr)
        ReadPath = sAns
        If Not (sAns <> "") Then
            MessageBox.Show("This error occurred: " & sErr)
        End If
    End Function

    ' This Function reads values to the registry
    Public Function RegValue(ByVal Hive As RegistryHive, _
          ByVal Key As String, ByVal ValueName As String, _
          Optional ByRef ErrInfo As String = "") As String

        Dim objParent As RegistryKey
        Dim objSubkey As RegistryKey
        Dim sAns As String
        Select Case Hive
            Case RegistryHive.ClassesRoot
                objParent = Registry.ClassesRoot
            Case RegistryHive.CurrentConfig
                objParent = Registry.CurrentConfig
            Case RegistryHive.CurrentUser
                objParent = Registry.CurrentUser
            Case RegistryHive.DynData
                objParent = Registry.DynData
            Case RegistryHive.LocalMachine
                objParent = Registry.LocalMachine
            Case RegistryHive.PerformanceData
                objParent = Registry.PerformanceData
            Case RegistryHive.Users
                objParent = Registry.Users

        End Select

        Try
            objSubkey = objParent.OpenSubKey(Key)
            'if can't be found, object is not initialized
            If Not objSubkey Is Nothing Then
                sAns = (objSubkey.GetValue(ValueName))
            End If

        Catch ex As Exception

            ErrInfo = ex.Message
        Finally

            'if no error but value is empty, populate errinfo
            If ErrInfo = "" And sAns = "" Then
                ErrInfo = _
                   "No value found for requested registry key"
            End If
        End Try
        Return sAns
    End Function

    ' This Function writes values to the registry
    Public Function WriteToRegistry(ByVal _
    ParentKeyHive As RegistryHive, _
    ByVal SubKeyName As String, _
    ByVal ValueName As String, _
    ByVal Value As Object) As Boolean

        Dim objSubKey As RegistryKey
        Dim sException As String
        Dim objParentKey As RegistryKey
        Dim bAns As Boolean

        Try

            Select Case ParentKeyHive
                Case RegistryHive.ClassesRoot
                    objParentKey = Registry.ClassesRoot
                Case RegistryHive.CurrentConfig
                    objParentKey = Registry.CurrentConfig
                Case RegistryHive.CurrentUser
                    objParentKey = Registry.CurrentUser
                Case RegistryHive.DynData
                    objParentKey = Registry.DynData
                Case RegistryHive.LocalMachine
                    objParentKey = Registry.LocalMachine
                Case RegistryHive.PerformanceData
                    objParentKey = Registry.PerformanceData
                Case RegistryHive.Users
                    objParentKey = Registry.Users
            End Select

            'Open 
            objSubKey = objParentKey.OpenSubKey(SubKeyName, True)
            'create if doesn't exist
            If objSubKey Is Nothing Then
                objSubKey = objParentKey.CreateSubKey(SubKeyName)
            End If


            objSubKey.SetValue(ValueName, Value)
            bAns = True
        Catch ex As Exception
            bAns = False

        End Try

        Return True

    End Function

    ' This function extracts the given add-on into the path specified
    Private Sub ExtractFile(ByVal path As String)
        Try
            Dim AddonExeFile As IO.FileStream
            Dim thisExe As System.Reflection.Assembly
            thisExe = System.Reflection.Assembly.GetExecutingAssembly()
            Dim sTargetPath = path & "\" & sAddonName & ".exe"
            Dim sSourcePath = path & "\" & sAddonName & ".tmp"

            Dim file As System.IO.Stream

            file = thisExe.GetManifestResourceStream("Installer." & sAddonName & ".exe")

            ' Create a tmp file first, after file is extracted change to exe
            If IO.File.Exists(sSourcePath) Then
                IO.File.Delete(sSourcePath)
            End If
            AddonExeFile = IO.File.Create(sSourcePath)

            Dim buffer() As Byte
            ReDim buffer(file.Length)

            file.Read(buffer, 0, file.Length)
            AddonExeFile.Write(buffer, 0, file.Length)
            AddonExeFile.Close()

            If IO.File.Exists(sTargetPath) Then
                IO.File.Delete(sTargetPath)
            End If
            ' Change file extension to exe
            IO.File.Move(sSourcePath, sTargetPath)
            file.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' This procedure delets the addon files
    Private Sub UnInstall()
        Dim path As String
        path = ReadPath() ' Reads the addon path from the registry
        If path <> "" Then
            Try
                ' Delete the addon EXE file
                If IO.File.Exists(path & "\HelloWorld.exe") Then
                    IO.File.Delete(path & "\HelloWorld.exe")
                    MessageBox.Show(path & "\HelloWorld.exe was deleted")
                    EndUninstall("", True) ' Finished Uninstalling
                Else
                    MessageBox.Show(path & "\HelloWorld.exe was not found")
                End If
            Catch
                MessageBox.Show(path & " - ERROR UNINSTALLING")
            End Try
        Else
            MessageBox.Show("Path not found")
        End If
        ' Terminate the application
        GC.Collect()
        End
    End Sub

    ' This procedure copies the addon exe file to the installation folder        
    Private Sub Install()
        Try
            Environment.CurrentDirectory = strDll ' For Dll function calls will work

            If chkDefaultFolder.Checked = False Then ' Change the installation folder
                SetAddOnFolder(txtDest.Text)
                strDest = txtDest.Text
            End If

            If Not (IO.Directory.Exists(strDest)) Then
                IO.Directory.CreateDirectory(strDest) ' Create installation folder
            End If

            FileWatcher.Path = strDest
            FileWatcher.EnableRaisingEvents = True

            ExtractFile(strDest) ' Extract add-on to installation folder

            While bFileCreated = False
                Application.DoEvents()
                'Don't continue running until the file is copied...
            End While

            If chkRestart.Checked Then
                RestartNeeded() ' Inform SBO the restart is needed
            End If
            EndInstallEx("", True) ' Inform SBO the installation ended successfully
            'Write installation Folder to registry
            Dim bAns As Boolean

            bAns = WriteToRegistry(RegistryHive.LocalMachine, "SOFTWARE", "HelloWorld", strDest)

            MessageBox.Show("Installation ended successfully", "Installation ended successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Windows.Forms.Application.Exit() ' Exit the installer
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Addon Installer")
        End Try
    End Sub

#End Region

#Region "Events"
    Private Sub frmInstall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Dim strAppPath As String

            ' The command line parameters, seperated by '|' will be broken to this array
            Dim strCmdLineElements(2) As String

            Dim strCmdLine As String ' The whole command line

            Dim NumOfParams As Integer 'The number of parameters in the command line (should be 2)


            NumOfParams = Environment.GetCommandLineArgs.Length

            If NumOfParams = 2 Then
                strCmdLine = Environment.GetCommandLineArgs.GetValue(1)
                If strCmdLine.ToUpper = "/U" Then
                    UnInstall()
                End If
                strCmdLineElements = strCmdLine.Split("|")

                ' Get Install destination Folder
                strDest = strCmdLineElements.GetValue(0)
                txtDest.Text = strDest

                ' Get the "AddOnInstallAPI.dll" path
                strDll = strCmdLineElements.GetValue(1)
                strDll = strDll.Remove((strDll.Length - 19), 19) ' Only the path is needed
            Else
                MessageBox.Show("This installer must be run from Sap Business One", _
                                "Incorrect installation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Windows.Forms.Application.Exit()
            End If
        Catch ex As Exception
            ShowError(ex)
        End Try
    End Sub

    Private Sub cmdInstall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInstall.Click
        Install()
    End Sub
    Private Sub chkDefaultFolder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefaultFolder.CheckedChanged
        txtDest.Enabled = Not (chkDefaultFolder.Checked)
    End Sub

    ' This event happens when the addon exe file is renamed to exe extention
    Private Sub FileWatcher_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles FileWatcher.Renamed
        bFileCreated = True
        FileWatcher.EnableRaisingEvents = False
    End Sub

    Public Sub ShowError(ByVal ex As Exception)
        MsgBox(ex.Message & vbNewLine & "Source:" & ex.StackTrace, MsgBoxStyle.Information, "Addon Installer")
    End Sub
#End Region

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        EndInstallEx("", False) ' Inform SBO the installation was not complete
        MessageBox.Show("Installation was canceled", "Installation was canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Windows.Forms.Application.Exit() ' Exit the installer
    End Sub

End Class

