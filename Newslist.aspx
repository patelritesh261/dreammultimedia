<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Newslist.aspx.cs" Inherits="Newslist" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css" >
    .blog-body {
float: right;
width: 600px;
border-left: 1px solid #ddd;
padding: 0 0 0 12px;
}
</style>  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!-- main -->
			<div id="main" style="min-height:565px;"  ><br />
				<h2 class="inner">News</h2>
			<div id="page">
				<asp:Repeater ID="rptnewsdesc" runat="server" 
                    onitemcommand="rptnewsdesc_ItemCommand">
				<ItemTemplate >
				<div class="blog-post">
					<p class="blog-date"><span><%#Eval("day")%></span><br /><%# Eval("month")  %></p>
			            <div class="blog-body">
						<h3><%# Eval("Title") %></h3>
						<p><%# Eval("SDescription") %> &nbsp;&nbsp;<asp:LinkButton ID="lkbtnmore" runat="server" CommandName="More" CommandArgument='<%# Eval("NewsID") %>'>More</asp:LinkButton></p>
						
					</div>
					<div class="clear"></div>
				</div>
				</ItemTemplate>
				
				</asp:Repeater>
				<asp:LinkButton ID="linkprev" runat ="server" 
            PostBackUrl="~/Newslist.aspx"   onclick="linkprev_Click"   >Prev</asp:LinkButton>&nbsp;
        
        <asp:LinkButton ID="linknext" runat="server" 
            PostBackUrl ="~/Newslist.aspx"   onclick="linknext_Click" >Next</asp:LinkButton> 
				<%--<!-- blog post -->
				<div class="blog-post">
					<p class="blog-date"><span>14th</span><br />October</p>
					<div class="blog-body">
						<h3><a href="#">Hello World</a></h3>
						<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque vel lorem eu libero laoreet facilisis. Aenean placerat, ligula quis placerat iaculis, mi magna luctus nibh, adipiscing pretium erat neque vitae augue. <a href="#">&raquo;</a></p>
					</div>
					<div class="clear"></div>
				</div>
				<!-- /blog post -->
				
				<!-- blog post -->
				<div class="blog-post">
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
				<!-- /blog post -->--%>
				
			</div>
		
			</div>
			<!-- /main -->
<%--<div id="main">
                <br />
				<h2 class="inner">News</h2>
				<div id="page">
				<!-- blog post -->
				<div class="blog-post">
					<p class="blog-date"><span>14th</span><br />October</p>
					<div class="blog-body">
						<h3><a href="#">Hello World</a></h3>
						<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque vel lorem eu libero laoreet facilisis. Aenean placerat, ligula quis placerat iaculis, mi magna luctus nibh, adipiscing pretium erat neque vitae augue. <a href="#">&raquo;</a></p>
					</div>
					<div class="clear"></div>
				</div>
				<asp:Repeater ID="rptnewsdesc" runat="server" 
                    onitemcommand="rptnewsdesc_ItemCommand">
				<ItemTemplate >
				<div class="blog-post">
					<p class="blog-date"><span><%#Eval("day")%></span><br /><%# Eval("month")  %></p>
			            <div class="blog-body">
						<h3><%# Eval("Title") %></h3>
						<p><%# Eval("SDescription") %> &nbsp;&nbsp;<asp:LinkButton ID="lkbtnmore" runat="server" CommandName="More" CommandArgument='<%# Eval("NewsID") %>'>More</asp:LinkButton></p>
						
					</div>
					<div class="clear"></div>
				</div>
				</ItemTemplate>
				
				</asp:Repeater>
				</div> 
			
		
			</div>--%>
</asp:Content>

