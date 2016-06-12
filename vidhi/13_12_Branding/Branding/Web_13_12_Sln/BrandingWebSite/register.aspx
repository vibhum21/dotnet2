<%@ Page Title="" Language="C#" MasterPageFile="~/site.master"
     AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register"
     EnableTheming="true" Theme="SilverGold"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            width: 104px;
        }
    .auto-style5 {
        width: 104px;
        height: 26px;
    }
    .auto-style6 {
        height: 26px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please  add first Name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Italic="False" ForeColor="Black" Text="Last Name"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please Add LastName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label5" runat="server" Text="City"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Pune</asp:ListItem>
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Chennai</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>Hydrabad</asp:ListItem>
                    <asp:ListItem>Nagpur</asp:ListItem>
                    <asp:ListItem>Amrawati</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label6" runat="server" Text="Birth Date"></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Calendar ID="Calendar2" runat="server" EnableTheming="False"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Register" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

