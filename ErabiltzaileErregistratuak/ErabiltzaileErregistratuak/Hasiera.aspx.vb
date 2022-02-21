Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogIN_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Response.Redirect(“Login.aspx”)
    End Sub

    Protected Sub btnErregistratu_Click(sender As Object, e As EventArgs) Handles btnErregistratu.Click
        Response.Redirect(“Erregistratzea.aspx”)
    End Sub
End Class