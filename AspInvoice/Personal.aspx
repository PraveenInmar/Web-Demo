<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personal.aspx.cs" Inherits="AspInvoice.Personal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Personal Details"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="IDINPUT" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="NAME"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="NAMEINPUT" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Age" runat="server" Text="Age"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Ageinput" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Addressinput" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="ADDB" runat="server" OnClick="ADDB_Click" Text="ADD" />
        <asp:Button ID="EDITB" runat="server" OnClick="EDITB_Click" Text="EDIT" />
        <asp:Button ID="DELETEB" runat="server" OnClick="DELETEB_Click" Text="DELETE" />
        <asp:GridView ID="PersonalDGV" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GV1_SelectedIndexChanged">
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" Text="Shoping." Width="122px" OnClick="Button2_Click" />
        <asp:Button ID="Product" runat="server" OnClick="Product_Click" Text="Product" Width="97px" />
    </form>
</body>
</html>
