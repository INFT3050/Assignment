<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_ViewTransactions.aspx.cs" Inherits="HMT.WebApp.UL.Admin_ViewTransactions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
    <div>
        <asp:PlaceHolder ID="placeTable" runat="server"></asp:PlaceHolder>
    </div>
</asp:Content>