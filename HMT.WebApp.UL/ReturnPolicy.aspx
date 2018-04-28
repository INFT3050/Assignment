<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="ReturnPolicy.aspx.cs" Inherits="HMT.WebApp.UL.ReturnPolicy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Our return policy for all our items -->
    <h1>Returns and Exchanges</h1>
    <div class="grid">
        <div class="centered">
            <h2>Change of Mind Returns</h2>
            <p>
                Customer Service is available 9am - 5pm AEST Monday - Friday. <br />
                Closed Saturday, Sunday and all major public holidays.
            </p>
            <p>
                For all customer enquiries please ring XXXX-XXXX <br />
                Or send us an email at customerservice@email.com
            </p>
            <h2 class="seperate">Faulty Product Returns</h2>
            <p>
                AUS Fashion <br />
                address line 1 <br />
                address line 2 <br />
                PH:  XXXX-XXXX <br />
                FAX: XXXX-XXXX <br />
                EMAIL: customerservice@email.com
            </p>
            <h2 class="seperate">Returns Process</h2>
            <p>We have a 30 day return policy where we will refund for a change of mind purchase. The following procedure is in place to ensure you have the right to a refund of your product:
                <ol>
                    <li>Keep any receipts or proof of purchases of the product</li>
                    <li>Come into our store and speak with one of our staff members</li>
                    <li>They will make the refund on the spot and the amount should return to your account within 24 hours</li>
                </ol>
            </p>

            <h2 class="seperate">Returns Process (Online)</h2>
            <p>For a purchase made online, you can follow the previous process or if you can't make it to the store, that's fine! Follow our online 30 day return policy for a refund:
                <ol>
                    <li>Keep any receipts or proof of purchases of the product</li>
                    <li>Send an email to our customer service email <i>customerservice@email.com</i> explaining why you would like to return your item</li>
                    <li>Your request will be processed and if accepted then we will send you an address to ship your items too. You will have to pay for postage and handling</li>
                    <li>Once recieved and finalised, we will return the amount to your account within 24 hours</li>
                </ol>
            </p>
        </div>
    </div>
    
</asp:Content>
