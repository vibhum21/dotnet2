<%@ Page Language="C#" AutoEventWireup="true" CodeFile="checkme.aspx.cs" Inherits="checkme" %>

<%@ Register src="CredentialControl.ascx" tagname="CredentialControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:CredentialControl ID="CredentialControl1" runat="server" />
    
    </div>
    </form>
</body>
</html>
