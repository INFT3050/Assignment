<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="HMT.WebApp.UL.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- This page allows the user to page for the products that were in the shopping cart -->
    <h1>Payment</h1>
    <div class="grid">
        <div class="centered listed">
            <p></p>
            

                <form action="Default.aspx">
                  <fieldset>
                    <legend>Personal information:</legend>
                    First name:<br>
                    <input type="text" name="firstname" value="Dean" required><br>
                    Last name:<br>
                    <input type="text" name="lastname" value="Morton" required><br><br>
                  </fieldset>

                    <fieldset>
                    <legend>Delivery Address:</legend>
                    Street number<br>
                    <input type="number" name="street"  required><br>
                    Street Name<br>
                    <input type="text" name="name" required><br>
                      Town<br>
                    <input type="text" name="town" required><br>
                    Post Code
                    <br>
                    <input type="number" name="postCode" required><br>
                         <br>
      
                  </fieldset>

                     <fieldset>
                    <legend>Credit Card information:</legend>
                    Card Number:<br>
                    <input type="number" name="cardNumber"  required><br>
                    Expiration Date:<br>
                    <input type="date" name="date" required><br>
                      CVV number<br>
                    <input type="number" name="date" required><br>    
                         <br>

                         Your total is: $<%:Session["total"]%>
                    <input type="submit" value="Pay Now" >
                  </fieldset>
                </form>
            <br />
            <br />
                    
           
        </div>
    </div>
</asp:Content>
