<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Packagesub.aspx.cs" Inherits="Packagesub" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main1"  style="min-height:580px;  "  >
   <div id="releted">
    
    <h2>Packages</h2> <hr /><br />
    
    <div id="bits">
    <%--<asp:Repeater ID="rptreleted" runat="server" > 
    <ItemTemplate >
    <div class="rbit">
						<h3><%# Eval("Name")  %></h3>
						<div class="photo">
							<a href="Productdetails.aspx?sid=<%# Eval("ProductID") %>" ><img src="Admin/upload/category/<%# Eval("Image") %>" alt="No Image" height="70" width="203" /></a>
						</div>
						
    </div>
    </ItemTemplate>
    </asp:Repeater>
       --%>
     <asp:Repeater ID="rptpackage" runat="server" 
            onitemcommand="rptpackage_ItemCommand" >
     
     <ItemTemplate >
         <div class="rbit">
						<h4><%# Eval ("Name") %></h4>
						<div class="photo">
							<a href="Category.aspx?id=<%# Eval("packageID") %>" ><img src="Admin/upload/package/<%# Eval("image") %>" height ="70" width ="203" alt="Thumb" /></a>
						</div>
						<p>Credit:<%# Eval ("Credit")%></p>
						<p>Price:<%# Eval ("Price") %></p>
						<p><asp:Button ID="btnsubscribe" runat ="server" Text ="" CssClass="btn-buynow" CommandName ="Subscribepack" CommandArgument ='<%# Eval("packageID") %>'/></p>
						
    </div> 
    </ItemTemplate>
    
    
    </asp:Repeater>  
      
    </div>
    
    </div>
    <asp:LinkButton ID="linkprev" runat ="server" 
            PostBackUrl="~/Admin/Bannerrepeter.aspx"  onclick="linkprev_Click"   >Prev</asp:LinkButton>
    &nbsp;
        
        <asp:LinkButton ID="linknext" runat="server" 
            PostBackUrl ="~/Admin/Bannerrepeter.aspx"  onclick="linknext_Click" >Next</asp:LinkButton>  
</div>
</asp:Content>

