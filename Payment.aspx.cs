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

public partial class Payment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("signin.aspx");  
        }
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                filldata();
            }
        }
    }

    private void filldata()
    {
        //throw new NotImplementedException();
        using (Package obj = new Package())
        {
            DataSet ds = new DataSet();
            obj._id =Convert.ToInt64(Request.QueryString["id"].ToString());   
            ds = obj.package_Select_byid();
            if (ds.Tables[0].Rows.Count > 0)
            {
               double  amt=Convert.ToDouble(ds.Tables[0].Rows[0]["Credit"].ToString());
               txtpname.Text = ds.Tables[0].Rows[0]["name"].ToString();     
                txtcamount.Text = amt.ToString();
                txttamount.Text = (0.085 * amt).ToString();
                txtnamount.Text = (amt + Convert.ToDouble(txttamount.Text)).ToString();  
            }
        }

    }
    protected void btnpay_Click(object sender, EventArgs e)
    {
        using (Package obj = new Package())
        { 
            obj._id=Convert.ToInt64 (Request.QueryString["id"].ToString());
            obj._uid = Convert.ToInt64(Session["UserID"].ToString());
            obj._date = Convert.ToDateTime(System.DateTime.Now);
            obj.tid = "123456";  

            obj.packagetransacation_insert(); 
        }
        using (users obj = new users())
        {

            obj.uid = Convert.ToInt64(Session["UserID"].ToString());
            DataSet ds = new DataSet(); 
            ds=obj.user_select_byid();
            double amt=0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                amt = Convert.ToDouble(ds.Tables[0].Rows[0]["Balance"].ToString());  
            }
            obj.balanceid = amt+Convert.ToDouble(txtcamount.Text.ToString());
            obj.user_updatebalance(); 
        }
        Response.Redirect("Myaccount.aspx");  
    }
}
