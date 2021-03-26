using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsProduct
        clsProduct AProduct = new clsProduct
        {
            //capture the Product ID
            ProductID = txtID.Text,
            //capture the Product Name
            Name = txtName.Text,
            //capture the Product Price
            Price = txtPrice.Text,
            //capture the product description
            Description = txtDescription.Text
        };
        //store the product name in the session object
        Session["AProduct"] = AProduct;
        //redirect to the viewer page
        Response.Redirect("ProductViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the product class
        clsProduct AProduct = new clsProduct();
        //variable to store the primary key
        Int32 ProductID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ProductID = Convert.ToInt32(txtID.Text);
        //find the record
        Found = AProduct.Find(ProductID);
        //if found
        if (Found == true)
        {
            //display the values of the product in the form
            txtName.Text = AProduct.Name;
            txtPrice.Text = AProduct.Price;
            txtDescription.Text = AProduct.Description;

        }
        
    }
}