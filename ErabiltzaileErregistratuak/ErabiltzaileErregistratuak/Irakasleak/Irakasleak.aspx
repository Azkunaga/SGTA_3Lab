<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Irakasleak.aspx.vb" Inherits="ErabiltzaileErregistratuak.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 150px; height: 150px; float:left; background-color: #ffde82;">
            <asp:HyperLink ID="hypLanGene" runat="server">Irakasgaiak</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hypLanPer" runat="server" NavigateUrl="~/Irakasleak/IrakasleLanak.aspx">Lanak</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hypTaldeak" runat="server">Taldeak</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hypPasaAlda" runat="server" NavigateUrl="~/PasahitzaAldatu.aspx">Pasahitza aldatu</asp:HyperLink>
        </div>
        <div style="float:left; height: 150px; width: 379px; text-align:center; background-color: #d7fcf1;">
                <asp:Label ID="Label1" runat="server" Text="Lanen Kudeaketa"></asp:Label><br /><br />
                <asp:Label ID="Label2" runat="server" Text="Irakasleak"></asp:Label>
        </div>
    </form>
</body>
</html>
