<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NavigationCtrl.ascx.cs" Inherits="NavigationCtrl" %>
<style type="text/css">

        .auto-style28 {
            width: 143px;
            height: 48px;
        }
        .auto-style27 {
            width: 54px;
            height: 48px;
        }
        .auto-style35 {
            width: 184px;
            height: 48px;
        }
        .auto-style33 {
            height: 48px;
        }
        .auto-style34 {
            height: 48px;
            width: 114px;
        }
        .auto-style36 {
            width: 107px;
            height: 48px;
        }
        .auto-style13 {
            width: 98%;
            height: 57px;
        }
        .auto-style39 {
        height: 48px;
        width: 126px;
    }
    .auto-style40 {
        width: 98px;
        height: 48px;
    }
        </style>

                                                <table class="auto-style13">
                                                    <tr>
                                                        <td class="auto-style28">
                                                            <asp:LinkButton ID="LinkButton10" runat="server" Font-Bold="False" Font-Underline="False" ForeColor="Black">Your Amazon.in</asp:LinkButton>
                                                        </td>
                                                        <td class="auto-style39">
                                                            <asp:LinkButton ID="LinkButton11" runat="server" Font-Underline="False" ForeColor="Black">Today&#39;s Deal</asp:LinkButton>
                                                        </td>
                                                        <td class="auto-style40">
                                                            <asp:LinkButton ID="LinkButton3" runat="server" Font-Underline="False" ForeColor="Black">Gift Cards</asp:LinkButton>
                                                        </td>
                                                        <td class="auto-style27">
                                                            <asp:LinkButton ID="LinkButton12" runat="server" Font-Underline="False" ForeColor="Black">Sell</asp:LinkButton>
                                                        </td>
                                                        <td class="auto-style35">
                                                            <asp:LinkButton ID="LinkButton13" runat="server" Font-Underline="False" ForeColor="Black">Customer Service</asp:LinkButton>
                                                        </td>
                                                        <td class="auto-style33"></td>
                                                        <td class="auto-style34">
                                                            <asp:Panel ID="Panel1" runat="server" Height="49px" Width="106px">
                                                                <asp:LinkButton ID="LinkButton14" runat="server" Font-Underline="False" ForeColor="Black" OnClick="LinkButton6_Click">Sign In</asp:LinkButton>
                                                                <br />
                                                                <asp:Label ID="Label3" runat="server" Text="Your Orders"></asp:Label>
                                                                <asp:Image ID="Image1" runat="server" Height="16px" ImageUrl="~/images/arrow.png" style="margin-left: 11px; margin-top: 11px" Width="16px" />
                                                            </asp:Panel>
                                                        </td>
                                                        <td class="auto-style36">
                                                            <asp:Panel ID="Panel2" runat="server" Height="37px" Width="87px">
                                                                <asp:Image ID="Image2" runat="server" Height="34px" ImageUrl="~/images/cart.png" />
                                                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Larger" Height="30px" Text="Cart"></asp:Label>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            

