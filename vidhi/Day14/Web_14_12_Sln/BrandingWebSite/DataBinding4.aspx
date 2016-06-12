<%@ Import namespace="System.Data.SqlClient" %>
<%@ Import namespace="System.Data" %>
<HTML>
	<HEAD>
		<title>DataBinding4.aspx</title>
	</HEAD>
	<body>
		<a href="DataBinding4.aspx">
			<h3>
				<font face="Verdana">DataGrid</font>
			</h3>
		</a>
		<form runat="server">
			<asp:Label id="msg" runat="server" />
			<hr>
			<h3>
				DataGrid1:
			</h3>
			<asp:DataGrid id="DataGrid1" 
                DataSource="<%# GetSampleData() %>" 
                runat="server" />
			<hr>
			<h3>
				DataGrid2:
			</h3>
			<asp:DataGrid id="DataGrid2" runat="server" 
                DataSource="<%# GetSampleData() %>" 
                EnableViewState="False" Width="700" 
                BackColor="#ccccff" BorderColor="black" 
                ShowFooter="false" CellPadding="3"
                 CellSpacing="0" Font-Name="Verdana" 
                Font-Size="8pt" 
                HeaderStyle-BackColor="#aaaadd" />
			<hr>
			<h3>
				DataGrid3:
			</h3>
			<asp:datagrid id="DataGrid3"
                 DataSource="<%# GetSampleData() %>" 
                autogeneratecolumns="false" runat="server" Width="700" BackColor="#ccccff" BorderColor="black" ShowFooter="false" CellPadding="3" CellSpacing="0" Font-Name="Verdana" Font-Size="8pt" HeaderStyle-BackColor="#aaaadd" AlternatingItemStyle-BackColor="Moccasin">
            <COLUMNS>
					<asp:BoundColumn DataField="CategoryName"
                         HeaderText="Category Name">
					</asp:BoundColumn>
					<asp:BoundColumn DataField="CategoryDescription"
                         HeaderText="Category Description">
					</asp:BoundColumn>
				</COLUMNS>
            </asp:datagrid>
			<hr>
			<asp:Button id="button3" text="Do Nothing" onClick="DoNothing" runat="server" />
			<script language="c#" runat="server">

public void Page_Load(object s, EventArgs e) {
  msg.Text = "Page.IsPostBack = " + Page.IsPostBack;

  if (! Page.IsPostBack) {
    Page.DataBind();
  }
}

DataView m_cachedDV;

DataView GetSampleData() {
  if (m_cachedDV == null) {
    DataSet ds;
    SqlConnection cxn = new SqlConnection("server=tfl;uid=sa;pwd=P@ssw0rd123;database=db_7773");;
    SqlDataAdapter adp = new SqlDataAdapter("select CategoryID, CategoryName, CategoryDescription from Category", cxn);
    ds = new DataSet();
    adp.Fill(ds, "Category");
    m_cachedDV = ds.Tables["Category"].DefaultView;
  }
  return m_cachedDV;
  //return null;
}

// Don't do anything: demonstrates that state is maintained
public void DoNothing(object sender, System.EventArgs e) {
}

			</script>
		</form>
	</body>
</HTML>
