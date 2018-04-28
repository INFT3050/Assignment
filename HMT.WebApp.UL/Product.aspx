<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="HMT.WebApp.UL.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Where all the porducts will be added -->
    <h1><%:Session["name"]%></h1>
    <div class="grid">
        <div class="centered">
        
        <img style="height:auto; width:auto" class="edit" src="<%:Session["image"]%>"/>
            <br />
        <asp:Label id="currentProduct" runat="server"><%:Session["name"]%></asp:Label>
        <p class="itemName">$<%:Session["price"]%></p>
            <p><%:Session["description"]%></p>

        <asp:Button id="Button1" runat="server" CssClass="btn addToCart" OnClick="addtoCart"/>

      </div>
    </div>
    
</asp:Content>