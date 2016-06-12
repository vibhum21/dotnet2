
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Me.Response.Redirect("details.aspx?bookid=" & Me.GridView1.SelectedValue)

    End Sub
End Class
