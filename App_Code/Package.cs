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
/// Summary description for Package
/// </summary>
public class Package :IDisposable 
{
    SqlConnection objconn;
	public Package()
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
    public Int64 _uid;
    public Int64 uid
    {
        get
        {
            return _uid;
        }
        set
        {
            _uid = value;
        }
    }
    public String  _tid;
    public String  tid
    {
        get
        {
            return _tid;
        }
        set
        {
            _tid = value;
        }
    }
    public DateTime _date;
    public DateTime date
    {
        get {
            return _date; 
        }
        set {
            value = _date;  
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
    public Int64 _credit;
    public Int64 credit
    {
        get
        {
            return _credit;
        }
        set
        {
            _credit = value;
        }
    }
    public Int64 _rupees;
    public Int64 rupees
    {
        get
        {
            return _rupees;
        }
        set
        {
            _rupees = value;
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

    public void package_insert()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_package_insert";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@name", _name));
        objcmd.Parameters.Add(new SqlParameter("@credit", _credit));
        objcmd.Parameters.Add(new SqlParameter("@image", _image));
        objcmd.Parameters.Add(new SqlParameter("@rupees", _rupees));

        int i = objcmd.ExecuteNonQuery();

    }

    public void package_update()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_package_update";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));
        objcmd.Parameters.Add(new SqlParameter("@name", _name));
        objcmd.Parameters.Add(new SqlParameter("@image", _image));
        objcmd.Parameters.Add(new SqlParameter("@credit", _credit));
       

        int i = objcmd.ExecuteNonQuery();

    }

    public void package_delete()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_package_delete";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));

        int i = objcmd.ExecuteNonQuery();
    }

    public DataSet package_Select_Alldata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_package_selectall";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }
    public DataSet package_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_package_selectserch";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _serch));

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }
    public DataSet package_Select_byid()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_package_selectbyid";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@id", _id));

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }

    public void packagetransacation_insert()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_packagetransacation_insert";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));
        objcmd.Parameters.Add(new SqlParameter("@uid", _uid));
        objcmd.Parameters.Add(new SqlParameter("@date", _date));
        objcmd.Parameters.Add(new SqlParameter("@tid", _tid));

        int i = objcmd.ExecuteNonQuery();

    }

    public DataSet packagetranscation_Select_byuid()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_packagetranscation_history";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@uid", _uid));

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }
    public DataSet packagetran_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_packagetran_selectserch";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _serch));

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }
    public DataSet packagetran_Select_Alldata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_packagetrans";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }
    public void packagetran_delete()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_packagetran_delete";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));

        int i = objcmd.ExecuteNonQuery();
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
