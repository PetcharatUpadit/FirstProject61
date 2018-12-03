Public Class firstform


    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Dim SaleV As Integer
        Dim SaleF As Integer
        Dim Commission1, Commission2 As Long

        SaleV = txtSale1.Text
        SaleF = txtF.Text

        lbltotal.Text = SaleV + SaleF
        Commission1 = txtSale1.Text * 0.05
        Commission2 = txtF.Text * 0.1

        lblCom.Text = Commission1 + Commission2
        lblAll.Text = SaleV + SaleF + Commission1 + Commission2


    End Sub
   
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub firstform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class