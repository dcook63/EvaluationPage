<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MockupGUI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="css/reset.css" rel="stylesheet" type="text/css">
    <link href="css/style.css" rel="stylesheet" type="text/css">
    <link href="css/nav.css" rel="stylesheet" type="text/css">

    <!-- Nav -->
    <section class="navigation">
        <div class="nav-container">
            <div class="brand">
                <img src="images/ksu_logo.png" id="logo" />
            </div>
        </div>
    </section>

    <!-- Header -->
    <section class="header">
    <h1 id="cms">Capstone Management System</h1>
    <br />
    <h3 id="page">Login To Continue</h3>
  </section>

    <section class="main">
    <div class="margin" style="text-align: center;">
    <asp:Table runat="server">
        <asp:TableRow BorderColor="Transparent" BorderWidth="15px">
            <asp:TableCell>
                <asp:TextBox runat="server" placeholder="Enter your KSU email"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow BorderColor="Transparent" BorderWidth="15px">
            <asp:TableCell>
                <asp:TextBox runat="server" placeholder="Enter your password"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow BorderColor="Transparent" BorderWidth="15px">
            <asp:TableCell>
                <label>   </label><button>Login</button>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
    </section>

    <!-- Footer -->
  <section class="footer">
    <p>© Copyright 2019. All Rights Reserved.</p>
  </section>

</asp:Content>
