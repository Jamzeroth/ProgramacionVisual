Module Module1
    Sub leer()
        Using MyReader As New Microsoft.VisualBasic.
            FileIO.TextFieldParser("C:\Users\JAEL\Documents\Progra Vis\Ejemplo_LeerA\Prueba.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        MsgBox(currentField)
                    Next
                Catch ex As Microsoft.VisualBasic.
                    FileIO.MalformedLineException
                    MsgBox("Línea" + ex.Message + "no encontrado")
                End Try
            End While
        End Using
    End Sub
End Module
