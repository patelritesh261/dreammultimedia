<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminlogin.aspx.cs" Inherits="test_adminlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    <link rel="stylesheet" href="css/screen.css" type="text/css" media="screen" title="default" />
    <!--  jquery core -->

  <script src="js/jquery/jquery-1.4.1.min.js" type="text/javascript"></script>

    <!-- Custom jquery scripts -->

   <script src="js/jquery/custom_jquery.js" type="text/javascript"></script>

    <!-- MUST BE THE LAST SCRIPT IN <HEAD></HEAD></HEAD> png fix -->

    <script src="js/jquery/jquery.pngFix.pack.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(document).ready(function() {
            $(document).pngFix();
        });
    </script>
   
</head>
<body id="login-bg">
    <form id="form1" runat="server">
    <!-- Start: login-holder -->
    <div id="login-holder">
        <!-- start logo -->
        <div id="logo-login">
            <a href="adminlogin.aspx">
                <img src="images/dmlogo.png" width="151" height="90" alt="" /></a>
        </div>
        <!-- end logo -->
        <div class="clear">
        </div>
        <!--  start loginbox ................................................................................. -->
        <div id="loginbox">
            <!--  start login-inner -->
            <div id="login-inner">
                <div id="message-red">
                    <table cellspacing="0" cellpadding="0" border="0" width="100%" id="trError" runat="server" visible="false">
                        <tbody>
                            <tr><td>&nbsp;</td>
                                <td class="red-left">
                                  <asp:Label ID="lblError" runat="server"></asp:Label>
                                </td>
                                <td class="red-right">
                                    <a class="close-red">
                                        <img alt="" src="images/table/icon_close_red.gif"/></a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <table border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <th>
                            Username
                        </th>
                        <td>
                            <asp:TextBox ID="txtUsername" runat="server" CssClass="login-inp" 
                                ontextchanged="txtUsename_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            Password
                        </th>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="login-inp" 
                                TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th>
                        </th>
                        <td valign="top">
                            <asp:CheckBox ID="chkLogincheck" runat="server" CssClass="checkbox-size" /><label
                                for="login-check">Remember me</label>
                        </td>
                    </tr>
                    <tr>
                        <th>
                        </th>
                        <td>
                            <asp:Button ID="btnSubmit" runat="server" CssClass="submit-login" OnClick="btnSubmit_Click" />
                        </td>
                    </tr>
                </table>
            </div>
            <!--  end login-inner -->
            <div class="clear">
            </div>
            <%--<a href="" class="forgot-pwd">Forgot Password?</a>--%>
        </div>
        <!--  end loginbox -->
        
    </div>
    </form>
    
</body>
</html>
