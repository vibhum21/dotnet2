<%@ Page Debug="true" %>
<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<html>
	<head>
		<title>DataBinding3.aspx</title>
	</head>
	<body>
		<a href="DataBinding3.aspx">
			<h3>
				<font face="Verdana">Data Binding from a Database</font>
			</h3>
		</a>
		<form runat="server">
			<asp:Label id="msg" runat="server" />
			<p>

				<asp:DropDownList id="DropDown1" 
                    onSelectedIndexChanged="List_SelectedIndexChanged" 
                    autopostback="true"
                     runat="server" />
			<p>
				<asp:ListBox id="ListBox1"
                     onSelectedIndexChanged="List_SelectedIndexChanged"
                     DataValueField="CategoryID" 
                     DataTextField="CategoryName"
                     DataSource="<%# GetSampleDataDR() %>" 
                    autopostback="true" runat="server" />
			<p>
				<asp:CheckBoxList id="CheckboxList1" 
                    onSelectedIndexChanged="List_SelectedIndexChanged"
                     autopostback="true" runat="server" />
			<p>
				<asp:RadioButtonList id="RadiobuttonList1" 
                    onSelectedIndexChanged="List_SelectedIndexChanged"
                     autopostback="true" runat="server" />
            
                <script language="c#" runat="server">

// When page loads, indicate if it's in a postback
public void Page_Load(object s, EventArgs e) {
//  Response.Write("In Page_Load, Page.IsPostBack = " + Page.IsPostBack + "<br>");
  
  if (! Page.IsPostBack) {
    // Databind the drop down
    DropDown1.DataSource = GetSampleDataDR();
    DropDown1.DataValueField = "CategoryID";
    DropDown1.DataTextField = "CategoryName";
    DropDown1.DataBind();

    // Databind the list box
    ListBox1.DataBind();

    // Databind the list box to a data reader
    CheckboxList1.DataSource = GetSampleDataDR();
    CheckboxList1.DataValueField = "CategoryID";
    CheckboxList1.DataTextField = "CategoryName";
    CheckboxList1.DataBind();

    // Databind the radio button list
    RadiobuttonList1.DataSource = GetSampleDataDV();
    RadiobuttonList1.DataValueField = "CategoryID";
    RadiobuttonList1.DataTextField = "CategoryName";
    RadiobuttonList1.DataBind();
  }
}

IDataReader GetSampleDataDR() {
    SqlConnection cxn = new SqlConnection("server=tfl;uid=sa;pwd=P@ssw0rd123;database=db_7773");
    SqlCommand cmd = new SqlCommand("select CategoryID, CategoryName from Category", cxn);
    cxn.Open();
    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
    return dr;
}

DataView GetSampleDataDV() {
  DataSet ds;
  SqlConnection cxn = new SqlConnection("server=tfl;uid=sa;pwd=P@ssw0rd123;database=db_7773");
  SqlDataAdapter adp = new SqlDataAdapter("select CategoryID, CategoryName from Category", cxn);
  ds = new DataSet();
  adp.Fill(ds, "Category");
  return ds.Tables["Category"].DefaultView;
}

public void List_SelectedIndexChanged (object sender, System.EventArgs e) {
  ListControl control = ((ListControl)sender);
  if (control.SelectedIndex > -1)
    msg.Text = "You selected " + control.SelectedItem.Text + 
               ", Value = " + control.SelectedItem.Value;
  else
    msg.Text = "Value was unselected";
}

				</script>
		</form>
	</body>
</html>
