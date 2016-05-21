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
using System.Drawing;
using System.Drawing.Drawing2D;

public partial class Admin_Productadd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminID"] == null)
        {
            Response.Redirect("adminlogin.aspx");
        }
        imageup.Visible = false; 
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"] != "")
                {
                    FillRegData();
                }
            }
        }
    }
    private void FillRegData()
    {
        using (product obj = new product())
        {
            DataSet ds = new DataSet();
            obj._id = Convert.ToInt64(Request.QueryString["id"].ToString());
            ds = obj.product_selectbyid();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtpname.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                txtpcode.Text = ds.Tables[0].Rows[0]["Productcode"].ToString();
                txtrank.Text = ds.Tables[0].Rows[0]["Rating"].ToString();
                txtdesc.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                Boolean b = Convert.ToBoolean(ds.Tables[0].Rows[0]["Active"].ToString());
                ddlcategoryname.SelectedValue = ds.Tables[0].Rows[0]["CategoryID"].ToString();
                ViewState["image"] = ds.Tables[0].Rows[0]["image"].ToString();
                imageup.ImageUrl += ds.Tables[0].Rows[0]["image"].ToString();
                imageup.Visible = true;
                fuimage.Visible = false; 
                if (b)
                {
                    ckbactive.Checked = true;
                }
                else
                {
                    ckbactive.Checked = false;
                }
                btnsubmit.Text = "Update";

            }
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        using (product obj = new product())
        {
            obj._name = txtpname.Text.ToString();
            obj._pcode = txtpcode.Text.ToString();
            obj._desc = txtdesc.Text.ToString();
            obj._cid = Convert.ToInt64(ddlcategoryname.SelectedValue);
            obj._rank = Convert.ToInt64(txtrank.Text.ToString());
            if (fuimage.Visible == true)
            {
                if (fuimage.HasFile)
                {
                // Bitmap bmp = new Bitmap(FileTest.PostedFile.InputStream); 
                Bitmap bmp = new Bitmap(fuimage.PostedFile.InputStream);
                Graphics canvas = Graphics.FromImage(bmp);
                try
                {
                    Bitmap bmpNew = new Bitmap(bmp.Width, bmp.Height);
                    canvas = Graphics.FromImage(bmpNew);
                    canvas.DrawImage(bmp, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);
                    bmp = bmpNew;
                }
                catch (Exception ee) // Catch exceptions 
                {
                    Response.Write(ee.Message);
                }
                // Here replace "Text" with your text and you also can assign Font Family, Color, Position Of Text etc. 
                canvas.DrawString("Dream Multimedia", new Font("Verdana", 20, FontStyle.Bold), new SolidBrush(Color.FromArgb(70, 255, 255, 255)), (20), (bmp.Height / 2));
                // Save or display the image where you want. 
                bmp.Save(System.Web.HttpContext.Current.Server.MapPath("upload\\product\\") + fuimage.PostedFile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg); 

                //fuimage.SaveAs(Server.MapPath("upload\\product\\") + fuimage.FileName);
                obj._image = fuimage.FileName;
                 }
            }
            else
            {
                obj._image = ViewState["image"].ToString();
            }
            if (ckbactive.Checked == true)
            {
                obj._active = true;
            }
            else
            {
                obj._active = false;
            }
            if (btnsubmit.Text == "Update")
            {
                obj._id = Convert.ToInt64(Request.QueryString["id"].ToString());
                obj.product_update();
                Response.Redirect("Productrepeater.aspx?flag=edit");
            }
            else
            {
                obj.product_insert();
                Response.Redirect("Productrepeater.aspx?flag=add");
            }

        }
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtpname.Text = "";
        txtdesc .Text = "";
        txtpcode.Text = "";
        txtrank.Text = "";  

        ckbactive.Checked = false;
    }
    protected void imageup_Click(object sender, ImageClickEventArgs e)
    {
        imageup.Visible = false;
        fuimage.Visible = true;
    }
}
