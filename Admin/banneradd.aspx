<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="banneradd.aspx.cs" Inherits="Admin_banneradd" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        height: 375px;
    }
        .style2
        {
            width: 457px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<asp:ScriptManager ID="ScriptManager1" runat="server" EnableViewState ="true">
    </asp:ScriptManager>--%>
    <div id="content">
<div id="page-heading">
        <h1>
          <asp:Label ID="title" runat="server" Text="Add Banner"></asp:Label></h1>
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
    <td><span style="color:Red " >*</span> Title</td>
    <td class="style2" ><asp:TextBox ID="txttitle" runat="server" class="inp-form"  ></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtitle" runat ="server" Display="None"  ControlToValidate ="txttitle" ValidationGroup="btnsubmit"  ErrorMessage ="Title must not Empty"></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="vcetitle" runat="server"  TargetControlID="rfvtitle" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>      
    </td>
    <td>&nbsp;</td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    
    <tr>
    <td><span style="color:Red " >*</span>Image:</td>
    <td class="style2"  ><asp:FileUpload ID="fuimage" runat="server" BackColor="White" Class="file_1 "   />
        <asp:RequiredFieldValidator ID="rfvfuimage" runat="server" Display ="None"  ValidationGroup="btnsubmit"   ControlToValidate="fuimage"   ErrorMessage="Please Choose Image" ></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="vcefuimg" runat="server" TargetControlID="rfvfuimage" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>  
        <asp:RegularExpressionValidator ID="RfvFileBanner" runat="server" Display="None"  ControlToValidate="fuimage" SetFocusOnError="true" ValidationExpression=".+(.bmp|.BMP|.png|.PNG|.JPEG|.jpeg|.JPG|.jpg|.gif|.GIF)$" ErrorMessage="Please upload image only .jpg , .bmp , .png, .gif " ValidationGroup="btnsubmit"
                                                                                    CssClass="cancel_error_bg"></asp:RegularExpressionValidator>
        <cc1:ValidatorCalloutExtender ID="vcefuimage" runat="server" TargetControlID="RfvFileBanner" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>                                                                              
        <asp:ImageButton ID="imageup" runat="server" onclick="imageup_Click" ImageUrl="~/Admin/upload/banner/" Height="50" Width="50"    /> 
                                                                                
                                                                                
   </td>
  
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td><span style="color:Red " >*</span>Rank</td>
    <td class="style2"  ><asp:TextBox ID="txtrank" runat="server" class="inp-form"  ></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvrank" runat="server" Display="None" ControlToValidate="txtrank" ValidationGroup="btnsubmit" ErrorMessage="Please Fill Up"></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="vcerank" runat="server" TargetControlID="rfvrank" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>      
        <asp:RegularExpressionValidator ID="revrank" runat="server" Display="None"  ValidationExpression="^[0-9]+$" ValidationGroup="btnsubmit" ErrorMessage="Enter Only Number " ControlToValidate="txtrank"></asp:RegularExpressionValidator>
        <cc1:ValidatorCalloutExtender ID="vcsrank" runat="server" TargetControlID="revrank" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>     
    </td>
   </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td>Active</td>
    <td class="style2"><asp:CheckBox ID="ckbactive" runat="server"/></td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
    <td><asp:Button ID="btnsubmit" runat ="server" Text="Submit" class="form-submit" 
            onclick="btnsubmit_Click"  ValidationGroup="btnsubmit" /><%--<asp:UpdatePanel runat="server" ID="up1">  
    <ContentTemplate>  
        <asp:Label id="lblMessage" runat="server" />  
    </ContentTemplate>  
    <Triggers>  
        <asp:AsyncPostBackTrigger ControlID="btnsubmit" EventName="Click" />  
    </Triggers>  
</asp:UpdatePanel>--%>  &nbsp;&nbsp;&nbsp;<asp:Button 
            ID="btnreset" runat ="server" Text="Reset" class="form-reset" 
             onclick="btnreset_Click" 
              /> </td>
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

