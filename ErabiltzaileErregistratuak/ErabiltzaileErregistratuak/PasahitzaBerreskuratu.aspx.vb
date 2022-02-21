Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class WebForm5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim drErabiltzailea As SqlDataReader
        Try
            DatuAtzipenekoak.DatuAtzipena.Konektatu()
            drErabiltzailea = DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu(Request.QueryString(“emaila”))
            If drErabiltzailea.Read() Then
                lblGalEzk.Text = drErabiltzailea.Item("galderaEzkutua")
            End If
            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaKonektatzean
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaIrakurtzean
            MessageBox.Show(ex.Message)
            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
            Exit Sub
        End Try
    End Sub

    Protected Sub btnPasaBerr_Click(sender As Object, e As EventArgs) Handles btnPasaBerr.Click
        Dim drErabiltzailea As SqlDataReader
        Try
            DatuAtzipenekoak.DatuAtzipena.Konektatu()
            drErabiltzailea = DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu(Request.QueryString(“emaila”))
            If drErabiltzailea.Read() Then
                If String.IsNullOrEmpty(txtErantzuna.Text) Then
                    lblEmaitza.Text = "Erantzuna hutsik dago"
                ElseIf String.Equals(drErabiltzailea.Item("erantzuna"), txtErantzuna.Text) Then
                    lblEmaitza.Text = drErabiltzailea.Item("pasahitza")
                Else
                    lblEmaitza.Text = "Erantzuna ez da zuzena"
                End If
            End If
            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaKonektatzean
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaIrakurtzean
            MessageBox.Show(ex.Message)
            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
            Exit Sub
        End Try

    End Sub

    Protected Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Response.Redirect("Login.aspx")
    End Sub
End Class