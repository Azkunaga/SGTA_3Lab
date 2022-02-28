Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class WebForm7
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnPasaAlda_Click(sender As Object, e As EventArgs) Handles btnPasaAlda.Click

        Dim drErabiltzaileak As SqlDataReader
        Try
            DatuAtzipenekoak.DatuAtzipena.Konektatu()
            drErabiltzaileak = DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu(Session.Contents("emaila").ToString)
            If drErabiltzaileak.Read() Then
                If String.Equals(drErabiltzaileak.Item("pasahitza"), txtOldPass.Text) Then
                    If String.Equals(txtNewPass.Text, txtNewPass2.Text) Then
                        Try
                            DatuAtzipenekoak.DatuAtzipena.ErabiltzailearenPasahitzaAldatu(Session.Contents("emaila").ToString, txtNewPass.Text)
                        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaEguneratzean
                            lblErrMezu.Text = ex.Message
                            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
                            Exit Sub
                        End Try
                        DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
                        Response.Redirect("Menua.aspx")
                    Else
                        lblErrMezu.Text = "Pasahitz berriak ez dira berdinak"
                        DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
                    End If
                Else
                    lblErrMezu.Text = "Pasahitz zaharra ez da datubasekoaren berdina"
                    DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
                End If
            End If
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaKonektatzean
            lblErrMezu.Text = ex.Message
            Exit Sub
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaIrakurtzean
            lblErrMezu.Text = ex.Message
            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
            Exit Sub
        End Try
    End Sub

End Class