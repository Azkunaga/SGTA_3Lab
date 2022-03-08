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
            <asp:DropDownList ID="ddlIrakasgaiak" runat="server" DataSourceID="sqldsIrakasleakTaldeak" DataTextField="irakasgaiKodea" AutoPostBack="True">
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
                <SelectParameters>
                    <asp:SessionParameter Name="email" SessionField="email" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource 
                ID="sqldsLanGenerikoak" 
                runat="server" 
                ConnectionString="Server=tcp:sgta2022-aritzplazaola.database.windows.net,1433;Initial Catalog=sgta2022-aritzplazaola;Persist Security Info=False;User ID=sgta2022-aritzplazaola;Password=softGTA3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                ProviderName="System.Data.SqlClient"
                SelectCommand="SELECT * FROM [LanGenerikoak] WHERE ([irakasgaiKodea] = @irakasgaiKodea)"
                >
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlIrakasgaiak" Name="irakasgaiKodea" PropertyName="SelectedValue" Type="String"  />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView
                id="grvLanGenerikoak"
                runat="server"
                DataSourceID="sqldsLanGenerikoak" AllowSorting="True" AutoGenerateEditButton="True" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="kodea" HeaderText="Kodea" />
                    <asp:BoundField DataField="deskribapena" HeaderText="Deskribapena" />
                    <asp:BoundField DataField="irakasgaiKodea" HeaderText="Irakasgai Kodea" />
                    <asp:BoundField DataField="aurreikusitakoOrduak" HeaderText="Aurreikusitako orduak" />
                    <asp:BoundField DataField="ustiapenean" HeaderText="Ustiapenean" />
                    <asp:BoundField DataField="lanMota" HeaderText="Lan mota" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <asp:HyperLink ID="hypSaioaAmaitu" runat="server" NavigateUrl="~/Hasiera.aspx">Saioa amaitu</asp:HyperLink>
            <br />

        </div>
    </form>
</body>
</html>
