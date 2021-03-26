using Clothes_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        //creatr instance new Orderclass
        clsOrder AnOrder = new clsOrder();

        //capture the orderType
        AnOrder.Order_ID = txtOrderID.Text;

        //store the order in the session object
        Session["AnOrder"] = AnOrder;

        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }



    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        //creat an inatance of the Order class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key 
        Int32 Order_ID;
        //variable to store the results of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Order_ID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(Order_ID);

        //if found
        if(Found == true)
        {
            //display the values of the properties in the form
            txtOrderCusNo.Text = AnOrder.Order_Cus_No.ToString();
            txtOrderProNo.Text = AnOrder.Order_Product_ID.ToString();
            txtOrderType.Text = AnOrder.Order_Type;
            txtOrderDate.Text = AnOrder.Order_Date.ToString();
        }
    }
}