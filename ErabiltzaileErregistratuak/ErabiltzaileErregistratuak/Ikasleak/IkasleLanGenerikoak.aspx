<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="IkasleLanGenerikoak.aspx.vb" Inherits="ErabiltzaileErregistratuak.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="IKASLEA LAN GENERIKOEN KUDEAKETA"></asp:Label>
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="Hautatu irakasgaia(matrikulatutakoak baino ez dira azaltzen):"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ddlIrakasgaiak" runat="server">
        </asp:DropDownList>
        <asp:CheckBoxList ID="cblLanEzaugarri" runat="server">
            <asp:ListItem Value="Kodea">Kodea</asp:ListItem>
            <asp:ListItem Value="Deskribapena"></asp:ListItem>
            <asp:ListItem Value="AurOrd">Aurreikusitako orduak</asp:ListItem>
            <asp:ListItem Value="LanMota">Lan mota</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="btnLanakBistaratu" runat="server" Text="Ikusi lanak" />
        <br />
        <asp:Label ID="lblErrMezu" runat="server" Text="   "></asp:Label>
        <br />
        <br />
        <asp:GridView ID="grvLanak" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
