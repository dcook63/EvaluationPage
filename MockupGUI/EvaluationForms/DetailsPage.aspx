<%@ Page Title="Details Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsPage.aspx.cs" Inherits="MockupGUI.DetailsPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="/css/reset.css" rel="stylesheet" type="text/css">
    <link href="/css/style.css" rel="stylesheet" type="text/css">
    <link href="/css/nav.css" rel="stylesheet" type="text/css">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="/js/nav.js"></script>

    <!-- Nav -->
    <section class="navigation">
        <div class="nav-container">
            <div class="brand">
                <img src="/images/ksu_logo.png" id="logo" />
            </div>
            <nav>
                <div class="nav-mobile"><a id="nav-toggle" href="#!"><span></span></a></div>
                <ul class="nav-list">
                    <li><a href="#!" id="nav-home">Group 5</a></li>
                    <li><a href="#!">Group 6</a></li>
                    <li><a href="#!">Group 7</a></li>
                    <li>
                        <a href="#!">Evaluation Form</a>
                        <ul class="nav-dropdown">
                            <li><a href="SponsorReview.aspx">Sponsor Evaluation</a></li>
                            <li><a href="PeerReview.aspx">Peer Evaluation</a></li>
                            <li><a href="PresentationReview.aspx">Presentation Evaluation</a></li>
                            <li><a href="EvaluationReport.aspx">Evaluation Report</a></li>
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
    <h3 runat="server" id="detailHeader">Detail View</h3>
    </section>

    <!-- Main -->
    <div class="container" style="padding-top: 15px; padding-bottom: 80px">
        <button runat="server" onserverclick="Return">Back</button>
        <div style="margin-top:10px">
            <asp:GridView runat="server" ID="groups" AlternatingRowStyle-BackColor="white" HeaderStyle-BorderColor="black" HeaderStyle-BackColor="#feba18" AutoGenerateColumns="False" ForeColor="Black" CellSpacing="5">
            </asp:GridView>
        </div>
     </div>
    

    <!-- Footer -->
  <section class="footer">
    <p>© Copyright 2019. All Rights Reserved.</p>
  </section>
</asp:Content>