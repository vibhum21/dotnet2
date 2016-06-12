<%@ Page Title="" Language="C#"
     MasterPageFile="~/site.master" 
    AutoEventWireup="true"
     CodeFile="Default.aspx.cs"
     Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
    <asp:DropDownList ID="DDLstCategory" runat="server" 
        AutoPostBack="True"
         OnSelectedIndexChanged="DDLstCategory_SelectedIndexChanged" >
        <asp:ListItem>Laptops</asp:ListItem>
        <asp:ListItem>SmartPhones</asp:ListItem>
        <asp:ListItem>SmartWatches</asp:ListItem>
        <asp:ListItem>Camera</asp:ListItem>
        <asp:ListItem>Tabs</asp:ListItem>
    </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ListBox ID="lstProducts" runat="server">
                    <asp:ListItem>GalaxyTab</asp:ListItem>
                    <asp:ListItem>Surface</asp:ListItem>
                    <asp:ListItem>Lenovo Yoga Tab</asp:ListItem>
                    <asp:ListItem>iPad</asp:ListItem>
                    <asp:ListItem>iBall</asp:ListItem>
                    <asp:ListItem>iMAXPad</asp:ListItem>
                </asp:ListBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

