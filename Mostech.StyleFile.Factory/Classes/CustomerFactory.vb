
Imports Mostech.Common
Imports Mostech.StyleFile.Entity
Imports Mostech.Common.Entity

Imports System.Text

Public Class CustomerFactory
    Implements IFactory

    Public Function InstantiateEntity(ByVal data As DataSet,
                                      ByVal type As FactoryEnums.InstantionType,
                                      ByVal db As DBAccess) As Collection Implements IFactory.InstantiateEntity

        Dim coll As New Collection
        Dim cust As Customer

        Try
            For Each r In data.Tables(0).Rows
                cust = New Customer

                cust.Key = r.Item("cu_key").ToString
                cust.ID = r.Item("cu_id").ToString
                cust.Category = r.Item("cu_category").ToString
                cust.LastName = r.Item("cu_lastname").ToString
                cust.FirstName = r.Item("cu_firstname").ToString
                cust.DateOfBirth = r.Item("cu_dob").ToString
                cust.Address = r.Item("cu_address").ToString
                cust.District = r.Item("cu_district").ToString
                cust.PostalCode = Toolbox.ConversionUtils.ParseInteger(r.Item("cu_postalcode").ToString)
                cust.City = r.Item("cu_city").ToString
                cust.TelephoneMobile = r.Item("cu_telmobile").ToString
                cust.TelephoneHome = r.Item("cu_telhome").ToString
                cust.TelephoneWork = r.Item("cu_telwork").ToString
                cust.EmailAddress = r.Item("cu_email").ToString
                cust.AllowSMS = r.Item("cu_allowsms").ToString
                cust.AllowEmail = r.Item("cu_allowemail").ToString
                cust.AllowMail = r.Item("cu_allowmail").ToString
                cust.Allergy = r.Item("cu_allergy").ToString
                cust.MiscInfo = r.Item("cu_miscinfo").ToString
                cust.Created = r.Item("cu_created").ToString
                cust.CreatedBy = r.Item("cu_createdby").ToString
                cust.Updated = r.Item("cu_updated").ToString
                cust.UpdatedBy = r.Item("cu_updatedby").ToString
                cust.Active = r.Item("cu_active").ToString

                coll.Add(cust)
            Next
        Catch ex As Exception
            Throw
        Finally
            cust = Nothing
        End Try

        Return coll

    End Function

    Public Function CreateSQL(ByVal entity As Entity.Entity, _
                              ByVal dbOp As FactoryEnums.DBOperation,
                              ByVal db As DBAccess) As String Implements IFactory.CreateSQL

        Dim cust As Customer
        Dim sb As New StringBuilder
        Dim sInsertDel1 As String = "'"
        Dim sInsertDel2 As String = "',"
        Dim sUpdateDel1 As String = "='"
        Dim sUpdateDel2 As String = "',"

        Try
            cust = DirectCast(entity, Customer)
            Select Case dbOp
                Case FactoryEnums.DBOperation.INSERT
                    sb.Append("insert into ")
                    sb.Append(db.DBName)
                    sb.Append(".customer(")
                    sb.Append("cu_key, cu_category, cu_lastname, cu_firstname, cu_dob, cu_address, cu_postalcode, ")
                    sb.Append("cu_city, cu_telmobile, cu_telhome, cu_telwork, cu_email, cu_allowsms, ")
                    sb.Append("cu_allowemail, cu_allowmail, cu_allergy, cu_miscinfo, cu_created, cu_createdby, ")
                    sb.Append("cu_active, cu_district")
                    sb.Append(") values(")
                    sb.Append(sInsertDel1 & cust.Key & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.Category & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.LastName & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.FirstName & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.DateOfBirth & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.Address & sInsertDel2)
                    sb.Append(cust.PostalCode & ",")
                    sb.Append(sInsertDel1 & cust.City & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.TelephoneMobile & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.TelephoneHome & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.TelephoneWork & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.EmailAddress & sInsertDel2)
                    sb.Append(cust.AllowSMS & ",")
                    sb.Append(cust.AllowEmail & ",")
                    sb.Append(cust.AllowMail & ",")
                    sb.Append(sInsertDel1 & cust.Allergy & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.MiscInfo & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.Created & sInsertDel2)
                    sb.Append(sInsertDel1 & cust.CreatedBy & sInsertDel2)
                    sb.Append(cust.Active & ",")
                    sb.Append(sInsertDel1 & cust.District & "')")

                Case FactoryEnums.DBOperation.UPDATE
                    sb.Append("update ")
                    sb.Append(db.DBName)
                    sb.Append(".customer set ")
                    sb.Append("cu_category" & sUpdateDel1 & cust.Category & sUpdateDel2)
                    sb.Append("cu_lastname" & sUpdateDel1 & cust.LastName & sUpdateDel2)
                    sb.Append("cu_firstname" & sUpdateDel1 & cust.FirstName & sUpdateDel2)
                    sb.Append("cu_dob" & sUpdateDel1 & cust.DateOfBirth & sUpdateDel2)
                    sb.Append("cu_address" & sUpdateDel1 & cust.Address & sUpdateDel2)
                    sb.Append("cu_postalcode=" & cust.PostalCode & ",")
                    sb.Append("cu_city" & sUpdateDel1 & cust.City & sUpdateDel2)
                    sb.Append("cu_telmobile" & sUpdateDel1 & cust.TelephoneMobile & sUpdateDel2)
                    sb.Append("cu_telhome" & sUpdateDel1 & cust.TelephoneHome & sUpdateDel2)
                    sb.Append("cu_telwork" & sUpdateDel1 & cust.TelephoneWork & sUpdateDel2)
                    sb.Append("cu_email" & sUpdateDel1 & cust.EmailAddress & sUpdateDel2)
                    sb.Append("cu_allowsms=" & cust.AllowSMS & ",")
                    sb.Append("cu_allowemail=" & cust.AllowEmail & ",")
                    sb.Append("cu_allowmail=" & cust.AllowMail & ",")
                    sb.Append("cu_allergy" & sUpdateDel1 & cust.Allergy & sUpdateDel2)
                    sb.Append("cu_miscinfo" & sUpdateDel1 & cust.MiscInfo & sUpdateDel2)
                    sb.Append("cu_updated" & sUpdateDel1 & cust.Updated & sUpdateDel2)
                    sb.Append("cu_updatedby" & sUpdateDel1 & cust.UpdatedBy & sUpdateDel2)
                    sb.Append("cu_active=" & cust.Active & ", ")
                    sb.Append("cu_district" & sUpdateDel1 & cust.District & "' ")
                    sb.Append("where cu_key='" & cust.Key & "'")

            End Select
        Catch ex As Exception
            Throw
        End Try

        Debug.WriteLine("SQL: " & sb.ToString)
        Return sb.ToString

    End Function

    Public Function CreateSQL(ByVal sKey As String, _
                              ByVal dbOp As FactoryEnums.DBOperation,
                              ByVal db As DBAccess) As String Implements IFactory.CreateSQL

        Dim sb As New StringBuilder

        Try
            Select Case dbOp
                Case FactoryEnums.DBOperation.DELETE
                    sb.Append("delete from ")
                    sb.Append(db.DBName)
                    sb.Append(".customer where cu_key='")
                    sb.Append(sKey)
                    sb.Append("'")
            End Select
        Catch ex As Exception
            Throw
        End Try

        Return sb.ToString

    End Function

End Class
