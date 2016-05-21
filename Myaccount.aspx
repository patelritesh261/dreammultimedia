<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Myaccount.aspx.cs" Inherits="Myaccount" Title="Untitled Page" %>
<%@ Register TagName ="usercontrol" TagPrefix ="uc" Src="~/newsuc.ascx"   %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
<script language="javascript" type="text/javascript">

         function showbox() {
             //alert('1');
             document.getElementById('light').style.display = 'block';
             document.getElementById('fade').style.display = 'block';
         }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="bg">
<div id="main" style="width:700px; min-height:600px; "  >
    <h1 style="text-align: left; height: 35px; color:Black; width: 700px;">My Account
</h1>
<hr/><br />
 <div  style="width:700px;" runat="server" id="trError" >
                        <asp:Label ID="lblMsg" runat="server" CssClass="ErrorClass" ></asp:Label>
                        <br style="clear:both;" />
                    </div>
<div class="myaccount-left">
    <a class="account-iner" href="signup.aspx?id=" id="lnkp" runat="server"   title="My Profile">  <img alt="My Profile" src="images/my-profile.png" title="My Profile"/> </a>
    <div class="account-des" >
                    <a class="account-ttle" href="signup.aspx?id="  title="My Profile" id="lnkpp" runat="server" >
                        My Profile</a><br style=" clear:both;"/>
                    <p>
                        View and edit your contact details as well as other profile details.</p>
    </div>
</div>
<div class="myaccount-right">
    <%--<a class="account-iner" href="Changepassowrd.aspx"  title="Change Password">--%><a href = "javascript:void(0)" title="Change Password" class="account-ttle"  onclick = "document.getElementById('light').style.display='block';document.getElementById('fade').style.display='block'" >  <img alt="Change Password" src="images/change-pass.png" title="Change Password"/> </a>
    <div class="account-des" >
                    <a href = "javascript:void(0)" class="account-ttle" title="Change Password" onclick = "document.getElementById('light').style.display='block';document.getElementById('fade').style.display='block'" >Change Password</a>
                    <%--<a class="account-ttle" href="Changepassowrd.aspx"  title="Change Password">
                        Change Password</a>--%><br style=" clear:both;"/>
                    <p>
                        Change your current login password to new one.</p>
    </div>
</div>
<br style="clear:both;" />
<br style="clear:both;" />
<div class="myaccount-left">
    <a class="account-iner" href="Orderhistory.aspx" title="Order History">  <img alt="Order History" src="images/ord-his.png" title="Order History"/> </a>
    <div class="account-des" >
                    <a class="account-ttle" href="Orderhistory.aspx" title="Order History">
                        Order History</a><br style=" clear:both;"/>
                    <p>
                       View your Order History details.</p>
    </div>
</div>
<div class="myaccount-right">
    <a class="account-iner" href="Cart.aspx"  title="Shopping Cart">  <img alt="Shopping Cart" src="images/shopping-cart.png" title="Shopping Cart"/> </a>
    <div class="account-des" >
                    <a class="account-ttle" href="Cart.aspx"  title="Shopping Cart">
                        Shopping Cart</a><br style=" clear:both;"/>
                    <p>
                         View and edit your Cart details.</p>
    </div>
</div>
<br style="clear:both;" />
<br style="clear:both;" />
<div class="myaccount-left">
    <a class="account-iner" href="Transcationhistory.aspx"  title="Logout">  <img alt="Logout" src="images/log-out.png" title="Package Transcation"/> </a>
    <div class="account-des" >
                    <a class="account-ttle" href="Transcationhistory.aspx"  title="Package Transcation">
                       Transcation History</a><br style=" clear:both;"/>
                    <p>
                       Transcation History.</p>
    </div>
</div>
<div class="myaccount-right">
    <a class="account-iner" href="Packagesub.aspx" title="Package Subscription">  <img alt="Shopping Cart" src="images/shopping-cart.png" title="Package Subscription"/> </a>
    <div class="account-des" >
                    <a class="account-ttle" href="Packagesub.aspx" title="Package Subscription">
                        Package Subscription</a><br style=" clear:both;"/>
                    <p>
                         View and edit your Package details.</p>
    </div>
</div>
<br style="clear:both;" />

