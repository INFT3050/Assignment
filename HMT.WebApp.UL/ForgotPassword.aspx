<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="HMT.WebApp.UL.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Centered_Form.css" />
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="pageHeading">Forgot Password</h1>
    <div class="container" style="margin-bottom:300px;">
        <div class ="inputField">
            <h2>Please enter your email address:</h2>
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Email *" CssClass="inputTxt alignVert" TabIndex="1"></asp:TextBox>
           
       </div>
            <asp:Label ID="errorLabel" runat="server"></asp:Label>
        <br />
            <asp:Button ID="submitEmail" runat="server" text="Submit" CssClass="regBtn" TabIndex="3" OnClick="submitEmail_Click"/>
    </div>
    
        
</asp:Content>
