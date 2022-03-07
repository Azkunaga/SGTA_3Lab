Public Class WebForm13
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ddlIrakasgaiak_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlIrakasgaiak.SelectedIndexChanged

    End Sub

    Protected Sub btnLanBerria_Click(sender As Object, e As EventArgs) Handles btnLanBerria.Click
        Response.Redirect("LanGenerikoaGehitu.aspx")
    End Sub
End Class