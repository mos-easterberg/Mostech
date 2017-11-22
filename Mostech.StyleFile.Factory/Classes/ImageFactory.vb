
Imports Mostech.Common

Imports Mostech.StyleFile.Entity
Imports Mostech.Common.Entity

Imports System.Text

Public Class ImageFactory
    Implements IFactory

    Public Function InstantiateEntity(ByVal data As DataSet, _
                                      ByVal type As FactoryEnums.InstantionType,
                                      ByVal db As DBAccess) As Collection Implements IFactory.InstantiateEntity

        Dim coll As New Collection
        Dim img As ImageProps

        Try
            For Each r In data.Tables(0).Rows
                img = New ImageProps

                img.Key = r.Item("im_key").ToString
                img.ParentKey = r.Item("im_parentkey").ToString
                'img.Image = ImageFactory.fr r.Item("im_blob")
                'img.FilePath = r.Item("im_filepath").ToString
                img.FileName = r.Item("im_filename").ToString
                img.Created = r.Item("im_created").ToString
                img.CreatedBy = r.Item("im_createdby").ToString
                img.Updated = r.Item("im_updated").ToString
                img.UpdatedBy = r.Item("im_updatedby").ToString

                coll.Add(img)
            Next
        Catch ex As Exception
            'Throw
        End Try

        Return coll

    End Function

    Public Function CreateSQL(ByVal entity As Entity.Entity, _
                              ByVal dbOp As FactoryEnums.DBOperation,
                              ByVal db As DBAccess) As String Implements IFactory.CreateSQL

        Dim img As ImageProps
        Dim sb As New StringBuilder
        Dim sInsertDel1 As String = "'"
        Dim sInsertDel2 As String = "',"
        Dim sUpdateDel1 As String = "='"
        Dim sUpdateDel2 As String = "',"

        Try
            img = DirectCast(entity, ImageProps)

            Select Case dbOp
                Case FactoryEnums.DBOperation.INSERT
                    sb.Append("insert into ")
                    sb.Append(db.DBName)
                    sb.Append(".image(")
                    sb.Append("im_key, im_parentkey, im_filename, im_created, im_createdby")
                    sb.Append(") values (")
                    sb.Append(sInsertDel1 & img.Key & sInsertDel2)
                    sb.Append(sInsertDel1 & img.ParentKey & sInsertDel2)
                    sb.Append(sInsertDel1 & img.FileName & sInsertDel2)
                    sb.Append(sInsertDel1 & img.Created & sInsertDel2)
                    sb.Append(sInsertDel1 & img.CreatedBy & "')")

                Case FactoryEnums.DBOperation.UPDATE
                    'sb.Append("update ")
                    'sb.Append(db.DBName)
                    'sb.Append(".image set ")
                    'sb.Append("im_filepath" & sUpdateDel1 & img.FilePath & sUpdateDel2)
                    'sb.Append("im_filename" & sUpdateDel1 & img.FileName & sUpdateDel2)
                    'sb.Append("im_updated" & sUpdateDel1 & img.Updated & sUpdateDel2)
                    'sb.Append("im_updatedby" & sUpdateDel1 & img.UpdatedBy & "'")
                    'sb.Append(" where im_key='" & img.Key & "'")

            End Select
        Catch ex As Exception
            Throw
        End Try

        Debug.WriteLine("SQL: " & sb.ToString)
        Return sb.ToString

    End Function

    Public Function CreateSQL(ByVal sKey As String,
                              ByVal dbOp As FactoryEnums.DBOperation,
                              ByVal db As DBAccess) As String Implements IFactory.CreateSQL

        Dim sb As New StringBuilder

        Try
            Select Case dbOp

                'DELETE
                '------------------------
                Case FactoryEnums.DBOperation.DELETE
                    sb.Append("delete from ")
                    sb.Append(db.DBName)
                    sb.Append(".image where im_key='")
                    sb.Append(sKey)
                    sb.Append("'")

                    'DELETE_BY_PARENT
                    '------------------------
                Case FactoryEnums.DBOperation.DELETE_BY_PARENT
                    sb.Append("delete from ")
                    sb.Append(db.DBName)
                    sb.Append(".image where im_parentkey='")
                    sb.Append(sKey)
                    sb.Append("'")

            End Select
        Catch ex As Exception
            Throw
        End Try

        Return sb.ToString

    End Function

End Class
