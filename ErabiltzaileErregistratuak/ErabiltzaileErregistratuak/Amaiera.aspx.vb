Public Class WebForm8
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session.Abandon()
        lblAgurra.Text = "Saioa amaitu duzu. Ondo izan."
    End Sub

End Class