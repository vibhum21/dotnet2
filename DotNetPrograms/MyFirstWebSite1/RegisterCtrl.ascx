<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RegisterCtrl.ascx.cs" Inherits="RegisterCtrl" %>
<style type="text/css">

        .auto-style5 {
            width: 154px;
            height: 36px;
        }
        .auto-style6 {
            height: 36px;
        width: 498px;
    }
        .auto-style7 {
            width: 154px;
            height: 34px;
        }
        .auto-style8 {
        height: 34px;
        width: 498px;
    }
        .auto-style4 {
        width: 154px;
    }
        .auto-style9 {
            width: 154px;
            height: 33px;
        }
        .auto-style10 {
            height: 33px;
        width: 498px;
    }
        .auto-style37 {
        width: 154px;
        height: 27px;
    }
        .auto-style23 {
            height: 27px;
        width: 498px;
    }
        .auto-style38 {
        width: 498px;
    }
    .auto-style39 {
        width: 100%;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style5">
            <asp:Label ID="Label3" runat="server" Text="First Name" BorderStyle="None"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Your First Name" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="Label4" runat="server" Text="Last Name"></asp:Label>
        </td>
        <td class="auto-style8">
            <asp:TextBox ID="TextBox2" runat="server" Width="155px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Your Last Name" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="Label5" runat="server" Text="City"></asp:Label>
        </td>
        <td class="auto-style8">
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Jaipur</asp:ListItem>
                <asp:ListItem>Pune</asp:ListItem>
                <asp:ListItem>Mumbai</asp:ListItem>
                <asp:ListItem>Delhi</asp:ListItem>
                <asp:ListItem>Nagpur</asp:ListItem>
                <asp:ListItem>Bangalore</asp:ListItem>
                <asp:ListItem>Noida</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Select A City" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>
            <table class="auto-style39">
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Mobile No."></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
        <td class="auto-style38">
            <asp:TextBox ID="TextBox4" runat="server" Width="260px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please enter a correct email" ForeColor="Red"></asp:RequiredFieldValidator>
            <table class="auto-style39">
                <tr>
                    <td>
            <asp:TextBox ID="TextBox6" runat="server" Width="179px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please enter your mobile no." ForeColor="Red" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">
            <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>
        </td>
        <td class="auto-style10">
            <asp:TextBox ID="TextBox3" runat="server" Width="260px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please enter a password" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style37">
            <asp:Label ID="Label9" runat="server" Text="Password Again"></asp:Label>
        </td>
        <td class="auto-style23">
            <asp:TextBox ID="TextBox5" runat="server" Width="260px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox5" ErrorMessage="Please enter a correct password " ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox5" ErrorMessage="Passwords don't match" ForeColor="Red"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Label ID="Label11" runat="server" Text="Role"></asp:Label>
        </td>
        <td class="auto-style38">
            <asp:Label ID="Label12" runat="server" Text="Customer"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style38">
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        </td>
    </tr>
</table>

