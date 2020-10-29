Imports System.Data
Imports System.Data.OleDb

Public Class FrmLogin

    Private Sub PLogin(ByVal login As String, ByVal senha As String)
        Dim dr As OleDbDataReader = Nothing
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "select * from TabUsuario where login = '" & login & "' and senha = '" & senha & "'"
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()


                    Me.Dispose()


                Else
                    MsgBox("Os dados não conferem")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                dr.Close()
                con.Close()

            End Try
        End Using
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        PLogin(txtusuario.Text, txtsenha.Text)
    End Sub
End Class