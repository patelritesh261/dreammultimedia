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
/// Summary description for productparameter
/// </summary>
public class productparameter :IDisposable 
{
    SqlConnection objconn;
	public productparameter()
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
    public Int64  _pdid;
    public Int64  pdid
    {
        get
        {
            return _pdid;
        }
        set
        {
            _pdid = value;
        }
    }
    public Int64  _prid;
    public Int64  prid
    {
        get
        {
            return _prid;
        }
        set
        {
            _prid = value;
        }
    }
    public String _size;
    public String size
    {
        get
        {
            return _size;
        }
        set
        {
            _size = value;
        }
    }
    public String _oproduct;
    public String oproduct
    {
        get
        {
            return _oproduct;
        }
        set
        {
            _oproduct = value;
        }
    }
    public Int64   _credit;
    public Int64   credit
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


    public void productparameter_insert()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_productparameter_insert";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@pdid", _pdid ));
        objcmd.Parameters.Add(new SqlParameter("@prid", _prid));
        objcmd.Parameters.Add(new SqlParameter("@oproduct", _oproduct));
        objcmd.Parameters.Add(new SqlParameter("@credit", _credit));
        objcmd.Parameters.Add(new SqlParameter("@size", _size));
        

        int i = objcmd.ExecuteNonQuery();
    }

    public void productparameter_update()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_productparameter_update";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));
        objcmd.Parameters.Add(new SqlParameter("@pdid", _pdid));
        objcmd.Parameters.Add(new SqlParameter("@prid", _prid));
        objcmd.Parameters.Add(new SqlParameter("@oproduct", _oproduct));
        objcmd.Parameters.Add(new SqlParameter("@credit", _credit));
        objcmd.Parameters.Add(new SqlParameter("@size", _size));

        int i = objcmd.ExecuteNonQuery();
    }

    public void productparameter_delete()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_productparameter_delete";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));

        int i = objcmd.ExecuteNonQuery();


    }
    public DataSet productparameter_selectall()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_productparameter_selectall";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@pdid", _pdid));  

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
    }

    public DataSet productparameter_select_byid()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_productparameter_selectbyid";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
    }

    
    public DataSet productparameter_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_productparameter_selectserch";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _serch));

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }
    public DataSet productparameter_select_bycategoryid()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_product_bycategoryid";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@pdid", _pdid));     

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
    }
    public DataSet productparameter_select_byproductid()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_product_selectbyproductid";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@pdid", _pdid));

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
    }
    public DataSet productparameter_select_byparameterid()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_productparameter_selectbyprid";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@pdid", _pdid));
        objcmd.Parameters.Add(new SqlParameter("@prid", _prid));

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
    }
    public DataSet productparameter_select_up_byproductid()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_product_up_selectbyid";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _pdid));

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
