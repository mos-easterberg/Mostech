
Imports Mostech.Common

Imports Mostech.StyleFile.Entity
Imports Mostech.Common.Entity

Imports System.Text

Public Class StylistFactory
    Implements IFactory

    Public Function InstantiateEntity(ByVal data As DataSet,
                                      ByVal type As FactoryEnums.InstantionType,
                                      ByVal db As DBAccess) As Collection Implements IFactory.InstantiateEntity

        Dim coll As New Collection
        Dim s As Stylist

        Try
            For Each r In data.Tables(0).Rows
                s = New Stylist

                s.Key = r.Item("st_key").ToString
                s.ID = r.Item("st_id").ToString
                s.Employment = r.Item("st_employmenttype").ToString
                s.Profession = r.Item("st_profession").ToString
                s.LastName = r.Item("st_lastname").ToString
                s.FirstName = r.Item("st_firstname").ToString
                s.Address = r.Item("st_address").ToString
                s.PostalCode = Toolbox.ConversionUtils.ParseInteger(r.Item("st_postalcode").ToString)
                s.City = r.Item("st_city").ToString
                s.TelephoneMobile = r.Item("st_telmobile").ToString
                s.TelephoneHome = r.Item("st_telhome").ToString
                s.TelephoneWork = r.Item("st_telwork").ToString
                s.EmailAddress = r.Item("st_email").ToString
                s.Allergy = r.Item("st_allergy").ToString
                s.MiscInfo = r.Item("st_miscinfo").ToString
                s.Created = r.Item("st_created").ToString
                s.CreatedBy = r.Item("st_createdby").ToString
                s.Updated = r.Item("st_updated").ToString
                s.UpdatedBy = r.Item("st_updatedby").ToString
                s.Active = r.Item("st_active").ToString

                coll.Add(s)
            Next
        Catch ex As Exception
            Throw
        End Try

        Return coll

    End Function

    Public Function CreateSQL(ByVal entity As Entity.Entity, _
                              ByVal dbOp As FactoryEnums.DBOperation,
                              ByVal db As DBAccess) As String Implements IFactory.CreateSQL

        Dim s As Stylist
        Dim sb As New StringBuilder
        Dim sInsertDel1 As String = "'"
        Dim sInsertDel2 As String = "',"
        Dim sUpdateDel1 As String = "='"
        Dim sUpdateDel2 As String = "',"

        Try
            s = DirectCast(entity, Stylist)
            Select Case dbOp
                Case FactoryEnums.DBOperation.INSERT
                    sb.Append("insert into ")
                    sb.Append(db.DBName)
                    sb.Append(".stylist(")
                    sb.Append("st_key,st_lastname,st_firstname,st_address,st_postalcode,st_city,st_telmobile,")
                    sb.Append("st_telhome,st_telwork,st_email,st_allergy,st_miscinfo,st_created,")
                    sb.Append("st_createdby,st_active,st_profession,st_employmenttype")
                    sb.Append(") values(")
                    sb.Append(sInsertDel1 & s.Key & sInsertDel2)
                    sb.Append(sInsertDel1 & s.LastName & sInsertDel2)
                    sb.Append(sInsertDel1 & s.FirstName & sInsertDel2)
                    sb.Append(sInsertDel1 & s.Address & sInsertDel2)
                    sb.Append(s.PostalCode & ",")
                    sb.Append(sInsertDel1 & s.City & sInsertDel2)
                    sb.Append(sInsertDel1 & s.TelephoneMobile & sInsertDel2)
                    sb.Append(sInsertDel1 & s.TelephoneHome & sInsertDel2)
                    sb.Append(sInsertDel1 & s.TelephoneWork & sInsertDel2)
                    sb.Append(sInsertDel1 & s.EmailAddress & sInsertDel2)
                    sb.Append(sInsertDel1 & s.Allergy & sInsertDel2)
                    sb.Append(sInsertDel1 & s.MiscInfo & sInsertDel2)
                    sb.Append(sInsertDel1 & s.Created & sInsertDel2)
                    sb.Append(sInsertDel1 & s.CreatedBy & sInsertDel2)
                    sb.Append(s.Active & ",")
                    sb.Append(sInsertDel1 & s.Profession & sInsertDel2)
                    sb.Append(sInsertDel1 & s.Employment & "')")

                Case FactoryEnums.DBOperation.UPDATE
                    sb.Append("update ")
                    sb.Append(db.DBName)
                    sb.Append(".stylist set ")
                    sb.Append("st_lastname" & sUpdateDel1 & s.LastName & sUpdateDel2)
                    sb.Append("st_firstname" & sUpdateDel1 & s.FirstName & sUpdateDel2)
                    sb.Append("st_address" & sUpdateDel1 & s.Address & sUpdateDel2)
                    sb.Append("st_postalcode" & " = " & s.PostalCode & ", ")
                    sb.Append("st_city" & sUpdateDel1 & s.City & sUpdateDel2)
                    sb.Append("st_telmobile" & sUpdateDel1 & s.TelephoneMobile & sUpdateDel2)
                    sb.Append("st_telhome" & sUpdateDel1 & s.TelephoneHome & sUpdateDel2)
                    sb.Append("st_telwork" & sUpdateDel1 & s.TelephoneWork & sUpdateDel2)
                    sb.Append("st_email" & sUpdateDel1 & s.EmailAddress & sUpdateDel2)
                    sb.Append("st_allergy" & sUpdateDel1 & s.Allergy & sUpdateDel2)
                    sb.Append("st_miscinfo" & sUpdateDel1 & s.MiscInfo & sUpdateDel2)
                    sb.Append("st_updated" & sUpdateDel1 & s.Updated & sUpdateDel2)
                    sb.Append("st_updatedby" & sUpdateDel1 & s.UpdatedBy & sUpdateDel2)
                    sb.Append("st_active=" & s.Active & ", ")
                    sb.Append("st_profession" & sUpdateDel1 & s.Profession & sUpdateDel2)
                    sb.Append("st_employmenttype" & sUpdateDel1 & s.Employment & "'")
                    sb.Append(" where st_key='" & s.Key & "'")

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
                    sb.Append(".stylist where st_key='")
                    sb.Append(sKey)
                    sb.Append("'")
            End Select
        Catch ex As Exception
            Throw
        End Try

        Debug.WriteLine("SQL: " & sb.ToString)
        Return sb.ToString

    End Function

End Class
