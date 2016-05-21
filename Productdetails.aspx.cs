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

public partial class Productdetails : System.Web.UI.Page
{
    int i = 3;
    protected void Page_Load(object sender, EventArgs e)
    
    {
        lblMsg.Visible = false;   
        
        if (!IsPostBack)
        {
            //releted();
            if (Request.QueryString["sid"] =="")
            {
                Response.Redirect("Default.aspx");  
            }
            else if (Request.QueryString["sid"] != null)
            {
                if (Request.QueryString["sid"] != "")
                {
                    Fillrepeater();
                    Choseiav();
                    //if (i == 2)
                    //{
                    //    image.Visible = false;
                    //    video.Visible = true;
                    //    audio.Visible = false;   
                    //}
                    //if (i == 3)
                    //{

                    //    image.Visible = false;
                    //    video.Visible = false ;
                    //    audio.Visible = true;
                    //}

                }
            }
            else
            {
                Response.Redirect("Default.aspx");  
            }
        }
    }

    private void Choseiav()
    {
        int tag;
       // throw new NotImplementedException();
        using (product obj = new product())
        {
            obj._id = Convert.ToInt64(Request.QueryString["sid"].ToString());
            DataSet ds = new DataSet();
            ds = obj.product_details();
            if (ds.Tables[0].Rows.Count > 0)
            {
                using (category objc = new category())
                {
                    objc._id = Convert.ToInt64(ds.Tables[0].Rows[0]["cid"].ToString());
                    DataSet dsr = new DataSet(); 
                    dsr=objc.category_selectbyid();
                    if (dsr.Tables[0].Rows.Count > 0)
                    {
                        tag = Convert.ToInt32(dsr.Tables[0].Rows[0]["ParentID"].ToString());
                        if (tag == 2)
                        {
                            imgpd.Src += ds.Tables[0].Rows[0]["image"].ToString();
                            using (productparameter objp = new productparameter())
                            {
                                objp._pdid = Convert.ToInt64(Request.QueryString["sid"].ToString());       
                                objp._prid = Convert.ToInt64("2");
                                DataSet dsp = new DataSet(); 
                                dsp=objp.productparameter_select_byparameterid ();
                                if (dsp.Tables[0].Rows.Count > 0)
                                {
                                    aimg.HRef += dsp.Tables[0].Rows[0]["OProduct"].ToString();
                                }
                            }
                            
                            image.Visible = true ;
                            video.Visible = false;
                            audio.Visible = false;
                            lblrelated.Text = "Image";  
                        }
                        if (tag == 3)
                        {
                            using (productparameter objp = new productparameter())
                            {
                                objp._pdid = Convert.ToInt64(Request.QueryString["sid"].ToString());
                                objp._prid = Convert.ToInt64("6");
                                DataSet dsp = new DataSet();
                                dsp = objp.productparameter_select_byparameterid();
                                if (dsp.Tables[0].Rows.Count > 0)
                                {
                                    //aimg.HRef += dsp.Tables[0].Rows[0]["OProduct"].ToString();
                                    flashvideo.VideoURL += dsp.Tables[0].Rows[0]["OProduct"].ToString(); 
                                }
                            }
                              
                            image.Visible = false;
                            video.Visible = true;
                            audio.Visible = false;
                            lblrelated.Text = "Video";
                        }
                        if (tag == 4)
                        {
                            img1.Src += ds.Tables[0].Rows[0]["image"].ToString();
                            using (productparameter objp = new productparameter())
                            {
                                objp._pdid = Convert.ToInt64(Request.QueryString["sid"].ToString());
                                objp._prid = Convert.ToInt64("10");
                                DataSet dsp = new DataSet();
                                dsp = objp.productparameter_select_byparameterid();
                                if (dsp.Tables[0].Rows.Count > 0)
                                {
                                    
                                    audio1.AudioURL += dsp.Tables[0].Rows[0]["OProduct"].ToString();
                                }
                            }
                              
                            image.Visible = false;
                            video.Visible = false;
                            audio.Visible = true;
                            lblrelated.Text = "Audio";
                        }
 
                    }
                }
            }
        }

    }
    private void releted()
    {
        using (product obj = new product())
        {
            if (ViewState["cid"] != null)
            {
                obj._id = Convert.ToInt64(ViewState["cid"].ToString());
                DataSet ds = new DataSet();
                ds = obj.product_bindbyid();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblcname.Text = ds.Tables[0].Rows[0]["cname"].ToString();
                    rptreleted.DataSource = ds;
                    rptreleted.DataBind();
                }
            }
        }
    }
    private void Fillrepeater()
    {
        using (product obj = new product())
        { 
           
            obj._id=Convert.ToInt64(Request.QueryString["sid"].ToString());
            DataSet ds = new DataSet(); 
            ds=obj.product_details();
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                //imgpd.Src += ds.Tables[0].Rows[0]["image"].ToString();
                //aimg.HRef += ds.Tables[0].Rows[0]["simage"].ToString(); 
                lbliname.Text = ds.Tables[0].Rows[0]["pdname"].ToString();
                lblpdcode.Text = ds.Tables[0].Rows[0]["pdcode"].ToString();
                ViewState["cid"] = ds.Tables[0].Rows[0]["cid"].ToString();    
                rptpdetails.DataSource = ds;
                rptpdetails.DataBind();  

              
            }
 
        }
        releted(); 
    }


    protected void rbtnpd_CheckedChanged(object sender, EventArgs e)
    {
        foreach (RepeaterItem item in rptpdetails.Items)
        {
            RadioButton rbtn = (RadioButton)item.FindControl("rbtnpd");
            rbtn.Checked = false;
        }
        ((RadioButton)sender).Checked = true;
        foreach (RepeaterItem item in rptpdetails.Items)
        {
            RadioButton rbtn = (RadioButton)item.FindControl("rbtnpd");
            if (rbtn.Checked)
            {
                using (productparameter obj = new productparameter())
                {
                    ViewState["rbtnid"] = rbtn.ToolTip.ToString(); 
                    obj._id = Convert.ToInt64(ViewState["rbtnid"].ToString() );
                    DataSet ds = new DataSet();
                    ds = obj.productparameter_select_byid();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lbltotal.Text = ds.Tables[0].Rows[0]["Credit"].ToString();
                        ViewState["prid"] = ds.Tables[0].Rows[0]["ParameterID"].ToString();    
                       //ViewState["credit"] = lbltotal.Text;   
                    }

                }
            }
        }
    }
    protected void btnaddcart_Click(object sender, EventArgs e)
    {
        using (cart obj = new cart())
        {
            if (ViewState["rbtnid"] != null)
            {
                obj._productid = Convert.ToInt64(Request.QueryString["sid"].ToString());
                obj._ppid = Convert.ToInt64(ViewState["rbtnid"].ToString());
                obj._prid = Convert.ToInt64(ViewState["prid"].ToString());
                Session["Current"] = Session.SessionID.ToString();
                obj._sessionid = Session["Current"].ToString();
                obj._orderid = Convert.ToInt64("0");
                obj._credit = Convert.ToInt64 (lbltotal.Text.ToString());     
                if (Session["UserID"] != null)
                {
                    if (Session["UserID"] != "")
                    {
                        obj._userid = Convert.ToInt64(Session["UserID"].ToString());
                    }
                }
                else
                {
                    obj._userid = Convert.ToInt64("0");
                }
                obj.cart_insert();
                Response.Redirect("Cart.aspx");  
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg .Text = "Chose one product item";  
            }
        }          
    }
}
