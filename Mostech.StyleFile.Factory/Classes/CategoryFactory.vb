
Imports Mostech.StyleFile.Entity
Imports Mostech.Common
Imports System.Text
Imports Mostech.Common.Entity

Public Class CategoryFactory
    Implements IFactory

    Public Function InstantiateEntity(ByVal data As DataSet,
                                      ByVal type As FactoryEnums.InstantionType,
                                      ByVal db As DBAccess) As Collection Implements IFactory.InstantiateEntity

        Dim coll As New Collection
        Dim ct As Category

        Try
            For Each r In data.Tables(0).Rows
                ct = New Category

                ct.Key = r.Item("ct_key").ToString
                ct.Type = r.Item("ct_type").ToString
                ct.Value = r.Item("ct_value").ToString
                ct.Active = r.Item("ct_active").ToString
                ct.Default = r.Item("ct_default").ToString

                coll.Add(ct)
            Next
        Catch ex As Exception
            Throw
        End Try

        Return coll

    End Function

    Public Function CreateSQL(ByVal entity As Entity.Entity,
                              ByVal dbOp As FactoryEnums.DBOperation,
                              ByVal db As DBAccess) As String Implements IFactory.CreateSQL

        Dim ct As Category
        Dim sb As New StringBuilder
        Dim sInsertDel1 As String = "'"
        Dim sInsertDel2 As String = "',"
        Dim sUpdateDel1 As String = "='"
        Dim sUpdateDel2 As String = "',"

        Try
            ct = DirectCast(entity, Category)
            Select Case dbOp
                Case FactoryEnums.DBOperation.INSERT
                    sb.Append("insert into ")
                    sb.Append(db.DBName)
                    sb.Append(".category(")
                    sb.Append("ct_key, ct_type, ct_value, ct_active, ct_default")
                    sb.Append(") values(")
                    sb.Append(sInsertDel1 & Guid.NewGuid.ToString & sInsertDel2)
                    sb.Append(sInsertDel1 & ct.Type & sInsertDel2)
                    sb.Append(sInsertDel1 & ct.Value & sInsertDel2)
                    sb.Append(ct.Active & ",")
                    sb.Append(ct.Default & ")")

                Case FactoryEnums.DBOperation.UPDATE
                    sb.Append("update ")
                    sb.Append(db.DBName)
                    sb.Append(".category set ")
                    sb.Append("ct_value" & sUpdateDel1 & ct.Value & sUpdateDel2)
                    sb.Append("ct_active=" & ct.Active & ",")
                    sb.Append("ct_default=" & ct.Default & " ")
                    sb.Append("where ct_key='" & ct.Key & "'")

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
                    sb.Append(".category where ct_key='")
                    sb.Append(sKey)
                    sb.Append("'")
            End Select
        Catch ex As Exception
            Throw
        End Try

        Return sb.ToString

    End Function

End Class
