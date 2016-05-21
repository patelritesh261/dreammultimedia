<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Parameteradd.aspx.cs" Inherits="Admin_Parameteradd" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace ="AjaxControlToolkit" TagPrefix="cc1"   %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        height: 366px;
    }
        .style2
        {
            width: 344px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content">
<div id="page-heading">
        <h1>
          <asp:Label ID="title" runat="server" Text="Add Parameter"></asp:Label></h1>
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
         <tr><td>&nbsp;</td></tr>
         <tr>
         
    <td>Category:</td>
    <td class="style2"><asp:dropdownlist ID ="ddlcategory" runat="server" 
            DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="categoryid" class="styledselect_form_1" >
    
    </asp:dropdownlist>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DreammultimediaConnectionString %>" 
            SelectCommand="sp_parameter_category" SelectCommandType="StoredProcedure">
        </asp:SqlDataSource>
    </td></tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td><span style="color:Red " >*</span>Parameter Name</td>
        <td class="style2"><asp:TextBox ID="txtpname" runat="server" class="inp-form" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvpname" runat="server" ValidationGroup="btnsubmit" Display ="None"  ControlToValidate="txtpname" ErrorMessage="Parameter Name Required"  ></asp:RequiredFieldValidator> 
            <cc1:ValidatorCalloutExtender ID="vcepname" runat="server" TargetControlID="rfvpname"></cc1:ValidatorCalloutExtender>  
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td><span style="color:Red " >*</span>Parameter Resolution:</td>
        <td class="style2"><asp:TextBox ID="txtres" runat="server" class="inp-form"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvres" runat="server" ValidationGroup="btnsubmit" Display="None"   ControlToValidate="txtres" ErrorMessage="Parameter Resolution Required"></asp:RequiredFieldValidator>   
            <cc1:ValidatorCalloutExtender ID="vceres" runat="server" TargetControlID="rfvres"></cc1:ValidatorCalloutExtender>  
       </td>
    </tr>
    <%--<tr><td colspan="2" > &nbsp;</td></tr>
    <tr>
    <td>
        Sample Product:
    </td>
    <td><asp:FileUpload ID="fusproduct" runat="server"  BackColor="White" Class="file_1 " /> </td></tr>--%>
     <tr><td>&nbsp;</td></tr>   
    <tr>
    <td>Active</td><td class="style2">
    <asp:checkbox ID="ckbactive" runat="server" /></td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td colspan="3">
    <asp:button ID="btnsubmit" runat="server" Text="Submit" onclick="btnsubmit_Click" ValidationGroup="btnsubmit" class="form-submit" 
            />&nbsp;&nbsp;&nbsp;<asp:Button 
            ID="btnreset" runat ="server" Text="Reset" class="form-reset" 
             onclick="btnreset_Click" /></td>
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

