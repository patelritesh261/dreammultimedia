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

public partial class Topsell : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FilData();
        }
    }

    private void FilData()
    {
        //throw new NotImplementedException();
        using (order obj = new order())
        {
            DataSet ds = new DataSet(); 
            ds=obj.top_order();

            if (ds.Tables[0].Rows.Count > 0)
            {
                rptsell.DataSource = ds;
                rptsell.DataBind();  
            }
        }
    }
}
