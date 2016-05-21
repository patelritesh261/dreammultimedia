<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<%@ Register TagName ="usercontrol" TagPrefix ="uc" Src="~/newsuc.ascx"   %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link rel="stylesheet" href="css/index.css" type="text/css" />

		<style type="text/css"  >
		    /*--Tooltip Styles--*/

		

		</style> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <!-- pitch -->
            <div id="bg">
			<div id="pitch">
				<div id="slideshow">
					<%=bindbanner%>
					
					
					
					
				</div>
			</div>
			
			<!-- /pitch -->
			
			<!-- main -->
			<div id="main">
				<div id="intro">
					<h2>Welcome</h2>
					<p> Welcome To Dream Multimedia this web site provide Image, Video, Audio.. and all items not easy available on on internet and you buy one item in different type... and different size for example image available on x-small to x-large size with different credits and Video is mpb, avi, 3gp.</p>
				</div>
			
				<!-- bits -->
				<div id="bits">
				<%--<%=bindcategory %>--%>
				   
					<asp:Repeater ID="rptcategoty" runat="server" > 
					<ItemTemplate >	
					<div class="bit">
						<h4><%# Eval("Name") %></h4>
						<div class="photo">
							<a href="Category.aspx?id=<%# Eval("CategoryID") %>"  ><img src="Admin/upload/category/<%# Eval("Image") %>"  alt="Thumb" height="115" width="203" /></a>
						</div>
						<p> <%# Eval("Description") %> </p>
						<p class="more"><a href="#">Read More</a></p>
						
						
					</div>
					</ItemTemplate>
					
					<FooterTemplate> 
					<div class="clear"></div>
					</FooterTemplate>
					</asp:Repeater>
				</div>
				<!-- /bits -->
					
		
			</div>
			<!-- /main -->
			
			<!-- side -->
	        <uc:usercontrol ID="Usercontrol1" runat="server"  />
			</div>
			<!-- /side -->
</asp:Content>

