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

public partial class newsuc : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Fillrepeater();

        }
    }
    public void Fillrepeater()
    {
        using (news obj = new news())
        {
            DataSet ds = new DataSet();
            ds = obj.news_selectbind();

            if (ds.Tables[0].Rows.Count > 0)
            {
                rptnews.DataSource = ds;
                rptnews.DataBind();
            }
            else
            {
                rptnews.Visible = false;
            }

        }
    }
    protected void rptnews_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "linktitle")
        {
            Response.Redirect("Newsdesc.aspx?id="+e.CommandArgument);  
        }
    }
}
