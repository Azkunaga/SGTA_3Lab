Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class WebForm4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim drErabiltzailea As SqlDataReader
        Try
            DatuAtzipenekoak.DatuAtzipena.Konektatu()
            drErabiltzailea = DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu(Request.QueryString(“emaila”))
            If drErabiltzailea.Read() Then
                If Integer.Equals(drErabiltzailea.Item("egiaztatzeZenbakia"), Integer.Parse(Request.QueryString(“egZenb”))) Then
                    Try
                        DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaEgiaztatu(Request.QueryString(“emaila”))
                    Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaEguneratzean
                        lblErroreMezua.Text = ex.Message
                        Exit Sub
                    End Try
                    DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
                    btnLogin.Enabled = True
                Else
                    lblErroreMezua.Text = "Ezin izan da erabiltzailea egiaztatu"
                    DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
                End If
            End If
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaKonektatzean
            lblErroreMezua.Text = ex.Message
            Exit Sub
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaIrakurtzean
            lblErroreMezua.Text = ex.Message
            Exit Sub
        End Try
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Response.Redirect("Login.aspx")
    End Sub
End Class