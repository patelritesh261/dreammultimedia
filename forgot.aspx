<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="forgot.aspx.cs" Inherits="forgot" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="main" style="margin-top:20px; min-height:500px;"   >
<h2 class="inner">Forgot Password</h2>
<asp:Panel ID="panal5" runat="server" DefaultButton="btnsubmit">  
<table>                   		
<tr><td>&nbsp;</td></tr>
<tr>
<td><span style ="Color:Red ">*</span>Email Address</td>
<td><asp:textbox ID ="txtemail" runat = "server"  class="inp-form" 
         /></td>
<td><asp:RequiredFieldValidator ID ="rfvusername" runat ="server" ControlToValidate ="txtemail" ErrorMessage ="please fill Email" Display ="Dynamic" />   </td>             
</tr>
<tr>
<td><asp:Button ID="btnsubmit" runat ="server" Text="" CssClass ="btn-submit" 
        onclick="btnsubmit_Click"/></td>
</tr>
</table>
</asp:Panel>
</div> 
</asp:Content>

