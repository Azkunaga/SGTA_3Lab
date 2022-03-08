Imports System.Data.SqlClient

Public Class WebForm14
    Inherits System.Web.UI.Page

    Protected Sub btnGehiLana_Click(sender As Object, e As EventArgs) Handles btnGehiLana.Click
        DatuAtzipenekoak.DatuAtzipena.Konektatu()
        Dim dataSetIrakasleLanGeneriko As DataSet = Session("dataSetLanGenerikoak")
        Dim dataAdapterIrakasleLanGenerikoa As SqlDataAdapter = Session("dataAdapterLanGenerikoak")
        Dim errenkada As DataRow
        Dim tblLanGenerikoa As DataTable = dataSetIrakasleLanGeneriko.Tables("LanGenerikoak")
        errenkada = tblLanGenerikoa.NewRow
        errenkada("kodea") = txtKodea.Text
        errenkada("deskribapena") = txtDeskribapena.Text
        errenkada("irakasgaiKodea") = ddlIrakasgaiak.SelectedValue
        errenkada("aurreikusitakoOrduak") = txtAurreOrduak.Text
        errenkada("ustiapenean") = False
        errenkada("lanMota") = ddlLanMotak.SelectedValue
        tblLanGenerikoa.Rows.Add(errenkada)

        Dim builder As New SqlCommandBuilder(dataAdapterIrakasleLanGenerikoa)
        dataAdapterIrakasleLanGenerikoa.InsertCommand = builder.GetInsertCommand
        dataAdapterIrakasleLanGenerikoa.Update(tblLanGenerikoa)
        Session.Contents("dataSetLanGenerikoak") = dataSetIrakasleLanGeneriko
        Session.Contents("dataAdapterLanGenerikoak") = dataAdapterIrakasleLanGenerikoa
        DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
    End Sub
End Class
