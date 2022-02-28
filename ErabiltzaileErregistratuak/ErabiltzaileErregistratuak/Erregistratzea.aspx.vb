Imports System.Windows.Forms

Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnErregistratu_Click(sender As Object, e As EventArgs) Handles btnErregistratu.Click
        Try
            DatuAtzipenekoak.DatuAtzipena.Konektatu()
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaKonektatzean
            lblErrMezu.Text = ex.Message
            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
            Exit Sub
        End Try

        If String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrEmpty(txtIzena.Text) Or String.IsNullOrEmpty(txtAbizena.Text) Or String.IsNullOrEmpty(txtNAN.Text) Or String.IsNullOrEmpty(txtGalderaEzkutua.Text) Or String.IsNullOrEmpty(txtErantzuna.Text) Or String.IsNullOrEmpty(txtAzpiKodea.Text) Or String.IsNullOrEmpty(txtLanKodea.Text) Then
            lblErrMezu.Text = "Eremu guztiak bete behar dira"
        Else
            If Strings.Len(txtEmail.Text) > 50 Or Strings.Len(txtIzena.Text) > 50 Or Strings.Len(txtAbizena.Text) > 50 Or Strings.Len(txtGalderaEzkutua.Text) > 50 Or Strings.Len(txtEmail.Text) > 50 Or Strings.Len(txtErantzuna.Text) > 50 Or Strings.Len(DropDownMota.SelectedValue) > 50 Or Strings.Len(txtAzpiKodea.Text) > 50 Or Strings.Len(txtAzpiKodea.Text) > 50 Or Strings.Len(txtPasahitza.Text) > 16 Then
                lblErrMezu.Text = "Eremuren baten luzera desegokia da. Eremuen luzera maximoa 50ekoa izan daiteke. Pasahitzaren luzera maxioa 16 karaktere dira."
            Else
                If (Regex.IsMatch(txtEmail.Text, "[a-z]+@ehu.(eus|es)") And DropDownMota.SelectedValue = "Irakasle") Or (Regex.IsMatch(txtEmail.Text, "[a-z]+@ikasle.ehu.(eus|es)") And DropDownMota.SelectedValue = "Ikasle") Then
                    If Regex.IsMatch(txtNAN.Text, "[0-9]{8}") Then
                        Dim egiaztatzeZenbakia As Integer = CLng(Rnd() * 9000000) + 1000000
                        Try
                            DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaTxertatu(txtEmail.Text, txtIzena.Text, txtAbizena.Text, txtGalderaEzkutua.Text, txtErantzuna.Text, txtNAN.Text, egiaztatzeZenbakia, txtLanKodea.Text, txtAzpiKodea.Text, DropDownMota.SelectedValue, txtPasahitza.Text)
                        Catch ex As Exception
                            lblErrMezu.Text = ex.Message
                            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
                            Exit Sub
                        End Try
                        lblErrMezu.Text = ""
                        hylEgiaztatu.NavigateUrl = "Egiaztatu.aspx?emaila=" & txtEmail.Text & "&egZenb=" & egiaztatzeZenbakia
                        hylEgiaztatu.Enabled = True
                    Else
                        lblErrMezu.Text = "NAN-a zortzi digituko zenbaki bat izan behar da."
                    End If
                Else
                    lblErrMezu.Text = "Emailaren eremuak ez du patroia jarraitzen. Funtzionatuko lukeen email bat: ikasleentzat(x@ikasle.ehu.eus) eta irakasleentzat(x@ehu.eus)"
                End If
            End If
            DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
        End If
    End Sub
End Class