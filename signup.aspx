<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1"    %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
    <style type="text/css">
        .style1
        {
            width: 97px;
        }
        .style2
        {
            width: 109px;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- main -->
			<div id="main1">
			<br />
				<h2 class="inner">Sign Up</h2>
				<div id="table-content">
		        <asp:Panel ID="panal1" runat="server" DefaultButton="btnsubmit">  	
	    				<table>
					    <tr>
<td colspan="2" >
<h4>Fields with <span style ="Color:Red ">*</span> are Compulsary</h4></td>
</tr>

<tr><td class="style1">&nbsp;</td></tr>
<tr>
<td class="style1"><span style ="Color:Red ">*</span>First Name :</td>
<td><asp:textbox runat ="server" ID="txtfirstname" CssClass="txtbox" TabIndex="1"/>
<asp:RequiredFieldValidator ID ="rfvfirstname" runat ="server" ValidationGroup="btnsub" ControlToValidate ="txtfirstname" ErrorMessage ="please fill First Name" SetFocusOnError ="true" Display="None" BackColor ="Yellow" /></td>
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender9" runat="server" TargetControlID="rfvfirstname"></cc1:ValidatorCalloutExtender>  
<%--</tr>
<tr><td class="style1">&nbsp;</td></tr>
<tr>--%>
<td class="style2">&nbsp;</td>
<td class="style1"><span style ="Color:Red ">*</span>Last Name :</td>
<td><asp:textbox runat ="server" id="txtlastname"  CssClass="txtbox" TabIndex="1" />
<asp:RequiredFieldValidator ID ="rfvlastname" runat ="server" ValidationGroup="btnsub" ControlToValidate ="txtlastname" ErrorMessage ="please fill Last Name" SetFocusOnError ="true" Display="None" BackColor ="Yellow" /></td>
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender10" runat="server" TargetControlID="rfvlastname"></cc1:ValidatorCalloutExtender>  
</tr>
<tr><td class="style1">&nbsp;</td></tr>
<tr>
<td class="style1"><span style ="Color:Red ">*</span>Email:</td>
<td>
    <asp:textbox ID ="txtemail" runat ="server"  CssClass="txtbox" 
        AutoPostBack="true" OnTextChanged="txtemail_Changed" TabIndex="2" BackColor="White"   />
        <asp:UpdatePanel ID="upMessage" runat="Server" UpdateMode="Conditional">
      <Triggers>
         <asp:AsyncPostBackTrigger ControlID="txtemail" EventName="TextChanged" />
       </Triggers>
   <ContentTemplate>
   
       <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
    </ContentTemplate>
    
  </asp:UpdatePanel>
  <asp:UpdateProgress ID="upp" runat="server"   >
    <ProgressTemplate >
        <img src="images/form/loading11.gif" /> 
    </ProgressTemplate>
  </asp:UpdateProgress>
<asp:RequiredFieldValidator ID ="rfvemail" runat ="server" ValidationGroup="btnsub" ControlToValidate ="txtemail" ErrorMessage ="please fill valid Email Address" Display ="None" />
<cc1:ValidatorCalloutExtender ID="vceemail" runat="server" TargetControlID="rfvemail"></cc1:ValidatorCalloutExtender>  
<asp:RegularExpressionValidator ID ="rgexpremail" runat ="server" ValidationGroup="btnsub" ControlToValidate ="txtemail" Display="None" ErrorMessage ="please provide proper Email Address" ValidationExpression ="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError ="true" BackColor ="green"/> 
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" TargetControlID="rgexpremail"></cc1:ValidatorCalloutExtender>   </td>                   
<%--</tr>
<tr><td class="style1">&nbsp;</td></tr>
<tr>--%>
<td class="style2">&nbsp;</td>
<td class="style1"><span style ="Color:Red ">*</span>UserName:</td>
<td><asp:textbox ID ="txtusername" runat = "server"  CssClass="txtbox" 
        TabIndex="3" />
<asp:RequiredFieldValidator ID ="rfvusername" runat ="server" ValidationGroup="btnsub" ControlToValidate ="txtusername" ErrorMessage ="please fill username" Display ="None" BackColor ="yellow"/>
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" runat="server" TargetControlID="rfvusername"></cc1:ValidatorCalloutExtender>    </td>             
</tr>
<tr><td class="style1">&nbsp;</td></tr>
<tr>
<td class="style1"><span style ="Color:Red ">*</span>Password:</td>
<td><asp:textbox ID ="txtpassword" runat = "server"  TextMode ="Password"  
        CssClass="txtbox" TabIndex="4" />
<asp:RequiredFieldValidator ID ="rfvpassword" runat ="server" ValidationGroup="btnsub" ControlToValidate ="txtpassword" ErrorMessage ="please fill password" Display ="None" BackColor ="yellow"/>
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender3" runat="server" TargetControlID="rfvpassword"></cc1:ValidatorCalloutExtender> 
<asp:CustomValidator ID="cstpassword" runat ="server" ValidationGroup="btnsub" SetFocusOnError ="true" ClientValidationFunction ="validateLength" Display="None" ErrorMessage ="password at least 6 characters" ControlToValidate ="txtpassword"/>
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender4" runat="server" TargetControlID="cstpassword"></cc1:ValidatorCalloutExtender> 
</td>
<%--</tr>
<tr>--%>
<td class="style2">&nbsp;</td>
<td class="style1"><span style ="Color:Red ">*</span>Date Of Birth :</td>
<td><asp:TextBox ID="txtdate" runat="server"  CssClass="txtbox" TabIndex="6" ></asp:TextBox>
        <cc1:CalendarExtender ID="hhh" runat="server" TargetControlID="txtdate"></cc1:CalendarExtender></td>
        <asp:RequiredFieldValidator ID="rfvcal" runat="server" ValidationGroup="btnsub" ControlToValidate="txtdate" Display="None" ErrorMessage="Chose DOB"   ></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="vcecal" runat="server" TargetControlID="rfvcal" ></cc1:ValidatorCalloutExtender>   
</tr>
<tr><td class="style1">&nbsp;</td></tr>
<tr>
<td class="style1"><span style ="Color:Red ">*</span>RePassword:</td>
<td><asp:textbox ID ="txtrepassword" runat = "server"  TextMode ="Password"  
        CssClass="txtbox" TabIndex="5" />
<asp:RequiredFieldValidator ID ="rfxrepassword" runat ="server" ValidationGroup="btnsub" ControlToValidate ="txtrepassword" ErrorMessage ="please fill re-password" Display ="None" BackColor ="yellow"/>
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender5" runat="server" TargetControlID="rfxrepassword"></cc1:ValidatorCalloutExtender> 
<asp:CompareValidator ID ="cmppassword" runat ="server" ValidationGroup="btnsub" ControlToCompare ="txtpassword" ControlToValidate ="txtrepassword" Display="None"  ErrorMessage ="password and Re-password are not matched" SetFocusOnError ="true"  />
<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender6" runat="server" TargetControlID="cmppassword"></cc1:ValidatorCalloutExtender> </td>

<%--</tr>
<tr>--%>
<td class="style2">&nbsp;</td>
<td class="style1"><span style ="Color:Red ">*</span>Gender:</td>
<td colspan="2" >
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
        RepeatDirection="Horizontal" Width="229px" TabIndex="11">
        <asp:ListItem Value="1" Selected >Male</asp:ListItem>
        <asp:ListItem Value="2">Female</asp:ListItem>
    </asp:RadioButtonList>
</td>
</tr>
<%--<tr><td class="style1">&nbsp;</td></tr>

<tr><td class="style1">&nbsp;</td></tr>--%>

<%--<tr><td class="style1">&nbsp;</td></tr>

<tr>
<td class="style1">&nbsp;</td>
</tr>--%>
<tr><td>&nbsp;</td>
    <tr>
        <td class="style1">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            <span style="Color:Red ">*</span>Hint Question:</td>
        <td>
            <asp:DropDownList ID="ddlhint" runat="server" CssClass="txtbox">
            </asp:DropDownList>
        </td>
        <%--</tr>
<tr>--%>
        <td class="style2">
            &nbsp;</td>
        <td class="style1"><span style="Color:Red ">*</span>Contact No.</td>
        <td>
            <asp:TextBox ID="txtcno" runat="server" CssClass="txtbox" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                BackColor="yellow" ControlToValidate="txtcno" Display="None" 
                ErrorMessage="please fill Contactno" ValidationGroup="btnsub" />
            <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender11" runat="server" 
                TargetControlID="RequiredFieldValidator1">
            </cc1:ValidatorCalloutExtender>
            <asp:RegularExpressionValidator ID="revcno" runat="server" 
                ControlToValidate="txtcno" Display="None" ErrorMessage="Enter Valid Contact No" 
                ValidationExpression="^((\+)?(\d{2}[-]))?(\d{10}){1}?$" 
                ValidationGroup="btnsub"></asp:RegularExpressionValidator>
            <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender7" runat="server" 
                TargetControlID="revcno">
            </cc1:ValidatorCalloutExtender>
        </td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            <span style="Color:Red ">*</span>Answer:</td>
        <td>
            <asp:TextBox ID="txtans" runat="server" CssClass="txtbox" TabIndex="6" />
            <asp:RequiredFieldValidator ID="rfvans" runat="server" BackColor="yellow" 
                ControlToValidate="txtans" Display="None" 
                ErrorMessage="please give your hint question's answer" 
                ValidationGroup="btnsub" />
            <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender8" runat="server" 
                TargetControlID="rfvans">
            </cc1:ValidatorCalloutExtender>
        </td>
        <%--</tr>
<tr>--%>
        <td class="style2">
            &nbsp;</td>
        <td class="style1">
            Address</td>
        <td>
            <asp:TextBox ID="txtaddress" runat="server" CssClass="txtbox" TabIndex="12" 
                TextMode="MultiLine" />
        </td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
        <asp:UpdatePanel ID="update1" runat="server" >
            <ContentTemplate >
                    <asp:Button ID="btnsubmit" runat="server" CssClass="btn-register" 
                onclick="btnsubmit_Click" TabIndex="12" Text="" ToolTip="Submit" 
                ValidationGroup="btnsub" /></ContentTemplate>
         </asp:UpdatePanel> 
         <asp:UpdateProgress ID="uppp" runat="server" >
            <ProgressTemplate >
                <div >
                <img src="images/form/loading11.gif"  /> 
                </div>
            </ProgressTemplate>
         </asp:UpdateProgress>  

        </td>
    </tr>
                            </tr>
					</table> 
				</asp:Panel>
					</div>
				
			</div>
			<!-- /main -->
</asp:Content>

