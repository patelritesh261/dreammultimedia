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
/// Summary description for parameter
/// </summary>
public class parameter :IDisposable 
{
    SqlConnection objconn;
	public parameter()
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
        get {
            return _id;
        }
        set {
            _id = value; 
        }
    }
    public Int64 _cid;
    public Int64 cid
    {
        get {
            return _cid; 
        }
        set {
            _cid = value;  
        }
    }
    public String _name;
    public String name
    {
        get {
            return _name; 
        }
        set {
            _name = value;  
        }
    }
    public String _sproduct;
    public String sproduct
    {
        get
        {
            return _sproduct;
        }
        set
        {
            _sproduct = value;
        }
    }
    public String _res;
    public string res
    {
        get {
            return _res; 
        }
        set {
            _res = value;  
        }
    }
    public Boolean _active;
    public Boolean active
    {
        get
        {
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
            return _serch;
        }
        set
        {
            _serch = value;
        }
    }

    public void parameter_insert()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_parameter_insert";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;
 
        cmd.Parameters.Add(new SqlParameter("@name",_name));
        cmd.Parameters.Add(new SqlParameter("@res",_res));
        cmd.Parameters.Add(new SqlParameter("@cid", _cid));
        //cmd.Parameters.Add(new SqlParameter("@sproduct", _sproduct));
        cmd.Parameters.Add(new SqlParameter("@active", _active));

        int i = cmd.ExecuteNonQuery(); 
    }

    public void parameter_update()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_parameter_update";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;

        cmd.Parameters.Add(new SqlParameter("@id", _id));
        cmd.Parameters.Add(new SqlParameter("@name", _name));
        //cmd.Parameters.Add(new SqlParameter("@sproduct", _sproduct));
        cmd.Parameters.Add(new SqlParameter("@res", _res));
        cmd.Parameters.Add(new SqlParameter("@cid", _cid));
        cmd.Parameters.Add(new SqlParameter("@active", _active));

        int i = cmd.ExecuteNonQuery();

    }

    public void parameter_delete()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_parameter_delete";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;

        cmd.Parameters.Add(new SqlParameter("@id", _id));

        int i = cmd.ExecuteNonQuery();

    }

    public DataSet parameter_selectall()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_parameter_selectall";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;  

        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(ds);

        return ds;
    }

    public DataSet parameter_selectbyid()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_parameter_selectbyid";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;  

        cmd.Parameters.Add(new SqlParameter("@id", _id));    

        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(ds);

        return ds;
    }
    public DataSet parameter_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_parameter_selectserch";
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
