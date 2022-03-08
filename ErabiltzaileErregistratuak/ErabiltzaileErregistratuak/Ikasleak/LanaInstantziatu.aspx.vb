Imports System.Data.SqlClient

Public Class WebForm12
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            erabText.Text = Session("email")
            lanaText.Text = Request.QueryString("lanKodea")
            Dim dsIkasleLanak As New DataSet()
            DatuAtzipenekoak.DatuAtzipena.Konektatu()
            Dim daIkasleLanak As SqlDataAdapter = DatuAtzipenekoak.DatuAtzipena.IkasleLanenEgokitzaileaEskuratu(Session("email"))
            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
            daIkasleLanak.Fill(dsIkasleLanak, "ikasleLanak")
            Session.Contents("daIkasleLanak") = daIkasleLanak
            Session.Contents("dsIkasleLanak") = dsIkasleLanak

        End If
    End Sub

    Protected Sub btnLanaSortu_Click(sender As Object, e As EventArgs) Handles btnLanaSortu.Click
        Dim lanGenerikoakIrakasgaia As New DataView(Session("dsIkasleLanak").Tables("ikasleLanak"))
        lanGenerikoakIrakasgaia.RowFilter = "lanGenerikoarenKodea='" & lanaText.Text & "'"

        If IsNumeric(aurText.Text) And IsNumeric(benText.Text) Then
            If lanGenerikoakIrakasgaia.Count = 0 Then
                Dim rowLan As DataRow
                Dim tblIkasleLanak As DataTable = Session("dsIkasleLanak").Tables("ikasleLanak")
                rowLan = tblIkasleLanak.NewRow
                rowLan("email") = erabText.Text
                rowLan("lanGenerikoarenKodea") = lanaText.Text
                rowLan("aurreikusitakoOrduak") = aurText.Text
                rowLan("benetakoOrduak") = benText.Text
                tblIkasleLanak.Rows.Add(rowLan)
                Dim daIkasleLanak As SqlDataAdapter = Session("daIkasleLanak")
                Dim builder As New SqlCommandBuilder(daIkasleLanak)
                daIkasleLanak.UpdateCommand = builder.GetUpdateCommand
                daIkasleLanak.Update(tblIkasleLanak)
                mezua.Text = "Lana instantziatu da"
            Else
                mezua.Text = "Lan hori instantziatuta dago jada"
            End If
        Else
            mezua.Text = "Orduak zenabi osoak izan behar dira!"
        End If


    End Sub
End Class