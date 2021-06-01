<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Metrobankexam.aspx.cs" Inherits="metrobankexam.Metrobankexam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       Search Product ID: <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox><asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <hr />
        <table>
            <tr>
                <td>Product ID</td>
                 <td>Product Name</td>
                 <td>Price</td>
                 <td>Qty</td>
               
            </tr>
           <tr>
                <td>
                    <asp:Label ID="lblProductID" runat="server" Text=""></asp:Label></td>
               
               <td>
                    <asp:Label ID="lblProductName" runat="server" Text=""></asp:Label></td>
               <td>
                    <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label></td>
               <td>
                     <asp:TextBox ID="txtQty" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="btnAddtoCart" runat="server" Text="Add to Cart" OnClick="btnAddtoCart_Click" /></td>
           </tr>
        </table>
        <hr />
        <asp:Label ID="lblOrderList" runat="server" Text="Ordered List"></asp:Label>
        
        <hr />
        <asp:GridView ID="GridOrder" runat="server"></asp:GridView>

        Total Amount: <asp:Label ID="txtTotalAmount" runat="server" Text=""></asp:Label><br />
        Cash: <asp:TextBox ID="txtCash" runat="server"></asp:TextBox><br />
        Change: <asp:Label ID="txtChange" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="SaveTransaction" runat="server" Text="Save Transaction" OnClick="SaveTransaction_Click" />
        <hr />
        <asp:Label ID="txtSuccess" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
