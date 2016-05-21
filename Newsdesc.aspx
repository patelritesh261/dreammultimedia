<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Newsdesc.aspx.cs" Inherits="Newsdesc" Title="Untitled Page" %>
<%@ Register TagName ="usercontrol" TagPrefix ="uc" Src="~/newsuc.ascx"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="bg">
<div id="main" style="min-height:565px;"  >
                <br />
				<h2 class="inner">News</h2>
			<div id="page">
			<!-- blog post -->
                
			
				<asp:Repeater ID="rptnewsdesc" runat="server">
                
                <ItemTemplate >
                <p class="blog-date"><span><%#Eval("day")%></span><br /><%# Eval("month")  %></p>
					<div class="blog-body">
						<h3><%# Eval("Title") %></h3><br />
						<p><%# Eval("FDescription") %></p>
					</div>
					
				</ItemTemplate>
				
				</asp:Repeater>
				<div class="clear"></div>
				</div>
                
				<!-- /blog post -->
				
				<!-- blog post -->
				<%--<div class="blog-post">
					<p class="blog-date"><span>11th</span><br />October</p>
					<div class="blog-body">
						<h3><a href="#">Hello World</a></h3>
						<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque vel lorem eu libero laoreet facilisis. Aenean placerat, ligula quis placerat iaculis, mi magna luctus nibh, adipiscing pretium erat neque vitae augue. <a href="#">&raquo;</a></p>
					</div>
					<div class="clear"></div>
				</div>
				<!-- /blog post -->
				
				<!-- blog post -->
				<div class="blog-post">
					<p class="blog-date"><span>7th</span><br />October</p>
					<div class="blog-body">
						<h3><a href="#">Hello World</a></h3>
						<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque vel lorem eu libero laoreet facilisis. Aenean placerat, ligula quis placerat iaculis, mi magna luctus nibh, adipiscing pretium erat neque vitae augue. <a href="#">&raquo;</a></p>
					</div>
					<div class="clear"></div>
				</div>
				<!-- /blog post -->
				<div class="blog-post">
					<p class="blog-date"><span>7th</span><br />October</p>
					<div class="blog-body">
						<h3><a href="#">Hello World</a></h3>
						<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque vel lorem eu libero laoreet facilisis. Aenean placerat, ligula quis placerat iaculis, mi magna luctus nibh, adipiscing pretium erat neque vitae augue. <a href="#">&raquo;</a></p>
					</div>
					<div class="clear"></div>
				</div>--%>
			</div>
		
		
			<uc:usercontrol ID="Usercontrol1" runat="server" />
			</div>
</asp:Content>

