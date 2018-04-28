<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="HMT.WebApp.UL.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Contact Us</h1>
    <div class="grid">
        <div class="centered">
            <!-- Listing all the ways the we can be contacted -->
            <h2>Customer Support</h2>
            <p>
                Customer Service is available 9am - 5pm AEST Monday - Friday. <br />
                Closed Saturday, Sunday and all major public holidays.
            </p>
            <p>
                For all customer enquiries please ring XXXX-XXXX <br />
                Or send us an email at customerservice@email.com
            </p>
            <h2 class="seperate">Head Office and General Enquiries</h2>
            <p>
                AUS Fashion <br />
                address line 1 <br />
                address line 2 <br />
                PH:  XXXX-XXXX <br />
                FAX: XXXX-XXXX <br />
                EMAIL: customerservice@email.com
            </p>
        
        </div>
    </div>
    
</asp:Content>
