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
            <asp:ListItem Value="Kodea" Enabled="False" Selected="True">Kodea</asp:ListItem>
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
        
        <asp:GridView ID="grvLanak" runat="server" AutoGenerateColumns="False" DataKeyNames="kodea" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AllowSorting="True">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:ButtonField Text="Instantziatu" />
                <asp:BoundField DataField="kodea" HeaderText="Kodea" SortExpression="kodea" />
                <asp:BoundField DataField="deskribapena" HeaderText="Deskribapena" />
                <asp:BoundField DataField="aurreikusitakoOrduak" HeaderText="Aurreikusitako Orduak" />
                <asp:BoundField DataField="lanMota" HeaderText="Lan Mota" />
            </Columns>
            
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
            
        </asp:GridView>
     
    </form>
</body>
</html>
