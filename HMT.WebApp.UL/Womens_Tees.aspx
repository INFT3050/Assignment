<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Womens_Tees.aspx.cs" Inherits="HMT.WebApp.UL.Womens_Tees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- All of the womens shirts are displayed -->

    <h1>Women's</h1>
    <div class="productContent">
        <div class="startCol">
            <div class="columnHeading">
                <h3>Ladies Dress</h3>
            </div>
            <img style="width:auto; height:400px" src="Images/image1.jpg"/>
            <asp:Button id="Button5" runat="server" CssClass="btn arrowbtn" OnClick="btncheckproduct1"/>
            <p class="price">$99.95</p>
            <asp:Button id="product1AddToCart" runat="server" CssClass="btn addToCart" OnClick="btnAddProduct1"/>
        </div>


        <div class="column">
            <div class="columnHeading">
                <h3>Ladies Striped Sleeve</h3>
            </div>
              <img style="width:310px; height:400px" src="Images/image4.jpg" onclick="btncheckproduct2"/>
              <asp:Button id="Button4" runat="server" CssClass="btn arrowbtn" OnClick="btncheckproduct2"/>
                        
            <p class="price">$39.95</p>
            <asp:Button id="Button1" runat="server" CssClass="btn addToCart" OnClick="btnAddProduct2"/>
        </div>
    </div>
</asp:Content>