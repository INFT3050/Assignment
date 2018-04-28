<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Help.aspx.cs" Inherits="HMT.WebApp.UL.Help" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <!-- Where the users can contact us will any questions -->
    <h1>Help and Support</h1>
        <div class="grid">
            <div class="centered">

                    <h3>New to AUS Fashion?</h3>
                    <p>Don't worry! If you are a new customer, make sure you start by <b>creating an <a class="link" href="../Register.aspx">account</a></b>. 
                       This will ensure you keep up to date with any emails or specials we may have. It will also allow you to checkout much faster. </p>
                    
                    <h3>What is your return policy?</h3>
                    <p>For our return policy please see our page on <a class="link" href="../ReturnPolicy.aspx">returns and refunds</a>.</p>

                    <h3>Need more help?</h3>
                    <p>If you have any questions please feel free to email us at ausfashion@XXX.com and our team will help you reslove your issue. At AUS Fashion we pride ourselves on our customer service and 
                       appreciate any feedback you may have.</p>
            </div>
        </div>
        
</asp:Content>
