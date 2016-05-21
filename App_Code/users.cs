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
/// Summary description for user
/// </summary>
public class users :IDisposable 
{
    SqlConnection objconn;
    public users()
    {
        //
        // TODO: Add constructor logic here
        //
        String str = ConfigurationManager.ConnectionStrings["myconn"].ToString();
        objconn = new SqlConnection(str);
        objconn.Open();
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
    public String _fname;
    public String fname
    {
        get
        {
            return _fname;
        }
        set
        {
            _fname = value;

        }
    }
    public String _lname;
    public String lname
    {
        get
        {
            return _lname;
        }
        set
        {
            _lname = value;

        }
    }
    public DateTime _dbo;
    public DateTime dbo
    {
        get
        {
            return _dbo;
        }
        set
        {
            _dbo = value;

        }
    }
    public Boolean _gender;
    public Boolean gender
    {
        get
        {
            return _gender;
        }
        set
        {
            _gender = value;

        }
    }
    public Int64 _cno;
    public Int64 cno
    {
        get
        {
            return _cno;
        }
        set
        {
            _cno = value;

        }
    }
    public Int64 _accid;
    public Int64 accid
    {
        get
        {
            return _accid;
        }
        set
        {
            _accid = value;

        }
    }
    public String _email;
    public String email
    {
        get
        {
            return _email;
        }
        set
        {
            _email = value;

        }
    }
    public String _address;
    public String address
    {
        get
        {
            return _address;
        }
        set
        {
            _address = value;

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
    public Int64 _packageid;
    public Int64 packageid
    {
        get
        {
            return _packageid;
        }
        set
        {
            _packageid = value;

        }
    }
    public Double  _balanceid;
    public Double  balanceid
    {
        get
        {
            return _balanceid;
        }
        set
        {
            _balanceid = value;

        }
    }
    public String _uname;
    public String uname
    {
        get
        {
            return _uname;
        }
        set
        {
            _uname = value;

        }
    }
    public String _password;
    public String password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = value;

        }
    }
    public String _repassword;
    public String repassword
    {
        get
        {
            return _repassword;
        }
        set
        {
            _repassword = value;

        }
    }
    public Int64 _hint;
    public Int64 hint
    {
        get
        {
            return _hint;
        }
        set
        {
            _hint = value;

        }
    }
    public String _ans;
    public String ans
    {
        get
        {
            return _ans;
        }
        set
        {
            _ans = value;

        }
    }
    public void user_insert()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tbluser_insert";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@fname", _fname));
        objcmd.Parameters.Add(new SqlParameter("@lname", _lname));
        objcmd.Parameters.Add(new SqlParameter("@dbo", _dbo));
        objcmd.Parameters.Add(new SqlParameter("@gender", _gender));
        objcmd.Parameters.Add(new SqlParameter("@cno", _cno));
      
        objcmd.Parameters.Add(new SqlParameter("@email", _email));
        objcmd.Parameters.Add(new SqlParameter("@address", _address));
        objcmd.Parameters.Add(new SqlParameter("@balanceid", _balanceid));
       
        objcmd.Parameters.Add(new SqlParameter("@uname", _uname));
        objcmd.Parameters.Add(new SqlParameter("@password", _password));
        objcmd.Parameters.Add(new SqlParameter("@hint", _hint));
        objcmd.Parameters.Add(new SqlParameter("@ans", _ans));

        int i = objcmd.ExecuteNonQuery();
    }
    public void user_update()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tbluser_update";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _uid));
        objcmd.Parameters.Add(new SqlParameter("@fname", _fname));
        objcmd.Parameters.Add(new SqlParameter("@lname", _lname));
        objcmd.Parameters.Add(new SqlParameter("@dbo", _dbo));
        objcmd.Parameters.Add(new SqlParameter("@gender", _gender));
        objcmd.Parameters.Add(new SqlParameter("@cno", _cno));
        
        objcmd.Parameters.Add(new SqlParameter("@email", _email));
        objcmd.Parameters.Add(new SqlParameter("@address", _address));
        
        
      
        objcmd.Parameters.Add(new SqlParameter("@uname", _uname));
        objcmd.Parameters.Add(new SqlParameter("@password", _password));
        objcmd.Parameters.Add(new SqlParameter("@hint", _hint));
        objcmd.Parameters.Add(new SqlParameter("@ans", _ans));

        int i = objcmd.ExecuteNonQuery();
    }
    public void user_update_password()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tbluser_updatepass";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@Uid", _uid));
        

        
        objcmd.Parameters.Add(new SqlParameter("@newpassword", _password));
        objcmd.Parameters.Add(new SqlParameter("@oldpassword", _repassword));

        int i = objcmd.ExecuteNonQuery();
    }
    public void user_updatebalance()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tbluser_updatebalance";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _uid));
        
        objcmd.Parameters.Add(new SqlParameter("@balanceid", _balanceid));
        

        int i = objcmd.ExecuteNonQuery();
    }
    public void user_delete()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tbluser_delete";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _uid));
        int i = objcmd.ExecuteNonQuery();
    }
    public DataSet user_selectall()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tbluser_selectall";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return ds;
    }
    public DataSet user_login()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_user_login";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@Username", _email));
        objcmd.Parameters.Add(new SqlParameter("@Password", _password ));
        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return ds;
    }
    public DataSet user_select_byid()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tbluser_selectbyid ";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _uid));
        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return ds;
    }
    public DataSet user_select_byemail()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tbluser_selectbyemail";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@email", _email));
        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return ds;
    }
    public DataSet user_select_byemailans()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tbluser_selectbyemailans";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@email", _email));
        objcmd.Parameters.Add(new SqlParameter("@ans", _ans));
        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return ds;
    }
    public DataSet user_select_byforgotpassword()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_user_forgotpassword";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@email", _email));
        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return ds;
    }
    public DataSet user_select_byup()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_user_login";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@Username", _uname));
        objcmd.Parameters.Add(new SqlParameter("@Password", _password));
        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return ds;
    }
    public DataSet user_hin_selectall()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tblhint_selectall";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return ds;
    }
    public DataSet user_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_user_selectserch";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _email));

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
