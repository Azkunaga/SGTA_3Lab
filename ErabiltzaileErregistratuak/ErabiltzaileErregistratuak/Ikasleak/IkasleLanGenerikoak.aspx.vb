Imports System.Data.SqlClient

Public Class WebForm11
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dataSetIkaslea As New DataSet()
        Dim dataSetUstiapenekoa As New DataSet()
        Dim dataAdapterIkaslea As SqlDataAdapter = DatuAtzipenekoak.DatuAtzipena.IkasleaMatrikulatutakoIrakasgaienEgokitzaileaEskuratu(Session("email"))
        Dim dataAdapterUstiapenekoa As SqlDataAdapter = DatuAtzipenekoak.DatuAtzipena.UstiapenekoLanGenerikoenEgokitzaileaEskuratu
        dataAdapterIkaslea.Fill(dataSetIkaslea, "Irakasgaiak")
        dataAdapterUstiapenekoa.Fill(dataSetUstiapenekoa, "LanGenerikoak")
        Session.Contents("ustiapenekoak") = dataSetUstiapenekoa
        ddlIrakasgaiak.DataSource = dataSetIkaslea.Tables("Irakasgaiak")
        ddlIrakasgaiak.DataTextField = "iraksagaiKodea"
        ddlIrakasgaiak.DataBind()
    End Sub

    Protected Sub btnLanakBistaratu_Click(sender As Object, e As EventArgs) Handles btnLanakBistaratu.Click
        Dim lanGenerikoakIrakasgaia As New DataView(Session("ustiapenekoak").Tables("LanGenerikoak"))
        lanGenerikoakIrakasgaia.RowFilter = "irakasgaiKodea='" & ddlIrakasgaiak.SelectedValue & "'"
        grvLanak.Columns(1).Visible = cblLanEzaugarri.Items(1).Selected
        grvLanak.Columns(2).Visible = cblLanEzaugarri.Items(2).Selected
        grvLanak.Columns(3).Visible = cblLanEzaugarri.Items(3).Selected
        grvLanak.DataSource = lanGenerikoakIrakasgaia
        grvLanak.DataBind()
    End Sub

    Protected Sub cblLanEzaugarri_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cblLanEzaugarri.SelectedIndexChanged
    End Sub

    Protected Sub ddlIrakasgaiak_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlIrakasgaiak.SelectedIndexChanged
        btnLanakBistaratu_Click(sender, e)
    End Sub
End Class