<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FAQ.aspx.cs" Inherits="FAQ" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type ="text/css" >
    .accordionHeader
{
    border: 0px solid #2F4F4F;
    color: white;
    background-color: #333333;
	font-family: Arial, Sans-Serif;
	font-size: 12px;
	font-weight: bold;
    padding: 5px;
    color:White;  
    margin-top: 5px;
    cursor: pointer;
}

#master_content .accordionHeader a
{
	color: #FFFFFF;
	background: none;
	text-decoration: none;
}

#master_content .accordionHeader a:hover
{
	background: none;
	text-decoration: underline;
}

.accordionHeaderSelected
{
    border: 1px solid #2F4F4F;
    color: white;
    background-color: #5078B3;
	font-family: Arial, Sans-Serif;
	font-size: 12px;
	font-weight: bold;
    padding: 5px;
    margin-top: 5px;
    cursor: pointer;
}

#master_content .accordionHeaderSelected a
{
	color: #FFFFFF;
	background: none;
	text-decoration: none;
}

#master_content .accordionHeaderSelected a:hover
{
	background: none;
	text-decoration: underline;
}

.accordionContent
{
    background-color: #D3DEEF;
    border: 1px dashed #2F4F4F;
    border-top: none;
    padding: 5px;
    padding-top: 10px;
}

/*AutoComplete flyout */

.autocomplete_completionListElement 
{  
	margin : 0px!important;
	background-color : inherit;
	color : windowtext;
	border : buttonshadow;
	border-width : 1px;
	border-style : solid;
	cursor : 'default';
	overflow : auto;
	height : 200px;
    text-align : left; 
    list-style-type : none;
}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <%--<cc1:ToolkitScriptManager ID="scripmanage1" runat="server">
    </cc1:ToolkitScriptManager>--%>
    <div id="main1">
    <h2 class="inner">Frequently Asked Questions</h2>
   
        <cc1:Accordion ID="Ac" runat="server" SelectedIndex="1" ContentCssClass="accordionContent" HeaderCssClass="accordionHeader">
            <Panes>
                <cc1:AccordionPane ID="ccp1" runat="server">
                    <Header>
                        1.Ways To Pay</Header>
                    <Content>
                    <h2>Purchasing Files</h2>
                    <p>To download a file on iStockphoto, you need to purchase a royalty-free license. There are several ways to purchase these licenses:</p>
                    <p><b>Prepaid Credits</b> - iStock Credits are a prepaid payment option sold in preset packages. Credits let you pay once for multiple downloads up front and download files with the click of a button.</p>
                     <p><b>Prepaid Credits:</b></p> 
                     <p>Prepaid Credits let you pay in advance for files you'll download in the future. To purchase licenses with credits, you need to sign in to your account and buy iStock credits (sold in preset packages).</p>
                     <p>Once you have credits in your account, simply go to the detailed information page for the file you wish to purchase and select the correct size and licenses before clicking "Download This File". The price in credits will be deducted from your account balance.</p>
                     <p><ol type="1" ><li>Buy Credits</li><li>Find Your Files</li><li>Download and Go</li></ol></p> 
                      <p>You can purchase Prepaid Credits using your credit card or PayPal account. You can also use our mail order form to pay with checks or money orders (in USD funds).</p> 
                       </Content>
                </cc1:AccordionPane>
                <cc1:AccordionPane ID="ccp2" runat="server">
                    <Header>
                        2.Downloading Files</Header>
                    <Content>
                       <p><b>Downloading with Prepaid Credits</b></p>
                       <p>To download files using our Prepaid Credits, you need to have credits in your account. If you don't have enough credits, you'll have to buy more credits before proceeding.</p>
                       <p>Go to the file's detailed information page to select the correct size and license type before clicking "Download This File".</p>
                       <p>You'll be prompted to accept the license agreement, which you must do before proceeding to the file download page. Once here, click "Download" for your file and retrieve it from where you've saved it.</p>
                    </Content>
                </cc1:AccordionPane>
                 <cc1:AccordionPane ID="AccordionPane1" runat="server">
                    <Header>
                        3.Re-Downloading Files</Header>
                    <Content>
                   <p>You can re-download any file you've ever purchased at any time at no additional cost, as long as the file is still available for sale.</p>
                   <p>Simply return to the file's detailed information page. The cost for the file you've purchased will show as 0. Click "Download This File" to re-download the file to your computer.</p>
                   <p>There is no time limit for re-downloading content from iStockphoto.</p>
                       
                       
                    </Content>
                </cc1:AccordionPane>
                     <cc1:AccordionPane ID="acnpane2" runat="server">
                    <Header>
                        4.Searching for Files</Header>
                    <Content>
                   <p>The easiest way to search for files on iStockphoto is by typing keywords into the search bar at the top of the site. This will take you to the search results page, where you can view thumbnails and continue on to a file's detailed information page for closer evaluation.</p>
                    
                       
                    </Content>
                </cc1:AccordionPane>
            
               <cc1:AccordionPane ID="acn" runat="server">
                    <Header>
                        5.Can't Find a File?</Header>
                    <Content>
                   <p>If your search has yielded zero results, it most likely means you're being too specific (or you're searching for something really unusual). Try removing keywords from your search, or changing some of your refinements to generate more matches.</p>   
                      
                   </Content>
                </cc1:AccordionPane>
                 <cc1:AccordionPane ID="AccordionPane2" runat="server">
                    <Header>
                        6.Updating Personal Information</Header>
                    <Content>
                   <p>To update your address or contact information, sign in to your account and click on the 'My Account' link at the bottom of the screen. Then  left side of the page click ' My Profile'.</p>   
                      
                   </Content>
                </cc1:AccordionPane>
               <cc1:AccordionPane ID="AccordionPane3" runat="server">
                    <Header>
                        8.Viewing Receipts/Download History</Header>
                    <Content>
                   <p>It is suggested you change your password every 6 months. A good password should be something memorable that doesn't include any personal information (your birthday, phone number, etc.).</p>
                   <p>To view information relating to your account activity, click on the 'My Account' link at the bottom of the screen to see a list of options. To view your receipts, click on 'Purchase History' and to view a list of the files you've downloaded, click on 'Order History'.</p>   
                      
                   </Content>
                </cc1:AccordionPane>
                <cc1:AccordionPane ID="AccordionPane4" runat="server">
                    <Header>
                        9.Viewing Credit Balance</Header>
                    <Content>
                   <p>When you sign in to your account, your remaining Prepaid Credit balance will appear at the bottom of the screen beside the word 'Package Transcation' on click .</p>
                  
                      
                   </Content>
                </cc1:AccordionPane>
               
               
                </Panes>
        </cc1:Accordion>
    </div>

</asp:Content>

