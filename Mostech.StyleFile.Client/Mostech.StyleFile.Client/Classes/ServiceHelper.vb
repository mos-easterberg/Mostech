
Imports Mostech.StyleFile.Service
Imports Mostech.Common
Imports Mostech.StyleFile.Entity

Imports System.Text

Public Class ServiceHelper

    Public Shared Function TranslateKeyToValue(ByVal sKeyField As String, _
                                               ByVal sKeyValue As String, _
                                               ByVal sReturnField As String, _
                                               ByVal entity As AppEnums.EntityEnum) As String

        Dim ds As DataSet
        Dim sSQL As String = ""
        Dim sRet As String = ""

        Try
            Select Case entity
                Case AppEnums.EntityEnum.CUSTOMER
                    Dim service As New CustomerService()
                    sSQL = "select " & sReturnField & " from " & UserSettings.DBAccessSettings.DBName & _
                        ".customer where " & sKeyField & " = '" & sKeyValue & "'"
                    ds = service.FetchBySQLAsDataSet(sSQL, UserSettings.DBAccessSettings)
                    sRet = ds.Tables(0).Rows(0).Item(0).ToString

                Case AppEnums.EntityEnum.JOB

                Case AppEnums.EntityEnum.STYLIST
                    Dim service As New StylistService()
                    sSQL = "select " & sReturnField & " from " & UserSettings.DBAccessSettings.DBName & _
                        ".stylist where " & sKeyField & " = '" & sKeyValue & "'"
                    ds = service.FetchBySQLAsDataSet(sSQL, UserSettings.DBAccessSettings)
                    sRet = ds.Tables(0).Rows(0).Item(0).ToString

                Case AppEnums.EntityEnum.CATEGORY
                    Dim service As New CategoryService()
                    sSQL = "select " & sReturnField & " from " & UserSettings.DBAccessSettings.DBName & _
                        ".category where " & sKeyField & " = '" & sKeyValue & "'"
                    ds = service.FetchBySQLAsDataSet(sSQL, UserSettings.DBAccessSettings)
                    sRet = ds.Tables(0).Rows(0).Item(0).ToString

            End Select

        Catch ex As Exception
            Throw ex
        Finally
            ds = Nothing
        End Try

        Return sRet

    End Function

    Public Shared Function GetCategories(ByVal type As AppEnums.CategoryTypeEnum, _
                                         ByVal bActiveOnly As Boolean) As Collection

        Dim service As CategoryService
        Dim sb As New StringBuilder
        Dim coll As Collection

        Try
            service = New CategoryService()

            sb.Append("select * from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".category")

            Select Case type
                Case AppEnums.CategoryTypeEnum.ALL : sb.Append(" where 1=1")
                Case AppEnums.CategoryTypeEnum.CUSTOMER : sb.Append(" where ct_type='Kund'")
                Case AppEnums.CategoryTypeEnum.JOB : sb.Append(" where ct_type='Arbete'")
                Case AppEnums.CategoryTypeEnum.PROFESSION : sb.Append(" where ct_type='Profession'")
                Case AppEnums.CategoryTypeEnum.VATPERCENTAGE : sb.Append(" where ct_type='Momsprocent'")
                Case AppEnums.CategoryTypeEnum.EMPLOYMENT : sb.Append(" where ct_type='Anställningstyp'")
                Case AppEnums.CategoryTypeEnum.DISTRICT : sb.Append(" where ct_type='Stadsdel'")
            End Select

            If bActiveOnly Then
                sb.Append(" and ct_active=1")
            End If

            sb.Append(" order by ct_value")

            coll = service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings)
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return coll

    End Function

    Public Shared Function LoadJobFromDB(ByVal sKey As String,
                                         ByVal loadType As AppEnums.EntityLoadTypeEnum) As Job

        Dim coll As Collection = Nothing
        Dim jb As Job = Nothing
        Dim service As JobService = Nothing
        Dim sb As New StringBuilder

        Try
            service = New JobService

            Select Case loadType

                Case AppEnums.EntityLoadTypeEnum.KEYS
                    sb.Append("select * from ")
                    sb.Append(UserSettings.DBAccessSettings.DBName)
                    sb.Append(".job where jb_key='")
                    sb.Append(sKey)
                    sb.Append("'")

                Case AppEnums.EntityLoadTypeEnum.VALUES
                    sb.Append("select")
                    sb.Append(" jb_key, jb_id, ct_value as jb_category, jb_date, jb_starttime,")
                    sb.Append(" jb_endtime, jb_duration, concat(st_lastname, ' ', st_firstname) as jb_stylist,")
                    sb.Append(" jb_priceinclvat, jb_vatpercentage, jb_priceexclvat, jb_description,")
                    sb.Append(" concat(cu_lastname, ' ', cu_firstname) as jb_customer,")
                    sb.Append(" jb_created, jb_createdby, jb_updated, jb_updatedby")
                    sb.Append(" from")
                    sb.Append(" " & UserSettings.DBAccessSettings.DBName & ".job,")
                    sb.Append(" " & UserSettings.DBAccessSettings.DBName & ".category,")
                    sb.Append(" " & UserSettings.DBAccessSettings.DBName & ".customer,")
                    sb.Append(" " & UserSettings.DBAccessSettings.DBName & ".stylist")
                    sb.Append(" where jb_key = '" & sKey & "'")
                    sb.Append(" and jb_category = ct_key")
                    sb.Append(" and jb_customer = cu_key")
                    sb.Append(" and jb_stylist = st_key")
            End Select

            coll = service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings)
            jb = DirectCast(coll.Item(1), Job)

        Catch ex As Exception
            Throw ex
        Finally
            coll = Nothing
            service = Nothing
        End Try

        Return jb

    End Function

    Public Shared Function LoadJobsFromDB(ByVal sCustomerKey As String) As Collection

        Dim coll As Collection
        Dim service As JobService
        Dim sb As New StringBuilder

        Try
            service = New JobService()
            sb.Append("select * from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".job where jb_customer='")
            sb.Append(sCustomerKey)
            sb.Append("'")
            sb.Append(" order by jb_date, jb_starttime")
            coll = service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings)
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return coll

    End Function

    Public Shared Function LoadImagesFromDB(ByVal sJobKey As String) As Collection

        Dim service As ImageService
        Dim sb As New StringBuilder

        Try
            service = New ImageService()
            sb.Append("select * from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".image where im_parentkey='")
            sb.Append(sJobKey)
            sb.Append("' order by im_filename")
            Return service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings)
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return Nothing

    End Function

    Public Shared Function LoadStylistFromDB(ByVal sKey As String) As Stylist

        Dim coll As Collection
        Dim s As Stylist
        Dim sb As New StringBuilder
        Dim service As StylistService

        Try
            service = New StylistService()
            sb.Append("select * from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".stylist where st_key='")
            sb.Append(sKey)
            sb.Append("'")
            coll = service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings)
            s = DirectCast(coll.Item(1), Stylist)
        Catch ex As Exception
            Throw ex
        Finally
            coll = Nothing
            service = Nothing
        End Try

        Return s

    End Function

    Public Shared Function LoadStylistsFromDB(ByVal bActiveOnly As Boolean) As Collection

        Dim coll As Collection
        Dim service As StylistService
        Dim sb As New StringBuilder

        Try
            service = New StylistService()
            sb.Append("select * from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".stylist where st_active=" & bActiveOnly)
            sb.Append(" order by st_lastname")
            coll = service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings)
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return coll

    End Function

    Public Shared Function LoadCustomersFromDB(ByVal sFirstLetterInLastName As String, ByVal bActiveOnly As Boolean) As Collection

        Dim service As CustomerService
        Dim coll As Collection
        Dim sb As New StringBuilder

        Try
            service = New CustomerService()
            sb.Append("select * from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".customer")
            sb.Append(" where cu_lastname like '" & sFirstLetterInLastName & "%'")
            If bActiveOnly Then sb.Append(" and cu_active=" & bActiveOnly)
            sb.Append(" order by cu_lastname")
            coll = service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings)
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return coll

    End Function

    Public Shared Function LoadCustomersFromDBDynamically(ByVal sSearchField As String, _
                                                     ByVal sSearchCriteria As String, _
                                                     ByVal bActiveOnly As Boolean) As Collection

        Dim service As CustomerService
        Dim coll As Collection
        Dim sb As New StringBuilder

        Try
            service = New CustomerService()
            sb.Append("select * from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".customer")
            sb.Append(" where " & sSearchField & " like '" & sSearchCriteria & "%'")
            If bActiveOnly Then sb.Append(" and cu_active=" & bActiveOnly)
            sb.Append(" order by " & sSearchField)
            'sb.Append(" order by cu_lastname")
            coll = service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings)
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return coll

    End Function

    Public Shared Function LoadReportFromDB(ByVal sKey As String) As Report

        Dim rep As Report
        Dim service As ReportService
        Dim sb As New StringBuilder

        Try
            service = New ReportService()
            sb.Append("select * from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".report where rp_key='")
            sb.Append(sKey)
            sb.Append("'")
            rep = DirectCast(service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings).Item(1), Report)
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return rep

    End Function

    Public Shared Function LoadReportsFromDB() As Collection

        Dim coll As Collection
        Dim service As ReportService
        Dim sb As New StringBuilder

        Try
            service = New ReportService()
            sb.Append("select * from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".report ")
            sb.Append("order by rp_name")
            coll = service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings)
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return coll

    End Function

End Class
