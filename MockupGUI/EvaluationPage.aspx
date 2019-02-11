<%@ Page Title="Evaluation Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EvaluationPage.aspx.cs" Inherits="MockupGUI.EvaluationPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="css/reset.css" rel="stylesheet" type="text/css">
    <link href="css/style.css" rel="stylesheet" type="text/css">
    <link href="css/nav.css" rel="stylesheet" type="text/css">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="js/nav.js"></script>

    <!-- Nav -->
    <section class="navigation">
        <div class="nav-container">
            <div class="brand">
                <img src="images/ksu_logo.png" id="logo" />
            </div>
            <nav>
                <div class="nav-mobile"><a id="nav-toggle" href="#!"><span></span></a></div>
                <ul class="nav-list">
                    <li><a href="#!" id="nav-home">Group 5</a></li>
                    <li><a href="#!">Group 6</a></li>
                    <li><a href="#!">Group 7</a></li>
                    <li>
                        <a href="#!">Group 8</a>
                        <ul class="nav-dropdown">
                            <li><a href="#!">Sponsor Evaluation</a></li>
                            <li><a href="#!">Student Evaluation</a></li>
                            <li><a href="EvaluationPage.aspx">Professor Evaluation</a></li>
                        </ul>
                    </li>
                </ul>
            </nav>
        </div>
    </section>

    <!-- Header -->
    <section class="header">
    <h1 id="cms">Capstone Management System</h1>
    <br />
    <h3 id="page">Professor Review</h3>
  </section>
    <!-- Main -->
    <section class="main">
    <div class="margin" style="text-align: center;">
        <br />
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" text="Enter Team Member's Name"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" placeholder="Last, First"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow Height="30"></asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Rate your team members ability to research the topic"></asp:Label>
                </asp:TableCell>

                <asp:TableCell></asp:TableCell>

                <asp:TableCell>
                    <asp:dropdownlist runat="server" id="evalQ1">
                        <asp:ListItem Text="1 - Very Poor"></asp:ListItem>
                        <asp:ListItem Text="2 - Poor"></asp:ListItem>
                        <asp:ListItem Text="3 - OK"></asp:ListItem>
                        <asp:ListItem Text="4 - Very Good"></asp:ListItem>
                        <asp:ListItem Text="5 - Excellent"></asp:ListItem>
                    </asp:dropdownlist>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow Height="10"></asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Rate your team members ability to communicate with the group"></asp:Label>
                </asp:TableCell>

                <asp:TableCell></asp:TableCell>

                <asp:TableCell>
                    <asp:dropdownlist runat="server" id="evalQ2">
                        <asp:ListItem Text="1 - Very Poor"></asp:ListItem>
                        <asp:ListItem Text="2 - Poor"></asp:ListItem>
                        <asp:ListItem Text="3 - OK"></asp:ListItem>
                        <asp:ListItem Text="4 - Very Good"></asp:ListItem>
                        <asp:ListItem Text="5 - Excellent"></asp:ListItem>
                    </asp:dropdownlist>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow Height="30"></asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    <button>Submit</button> 
                </asp:TableCell>
                <asp:TableCell>
                    <button>Add Team Member</button> 
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
    </div>
    </section>

    <!-- Footer -->
  <section class="footer">
    <p>© Copyright 2019. All Rights Reserved.</p>
  </section>
</asp:Content>