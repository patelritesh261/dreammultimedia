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

public partial class Orderhistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserID"] != null)
            {
                if (Session["UserID"] != "")
                {
                    FilData();


                }
            }
            else
            {
                Response.Redirect("signin.aspx");
            }
           
        }
    }
    private void FilData()
    {
        //throw new NotImplementedException();
        using (order obj = new order())
        {
            DataSet ds = new DataSet();
            obj.uid=Convert.ToInt64(Session["UserID"].ToString());      
            ds = obj.order_byuserid();

            if (ds.Tables[0].Rows.Count > 0)
            {
                rptorder.DataSource = ds;
                rptorder.DataBind();
            }
        }
    }
}
