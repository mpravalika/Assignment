<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td>Empid</td>
        <td class="auto-style6">
            <asp:TextBox ID="txtempid" runat="server" ClientIDMode="Static"></asp:TextBox> 
        </td>
         <td>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="no blank" ControlToValidate="txtempid"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>password</td>
        <td class="auto-style6">
            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox> 
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="no blank" ControlToValidate="txtpwd"></asp:RequiredFieldValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="Purple"></asp:Label>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Button ID="btnLogin" runat="server" Text="Login" Height="28px" OnClick="btnLogin_Click" OnClientClick="return validate();"/> 
        </td>
        <td></td>
    </tr>
</table> 
</asp:Content>
