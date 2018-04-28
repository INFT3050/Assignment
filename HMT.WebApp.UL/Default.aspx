<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HMT.WebApp.UL.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/home.css" />
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!-- The landing page for all the customers  -->
    <div class="grid">
        <div class="main bigImg wholeRow">
            <!-- Text over the image -->
            <div class="textOverlay">
                <p>
                    SALE!<br />
                    Up to 50% Off!*
                </p>
                *Limited time only
            </div>
            <div class="wrapperButton shopWomen">
                <a href="Womens_Tees.aspx">
                    <!-- Link to all Womens Clothes -->
                <div class="button" >
                Women's Clothing <b>&gt;</b>
                    </div>
                    </a>
            </div>
            <div class="wrapperButton shopMen">
                <!-- Link to all Mens Clothes -->
                <a href="MensTees.aspx">
                <div class="button">
                Men's Clothing <b>&gt;</b>
                    </div>
                    </a>
            </div>
        </div>
        <div class="navigation wholeRow">
            <div class="advLink">
                These will
            </div>
            <div class="advLink">
                be links
            </div>
            <div class="advLink">
                to database
            </div>
             <div class="advLink">
                queries
            </div>
        </div>
        
        <div class="item">
            <img class="specials" src="../Images/image1.jpg" />
            <p class="caption">Dress to Impress</p>
        </div>
        <div class="item">
            <img class="specials" src="../Images/image2.jpg" />
            <p class="caption">Autumn Essentials</p>
        </div>
        <div class="item">
            <img class="specials" src="../Images/image3.jpg" />
            <p class="caption">Denim Studio</p>
        </div>
        <div class="item">
            <img class="specials" src="../Images/image4.jpg" />
            <p class="caption">Stripe Hype</p>
        </div>
        <div class="item">
            <img class="specials" src="../Images/image5.jpg" />
            <p class="caption">Layer Up</p>
        </div>
        <div class="item">
            <img class="specials" src="../Images/image7.jpg" />
            <p class="caption">Tees</p>
        </div>
        <div class="label wholeRow">
            again links to database queries
        </div>
        <div class="toTop wholeRow">
            <a class="fillParent" href="#top">Return to Top</a>
        </div>
        
    </div>
</asp:Content>
