<html>
	<head>
		<title>DataBinding1.aspx</title></head>
	<body>
		<a href="DataBinding1.aspx">
			<h3>
				<font face="Verdana">Simple Data Binding</font>
			</h3>
		</a>
		<form runat="server">
			Customer:
			<%# custID %>
			<p>
				1 + 2 =
				<%# "the result is " + (1 + 2) + ", the time is " +  DateTime.Now.ToLongTimeString() %>
			<p>
				label1:
				<asp:Label id="label1" Text="<%# custID %>" runat="server" />
			<p>
				text1:
				<asp:TextBox id="textbox1" runat="server" />
			<p>
			</p>
			label2:
			<asp:Label id="label2" Text="<%# textbox1.Text %>" runat="server" />
			<p>
			</p>
			<asp:Button id="button1" text="Call Page.DataBind()" onClick="PageDataBind" runat="server" />
			<asp:Button id="button2" text="Call label1.DataBind()" onClick="Label1DataBind" runat="server" />
			<asp:Button id="button3" text="Do Nothing" onClick="DoNothing" runat="server" />
			<script language="c#" runat="server">
// When page loads, indicate if it's in a postback
public void Page_Load(object s, EventArgs e) {
  Response.Write("In Page_Load, Page.IsPostBack = " + Page.IsPostBack + "<br>");
}

// custID is a read-only property of this Page object
string custID {
  get { return "Cust1123581121"; }
}

// Bind all controls on the page
public void PageDataBind(object sender, System.EventArgs e) {
  Page.DataBind();
}

// Bind just label1
public void Label1DataBind(object sender, System.EventArgs e) {
  label1.DataBind();
}

// Don't do anything: demonstrates that state is maintained
public void DoNothing(object sender, System.EventArgs e) {
}
			</script>
		</form>
	</body>
</html>
