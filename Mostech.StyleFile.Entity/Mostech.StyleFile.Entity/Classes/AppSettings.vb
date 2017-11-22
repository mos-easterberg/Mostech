
Imports System.Text

Public Class AppSettings
    Inherits Entity
    Implements IEntity

    Public Sub New()
    End Sub

    Public Property ApplicationName As String
    Public Property BackupScriptPath As String
    Public Property BackupFolderPath As String
    Public Property ConfirmAppExit As Boolean
    Public Property ConnectionString As String
    Public Property DisplayActiveOnly As Boolean
    Public Property HelpFile As String
    Public Property JobImagesRepositoryPath As String
    Public Property JobImagesSourcePath As String
    Public Property Password As String
    Public Property ReportResultFolder As String
    Public Property RequiredFieldsColor As String
    Public Property MostechWebSiteURL As String
    Public Property MostechOnFacebookURL As String
    Public Property ShowToolTips As Boolean
    Public Property FormBackColor As String
    Public Property ButtonColor As String
    Public Property TelephoneInitialText As String
    Public Property JobPrintFolderPath As String
    Public Property FileEncoding As String
    Public Property NrOfJobsPerPrint As Integer

    Public Overrides Function ToString() As String Implements IEntity.ToString

        Dim sb As StringBuilder = Nothing

        Try
            sb = New StringBuilder
            sb.AppendLine("ApplicationName: " & Me.ApplicationName)
            sb.AppendLine("BackupScriptPath: " & Me.BackupScriptPath)
            sb.AppendLine("BackupFolderPath: " & Me.BackupFolderPath)
            sb.AppendLine("ConfirmAppExit: " & Me.ConfirmAppExit)
            sb.AppendLine("ConnectionString: " & Me.ConnectionString)
            sb.AppendLine("DisplayActiveOnly: " & Me.DisplayActiveOnly)
            sb.AppendLine("HelpFile: " & Me.HelpFile)
            sb.AppendLine("JobImagesRepositoryPath: " & Me.JobImagesRepositoryPath)
            sb.AppendLine("JobImagesSourcePath: " & Me.JobImagesSourcePath)
            sb.AppendLine("Password: " & Me.Password)
            sb.AppendLine("ReportResultFolder: " & Me.ReportResultFolder)
            sb.AppendLine("RequiredFieldsColor: " & Me.RequiredFieldsColor)
            sb.AppendLine("MostechWebSiteURL: " & Me.MostechWebSiteURL)
            sb.AppendLine("MostechOnFacebookURL: " & Me.MostechOnFacebookURL)
            sb.AppendLine("ShowToolTips: " & Me.ShowToolTips)
            sb.AppendLine("FormBackColor: " & Me.FormBackColor)
            sb.AppendLine("ButtonColor: " & Me.ButtonColor)
            sb.AppendLine("TelephoneInitialText: " & Me.TelephoneInitialText)
            sb.AppendLine("JobPrintFolderPath: " & Me.JobPrintFolderPath)
            sb.AppendLine("FileEncoding: " & Me.FileEncoding)
            sb.AppendLine("NrOfJobsPerPrint: " & Me.NrOfJobsPerPrint)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return sb.ToString

    End Function

End Class