</div>
<uc:usercontrol ID="Usercontrol2" runat="server"  />
</div> 
<asp:Panel ID="panel2" runat="server" DefaultButton="Button1">  
	 <div id="light" class="white_content">
    <table cellpadding="0" cellspacing="0" border="0" style="background-color:#222222;" width="100%">
    <tr><td height="16px"><%--<a href = "javascript:void(0)" onclick = "document.getElementById('light').style.display='none';document.getElementById('fade').style.display='none'"><img src="images/button/close2.jpg" style="border :0px"  width="13px" align="right" height="13px" alt=" "/></a>--%></td></tr>
    
    <tr>
    <td style="padding-left:16px;padding-right:16px;padding-bottom:16px"> 
    <table align="center"  border="0" cellpadding="0" cellspacing="0" style="background-color:#fff" width="100%">
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td align="center" colspan="2" class="headertext" >Change Password Form </td>
    </tr>
    <tr>
    <td>
    &nbsp;
    </td>
    </tr>
<tr><td align="center">
<table>
<tr>
<td align="right"><b>Old Password:</b></td>
<td><asp:TextBox ID="txtoldpass" runat="server" class="textfield " TextMode="Password"  ></asp:TextBox></td>
</tr>
<tr><td></td>
    <td><asp:RequiredFieldValidator ID="rfvoldpass" runat="server" ValidationGroup="btnsubmit" ControlToValidate="txtoldpass" Display="Dynamic" ErrorMessage="Please Fill Up Field" ></asp:RequiredFieldValidator>   
                 <%--<cc1:ValidatorCalloutExtender ID="vce1" runat="server"   TargetControlID="rfvoldpass"></cc1:ValidatorCalloutExtender>--%> </td>
</tr>
<tr>
<td align="right"><b>New Password:</b></td>
<td><asp:TextBox ID="txtpassword" runat="server" class="textfield " TextMode="Password"  ></asp:TextBox></td>
</tr>
<tr><td></td>
    <td><asp:RequiredFieldValidator ID ="rfvpassword" runat ="server" ControlToValidate ="txtpassword" ValidationGroup="btnsubmit" ErrorMessage ="Please Fill Up Field" Display ="Dynamic" />
<%--<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender3" runat="server"  TargetControlID="rfvpassword"></cc1:ValidatorCalloutExtender> --%>
<asp:CustomValidator ID="cstpassword" runat ="server"  SetFocusOnError ="true" ValidationGroup="btnsubmit" ClientValidationFunction ="validateLength" Display="Dynamic" ErrorMessage ="password at least 6 characters" ControlToValidate ="txtpassword"/>
<%--<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender4" runat="server"  TargetControlID="cstpassword"></cc1:ValidatorCalloutExtender>--%>  </td>
</tr>
<tr>
<td align="right"><b>Re-Type New Password:</b></td>
<td><asp:textbox ID ="txtrepassword" runat = "server"  TextMode ="Password"  class="textfield " /></td>
</tr>
<tr><td></td>
    <td>
<asp:RequiredFieldValidator ID ="rfxrepassword" runat ="server" ValidationGroup="btnsubmit" ControlToValidate ="txtrepassword" ErrorMessage ="Please Fill Up Field" Display ="Dynamic" />
<%--<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender5" runat="server"  TargetControlID="rfxrepassword"></cc1:ValidatorCalloutExtender> 
--%><asp:CompareValidator ID ="cmppassword" runat ="server" ControlToCompare ="txtpassword" ValidationGroup="btnsubmit" ControlToValidate ="txtrepassword" Display="Dynamic"  ErrorMessage ="password and Re-password are not matched" SetFocusOnError ="true"  />
<%--<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender6" runat="server"  TargetControlID="cmppassword"></cc1:ValidatorCalloutExtender> --%></td>
</tr>
<tr><td height="10px"></td></tr>
<tr>
<td> </td>
<td><asp:Button ID="Button1" runat="server" Text="Submit"  ValidationGroup="btnsubmit"
        class="button2" onclick="Button1_Click" />
<a href = "javascript:void(0)" onclick = "document.getElementById('light').style.display='none';document.getElementById('fade').style.display='none'">
    <span class="button2"   >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Close&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span> </a>
        
</td>
</tr></table></td></tr>
<tr><td height="10px"></td></tr>
</table>
</td></tr>
</table>
<div align="center" class=" headertext">
<asp:Label ID="txtlbl" runat="server"  ></asp:Label></div>
</div>

 <div id="fade" class="black_overlay">
</div>
</asp:Panel>
</asp:Content>

