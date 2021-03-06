﻿using System;
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

public partial class Admin_Categoryrepeater : System.Web.UI.Page
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
        if (Session["AdminID"] == null)
        {
            Response.Redirect("adminlogin.aspx");
        }
        messagegreen.Visible = false;
        if (!IsPostBack)
        {
            if (Request.QueryString["flag"] != null)
            {
                if (Request.QueryString["flag"].ToString() == "add")
                {
                    messagegreen.Visible = true;
                    lblMessage.Text = " Your Record Added Sucessfully";
                }

                else if (Request.QueryString["flag"].ToString() == "edit")
                {
                    messagegreen.Visible = true;
                    lblMessage.Text = " Your Record Updated Sucessfully";
                }
            }
            FillRepeater();

        }
    }
    private void FillRepeater()
    {

        using (category  obj = new category())
        {
            DataSet dsR = new DataSet();
            if (txtserch.Text == "")
            {

                dsR = obj.category_selectall();
            }
            else
            {
                obj._serch = txtserch.Text.Trim();
                dsR = obj.category_Select_Searchdata ();
            }
            int cnt = dsR.Tables[0].Rows.Count;
            PagedDataSource page = new PagedDataSource();
            page.DataSource = dsR.Tables[0].DefaultView;
            page.AllowPaging = true;
            page.PageSize = 5;
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
                rptcategory .DataSource = page;
                rptcategory .DataBind();
                if (txtserch.Text != "")
                {
                    lblMessage.Text = " Record Found :" + dsR.Tables[0].Rows.Count;
                    messagegreen.Visible = true;
                }
            }
            else
            {
                rptcategory .Visible = false;

            }
        }
    }
    protected void rptcategory_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "EditData")
        {
            Response.Redirect("Categoryadd.aspx?id=" + e.CommandArgument.ToString());
        }
        if (e.CommandName == "DeleteData")
        {
            using (category  obj = new category())
            {
                obj._id = Convert.ToInt64(e.CommandArgument.ToString());
                obj.category_delete();
                FillRepeater();
            }
        }
    }
    protected void btnserch_Click(object sender, EventArgs e)
    {
        FillRepeater();
    }



    protected void btnviewall_Click(object sender, EventArgs e)
    {
        txtserch.Text = "";  
        FillRepeater();
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
