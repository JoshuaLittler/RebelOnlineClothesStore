using System;

public partial class AnOrder : System.Web.UI.Page
{
    

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        //creatr instance new Orderclass
        clsCustomer AnOrder = new clsCustomer();

        //capture the orderType
        AnOrder.Order_Type = txtOrderType.Text;

        //store the order in the session object
        Session["AnOrder"] = AnOrder;

        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}