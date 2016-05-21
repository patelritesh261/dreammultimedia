<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Packageadd.aspx.cs" Inherits="Admin_Packageadd" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1"    %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 342px;
        }
        .style2
        {
            width: 437px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content">
<div id="page-heading">
        <h1>
          <asp:Label ID="title" runat="server" Text="Add Package"></asp:Label></h1>
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
                                                <tr><td>&nbsp;</td></tr>
                                            </tr>
                                            <tr><td>&nbsp;</td></tr>
                                            <tr id="trError" runat="server">
                                                <td class="listing_bg_03" align="center">
                                                    <asp:Label ID="lblmsg" runat="server" CssClass="error_text" Text=""></asp:Label>
                                                </td>
                                            </tr>
                                            
         <tr>
            <td><span style="color:Red " >*</span>Package Name</td>
            <td class="style2"><asp:TextBox ID="txtname" runat ="server" class="inp-form"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvname" runat="server" ValidationGroup="btnsubmit" Display="None"  ControlToValidate="txtname" ErrorMessage="Package Name Required"></asp:RequiredFieldValidator>
                <cc1:ValidatorCalloutExtender ID="vcename" runat="server" TargetControlID="rfvname"></cc1:ValidatorCalloutExtender>  
            </td>
               
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td><span style="color:Red " >*</span>Credit</td>
            <td class="style2"><asp:TextBox ID="txtcredit" runat ="server" class="inp-form" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvcredit" runat="server" ValidationGroup="btnsubmit" Display="None"  ControlToValidate="txtcredit" ErrorMessage="Credit Required"></asp:RequiredFieldValidator> 
                <cc1:ValidatorCalloutExtender ID="vcecredit" runat="server" TargetControlID="rfvcredit"></cc1:ValidatorCalloutExtender>  
                <asp:RegularExpressionValidator ID="revcredit" runat="server" Display="None"  ValidationExpression="^[0-9]+$" ValidationGroup="btnsubmit" ErrorMessage="Enter Only Number " ControlToValidate="txtcredit"></asp:RegularExpressionValidator>
        <cc1:ValidatorCalloutExtender ID="vcscredit" runat="server" TargetControlID="revcredit" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>
            </td>
            
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td><span style="color:Red " >*</span>Rupees</td>
            <td class="style2"><asp:TextBox ID="txtrupees" runat ="server" class="inp-form" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvtxtrupees" runat="server" ValidationGroup="btnsubmit" Display="None"  ControlToValidate="txtrupees" ErrorMessage="Rupees Required"></asp:RequiredFieldValidator> 
                <cc1:ValidatorCalloutExtender ID="vceruppes" runat="server" TargetControlID="rfvtxtrupees"></cc1:ValidatorCalloutExtender>  
                <asp:RegularExpressionValidator ID="revrupees" runat="server" Display="None"  ValidationExpression="^[0-9]+$" ValidationGroup="btnsubmit" ErrorMessage="Enter Only Number " ControlToValidate="txtrupees"></asp:RegularExpressionValidator>
        <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" runat="server" TargetControlID="revrupees" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>
            </td>
            
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td><span style="color:Red " >*</span>Image</td>
            <td class="style2"><asp:FileUpload ID="fuimage" runat="server" class="file_1"/>
                <asp:RequiredFieldValidator ID="rfvfuimage" runat="server" Display ="None"  ValidationGroup="btnsubmit"   ControlToValidate="fuimage"   ErrorMessage="Please Choose Image" ></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="vcefuimg" runat="server" TargetControlID="rfvfuimage" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>  
        <asp:RegularExpressionValidator ID="RfvFileBanner" runat="server" Display="None"  ControlToValidate="fuimage" SetFocusOnError="true" ValidationExpression=".+(.bmp|.BMP|.png|.PNG|.JPEG|.jpeg|.JPG|.jpg|.gif|.GIF)$" ErrorMessage="Please upload image only .jpg , .bmp , .png, .gif " ValidationGroup="btnsubmit"
                                                                                    CssClass="cancel_error_bg"></asp:RegularExpressionValidator>
        <cc1:ValidatorCalloutExtender ID="vcefuimage" runat="server" TargetControlID="RfvFileBanner" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>                                                                              
            <asp:ImageButton ID="imageup" runat="server" onclick="imageup_Click" ImageUrl="~/Admin/upload/package/" Height="50" Width="50"    /> 
            </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td colspan="3"><asp:Button ID="btnsubmit" runat="server" Text="Submit" 
                    onclick="btnsubmit_Click" ValidationGroup="btnsubmit" class="form-submit"  />&nbsp;&nbsp;&nbsp;<asp:Button 
            ID="btnreset" runat ="server" Text="Reset" class="form-reset" 
             onclick="btnreset_Click" 
              /> </td>
        </tr>                                   
        </table></div>
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

