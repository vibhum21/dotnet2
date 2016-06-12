<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style37 {
        width: 72%;
        margin-left: 168px;
    }
    .auto-style38 {
        height: 38px;
            }
    .auto-style39 {
        height: 16px;
    }
    .auto-style40 {
        height: 46px;
    }
    .auto-style41 {
        height: 34px;
            }
    .auto-style42 {
        height: 32px;
            }
        .auto-style43 {
            width: 100%;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style37" border="0">
    <tr>
        <td class="auto-style38">
            <asp:Label ID="Label5" runat="server" Font-Size="XX-Large" Text="Login"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label6" runat="server" Text="Email or mobile phone number"></asp:Label>
            <table class="auto-style43">
                
            </table>
        </td>
    </tr>
    <tr>
        <td class="auto-style42">
            <asp:TextBox ID="TextBox2" runat="server" Width="313px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Email or mobile number" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>
            <table class="auto-style43">
                
            </table>
        </td>
    </tr>
    <tr>
        <td class="auto-style41">
            <asp:TextBox ID="TextBox3" runat="server" Width="308px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter a password" ForeColor="Red" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style33">
            <asp:Button ID="Button1" runat="server" style="margin-left: 56px" Text="Login" Width="214px" OnClick="Button1_Click" />
        </td>
    </tr>
    <tr>
        <td class="auto-style33">
            <asp:Label ID="Label7" runat="server" Text="------------------New To Amazon-----------------"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button2" runat="server" style="margin-left: 29px" Text="I am a new Customer" Width="270px" OnClick="Button2_Click" CausesValidation="False" />
        </td>
    </tr>
</table>
</asp:Content>

