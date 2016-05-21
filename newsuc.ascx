<%@ Control Language="C#" AutoEventWireup="true" CodeFile="newsuc.ascx.cs" Inherits="newsuc" %>
<div id="side">
            
				<h4>Latest News</h4>
				<div class="newss">
				    <asp:Repeater ID="rptnews" runat="server" onitemcommand="rptnews_ItemCommand" >
				    <HeaderTemplate><table ></HeaderTemplate> 
				    <ItemTemplate>
				    <tr>
				        <td><h5>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument ='<%# Eval("NewsID") %>' CommandName="linktitle"  ><%# Eval("Title") %></asp:LinkButton></h5></td>
				    </tr>
				    <tr>
				        <td><p><%# Eval("SDescription")  %></p></td>
				    </tr>
				    </ItemTemplate> 
				    <FooterTemplate></table></FooterTemplate> 
				    </asp:Repeater>
				    <asp:LinkButton ID="lkbtn" runat="server" PostBackUrl="~/Newslist.aspx" >View All</asp:LinkButton> 
				</div> 
				<%--<div class="news">
					<h5><a href="#">News title</a></h5>
					<p>Nunc commodo euismod massa quis vestibulum, proin mi nibh, dignissim.</p>
				</div>
				
				<div class="news">
					<h5><a href="#">News title</a></h5>
					<p>Nunc commodo euismod massa quis vestibulum, proin mi nibh, dignissim.</p>
				</div>
				
				<div class="news">
					<h5><a href="#">News title</a></h5>
					<p>Nunc commodo euismod massa quis vestibulum, proin mi nibh, dignissim.</p>
				</div>--%>
				
				<div id="quote">
					<h4>Request a Free Quote</h4>
					<p>Phasellus diam sapien, fermentum a eleifend non, luctus non augue.</p>
				</div>
            </div>