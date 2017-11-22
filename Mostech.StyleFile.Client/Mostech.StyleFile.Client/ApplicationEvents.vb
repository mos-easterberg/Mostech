
Imports Mostech.Common.Logging
Imports Mostech.Common.Resources

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged

            Try
                If e.IsNetworkAvailable Then
                    Logger.Log(AppTexts.NETWORK_CONNECTION_RESTORED, UserSettings.LogSettings)
                Else
                    Logger.Log(AppTexts.NETWORK_CONNECTION_LOST, UserSettings.LogSettings)
                End If
            Catch ex As Exception
            Finally
            End Try

        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As System.EventArgs) Handles Me.Shutdown

            Try
                Logger.Log(AppTexts.APPLICATION_IS_SHUTTING_DOWN, UserSettings.LogSettings)
            Catch ex As Exception
            Finally
            End Try

        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

            Try
                'Logger.Log(AppTexts.APPLICATION_IS_STARTING, GlobalAppVariables.g_LogSettings)
            Catch ex As Exception
            Finally
            End Try

        End Sub

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

            Try
                Logger.Log(AppTexts.APPLICATION_RECEIVED_ANOTHER_INSTANCE_STARTUP_REQUEST, UserSettings.LogSettings)
            Catch ex As Exception
            Finally
            End Try

        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException

            Try
                Logger.Log(AppTexts.UNHANDLED_EXCEPTION_WAS_CAUGHT & e.Exception.Message, UserSettings.LogSettings)
                e.ExitApplication = True
            Catch ex As Exception
            Finally
            End Try

        End Sub

    End Class

End Namespace

