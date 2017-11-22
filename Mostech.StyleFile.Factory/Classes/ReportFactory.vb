
Imports Mostech.StyleFile.Entity
Imports Mostech.Common
Imports System.Text
Imports Mostech.Common.Entity

Public Class ReportFactory
    Implements IFactory

    Public Function InstantiateEntity(ByVal data As DataSet, _
                                      ByVal type As FactoryEnums.InstantionType,
                                      ByVal db As DBAccess) As Collection Implements IFactory.InstantiateEntity

        Dim coll As New Collection
        Dim rep As Report

        Try
            For Each r In data.Tables(0).Rows
                rep = New Report

                rep.Key = r.Item("rp_key").ToString
                rep.ID = r.Item("rp_id").ToString
                rep.Name = r.Item("rp_name").ToString
                rep.SQL = r.Item("rp_sql").ToString
                rep.Created = r.Item("rp_created").ToString
                rep.CreatedBy = r.Item("rp_createdby").ToString
                rep.Updated = r.Item("rp_updated").ToString
                rep.UpdatedBy = r.Item("rp_updatedby").ToString
                rep.Active = r.Item("rp_active").ToString

                coll.Add(rep)
            Next
        Catch ex As Exception
            Throw
        End Try

        Return coll

    End Function

    Public Function CreateSQL(ByVal entity As Entity.Entity, _
                              ByVal dbOp As FactoryEnums.DBOperation,
                              ByVal db As DBAccess) As String Implements IFactory.CreateSQL

        Dim rep As Report
        Dim sb As New StringBuilder
        Dim sInsertDel1 As String = "'"
        Dim sInsertDel2 As String = "',"
        Dim sUpdateDel1 As String = "='"
        Dim sUpdateDel2 As String = "',"

        Try
            rep = DirectCast(entity, Report)
            Select Case dbOp
                Case FactoryEnums.DBOperation.INSERT
                    'rp_key,rp_id,rp_name,rp_sql,rp_created,rp_createdby,rp_updated,rp_updatedby,rp_active
                    sb.Append("insert into ")
                    sb.Append(db.DBName)
                    sb.Append(".report(")
                    sb.Append("rp_key,rp_name,rp_sql,rp_created,rp_createdby,rp_active")
                    sb.Append(") values(")
                    sb.Append(sInsertDel1 & rep.Key & sInsertDel2)
                    sb.Append(sInsertDel1 & rep.Name & sInsertDel2)
                    sb.Append(sInsertDel1 & rep.SQL & sInsertDel2)
                    sb.Append(sInsertDel1 & rep.Created & sInsertDel2)
                    sb.Append(sInsertDel1 & rep.CreatedBy & sInsertDel2)
                    sb.Append(rep.Active & ")")

                Case FactoryEnums.DBOperation.UPDATE
                    sb.Append("update ")
                    sb.Append(db.DBName)
                    sb.Append(".report set ")
                    sb.Append("rp_name" & sUpdateDel1 & rep.Name & sUpdateDel2)
                    sb.Append("rp_sql" & sUpdateDel1 & rep.SQL & sUpdateDel2)
                    sb.Append("rp_updated" & sUpdateDel1 & rep.Updated & sUpdateDel2)
                    sb.Append("rp_updatedby" & sUpdateDel1 & rep.UpdatedBy & sUpdateDel2)
                    sb.Append("rp_active=" & rep.Active & " ")
                    sb.Append("where rp_key='" & rep.Key & "'")

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
                    sb.Append(".report where rp_key='")
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
