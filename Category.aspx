<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="Category" Title="Untitled Page" %>
<%@ Register TagName ="usercontrol" TagPrefix ="uc" Src="~/newsuc.ascx"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div id="bg">      <!-- main -->
			<div id="main" style="min-height:580px; " >
			<br /><br />
				<h2 class="inner">Category</h2>
			
				<!-- portfolio bits -->
				<div id="bits">
				
				<asp:Repeater ID="rptproduct" runat="server" > 
					<ItemTemplate >	
					<div class="bit">
						<h4><%# Eval("Name") %></h4>
						<div class="photo">
							<a href="SubCategory.aspx?sid=<%# Eval("CategoryID") %>" class ="tip_trigger" ><img src="Admin/upload/category/<%# Eval("Image") %>" alt="Thumb" height="115" width="203" /><span class="tip" ><img src="Admin/upload/category/<%# Eval("Image") %>" height="250" alt="" /></span></a>
						</div>
						<p> <%# Eval("Description") %> </p>
						<p class="more"><a href="#">Read More</a></p>
						
					</div>
					</ItemTemplate>
					
					<FooterTemplate> 
					<div class="clear"></div>
					</FooterTemplate>
					</asp:Repeater>
				<%--<%=bindsub %>--%>
					<%--<div class="bit">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p1"><img src="images/thumb1.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="bit">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p2"><img src="images/thumb2.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="bit last">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p3"><img src="images/thumb3.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="line"></div>
					
					<div class="bit">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p4"><img src="images/thumb1.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="bit">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p5"><img src="images/thumb2.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="bit last">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p6"><img src="images/thumb3.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>--%>
					
					<div class="clear"></div>
				</div>
				<!-- /portfolio bits -->
					
			</div>
			<uc:usercontrol runat="server" />
			<!-- /main -->         
		</div>

</asp:Content>

