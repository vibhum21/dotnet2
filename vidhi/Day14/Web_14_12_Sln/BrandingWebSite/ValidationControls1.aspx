<% @ Page language="c#" %>
<%@ Import namespace="System.Web.UI.WebControls" %>
<%-- @ Page language="c#" ClientTarget="DownLevel"  --%>
<html>
	<head>
		<title>ValidationControls1.aspx</title>
	</head>
	<script runat="server">

// This button control event will be called when the button is clicked
public void button1_Click (object sender, System.EventArgs e) 
{
  label1.Text = "Hello, the time is now " + DateTime.Now.ToLongTimeString()  
    + "<br>Page.IsValid = " + Page.IsValid;
}

	</script>
	<body>
		<form method="post" runat="server">
			<table>
				<tr>
					<td>
						RequiredFieldValidator
					</td>
					<td>
						<asp:textbox id="text1" value="" runat="server" />
					</td>
					<td>
						<asp:RequiredFieldValidator id="text1val" ControlToValidate="text1" 
                            Text="You must specify a value" 
                            runat="server" Display="Static"
                             ErrorMessage="RequiredField" />
					</td>
				</tr>
				<tr>
					<td>
						CompareValidator: integer field
					</td>
					<td>
						<asp:textbox id="text2" value="" runat="server" />
					</td>
					<td>
						<asp:CompareValidator id="text2val"
                             ControlToValidate="text2" 
                            Operator="DataTypeCheck" Type="Integer" 
                            Text="Must be integer" Display="Dynamic"
                             ErrorMessage="Integer" runat="server" />
					</td>
				</tr>
				<tr>
					<td>
						CompareValidator: One field less than other
					</td>
					<td>
						<asp:textbox id="text3" value="" runat="server" />
						<br>
						<asp:textbox id="text4" value="" runat="server" />
					</td>
					<td>
						<asp:CompareValidator id="text3val" 
                            ControlToValidate="text3"
                            ControlToCompare="text4"
                            Operator="LessThan" 
                            Type="Integer" 
                            Text="First field must be less than second"
                             runat="server" Display="Dynamic" 
                            ErrorMessage="Less than" />
					</td>
				</tr>
				<tr>
					<td>
						RangeValidator
					</td>
					<td>
						<asp:textbox id="text5" value="" runat="server" />
						<br>
					</td>
					<td>
						<asp:RangeValidator id="text5val" ControlToValidate="text5"
                             MinimumValue="2" MaximumValue="5" 
                            Type="Integer" 
                            Text="Value must be between 2 and 5, inclusive" runat="server" Display="Dynamic" ErrorMessage="Range" />
					</td>
				</tr>
				<tr>
					<td>
						RegularExpressionValidator
					</td>
					<td>
						<asp:textbox id="text6" value="" runat="server" />
						<br>
					</td>
					<td>
						<asp:RegularExpressionValidator id="text6val" runat="server" 
                            ControlToValidate="text6" 
                            ValidationExpression="^\d{5}$"
                             Display="Dynamic" 
                            ErrorMessage="Regular expression">
Zip code must be 5 numeric digits
</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td>
						CustomValidator: even number
					</td>
					<td>
						<asp:textbox id="text7" value="2" 
                            runat="server" />
						<br>
					</td>
					<td>
						<asp:CustomValidator id="text7val" 
                            runat="server" 
                            ControlToValidate="Text7" 
                            OnServerValidate="ServerValidate" 
                            Display="Dynamic" ErrorMessage="Custom">
Must be an even number!
</asp:CustomValidator>
					</td>
				</tr>
<script language="c#" runat="server">
void ServerValidate (object sender, ServerValidateEventArgs args) {
  int num = Int32.Parse(args.Value);
  if ((num % 2) == 0)
    args.IsValid = true;
  else
    args.IsValid = false;
}
				</script>
			</table>
			<p>
				<asp:Button id="button1" onClick="button1_Click" text="Push Me" runat="server" />
			<p>
				<asp:Label id="label1" runat="server" />
			<p>
				<asp:ValidationSummary ID="valSum" runat="server" HeaderText="Error in the following field(s):" DisplayMode="SingleParagraph" />
		</form>
	</body>
</html>
