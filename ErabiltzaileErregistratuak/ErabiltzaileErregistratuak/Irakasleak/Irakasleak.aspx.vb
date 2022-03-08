Imports System.Data.SqlClient

Public Class WebForm10
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DatuAtzipenekoak.DatuAtzipena.Konektatu()
        Dim dataSetIrakasleLanGeneriko As New DataSet()
        Dim dataAdapterIrakasleLanGeneriko As SqlDataAdapter = DatuAtzipenekoak.DatuAtzipena.LanGenerikoenEgokitzaileaEskuratu
        DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
        dataAdapterIrakasleLanGeneriko.Fill(dataSetIrakasleLanGeneriko, "LanGenerikoak")
        Session.Contents("dataSetLanGenerikoak") = dataSetIrakasleLanGeneriko
        Session.Contents("dataAdapterLanGenerikoak") = dataAdapterIrakasleLanGeneriko
    End Sub

End Class
