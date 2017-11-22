
Imports Mostech.Common
Imports Mostech.Common.Entity
Imports Mostech.Common.Settings
Imports Mostech.Common.Logging
Imports Mostech.StyleFile.Entity

Imports System.IO
Imports System.Text
Imports System.Drawing.Printing

Public Class PrintHelper

    Private Shared printFont As Font = Nothing
    Private Shared pd As PrintDocument = Nothing
    Private Shared streamToPrint As StreamReader = Nothing

    Public Shared Function PrintJob(ByVal printJobs As Collection,
                                    ByVal sCustomerID As String,
                                    ByVal sEncoding As String) As Boolean

        Dim bContinue As Boolean = False
        Dim sFilePath As String = ""
        Dim sb As New StringBuilder
        Dim iJobCounter As Integer = 0
        Dim iTotalNrOfJobCounter As Integer = 0
        Dim iBatchCounter As Integer = 0
        Dim iFileDeletionCounter As Integer = 0

        Try

            'init
            '-------------------------------------------------
            bContinue = True
            iBatchCounter = 1

            For Each pj As PrintJob In printJobs
                iJobCounter += 1
                iTotalNrOfJobCounter += 1
                sb.Append(pj.Data & vbNewLine)

                If iJobCounter = UserSettings.UserAppSettings.NrOfJobsPerPrint OrElse
                    iJobCounter = printJobs.Count OrElse
                    iTotalNrOfJobCounter = printJobs.Count Then

                    sFilePath = Toolbox.FileUtils.CombinePath(UserSettings.UserAppSettings.JobPrintFolderPath, sCustomerID) & "-" & iBatchCounter & ".txt"
                    Logger.Log("Creating text file for jobs...", UserSettings.LogSettings)
                    Toolbox.FileUtils.CreateFile(sFilePath)
                    Logger.Log("File created: " & sFilePath, UserSettings.LogSettings)
                    Logger.Log("Writing jobs to file...", UserSettings.LogSettings)
                    Toolbox.FileUtils.WriteFile(sFilePath, sb.ToString, sEncoding)
                    Logger.Log("Done.", UserSettings.LogSettings)
                    sb.Clear()
                    Logger.Log("Printing file...", UserSettings.LogSettings)
                    PrintHelper._print(sFilePath)
                    Toolbox.ThreadUtils.Sleep(1)
                    Logger.Log("Done.", UserSettings.LogSettings)
                    Logger.Log("Deleting file, re-trying 5 times...", UserSettings.LogSettings)
                    iFileDeletionCounter = Toolbox.FileUtils.DeleteFile(sFilePath, 5, 1)
                    Logger.Log("File deleted at attempt: " & iFileDeletionCounter, UserSettings.LogSettings)
                    iJobCounter = 0
                    iBatchCounter += 1
                End If
            Next

        Catch ex As Exception
            bContinue = False
            Throw ex
        Finally
        End Try

        Return bContinue

    End Function

    Private Shared Function _print(ByVal sFilePath As String) As Boolean

        Dim b As Boolean = False

        Try
            streamToPrint = New StreamReader(sFilePath)
            printFont = New Font("Arial", 10)
            pd = New PrintDocument
            AddHandler pd.PrintPage, AddressOf PrintHelper.pd_PrintPage
            pd.Print()
            streamToPrint.Close()
            b = True
        Catch ex As Exception
            b = False
            Throw ex
        Finally
        End Try

        Return b

    End Function

    Private Shared Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim count As Integer = 0
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim line As String = Nothing

        Try

            ' Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)

            ' Print each line of the file.
            While count < linesPerPage
                line = streamToPrint.ReadLine()
                If line Is Nothing Then
                    Exit While
                End If
                yPos = topMargin + count * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
                count += 1
            End While

            ' If more lines exist, print another page.
            If (line IsNot Nothing) Then
                ev.HasMorePages = True
            Else
                ev.HasMorePages = False
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
