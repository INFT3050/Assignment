<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="HMT.WebApp.UL.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Items can be added to the whishlists and then added to the shopping cart if they want -->
    <h1>Transaction History</h1>
    <div>
        <asp:PlaceHolder ID="placeTable" runat="server"></asp:PlaceHolder>
    </div>

</asp:Content>
