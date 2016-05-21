using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text; 

public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsg  .Visible = false;   
        if (!IsPostBack)
        {
            Updateuserid();
            FillRepeater();
        }
    }
    public void Updateuserid()
    {
        if (Session["UserID"] != null)
        {
            if (Session["UserID"] != "")
            {
                using (cart obj = new cart())
                {
                    obj._userid = Convert.ToInt64(Session["UserID"].ToString());
                    obj._sessionid = Session["Current"].ToString();
                    obj._orderid = Convert.ToInt64("0");

                    obj.cart_updateuserid();


                    DataSet ds = new DataSet();
                    DataSet dsr = new DataSet();
                    ds = obj.cart_selectbyusoid();
                    dsr = obj.cart_selectbyuoid();
                    int i=dsr.Tables[0].Rows.Count;
                    int j=ds.Tables[0].Rows.Count;
                    if (i > j)
                    {
                        obj.cart_updatesessionid();   
                    }

                }
            }
        }
    }
    public void FillRepeater()
    { 
        
                    using (cart obj = new cart())
                    {
                        
                        if (Session["UserID"] != null)
                        {
                            if (Session["userID"] != "")
                            {
                                    obj._userid = Convert.ToInt64(Session["UserID"].ToString()  );
                            }

                        }
                        else
                        {
                             obj._userid = Convert.ToInt64("0"); 
                        }
                        obj._sessionid = Session["Current"].ToString();
                        obj._orderid = Convert.ToInt64("0");

                        DataSet ds = new DataSet();
                        ds = obj.cart_details();
                        Session["itemcount"] = ds.Tables[0].Rows.Count;  
                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            rptcart.DataSource = ds;
                            rptcart.DataBind();

                        }
                        else
                        {
                            rptcart.Visible = false;
                            lblMsg .Text = "No Product in Cart";
                            lblMsg .Visible = true;
                            totaldiv.Visible = false;
                            btnchkout.Visible = false;   
                        }
                        ds = obj.cart_total();
                        lbltotals.Text = ds.Tables[0].Rows[0]["total"].ToString();
                        Session["itemtotal"]  = ds.Tables[0].Rows[0]["total"].ToString();  
           }
      }
            

    protected void rptcart_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "DeleteData")
        {
            using (cart obj = new cart())
            {
                obj._id = Convert.ToInt64(e.CommandArgument.ToString());
                obj.cart_deletebyid();

                lblMsg .Text = "your item delete sucessfully";
                lblMsg .Visible = true; 
  

            }
            FillRepeater(); 
        }
    }
    protected void btnclearall_Click(object sender, EventArgs e)
    {
        using (cart obj = new cart())
        {
            if (Session["UserID"] != null)
            {
                if (Session["UserID"] != "")
                {
                    obj._userid = Convert.ToInt64(Session["UserID"].ToString());
                    obj._sessionid = Session["Current"].ToString();
                    obj._orderid = Convert.ToInt64("0");

                    obj.cart_clear();
                    FillRepeater();
                    lblMsg .Text = "Your Cart is Clear";
                    lblMsg .Visible = true;   
                }
            }
            else {
                obj._userid = Convert.ToInt64("0");
                obj._sessionid = Session["Current"].ToString();
                obj._orderid = Convert.ToInt64("0");

                obj.cart_clear();
                FillRepeater();
                lblMsg .Text = "Your Cart is Clear";
                lblMsg .Visible = true;   
            }
        }
    }
    protected void btnchkout_Click(object sender, EventArgs e)
    {
        
        if (Session["UserID"] != null)
        {
            
            Response.Redirect("Orderconfirmation.aspx");  
        }
        else {
            Response.Redirect("signin.aspx");  
        }
    }
}
    

