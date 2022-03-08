<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="LanGenerikoaGehitu.aspx.vb" Inherits="ErabiltzaileErregistratuak.WebForm14" %>
 
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
            <asp:Label ID="lblKodea" runat="server" Text="Kodea: "></asp:Label>
            <asp:TextBox ID="txtKodea" runat="server" Width="225px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDeskribapena" runat="server" Text="Deskribapena: "></asp:Label>
            <asp:TextBox ID="txtDeskribapena" runat="server" Width="503px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblIrakasgaia" runat="server" Text="Irakasgaia: "></asp:Label>
            <asp:DropDownList ID="ddlIrakasgaiak" runat="server" DataSourceID="odsDatuAtzipena" DataTextField="kodea">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblAurreOrduak" runat="server" Text="Aurreikusitako orduak: "></asp:Label>
            <asp:TextBox ID="txtAurreOrduak" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblLanMota" runat="server" Text="Lan mota: "></asp:Label>
            <asp:DropDownList ID="ddlLanMotak" runat="server">
                <asp:ListItem>Ariketa</asp:ListItem>
                <asp:ListItem>Azterketa</asp:ListItem>
                <asp:ListItem>Laborategia</asp:ListItem>
                <asp:ListItem>Lana</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnGehiLana" runat="server" Text="Gehitu lana" />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Irakasleak/IrakasleLanak.aspx">Ikusi lanak</asp:HyperLink>
            <br />
            <asp:ObjectDataSource
                ID="odsDatuAtzipena"
                runat="server"
                TypeName="DatuAtzipenekoak.DatuAtzipena"
                SelectMethod="IrakasgaiKodeenTaulaLortu"></asp:ObjectDataSource>
 
        </div>
    </form>
</body>
</html>