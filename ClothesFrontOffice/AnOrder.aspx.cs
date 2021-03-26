using System;
using System.Collections.Generic;
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
        //capture the Order_Cus_ID
        string Order_Cus_ID = txtOrderCusNo.Text;
        //capture the Order_Pro_ID
        string Order_Product_ID = txtOrderProNo.Text;
        //capture the Order_type
        string Order_Type = txtOrderType.Text;
        //capture the Order_Date
        string Order_Date = txtOrderDate.Text;
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
        if(Error =="")
        {
            //capture the orderCusID
            AnOrder.Order_Cus_ID = txtOrderCusNo.Text;

            //capture the orderProID
            AnOrder.Order_Pro_ID = txtOrderProNo.Text;

            //capture the orderType
            AnOrder.Order_Type = txtOrderType.Text;

            //capture the orderDate
            AnOrder.Order_Date = Convert.ToDateTime(Order_Date);

            //store the order in the session object
            Session["AnOrder"] = AnOrder;

            //redirect to the viewer page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
       
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
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderCusNo.Text = AnOrder.Order_Cus_No.ToString();
            txtOrderProNo.Text = AnOrder.Order_Product_ID.ToString();
            txtOrderType.Text = AnOrder.Order_Type;
            txtOrderDate.Text = AnOrder.Order_Date.ToString();
        }
    }
}

public class clsOrder
{
  
    public object Order_Product_ID { get; internal set; }
    public string Order_Type { get; internal set; }
    public object Order_Date { get; internal set; }
    public string Order_ID { get; internal set; }
    public string Order_Cus_ID { get; internal set; }
    public object Order_Cus_No { get; internal set; }
    public string Order_Pro_ID { get; internal set; }

    internal bool Find(int Order_ID)
    {
        Order_ID = 111;
        Order_Cus_No = 1;
        Order_Product_ID = 1;
        Order_Type = "Nike Tshirt";
        Order_Date = Convert.ToDateTime("13/02/2020");
        return true;
    }

    internal string Valid(string order_Cus_ID, string order_Product_ID, string order_Type, string order_Date)
    {
        throw new NotImplementedException();
    }
}