﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.269
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ebbb")>  _
        Public Property Password() As String
            Get
                Return CType(Me("Password"),String)
            End Get
            Set
                Me("Password") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DemoCompany")>  _
        Public ReadOnly Property LicenseCompany() As String
            Get
                Return CType(Me("LicenseCompany"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2012-01-23")>  _
        Public ReadOnly Property LicenseStartDate() As String
            Get
                Return CType(Me("LicenseStartDate"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("g6414515353")>  _
        Public ReadOnly Property LicenseEndDate() As String
            Get
                Return CType(Me("LicenseEndDate"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("k:")>  _
        Public ReadOnly Property LicenseUsers() As String
            Get
                Return CType(Me("LicenseUsers"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("127.0.0.1")>  _
        Public Property DBServer() As String
            Get
                Return CType(Me("DBServer"),String)
            End Get
            Set
                Me("DBServer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3306")>  _
        Public Property DBPort() As Integer
            Get
                Return CType(Me("DBPort"),Integer)
            End Get
            Set
                Me("DBPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("stylefile_dev")>  _
        Public Property DBName() As String
            Get
                Return CType(Me("DBName"),String)
            End Get
            Set
                Me("DBName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("root")>  _
        Public Property DBUserID() As String
            Get
                Return CType(Me("DBUserID"),String)
            End Get
            Set
                Me("DBUserID") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("iwttyxvq")>  _
        Public Property DBPassword() As String
            Get
                Return CType(Me("DBPassword"),String)
            End Get
            Set
                Me("DBPassword") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("60")>  _
        Public Property DBTimeOutSeconds() As Integer
            Get
                Return CType(Me("DBTimeOutSeconds"),Integer)
            End Get
            Set
                Me("DBTimeOutSeconds") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("MySQL")>  _
        Public ReadOnly Property DBVendor() As String
            Get
                Return CType(Me("DBVendor"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Mostech\StyleFile\help\StyleFile-v1.03_Users_Guide-swe.pdf")>  _
        Public Property HelpFile() As String
            Get
                Return CType(Me("HelpFile"),String)
            End Get
            Set
                Me("HelpFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ConfirmAppExit() As Boolean
            Get
                Return CType(Me("ConfirmAppExit"),Boolean)
            End Get
            Set
                Me("ConfirmAppExit") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-32768")>  _
        Public Property RequiredFieldsColor() As String
            Get
                Return CType(Me("RequiredFieldsColor"),String)
            End Get
            Set
                Me("RequiredFieldsColor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property DisplayActiveOnly() As Boolean
            Get
                Return CType(Me("DisplayActiveOnly"),Boolean)
            End Get
            Set
                Me("DisplayActiveOnly") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Mostech\StyleFile\log\")>  _
        Public ReadOnly Property LogFolderPath() As String
            Get
                Return CType(Me("LogFolderPath"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property LogThrowException() As Boolean
            Get
                Return CType(Me("LogThrowException"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("StyleFile v1.1")>  _
        Public ReadOnly Property ApplicationName() As String
            Get
                Return CType(Me("ApplicationName"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("StyleFile-log.txt")>  _
        Public ReadOnly Property LogFileName() As String
            Get
                Return CType(Me("LogFileName"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Mostech\StyleFile\db\dump-stylefile_db.cmd")>  _
        Public Property BackupScriptPath() As String
            Get
                Return CType(Me("BackupScriptPath"),String)
            End Get
            Set
                Me("BackupScriptPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Mostech\StyleFile\images\jobs\repository\")>  _
        Public Property JobImagesRepositoryPath() As String
            Get
                Return CType(Me("JobImagesRepositoryPath"),String)
            End Get
            Set
                Me("JobImagesRepositoryPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Mostech\StyleFile\images\jobs\source\")>  _
        Public Property JobImagesSourcePath() As String
            Get
                Return CType(Me("JobImagesSourcePath"),String)
            End Get
            Set
                Me("JobImagesSourcePath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Mostech\StyleFile\reports\result\")>  _
        Public Property ReportResultFolder() As String
            Get
                Return CType(Me("ReportResultFolder"),String)
            End Get
            Set
                Me("ReportResultFolder") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://www.mostech.fi/")>  _
        Public ReadOnly Property MostechWebSiteURL() As String
            Get
                Return CType(Me("MostechWebSiteURL"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public ReadOnly Property MostechOnFacebookURL() As String
            Get
                Return CType(Me("MostechOnFacebookURL"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowToolTips() As Boolean
            Get
                Return CType(Me("ShowToolTips"),Boolean)
            End Get
            Set
                Me("ShowToolTips") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Mostech\StyleFile\db\dumps\")>  _
        Public Property BackupFolderPath() As String
            Get
                Return CType(Me("BackupFolderPath"),String)
            End Get
            Set
                Me("BackupFolderPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-32768")>  _
        Public Property FormBackColor() As String
            Get
                Return CType(Me("FormBackColor"),String)
            End Get
            Set
                Me("FormBackColor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-32768")>  _
        Public Property ButtonColor() As String
            Get
                Return CType(Me("ButtonColor"),String)
            End Get
            Set
                Me("ButtonColor") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property LogEmptyOnStartup() As Boolean
            Get
                Return CType(Me("LogEmptyOnStartup"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("+358")>  _
        Public Property TelephoneInitialText() As String
            Get
                Return CType(Me("TelephoneInitialText"),String)
            End Get
            Set
                Me("TelephoneInitialText") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Mostech\StyleFile\printing\jobs\")>  _
        Public Property JobPrintFolderPath() As String
            Get
                Return CType(Me("JobPrintFolderPath"),String)
            End Get
            Set
                Me("JobPrintFolderPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("UNICODE")>  _
        Public ReadOnly Property FileEncoding() As String
            Get
                Return CType(Me("FileEncoding"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("info@mostech.fi")>  _
        Public Property EmailReceiverAddress() As String
            Get
                Return CType(Me("EmailReceiverAddress"),String)
            End Get
            Set
                Me("EmailReceiverAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("smtp.netikka.fi")>  _
        Public Property EmailServerName() As String
            Get
                Return CType(Me("EmailServerName"),String)
            End Get
            Set
                Me("EmailServerName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("25")>  _
        Public Property EmailServerPort() As Integer
            Get
                Return CType(Me("EmailServerPort"),Integer)
            End Get
            Set
                Me("EmailServerPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property EmailEnableSSL() As Boolean
            Get
                Return CType(Me("EmailEnableSSL"),Boolean)
            End Get
            Set
                Me("EmailEnableSSL") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("info@mostech.fi")>  _
        Public Property EmailFromAddress() As String
            Get
                Return CType(Me("EmailFromAddress"),String)
            End Get
            Set
                Me("EmailFromAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("30")>  _
        Public Property EmailSendTimeoutSeconds() As Integer
            Get
                Return CType(Me("EmailSendTimeoutSeconds"),Integer)
            End Get
            Set
                Me("EmailSendTimeoutSeconds") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4")>  _
        Public Property NrOfJobsPerPrint() As Integer
            Get
                Return CType(Me("NrOfJobsPerPrint"),Integer)
            End Get
            Set
                Me("NrOfJobsPerPrint") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Mostech.StyleFile.Client.My.MySettings
            Get
                Return Global.Mostech.StyleFile.Client.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
