<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Currentorder.aspx.cs" Inherits="Currentorder" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main1">
    <div class="brbotom">
        <h2>Order Details</h2>
    </div> <br /><br />
    <p style=" color:#0091C6; font-weight:bold; font-family:Verdana;" id="ptag" runat="server"  >
        Thank you for ordering from DREAMMULTIMEDIA.<br />
        Your payment is successfully processed.<br />
        Order Total:<asp:Label ID="lbltotalprice" ForeColor="Black" Font-Bold="true" runat="server" ></asp:Label><br />
        Please quote these details for any future correspondence.<br />
        
        </p>
    
     <p><asp:Label ID="lblerror" runat="server" Text=""  ></asp:Label>  </p>
     <asp:Panel ID="panal2" runat="server" DefaultButton ="" > 
        <div id="cartitem">
        
    <asp:Repeater ID="rptcart" runat="server" onitemcommand="rptcart_ItemCommand"  > 
    <HeaderTemplate >
    <table id="product-table" width="100%" cellspacing="0"  style="margin-bottom:0px;"   >
                    
                    <tr>
                    <th class="table-header-repeat line-left minwidth-1" width="20%"><a href="">
                            Image</a> </th>
                        <th class="table-header-repeat line-left minwidth-1" colspan="1" width="55%"><a href="">
                            Product Details</a> 
                        </th>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Credit</a> 
                        </th>
                        
                        
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Action</a>
                        </th>
                        
                        
                        
                    </tr>
        
    </HeaderTemplate>
    <ItemTemplate > 

        
            <tr  >
            
              <td class="style1"> <img src='Admin/upload/product/<%# Eval("image") %>' height="100" width="150"  style="margin-left:5px;"  /> </td> 
           
            
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
            
                <td>
                   <span     > <asp:LinkButton ID="lbtndownload" runat="server"  style="background-color:#e3f3f3; color:Blue;"   CommandName="Download" CommandArgument='<%#Eval("PPID") %>'   >Download</asp:LinkButton> </span>
                </td>
               
             
            </tr>
            <%--<tr>
                <td colspan="" class="line"></td>  
            </tr> --%>
        
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
    </asp:Panel>
 <%--<div class="cartitemm"  >
        <div  >
       <table width="100%"  >
       <tr>
       <td width="60%" colspan="3"  align="right"  ><h3>Total Credits:</h3></td>
       <td width="40%" colspan="2" ><h3><asp:Label ID="lbltotals" runat="server" ></asp:Label>  </h3></td>
       </tr>
       </table>
        </div>
    </div>--%>
      
</div> 
</asp:Content>

