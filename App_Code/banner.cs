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
/// Summary description for banner
/// </summary>
public class banner:IDisposable 
{

    SqlConnection objconn;
	public banner()
	{
		//
		// TODO: Add constructor logic here
		//
        String str = ConfigurationManager.ConnectionStrings["myconn"].ToString();
        objconn = new SqlConnection(str);
        objconn.Open(); 
	}
    public Int64 _id;
    public Int64 id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
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

    public String _imagename;
    public String imagename
    {
        get
        {
            return _imagename;
        }
        set
        {
            _imagename = value;
        }
    }
    public Int64 _rank;
    public Int64 rank
    {
        get {
            return _rank;
        }
        set {
            _rank = value; 
        }
    }
    public Boolean  _active;
    public Boolean active
    {
        get {
            return _active;
        }
        set {
            _active = value; 
        }
    }
    public String _serch;
    public String serch
    {
        get
        {
            return  _serch;
        }
        set
        {
            _serch = value;
        }
    }

    public void img_insert()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_img_insert";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@title",_title));
        objcmd.Parameters.Add(new SqlParameter("@imgname",_imagename));
        objcmd.Parameters.Add(new SqlParameter("@rank",_rank));
        objcmd.Parameters.Add(new SqlParameter("@active",_active));

        int i = objcmd.ExecuteNonQuery();
  
    }

    public void img_update()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_img_update";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));
        objcmd.Parameters.Add(new SqlParameter("@title", _title));
        objcmd.Parameters.Add(new SqlParameter("@imgname", _imagename));
        objcmd.Parameters.Add(new SqlParameter("@rank", _rank));
        objcmd.Parameters.Add(new SqlParameter("@active", _active));

        int i = objcmd.ExecuteNonQuery();

    }

    public void img_delete()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_banner_delete";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));

        int i = objcmd.ExecuteNonQuery();
    }

    public DataSet Banner_Select_Alldata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_banner_selectall";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }
    public DataSet Banner_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_banner_selectserch";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _serch));
     
        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }
    public DataSet Banner_Select_byid()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_banner_selectbyid";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@id",_id));     

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }
    public DataSet Banner_Select_Bind()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_banner_selectbind";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

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
