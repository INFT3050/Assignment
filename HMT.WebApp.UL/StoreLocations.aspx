<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="StoreLocations.aspx.cs" Inherits="HMT.WebApp.UL.StoreLocations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Our stores location -->
    <h1>Find Your Nearest Store</h1>
    <div class="grid">
        <div class="centered">
            <h2>Westfield Shopping Center</h2>
            <p>
                Shop XXX/XXX Westfield Shopping Center <br />
                Cnr Northcott Dr & Park Ave, KOTARA NSW 2289 <br />
            </p>
            <p>
                02 XXXX XXXX
            </p>
            <p class="aside">
                <span class="bold">OPENING HOURS: <br /></span>
                Monday 9am - 5pm<br />
                Tuesday 9am - 5pm <br />
                Wednesday 9am - 5pm<br />
                Thursday 9am - 9pm<br />
                Friday 9am - 5pm<br />
                Closed Saturdays and Sundays

            </p>
            <div class="mapWrapper">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d22524.16138795063!2d151.71087490483944!3d-32.944761621019445!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x6b7315fd3c4ddcc9%3A0xf017d68f9f32890!2sWestfield+Kotara!5e0!3m2!1sen!2sau!4v1522993838492" style="border:0" allowfullscreen></iframe>
            </div>
            
        </div>
    </div>
</asp:Content>
