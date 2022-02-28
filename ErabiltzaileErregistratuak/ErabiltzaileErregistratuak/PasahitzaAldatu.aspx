<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PasahitzaAldatu.aspx.vb" Inherits="ErabiltzaileErregistratuak.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOldPass" runat="server" Text="Pasahitz zaharra: "></asp:Label>
            <asp:TextBox ID="txtOldPass" runat="server" Width="301px"></asp:TextBox>
            <br />
            <asp:Label ID="lblNewPass" runat="server" Text="Pasahitz berria: "></asp:Label>
            <asp:TextBox ID="txtNewPass" runat="server" Width="303px"></asp:TextBox>
            <br />
            <asp:Label ID="lblNewPass2" runat="server" Text="Errepikatu pasahitz berria: "></asp:Label>
            <asp:TextBox ID="txtNewPass2" runat="server" Width="292px"></asp:TextBox>
            <br />
            <asp:Button ID="btnPasaAlda" runat="server" Text="Pasahitza aldatu" />
            <br />
            <br />
            <asp:Button ID="btnLogIn" runat="server" Text="LogIn" />
            <br />
            <br />
            <asp:Label ID="lblErrMezu" runat="server" Text="   "></asp:Label>
        </div>
    </form>
</body>
</html>
