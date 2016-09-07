﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CartView.ascx.cs" Inherits="KurvClass.CartView" %>

<asp:Repeater ID="Rpt_cartview" runat="server" OnItemCommand="Rpt_cartview_ItemCommand">
    <HeaderTemplate>
        <table>
            <thead>
                <th>Billede</th>
                <th>Navn</th>
                <th>Pris</th>
                <th>Antal</th>
                <th>Ialt</th>
                <th></th>
            </thead>
            <tbody>
    </HeaderTemplate>
    <ItemTemplate>
            <tr>
                <td>
                    <asp:Image ID="Img_product" runat="server" ImageUrl='<%# Eval("Image") %>' /></td>
                <td><%# Eval("Name") %></td>
                <td><%# Eval("Price") %></td>
                <td>
                    <asp:LinkButton ID="Btn_minus" CommandName="minus" CommandArgument='<%# Eval("Id") %>' runat="server">-</asp:LinkButton>
                    <%# Eval("Amount") %>
                    <asp:LinkButton ID="Btn_plus" CommandName="plus" CommandArgument='<%# Eval("Id") %>' runat="server">+</asp:LinkButton>
                </td>
                <td><%# Eval("TotalPrice") %></td>
                <td>Moms udgør <%# Eval("Vat") %></td>
                <td>
                    <asp:Button ID="Btn_delete" runat="server" CommandName="delete" CommandArgument='<%# Eval("Id") %>' Text="Slet" /></td>
            </tr>
    </ItemTemplate>
    <FooterTemplate>
            </tbody>
        </table>
    </FooterTemplate>
</asp:Repeater>

<asp:Button ID="Btn_emptyCart" runat="server" Text="Tøm indkøbskurv" OnClick="Btn_emptyCart_Click" />