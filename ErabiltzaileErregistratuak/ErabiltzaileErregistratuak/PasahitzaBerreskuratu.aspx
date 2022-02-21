<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PasahitzaBerreskuratu.aspx.vb" Inherits="ErabiltzaileErregistratuak.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblGalEzk" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblEra" runat="server" Text="Erantzuna: "></asp:Label>
            <asp:TextBox ID="txtErantzuna" runat="server" Width="395px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnPasaBerr" runat="server" Text="Pasahitza Berreskuratu" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogIn" runat="server" Text="LogIn" />
            <br />
            <asp:Label ID="lblEmaitza" runat="server" Text="              "></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
