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

public partial class Newsdesc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"] != "")
                {
                    FillRepeater();

                }
            }
        }
    }

    private void FillRepeater()
    {
       // throw new NotImplementedException();
        using (news obj = new news())
        {
            DataSet ds = new DataSet(); 
            obj._id=Convert.ToInt64(Request.QueryString["id"].ToString());     
            ds =obj.news_select_byid();
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                rptnewsdesc.DataSource = ds;
                rptnewsdesc.DataBind(); 
                String str=ds.Tables[0].Rows[0]["Date"].ToString();
                //lblmonth.Text = str.Substring(0, 1)+""+str.Substring(4,7) ; 
                //lbldate.Text = str.Substring(2, 2); 
                
            }

        }
    }
}
