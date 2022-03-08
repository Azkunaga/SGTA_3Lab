<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="LanaInstantziatu.aspx.vb" Inherits="ErabiltzaileErregistratuak.WebForm12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 216px;
            margin-left: 44px;
        }
        #erabText {
            margin-left: 47px;
        }
        #lanText {
            margin-left: 35px;
        }
        #aurrText {
            margin-left: 25px;
        }
        #benText {
            margin-left: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="IKASLEA"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="LAN GENERIKOA INSTANTZIATU"></asp:Label>
        <asp:SqlDataSource ID="sqldsIkasleakLanak" runat="server" ConnectionString="Server=tcp:sgta2022-aritzplazaola.database.windows.net,1433;Initial Catalog=sgta2022-aritzplazaola;Persist Security Info=False;User ID=sgta2022-aritzplazaola;Password=softGTA3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" ProviderName="System.Data.SqlClient" SelectCommand=" SELECT * FROM [IkasleakLanak] WHERE ([email] = @email)">
            <SelectParameters>
                <asp:SessionParameter Name="email" SessionField="email" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <div>
            <div style="float:left;padding:10px; width: 1259px;">

            <div style="float:left; width: 330px;">
                <div style="float:left; padding-right:5px">
                    <asp:Label ID="Label3" runat="server" Text="Erabiktzailea"></asp:Label><asp:TextBox ID="erabText" runat="server" Enabled="False"></asp:TextBox><br /><br />
                    <asp:Label ID="Label4" runat="server" Text="Lan Generikoa"></asp:Label><asp:TextBox ID="lanaText" runat="server" Enabled="False" style="margin-left: 37px"></asp:TextBox><br /><br />
                    <asp:Label ID="Label5" runat="server" Text="Aurreik. orduak"></asp:Label><asp:TextBox ID="aurText" runat="server" style="margin-left: 27px"></asp:TextBox><br /><br />
                    <asp:Label ID="Label6" runat="server" Text="Benetako orduak"></asp:Label><asp:TextBox ID="benText" runat="server"></asp:TextBox>
                </div>
            <div>
                <br />
                <asp:Label ID="mezua" runat="server" Text=" "></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnLanaSortu" runat="server" Text="Lana Sortu" Height="53px" Width="148px" />

                <br />
                <br />
            <asp:HyperLink ID="hpatzera" runat="server" NavigateUrl="~/Ikasleak/IkasleLanGenerikoak.aspx">Atzera</asp:HyperLink>  
            </div>
            </div>
                <asp:GridView ID="gvIkasleLanak" runat="server" DataSourceID="sqldsIkasleakLanak">
                </asp:GridView>
            </div>
            <br />
        </div>

    </form>
</body>
</html>
