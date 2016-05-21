using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
/// <summary>
/// Summary description for cms
/// </summary>
public class cms : IDisposable
{
    SqlConnection objconn;
	public cms()
	{
		//
		// TODO: Add constructor logic here
		//
        String str = ConfigurationManager.ConnectionStrings["myconn"].ToString();
        objconn = new SqlConnection(str);
        objconn.Open();
	}
    public Int64 _cid;
    public Int64 cid
    {
        get
        {
            return _cid;
        }
        set
        {
            _cid = value;
        }
    }
    public String _title;
    public String title
    {
        get
        {
            return _title;
        }
        set
        {
            _title = value;
        }
    }
    public String _desc;
    public String desc
    {
        get
        {
            return _desc;
        }
        set
        {
            _desc = value;
        }
    }
    public Boolean _active;
    public Boolean active
    {
        get
        {
            return _active;
        }
        set
        {
            _active = value;
        }
    }
    public String _serch;
    public String serch
    {
        get
        {
            return _serch;
        }
        set
        {
            _serch = value;
        }
    }
    public void cms_insert()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tblcms_insert";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@title", _title));
        objcmd.Parameters.Add(new SqlParameter("@desc", _desc));
        objcmd.Parameters.Add(new SqlParameter("@active", _active));
        int i = objcmd.ExecuteNonQuery();
    }
    public void cms_delete()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tblcms_delete";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@cid", _cid));
        int i = objcmd.ExecuteNonQuery();
    }
    public void cms_update()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tblcms_update";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@cid", _cid));
        objcmd.Parameters.Add(new SqlParameter("@title", _title));
        objcmd.Parameters.Add(new SqlParameter("@desc", _desc));
        objcmd.Parameters.Add(new SqlParameter("@active", _active));
        int i = objcmd.ExecuteNonQuery();
    }
    public DataSet cms_selectbyid()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tblcms_selectbyid";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@cid", _cid));

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return ds;
    }
    public DataSet cms_selectall()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tblcms_selectall";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;


        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return (ds);
    }
    public DataSet cms_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_cms_selectserch";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _serch));

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }

    #region IDisposable Members

    public void Dispose()
    {
        if (objconn.State == ConnectionState.Open)
        {
            objconn.Close();
        }
        System.GC.SuppressFinalize(this);
    }

    #endregion


}
