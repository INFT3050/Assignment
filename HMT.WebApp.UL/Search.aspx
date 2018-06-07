<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="HMT.WebApp.UL.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Default.css" />
    <link rel="stylesheet" type="text/css" href="CSS/Centered_Form.css" />
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <!-- Displays all the Mens Shirts -->   

    <h1>Search Results for <%:Session["description"]%></h1>


    <div>
        <!-- table to display records -->
        <asp:PlaceHolder ID="placeTable" runat="server"></asp:PlaceHolder>
    </div>

</asp:Content>