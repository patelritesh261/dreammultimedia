<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Productadd.aspx.cs" Inherits="Admin_Productadd" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1"    %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 14px;
        }
        .style2
        {
            height: 28px;
        }
        .style3
        {
            width: 444px;
        }
        .style4
        {
            height: 28px;
            width: 444px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content">
<div id="page-heading">
        <h1>
          <asp:Label ID="title" runat="server" Text="Add Product"></asp:Label></h1>
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
            <td><span style="color:Red " >*</span>Product Name</td>
            <td class="style3"><asp:TextBox ID="txtpname" runat="server" class="inp-form" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvpname" runat="server" ValidationGroup="btnsubmit" Display="None"  ControlToValidate="txtpname" ErrorMessage="Product Name must Required"></asp:RequiredFieldValidator>   
                <cc1:ValidatorCalloutExtender ID="vcepname" runat="server" TargetControlID="rfvpname"></cc1:ValidatorCalloutExtender>  
            </td>
        </tr>
         <tr><td>&nbsp;</td></tr>
        <tr>
            <td>Category Name</td>
            <td class="style3">
                <asp:DropDownList ID="ddlcategoryname" runat="server" class="styledselect_form_1"
                    DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="CategoryID" 
                    Height="24px" Width="216px">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:DreammultimediaConnectionString %>" 
                    SelectCommand="sp_ddlproductbind" SelectCommandType="StoredProcedure">
                </asp:SqlDataSource>
            </td>
        </tr>
         <tr><td>&nbsp;</td></tr>
        <tr>
            <td><span style="color:Red " >*</span>Product Code</td>
            <td class="style3"><asp:TextBox ID="txtpcode" runat="server" class="inp-form"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvpcode" runat="server" ValidationGroup="btnsubmit" Display="None"  ControlToValidate="txtpcode" ErrorMessage="Product Code Required"></asp:RequiredFieldValidator>   
                <cc1:ValidatorCalloutExtender ID="vcepcode" runat="server" TargetControlID="rfvpcode"></cc1:ValidatorCalloutExtender>  
            </td>
        </tr>
         <tr><td>&nbsp;</td></tr>
        <tr>
            <td class="style2"><span style="color:Red " >*</span>Rating</td>
            <td class="style4"><asp:TextBox ID="txtrank" runat="server" class="inp-form"  ></asp:TextBox> 
                <asp:RequiredFieldValidator ID="rfvrank" runat="server" Display="None" ControlToValidate="txtrank" ValidationGroup="btnsubmit" ErrorMessage="Please Fill Up"></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="vcerank" runat="server" TargetControlID="rfvrank" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>      
        <asp:RegularExpressionValidator ID="revrank" runat="server" Display="None"  ValidationExpression="^[0-9]+$" ValidationGroup="btnsubmit" ErrorMessage="Enter Only Number " ControlToValidate="txtrank"></asp:RegularExpressionValidator>
        <cc1:ValidatorCalloutExtender ID="vcsrank" runat="server" TargetControlID="revrank" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>     
            </td>
            
        </tr>
         <tr><td>&nbsp;</td></tr>
        <tr>
            <td><span style="color:Red " >*</span>Image</td>
            <td class="style3"><asp:FileUpload ID="fuimage" runat="server" class="file_1" />
                <asp:RequiredFieldValidator ID="rfvfuimage" runat="server" Display ="None"  ValidationGroup="btnsubmit"   ControlToValidate="fuimage"   ErrorMessage="Please Choose Image" ></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="vcefuimg" runat="server" TargetControlID="rfvfuimage" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>  
        <asp:RegularExpressionValidator ID="RfvFileBanner" runat="server" Display="None"  ControlToValidate="fuimage" SetFocusOnError="true" ValidationExpression=".+(.bmp|.BMP|.png|.PNG|.JPEG|.jpeg|.JPG|.jpg|.gif|.GIF|.flv|.FLV|.mp4|.MP4|.3gp|.3GP|.avi|.AVI)$" ErrorMessage="Please upload image only .jpg , .bmp , .png, .gif " ValidationGroup="btnsubmit"
                                                                                    CssClass="cancel_error_bg"></asp:RegularExpressionValidator>
        <cc1:ValidatorCalloutExtender ID="vcefuimage" runat="server" TargetControlID="RfvFileBanner" HighlightCssClass="validatorCalloutHighlight"></cc1:ValidatorCalloutExtender>                                                                              
             <asp:ImageButton ID="imageup" runat="server" onclick="imageup_Click" ImageUrl="~/Admin/upload/product/" Height="50" Width="50"    />         
            
            </td>
        </tr>
         <tr><td>&nbsp;</td></tr>
        <tr>
            <td>Description</td>
            <td class="style3"><asp:TextBox ID="txtdesc" runat="server" TextMode="MultiLine" class="form-textarea"  Height="97px"></asp:TextBox>  </td>
        </tr>
         <tr><td>&nbsp;</td></tr>
        <tr>
            <td>Active</td><td class="style3"><asp:CheckBox ID="ckbactive" runat="server"  /> </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td><asp:Button id="btnsubmit" runat="server" Text="Submit" 
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

