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
/// Summary description for product
/// </summary>
public class product :IDisposable 
{
    SqlConnection objconn;
	public product()
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
        get
        {
            return _image;
        }
        set
        {
            _image = value;
        }
    }
    public String _pcode;
    public String pcode
    {
        get
        {
            return _pcode;
        }
        set
        {
            _pcode = value;
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
            return _serch;
        }
        set
        {
            _serch = value;
        }
    }


    public void product_insert()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_product_insert";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;

        cmd.Parameters.Add(new SqlParameter("@name", _name));
        cmd.Parameters.Add(new SqlParameter("@cid", _cid));
        cmd.Parameters.Add(new SqlParameter("pcode", _pcode));
        cmd.Parameters.Add(new SqlParameter("@rank", _rank));
        cmd.Parameters.Add(new SqlParameter("@image", _image));
        cmd.Parameters.Add(new SqlParameter("@active", _active));
        cmd.Parameters.Add(new SqlParameter("@desc", _desc));

        int i = cmd.ExecuteNonQuery(); 

    }
    public void product_update()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_product_update";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;

        cmd.Parameters.Add(new SqlParameter("@id", _id));
        cmd.Parameters.Add(new SqlParameter("@name", _name));
        cmd.Parameters.Add(new SqlParameter("@cid", _cid));
        cmd.Parameters.Add(new SqlParameter("pcode", _pcode));
        cmd.Parameters.Add(new SqlParameter("@rank", _rank));
        cmd.Parameters.Add(new SqlParameter("@image", _image));
        cmd.Parameters.Add(new SqlParameter("@active", _active));
        cmd.Parameters.Add(new SqlParameter("@desc", _desc));

        int i = cmd.ExecuteNonQuery();

    }
    public void product_delete()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_product_delete";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;

        cmd.Parameters.Add(new SqlParameter("@id", _id));

        int i = cmd.ExecuteNonQuery();

    }
    public DataSet  product_selectbyid()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_product_selectbyid";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;

        cmd.Parameters.Add(new SqlParameter("@id", _id));

        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(ds);

        return ds;

    }
    public DataSet  product_selectall()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_product_selectall";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = objconn;

        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(ds);

        return ds;


    }
    public DataSet product_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_product_selectserch";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _serch));

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

         
        return dsReg;
    }
    public DataSet product_Select_Searchdatabypid()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_product_selectserchbyavi";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _serch));
        objcmd.Parameters.Add(new SqlParameter("@pdi", _id));
        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);


        return dsReg;
    }

    public DataSet product_Select_AdSearchdata()
    {
        ///command
        String str = "select * from tblProduct   where Name  like ";
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = str;
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _serch));

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);


        return dsReg;
    }
    public DataSet product_bindbyid()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_product_subbind";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
    }

    public DataSet product_details()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_product_details";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
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
