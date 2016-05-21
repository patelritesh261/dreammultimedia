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
using System.Data.SqlClient ;

/// <summary>
/// Summary description for category
/// </summary>
public class category:IDisposable 
{
    SqlConnection objconn;
	public category()
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
    public Int64 _pid;
    public Int64 pid
    {
        get
        {
            return _pid;
        }
        set
        {
            _pid = value;
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
    public String _image;
    public String image
    {
        get {
            return _image; 
        }
        set {
            _image = value;  
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
    public Boolean  active
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

    public void category_insert()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_category_insert";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
   
        objcmd.Parameters.Add(new SqlParameter("@name",_name));
        objcmd.Parameters.Add(new SqlParameter("@image",_image));
        objcmd.Parameters.Add(new SqlParameter("@rank",_rank));
        objcmd.Parameters.Add(new SqlParameter("@desc", _desc));
        objcmd.Parameters.Add(new SqlParameter("@pid", _pid));   
        objcmd.Parameters.Add(new SqlParameter("@active", _active));

        int i = objcmd.ExecuteNonQuery();       
    }

    public void category_update()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_category_update";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));     
        objcmd.Parameters.Add(new SqlParameter("@name", _name));
        objcmd.Parameters.Add(new SqlParameter("@image", _image));
        objcmd.Parameters.Add(new SqlParameter("@rank", _rank));
        objcmd.Parameters.Add(new SqlParameter("@desc", _desc));
        objcmd.Parameters.Add(new SqlParameter("@pid", _pid));
        objcmd.Parameters.Add(new SqlParameter("@active", _active));

        int i = objcmd.ExecuteNonQuery();
    }
    public void category_delete()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_category_delete";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));
        

        int i = objcmd.ExecuteNonQuery();
    }

    public DataSet category_ddlparentid()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_ddlparentidbind";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
    }
    public DataSet category_maincategory()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_ddlcategorybind";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;



        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
    }
    public DataSet category_subcategory()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_category_subbind";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));     

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
    }
    public DataSet category_selectall()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_category_selectall";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;

        DataSet ds = new DataSet();
        SqlDataAdapter  adp=new SqlDataAdapter(cmd);
        adp.Fill(ds);
        return ds; 
 
    }
    public DataSet category_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_category_selectserch";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _serch));

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }
    public DataSet category_selectbyid()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_category_selectbyid";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;

        cmd.Parameters.Add(new SqlParameter("@id", _id));
    
        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(ds);
        return ds;

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
