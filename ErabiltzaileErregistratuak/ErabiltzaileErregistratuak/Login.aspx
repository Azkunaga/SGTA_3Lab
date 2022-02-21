<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="ErabiltzaileErregistratuak.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Emaila:"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtEmail" runat="server" style="margin-right: 0px" Width="869px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPasahitza" runat="server" Text="Pasahitza:"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtPasahitza" runat="server" Width="849px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn2Login" runat="server" Text="Log In" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblErrMezua" runat="server" Text="   "></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn2Erregistratu" runat="server" Text="Erregistratu" />
            <br />
            <br />
            <asp:Button ID="btnPasaBerr" runat="server" Text="Pasahitza Berreskuratu" />
        </div>
    </form>
</body>
</html>
