<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Orderconfirmation.aspx.cs" Inherits="Orderconfirmation" Title="Untitled Page" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main1">
    <div class="brbotom">
        <h2>Order Details</h2>
    </div> <br /><br />
    
    
    <%-- <p><asp:Label ID="lblerror" runat="server" Text="" Visible="false"  ></asp:Label>  </p>--%>
     <asp:Label ID="lblerror" runat="server" CssClass="ErrorClass" ></asp:Label>
      <asp:Panel ID="panal5" runat="server" DefaultButton="btnconfirm"> 
        <div id="cartitem"   >
 
   
        <%--<asp:Label ID="lblAction" runat="server" Text="Action" ></asp:Label>--%>
    <asp:Repeater ID="rptcart" runat="server"  > 
    <HeaderTemplate >
    <table id="product-table" width="100%" cellspacing="0"  style="margin-bottom:0px;"   >
                    
                    <tr>
                    <th class="table-header-repeat line-left minwidth-1" width="25%" ><a href="">
                            Image</a> </th>
                        <th class="table-header-repeat line-left minwidth-1" colspan="1" width="65%" ><a href="">
                            Product Details</a> 
                        </th>
                        <th class="table-header-repeat line-left minwidth-1" width="10%"><a href="">
                            Credit</a> 
                        </th>
                        
                   </tr>      
                        
        
    </HeaderTemplate>
    <ItemTemplate > 

        
            <tr  >
            
              <td class="style1"> <img src="Admin/upload/product/<%# Eval("image") %>" height="100" width="150"  style="margin-left:20px;"  /> </td> 
           
            
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
 <div class="cartitemm" id="totaldiv" runat="server"  >
        <div  >
       <table width="100%"  >
       <tr>
       
       <td width="89%"  align="right"   ><span style="font-size:larger; font-weight:bold;"   > Total Credits:</span></td>
       <td width="11%"  align="left"   >&nbsp;&nbsp;<span style="font-size:larger; font-weight:bold;    "   ><asp:Label ID="lbltotals" runat="server" ></asp:Label></span>  </td>
       </tr>
       </table>
        </div>
    </div>
    <div style="margin:0 0 0 965px;"  >
     <asp:Button ID="btnconfirm" runat="server" Text="" CssClass="btn-buynow"
        onclick="btnconfirm_Click" /> 
      </div>  
</asp:Panel>  
</div> 
</asp:Content>

