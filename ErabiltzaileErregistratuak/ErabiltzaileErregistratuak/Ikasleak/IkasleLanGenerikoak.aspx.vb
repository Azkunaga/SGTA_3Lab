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
        Session("ustiapenekoak") = dataSetUstiapenekoa
        ddlIrakasgaiak.DataSource = dataSetIkaslea.Tables("Irakasgaiak")
        ddlIrakasgaiak.DataTextField = "iraksagaiKodea"
        ddlIrakasgaiak.DataBind()
    End Sub

    Protected Sub btnLanakBistaratu_Click(sender As Object, e As EventArgs) Handles btnLanakBistaratu.Click

    End Sub

End Class