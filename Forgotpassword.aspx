<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Forgotpassword.aspx.cs" Inherits="Forgotpassword" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <!-- main -->
<div id="main" style="margin-top:20px; min-height:500px;"   >
<br />
<h2 class="inner">Forgot Password</h2>
<div id="table-content">
	
		
      
 <table>                   		
<tr><td>&nbsp;</td></tr>
<tr>
<td>Hint Question</td>
<td><asp:DropDownList ID="ddlhint" runat="server" ></asp:DropDownList> </td>
</tr>
<tr><td>&nbsp;</td></tr>
<tr>
<td>Answer</td>
<td><asp:TextBox ID="txtans" runat="server" ></asp:TextBox> </td>
</tr>
<tr><td><asp:Label ID="lblfpassword" runat="server" Text="" ></asp:Label> </td></tr>
<tr>
<td><asp:Button ID="btnsubmit" runat ="server" Text="" CssClass="btn-submit"
        onclick="btnsubmit_Click"/></td>
</tr>
					</table> 
					</div>
				
			</div>
			<!-- /main -->
</asp:Content>

