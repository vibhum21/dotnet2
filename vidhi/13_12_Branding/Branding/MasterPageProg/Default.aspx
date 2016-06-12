<%@ Page Language="C#" Title="Content Page" MasterPageFile="~/MasterBlue.master"%>
<%@ MasterType TypeName="BaseMaster" %>
<script runat="server">
    protected void Page_PreInit(Object sender, EventArgs e)
    {
        this.MasterPageFile = "MasterBlue.master";
        if(Request.QueryString["color"] == "green")
        {
            this.MasterPageFile = "MasterGreen.master";
        }
        this.Title = Master.MyTitle;
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" 
        Runat="Server">
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black"
        BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black"
        Height="250px" NextPrevFormat="ShortMonth" Width="330px">
        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
        <TodayDayStyle BackColor="#999999" ForeColor="White" />
        <DayStyle BackColor="#CCCCCC" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt"
            ForeColor="White" Height="12pt" />
    </asp:Calendar>
</asp:Content>
