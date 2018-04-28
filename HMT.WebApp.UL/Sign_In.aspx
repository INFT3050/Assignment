<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Sign_In.aspx.cs" Inherits="HMT.WebApp.UL.Sign_In" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--
        Page created and styled by bradley turner 
        Created         11/03/18
        Modified        13/03/18        Redesigned layout to match Register.aspx
        Allows already registered users to sign in
    -->
    

    <link rel="stylesheet" type="text/css" href="CSS/Centered_Form.css" />
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
    <script src="JS/StylisedTextbox.js"></script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="pageHeading">Sign In</h1>
    <div class="container">
        <div class="inputField"> <!-- Groups span and textbox -->
            <span class="miniHeading alignVert">Email:</span>
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Email *" CssClass="inputTxt alignVert" TabIndex="1" onfocus="reveal(this);" onblur="hide(this)"></asp:TextBox>
        </div>
        <div class="inputField">
            <span class="miniHeading alignVert">Password:</span>
            <asp:TextBox ID="pass1" runat="server" placeholder="Password *" CssClass="inputTxt alignVert" TextMode="Password" TabIndex="2" onfocus="reveal(this);" onblur="hide(this)"></asp:TextBox>
        </div>
        <div class="extLink" style="margin-top:0;"><a href="#">Forgotten your password?</a></div>
        <asp:Button ID="signIn" title="Sign In" runat="server" text="Sign In" CssClass="regBtn" TabIndex="3" OnClick="SignIn_Click"/>
        <div class="extLink"><a href="Register.aspx">New to AUS Fashion? Create an Account today!</a></div>
    </div>
</asp:Content>
