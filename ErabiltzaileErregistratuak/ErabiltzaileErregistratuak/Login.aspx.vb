Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn2Login_Click(sender As Object, e As EventArgs) Handles btn2Login.Click

        Dim drErabiltzaileak As SqlDataReader
        Try
            DatuAtzipenekoak.DatuAtzipena.Konektatu()
            drErabiltzaileak = DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu(txtEmail.Text)
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaKonektatzean
            lblErrMezua.Text = ex.Message
            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
            Exit Sub
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaIrakurtzean
            lblErrMezua.Text = ex.Message
            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
            Exit Sub
        End Try
        If drErabiltzaileak.Read() Then
            If String.Equals(drErabiltzaileak.Item("email"), txtEmail.Text) And String.Equals(drErabiltzaileak.Item("pasahitza"), txtPasahitza.Text) Then
                Session.Contents("emaila") = txtEmail.Text
                Response.Redirect("Menua.aspx")
                DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
            Else
                lblErrMezua.Text = "Emaila edo pasahitza ez da zuzena"
            End If
        End If

    End Sub

    Protected Sub btn2Erregistratu_Click(sender As Object, e As EventArgs) Handles btn2Erregistratu.Click
        Response.Redirect("Erregistratzea.aspx")
        DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
    End Sub

    Protected Sub btnPasaBerr_Click(sender As Object, e As EventArgs) Handles btnPasaBerr.Click
        If String.IsNullOrEmpty(txtEmail.Text) Then
            MessageBox.Show("Emailaren testu kutxa hutsik dago")
        Else
            Response.Redirect(String.Concat("PasahitzaBerreskuratu.aspx?emaila=", txtEmail.Text))
            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
        End If
    End Sub
End Class