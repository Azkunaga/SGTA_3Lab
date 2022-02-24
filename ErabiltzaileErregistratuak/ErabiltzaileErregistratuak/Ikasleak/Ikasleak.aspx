<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Ikasleak.aspx.vb" Inherits="ErabiltzaileErregistratuak.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 351px; float:left">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ikasleak/IkasleLanGenerikoak.aspx">Lan generikoak</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server">Lan pertsonalak</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server">Taldeak</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/PasahitzaAldatu.aspx">Pasahitza aldatu</asp:HyperLink>
        </div>
        <div style="float:left; height: 152px; width: 379px; text-align:center;">
                <asp:Label ID="Label1" runat="server" Text="Lanen Kudeaketa"></asp:Label><br /><br />
                <asp:Label ID="Label2" runat="server" Text="Ikasleak"></asp:Label>
        </div>
    </form>
</body>
</html>
