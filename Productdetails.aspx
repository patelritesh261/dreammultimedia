<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Productdetails.aspx.cs" Inherits="Productdetails" Title="Untitled Page" %>

<%@ Register Assembly="ASPNetAudio.NET2" Namespace="ASPNetAudio" TagPrefix="ASPNetAudio" %>

<%@ Register Assembly="ASPNetFlashVideo.NET3" Namespace="ASPNetFlashVideo" TagPrefix="ASPNetFlashVideo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="test/js/jquery.jqzoom.css" rel="stylesheet" type="text/css" />

    <script src="test/js/jquery.jqzoom-core.js" type="text/javascript"></script>
<script type="text/javascript">

$(document).ready(function() {
	$('.jqzoom').jqzoom({
            zoomType: 'reverse',
            lens:true,
            preloadImages: false,
            alwaysOn:false
        });
	//$('.jqzoom').jqzoom();
});


</script>
<script type="text/javascript">
    $(document).ready(function() {
        //Tooltips
        $(".tip_trigger").hover(function() {
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

            if (tipVisX < 20) { //If tooltip exceeds the X coordinate of viewport
                mousex = e.pageX - tipWidth - 20;
            } if (tipVisY < 20) { //If tooltip exceeds the Y coordinate of viewport
                mousey = e.pageY - tipHeight - 20;
            }
            tip.css({ top: mousey, left: mousex });
        });
    });

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main1">
<asp:Label ID="lblMsg" runat="server" CssClass="ErrorClass" Width="926px" ></asp:Label>
    <div id="im">
        <div class="inner">
        <table width="95%" >
            <tr>
                <%--<td width="40%"><h2>Product Details</h2></td>--%>
                <td> <table id="product-table" width="100%" cellspacing="0" 
            style="margin-bottom :0px; height: 33px;"    >
                    
                    <tr>
                    <th class="table-header-repeat line-left minwidth-1" colspan="2"  ><a href="">
                             Product Details </a> </th>
                    <th class="table-header-repeat line-left minwidth-1" colspan="2"  ><a href="">
                             <asp:Label ID="lbliname" runat="server" Text=""  ></asp:Label> </a> </th>
                        <th class="table-header-repeat line-left minwidth-1" colspan="2" ><a href="">
                             categoty name:&nbsp;&nbsp;<asp:Label ID="lblcname" runat="server" Text=""></asp:Label></a></th>
                       <th class="table-header-repeat line-left minwidth-1" colspan="2" ><a href="">
                             Product Code:&nbsp;&nbsp;<asp:Label ID="lblpdcode" runat="server" Text=""  ></asp:Label></a></th>
                    
                     
                     </tr>
       
        </table></td>
            </tr>
        </table> 
        
       
        <asp:Label ID="lblerror" runat="server" Visible="false" Text="" ></asp:Label>
       
         </div> 
         <!-----photoshow--------->
    <div class="imgp" id="image" runat="server"   >
     <a href="Admin/upload/orignal/" class="jqzoom" rel='gal1'  title="Show"  id="aimg" runat="server"  >
        <img src="Admin/upload/product/" id="imgpd" runat="server"   height="256" width="341"  /> </a> 
    </div>
    <div class="imgp" id="video" runat="server"   >
        <ASPNetFlashVideo:FlashVideo ID="flashvideo" runat="server" AutoPlay="false" Height="350" Width="350"   VideoURL="~/Admin/upload/orignal/"   >
        </ASPNetFlashVideo:FlashVideo>
    </div> 
    <div class="imgp" id="audio" runat="server"   >
    <img src="Admin/upload/product/" id="img1" runat="server"   height="350" width="350"  />
        <ASPNetAudio:Audio ID="audio1" runat="server"  AudioURL="~/Admin/upload/orignal/"  >
        </ASPNetAudio:Audio>
    </div> 
    <div class="imgp">
       
    </div>
    <div class="pdright" >
    <div id="tblformat">
        
        <%--<p> </p>
        
        <div class="brbotom ">
        <p >&nbsp;&nbsp;&nbsp;&nbsp;</p>
        </div> --%><%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate >--%>
            <asp:Repeater ID="rptpdetails" runat="server"  >
        <HeaderTemplate >
        <table id="product-table" width="100%" cellspacing="0"  style="margin-bottom:0px;"   >
                    
                    <tr>
                    <th class="table-header-repeat line-left minwidth-1" colspan="2" ><a href="">
                            Parameter Name</a> </th>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Resolution</a> 
                        </th>
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Size</a> 
                        </th>
                        
                        
                        <th class="table-header-repeat line-left minwidth-1"><a href="">
                            Credit</a>
                        </th>
                        
                        
                    </tr>
            </HeaderTemplate>
        
        <ItemTemplate >
        <tr>
            <td  colspan="2" ><asp:RadioButton id="rbtnpd" runat="server" AutoPostBack="true"    ToolTip='<%# Eval("PPID") %>'   oncheckedchanged="rbtnpd_CheckedChanged" TextAlign="Right" /><%--</td>
              <td align="left">--%>&nbsp;&nbsp;<%# Eval("prname")  %>
             </td>
             
            <td><%# Eval("res")  %></td>
            <td><%# Eval("size")  %></td>
            <td><%# Eval("credit")  %></td>
        </tr>
        </ItemTemplate>
        <FooterTemplate >
        </table> 
        </FooterTemplate>
        </asp:Repeater>
        
        <%--</ContentTemplate>
        </asp:UpdatePanel>--%>
        
         
    </div>
    <div class="addcartbtn"  >
        <span style="font-size:large; font-weight:bolder ; padding:0 0 0 40px; "     > Total:</span><span  style="font-size:large; font-weight:bolder ; padding:0 0 0 10px;" > <asp:Label ID="lbltotal" runat="server" Text="0"></asp:Label></span>   
        <asp:Button ID="btnaddcart" runat="server"  Text=""  
            CssClass="addto-cart" ToolTip="Add To Cart"  onclick="btnaddcart_Click" 
            Width="141px"   />
    </div>
    </div>
    </div>
   
    <div id="releted">
    
    <h2>Related &nbsp;<asp:Label ID="lblrelated" runat="server" ></asp:Label></h2>
    
    <div id="bits">
    <asp:Repeater ID="rptreleted" runat="server" > 
    <ItemTemplate >
    <div class="rbit">
						<h3><%# Eval("Name")  %></h3>
						<div class="photo">
						    <a href="Productdetails.aspx?sid=<%# Eval("ProductID") %>" class ="tip_trigger" ><img src="Admin/upload/product/<%# Eval("Image") %>" alt="Thumb" height="115" width="203" /><span class="tip" ><img src="Admin/upload/product/<%# Eval("Image") %>" height="250" alt="" /></span></a>
							<%--<a href="Productdetails.aspx?sid=<%# Eval("ProductID") %>" ><img src="Admin/upload/product/<%# Eval("Image") %>" alt="No Image" height="70" width="203" /></a>--%>
						</div>
						
    </div>
    </ItemTemplate>
    </asp:Repeater>
       
     <%--<div class="rbit">
						<h4>Methods</h4>
						<div class="photo">
							<a href="Category.aspx?id=" ><img src="images/thumb1.png" alt="Thumb" /></a>
						</div>
						
    </div>  
     <div class="rbit">
						<h4>Methods</h4>
						<div class="photo">
							<a href="Category.aspx?id=" ><img src="images/thumb1.png" alt="Thumb" /></a>
						</div>
						
    </div>   <div class="rbit">
						<h4>Methods</h4>
						<div class="photo">
							<a href="Category.aspx?id=" ><img src="images/thumb1.png" alt="Thumb" /></a>
						</div>
						
    </div>   <div class="rbit">
						<h4>Methods</h4>
						<div class="photo">
							<a href="Category.aspx?id=" ><img src="images/thumb1.png" alt="Thumb" /></a>
						</div>
						
    </div>   <div class="rbit">
						<h4>Methods</h4>
						<div class="photo">
							<a href="Category.aspx?id=" ><img src="images/thumb1.png" alt="Thumb" /></a>
						</div>
						
    </div>   <div class="rbit">
						<h4>Methods</h4>
						<div class="photo">
							<a href="Category.aspx?id=" ><img src="images/thumb1.png" alt="Thumb" /></a>
						</div>
						
    </div>   <div class="rbit">
						<h4>Methods</h4>
						<div class="photo">
							<a href="Category.aspx?id=" ><img src="images/thumb1.png" alt="Thumb" /></a>
						</div>
						
    </div>  --%>
    </div> 
    
    </div>
</div>
</asp:Content>

