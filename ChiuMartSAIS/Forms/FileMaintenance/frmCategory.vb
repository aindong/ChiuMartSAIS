Imports System.Data
Imports MySql.Data.MySqlClient

Public Class frmCategory



    'load products from the database to the listview
    Sub loadProducts()
        Try
            Using db = New MySqlConnection(conString)
                db.Open()
                Dim sql As String = "SELECT * FROM category"

                Dim cmd = New MySqlCommand(sql, db)
                
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ListView1.Items.Clear()

                While reader.Read
                    ListView1.Items.Add(reader("categoryId").ToString)
                    With ListView1.Items(ListView1.Items.Count - 1).SubItems
                        .Add(reader("categoryName").ToString)
                    End With
                End While

            End Using
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message.ToString)
        End Try
    End Sub

    'load products from the database to the textbox custome collection
    Sub loadProductToSuggestion()
        Try
            Using db = New MySqlConnection(conString)
                db.Open()
                Dim sql As String = "SELECT * FROM category"

                Dim cmd = New MySqlCommand(sql, db)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While (reader.Read)
                    txtQuery.AutoCompleteCustomSource.AddRange(New String() {reader(1)})
                End While

            End Using
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadProducts()
        loadProductToSuggestion()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class