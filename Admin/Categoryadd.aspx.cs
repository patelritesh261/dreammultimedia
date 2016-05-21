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

public partial class Admin_Categoryadd : System.Web.UI.Page
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
            //ddlparentidfill();
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
        using (category obj = new category())
        {
            DataSet ds = new DataSet();
            obj._id = Convert.ToInt64(Request.QueryString["id"].ToString());
            ds = obj.category_selectbyid();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtcname.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                txtrank.Text = ds.Tables[0].Rows[0]["Rank"].ToString();
                txtdesc.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                ddlparentid.SelectedValue = ds.Tables[0].Rows[0]["ParentID"].ToString();     
                Boolean b = Convert.ToBoolean(ds.Tables[0].Rows[0]["Active"].ToString());
                ViewState["image"] = ds.Tables[0].Rows[0]["image"].ToString();
                imageup.ImageUrl += ds.Tables[0].Rows[0]["image"].ToString();
                imageup.Visible = true;
                fucimage.Visible = false; 
                if (b == true)
                {
                    ckbactive.Checked = true;
                }
                else
                {
                    ckbactive.Checked = false;
                }
                
                //ViewState["image"] = ds.Tables[0].Rows[0]["Image"].ToString();

            }
            btnsubmit.Text = "Update";
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        
            using (category obj = new category())
            {
                obj._name = txtcname.Text.ToString();
                obj._rank = Convert.ToInt64(txtrank.Text.ToString());
                obj._pid = Convert.ToInt16(ddlparentid.SelectedValue);
                obj._desc = txtdesc.Text.ToString();
                if (ckbactive.Checked == true)
                {
                    obj._active = true;
                }
                else
                {
                    obj._active = false;
                }
                if (fucimage.Visible == true)
                {
                    if (fucimage.HasFile)
                    {
                        // Bitmap bmp = new Bitmap(FileTest.PostedFile.InputStream); 
                        Bitmap bmp = new Bitmap(fucimage.PostedFile.InputStream);
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
                        bmp.Save(System.Web.HttpContext.Current.Server.MapPath("upload\\category\\") + fucimage.PostedFile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                        //fucimage.SaveAs(Server.MapPath("upload\\category\\") + fucimage.FileName);

                        obj._image = fucimage.FileName.ToString();
                    }
                }
                else
                {
                    obj._image = ViewState["image"].ToString();
                }
                if (btnsubmit.Text == "Update")
                {
                    obj._id = Convert.ToInt64(Request.QueryString["id"].ToString());
                    //if (!fucimage.HasFile)
                    //{
                    //    obj._image = ViewState["Image"].ToString();
                    //}
                    obj.category_update();
                    Response.Redirect("Categoryrepeater.aspx?flag=edit");

                }
                else
                {
                    obj.category_insert();
                    Response.Redirect("Categoryrepeater.aspx?flag=add");
                }
            }
        
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtcname.Text = "";
        txtrank.Text = "";
        txtdesc.Text = "";  
        ckbactive.Checked = false;
    }
    protected void imageup_Click(object sender, ImageClickEventArgs e)
    {
        imageup.Visible = false;
        fucimage.Visible = true; 
    }
}
