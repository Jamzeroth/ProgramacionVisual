Public Class Form1

    Dim conexion As New OleDb.OleDbConnection


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Jael\Programacion\Ejemplos\ProgramacionVisual\transacciones.accdb")
            conexion.Open()
            MsgBox("Conexion Exitosa")
        Catch ex As Exception
            MsgBox("No se pudo conectar")
        End Try
    End Sub
End Class
