<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Menua.aspx.vb" Inherits="ErabiltzaileErregistratuak.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:HyperLink ID="hylPasaAlda" runat="server" NavigateUrl="~/PasahitzaAldatu.aspx">Pasahitza Aldatu</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hylSaioaAmaitu" runat="server" NavigateUrl="Amaiera.aspx">Saioa amaitu</asp:HyperLink>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
