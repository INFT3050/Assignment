<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="ShowCart.aspx.cs" Inherits="HMT.WebApp.UL.ShowCart" %>
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

                <!-- table to display records -->
                <asp:PlaceHolder ID="placeTable" runat="server"></asp:PlaceHolder>
            
        

            <!-- Shows all their products and the price of each item -->

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
