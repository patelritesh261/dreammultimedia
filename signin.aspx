<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="signin.aspx.cs" Inherits="signin" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!-- Custom jquery scripts -->

   <script src="Admin/js/jquery/custom_jquery.js" type="text/javascript"></script>
 <script src="Admin/js/jquery/jquery.pngFix.pack.js" type="text/javascript"></script>
<link href="css/demo.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(document).ready(function() {
            $(document).pngFix();
        });
    </script>
     <script language="javascript" type="text/javascript">

         function showbox() {
             //alert('1');
             document.getElementById('light').style.display = 'block';
             document.getElementById('fade').style.display = 'block';
         }
    </script> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- main -->
<div id="main1">
<br />
<div class="login"   >
<h2 >Login</h2>
<asp:Panel ID="panal2" runat="server" DefaultButton ="btnsubmit"> 
<div id="table-content" style="margin-left:20px; " >
	
		
        <div id="message-red">
                    <table cellspacing="0" cellpadding="0" border="0" width="100%" id="trError" runat="server" visible="false">
                        <tbody>
                            <tr>
                                <td class="red-left">
                                  <asp:Label ID="lblError" runat="server"></asp:Label>
                                </td>
                                <td class="red-right">
                                    <a class="close-red">
                                        <img alt="" src="Admin/images/table/icon_close_red.gif"></a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    </div> 
 <table>                   		
<tr><td>&nbsp;</td></tr>
<tr>
<td><span style ="Color:Red ">*</span>Email-Address:</td>
<td><asp:textbox ID ="txtemail" runat = "server"  CssClass="txtbox1" ValidationGroup="btnsubmit" Width="150px"  /><asp:RequiredFieldValidator ID ="rfvusername" runat ="server" ControlToValidate ="txtemail" ValidationGroup="btnsubmit" ErrorMessage ="please fill username" Display ="None"  /> <cc1:ValidatorCalloutExtender ID="vce1" runat="server" TargetControlID="rfvusername"></cc1:ValidatorCalloutExtender>    </td>             
</tr>
<tr><td>&nbsp;</td></tr>
<tr>
<td><span style ="Color:Red ">*</span>Password:</td>
<td><asp:textbox ID ="txtpassword" runat = "server"  TextMode ="Password"  CssClass="txtbox1" Width="150px" />
<asp:RequiredFieldValidator ID ="rfvpassword" runat ="server" ControlToValidate ="txtpassword" ValidationGroup="btnsubmit" ErrorMessage ="please fill password" Display ="None" /> <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" TargetControlID="rfvpassword"></cc1:ValidatorCalloutExtender>    </td>      
</tr>

<tr><td>&nbsp;</td></tr>
<tr>
<td></td>
<td style="padding-left:20px;"  >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%--<asp:LinkButton ID="lbtnfp" runat="server" 
        onclick="lbtnfp_Click">  Forgot Password</asp:LinkButton>--%><a href = "javascript:void(0)" onclick = "document.getElementById('light').style.display='block';document.getElementById('fade').style.display='block'" >Forgot Password</a>
        
        
        </td>
</tr>
<tr>
<%--<td colspan="2" >&nbsp;</td>--%><td><asp:Button ID="btnsubmit" runat ="server" Text="" ValidationGroup="btnsubmit"  CssClass="login-btn" ToolTip="Login"
        onclick="btnsubmit_Click"/></td>
</tr>
					</table> 
					</div>
</asp:Panel>				
</div>

<div class="login" style="margin:0 0 0 130px;  "   >
    <h2 >New Customer</h2>
    <div class="logininner"  style="margin-top:60px;"   >
	
		 <a href="signup.aspx" title="register here" >
                    <br/>
                    <h4 style="margin-bottom:0px; margin-top:9px;   ">New Customer</h4>
                    <h4 style="margin-bottom:0px; ">Click Here</h4>
                    <h4 style="" >To Register</h4>
                    <br/>
                    </a>
         
	</div><br />
</div>

<div style="width:1000px; float:left; margin-top:60px;   "  >
  <marquee behavior="scroll" direction="left">
  <asp:Repeater ID="rptimage" runat="server"  >
  <ItemTemplate>
    <a href='SubCategory.aspx?sid=<%# Eval("CategoryID") %>'  ><img src='Admin/upload/category/<%# Eval("Image") %>' height ="200" width="200"  /></a>
  </ItemTemplate> 
  
  </asp:Repeater></marquee>
   
</div>
</div> 
<asp:Panel ID="pan" runat="server" DefaultButton="Button1">  		
		 <div id="light" class="white_content">
    <table cellpadding="0" cellspacing="0" border="0" style="background-color:#222222;" width="100%">
    <tr><td height="16px"><%--<a href = "javascript:void(0)" onclick = "document.getElementById('light').style.display='none';document.getElementById('fade').style.display='none'"><img src="images/button/close2.jpg" style="border :0px"  width="13px" align="right" height="13px" alt=" "/></a>--%></td></tr>
    
    <tr>
    <td style="padding-left:16px;padding-right:16px;padding-bottom:16px"> 
    <table align="center"  border="0" cellpadding="0" cellspacing="0" style="background-color:#fff" width="100%">
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td align="center" colspan="2" class="headertext" >Forget Password Form </td>
    </tr>
    <tr>
    <td>
    &nbsp;
    </td>
    </tr>
<tr><td align="center">
<table>
<tr>
<td align="right"><b>Email Address:</b></td>
<td><asp:TextBox ID="txtEmailAdd" runat="server" CssClass="textfield"  ></asp:TextBox></td>
</tr>
<tr>
<td></td>
<td><asp:RequiredFieldValidator ID ="RequiredFieldValidator1" runat ="server" ValidationGroup="btnsub" ControlToValidate ="txtEmailAdd" ErrorMessage ="Please Fill Email" Display ="Dynamic" /> </td>
</tr>

<tr><td height="10px"></td></tr>
<tr>
<td> </td>
<td><asp:Button ID="Button1" runat="server" Text="Submit"  ValidationGroup="btnsub"
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
</div></asp:Panel>	
<!-- /main -->
</asp:Content>


