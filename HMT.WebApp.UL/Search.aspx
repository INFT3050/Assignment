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


    <%-- --<div class="productContent">
        <div class="startCol">
            <div class="columnHeading">
                <h3>Men's Green Striped Tee</h3>
            </div>
            <img src="Images/image7.jpg"/>
            <asp:Button id="Button5" runat="server" CssClass="btn arrowbtn" OnClick="btncheckproduct1"/>
            <p class="price">$29.95</p>
            <asp:Button id="product1AddToCart" runat="server" CssClass="btn addToCart" OnClick="btnAddProduct1"/>
        </div>


        <div class="column">
            <div class="columnHeading">
                <h3>Men's Blue Jacket</h3>
            </div>
              <img style="width:auto; height:400px" src="Images/image5.jpg" onclick="btncheckproduct2"/>
              <asp:Button id="Button4" runat="server" CssClass="btn arrowbtn" OnClick="btncheckproduct2"/>
                        
            <p class="price">$49.95</p>
            <asp:Button id="Button1" runat="server" CssClass="btn addToCart" OnClick="btnAddProduct2"/>
        </div>
            

        <div class="column">
            <div class="columnHeading">
                <h3>Plain White Tee</h3>
            </div>
            <img style="width:auto; height:400px" src="Images/image8.jpg"/>
            <asp:Button id="Button3" runat="server" CssClass="btn arrowbtn" OnClick="btncheckproduct3"/>
            <p class="price">$19.95</p>
            <asp:Button id="Button2" runat="server" CssClass="btn addToCart" OnClick="btnAddProduct3"/>
        </div>
    </div>--%>
</asp:Content>