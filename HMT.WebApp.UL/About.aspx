<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="HMT.WebApp.UL.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- The about page shows what our company is about -->
    <h1>About us</h1>
    <div class="grid">
        <div class="centered">
            <p>Aus Fashion is committed to supporting the local community and to meeting our responsibilities to our customers, team members and suppliers. 
                We are located in the heart of Kotara Westfield providing jobs to locals and supporting new and trending fashion ideas. </p>
            <img width="600" height="400" src ="../Images/pic1.jpg" />
            <p>We started this store only this year and it has exceeded our expectations. Making jobs for local people is what we wanted and if you are looking for a career in retail then let us know!</p>
        </div>
    </div>

</asp:Content>