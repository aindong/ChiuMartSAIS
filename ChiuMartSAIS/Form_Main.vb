Public Class Form_Main

    Private Sub btnProductCategory_Click(sender As Object, e As EventArgs) Handles btnProductCategory.Click
        Dim frm = New frmCategory()
        frm.Show()
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        Dim frm = New frmProduct()
        frm.Show()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        Dim frm = New frmSupplier()
        frm.Show()
    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        Dim frm = New frmClient()
        frm.Show()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim frm = New frmUsers()
        frm.Show()
    End Sub

    Private Sub btnUnits_Click(sender As Object, e As EventArgs) Handles btnUnits.Click
        Dim frm = New frmUnits()
        frm.Show()
    End Sub

    Private Sub btnOR_Click(sender As Object, e As EventArgs) Handles btnOR.Click
        Dim frm = New frmOR()
        frm.Show()
    End Sub
End Class
