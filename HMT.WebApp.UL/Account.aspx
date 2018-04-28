<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Default.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="HMT.WebApp.UL.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/StraightBody.css" />
    <link rel="stylesheet" type="text/css" href="CSS/General.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- This page shows the current login in users details and they can edit them -->
    <h1>My Account</h1>
    <div class="grid">
        <div class="centered listed">
            <!-- Displays all the users account details from the session -->
            <h2>Account Details</h2>
            <div class="grouping" style="border-top:1px solid darkgrey;">
                <span class="textLbl">First Name</span>
                <asp:TextBox id="firstName" runat="server" CssClass="accTextBox" ReadOnly="false"></asp:TextBox>
                <img class="edit" src="Images/edit.png"/>
            </div>
            <div class="grouping">
                <span class="textLbl">Last Name</span>
                <asp:TextBox id="lName" runat="server" CssClass="accTextBox" ReadOnly="false"></asp:TextBox>
                <img class="edit" src="Images/edit.png"/>
            </div>
            <div class="grouping">
                <span class="textLbl">Email</span>
                <asp:TextBox id="eMail" runat="server" CssClass="accTextBox" ReadOnly="false"></asp:TextBox>
                <img class="edit" src="Images/edit.png"/>
            </div>
            <div class="grouping">
                <span class="textLbl">Address</span>
                <asp:TextBox id="address" runat="server" CssClass="accTextBox" ReadOnly="false"></asp:TextBox>
                <img class="edit" src="Images/edit.png"/>
            </div>
            <div class="grouping">
                <span class="textLbl">Password</span>
                <asp:TextBox id="password" runat="server" CssClass="accTextBox" ReadOnly="false"></asp:TextBox>
                <img class="edit" src="Images/edit.png"/>
            </div>

            <asp:Button ID="updateChanges" title="Update Changes" runat="server" text="Update Changes" CssClass="regBtn" TabIndex="3" OnClick="updateChanges_Click"/>
            


            <h2>Current Transactions</h2>
            <p>There are no current transactions</p>
            <asp:Table ID="currentTransactions" runat="server"></asp:Table> <!-- insert ASP.NET code to list current transactions that are NOT completed, ie waiting on delivery -->
        
            
            <h2>Transaction History</h2>
            <p>You have no previous transactions</p>
            <asp:Table ID="transHistory" runat="server"></asp:Table> <!-- insert ASP.NET code to list previous transactions  -->
        </div>
    </div>
</asp:Content>
