<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Searchpage.aspx.cs" Inherits="Searchpage" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script type="text/javascript">
$(document).ready(function() {
	//Tooltips
	$(".tip_trigger").hover(function(){
		tip = $(this).find('.tip');
		tip.show(); //Show tooltip
	}, function() {
		tip.hide(); //Hide tooltip		  
	}).mousemove(function(e) {
		var mousex = e.pageX + 20; //Get X coodrinates
		var mousey = e.pageY + 20; //Get Y coordinates
		var tipWidth = tip.width(); //Find width of tooltip
		var tipHeight = tip.height(); //Find height of tooltip
		
		//Distance of element from the right edge of viewport
		var tipVisX = $(window).width() - (mousex + tipWidth);
		//Distance of element from the bottom of viewport
		var tipVisY = $(window).height() - (mousey + tipHeight);
		  
		if ( tipVisX < 20 ) { //If tooltip exceeds the X coordinate of viewport
			mousex = e.pageX - tipWidth - 20;
		} if ( tipVisY < 20 ) { //If tooltip exceeds the Y coordinate of viewport
			mousey = e.pageY - tipHeight - 20;
		} 
		tip.css({  top: mousey, left: mousex });
	});
});

</script>
<link href="css/ajax.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="main1" style="top: auto">            

			
			<br /><br />
				<h2 class="inner">Search Resilts</h2>
				<table width="100%"  >
				<tr>
				    <td><span style="font-size:medium ; font-style:normal ;  "  >Advance Search</span></td>
				    <td><asp:TextBox ID="txtsearch" runat="server" CssClass="roundedleft1"   ></asp:TextBox><asp:Button ID="btnsearch" runat="server" Text ="search" Class="roundedright1"   
                             onclick="btnsearch_Click"  /></td>
                    <td><asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal"  Width="189px" >
                        <asp:ListItem Value="2" Selected="True"  >Image</asp:ListItem>
                         <asp:ListItem Value="3">Video</asp:ListItem>
                         <asp:ListItem Value="4">Audio</asp:ListItem>
                            </asp:RadioButtonList></td>
				</tr>
				</table>
			    
    <br />
				<!-- portfolio bits -->
				<asp:Label ID="lblMsg" runat="server" CssClass="ErrorClass" ></asp:Label>
				<div class="bits">
				<asp:Repeater ID="rptproduct" runat="server" > 
					<ItemTemplate >	
					<div class="bit">
						<h4><%# Eval("Name") %></h4>
						<div class="photo">
							<a href="Productdetails.aspx?sid=<%# Eval("ProductID") %>" class ="tip_trigger" ><img src="Admin/upload/product/<%# Eval("Image") %>" alt="Thumb" height="115" width="203" /><span class="tip" ><img src="Admin/upload/product/<%# Eval("Image") %>" height="250" alt="" /></span></a>
						</div>
						<p> <%# Eval("Description") %> </p>
						<p class="more"><a href="#">Read More</a></p>
						
					</div>
					</ItemTemplate>
					
					<FooterTemplate> 
					<div class="clear"></div>
					</FooterTemplate>
					</asp:Repeater>
				<%--<%=bindsub  %>--%>
				<%--	<div class="bit">
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
					
					<div class="bit">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p3"><img src="images/thumb2.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="bit last">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p4"><img src="images/thumb3.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="line"></div>
					<div class="bit">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p5"><img src="images/thumb1.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="bit">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p6"><img src="images/thumb2.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="bit">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p7"><img src="images/thumb2.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="bit last">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p8"><img src="images/thumb3.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="line"></div>
					
					<div class="bit">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p9"><img src="images/thumb1.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="bit">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p10"><img src="images/thumb2.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="bit">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p11"><img src="images/thumb2.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>
					
					<div class="bit last">
						<h4>Client Name</h4>
						<div class="photo">
							<a href="#p12"><img src="images/thumb3.png" alt="Thumb" /></a>
						</div>
						<p>Aliquam erat volutpat. Donec a sem consequat tortor posuere dignissim sit amet at ipsum.</p>
						
					</div>--%>
					
					<div class="clear"></div>
				</div>
				<!-- /portfolio bits -->
					 
		
			<!-- /main -->
			</div>
</asp:Content>

