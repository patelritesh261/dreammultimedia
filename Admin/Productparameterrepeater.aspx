<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Productparameterrepeater.aspx.cs" Inherits="Admin_Productparameterrepeater" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content-outer">
<!-- start content -->
<div id="content">

	<!--  start page-heading -->
	<div id="page-heading">
		<h1>Product Parameter Listing</h1>
	</div>
	<!-- end page-heading -->
	<table border="0" width="100%" cellpadding="0" cellspacing="0" id="content-table">
	<tr>
		<th rowspan="3" class="sized"><img src="images/shared/side_shadowleft.jpg" width="20" height="300" alt="" /></th>
		<th class="topleft"></th>
		<td id="tbl-border-top">&nbsp;</td>
		<th class="topright"></th>
		<th rowspan="3" class="sized"><img src="images/shared/side_shadowright.jpg" width="20" height="300" alt="" /></th>
	</tr>
	<tr>
		<td id="tbl-border-left"></td>
		<td>
		<!--  start content-table-inner ...................................................................... START -->
		<div id="content-table-inner">
		
			<!--  start table-content  -->
			<div id="table-content">
			<table >
			<tr>
			    <td width="54%" align="left" valign="middle">
                                                        <asp:Panel ID="searchpanel" runat="server" >
                                                            <table width="70%" cellspacing="2" cellpadding="0">
                                                                <tr>
                                                                    <td align="left" valign="middle" class="grey_text">
                                                                        <strong>Search by Credit:</strong>
                                                                    </td>
                                                                    <td align="left" valign="middle">
                                                                        <asp:TextBox ID="txtserch" runat="server" class="inp-form" ></asp:TextBox>
                                                                    </td>
                                                                    <td align="left" valign="middle">
                                                                        <asp:Button runat="server" Text="Search" ID="btnserch" CssClass="form-search "
                                                                            OnClick="btnserch_Click" />&nbsp;&nbsp;
                                                                        <asp:Button runat="server" Text="View All" ID="btnviewall" CssClass="form-viewall "
                                                                            OnClick="btnviewall_Click" />
                                                                        <asp:LinkButton ID="linkadd" runat="server" 
                                                                            onclick="linkadd_Click"  ><img src="images/forms/form_add.png" height="30" width="80" />  </asp:linkbutton> 
                                                                    </td>
                                                                    <td colspan="3" ></td>
                                                                </tr>
                                                                
                                                                <tr>
                                                                    <td >
                                                                        <br />
                                                                    </td>
                                                                    <td>
                                                                        <br />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="left" valign="middle" class="grey_text">
                                                                    </td>
                                                                    
                                                                </tr>
                                                                <tr><td>&nbsp;</td></tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </td>
			</tr>
			</table>
			<!--  start message-green -->
				<div id="messagegreen" runat="server">
                                    <table border="0" width="100%" cellpadding="0" cellspacing="0">
                                        <tr>
                                            
                                            <td class="green-left">
                                                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                                            </td>
                                            <td class="green-right">
                                                <a class="close-green">
                                                    <img src="images/table/icon_close_green.gif" alt="" /></a>
                                            </td>
                                        </tr>
                                       
                                    </table>
                                </div>
				<!--  end mes sage-green -->
        
        <form id="mainform" action="">
            <asp:Repeater ID="rptproductparameter" runat="server" 
            onitemcommand="rptproductparameter_ItemCommand"  >
        <HeaderTemplate>
                <table id="product-table" width="100%" >
                    <tr>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Product Name
                        </th>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Parameter Name
                        </th >
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Credit
                        </th>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Size
                        </th>
                        <th class="table-header-repeat line-left"><a href="">
                            Action
                        </th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate >
                <tr>
                    <td><%# Eval("pdname")  %></td>
                    <td><%# Eval("prname")  %></td>
                    <td>
                        <%# Eval("credit")  %>
                    </td>
                    
                    <td>
                        <%# Eval("size")  %>
                    </td>
                    
                   <td class="options-width">
                        <asp:LinkButton  ID="btnedit" runat ="server"  CommandName ="EditData" CommandArgument ='<%# Eval("PPID") %>' CssClass="icon-1 info-tooltip" ></asp:LinkButton> 
                        <asp:LinkButton  ID="btndelete" runat ="server" CommandName ="DeleteData" CommandArgument ='<%# Eval("PPID") %>' CssClass="icon-2 info-tooltip" OnClientClick="return window.confirm('Do you really want to delete this record ?')"></asp:LinkButton> 
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate >
            </table>
            </FooterTemplate>
        </asp:Repeater>

            <asp:LinkButton ID="linkprev" runat ="server" 
            PostBackUrl="~/Admin/Productparameterrepeater.aspx"   onclick="linkprev_Click"   >Prev</asp:LinkButton>&nbsp;
        
        <asp:LinkButton ID="linknext" runat="server" 
            PostBackUrl ="~/Admin/Productparameterrepeater.aspx"   onclick="linknext_Click" >Next</asp:LinkButton> 
        </form> 
    </div></div> </td>
		<td id="tbl-border-right"></td>
	</tr>
	<tr>
		<th class="sized bottomleft"></th>
		<td id="tbl-border-bottom">&nbsp;</td>
		<th class="sized bottomright"></th>
	</tr>
	</table> 
</div> 
    </div>
</asp:Content>

