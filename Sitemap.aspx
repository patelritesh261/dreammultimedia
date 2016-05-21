<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Sitemap.aspx.cs" Inherits="Sitemap" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main1" style="min-height:580px;"  >
				<div class="wrap">
				<h2>Site Map</h2> <hr /><br />
		<div class="fo1"  style="border:2px solid black; padding:5px; "  >
		<h2 style="border-bottom :2px solid black; padding:0px; color:Black;  " >File Type</h2>
		<ul type="none" >
		    
		    <li><a id="footer-photos" href="Category.aspx?id=2">Photos</a></li>
		    
		    <li><a id="footer-video" href="Category.aspx?id=3">Video</a></li>
		    <li><a id="footer-audio" href="Category.aspx?id=4">Audio</a></li>
		   
		</ul>
		</div>
		<div class="fo1" style="margin-left:520px; height: 107px;border:2px solid black; padding:5px; ">
		     <h2 style="border-bottom :2px solid black; padding:0px; color:Black;">Need Help?</h2>
		     <ul type="none">
		        
		        <li><a  href="FAQ.aspx">FAQ</a></li>
		        
		        
		        <li><a  href="Contact.aspx">Contact Us</a></li>
		       </ul>
		      </div>
		      <div class="fo1" style="margin-left:350px; margin-right:400px;border:2px solid black; padding:5px; "  >
		<h2 style="border-bottom :2px solid black; padding:0px; color:Black;">Learn More</h2>
		<ul type="none">
		    <li><a id="footer-buy-with-credits" href="Packagesub.aspx">Buy With Credits</a></li>
		    
		        
		        <li><a id="footer-sell-stock" href="Topsell.aspx">Sell Stock</a></li>
		       
		</ul>
		</div>
		<div class="fo1" style="border:2px solid black; padding:5px;  ">
		    <h2 style="border-bottom :2px solid black; padding:0px; color:Black;">Company Info</h2>
		    <ul type="none">
		        <li><a  href="Aboutus.aspx">About Us</a></li>
		        <li><a  href="" href="Sitemap.aspx"  >Site Map</a></li>
		        
		       
		     </ul>
		     </div>
		<div class="fo1" style="margin-left:520px; padding-bottom:40px; height: 70px; border:2px solid black; padding:5px; " >
		<h2 style="border-bottom :2px solid black; padding:0px; color:Black;">Participate</h2>
		<ul type="none">
		    <li><a id="footer-articles" href="Privacy.aspx" >Privacy</a></li>
		    
		    
		    <li><a id="footer-design-spotlight" href="Term_of_use.aspx">Term Of Use</a></li>
		  
		    
		    </ul>
		    </div>
		
	
		     
        </div>
        </div> 
</asp:Content>

