<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Topsell.aspx.cs" Inherits="Topsell" Title="Untitled Page" %>
<%@ Register TagName ="usercontrol" TagPrefix ="uc" Src="~/newsuc.ascx"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="bg">  
<div id="main" style="min-height:580px; padding-top:20px;"   >
<h2 class="inner">Top Sell</h2>
<asp:Repeater ID="rptsell" runat="server" >
<HeaderTemplate>
<table id="product-table" width="100%" cellspacing="0"  >
                    
                    <tr>
                        
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Image</a> 
                        </th>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Category Name</a>
                        </th>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Product Name</a>
                        </th>
                        <th class="table-header-repeat line-left"><a href="">
                            No. of Sell</a>
                        </th>
                        
                    </tr>
            </HeaderTemplate>
<ItemTemplate >
    <tr>
        <td><img src='Admin/upload/product/<%# Eval("image") %>' height="50" width="50" /></td>
        <td><%# Eval("Categoryname")  %></td>
        <td><%# Eval("Productname")  %></td>
        <td><%# Eval("Sell")  %></td>
    </tr>
</ItemTemplate>
<FooterTemplate>
</table>
</FooterTemplate>  
</asp:Repeater> 


</div>
<uc:usercontrol ID="Usercontrol1" runat="server" />
</div> 
</asp:Content>

