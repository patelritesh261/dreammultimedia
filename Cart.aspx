<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 131px;


        }
        .style2
        {
            width: 449px;
        }
        .style3
        {
            width: 236px;
        }
        .style4
        {
            width: 537px;
        }
        .style5
        {
            width: 122px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main1">
    <div class="brbotom">
        <h2>Shoping Cart</h2>
    </div> <br /><br />
   
    
     <asp:Label ID="lblMsg" runat="server" CssClass="ErrorClass" ></asp:Label>
     <asp:Panel ID="panal" runat="server" DefaultButton="btnchkout">
        <div id="cartitem">
    <asp:Repeater ID="rptcart" runat="server" onitemcommand="rptcart_ItemCommand" > 
    <HeaderTemplate >
        <table id="product-table" width="100%" cellspacing="0"  style="margin-bottom:0px;"   >
                    
                    <tr>
                    <th class="table-header-repeat line-left minwidth-1" width="20%"><a href="">
                            Image</a> </th>
                        <th class="table-header-repeat line-left minwidth-1" colspan="1"  width="55%"><a href="">
                            Product Details</a> 
                        </th>
                        <th class="table-header-repeat line-left minwidth-1"  ><a href="">
                            Credit</a> 
                        </th>
                        
                        
                        <th class="table-header-repeat line-left minwidth-1"  ><a href="">
                            Action</a>
                        </th>
                        
                        
                        
                    </tr>
        
    </HeaderTemplate>
    <ItemTemplate > 

        
            <tr  >
            
              <td class="style1"> <img src="Admin/upload/product/<%# Eval("image") %>" height="100" width="150"  style="margin-left:5px;"  /> </td> 
           
            
              <td class="style4">
                    <table width="100%"  >
                        <tr>
                            <td>
                                <p>Category Name:<%# Eval("cname") %></p>
                                <p>Product Name:<%# Eval("pdname")  %></p>
                                <p>Product Code:<%# Eval("pcode") %></p>
                             </td>
                             <td>
                                 <p>Parameter Name:<%# Eval("prname") %></p>
                                <p>Resolution:<%# Eval("res") %></p>
                                <p>Size:<%# Eval("size") %></p>
                             </td>
                        </tr>
                    </table> 
                     
                   
              </td> 
            
            
                <td class="style5"><%# Eval("credit") %></td>
            
            
                <td >
                       <%-- <asp:Button ID="btndelete" runat="server" Text="delete"  ToolTip="Delete" 
                CssClass="form-deletecart" Height="100px" Width="100px"  OnClientClick="return window.confirm('Do you really want to delete this record ?')" />--%>
                <span   > <asp:ImageButton  ID="lbtndelete" runat="server" Text="Delete" ToolTip="Delete" CommandName="DeleteData" CommandArgument='<%# Eval("id") %>' style="background-color:#e3f3f3;"   OnClientClick="return window.confirm('Do you really want to delete this record ?')" ImageUrl="~/images/form/action_delete.gif" Height="24" Width="24"  /> </span> 
              
                </td>
             
            </tr>
           
        
       <%-- <div class="cbit">
            <img src="Admin/upload/product/<%# Eval("image") %>" height="230" width="230" /> 
        </div> 
        <div class="cbit">
            <br /><br />
            <p>Category Name:<%# Eval("cname") %></p>
            <p>Product Name:<%# Eval("pdname")  %></p>
            <p>Product Code:<%# Eval("pcode") %></p>
        </div> 
        
        <div class="cbit">
            <br /><br />
            <p>Parameter Name:<%# Eval("prname") %></p><br /><br />
            <p>Resolution:<%# Eval("res") %></p><br /><br />
            <p>Size:<%# Eval("size") %></p>
        </div>
        
        <div class="cbit3">
                <div class="cbtn" >
            <asp:Button ID="btnedit" runat="server" Text="edit" CssClass="form-editcart" ToolTip="Edit"  
                Height="100px" Width="100px" 
                  />&nbsp;
            <asp:Button ID="brndelete" runat="server" Text="delete"  ToolTip="Delete" 
                CssClass="form-deletecart" Height="100px" Width="100px"  OnClientClick="return window.confirm('Do you really want to delete this record ?')" />     
                </div>
                <div class="cbit2 " >
            <h3>Credit:<%# Eval("credit") %></h3>
        </div> 
        </div> --%>
   
    </ItemTemplate>
    <FooterTemplate >
        </table>
    </FooterTemplate>

    </asp:Repeater>
   
</div>
 <div class="cartitemm"  id="totaldiv" runat="server"    >
        <div  >
       <table width="100%"  >
       <tr>
       <td width="75%" colspan="3"  align="right"  ><span style="font-size:larger; font-weight:bold ;"    >Total Credits:</span></td>
       <td width="25%" colspan="1" style="padding-left:10px;"   ><span style="font-size:larger; font-weight:bold ;" ><asp:Label ID="lbltotals" runat="server" ></asp:Label>  </span></td>
       </tr>
       </table>
        </div>
    </div>
    <asp:Button ID="btncshoping" runat="server" Text="" CssClass="btn-continue-shop" PostBackUrl="~/Default.aspx"    />
    <asp:Button ID="btnclearall" runat="server" Text="" 
        onclick="btnclearall_Click"  CssClass="btn-clearall" />
    <asp:Button ID="btnchkout" runat="server" Text="" CssClass="btn-proced-to-pay"
        onclick="btnchkout_Click" />    
        </asp:Panel>   
</div> 
</asp:Content>

