<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="IrakasleLanak.aspx.vb" Inherits="ErabiltzaileErregistratuak.WebForm13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            IRAKASLEA<br />
            LAN GENERIKOEN KUDEAKETA<br />
        </div>
        <div>

            <br />
            <asp:Label ID="Label1" runat="server" Text="Irakasgaia hautatu:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlIrakasgaiak" runat="server" DataSourceID="sqldsIrakasleakTaldeak">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLanBerria" runat="server" Text="Lan berria gehitu" />
            <br />
            <br />
            <asp:SqlDataSource
                id="sqldsIrakasleakTaldeak"
                runat="server"
                ProviderName="System.Data.SqlClient"
                ConnectionString="Server=tcp:sgta2022-aritzplazaola.database.windows.net,1433;Initial Catalog=sgta2022-aritzplazaola;Persist Security Info=False;User ID=sgta2022-aritzplazaola;Password=softGTA3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                SelectCommand="SELECT KlasekoTaldeak.irakasgaiKodea FROM (KlasekoTaldeak INNER JOIN IrakasleakTaldeak ON KlasekoTaldeak.kodea = IrakasleakTaldeak.taldeKodea) WHERE (IrakasleakTaldeak.email = @email)">
            </asp:SqlDataSource>
            <asp:SqlDataSource 
                ID="sqldsLanGenerikoak" 
                runat="server" 
                ConnectionString="Server=tcp:sgta2022-aritzplazaola.database.windows.net,1433;Initial Catalog=sgta2022-aritzplazaola;Persist Security Info=False;User ID=sgta2022-aritzplazaola;Password=softGTA3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                ProviderName="System.Data.SqlClient"
                SelectCommand="SELECT * FROM [LanGenerikoak] WHERE ([irakasgaiKodea] = @irakasgaiKodea)"
                >
            </asp:SqlDataSource>
            <asp:GridView
                id="grvLanGenerikoak"
                runat="server"
                DataSourceID="sqldsLanGenerikoak" AllowSorting="True" AutoGenerateEditButton="True">
            </asp:GridView>
            <br />
            <br />
            <asp:HyperLink ID="hypSaioaAmaitu" runat="server" NavigateUrl="~/Amaiera.aspx">Saioa amaitu</asp:HyperLink>
            <br />

        </div>
    </form>
</body>
</html>
