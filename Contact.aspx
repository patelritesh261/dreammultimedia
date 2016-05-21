<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script type="text/javascript">
    var map = null;
    var geocoder = null;
    var message = null;

    function initialize() {

        message = '<%=desc %>';
        if (GBrowserIsCompatible()) {
            map = new GMap2(document.getElementById("map_canvas"));
            map.addControl(new GLargeMapControl());
            map.addControl(new GMapTypeControl());
            geocoder = new GClientGeocoder();


            function showAddress(address) {
                geocoder.getLatLng(
address,
function(point) {
                    if (!point) {
                        alert(address + " not found");
                    }

                    else {
                        map.setCenter(point, 13);
                        var marker = new GMarker(point);
                        map.addOverlay(marker);
                        marker.openInfoWindowHtml("<%=address %>");
                    }

                }

);

            }
            //           GEvent.addListener("click",showAddress('<%=desc %>'));
            map.addOverlay(showAddress('<%=desc %>'));



        }
    }
    </script>  
<script src="http://maps.google.com/maps?file=api&v=2&key=" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="main1"   >
  <div id="im">
  
				<h2 class="inner">Contact Us</h2><br />
				<asp:Label ID="lblMsg" runat="server" CssClass="ErrorClass" ></asp:Label><br />
				<div class="imgp">
				<table>
				    <tr>
				        <td><span style="font-size:large;"   > Name:</span></td>
				        <td><asp:TextBox ID="txtname" runat="server" CssClass="txtbox" 
                                ForeColor="#99FFCC"  ></asp:TextBox> </td>
				    </tr>
				    <tr><td>&nbsp;</td></tr>
				    <tr>
				        <td><span style="font-size:large;"   >E-mail Address:</span></td>
				        <td><asp:TextBox ID="txtemail" runat="server" CssClass="txtbox" ></asp:TextBox> </td>
				    </tr>
				    <tr><td>&nbsp;</td></tr>
				     <tr>
				        <td><span style="font-size:large;"   >Contact Number:</span></td>
				        <td><asp:TextBox ID="txtpno" runat="server" CssClass="txtbox" ></asp:TextBox> </td>
				    </tr>
				    <tr><td>&nbsp;</td></tr>
				    <tr>
				        <td><span style="font-size:large;"   >Message:</span></td>
				        <td><asp:TextBox ID="txtmsg" runat="server" TextMode="MultiLine" CssClass="txtbox" 
                                Height="87px"  ></asp:TextBox> </td>
				    </tr>
				    <tr><td>&nbsp;</td></tr>
				    <tr>
				        
				        <td><asp:Button  ID="btnsubmit" runat="server" CssClass="btn-submit" 
                                onclick="btnsubmit_Click"  /> </td>
				    </tr>
				
				</table> 
				</div> 
				<div class="pdright" style="margin:0 0 0 600px;  "  >
				<div id="map_canvas" class="mapbox" style="width: 400px; height: 400px; position: relative; border:6px solid #ddd;    background-color: rgb(229, 227, 223);"></div>	
				
			</div>
			</div> 
</div> 
</asp:Content>

