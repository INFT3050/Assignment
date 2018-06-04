<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_EditCustomer.aspx.cs" Inherits="HMT.WebApp.UL.Admin_EditCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script src="JS/Validate.js"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
    
    
    
    <div style="margin-left:20px; margin-top:20px">
        <!-- Update and delete section for editing customer records -->
            <h3>Update/Delete Customer:</h3>
            <asp:TextBox ID="search" runat="server" placeholder="Enter ID" CssClass="inputTxt alignVert" onfocus="reveal(this);" onblur="hide(this)"></asp:TextBox>
            <asp:Button id="searchID" runat="server" Text="Go" OnClick="searchID_Click"/>
            <asp:Label CssClass="msgLbl" ID="msgLbl" runat="server" BorderStyle="None"></asp:Label>
        
    </div>
    <br />
    <div id="hide" runat="server" style="margin-left:20px;">  <!-- Hidden div for editing customers when id entered. -->
        <asp:TextBox CssClass="inputTxt" ID="first" runat="server" TabIndex="1"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="last" runat="server" TabIndex="2"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="email" runat="server" TabIndex="3"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="address" runat="server" TabIndex="4"></asp:TextBox>
        <asp:TextBox CssClass="inputTxt" ID="suspended" runat="server" TabIndex="5" ReadOnly="true"></asp:TextBox>
        <asp:Button id="update" runat="server" Text="Update" OnClientClick="return validate_update()" OnClick="update_Click"/>
        <asp:Button id="delete" runat="server" Text="Suspend" OnClick="suspend_Click"/>

    </div>

    <div style="margin-left:20px; margin-top:60px">
        <div>
            <!-- table to display records -->
            <asp:PlaceHolder ID="placeTable" runat="server"></asp:PlaceHolder>
        </div>
        
    </div>

</asp:Content>
