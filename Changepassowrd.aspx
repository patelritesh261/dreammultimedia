<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Changepassowrd.aspx.cs" Inherits="Changepassowrd" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="main" style="min-height:500px; margin-top:20px;"   >
    <h2>Change Password</h2>
    <asp:Panel ID="panal6" runat="server" DefaultButton="btnsubmit"  >
    <table >
        <tr>
            <td><span style ="Color:Red ">*</span>
                Old Password:
            </td>
            <td><asp:TextBox ID="txtoldpass" runat="server" TextMode="Password"   ></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvoldpass" runat="server" ControlToValidate="txtoldpass" Display="None" ErrorMessage="Please Fill Up Field" ></asp:RequiredFieldValidator>   
                 <cc1:ValidatorCalloutExtender ID="vce1" runat="server"   TargetControlID="rfvoldpass"></cc1:ValidatorCalloutExtender>  </td>
         </tr>
         <tr><td class="style1">&nbsp;</td></tr>
         <tr>
         <td class="style1"><span style ="Color:Red ">*</span>New Password:</td>
<td><asp:textbox ID ="txtpassword" runat = "server"  TextMode ="Password"  class="inp-form" />
<asp:RequiredFieldValidator ID ="rfvpassword" runat ="server" ControlToValidate ="txtpassword" ValidationGroup="btnsubmit" ErrorMessage ="please fill password" Display ="None" BackColor ="yellow"/>
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender3" runat="server"  TargetControlID="rfvpassword"></cc1:ValidatorCalloutExtender> 
<asp:CustomValidator ID="cstpassword" runat ="server"  SetFocusOnError ="true" ValidationGroup="btnsubmit" ClientValidationFunction ="validateLength" Display="None" ErrorMessage ="password at least 6 characters" ControlToValidate ="txtpassword"/>
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender4" runat="server"  TargetControlID="cstpassword"></cc1:ValidatorCalloutExtender> 
</td>
</tr>
<tr><td class="style1">&nbsp;</td></tr>
<tr>
<td class="style1"><span style ="Color:Red ">*</span>Re-Enter New Password:</td>
<td><asp:textbox ID ="txtrepassword" runat = "server"  TextMode ="Password"  class="inp-form" />
<asp:RequiredFieldValidator ID ="rfxrepassword" runat ="server" ValidationGroup="btnsubmit" ControlToValidate ="txtrepassword" ErrorMessage ="please fill re-password" Display ="None" BackColor ="yellow"/>
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender5" runat="server"  TargetControlID="rfxrepassword"></cc1:ValidatorCalloutExtender> 
<asp:CompareValidator ID ="cmppassword" runat ="server" ControlToCompare ="txtpassword" ValidationGroup="btnsubmit" ControlToValidate ="txtrepassword" Display="None"  ErrorMessage ="password and Re-password are not matched" SetFocusOnError ="true"  />
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender6" runat="server"  TargetControlID="cmppassword"></cc1:ValidatorCalloutExtender> </td>

</tr>
<tr><td class="style1">&nbsp;</td></tr>
<tr>
<td class="style1"><asp:Button ID="btnsubmit" runat ="server" Text=""  ValidationGroup="btnsubmit" CssClass="btn-submit"
        onclick="btnsubmit_Click"/></td>
</tr>
    </table>
    </asp:Panel> 
</div>
</asp:Content>

