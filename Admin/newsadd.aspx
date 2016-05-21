<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="newsadd.aspx.cs" Inherits="Admin_newsadd" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1"    %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content">
<div id="page-heading">
        <h1>
          <asp:Label ID="title" runat="server" Text="Add News"></asp:Label></h1>
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
		<td id="tbl-border-left"></td>
		<!--  start content-table-inner ...................................................................... START -->
		<td><div id="content-table-inner">
	
			<!--  start table-content  -->
			<div id="table-content">
		<table >
		<tr>
                                                <td align="left" valign="top" class="listing_bg_03">
                                                    Please complete the form below. * fields are Mandatory fields
                                                </td>
                                                
                                            </tr>
                                            <tr><td>&nbsp;</td></tr>
                                            <tr id="trError" runat="server">
                                                <td class="listing_bg_03" align="center">
                                                    <asp:Label ID="lblmsg" runat="server" CssClass="error_text" Text=""></asp:Label>
                                                </td>
                                      
                                            </tr>
        <tr>
    <td><span style="color:Red " >*</span>Title</td>
    <td><asp:TextBox ID="txttitle" runat="server"  class="inp-form"></asp:TextBox>
        <asp:RequiredFieldValidator id="rfvtitle" runat="server" ValidationGroup="btnsubmit" Display="None" ControlToValidate ="txttitle" ErrorMessage ="Title must Required"></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender id="vcetitle" runat="server" TargetControlID="rfvtitle"></cc1:ValidatorCalloutExtender> 
    </td>
  </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td><span style="color:Red " >*</span>Short Description</td>
    <td><asp:TextBox ID="txtsdesc" runat="server" TextMode ="MultiLine" 
            class="form-textarea"  Height="97px" ></asp:TextBox>
        <asp:RequiredFieldValidator id="rfvsdesc" runat="server" ValidationGroup="btnsubmit" Display="None" ControlToValidate ="txtsdesc" ErrorMessage ="Short Description Required"></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="vcesdesc" runat="server" TargetControlID="rfvsdesc"></cc1:ValidatorCalloutExtender>  
    </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td><span style="color:Red " >*</span>Full Description</td>
    <td><asp:TextBox ID="txtfdesc" runat="server" TextMode ="MultiLine" 
            class="form-textarea"  Height="97px" ></asp:TextBox>
        <asp:RequiredFieldValidator id="rfvfdesc" runat="server" ValidationGroup="btnsubmit" Display="None"   ControlToValidate ="txtfdesc" ErrorMessage ="Full Description  Required"></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" TargetControlID="rfvfdesc"></cc1:ValidatorCalloutExtender>          
        
    </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td><span style="color:Red " >*</span>Date</td>
    <td><asp:TextBox ID="txtdate" runat="server" class="inp-form"></asp:TextBox>
        <cc1:CalendarExtender ID="hhh" runat="server" TargetControlID="txtdate"></cc1:CalendarExtender></td>
    </tr>
     <tr><td>&nbsp;</td></tr>
    <tr>
    <td><span style="color:Red " >*</span>Rank</td>
    <td><asp:TextBox ID="txtrank" runat="server" class="inp-form" ></asp:TextBox> </td>
    <td>
        <asp:RequiredFieldValidator ID="rfvrank" runat="server" Display="None" ControlToValidate="txtrank" ValidationGroup="btnsubmit" ErrorMessage="Please Fill Up"></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="vcerank" runat="server" TargetControlID="rfvrank" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>      
        <asp:RegularExpressionValidator ID="revrank" runat="server" Display="None"  ValidationExpression="^[0-9]+$" ValidationGroup="btnsubmit" ErrorMessage="Enter Only Number " ControlToValidate="txtrank"></asp:RegularExpressionValidator>
        <cc1:ValidatorCalloutExtender ID="vcsrank" runat="server" TargetControlID="revrank" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>     
        
    </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    
    <td>Active</td><td><asp:CheckBox ID="ckbactive" runat="server"  /></td>
    
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td colspan ="3">
    <asp:Button ID="btnsubmit" runat ="server" Text ="Submit" ValidationGroup="btnsubmit" class="form-submit" 
            onclick="btnsubmit_Click" 
             />&nbsp;&nbsp;&nbsp;<asp:Button 
            ID="btnreset" runat ="server" Text="Reset" class="form-reset" 
             onclick="btnreset_Click" 
              />
    </td>
    </tr>
                                            
       </table></div> </div> </td>
	</tr> 
   
    </table>
    </div>

</asp:Content>

