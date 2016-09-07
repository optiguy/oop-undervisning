<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="Optiguy.checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-width {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-width">
            <tr>
                <td>Email : <asp:TextBox ID="TB_email" runat="server"></asp:TextBox></td>
                <td>Password : <asp:TextBox ID="TB_password" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Navn : <asp:TextBox ID="TB_name" runat="server"></asp:TextBox></td>
                <td>Adresse : <asp:TextBox ID="TB_address" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Post nr. : <asp:TextBox ID="TB_zip" runat="server"></asp:TextBox></td>
                <td>By : <asp:TextBox ID="TB_city" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Btn_saveOrder" runat="server" Text="Gem ordre" OnClick="Btn_saveOrder_click" />
                &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
