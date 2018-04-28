<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="HMT.WebApp.UL.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- All of the users items will be added the shopping cart -->

        <h1>Cart</h1>
     <div class="grid">
        <div class="centered listed">
            <div class="grouping" style="border-top:1px solid darkgrey;">
                <p class="itemName">Item</p>
                     Price
            </div>
            <!-- Shows all their products and the price of each item -->
            <div class="grouping">
                <img class="edit" src="<%:Session["image"]%>"/>
                <p class="itemName"><%:Session["name"]%></p>
                <p class="itemName"><%:Session["price"]%></p>
                

                <asp:Button id="rmvFromCart" runat="server" CssClass="btn removeFromCart" OnClick="rmvFromCart_Click"/>
            </div>
            <!-- Shows the total price -->
            <h2>Total: $<%:Session["total"]%></h2>

            <div class="flexContainer">
                <div class="flexRight">
                    <a href="Payment.aspx">
                    proceed to payment
                     </a>
                </div>
                
            </div>
        </div>
      </div>
        
            
        
</asp:Content>
