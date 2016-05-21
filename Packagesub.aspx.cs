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

public partial class Packagesub : System.Web.UI.Page
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
            Fillpackage();
        }
    }
    protected void Fillpackage()
    {
        using (Package obj = new Package())
        {
            DataSet ds = new DataSet();
            ds = obj.package_Select_Alldata();
            int cnt = ds.Tables[0].Rows.Count;
            PagedDataSource page = new PagedDataSource();
            page.DataSource = ds.Tables[0].DefaultView;
            page.AllowPaging = true;
            page.PageSize = 12;
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



            if (ds.Tables[0].Rows.Count > 0)
            {
                rptpackage.DataSource = page;
                rptpackage.DataBind();
            }
            else
            {
                rptpackage.Visible = false;
            }
        }
    }
    protected void linkprev_Click(object sender, EventArgs e)
    {
        Pgnm -= 1;
        Fillpackage();
    }
    protected void linknext_Click(object sender, EventArgs e)
    {
        Pgnm += 1;
        Fillpackage();
    }
    protected void rptpackage_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Subscribepack")
        {
            Response.Redirect("Payment.aspx?id=" + e.CommandArgument);   
        }
    }
}
