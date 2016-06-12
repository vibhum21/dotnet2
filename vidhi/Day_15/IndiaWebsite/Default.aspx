<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>Welcome</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
               
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>Poor</asp:ListItem>
                    <asp:ListItem>Good</asp:ListItem>
                    <asp:ListItem>Very Good</asp:ListItem>
                    <asp:ListItem>Excellent</asp:ListItem>
                </asp:RadioButtonList>
               
            </td>
        </tr>
        <tr>
            <td> <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" /></td>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server">Like</asp:LinkButton>
            </td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
