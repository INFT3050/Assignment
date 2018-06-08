<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_EditProducts.aspx.cs" Inherits="HMT.WebApp.UL.Admin_EditProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
    

    <asp:Panel runat="server" DefaultButton="searchID"> 
    <div style="margin-left:20px; margin-top:20px">
        <!-- Update and delete section for editing customer records -->
            <h3>Update/Suspend Products:</h3>
            <asp:TextBox ID="search" runat="server" placeholder="Enter ID" CssClass="inputTxt alignVert" onfocus="reveal(this);" onblur="hide(this)"></asp:TextBox>
            <asp:Button id="searchID" runat="server" Text="Go" OnClick="searchID_Click"/>
            <asp:Label CssClass="msgLbl" ID="msgLbl" runat="server" BorderStyle="None"></asp:Label>
    
    </div> </asp:Panel>
    <br />
    <asp:Panel runat="server" DefaultButton="update"> 
    <div id="hide" runat="server" style="margin-left:20px;">  <!-- Hidden div for editing products when id entered. -->
        <asp:TextBox CssClass="inputTxt" ID="name" runat="server" TabIndex="1"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="description" runat="server" TabIndex="2"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="size" runat="server" TabIndex="3"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="price" runat="server" TabIndex="4"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="image" runat="server" TabIndex="5"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="gender" runat="server" TabIndex="6"></asp:TextBox>
        <asp:Button id="update" runat="server" Text="Update" OnClick="update_Click"/>
        <asp:Button id="suspend" runat="server" Text="Suspend" OnClick="suspend_Click"/>
    
    </div> </asp:Panel>

    <div style="margin-left:20px; margin-top:60px">
        <div>
            <!-- table to display records -->
            <asp:PlaceHolder ID="placeTable" runat="server"></asp:PlaceHolder>
        </div>
        
    </div>


    <!-- add products -->
    <div >
        <h2> Add a Product </h2>
        <asp:TextBox CssClass="inputTxt" ID="addName" placeholder="Name" runat="server" TabIndex="1"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="addDescription" placeholder="Description" runat="server" TabIndex="2" TextMode="MultiLine"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="addSize" placeholder="Size" runat="server" TabIndex="3"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="addPrice" placeholder="Price" runat="server" TabIndex="4"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="addImage" Text="Images/" runat="server" TabIndex="5"></asp:TextBox>
        <asp:DropDownList ID="addGender" runat="server">
            <asp:ListItem Text="Male" Value="M"></asp:ListItem>
            <asp:ListItem Text="Female" Value="F"></asp:ListItem>
        </asp:DropDownList>
        <asp:Button id="insert" runat="server" Text="Insert" OnClick="insert_Click"/>
    </div>



</asp:Content>