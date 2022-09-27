<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="AspInvoice.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="IDINPUT" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="NAME"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="NAMEINPUT" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="QUANTITY"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="QUANTITYINPUT" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="PRICE"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="PRICEINPUT" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="ADDB" runat="server" OnClick="ADDB_Click" Text="ADD" />
            <asp:Button ID="EDITB" runat="server" OnClick="EDITB_Click" Text="EDIT" />
            <asp:Button ID="DELETEB" runat="server" OnClick="DELETEB_Click" Text="DELETE" />
            <asp:GridView ID="GV1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GV1_SelectedIndexChanged">
            </asp:GridView>
        </p>
        <asp:Button ID="Items" runat="server" OnClick="Seller_Click" Text="Items" />
        <asp:Button ID="PersonalB" runat="server" OnClick="PersonalB_Click" Text="Personal" Width="102px" />
    </form>
</body>
</html>
