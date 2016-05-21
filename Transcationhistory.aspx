<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Transcationhistory.aspx.cs" Inherits="Transcationhistory" Title="Untitled Page" %>
<%@ Register TagName ="usercontrol" TagPrefix ="uc" Src="~/newsuc.ascx"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="bg">
<div id="main" style="min-height:550px; margin-top:20px;  " >
    <h2>Transcation History</h2>
<asp:Repeater ID="rptorder" runat="server" >
<HeaderTemplate>
<table id="product-table" width="100%" cellspacing="0"  >
                    
                    <tr>
                    <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Image</a> </th>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Date</a> 
                        </th>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Package Name</a> 
                        </th>
                        
                        
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Credit</a>
                        </th>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Price</a>
                        </th>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Transcation No.</a>
                        </th>
                        
                        
                    </tr>
            </HeaderTemplate>
<ItemTemplate >
    <tr>
        <td><img src='Admin/upload/package/<%# Eval("image") %>' height="50" width="50" /></td>
        <td><%# Eval("dd")  %></td>
        <td><%# Eval("name")  %></td>
        <td><%# Eval("credit")  %></td>
        <td><%# Eval("price")  %></td>
        <td><%# Eval("TranscationID")%></td>
        
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

