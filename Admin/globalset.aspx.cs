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

public partial class Admin_globalset : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminID"] == null)
        {
            Response.Redirect("adminlogin.aspx");
        }
       
        if (!IsPostBack)
        {
            
                    FillBannerData();
        }
        
    }
    private void FillBannerData()
    {
        using (global  badd = new global())
        {

            DataSet ds = new DataSet();
            badd._id = Convert.ToInt64("1");
            ds = badd.global_Select_byid ();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txt1.Text = ds.Tables[0].Rows[0]["Sitename"].ToString();
                txtsiteurl .Text = ds.Tables[0].Rows[0]["Surl"].ToString();
                txtdisurl.Text = ds.Tables[0].Rows[0]["Durl"].ToString();
                txtemail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                txtpassword .Text = ds.Tables[0].Rows[0]["Password"].ToString();
                txtinfoemail.Text = ds.Tables[0].Rows[0]["Infoemail"].ToString();
                txtmappadd.Text = ds.Tables[0].Rows[0]["Mapadd"].ToString();
                txtadd.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                txthostname.Text = ds.Tables[0].Rows[0]["Hostname"].ToString();
                txtfoter.Text = ds.Tables[0].Rows[0]["Footer"].ToString();
                txtpaypal .Text = ds.Tables[0].Rows[0]["Paypaladd"].ToString();
                
               
                
                
                //ViewState["funame"] = ds.Tables[0].Rows[0]["image"].ToString();
                btnsubmit.Text = "Update";
            }

        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        using (global obj = new global())
        {
            obj.id = Convert.ToInt64("1");
            obj.infoemail = txtinfoemail.Text.ToString();
            obj.mapadd = txtmappadd.Text.ToString();
            obj.pass = txtpassword.Text.ToString();
            obj.paypal = txtpaypal.Text.ToString();
            obj.sitename = txt1.Text.ToString();
            obj.surl = txtsiteurl.Text.ToString();
            obj.durl = txtdisurl.Text.ToString();
            obj.email = txtemail.Text.ToString();
            obj.footer = txtfoter.Text.ToString();
            obj.add = txtadd.Text.ToString();

            obj.global_update(); 
        }
        
    }
    
}
