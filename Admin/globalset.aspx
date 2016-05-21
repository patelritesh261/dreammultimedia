<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="globalset.aspx.cs" Inherits="Admin_globalset" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content">
<div id="page-heading">
        <h1>
          <asp:Label ID="title" runat="server" Text="Global Setting"></asp:Label></h1>
	</div>
    <table id="content-table">
    <tr>
		<th rowspan="3" class="sized"><img src="images/shared/side_shadowleft.jpg" width="20" height="300" alt="" /></th>
		<th class="topleft"></th>
		<td id="tbl-border-top">&nbsp;</td>
		<th class="topright"></th>
		<th rowspan="3" class="sized"><img src="images/shared/side_shadowright.jpg" width="20" height="300" alt="" /></th>
	</tr>
	<tr>
		<td id="tbl-border-left" class="style1"></td>
		<!--  start content-table-inner ...................................................................... START -->
		<td class="style1"><div id="content-table-inner">
	
			<!--  start table-content  -->
			<div id="table-content">
		<table >
		<tr>
		
                                                <td align="left" valign="top" class="listing_bg_03">
                                                    Please complete the form below. * fields are Mandatory fields
                                                </td>
                                                <td colspan="2" ></td>
                                                
                                            </tr>
                                            <tr><td>&nbsp;</td></tr>
                                            <tr id="trError" runat="server">
                                                <td class="listing_bg_03" align="center">
                                                    <asp:Label ID="lblmsg" runat="server" CssClass="error_text" Text=""></asp:Label>
                                                </td>
                                            </tr>
		<tr>
<td>Site Name:</td>
<td><asp:TextBox ID ="txt1" runat="server" class="inp-form"/></td>
<td><asp:RequiredFieldValidator ID="rfv1" runat ="server" ControlToValidate ="txt1" /></td>
</tr> 
<tr><td>&nbsp;</td></tr> 
<tr>
<td>Site Url:</td>
<td><asp:TextBox ID ="txtsiteurl" runat="server"  class="inp-form"/></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat ="server" ControlToValidate ="txtsiteurl" /></td>
</tr>
<tr><td>&nbsp;</td></tr>  
<tr>
<td>Display Url:</td>
<td><asp:TextBox ID ="txtdisurl" runat="server"  class="inp-form"/></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat ="server" ControlToValidate ="txtdisurl" /></td>
</tr>  
<tr><td>&nbsp;</td></tr>
<tr>
<td>Email:</td>
<td><asp:TextBox ID ="txtemail" runat="server"  class="inp-form"/></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat ="server" ControlToValidate ="txtemail" /></td>
</tr>  
<tr><td>&nbsp;</td></tr>
<tr>
<td>Password:</td>
<td><asp:TextBox ID ="txtpassword" runat="server"  class="inp-form"/></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat ="server" ControlToValidate ="txtpassword" /></td>
</tr>  
<tr><td>&nbsp;</td></tr>
<tr>
<td>Info Email:</td>
<td><asp:TextBox ID ="txtinfoemail" runat="server"  class="inp-form"/></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat ="server" ControlToValidate ="txtinfoemail" /></td>
</tr>  
<tr><td>&nbsp;</td></tr>
<tr>
<td>Map Address:</td>
<td><asp:TextBox ID ="txtmappadd" runat="server"  class="form-textarea"/></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat ="server" ControlToValidate ="txtmappadd" /></td>
</tr>  
<tr><td>&nbsp;</td></tr>
<tr>
<td>Address:</td>
<td><asp:TextBox ID ="txtadd" TextMode="MultiLine"   runat="server"  class="form-textarea"/></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat ="server" ControlToValidate ="txtadd" /></td>
</tr>  
<tr><td>&nbsp;</td></tr>
<tr>
<td>Host Name:</td>
<td><asp:TextBox ID ="txthostname" runat="server" class="inp-form" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat ="server" ControlToValidate ="txthostname" /></td>
</tr>  
<tr><td>&nbsp;</td></tr>
<tr>
<td>Footertext:</td>
<td><asp:TextBox ID ="txtfoter" runat="server"  class="inp-form"/></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat ="server" ControlToValidate ="txtfoter" /></td>
</tr> 
<tr><td>&nbsp;</td></tr>
<tr>
<td>PayPal Address:</td>
<td><asp:TextBox ID ="txtpaypal" runat="server" class="inp-form" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat ="server" ControlToValidate ="txtpaypal" /></td>
</tr> 
<tr><td>&nbsp;</td></tr>
    <tr>
    <td colspan="2" ><asp:Button ID="btnsubmit" runat ="server" Text="Submit" class="form-submit" 
            onclick="btnsubmit_Click"  ValidationGroup="btnsubmit" /><%--<asp:UpdatePanel runat="server" ID="up1">  
    <ContentTemplate>  
        <asp:Label id="lblMessage" runat="server" />  
    </ContentTemplate>  
    <Triggers>  
        <asp:AsyncPostBackTrigger ControlID="btnsubmit" EventName="Click" />  
    </Triggers>  
</asp:UpdatePanel>--%>   </td>
    </tr>
   
		</table>
		</div>
			<!--  end table-content  -->
	
			<div class="clear"></div>
		 
		</div>
		<!--  end content-table-inner ............................................END  -->
		</td>
		<td id="tbl-border-right" class="style1"></td>
	</tr>
	<tr>
		<th class="sized bottomleft"></th>
		<td id="tbl-border-bottom">&nbsp;</td>
		<th class="sized bottomright"></th>
	</tr>
	
	</table>
	<div class="clear">&nbsp;</div>


<!--  end content -->
<div class="clear">&nbsp;</div>
</div>
</asp:Content>

