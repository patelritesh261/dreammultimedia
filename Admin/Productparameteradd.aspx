<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Productparameteradd.aspx.cs" Inherits="Admin_Productparameteradd" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1"     %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content">
<div id="page-heading">
        <h1>
          <asp:Label ID="title" runat="server" Text="Add ProductParameter"></asp:Label></h1>
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
                                                
                                            </tr>
                                            <tr><td>&nbsp;</td></tr>
                                            <tr id="trError" runat="server">
                                                <td class="listing_bg_03" align="center">
                                                    <asp:Label ID="lblmsg" runat="server" CssClass="error_text" Text=""></asp:Label>
                                                </td>
                                            </tr>
       <tr>
    <td>Product Name:</td>
    <td><asp:DropDownList ID="ddlpdname" runat="server" class="styledselect_form_1"></asp:DropDownList> </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td>Parameter Name:</td>
    <td><asp:DropDownList ID="ddlprname" runat="server" class="styledselect_form_1" ></asp:DropDownList> </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    
    <td><span style="color:Red " >*</span>Credit</td>
    <td><asp:TextBox ID="txtcredit" runat="server" class="inp-form"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvcredit" runat="server" ValidationGroup="btnsubmit" Display="None"  ControlToValidate="txtcredit" ErrorMessage="Credit Required"></asp:RequiredFieldValidator> 
                <cc1:ValidatorCalloutExtender ID="vcecredit" runat="server" TargetControlID="rfvcredit"></cc1:ValidatorCalloutExtender>  
                <asp:RegularExpressionValidator ID="revcredit" runat="server" Display="None"  ValidationExpression="^[0-9]+$" ValidationGroup="btnsubmit" ErrorMessage="Enter Only Number " ControlToValidate="txtcredit"></asp:RegularExpressionValidator>
        <cc1:ValidatorCalloutExtender ID="vcscredit" runat="server" TargetControlID="revcredit" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>
    </td> 
    </tr>
    <tr><td>&nbsp;</td></tr>
    <%--<tr>
    <td><span style="color:Red " >*</span>Size</td>
    <td><asp:TextBox ID="txtsize" runat="server" class="inp-form"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvsize" runat ="server" ValidationGroup="btnsubmit" Display="None" ControlToValidate ="txtsize" ErrorMessage ="Size Required"></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="vcesize" runat="server" TargetControlID="rfvsize"></cc1:ValidatorCalloutExtender>  
    </td>
    </tr>--%>
    <tr><td colspan="2" > &nbsp;</td></tr>
    <tr>
    <td>
        Orignal Product:
    </td>
    <td><asp:FileUpload ID="fusproduct" runat="server" BackColor="White" Class="file_1 "  /> </td></tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td><asp:Button ID="btnsubmit" runat ="server" Text ="SUBMIT" 
            onclick="btnsubmit_Click" ValidationGroup="btnsubmit" class="form-submit" />&nbsp;&nbsp;&nbsp;<asp:Button 
            ID="btnreset" runat ="server" Text="Reset" class="form-reset" 
             onclick="btnreset_Click" /> </td>
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

