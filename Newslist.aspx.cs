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

public partial class Newslist : System.Web.UI.Page
{
    int vcnt;
    public int Pgnm
    {
        get
        {
            if (ViewState["Pgnm"] != null)
            {
                return Convert.ToInt32(ViewState["Pgnm"]);
            }
            else
            {
                return 0;
            }
        }
        set
        {
            ViewState["Pgnm"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            FillRepeater();

               
        }
    }
    public void FillRepeater()
    {
        using (news obj = new news())
        {
            DataSet dsR = new DataSet();
            dsR = obj.news_selectall();

            int cnt = dsR.Tables[0].Rows.Count;
            PagedDataSource page = new PagedDataSource();
            page.DataSource = dsR.Tables[0].DefaultView;
            page.AllowPaging = true;
            page.PageSize = 6;
            page.CurrentPageIndex = Pgnm;
            vcnt = cnt / page.PageSize;

            if (Pgnm < 1)
            {
                linkprev.Visible = false;
            }
            else if (Pgnm > 0)
            {
                linkprev.Visible = true;
            }
            if (Pgnm == vcnt)
            {
                linknext.Visible = false;
            }
            if (Pgnm < vcnt)
            {
                linknext.Visible = true;
            }
            if (dsR.Tables[0].Rows.Count > 0)
            {
                rptnewsdesc.DataSource = page;
                rptnewsdesc.DataBind();

            }

        }
    }
    protected void rptnewsdesc_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "More")
        {
            Response.Redirect("Newsdesc.aspx?id=" + e.CommandArgument.ToString());
        }
    }
    protected void linkprev_Click(object sender, EventArgs e)
    {
        Pgnm -= 1;
        FillRepeater();
    }
    protected void linknext_Click(object sender, EventArgs e)
    {
        Pgnm += 1;
        FillRepeater();
    }
}
