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

public partial class Transcationhistory : System.Web.UI.Page
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
        using (Package  obj = new Package ())
        {
            DataSet ds = new DataSet();
            obj.uid = Convert.ToInt64(Session["UserID"].ToString());
            ds = obj.packagetranscation_Select_byuid ();

            if (ds.Tables[0].Rows.Count > 0)
            {
                rptorder.DataSource = ds;
                rptorder.DataBind();
            }
        }
    }
}
