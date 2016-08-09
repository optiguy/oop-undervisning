<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="UserClass.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_user" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btn_opret" runat="server" Text="Login som gæst" OnClick="btn_opret_Click" />
            <asp:Button ID="brn_login" runat="server" Text="Login som bruger" OnClick="brn_login_Click" />
            <asp:Button ID="Button_logout" runat="server" Text="Log ud" OnClick="Button_logout_Click" />
            <asp:Button ID="btn_slet" runat="server" Text="Slet session" OnClick="btn_slet_Click"/>
            <br />
            <div id="div_username" runat="server"></div>
        </div>
    </form>
</body>
</html>
