
Imports Mostech.Common

Imports Mostech.StyleFile.Entity
Imports Mostech.Common.Entity

Imports System.Text

Public Class JobFactory
    Implements IFactory

    Public Function InstantiateEntity(ByVal data As DataSet,
                                      ByVal type As FactoryEnums.InstantionType,
                                      ByVal db As DBAccess) As Collection Implements IFactory.InstantiateEntity

        Dim coll As New Collection
        Dim jb As Job

        Try
            For Each r In data.Tables(0).Rows
                jb = New Job

                jb.Key = r.Item("jb_key").ToString
                jb.ID = r.Item("jb_id").ToString
                jb.Customer = r.Item("jb_customer").ToString
                jb.Category = r.Item("jb_category").ToString
                jb.JobDate = Toolbox.DateAndTimeUtils.GetDate(r.Item("jb_date").ToString, Toolbox.DateAndTimeUtils.DateFormat.SHORT)
                jb.StartTime = r.Item("jb_starttime").ToString
                jb.EndTime = r.Item("jb_endtime").ToString
                jb.Duration = Toolbox.ConversionUtils.ParseInteger(r.Item("jb_duration").ToString)
                jb.Stylist = r.Item("jb_stylist").ToString
                jb.PriceInclVAT = Toolbox.ConversionUtils.ParseDecimal(r.Item("jb_priceinclvat").ToString)
                jb.VATPercentage = Toolbox.ConversionUtils.ParseInteger(r.Item("jb_vatpercentage").ToString)
                jb.PriceExclVAT = Toolbox.ConversionUtils.ParseDecimal(r.Item("jb_priceexclvat").ToString)
                jb.Description = r.Item("jb_description").ToString
                jb.Created = r.Item("jb_created").ToString
                jb.CreatedBy = r.Item("jb_createdby").ToString
                jb.Updated = r.Item("jb_updated").ToString
                jb.UpdatedBy = r.Item("jb_updatedby").ToString

                coll.Add(jb)
            Next
        Catch ex As Exception
            'Throw
        End Try

        Return coll

    End Function

    Public Function CreateSQL(ByVal entity As Entity.Entity, _
                              ByVal dbOp As FactoryEnums.DBOperation,
                              ByVal db As DBAccess) As String Implements IFactory.CreateSQL

        Dim jb As Job
        Dim sb As New StringBuilder
        Dim sInsertDel1 As String = "'"
        Dim sInsertDel2 As String = "',"
        Dim sUpdateDel1 As String = "='"
        Dim sUpdateDel2 As String = "',"

        Try
            jb = DirectCast(entity, Job)
            Select Case dbOp
                Case FactoryEnums.DBOperation.INSERT
                    sb.Append("insert into ")
                    sb.Append(db.DBName)
                    sb.Append(".job(")
                    sb.Append("jb_key,jb_customer,jb_category,jb_date,jb_starttime,jb_endtime,jb_duration,")
                    sb.Append("jb_stylist,jb_priceinclvat,jb_vatpercentage,jb_priceexclvat,jb_description,")
                    sb.Append("jb_created,jb_createdby")
                    sb.Append(") values (")
                    sb.Append(sInsertDel1 & jb.Key & sInsertDel2)
                    sb.Append(sInsertDel1 & jb.Customer & sInsertDel2)
                    sb.Append(sInsertDel1 & jb.Category & sInsertDel2)
                    sb.Append(sInsertDel1 & jb.JobDate & sInsertDel2)
                    sb.Append(sInsertDel1 & jb.StartTime & sInsertDel2)
                    sb.Append(sInsertDel1 & jb.EndTime & sInsertDel2)
                    sb.Append(jb.Duration & ",")
                    sb.Append(sInsertDel1 & jb.Stylist & sInsertDel2)
                    sb.Append(Toolbox.StringUtils.Replace(jb.PriceInclVAT.ToString, ",", ".") & ",")
                    sb.Append(jb.VATPercentage & ",")
                    sb.Append(Toolbox.StringUtils.Replace(jb.PriceExclVAT.ToString, ",", ".") & ",")
                    sb.Append(sInsertDel1 & jb.Description & sInsertDel2)
                    sb.Append(sInsertDel1 & jb.Created & sInsertDel2)
                    sb.Append(sInsertDel1 & jb.CreatedBy & "')")

                Case FactoryEnums.DBOperation.UPDATE
                    sb.Append("update ")
                    sb.Append(db.DBName)
                    sb.Append(".job set ")
                    sb.Append("jb_category" & sUpdateDel1 & jb.Category & sUpdateDel2)
                    sb.Append("jb_date" & sUpdateDel1 & jb.JobDate & sUpdateDel2)
                    sb.Append("jb_starttime" & sUpdateDel1 & jb.StartTime & sUpdateDel2)
                    sb.Append("jb_endtime" & sUpdateDel1 & jb.EndTime & sUpdateDel2)
                    sb.Append("jb_duration" & sUpdateDel1 & jb.Duration & sUpdateDel2)
                    sb.Append("jb_stylist" & sUpdateDel1 & jb.Stylist & sUpdateDel2)
                    sb.Append("jb_priceinclvat" & sUpdateDel1 & Toolbox.StringUtils.Replace(jb.PriceInclVAT.ToString, ",", ".") & sUpdateDel2)
                    sb.Append("jb_vatpercentage" & sUpdateDel1 & jb.VATPercentage & sUpdateDel2)
                    sb.Append("jb_priceexclvat" & sUpdateDel1 & Toolbox.StringUtils.Replace(jb.PriceExclVAT.ToString, ",", ".") & sUpdateDel2)
                    sb.Append("jb_description" & sUpdateDel1 & jb.Description & sUpdateDel2)
                    sb.Append("jb_updated" & sUpdateDel1 & jb.Updated & sUpdateDel2)
                    sb.Append("jb_updatedby" & sUpdateDel1 & jb.UpdatedBy & "'")
                    sb.Append(" where jb_key='" & jb.Key & "'")

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
                    sb.Append(".job where jb_key='")
                    sb.Append(sKey)
                    sb.Append("'")
            End Select
        Catch ex As Exception
            Throw
        End Try

        Return sb.ToString

    End Function

End Class
