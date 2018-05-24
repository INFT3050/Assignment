<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HMT.WebApp.UL.Register" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- 
        Page created and styled by bradley turner
        Created         12/03/2018
        Modified        13/03/2018      Developed page to be styled with dynamic textboxes, linked to StylisedTextbox.js
        The user can create an account which will be stored as a session
    -->

    <link rel="stylesheet" type="text/css" href="CSS/Centered_Form.css"/>
    <script src="JS/StylisedTextbox.js"></script> <!-- links JS file that dynamically styles all textboxes in this file -->
    <script src="JS/Validate.js"></script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="pageHeading">Create an Account</h1>
    <div class="container">
        
        <div class="inputField"><!-- Groups together span and textbox for desired dynamic JS styling -->
            <span class="miniHeading alignVert">First Name:</span>
            <asp:TextBox ID="fname" runat="server" placeholder="First Name *" CssClass="inputTxt alignVert" TabIndex="1" onfocus="reveal(this);" onblur="hide(this)"></asp:TextBox>
            <span class="errorMsg alignVert">First Name</span>
        </div>
        <div class="inputField">
            <span class="miniHeading alignVert">Surname:</span>
            <asp:TextBox ID="lname" runat="server" placeholder="Surname *" CssClass="inputTxt alignVert" TabIndex="2" onfocus="reveal(this);" onblur="hide(this)"></asp:TextBox>
            <span class="errorMsg alignVert">Surname</span>
        </div>
        <div class="inputField">
            <span class="miniHeading alignVert">Email:</span>
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Email *" CssClass="inputTxt alignVert" TabIndex="3" onfocus="reveal(this);" onblur="hide(this)"></asp:TextBox>
            <span class="errorMsg alignVert">Email</span>
        </div>
        <div class="inputField">
            <span class="miniHeading alignVert">Address:</span>
            <asp:TextBox ID="address" runat="server" placeholder="Address *" CssClass="inputTxt alignVert" TabIndex="3" onfocus="reveal(this);" onblur="hide(this)"></asp:TextBox>
            <span class="errorMsg alignVert">Address</span>
        </div>
        <div class="inputField">
            <span class="miniHeading alignVert">Password:</span>
            <asp:TextBox ID="pass1" runat="server" placeholder="Password *" CssClass="inputTxt alignVert" TextMode="Password" TabIndex="4" onfocus="reveal(this);" onblur="hide(this)"></asp:TextBox>
            <span class="errorMsg alignVert">Password</span>
        </div>
        <div class="inputField">
            <span class="miniHeading alignVert">Confirm Password:</span>
            <asp:TextBox ID="pass2" runat="server" placeholder="Confirm Password *" CssClass="inputTxt alignVert" TextMode="Password" TabIndex="5" onfocus="reveal(this);" onblur="hide(this)"></asp:TextBox>
            <span class="errorMsg alignVert">Confirm Password</span>
        </div>
        <asp:Button ID="register" runat="server" text="Register" TabIndex="6" OnClientClick="return validate_register()" OnClick="register_Click"/>
        <div class="link" tabindex="7"><a href="Sign_In.aspx">Already have an Account?</a></div>
    </div>
</asp:Content>
