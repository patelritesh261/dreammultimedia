<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="cmspage.aspx.cs" Inherits="Admin_cmspage" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="content">
<div id="page-heading">
        <h1>
          <asp:Label ID="title" runat="server" Text="Add CMS"></asp:Label></h1>
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
<td><asp:label ID ="lbltitle" runat ="server" Text ="Title" /></td>
<td><asp:TextBox ID="txttitle" runat ="server"  class="inp-form"/></td>
<td><asp:RequiredFieldValidator ID ="rfvtitle" runat ="server" ControlToValidate ="txttitle" ErrorMessage ="Please give title" SetFocusOnError ="true" /></td>
</tr>
<tr><td>&nbsp;</td></tr><tr><td>&nbsp;</td></tr><tr>
<td>Description:</td><td><asp:TextBox ID="txtdesc" runat ="server" TextMode ="MultiLine" class="form-textarea"/></td>
<td><asp:RequiredFieldValidator ID ="rfvdesc" runat ="server" ControlToValidate ="txtdesc" ErrorMessage ="Please give description" SetFocusOnError ="true" /></td>
</tr>
<tr><td>&nbsp;</td></tr><tr><td>&nbsp;</td></tr>
<tr>
<td>Active<asp:CheckBox ID="ckbactive" runat ="server" Text =""/></td>
</tr>
<tr><td>&nbsp;</td></tr><tr><td>&nbsp;</td></tr><tr>
<td><asp:Button id="btnsubmit" runat ="server" Text ="Submit" 
        onclick="btnsubmit_Click"/></td>
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

