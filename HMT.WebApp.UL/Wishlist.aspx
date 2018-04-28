<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Wishlist.aspx.cs" Inherits="HMT.WebApp.UL.Wishlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Items can be added to the whishlists and then added to the shopping cart if they want -->
    <h1>Wishlist</h1>
    <div class="grid">
        <div class="centered listed">
            <div class="grouping" style="border-top:1px solid darkgrey;">
                <p class="itemName">Item</p>
                Add |
                Remove
            </div>
            <div class="grouping">
                <img class="edit" src="Images/wishlist1.jpg"/>
                <p class="itemName">Men's Black Bowtie</p>
                <p class="price">$9.95</p>
                <asp:Button id="addToCart" runat="server" CssClass="btn addToCart"/>
                <asp:Button id="rmvWishlist" runat="server" CssClass="btn removeFromCart"/>
            </div>
            <div>
                Add all to Cart | Clear all from wishlist
            </div>
            
        </div>
    </div>
</asp:Content>
