<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Payment.aspx.cs" Inherits="Payment" Title="Untitled Page" %>

<script runat="server">

   
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="main1">
 <h2 class="inner">Payment Details</h2>
<table width="100%" id="TABLE1">
    <tr>
        <td >
       
            
        </td>
    </tr>
   
   <tr>
        <td>Package Name</td>
        <td><asp:TextBox ID="txtpname" runat="server"  Enabled="false" Width="225px"  ></asp:TextBox></td>
   </tr>
   <tr><td>&nbsp;</td></tr>
    <tr >
        <td  >
            <asp:Label ID="lblCamount" runat="server" Text="Package Amount">
            </asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtcamount" runat="server" 
                Width="225px" Enabled="False" EnableTheming="True"></asp:TextBox>
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr >
        <td  >
            <asp:Label ID="lbltamount" runat="server" Text="Tax Amount(8.5)">
            </asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txttamount" runat="server" Width="225px" Enabled="False"></asp:TextBox>
        </td>
    </tr>
     
     <tr><td>&nbsp;</td></tr>
    <tr >
        <td  >
            <asp:Label ID="lblnamount" runat="server" Text="Net Payable Amount">
            </asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtnamount" runat="server" Width="225px" Enabled="False"></asp:TextBox>
        </td>
    </tr>
     <tr><td>&nbsp;</td></tr>
    <tr>
        <td>
            <asp:Label ID="lblenter" runat="server" Text="Accepted Cards: Visa,MasterCard,American Express">
            </asp:Label>
        </td>
        <td>
            <asp:Image ID="icard" runat="server" ImageUrl="~/images/PayCards.gif" />
        </td>
    </tr>
     <tr><td>&nbsp;</td></tr>
    <tr>
        <td>
            <asp:Label ID="lblcdetails" runat="server" Text="Enter card details" Font-Size="Larger">
            </asp:Label>
        </td>
    </tr>
    
    <tr >
        <td  >
            <asp:Label ID="lblcnumber" runat="server" Text="Card Number" Font-Size="Small">
            </asp:Label>
        </td>
        <td >
          
            <asp:TextBox ID="txtCardno" runat="server" Height="20px" Width="225px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"
                ControlToValidate="txtCardno" ToolTip="Must enter Card number">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revcno" runat="server" ControlToValidate="txtCardno"
                ToolTip="Must enter card number" Text="*" ErrorMessage="Must enter card number"
                ValidationExpression="\d{4}-\d{4}-\d{4}-\d{4}"></asp:RegularExpressionValidator>
        </td>
        <td >
            *Enter in format (1111-1111-1111-1111)
        </td>
    </tr>
    
    <tr >
        <td >
            <asp:Label ID="lblccode" runat="server" Font-Size="Small" Text="Card Code">
            </asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtcode" runat="server" Height="20px" Width="226px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revCode" runat="server" ControlToValidate="txtcode"
                ToolTip="Must enter 3-4 digit card code" Text="*" ErrorMessage="Must enter 3-4 digit card code"
                ValidationExpression="\d{3,4}"></asp:RegularExpressionValidator>
        </td>
        <td >
            *(Valid CVV2,CVC2 or CID value,3 or 4 digit number on back of credit card for American
            Express)
        </td>
    </tr>
     <tr><td>&nbsp;</td></tr>
    <%--<tr style="width: 100%">
        <td style="width: 40%" >
            <asp:Label ID="lblexpiry" runat="server" Text="Expiry Date">
            </asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlMonth" runat="server" ToolTip="EnterMonth">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvMonth" runat="server" ControlToValidate="ddlMonth"
                ErrorMessage="RequiredFieldValidator" ToolTip="Select Month">*</asp:RequiredFieldValidator>
            <asp:DropDownList ID="ddlyear" runat="server" ToolTip="EnterYear">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvYear" runat="server" ControlToValidate="ddlyear"
                ErrorMessage="RequiredFieldValidator" ToolTip="Select Year">*</asp:RequiredFieldValidator>
            &nbsp; mm/yyyy</td>
    </tr>--%>
    <tr>
        <td colspan="2" >
            <asp:Button ID="btnpay" runat="server" Text="" OnClick="btnpay_Click" CausesValidation="True" CssClass="btn-proced-to-pay" />
            
        </td>
    </tr>
</table>
</div>

</asp:Content>

