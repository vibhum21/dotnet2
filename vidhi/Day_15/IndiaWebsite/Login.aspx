<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

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
                <td>
                    <asp:Login ID="Login1" runat="server">
                    </asp:Login>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
                        <WizardSteps>
                            <asp:CreateUserWizardStep runat="server" />
                            <asp:CompleteWizardStep runat="server" />
                        </WizardSteps>
                    </asp:CreateUserWizard>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:ChangePassword ID="ChangePassword1" runat="server">
                    </asp:ChangePassword>
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
