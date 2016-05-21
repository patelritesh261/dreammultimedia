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

public partial class Myaccount : System.Web.UI.Page
{
    public string strusername = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsg.Visible = false;   
        if (Request.QueryString["flag"] == "login")
        {
            lblMsg.Text = "Login Successfully";
            lblMsg.Visible = true;   
        }
        if (Request.QueryString["flag"] == "signup")
        {
            lblMsg.Text = "Register Successfully";
            lblMsg.Visible = true;
        }
        if (Request.QueryString["flag"] == "change")
        {
            lblMsg.Text = "Change Password Successfully";
            lblMsg.Visible = true;
        }
        if (Request.QueryString["flag"] == "edit")
        {
            lblMsg.Text = "Update Successfully";
            lblMsg.Visible = true;
        }
        if (Session["UserID"] == null)
        {
            Response.Redirect("Signin.aspx");
        }
        else {
            using (cart obj = new cart())
            {
                obj._orderid = Convert.ToInt64("0");
                obj._userid = Convert.ToInt64(Session["UserID"].ToString());
                DataSet ds = new DataSet();
                lnkp.HRef += Session["UserID"].ToString();
                lnkpp.HRef += Session["UserID"].ToString();
                ds=obj.cart_selectbyuoid();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["current"] = ds.Tables[0].Rows[0]["SessionID"].ToString();
                }
                else
                {
                    Session["current"] = Session.SessionID.ToString();    
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        using (users obj = new users())
        {
            obj._uid = Convert.ToInt64(Session["UserID"].ToString());
            obj.repassword = txtoldpass.Text;
            obj.password = txtpassword.Text;
            obj.user_update_password();
            Response.Redirect("Myaccount.aspx?flag=change");  
        }
    }
}
