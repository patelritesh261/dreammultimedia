<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Globalseting.aspx.cs" Inherits="Globalseting" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="main1">
<h2>Global Setting</h2>
<table>
<tr>
<td>Site Name:</td>
<td><asp:TextBox ID ="txt1" runat="server" /></td>
<td><asp:RequiredFieldValidator ID="rfv1" runat ="server" ControlToValidate ="txt1" /></td>
</tr> 
<tr><td>&nbsp;</td></tr> 
<tr>
<td>Site Url:</td>
<td><asp:TextBox ID ="TextBox1" runat="server" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat ="server" ControlToValidate ="TextBox1" /></td>
</tr>
<tr><td>&nbsp;</td></tr>  
<tr>
<td>Display Url:</td>
<td><asp:TextBox ID ="TextBox2" runat="server" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat ="server" ControlToValidate ="TextBox2" /></td>
</tr> 
<tr><td>&nbsp;</td></tr> 
<tr>
<td>Email:</td>
<td><asp:TextBox ID ="TextBox3" runat="server" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat ="server" ControlToValidate ="TextBox3" /></td>
</tr>
<tr><td>&nbsp;</td></tr>  
<tr>
<td>Password:</td>
<td><asp:TextBox ID ="TextBox4" runat="server" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat ="server" ControlToValidate ="TextBox4" /></td>
</tr>
<tr><td>&nbsp;</td></tr>  
<tr>
<td>Info Email:</td>
<td><asp:TextBox ID ="TextBox5" runat="server" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat ="server" ControlToValidate ="TextBox5" /></td>
</tr>
<tr><td>&nbsp;</td></tr>  
<tr>
<td>Map Address:</td>
<td><asp:TextBox ID ="TextBox6" runat="server" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat ="server" ControlToValidate ="TextBox6" /></td>
</tr>
<tr><td>&nbsp;</td></tr>  
<tr>
<td>Address:</td>
<td><asp:TextBox ID ="TextBox7" runat="server" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat ="server" ControlToValidate ="TextBox7" /></td>
</tr>
<tr><td>&nbsp;</td></tr>  
<tr>
<td>Host Name:</td>
<td><asp:TextBox ID ="TextBox8" runat="server" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat ="server" ControlToValidate ="TextBox8" /></td>
</tr> 
<tr><td>&nbsp;</td></tr> 
<tr>
<td>Footertext:</td>
<td><asp:TextBox ID ="TextBox9" runat="server" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat ="server" ControlToValidate ="TextBox9" /></td>
</tr>
<tr><td>&nbsp;</td></tr> 
<tr>
<td>PayPal Address:</td>
<td><asp:TextBox ID ="TextBox10" runat="server" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat ="server" ControlToValidate ="TextBox10" /></td>
</tr>
<tr><td>&nbsp;</td></tr> 
<tr>
<td></td>
<td><asp:Button ID="btn1" runat ="server" Text ="Submit"/></td>
<td></td>
</tr> 
</table>
    
</div>
</asp:Content>

