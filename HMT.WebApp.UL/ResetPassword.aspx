<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="HMT.WebApp.UL.ResetPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Centered_Form.css" />
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="pageHeading">Forgot Password</h1>
    <div class="container" style="margin-bottom:300px;">
            
        <h2>Please enter your new password:</h2>
            <div class="inputField">
                <asp:TextBox ID="password1" runat="server" placeholder="New Password *" CssClass="inputTxt alignVert" TabIndex="1" TextMode="Password"></asp:TextBox>
            </div>
            
            <div class="inputField">
                <asp:TextBox ID="password2" runat="server" placeholder="Confirm Password *" CssClass="inputTxt alignVert" TabIndex="1" TextMode="Password"></asp:TextBox>
            </div>
            <asp:Label ID="errorLabel" runat="server"></asp:Label>
        <br />
            <asp:Button ID="submitPass" runat="server" text="Submit" CssClass="regBtn" TabIndex="3" OnClick="submitPass_Click"/>
    </div>
    
        
</asp:Content>