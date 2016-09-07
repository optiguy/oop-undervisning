<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KurvClass.Default" %>

<%@ Register src="CartView.ascx" tagname="CartView" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div> n
        <h1>Produkt der skal lægges i kurven</h1>
        <p>Det er selvfølgelig ikke sådan et produkt ser ud på en side, men det er istedet for at hive det ud af databasen.<br />
            Her kan du tilføje testprodukter til din kurv. Udfyld de fire felter og tryk tilføj. Prøv at tilføje det samme produkt flere gange.</p>
        <table>
            <tr>
                <td>Id</td>
                <td>
                    <asp:TextBox ID="TB_id" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Navn</td>
                <td><asp:TextBox ID="TB_name" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Pris</td>
                <td><asp:TextBox ID="TB_price" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Antal</td>
                <td><asp:TextBox ID="TB_amount" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Btn_submit" runat="server" Text="Put i kurv" OnClick="Button_submit_Click" /></td>
            </tr>
        </table>
        <h1>Indkøbskurv</h1>
        <uc1:CartView ID="CartViewControl" runat="server" />

    </div>
    </form>
</body>
</html>
