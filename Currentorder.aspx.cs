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

public partial class Currentorder : System.Web.UI.Page
{
    String fileloc;
    String filename;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserID"] != null)
            {
                if (Session["UserID"] != "")
                {
                    FillRepeater();


                }
            }
            else
            {
                Response.Redirect("signin.aspx");
            }
        }
    }
    public void FillRepeater()
    {

        using (cart obj = new cart())
        {
            DataSet ds = new DataSet();
            if (Request.QueryString["oid"] == "")
            {
                Response.Redirect("Default.aspx");  
            }
            else if (Request.QueryString["oid"] != null)
            {
                using (order objo = new order())
                {
                    objo.id = Convert.ToInt64(Request.QueryString["oid"].ToString());
                    ds = objo.order_byid();
                    lbltotalprice.Visible = false;
                    ptag.Visible = false;  
                }
            }
            else
            {
                obj._userid = Convert.ToInt64(Session["UserID"].ToString());
                obj._sessionid = Session["Current"].ToString();
                obj._orderid = Convert.ToInt64("1");
                DataSet dsr = new DataSet(); 

                ds = obj.cart_details();

                dsr = obj.cart_total();
                lbltotalprice.Text = dsr.Tables[0].Rows[0]["total"].ToString();
            }
            if (ds.Tables[0].Rows.Count > 0)
            {

                rptcart.DataSource = ds;
                rptcart.DataBind();

            }
            else
            {
                rptcart.Visible = false;
            }
            

        }
          
    }
    protected void rptcart_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Download")
        {
            downloaddata(e.CommandArgument);  
        }
    }

    private void downloaddata(object p)
    {
        //throw new NotImplementedException();
        using (productparameter obj = new productparameter())
        {
            obj._id = Convert.ToInt64(p.ToString());
            DataSet ds = new DataSet(); 
            ds=obj.productparameter_select_byid();
            if (ds.Tables[0].Rows.Count > 0)
            { 
                filename=ds.Tables[0].Rows[0]["OProduct"].ToString();
                fileloc = Server.MapPath("Admin\\upload\\orignal\\") + filename;
    
                //download file from folder

                Response.Clear();
                Response.AddHeader("content-disposition", "attachment;filename=" + filename);
                Response.WriteFile(fileloc);
                Response.End();    
            }
        }
    }
}
